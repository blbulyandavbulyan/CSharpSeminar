// See https://aka.ms/new-console-template for more information
Console.Write("Введите число: ");
string userAnswer = Console.ReadLine();
int number = Convert.ToInt32(userAnswer);
int result = number * number;
Console.WriteLine("Квадрат числа: " + result);
