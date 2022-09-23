/*Напишите программу, которая принимает
 на вход пятизначное число и проверяет, является ли оно палиндромом.*/
 Console.Clear();
Console.WriteLine("Введите пятизначное число:");
string input = Console.ReadLine();
int number = int.Parse(input);
int num1 = number / 10000 % 10;
int num2 = number / 1000 % 10;
int num4 = number / 10 % 10;
int num5 = number % 10;

if (number > 9999 && number < 100000)
{
    if  (num1 == num5 && num2 == num4){
            Console.WriteLine(number + "  Палиндром");
            }
            else{
            Console.WriteLine(number + "  Не палиндром");
            }
            
}
else 
{
    Console.WriteLine("Введено не пятизначное число!");
}
 