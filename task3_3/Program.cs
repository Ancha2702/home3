/*Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.*/
Console.WriteLine("Введите число:");
int n = int.Parse(Console.ReadLine()!);
int count = 1;
for (count =1; count <= n; count++)
{
    Console.Write(Math.Pow(count,3));
    if (count != n)
    {   
    Console.Write(", ");
    }
}
Console.WriteLine(" ");