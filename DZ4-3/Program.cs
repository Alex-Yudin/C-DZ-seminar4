// Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
// 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
// 6, 1, 33 -> [6, 1, 33]

int[] FillArray(int size)
{
    int[] myArray = new int[size];
    for (int i = 0; i < myArray.Length; i++)
    {
        myArray[i] = new Random().Next(0,100);
    }
    return myArray;
}

void PrintArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        // System.Threading.Thread.Sleep(50);    // замедление скорости вывода 
        System.Console.Write($"{array[i]}, ");
    }
    System.Console.WriteLine();
}

int InputSizeArray(string msg)
{
    System.Console.WriteLine($"{msg}");
    return Convert.ToInt32(Console.ReadLine());
}

int sizeArray = InputSizeArray("Введите размер массива");
int[] myArray = FillArray(sizeArray);
PrintArray(myArray);
