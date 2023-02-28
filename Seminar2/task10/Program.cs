// Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.

// 456 -> 5
// 782 -> 8
// 918 -> 1
Console.Write("Введите число: ");
int n = Convert.ToInt32(Console.ReadLine());
if(n > 99 && n < 1000){
  int a = n / 100;//получаем количество сотен
  int c = n - a*100;//вычитаем из n сотни
  int result = c / 10;
  Console.WriteLine(result);
}
else Console.Error.WriteLine("Your number is wrong!");