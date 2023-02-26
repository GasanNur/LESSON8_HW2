//  Задача 2: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.

// [3, 7, 23, 12] -> 19

// [-4, -6, 89, 6] -> 0


int InputUser(string msg)
{
    Console.Write($"{msg} = >");
    int userNumber = Convert.ToInt32(Console.ReadLine());
    return userNumber;
}

int[] FillArray(int[] array)
{
    Random rnd = new Random();
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = rnd.Next(100, 1000);
    }
    return array;
}

// int ShowEvenArray(int[] array)
// {
//     int result = 0;
//     for (int i = 0; i < array.Length; i++)
//     {
//        if (array[i] % 2 ==0) result++; 
//     }
//     return result;
// }

void PrintArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]}  ");
    }
    Console.WriteLine();
}

int SummOddIndex(int[] newArray)
{
    int result = 0;
    for (int i = 1; i < newArray.Length; i += 2)
    {
        result += newArray[i];
    }
    return result;
}

int userNumber = InputUser("Введите колличество элементов массива ");
int[] myArray = new int[userNumber];
FillArray(myArray);
PrintArray(myArray);
Console.WriteLine($"Сумма  не четных элементов массива  {SummOddIndex(myArray)}");