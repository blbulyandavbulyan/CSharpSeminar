// Напишите программу, которая принимает на вход число и проверяет, кратно ли оно одновременно 
// 7 и 23.

// 14 -> нет 
// 46 -> нет 
// 161 -> да
Console.Write("Введите число: ");
int n = Convert.ToInt32(Console.ReadLine());

if(n % 7 == 0 && n % 23 == 0){
  Console.WriteLine("да");
}
else {
  Console.WriteLine("нет");
}