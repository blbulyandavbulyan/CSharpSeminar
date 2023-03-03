// Задача №17. Напишите программу, которая принимает на вход координаты точки (X и Y),
// причем X ≠ 0 и Y ≠ 0 и выдаёт номер четверти плоскости, в которой находится эта точка.
int getInt(string msg){
  Console.Write(msg);
  return Convert.ToInt32(Console.ReadLine());
}
int x = getInt("Введите X: ");
int y = getInt("Введите Y: ");
if(x > 0 && y > 0){
  Console.WriteLine(1);
}
else if(x < 0 && y > 0){
  Console.WriteLine(2);
}
else if(x < 0 && y < 0){
  Console.WriteLine(3);
}
else if(x > 0 && y < 0){
  Console.WriteLine(4);
}
else {
  Console.WriteLine("Для данной точки точно сказать невозможно");
}