/*Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.*/
int getSumOfDigit(int Number)
{
    int sum = 0;
    while(Number>0)
    {
        sum += Number % 10;
        Number /=10;
    } 
    return sum;
}
Console.WriteLine("Введите целое число");
int userNumber = Convert.ToInt32(Console.ReadLine());
int SumOfDigit = getSumOfDigit(Math.Abs(userNumber));
Console.WriteLine($"Сумма цифр числа {userNumber} равна {SumOfDigit}");

