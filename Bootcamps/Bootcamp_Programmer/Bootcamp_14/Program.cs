using System;
using System.Linq;
using System.Resources;
using System.Threading;

const int THREADS_NUMBER = 4;
const int N = 100000;
Random rand = new Random();
object locker = new object();
// int[] array = { -10, -5, -9, 0, 2, 5, 1, 3, 1, 0, 1 };
// int[] sortedArray = CountingSortExtended(array);
int[] resSerial = new int[N].Select(r => rand.Next(0, 5)).ToArray();
int[] resParallel = new int[N];

Array.Copy(resSerial, resParallel, N);

CountingSortExtended(resSerial);
PrepairParalleCountingSorting(resParallel);
Console.WriteLine(EqualityMatrix(resSerial, resParallel));
// System.Console.WriteLine(string.Join(", ", resParallel));
// System.Console.WriteLine(string.Join(", ", resSerial));

void PrepairParalleCountingSorting(int[] inputArray)
{
    int max = inputArray.Max();
    int min = inputArray.Min();

    int offset = -min;
    int[] counters = new int[max + offset + 1];

    int eachThreadCalc = N / THREADS_NUMBER;
    var threadsParall = new List<Thread>();

    for (int i = 0; i < THREADS_NUMBER; i++)
    {
        int startPos = i * eachThreadCalc;
        int endPos = (i + 1) * eachThreadCalc;
        if (i == THREADS_NUMBER - 1) endPos = N;
        threadsParall.Add(new Thread(() => CountingSortParallel(inputArray, counters, offset, startPos, endPos)));
        threadsParall[i].Start();
    }

    foreach (var thread in threadsParall)
    {
        thread.Join();
    }

    int index = 0;

    for (int i = 0; i < counters.Length; i++)
    {
        for (int j = 0; j < counters[i]; j++)
        {
            inputArray[index] = i - offset;
            index++;
        }
    }
}

void CountingSortParallel (int[] inputArray, int[] counters, int offset, int startPos, int endPos)
{
    for (int i = startPos; i < endPos; i++)
        {
            lock (locker)
            {
                counters[inputArray[i]+ offset]++;
            }
        }
}

void CountingSortExtended(int[] inputArray)
{
    int max = inputArray.Max();
    int min = inputArray.Min();

    int offset = -min;
    int[] counters = new int[max+offset+1];

    for (int i = 0; i < inputArray.Length; i++)
    {
        counters[inputArray[i]+ offset]++;
    }

    int index = 0;

    for (int i = 0; i < counters.Length; i++)
    {
        for (int j = 0; j < counters[i]; j++)
        {
            inputArray[index] = i - offset;
            index++;
        }
    }
}

bool EqualityMatrix (int[] firstMatrix, int[] secondMatrix)
{
    bool res = true;

    for (int i = 0; i < firstMatrix.GetLength(0); i++)
    {
            res = res && (firstMatrix[i] == secondMatrix[i]);
    }
    return res;
}


