//  Задача 8: Напишите программу, 
//  которая на вход принимает число (N), 
//  а на выходе показывает все чётные числа от 1 до N.

//  5 -> 2, 4
//  8 -> 2, 4, 6, 8

internal partial class Program
{
    private static void Main(string[] args)
    {
        Console.Clear();
        Console.WriteLine("Введите число: ");
        int number = Convert.ToInt32(Console.ReadLine());

        int c = Convert.ToInt32(1);

        for (c = 1; c <= number; c++)
        {
            if (c % 2 == 0)
            {
                Console.WriteLine("Четные числа: " + c);
            }

        }
    Console.ReadKey();
    }
}
