﻿﻿// // Исчезновение линий

// // char[,] map = 
// // {
// //     { '#', '#', '#', '#', '#', '#', '#', '#', '#', '#', '#', '#', '#', '#',}, // индекс 0
// //     { '#', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', '#',},
// //     { '#', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', '#',},
// //     { '#', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', '#',},
// //     { '#', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', '#',},
// //     { '#', '#', '#', '#', '#', '#', '#', '#', '#', '#', '#', '#', '#', '#',},
// //     { '#', '#', '#', ' ', ' ', ' ', '#', '#', ' ', '#', '#', ' ', ' ', '#',},
// //     { '#', '#', '#', ' ', ' ', ' ', ' ', '#', '#', ' ', ' ', ' ', ' ', '#',},
// //     { '#', '#', '#', '#', '#', ' ', '#', '#', '#', '#', '#', '#', '#', '#',},
// //     { '#', '#', '#', '#', '#', '#', '#', '#', '#', '#', '#', '#', '#', '#',},
// //     { '#', ' ', ' ', '#', '#', ' ', ' ', ' ', ' ', '#', '#', ' ', ' ', '#',},
// //     { '#', '#', '#', '#', '#', '#', '#', '#', '#', '#', '#', '#', '#', '#',},
// //     { '#', '#', '#', '#', '#', '#', '#', '#', '#', '#', '#', '#', '#', '#',},
// //     { '#', '#', '#', '#', '#', '#', '#', '#', '#', '#', '#', '#', '#', '#',},  // индекс 13
// // };

// // void drowMap(char[,] arr)
// // {
// //     for (int i = 0; i < map.GetLength(0); i++)
// //     {
// //         for (int j = 0; j < map.GetLength(1); j++)
// //         {
// //             Console.Write(arr[i, j]);
// //         }
// //         Console.WriteLine();
// //     }
// // }
// // drowMap(map);

// // int row = 10;
// // while(row > 0)
// // {
// //     check(map);
// //     row--;
// // }

// // check(map);
// // void check (char[,] arr)
// // {
// //     int row = 0;
// //     int count = 0;
// //     for (int i = 1; i < arr.GetLength(0) - 1; i++)
// //     {
// //         for (int j = 1; j < arr.GetLength(1) - 1; j++)
// //         {
// //             if (arr[i, j] == '#')
// //             {
// //                 count++;
// //                 if (count == 12)
// //                 {
// //                     row = i;
// //                 }
// //             }
// //         }
// //         count = 0;
// //     }
// //     chenge(map, row);
// // }

// // void chenge(char[,] arr, int x)
// // {
// //     for (int i = x; i > 1; i--)
// //     {
// //         for (int j = 1; j < arr.GetLength(1) - 1; j++)
// //         {
// //             arr[i, j] = arr[i - 1, j];
// //         }
// //     }
// // }

// // Console.WriteLine();
// // drowMap(map);

// // ****************************************************************************************************************************************
// // ****************************************************************************************************************************************

// Console.CursorVisible = false;

// char[,] map =
// {
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
//     {'#', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', '#'},
//     {'#', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', '#'},
//     {'#', '#', '#', '#', '#', '#', '#', '#', '#', '#', '#', '#', '#', '#', '#', '#', '#', '#', '#', '#', '#', '#', '#'}
// };

// char[,] oShape =
// {
//     {'#', '#'},
//     {'#', '#'},
// };

// bool isOpen = true;

// int elemX = 1, elemY = 10;

// Task task = Task.Run(() =>
//     {
//         while (isOpen)
//         {
//             while (map[0, 10] != '#')
//             {
//                 while (map[elemX + 1, elemY] != '#' && map[elemX + 1, elemY + 1] != '#')
//                 {
//                     Console.Clear();
//                     drowMap(map);
//                     Console.SetCursorPosition(elemY, elemX);
//                     drowElem(oShape, elemX, elemY);
//                     elemX++;
//                     Thread.Sleep(100);
//                 }
//                 map[elemX - 1, elemY] = '#';
//                 map[elemX - 1, elemY + 1] = '#';
//                 map[elemX, elemY] = '#';
//                 map[elemX, elemY + 1] = '#';
//                 elemX = 1;
//                 elemY = 10;
//             }
//         }
//     });

// while (isOpen)
// {
//     ConsoleKeyInfo charKey = Console.ReadKey();
//     switch (charKey.Key)
//     {
//         case ConsoleKey.LeftArrow:
//             if (map[elemX, elemY - 1] != '#')
//             {
//                 elemY--;
//             }
//             break;
//         case ConsoleKey.RightArrow:
//             if (map[elemX, elemY + 2] != '#')
//             {
//                 elemY++;
//             }
//             break;
//         case ConsoleKey.Escape:
//             isOpen = false;
//             break;
//     }
// }
// // ********************************************************

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
//         Console.SetCursorPosition(y, x + 1);
//     }
// }


﻿// using System.ComponentModel;

// Console.CursorVisible = false;
// char [,] map = 
// {
//     {'#', '#', '#', '#', '#', '#', '#', '#', '#', '#', '#', '#', '#', '#', '#', '#', '#'},
//     {'#', ' ', '#', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', '#'},
//     {'#', ' ', '#', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', 'X', '#'},
//     {'#', ' ', '#', ' ', 'X', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', '#'},
//     {'#', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', '#'},
//     {'#', ' ', '#', ' ', ' ', ' ', ' ', ' ', ' ', '#', '#', '#', ' ', ' ', ' ', ' ', '#'},
//     {'#', ' ', '#', ' ', ' ', ' ', ' ', ' ', ' ', '#', 'X', '#', ' ', ' ', ' ', ' ', '#'},
//     {'#', ' ', '#', ' ', ' ', ' ', ' ', ' ', ' ', '#', ' ', '#', ' ', ' ', ' ', ' ', '#'},
//     {'#', ' ', '#', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', '#'},
//     {'#', ' ', '#', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', '#'},
//     {'#', ' ', '#', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', '#'},
//     {'#', ' ', '#', '#', '#', '#', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', 'X', ' ', '#'},
//     {'#', ' ', ' ', ' ', 'X', '#', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', '#'},
//     {'#', ' ', ' ', ' ', ' ', '#', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', '#'},
//     {'#', '#', '#', '#', '#', '#', '#', '#', '#', '#', '#', '#', '#', '#', '#', '#', '#'}
// };


// int userX = 6, userY = 6;
// char[] bag = new char[1];
// bool isOpen = true;
// while(isOpen)
// {   Console.SetCursorPosition(0, 20);
//     Console.Write("Сумка: ");
//     for (int i = 0; i < bag.Length; i++)
//     {
//         Console.Write(bag[i] + " ");
//     }

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
//     Console.WriteLine('@');
//     ConsoleKeyInfo charKey = Console.ReadKey();
//     switch(charKey.Key)
//     {
//         case ConsoleKey.UpArrow:
//             if (map[userX -1, userY] != '#')
//             {
//                 userX--;
//             }
//             break;
//         case ConsoleKey.DownArrow:
//             if (map[userX + 1, userY] != '#')
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
//             if (map[userX, userY + 1] != '#')
//             {
//                 userY++;
//             }
//             break;
//         case ConsoleKey.Escape:
//             isOpen = false;
//             break;
//     }
//     if (map[userX, userY] == 'X')
//     {
//         map[userX, userY] = 'O';
//         char[] tempBag = new char[bag.Length + 1];
//         for (int i = 0; i < bag.Length; i++)
//         {
//             tempBag[i] = bag[i];
//         }
//         tempBag[tempBag.Length - 1] = 'X';
//         bag = tempBag;
//     }
//     Console.Clear();
// }


// ************************************************************************************************************************************************
// ************************************************************************************************************************************************

// using System.ComponentModel;

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
//     {'@', '@'},
//     {'@', '@'},
// };

// char [,] iShape = 
// {
//     {' ', '@', ' ', ' '},
//     {' ', '@', ' ', ' '},
//     {' ', '@', ' ', ' '},
//     {' ', '@', ' ', ' '},
// };

// char [,] lShape = 
// {
//     // {' ', ' ', ' '},
//     {'@', '@', '@'},
//     {'@', ' ', ' '},
// };

// char [,] jShape = 
// {
//     {' ', ' ', ' '},
//     {'@', '@', '@'},
//     {' ', ' ', '@'},
// };

// char [,] zShape = 
// {
//     {' ', ' ', ' '},
//     {'@', '@', ' '},
//     {' ', '@', '@'},
// };

// char [,] sShape = 
// {
//     {' ', ' ', ' '},
//     {' ', '@', '@'},
//     {'@', '@', ' '},
// };

// char [,] tShape = 
// {
//     {' ', ' ', ' '},
//     {'@', '@', '@'},
//     {' ', '@', ' '},
// };

// int number = new Random().Next(1, 8);
// switch(number)
// {
//     case 1:
//         drow(iShape);
//         break;
//     case 2:
//         drow(jShape);
//         break;
//     case 3:
//         drow(lShape);
//         break;
//     case 4:
//         drow(oShape);
//         break;
//     case 5:
//         drow(zShape);
//         break;
//     case 6:
//         drow(tShape);
//         break;
//     case 7:
//         drow(sShape);
//         break;
// }

// int userX = 2, userY = 10;
// int nextEx = 4, nextEy = 30;

// bool isOpen = true;

// while(isOpen)
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
//             isOpen = false;
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


// ********************************************************************************************************************************
// ********************************************************************************************************************************

// Console.CursorVisible = false;

// char [,] map = 
// {
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
//     {'#', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', '#'},
//     {'#', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', '#'},
//     {'#', '#', '#', '#', '#', '#', '#', '#', '#', '#', '#', '#', '#', '#', '#', '#', '#', '#', '#', '#', '#', '#', '#'}
// };

// char [,] oShape =
// {
//     {'#', '#'},
//     {'#', '#'},
// };
// while (map[0, 10] != '#')
// {   

//     int elemX = 1, elemY = 10;
//     drowMap (map);


//     while (map[elemX + 1, elemY] != '#' && map[elemX + 1, elemY + 1] != '#')
//     {
//         drowMap (map);
//         Console.SetCursorPosition(elemY, elemX);
//         drowElem(oShape, elemX, elemY);
//         Thread.Sleep(200); 
//         elemX++;
//     }

//     map[elemX - 1, elemY] = '#';
//     map[elemX - 1, elemY + 1] = '#';
//     map[elemX, elemY] = '#';
//     map[elemX, elemY + 1] = '#';
// }

// void drowMap (char[,] arr)
// {
//     Console.SetCursorPosition(0, 0);
//     for (int i = 0; i < arr.GetLength(0); i++)
//         {
//             for (int j = 0; j < arr.GetLength(1); j++)
//             {
//                 Console.Write(arr[i, j]);
//             }
//             Console.WriteLine();
//     }
// }

// void drowElem (char[,] arr, int x, int y)
// {
//     Console.SetCursorPosition(y, x);
//     for (int i = 0; i < arr.GetLength(0); i++)
//         {
//             for (int j = 0; j < arr.GetLength(1); j++)
//             {
//                 Console.Write(arr[i, j]);
//             }
//             Console.SetCursorPosition(y, x + 1);
//     }
// }