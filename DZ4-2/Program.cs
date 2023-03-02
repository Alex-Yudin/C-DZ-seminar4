// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12

// Вывести количество цифр в числе

int InputInt(string prompt)
{
    System.Console.Write($"{prompt} > ");
    return Convert.ToInt32(Console.ReadLine());
}

int SumNumber(int num)
{
    int sum = 0;
    while (num > 0)
    {
        sum += num % 10;
        num /= 10;
     }
    return sum;
}
int userNumber = InputInt("Введите число");
int sum = SumNumber(userNumber);
System.Console.WriteLine($"Сумма цифр в числе {userNumber} = {SumNumber(userNumber)}");