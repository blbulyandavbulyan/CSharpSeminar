Console.WriteLine("Введите N: ");
int n = Convert.ToInt32(Console.ReadLine());
for(int i = 1; i <= n; i++){
  if(i != n){
    Console.Write($"{i*i}, ");
  }
  else Console.WriteLine(Math.Pow(i, 2));
}