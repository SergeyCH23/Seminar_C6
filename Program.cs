// // Задача 46: Задайте двумерный массив размером m×n, заполненный случайными целыми числами.
// // m = 3, n = 4.
// // 1 4 8 19
// // 5 -2 33 -2
// // 77 3 8 1

// // Двумерный массив = табличка = матрица (табличка, состоящая из m строк и n столбцов)
// // Одномерный массив = строчка
// Console.Write("Введите количество строк: ");
// int rows = Convert.ToInt32(Console.ReadLine());

// Console.Write("Введите количество столбцов: ");
// int columns = Convert.ToInt32(Console.ReadLine());
// int[,] array2D = GetMatrix(rows, columns, 0, 10); // Создалась матрица
// // int[,] testMatrix = GetMatrix(2,2, -10,10);
// // int[,] secondTestMatrix = GetMatrix(3,3, -10,10);
// // m - строчки, n - столбцы
// // int[,] GetMatrix(int m, int n)
// // {
// //     int[,] matrix = new int[m, n]; // [rows, columns]
// //     for (int i = 0; i < matrix.GetLength(0); i++) //  matrix.GetLength(0) = m - строчки
// //     {
// //         // i, j , m , k
// //         for (int j = 0; j < matrix.GetLength(1); j++) //  matrix.GetLength(1) = n - столбцы
// //         {
// //             matrix[i, j] = i + j;
// //         }
// //     }
// //     return matrix;
// // }
// int[,] GetMatrix(int m, int n, int min, int max)
// {
//     int[,] matrix = new int[m, n]; // [rows, columns]
//     for (int i = 0; i < matrix.GetLength(0); i++) //  matrix.GetLength(0) = m - строчки
//     {
//         // i, j , m , k
//         for (int j = 0; j < matrix.GetLength(1); j++) //  matrix.GetLength(1) = n - столбцы
//         {
//             matrix[i, j] = new Random().Next(min, max + 1);
//         }
//     }
//     return matrix;
// }
// Console.WriteLine("исходный массив:");
// PrintMatrix(array2D);  // inputMatrix = array2D
// // Console.WriteLine("Вывод матрицы  2 на 2 для теста: ");
// // PrintMatrix(testMatrix); // inputMatrix = testMatrix
// // Console.WriteLine("Вывод матрицы  3 на 3 для теста: ");
// // PrintMatrix(secondTestMatrix); // inputMatrix = secondTestMatrix
// // Печатаем двумерный массив на экран
// void PrintMatrix(int[,] inputMatrix)
// {
//     for (int i = 0; i < inputMatrix.GetLength(0); i++) // строчки
//     {
//         for (int j = 0; j < inputMatrix.GetLength(1); j++) // столбцы
//         {
//             Console.Write(inputMatrix[i, j] + "\t"); // "\t" - отступ между элементами   
//         }
//         Console.WriteLine(); // Переход на новую строчку
//     }
// }

// //  Задайте двумерный массив. 
// //  Найдите элементы, у которых оба индекса чётные, и замените эти элементы на их квадраты.

// // Метод, который берет матрицу, заполненную целыми числами и возводит в квадрат элементы
// // с четными индексами

// Console.WriteLine("Исходный массив, где элементы возведены в квадрат (четные индексы)");
// PrintMatrix(ChangeMatrix(array2D)); // matrix = array2D
// int[,] ChangeMatrix(int[,] matrix) // Чтобы возвести в квадрат элементы матрицы, получим матрицу :)
// {
//     for (int i = 0; i < matrix.GetLength(0); i++) // строчки
//     {
//         for (int j = 0; j < matrix.GetLength(1); j++) // столбцы
//         {
//             if (i % 2 == 0 && j % 2 == 0) // если номер строчки и номер столбца дают остаток 0 при 
//             // делении на 2, то это четные индексы
//             {
//                 matrix[i,j] *= matrix[i,j]; // matrix[i,j] = matrix[i,j] * matrix[i,j]
//             }
//         }
//     }
//     return matrix; // Матрица, в которой эл-ты возвезедны в квадрат
// }

