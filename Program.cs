// Задача 2. Напишите программу, которая на вход принимает позиции элемента в двумерном
//  массиве, 
// и возвращает значение этого элемента или же указание, что такого элемента нет.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4

 

int[,] GenerateArray(int row, int col)
{
    int[,] array = new int[row, col]; // Создаем 2-мерный массив
    Random rnd = new Random();
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = rnd.Next(1, 20);
        }
    }
    return array;
}
void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        System.Console.WriteLine();
        for (int j = 0; j < array.GetLength(1); j++)
        {
            System.Console.Write($"{array[i, j]}\t");
        }
    }
    System.Console.WriteLine();
}

/// <summary>
/// Метод возвращает позицию найденого значения в двумерном массиве
/// </summary>
/// <param name="isNotFinde">параметр возвращает найдено искомое значение или нет </param>
/// <param name="row">строка найденной позиции</param>
/// <param name="col">колонка найденной позиции</param>
/// <param name="array"> двумерный массив</param>
/// <param name="element">искомый элемент</param>
/// <returns></returns>

(bool isNotFinde, int row, int col) FindePosition(int[,] array, int element)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            if (element == array[i, j])
            {
                return (false, i, j);
            }
        }
    }
    return (true, -1, -1);
}

//Метод получения числа от пользователя 
int InputUser(string str) 
{ 
    Console.Write($"{str} ="); 
    return Convert.ToInt32(Console.ReadLine()); 
} 

int[,] matrix = GenerateArray(3, 4);
PrintArray(matrix);
int element = InputUser("Введите цифру которую будем искать");
var result = FindePosition(matrix, element);
if (result.isNotFinde) Console.WriteLine("Такого элемента нет");
else Console.WriteLine($"индекс поискового элемента равно = ({result.row},{result.col})");