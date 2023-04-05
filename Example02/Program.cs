//Задача 4: Напишите программу,
//которая принимает на вход три числа и выдаёт максимальное из этих чисел.

//  2, 3, 7 -> 7
//  44, 5, 78 -> 78
//  22, 3, 9 -> 22

Console.Clear();
Console.Write("Введите А: ");
int numA = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите B: ");
int numB = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите C: ");
int numC = Convert.ToInt32(Console.ReadLine());
int max = Convert.ToInt32(0);

string maxLetter = "";

if (max < numA)
{
    max = numA;
    maxLetter = "A";
}
if (max < numB)
{
    max = numB;
    maxLetter = "B";
}
if (max < numC)
{
    max = numC;
    maxLetter = "C";
}

Console.WriteLine(maxLetter + " is max and = " + max);

Console.ReadKey();