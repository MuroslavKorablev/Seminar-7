// Программа, которая будет создавать два одинаковых массива
// запелненных рандомными числами и создайте такой метод, который будет
// перемножать между собой массивы и складывать их в новый массив

int rows = WorkWithUser("Введите количество строк: ");
int columns = WorkWithUser("Введите количество столбцов: ");
int minValue1 = WorkWithUser("Введите минимальное значение для первой матрицы: ");
int maxValue1 = WorkWithUser("Введите максимальное значение для первой матрицы: ");
int[,] array1 = GetRandomArray(rows, columns, minValue1, maxValue1 + 1);

int minValue2 = WorkWithUser("Введите минимальное значение для второй матрицы: ");
int maxValue2 = WorkWithUser("Введите максимальное значение для второй матрицы: ");
int[,] array2 = GetRandomArray(rows, columns, minValue2, maxValue2 + 1);

Console.WriteLine();
Console.WriteLine("Первая матрица:");
PrintArray(array1);

Console.WriteLine();
Console.WriteLine("Вторая матрица:");
PrintArray(array2);

Console.WriteLine();
Console.WriteLine("Произведение матриц:");
int[,] product = MultiplyMatrices(array1, array2);
PrintArray(product);

// Метод для работы с пользователем: принимает сообщение и возвращает введенное им число.
int WorkWithUser(string message)
{
    Console.Write(message);
    int number = int.Parse(Console.ReadLine()!);
    return number;
}

// Метод для генерации случайной матрицы с заданными параметрами.
int[,] GetRandomArray(int rows, int columns, int minValue, int maxValue)
{
    int[,] result = new int[rows, columns];
    Random rnd = new Random();
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            result[i, j] = rnd.Next(minValue, maxValue);
        }
    }
    return result;
}

// Метод для вывода матрицы в консоль.
void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write($"{array[i, j]} ");
        }
        Console.WriteLine();
    }
}

// Метод для умножения двух матриц.
int[,] MultiplyMatrices(int[,] array1, int[,] array2)
{
    int rows = array1.GetLength(0);
    int columns = array1.GetLength(1); 
    int[,] result = new int[rows, columns];
    
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            result[i, j] = array1[i, j] * array2[i, j];
        }
    }
    
    return result;
}