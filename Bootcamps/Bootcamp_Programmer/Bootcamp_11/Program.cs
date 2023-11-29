using System.Diagnostics;

const int N = 1000; //размер матрицы
const int THREADS_NUMBER = 10;

int[,] serialMulRes = new int[N,N]; // результат умножения матриц в однопотке
int[,] threadMulRes = new int[N,N]; // результат параллельного умножения матриц

int[,] firstMatrix = MatrixGenerator(N, N);
int[,] secondMatrix = MatrixGenerator(N, N);

Stopwatch sw = new Stopwatch();
sw.Start();
SerialMatrixMul(firstMatrix, secondMatrix);
sw.Stop();
Console.WriteLine($"SerialMatrixMul: {sw.ElapsedMilliseconds}");

sw.Reset();
sw.Start();
PrepareParallelMatrixMul(firstMatrix, secondMatrix);
sw.Stop();
Console.WriteLine($"PrepareParallelMatrixMul: {sw.ElapsedMilliseconds}");

Console.WriteLine(EqualityMatrix(serialMulRes, threadMulRes));

int[,] MatrixGenerator (int rows, int columns)
{
    Random _rand = new Random();
    int[,] res = new int[rows, columns];
    for (int i = 0; i < res.GetLength(0); i++)
    {
        for (int j = 0; j < res.GetLength(1); j++)
        {
            res[i,j] = _rand.Next(-100, 100);
        }
    }
    return res;
}

void SerialMatrixMul(int[,] a, int[,] b)
{
    if (a.GetLength(1) != b.GetLength(0)) throw new Exception("Нельзя умножать такие матрицы");
    for (int i = 0; i < a.GetLength(0); i++)
    {
        for (int j = 0; j < b.GetLength(1); j++)
        {
            for (int k = 0; k < b.GetLength(0); k++)
            {
                serialMulRes[i,j] += a[i,k]*b[k, j];
            }
        }
    }

}

void PrepareParallelMatrixMul(int[,] a, int[,] b)
{
    if (a.GetLength(1) != b.GetLength(0)) throw new Exception("Нельзя умножать такие матрицы");
    int eachThreadCalc = N / THREADS_NUMBER;
    var threadsList = new List<Thread>();
    for (int i = 0; i < THREADS_NUMBER; i++)
    {
        int startPos = i * eachThreadCalc;
        int endPos = (i+1) * eachThreadCalc;
        // если поток последний
        if (i == THREADS_NUMBER-1) endPos = N;
        threadsList.Add(new Thread(() => ParallelMatrixMul(a, b, startPos, endPos)));
        threadsList[i].Start();
    }
    for (int i = 0; i < THREADS_NUMBER; i++)
    {
        threadsList[i].Join();
    }
}

void ParallelMatrixMul(int[,] a, int[,] b, int startPos, int endPos)
{
    for (int i = startPos; i < endPos; i++)
    {
        for (int j = 0; j < b.GetLength(1); j++)
        {
            for (int k = 0; k < b.GetLength(0); k++)
            {
                threadMulRes[i,j] += a[i,k]*b[k, j];
            }
        }
    }
}

bool EqualityMatrix (int[,] firstMatrix, int[,] secondMatrix)
{
    bool res = true;

    for (int i = 0; i < firstMatrix.GetLength(0); i++)
    {
        for (int j = 0; j < firstMatrix.GetLength(1); j++)
        {
            res = res && (firstMatrix[i,j] == secondMatrix[i,j]);
        }
    }
    return res;
}