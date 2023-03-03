// Задача 20: Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 2D пространстве.
// A (3,6); B (2,1) -> 5,10
// A (7,-5); B (1,-1) -> 7,21
// Point2D p = new Point2D(2, 2);
Console.WriteLine("Введите координаты точки A: ");
Point2D a = Point2D.readPointFromKeyBoard();
Console.WriteLine("Введите координаты точки B: ");
Point2D b = Point2D.readPointFromKeyBoard();
Console.WriteLine(a.getDistance(b));
