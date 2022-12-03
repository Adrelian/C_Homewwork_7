// Задача 47. Задайте двумерный массив размером m×n,
// заполненный случайными вещественными числами.

// m = 3, n = 4.
// 0,5 7 -2 -0,2
// 1 -3,3 8 -9,9
// 8 7,8 -7,1 9

// void CreatAndShowArray(int rows, int columns)  
// {      
//     // Инициализация массива
//     double [,] newArray = new double[rows, columns];

//     Random value = new Random(); // случайное число для суммирования в float
    
//     if( rows > 0 && columns > 0)
//     {
//         // создание массива
//         for (int i = 0; i < rows; i++)
//         {
//             for(int j = 0; j < columns; j++)
//             {
//             newArray[i,j] =Math.Round(value.Next(-100, 100) + value.NextDouble(), 2);
//             }
//         }

//         // Отображение массива
//         for(int i = 0; i < rows ;i++ ) 
//             {
//                 for(int j = 0; j < columns; j++)  
//                 {
//                 Console.Write(newArray[i,j] + " ");
//                 }
//                 Console.WriteLine(); 
//             }
//     }
//     else Console.WriteLine("Ошибка ввода данных");
// }

// Console.Write("Введите кол-во строк ");
// int rows = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите кол-во столбцов ");
// int columns = Convert.ToInt32(Console.ReadLine());

// CreatAndShowArray(rows, columns);

// Задача 50. Напишите программу,
// которая на вход принимает позиции элемента в двумерном массиве,
// и возвращает значение этого элемента или же указание, 
// что такого элемента нет.

// Например, задан массив:

// 1 4 7 2
// 5 9 2 3
// 8 4 2 4

// 17 -> такого числа в массиве нет

// int [,] CreatAndShowArray(int rows, int columns)  
// {      
//     // Инициализация массива
//     int[,] newArray = new int[rows, columns];  
    
//     if( rows > 0 && columns > 0)
//     {
//         // создание массива
//         for (int i = 0; i < rows; i++)
//         {
//             for(int j = 0; j < columns; j++)
//             {
//             newArray[i,j] = new Random().Next(1, 11);
//             }
//         }

//         // Отображение массива
//         for(int i = 0; i < rows ;i++ ) 
//             {
//                 for(int j = 0; j < columns; j++)  
//                 {
//                 Console.Write(newArray[i,j] + " ");
//                 }
//                 Console.WriteLine(); 
//             }
//         return newArray;
//     }
//     else 
//     {
//         Console.WriteLine("Ошибка ввода данных");
//         return newArray;
//     }

// }

// Console.Write("Введите кол-во строк ");
// int rows = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите кол-во столбцов ");
// int columns = Convert.ToInt32(Console.ReadLine());

// int [,] myArray = CreatAndShowArray(rows, columns);


// int findNumberInArray (int indexI, int indexJ)
// {
//     int number; // искомое число

//     if (indexI <= myArray.GetLength(0) && indexJ <= myArray.GetLength(1)) // отмекаем ошибку ввода
//     {    
//         for (int i = 0; i < myArray.GetLength(0); i++) // перебираем строки
//         {
//             if (indexI - 1 == i) // если строка равна пользовательской, начинаем перебор столбцов
//             {             
//                 for(int j = 0; j < myArray.GetLength(1); j++) // перебираем столбцы
//                 {
//                     if (indexJ - 1 == j) // если стобец равен пользовательскому, делаем вывод
//                     {
//                         number = myArray[i,j]; 
//                         Console.WriteLine($"Ваше число {number}");
//                         return number;
//                     }
//                 }
//             }
//         }
//     }
//     else Console.WriteLine("Ошибка"); // Если ошибка ввода
//     return indexI;
// }

// Console.Write("Введите строку для поиска ");
// int indexI = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите введите столбец для поиска ");
// int indexJ = Convert.ToInt32(Console.ReadLine());

// findNumberInArray(indexI, indexJ);



// Задача 52. Задайте двумерный массив из целых чисел.
// Найдите среднее арифметическое элементов в каждом столбце.

// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.

int [,] CreatAndShowArray(int rows, int columns)  
{      
    // Инициализация массива
    int[,] newArray = new int[rows, columns];  
    
    if( rows > 0 && columns > 0)
    {
        // создание массива
        for (int i = 0; i < rows; i++)
        {
            for(int j = 0; j < columns; j++)
            {
            newArray[i,j] = new Random().Next(1, 11);
            }
        }

        // Отображение массива
        for(int i = 0; i < rows ;i++ ) 
            {
                for(int j = 0; j < columns; j++)  
                {
                Console.Write(newArray[i,j] + " ");
                }
                Console.WriteLine(); 
            }
        return newArray;
    }
    else 
    {
        Console.WriteLine("Ошибка ввода данных");
        return newArray;
    }
}

Console.Write("Введите кол-во строк ");
int rows = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите кол-во столбцов ");
int columns = Convert.ToInt32(Console.ReadLine());

int [,] myArray = CreatAndShowArray(rows, columns);



void arithmeticMean(int [,] myArray)
{
    for (int j = 0; j < myArray.GetLength(1); j++) // столбцы
    {
        double sum = 0;
        for (int i = 0;  i < myArray.GetLength(0); i++) // строки
        {
            sum = (sum + myArray[i, j]);
        }
        Console.WriteLine
        (
            $"Среднее арифметическое столбца {j + 1} равно {Math.Round(sum / myArray.GetLength(0), 2)}"
        );
    }
}

arithmeticMean(myArray);