/*Задача 29
 Напишите программу, в которой пользователь задает длину массива,
элементы которого задаются в диапазоне [1,99] и выводит на экран.
*/
int[] CreateArray(int Number)
{
    int[] array = new int[Number];
    for(int i = 0; i < Number; i++)
    {
        array[i] = new Random().Next(1,100);
    }
    return array;
}
void PrintArray(int[] array)
{
    Console.Write("[");
    for(int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i]);
        if(i < array.Length -1)
        {
            Console.Write(", ");
        }
    }
    Console.WriteLine("]");
}
Console.WriteLine("Введите длину массива");
int userNumber = Convert.ToInt32(Console.ReadLine());
int[] userArray = CreateArray(userNumber);
PrintArray(userArray);
