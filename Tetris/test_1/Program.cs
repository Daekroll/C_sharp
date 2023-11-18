// using System.ComponentModel;
// using System.Runtime.InteropServices;

// Console.CursorVisible = false;
// char [,] map = 
// {
//     {'#', '#', '#', '#', '#', '#', '#', '#', '#', '#', '#', '#', '#', '#', '#', '#', '#', '#', '#', '#', '#', '#', '#'},
//     {'#', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', '#'},
//     {'#', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', '#'},
//     {'#', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', '#'},
//     {'#', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', '#'},
//     {'#', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', '#'},
//     {'#', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', '#'},
//     {'#', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', '#'},
//     {'#', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', '#'},
//     {'#', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', '#'},
//     {'#', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', '#'},
//     {'#', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', '#'},
//     {'#', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', '#'},
//     {'#', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', '#'},
//     {'#', '#', '#', '#', '#', '#', '#', '#', '#', '#', '#', '#', '#', '#', '#', '#', '#', '#', '#', '#', '#', '#', '#'}
// };

// char [,] oShape = 
// {
//     {'#', '#'},
//     {'#', '#'},
// };

// char [,] iShape = 
// {
//     {'#'},
//     {'#'},
//     {'#'},
//     {'#'},
// };

// char [,] lShape = 
// {

//     {'#', '#', '#'},
//     {'#', ' ', ' '},
// };

// char [,] jShape = 
// {

//     {'#', '#', '#'},
//     {' ', ' ', '#'},
// };

// char [,] zShape = 
// {
//     {'#', '#', ' '},
//     {' ', '#', '#'},
// };

// char [,] sShape = 
// {
//     {' ', '#', '#'},
//     {'#', '#', ' '},
// };

// char [,] tShape = 
// {
//     {' ', ' ', ' '},
//     {'#', '#', '#'},
//     {' ', '#', ' '},
// };

// bool clear = true;
// int elemX = 1, elemY = 10;
// // int number = new Random().Next(1, 8);
// while (clear)
// {
//     Console.SetCursorPosition(30, 1);
//     Console.WriteLine("Score: ");
//     Console.SetCursorPosition(30, 2);
//     Console.WriteLine("Next element:");
//     int number = new Random().Next(1, 8);
//     switch (number)
//     {
//         case 1:
//             elemX = 1;
//             elemY = new Random().Next(1, map.GetLength(1) - 3);
//             drowMap(map);


//             while (map[elemX + 4, elemY] != '#')
//             {
//                 drowMap(map);
//                 Console.SetCursorPosition(elemY, elemX);
//                 drowElem(iShape, elemX, elemY);
//                 Thread.Sleep(200);
//                 elemX++;
//                 ConsoleKeyInfo charKey = Console.ReadKey();
//                 switch (charKey.Key)
//                 {
//                     case ConsoleKey.LeftArrow:
//                         if (map[elemX, elemY - 1] != '#' && map[elemX + 1, elemY - 1] != '#' && map[elemX + 2, elemY - 1] != '#' && map[elemX + 3, elemY - 1] != '#' )
//                         {
//                             elemY--;
//                         }
//                         break;
//                     case ConsoleKey.RightArrow:
//                         if (map[elemX, elemY + 1] != '#' && map[elemX + 1, elemY + 1] != '#' && map[elemX + 2, elemY + 1] != '#' && map[elemX + 3, elemY + 1] != '#' )
//                         {
//                             elemY++;
//                         }
//                         break;
//                     case ConsoleKey.Escape:
//                         clear = false;
//                         break;
//                 }
//             }

//             map[elemX, elemY] = '#';
//             map[elemX + 3, elemY] = '#';
//             map[elemX + 1, elemY] = '#';
//             map[elemX + 2, elemY] = '#';
//             for (int i = 1; i < map.GetLength(1) - 2; i++)
//             {
//                 if (map[1, i] == '#')
//                 {
//                     clear = false;
//                 }
//             }
//             break;
//         case 2:
//             elemX = 1;
//             elemY = new Random().Next(1, map.GetLength(1) - 3);
//             drowMap(map);


//             while (map[elemX + 2, elemY] != '#' && map[elemX + 2, elemY + 1] != '#' && map[elemX + 2, elemY + 2] != '#')
//             {
//                 drowMap(map);
//                 Console.SetCursorPosition(elemY, elemX);
//                 drowElem(sShape, elemX, elemY);
//                 Thread.Sleep(200);
//                 elemX++;
//                 ConsoleKeyInfo charKey = Console.ReadKey();
//                 switch (charKey.Key)
//                 {
//                     case ConsoleKey.LeftArrow:
//                         if (map[elemX, elemY - 1] != '#')
//                         {
//                             elemY--;
//                         }
//                         break;
//                     case ConsoleKey.RightArrow:
//                         if (map[elemX, elemY + 3] != '#')
//                         {
//                             elemY++;
//                         }
//                         break;
//                     case ConsoleKey.Escape:
//                         clear = false;
//                         break;
//                 }
//             }

//             map[elemX + 1, elemY] = '#';
//             map[elemX + 1, elemY + 1] = '#';
//             map[elemX, elemY + 1] = '#';
//             map[elemX, elemY + 2] = '#';
//             for (int i = 1; i < map.GetLength(1) - 2; i++)
//             {
//                 if (map[1, i] == '#')
//                 {
//                     clear = false;
//                 }
//             }
//             break;
//         case 3:
//             elemX = 1;
//             elemY = new Random().Next(1, map.GetLength(1) - 3);
//             drowMap(map);


//             while (map[elemX + 2, elemY] != '#' && map[elemX + 1, elemY + 1] != '#' && map[elemX + 1, elemY + 2] != '#' )
//             {
//                 drowMap(map);
//                 Console.SetCursorPosition(elemY, elemX);
//                 drowElem(lShape, elemX, elemY);
//                 Thread.Sleep(200);
//                 elemX++;
//                 ConsoleKeyInfo charKey = Console.ReadKey();
//                 switch (charKey.Key)
//                 {
//                     case ConsoleKey.LeftArrow:
//                         if (map[elemX, elemY - 1] != '#')
//                         {
//                             elemY--;
//                         }
//                         break;
//                     case ConsoleKey.RightArrow:
//                         if (map[elemX, elemY + 3] != '#')
//                         {
//                             elemY++;
//                         }
//                         break;
//                     case ConsoleKey.Escape:
//                         clear = false;
//                         break;
//                  }
//             }

//             map[elemX, elemY + 1] = '#';
//             map[elemX, elemY + 2] = '#';
//             map[elemX + 1, elemY] = '#';
//             map[elemX, elemY] = '#';
//             for (int i = 1; i < map.GetLength(1) - 2; i++)
//             {
//                 if (map[1, i] == '#')
//                 {
//                     clear = false;
//                 }
//             }
//             break;
//         case 4:
//             elemX = 1;
//             elemY = new Random().Next(1, map.GetLength(1) - 3);
//             drowMap(map);


//             while (map[elemX + 1, elemY] != '#' && map[elemX + 1, elemY + 1] != '#')
//             {
//                 drowMap(map);
//                 Console.SetCursorPosition(elemY, elemX);
//                 drowElem(oShape, elemX, elemY);
//                 Thread.Sleep(200);
//                 elemX++;
//                 ConsoleKeyInfo charKey = Console.ReadKey();
//                 switch (charKey.Key)
//                 {
//                     case ConsoleKey.LeftArrow:
//                         if (map[elemX, elemY - 1] != '#')
//                         {
//                             elemY--;
//                         }
//                         break;
//                     case ConsoleKey.RightArrow:
//                         if (map[elemX, elemY + 2] != '#')
//                         {
//                             elemY++;
//                         }
//                         break;
//                     case ConsoleKey.Escape:
//                         clear = false;
//                         break;
//                 }
//             }

//             map[elemX - 1, elemY] = '#';
//             map[elemX - 1, elemY + 1] = '#';
//             map[elemX, elemY] = '#';
//             map[elemX, elemY + 1] = '#';
//             for (int i = 1; i < map.GetLength(1) - 2; i++)
//             {
//                 if (map[1, i] == '#')
//                 {
//                     clear = false;
//                 }
//             }

//             break;
//         case 5:
//             elemX = 1;
//             elemY = new Random().Next(1, map.GetLength(1) - 3);
//             drowMap(map);


//             while (map[elemX + 1, elemY] != '#' && map[elemX + 2, elemY + 1] != '#' && map[elemX + 2, elemY + 2] != '#')
//             {
//                 drowMap(map);
//                 Console.SetCursorPosition(elemY, elemX);
//                 drowElem(zShape, elemX, elemY);
//                 Thread.Sleep(200);
//                 elemX++;
//                 ConsoleKeyInfo charKey = Console.ReadKey();
//                 switch (charKey.Key)
//                 {
//                     case ConsoleKey.LeftArrow:
//                         if (map[elemX, elemY - 1] != '#')
//                         {
//                             elemY--;
//                         }
//                         break;
//                     case ConsoleKey.RightArrow:
//                         if (map[elemX, elemY + 3] != '#')
//                         {
//                             elemY++;
//                         }
//                         break;
//                     case ConsoleKey.Escape:
//                         clear = false;
//                         break;
//                 }
//             }

//             map[elemX, elemY] = '#';
//             map[elemX, elemY + 1] = '#';
//             map[elemX + 1, elemY + 1] = '#';
//             map[elemX + 1, elemY + 2] = '#';
//             for (int i = 1; i < map.GetLength(1) - 2; i++)
//             {
//                 if (map[1, i] == '#')
//                 {
//                     clear = false;
//                 }
//             }
//             break;
//         case 6:
//             elemX = 1;
//             elemY = new Random().Next(1, map.GetLength(1) - 3);
//             drowMap(map);


//             while (map[elemX + 1, elemY] != '#' && map[elemX + 1, elemY + 1] != '#' && map[elemX + 2, elemY + 2] != '#'  )
//             {
//                 drowMap(map);
//                 Console.SetCursorPosition(elemY, elemX);
//                 drowElem(jShape, elemX, elemY);
//                 Thread.Sleep(200);
//                 elemX++;
//                 ConsoleKeyInfo charKey = Console.ReadKey();
//                 switch (charKey.Key)
//                 {
//                     case ConsoleKey.LeftArrow:
//                         if (map[elemX, elemY - 1] != '#')
//                         {
//                             elemY--;
//                         }
//                         break;
//                     case ConsoleKey.RightArrow:
//                         if (map[elemX, elemY + 3] != '#')
//                         {
//                             elemY++;
//                         }
//                         break;
//                     case ConsoleKey.Escape:
//                         clear = false;
//                         break;
//                 }
//             }

//             map[elemX, elemY] = '#';
//             map[elemX, elemY + 1] = '#';
//             map[elemX, elemY + 2] = '#';
//             map[elemX + 1, elemY + 2] = '#';
//             for (int i = 1; i < map.GetLength(1) - 2; i++)
//             {
//                 if (map[1, i] == '#')
//                 {
//                     clear = false;
//                 }
//             }
//             break;
//         case 7:
//             elemX = 1;
//             elemY = new Random().Next(1, map.GetLength(1) - 3);
//             drowMap(map);


//             while (map[elemX + 1, elemY] != '#' && map[elemX + 2, elemY + 1] != '#' && map[elemX + 1, elemY + 2] != '#')
//             {
//                 drowMap(map);
//                 Console.SetCursorPosition(elemY, elemX);
//                 drowElem(tShape, elemX, elemY);
//                 Thread.Sleep(200);
//                 elemX++;
//                 ConsoleKeyInfo charKey = Console.ReadKey();
//                 switch (charKey.Key)
//                 {
//                     case ConsoleKey.LeftArrow:
//                         if (map[elemX, elemY - 1] != '#')
//                         {
//                             elemY--;
//                         }
//                         break;
//                     case ConsoleKey.RightArrow:
//                         if (map[elemX, elemY + 3] != '#')
//                         {
//                             elemY++;
//                         }
//                         break;
//                     case ConsoleKey.Escape:
//                         clear = false;
//                         break;
//                 }
//             }

//             map[elemX, elemY] = '#';
//             map[elemX, elemY + 1] = '#';
//             map[elemX, elemY + 2] = '#';
//             map[elemX + 1, elemY + 1] = '#';
//             for (int i = 1; i < map.GetLength(1) - 2; i++)
//             {
//                 if (map[1, i] == '#')
//                 {
//                     clear = false;
//                 }
//             }
//             break;
//     }
// }
// void drowMap(char[,] arr)
// {
//     Console.SetCursorPosition(0, 0);
//     for (int i = 0; i < arr.GetLength(0); i++)
//     {
//         for (int j = 0; j < arr.GetLength(1); j++)
//         {
//             Console.Write(arr[i, j]);
//         }
//         Console.WriteLine();
//     }
// }

// void drowElem(char[,] arr, int x, int y)
// {
//     Console.SetCursorPosition(y, x);
//     for (int i = 0; i < arr.GetLength(0); i++)
//     {
//         for (int j = 0; j < arr.GetLength(1); j++)
//         {
//             Console.Write(arr[i, j]);
//         }
//         Console.SetCursorPosition(y, x + 1 + i);
//     }
// }

// int userX = 2, userY = 10;
// int nextEx = 4, nextEy = 30;

// bool clear = true;

// while(clear)
// {   
//     Console.SetCursorPosition(30, 1);
//     Console.WriteLine("Score: ");
//     Console.SetCursorPosition(30, 2);
//     Console.WriteLine("Next element:");

//     Console.SetCursorPosition(nextEy, nextEx);
//     drow(lShape, nextEx, nextEy);

//     Console.SetCursorPosition(0, 0);
//     for (int i = 0; i < map.GetLength(0); i++)
//     {
//         for (int j = 0; j < map.GetLength(1); j++)
//         {
//             Console.Write(map[i, j]);
//         }
//         Console.WriteLine();
//     }

//     Console.SetCursorPosition(userY, userX);
//     drow(oShape, userX, userY);
//     ConsoleKeyInfo charKey = Console.ReadKey();
//     switch(charKey.Key)
//     {
//         case ConsoleKey.UpArrow:
//             if (map[userX - 1, userY] != '#')
//             {
//                 userX--;
//             }
//             break;
//         case ConsoleKey.DownArrow:
//             if (map[userX + 2, userY] != '#')
//             {
//                 userX++;
//             }
//             break;
//         case ConsoleKey.LeftArrow:
//             if (map[userX, userY - 1] != '#')
//             {
//                 userY--;
//             }
//             break;
//         case ConsoleKey.RightArrow:
//             if (map[userX, userY + 2] != '#')
//             {
//                 userY++;
//             }
//             break;
//         case ConsoleKey.Escape:
//             clear = false;
//             break;
//     }

//     Console.Clear();
// }

// void drow (char [,] arr, int x = 0, int y = 0)
// {
//     for (int i = 0; i < arr.GetLength(0); i++)
//     {
//         for (int j = 0; j < arr.GetLength(1); j++)
//         {
//             Console.Write(arr[i, j]);
//         }
//         Console.SetCursorPosition(y, x + 1);
//     }
// }


// using System.ComponentModel;
// using System.Runtime.InteropServices;


// Console.CursorVisible = false;
// char [,] map = 
// {
//     {'#', '#', '#', '#', '#', '#', '#', '#', '#', '#', '#', '#', '#', '#', '#', '#', '#', '#', '#', '#', '#', '#', '#'},
//     {'#', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', '#'},
//     {'#', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', '#'},
//     {'#', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', '#'},
//     {'#', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', '#'},
//     {'#', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', '#'},
//     {'#', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', '#'},
//     {'#', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', '#'},
//     {'#', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', '#'},
//     {'#', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', '#'},
//     {'#', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', '#'},
//     {'#', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', '#'},
//     {'#', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', '#'},
//     {'#', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', '#'},
//     {'#', '#', '#', '#', '#', '#', '#', '#', '#', '#', '#', '#', '#', '#', '#', '#', '#', '#', '#', '#', '#', '#', '#'}
// };

// char [,] oShape = 
// {
//     {'#', '#'},
//     {'#', '#'},
// };

// char [,] iShape1 = 
// {
//     {'#'},
//     {'#'},
//     {'#'},
//     {'#'},
// };

// char [,] iShape2 = 
// {
//     {'#'},{'#'},{'#'},{'#'},
// };

// char [,] lShape = 
// {

//     {'#', '#', '#'},
//     {'#', ' ', ' '},
// };

// char [,] jShape = 
// {

//     {'#', '#', '#'},
//     {' ', ' ', '#'},
// };

// char [,] zShape = 
// {
//     {'#', '#', ' '},
//     {' ', '#', '#'},
// };

// char [,] sShape = 
// {
//     {' ', '#', '#'},
//     {'#', '#', ' '},
// };

// char [,] tShape = 
// {
//     {' ', ' ', ' '},
//     {'#', '#', '#'},
//     {' ', '#', ' '},
// };

// bool clear = true;
// int elemX = 1, elemY = 10;
// int number = 0;
// bool position = true;
// // int number = new Random().Next(1, 8);
// Task task = Task.Run(() =>
// {
//     while (clear)
//     {   
//         elemX = 1;
//         elemY = new Random().Next(1, map.GetLength(1) - 3);
//         bool pos = true;
//         Console.SetCursorPosition(30, 1);
//         Console.WriteLine($"Score: {pos} ");
//         Console.SetCursorPosition(30, 2);
//         Console.WriteLine("Next element:");
//         number = new Random().Next(1, 8);
//         switch (number)
//         {
//             case 1:
//                 drowMap(map);

//               Console.Clear();




//                         drowMap(map);
//                         Console.SetCursorPosition(elemY, elemX);
//                         if (position)
//                         {
//                         iShape1 = iShape1;
//                         if (map[elemX + 4, elemY] == '#')
//                         {
//                             map[elemX, elemY] = '#';
//                             map[elemX + 3, elemY] = '#';
//                             map[elemX + 1, elemY] = '#';
//                             map[elemX + 2, elemY] = '#';
//                             pos = false;
//                         }
//                         }
//                         else
//                         {
//                             iShape1 = iShape2;
//                         }
//                         drowElem(shape, elemX, elemY);
//                         Thread.Sleep(200);
//                         elemX++;



//                         for (int i = 1; i < map.GetLength(1) - 2; i++)
//                         {
//                             if (map[1, i] == '#')
//                             {
//                                 clear = false;
//                             }
//                         }
//                         break;
//                     case 2:
//                         drowMap(map);
//                         if (map[elemX + 1, elemY] == '#' && map[elemX + 1, elemY + 1] == '#' && map[elemX + 1, elemY + 2] == '#' && map[elemX + 1, elemY + 3] == '#')
//                         {
//                             map[elemX, elemY] = '#';
//                             map[elemX, elemY + 3] = '#';
//                             map[elemX, elemY + 1] = '#';
//                             map[elemX, elemY + 2] = '#';
//                             pos = false;
//                         }

//                         drowMap(map);
//                         Console.SetCursorPosition(elemY, elemX);
//                         drowElem(iShape2, elemX, elemY);
//                         Thread.Sleep(200);
//                         elemX++;



//                         for (int i = 1; i < map.GetLength(1) - 2; i++)
//                         {
//                             if (map[1, i] == '#')
//                             {
//                                 clear = false;
//                             }
//                         }
//                         break;
//                 }
//                 }
//                 break;
//                 case 2:
//                     elemX = 1;
//                     elemY = new Random().Next(1, map.GetLength(1) - 3);
//                     drowMap(map);
//                     while (map[elemX + 2, elemY] != '#' && map[elemX + 2, elemY + 1] != '#' && map[elemX + 2, elemY + 2] != '#')
//                     {
//                         drowMap(map);
//                         Console.SetCursorPosition(elemY, elemX);
//                         drowElem(sShape, elemX, elemY);
//                         Thread.Sleep(200);
//                         elemX++;
//                     }

//                     map[elemX + 1, elemY] = '#';
//                     map[elemX + 1, elemY + 1] = '#';
//                     map[elemX, elemY + 1] = '#';
//                     map[elemX, elemY + 2] = '#';
//                     for (int i = 1; i < map.GetLength(1) - 2; i++)
//                     {
//                         if (map[1, i] == '#')
//                         {
//                             clear = false;
//                         }
//                     }
//                     break;

//                         case 3:
//                 elemX = 1;
//                 elemY = new Random().Next(1, map.GetLength(1) - 3);
//                 drowMap(map);
//                 while (map[elemX + 2, elemY] != '#' && map[elemX + 1, elemY + 1] != '#' && map[elemX + 1, elemY + 2] != '#')
//                 {
//                     drowMap(map);
//                     Console.SetCursorPosition(elemY, elemX);
//                     drowElem(lShape, elemX, elemY);
//                     Thread.Sleep(200);
//                     elemX++;

//                 }


//                 map[elemX, elemY + 1] = '#';
//                 map[elemX, elemY + 2] = '#';
//                 map[elemX + 1, elemY] = '#';
//                 map[elemX, elemY] = '#';
//                 for (int i = 1; i < map.GetLength(1) - 2; i++)
//                 {
//                     if (map[1, i] == '#')
//                     {
//                         clear = false;
//                     }
//                 }
//                 break;
//             case 4:
//                 elemX = 1;
//                 elemY = new Random().Next(1, map.GetLength(1) - 3);
//                 drowMap(map);


//                 while (map[elemX + 1, elemY] != '#' && map[elemX + 1, elemY + 1] != '#')
//                 {
//                     drowMap(map);
//                     Console.SetCursorPosition(elemY, elemX);
//                     drowElem(oShape, elemX, elemY);
//                     Thread.Sleep(200);
//                     elemX++;
//                 }

//                 map[elemX - 1, elemY] = '#';
//                 map[elemX - 1, elemY + 1] = '#';
//                 map[elemX, elemY] = '#';
//                 map[elemX, elemY + 1] = '#';
//                 for (int i = 1; i < map.GetLength(1) - 2; i++)
//                 {
//                     if (map[1, i] == '#')
//                     {
//                         clear = false;
//                     }
//                 }

//                 break;
//             case 5:
//                 elemX = 1;
//                 elemY = new Random().Next(1, map.GetLength(1) - 3);
//                 drowMap(map);


//                 while (map[elemX + 1, elemY] != '#' && map[elemX + 2, elemY + 1] != '#' && map[elemX + 2, elemY + 2] != '#')
//                 {
//                     drowMap(map);
//                     Console.SetCursorPosition(elemY, elemX);
//                     drowElem(zShape, elemX, elemY);
//                     Thread.Sleep(200);
//                     elemX++;
//                 }

//                 map[elemX, elemY] = '#';
//                 map[elemX, elemY + 1] = '#';
//                 map[elemX + 1, elemY + 1] = '#';
//                 map[elemX + 1, elemY + 2] = '#';
//                 for (int i = 1; i < map.GetLength(1) - 2; i++)
//                 {
//                     if (map[1, i] == '#')
//                     {
//                         clear = false;
//                     }
//                 }
//                 break;
//             case 6:
//                 elemX = 1;
//                 elemY = new Random().Next(1, map.GetLength(1) - 3);
//                 drowMap(map);


//                 while (map[elemX + 1, elemY] != '#' && map[elemX + 1, elemY + 1] != '#' && map[elemX + 2, elemY + 2] != '#')
//                 {
//                     drowMap(map);
//                     Console.SetCursorPosition(elemY, elemX);
//                     drowElem(jShape, elemX, elemY);
//                     Thread.Sleep(200);
//                     elemX++;
//                 }

//                 map[elemX, elemY] = '#';
//                 map[elemX, elemY + 1] = '#';
//                 map[elemX, elemY + 2] = '#';
//                 map[elemX + 1, elemY + 2] = '#';
//                 for (int i = 1; i < map.GetLength(1) - 2; i++)
//                 {
//                     if (map[1, i] == '#')
//                     {
//                         clear = false;
//                     }
//                 }
//                 break;
//             case 7:
//                 elemX = 1;
//                 elemY = new Random().Next(1, map.GetLength(1) - 3);
//                 drowMap(map);


//                 while (map[elemX + 1, elemY] != '#' && map[elemX + 2, elemY + 1] != '#' && map[elemX + 1, elemY + 2] != '#')
//                 {
//                     drowMap(map);
//                     Console.SetCursorPosition(elemY, elemX);
//                     drowElem(tShape, elemX, elemY);
//                     Thread.Sleep(200);
//                     elemX++;
//                 }

//                 map[elemX, elemY] = '#';
//                 map[elemX, elemY + 1] = '#';
//                 map[elemX, elemY + 2] = '#';
//                 map[elemX + 1, elemY + 1] = '#';
//                 for (int i = 1; i < map.GetLength(1) - 2; i++)
//                 {
//                     if (map[1, i] == '#')
//                     {
//                         clear = false;
//                     }
//                 }
//                 break;
//         }
//     }

// });
// void drowMap(char[,] arr)
// {
//     Console.SetCursorPosition(0, 0);
//     for (int i = 0; i < arr.GetLength(0); i++)
//     {
//         for (int j = 0; j < arr.GetLength(1); j++)
//         {
//             Console.Write(arr[i, j]);
//         }
//         Console.WriteLine();
//     }
// }

// void drowElem(char[,] arr, int x, int y)
// {
//     Console.SetCursorPosition(y, x);
//     for (int i = 0; i < arr.GetLength(0); i++)
//     {
//         for (int j = 0; j < arr.GetLength(1); j++)
//         {
//             Console.Write(arr[i, j]);
//         }
//         Console.SetCursorPosition(y, x + 1 + i);
//     }
// }

// while (clear)
// {
//     int row = 10;
//     ConsoleKeyInfo charKey = Console.ReadKey();
//     switch (number)
//     {
//         case 1:
//             switch (charKey.Key)
//             {
//                 case ConsoleKey.LeftArrow:
//                     if (map[elemX, elemY - 1] != '#' && map[elemX + 1, elemY - 1] != '#' && map[elemX + 2, elemY - 1] != '#' && map[elemX + 3, elemY - 1] != '#')
//                     {
//                         elemY--;
//                     }
//                     break;
//                 case ConsoleKey.RightArrow:
//                     if (map[elemX, elemY + 1] != '#' && map[elemX + 1, elemY + 1] != '#' && map[elemX + 2, elemY + 1] != '#' && map[elemX + 3, elemY + 1] != '#')
//                     {
//                         elemY++;
//                     }
//                     break;
//                 case ConsoleKey.Escape:
//                     clear = false;
//                     break;
//                 case ConsoleKey.UpArrow:
//                     if (position < 2)
//                     {
//                         position++;
//                     }
//                     else 
//                     {
//                         position = 1;
//                     }
//                     break;
//             }
//             while (row > 0)
//             {
//                 check(map);
//                 row--;
//             }
//             break;

//         case 2:
//             switch (charKey.Key)
//             {
//                 case ConsoleKey.LeftArrow:
//                     if (map[elemX, elemY - 1] != '#')
//                     {
//                         elemY--;
//                     }
//                     break;
//                 case ConsoleKey.RightArrow:
//                     if (map[elemX, elemY + 3] != '#')
//                     {
//                         elemY++;
//                     }
//                     break;
//                 case ConsoleKey.Escape:
//                     clear = false;
//                     break;
//             }
//             while (row > 0)
//             {
//                 check(map);
//                 row--;
//             }
//             break;

//         case 3:
//             switch (charKey.Key)
//             {
//                 case ConsoleKey.LeftArrow:
//                     if (map[elemX, elemY - 1] != '#')
//                     {
//                         elemY--;
//                     }
//                     break;
//                 case ConsoleKey.RightArrow:
//                     if (map[elemX, elemY + 3] != '#')
//                     {
//                         elemY++;
//                     }
//                     break;
//                 case ConsoleKey.Escape:
//                     clear = false;
//                     break;
//             }
//             while (row > 0)
//             {
//                 check(map);
//                 row--;
//             }
//             break;

//         case 4:
//             switch (charKey.Key)
//             {
//                 case ConsoleKey.LeftArrow:
//                     if (map[elemX, elemY - 1] != '#')
//                     {
//                         elemY--;
//                     }
//                     break;
//                 case ConsoleKey.RightArrow:
//                     if (map[elemX, elemY + 2] != '#')
//                     {
//                         elemY++;
//                     }
//                     break;
//                 case ConsoleKey.Escape:
//                     clear = false;
//                     break;
//             }
//             while (row > 0)
//             {
//                 check(map);
//                 row--;
//             }
//             break;

//         case 5:
//             switch (charKey.Key)
//             {
//                 case ConsoleKey.LeftArrow:
//                     if (map[elemX, elemY - 1] != '#')
//                     {
//                         elemY--;
//                     }
//                     break;
//                 case ConsoleKey.RightArrow:
//                     if (map[elemX, elemY + 3] != '#')
//                     {
//                         elemY++;
//                     }
//                     break;
//                 case ConsoleKey.Escape:
//                     clear = false;
//                     break;
//             }
//             while (row > 0)
//             {
//                 check(map);
//                 row--;
//             }
//             break;

//         case 6:
//             switch (charKey.Key)
//             {
//                 case ConsoleKey.LeftArrow:
//                     if (map[elemX, elemY - 1] != '#')
//                     {
//                         elemY--;
//                     }
//                     break;
//                 case ConsoleKey.RightArrow:
//                     if (map[elemX, elemY + 3] != '#')
//                     {
//                         elemY++;
//                     }
//                     break;
//                 case ConsoleKey.Escape:
//                     clear = false;
//                     break;
//             }
//             while (row > 0)
//             {
//                 check(map);
//                 row--;
//             }
//             break;

//         case 7:
//             switch (charKey.Key)
//             {
//                 case ConsoleKey.LeftArrow:
//                     if (map[elemX, elemY - 1] != '#')
//                     {
//                         elemY--;
//                     }
//                     break;
//                 case ConsoleKey.RightArrow:
//                     if (map[elemX, elemY + 3] != '#')
//                     {
//                         elemY++;
//                     }
//                     break;
//                 case ConsoleKey.Escape:
//                     clear = false;
//                     break;
//             }
//             while (row > 0)
//             {
//                 check(map);
//                 row--;
//             }
//             break;
//     }
// }

// void check (char[,] arr)
// {
//     int row = 0;
//     int count = 0;
//     for (int i = 1; i < arr.GetLength(0) - 1; i++)
//     {
//         for (int j = 1; j < arr.GetLength(1) - 1; j++)
//         {
//             if (arr[i, j] == '#')
//             {
//                 count++;
//                 if (count == map.GetLength(1)-2)
//                 {
//                     row = i;
//                 }
//             }
//         }
//         count = 0;
//     }
//     chenge(map, row);
// }

// void chenge(char[,] arr, int x)
// {
//     for (int i = x; i > 1; i--)
//     {
//         for (int j = 1; j < arr.GetLength(1) - 1; j++)
//         {
//             arr[i, j] = arr[i - 1, j];
//         }
//     }
// }


// char[,] shape = char[,] shapeSquar = char[,] shapeSquarV1;


using System.Collections.Generic;

char [,] oShape = 
{
    {'#', '#'},
    {'#', '#'},
};

char [,] iShape1 = 
{
    {'#'},
    {'#'},
    {'#'},
    {'#'},
};

char [,] iShape2 = 
{
    {'#'},{'#'},{'#'},{'#'},
};

char [,] lShape = 
{

    {'#', '#', '#'},
    {'#', ' ', ' '},
};

char [,] jShape = 
{

    {'#', '#', '#'},
    {' ', ' ', '#'},
};

char [,] zShape = 
{
    {'#', '#', ' '},
    {' ', '#', '#'},
};

char [,] sShape = 
{
    {' ', '#', '#'},
    {'#', '#', ' '},
};

char [,] tShape = 
{
    {' ', ' ', ' '},
    {'#', '#', '#'},
    {' ', '#', ' '},
};

List<char[,]> elements1 = new List<char[,]>{oShape, iShape1, iShape2, tShape};
List<char[,]> elements2 = new List<char[,]>{oShape, iShape1, iShape2, tShape};
List<char[,]> elements3 = new List<char[,]>{oShape, iShape1, iShape2, tShape};
List<char[,]> elements4 = new List<char[,]>{oShape, iShape1, iShape2, tShape};

List<List<char[,]>> elements = new List<List<char[,]>>{elements1, elements2, elements3, elements4};

for (int i = 0; i < elements[3][3].GetLength(0); i++)
{
    for (int j = 0; j < elements[3][3].GetLength(1); j++)
    {
        System.Console.Write($"{elements[3][3][i,j]}");
    }
    System.Console.WriteLine();
}








