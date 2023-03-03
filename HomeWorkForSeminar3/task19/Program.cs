// Задача 19

// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.

// 14212 -> нет

// 12821 -> да

// 23432 -> да
bool checkPolindrom(int number){
  int count_digits = number.ToString().Length;//жулничество, перевёл в строку чтоб узнать сколько цифр в числе
  int reversed_number = 0;
  //в данном цикле счётчик i нужен для получения цифр с конца, а счётчик j цифр с начала
  for(int i = number, power = count_digits - 1; i >= 1; i /= 10, power--){
    int digit = i % 10;
    reversed_number += digit*(int)Math.Pow(10, power);
  }
  return number == reversed_number;
}
Console.Write("Введите число: ");
int n = Convert.ToInt32(Console.ReadLine());
Console.WriteLine(checkPolindrom(n) ? "да" : "нет");