// Задача 51: Задайте двумерный массив. Найдите сумму
// элементов, находящихся на главной диагонали (с индексами
// (0,0); (1;1) и т.д.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Сумма элементов главной диагонали: 1+9+2 = 12

int rows = WorkWithUser("Введите кол-во строк: ");
int columns = WorkWithUser("Введите кол-во столбцов: ");
int minValue = WorkWithUser("Введите минимальное значение: ");
int maxValue = WorkWithUser("Введите максимальное значение: ");
int[,] array = GetArray(rows, columns, minValue, maxValue + 1);
PrintArray(array);
System.Console.WriteLine();
GetMainDiagonalSum(array);

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
    System.Console.WriteLine("Матрица:");
    for(int i = 0; i < inArray.GetLength(0); i++) // GetLength(0) для строчик
    { 
        for (int j = 0; j < inArray.GetLength(1); j++) //GetLength(1) для столбца
        {
            System.Console.Write($"{inArray[i, j]} "); 
        }
        System.Console.WriteLine();
    }
}

void GetMainDiagonalSum(int[,] inArr)
{
    int sum = 0;
    string elements = "";
    
    for(int i = 0; i < inArr.GetLength(0); i++) 
    {
        if (i < inArr.GetLength(1)) // Проверяем, чтобы не выйти за пределы матрицы
        {
            if (elements.Length > 0)
            {
                elements += "+";
            }

            elements += inArr[i, i].ToString(); // Добавляем элементы главной диагонали в строку
            sum += inArr[i, i]; // Считаем сумму элементов главной диагонали
        }
    }

    System.Console.WriteLine($"Сумма элементов главной диагонали: {elements} = {sum}");
}