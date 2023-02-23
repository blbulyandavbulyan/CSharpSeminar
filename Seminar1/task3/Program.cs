// Задача №3. Напишите программу, которая будет выдавать название дня недели по заданному номеру.
// 3 -> Среда 
// 5 -> Пятница
string []days = {"Понедельник", "Вторник", "Среда", "Четверг", "Пятница", "Суббота", "Воскресенье"};
Console.Write("Введите номер дня: ");
int numberOfDay = Convert.ToInt32(Console.ReadLine());
if(numberOfDay > 7 | numberOfDay < 1){
  Console.WriteLine("Вы ввели неправильный номер дня!");
}
else Console.WriteLine(days[numberOfDay - 1]);
