// Задайте прямоугольный двумерный массив. Напишите программу, 
//  которая будет находить строку с наименьшей суммой элементов.

Console.WriteLine("Введите размер массива m x n и диапазон случайных значений:");
int m = InputNumbers("Введите m: ");
int n = InputNumbers("Введите n: ");
int range = InputNumbers("Введите диапазон: от 1 до ");

// метод выводит массив где ищет минимальное значение наименшей суммой элементов 


int[,] array = new int[m, n];  
CreateArray(array);
WriteArray(array);

int minSumLine = 0;
int sumLine = SumLineElements(array, 0);
for (int i = 0; i < array.GetLength(0); i++)
{
    int tempSumLine = SumLineElements(array, i);
    if (sumLine > tempSumLine)
    {
        sumLine = tempSumLine;
        minSumLine = i;
    }
}

// метод который суммирует строки 

int SumLineElements(int[,] array, int i)
{
    int sumLine = array[i, 0];
    for(int j = 0; j < array.GetLength(0); j++)
    {
        sumLine += array[i, j];
    }
    return sumLine;
}


int InputNumbers(string input)
{
    Console.Write(input);
    int output = Convert.ToInt32(Console.ReadLine());
    return output;
}

void CreateArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = new Random().Next(range);
        }
    }
}

 // метод который читает массив 
void WriteArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i, j] + " ");
        }
        Console.WriteLine();
    }
}

Console.WriteLine($"\n{minSumLine + 1} - строкa с наименьшей суммой ({sumLine}) элементов ");
CreateArray(array);
 WriteArray(array);


