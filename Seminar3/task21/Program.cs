// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 2D пространстве.

// A (3,6); B (2,1) -> 5,09 
// A (7,-5); B (1,-1) -> 7,21
int getInt(){
  return Convert.ToInt32(Console.ReadLine());
}
Console.WriteLine("Введите координаты точки A и B: ");
Console.Write("Введите A_x: ");
int x1 = getInt();
Console.Write("Введите A_y: ");
int y1 = getInt();
Console.Write("Введите B_x: ");
int x2 = getInt();
Console.Write("Введите B_y: ");
int y2 = getInt();
double d = Math.Sqrt(Math.Pow(x1 - x2, 2) + Math.Pow(y1 - y2, 2));
Console.WriteLine(d);