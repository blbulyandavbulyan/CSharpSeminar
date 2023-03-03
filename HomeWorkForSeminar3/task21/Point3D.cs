
class Point3D{
  private int x;
  private int y;
  private int z;
  public Point3D(int x, int y, int z){
    this.x = x;
    this.y = y;
    this.z = z;
  }
  //метод для получения расстояния между текущей точкой и переданной сюда
  public double getDistance(Point3D p){
    return Math.Sqrt(Math.Pow(x - p.x, 2) + Math.Pow(y - p.y, 2) + Math.Pow(z - p.z, 2));
  }
  public static Point3D readPoint3DFromKeyboard(){
    Console.Write("Введите координату X: ");
    int x = Convert.ToInt32(Console.ReadLine());
    Console.Write("Введите координату Y: ");
    int y = Convert.ToInt32(Console.ReadLine());
    Console.Write("Введите координату Z: ");
    int z = Convert.ToInt32(Console.ReadLine());
    return new Point3D(x, y, z);
  }
}