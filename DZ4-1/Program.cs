// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16


// int InputInt(string prompt)
// {
//     System.Console.Write($"{prompt} > ");
//     return Convert.ToInt32(Console.ReadLine());
// }

// int SumNumbers(int value)    // Подсчет суммы от 1 до value 
// {
//     int sum = 0;  // будем здесь накапливать сумму
//     for(int i = 1; i <= value; i++)  // цикл вычисления суммы
//     {
//         sum += i;   // накапливаем сумму
//     }
//     return sum;
// }

// int value = InputInt("Введите число");

int InputInt(string prompt)
{
    System.Console.Write($"{prompt} > ");
    return Convert.ToInt32(Console.ReadLine());
}

bool ValidateExponent(int numberB)
{
    if(numberB < 0)
    {
    System.Console.WriteLine("Введите положительное число Б");
    return false;
    }
    return true;
}

int Degree(int numberA, int numberB)  
{
    int result = 1;
    for(int i = 0; i <= numberB; i++)  
    {
        result *= numberA;   
    }
    return result;
}

int numberA = InputInt("Введите число A");
int numberB = InputInt("Введите число Б");
if (ValidateExponent(numberB))
{
System.Console.WriteLine($"Число {numberA} в степени {numberB} равно {Degree(numberA, numberB)}");
}

