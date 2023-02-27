// See https://aka.ms/new-console-template for more information
Random random = new Random();
int number = random.Next(10, 100);
Console.WriteLine(number);
int digit1 = number % 10;
int digit2 = number / 10;
int maximal_digit = Math.Max(digit1, digit2);
Console.WriteLine(maximal_digit);