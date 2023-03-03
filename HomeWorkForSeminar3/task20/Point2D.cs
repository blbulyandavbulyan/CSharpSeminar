class Point2D{
  private int x;
  private int y;
  public Point2D(int x, int y){
    this.x = x;
    this.y = y;
  }
  public double getDistance(Point2D p){
    return Math.Sqrt(Math.Pow(x - p.x, 2) + Math.Pow(y - p.y, 2));
  }
  public static Point2D readPointFromKeyBoard(){
    Console.Write("Введите X: ");
    int x = Convert.ToInt32(Console.ReadLine());
    Console.Write("Введите Y: ");
    int y = Convert.ToInt32(Console.ReadLine());
    return new Point2D(x, y);
  }
}