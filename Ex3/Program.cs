// Решение в группах задач:
// Задача 49: Задайте двумерный массив. Найдите элементы, у
// которых оба индексы чётные, и замените эти элементы на их
// квадраты.
// Например, изначально массив         Новый массив будет выглядеть 
// выглядел вот так:                   выглядел вот так:
// 1 4 7 2                             1 4 49 2                    
// 5 9 2 3                             5 9 2 3
// 8 4 2 4                             64 4 4 4

int rows = WorkWithUser("Введите кол-во строк: ");
int columns = WorkWithUser("Введите кол-во столбцов: ");
int minValue = WorkWithUser("Введите минимальное значение: ");
int maxValue = WorkWithUser("Введите максимальное значение: ");
int[,] array = GetArray(rows, columns, minValue, maxValue + 1);
System.Console.WriteLine("Оригинальная матрица:");
PrintArray(array);
System.Console.WriteLine("Измененная матрица:");
TransformEvenIndicesToSquares(array);
System.Console.WriteLine();

int WorkWithUser(string message)
{
        System.Console.Write(message);
    int number = int.Parse(Console.ReadLine()!);
    return number;
}

int[,] GetArray(int row, int column, int minValue, int maxValue)
{
    int[,] result = new int[row, column];
    Random rnd = new Random();
    for(int i = 0; i < row; i++)
    { 
        for (int j = 0; j < column; j++)
        {
            result[i, j] = rnd.Next(minValue, maxValue); 
        }
    }
    return result;
}

void PrintArray(int[,] inArray)
{
    for(int i = 0; i < inArray.GetLength(0); i++) // GetLength(0) для строчик
    { 
        for (int j = 0; j < inArray.GetLength(1); j++) //GetLength(1) для столбца
        {
            System.Console.Write($"{inArray[i, j]} "); 
        }
        System.Console.WriteLine();
    }
}

void TransformEvenIndicesToSquares(int[,] inArr)
{
    
    for(int i = 0; i < inArr.GetLength(0); i++) // GetLength(0) для строчик
    { 
        for (int j = 0; j < inArr.GetLength(1); j++) //GetLength(1) для столбца
        {
            
            if (i % 2 == 0 && j % 2 == 0) // Проверка, что оба индекса четные
            {
                inArr[i, j] *= inArr[i, j]; // Возводим элемент в квадрат
            } 
            System.Console.Write($"{inArr[i, j]} "); // Выводим элемент массива
        }
        System.Console.WriteLine();
    }
}