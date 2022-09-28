/*Задача 25: Напишите цикл, который принимает на вход два числа (A и B)
 и возводит число A в натуральную степень B.
 */
int getPower(int basis, int power)
{
    int result = 1;
    for(int i = 1; i <= power; i++)
    {
        result *= basis;
    }
    return result;
}
Console.WriteLine("Введите целое число A и натуральное число B");
int userBasis = Convert.ToInt32(Console.ReadLine());
int userPower = Convert.ToInt32(Console.ReadLine());
int isPower = getPower(userBasis,userPower);
Console.WriteLine($"{userBasis} ^ {userPower} = {isPower}");