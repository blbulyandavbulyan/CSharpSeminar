
int a = Convert.ToInt32(Console.ReadLine());
int b = Convert.ToInt32(Console.ReadLine());
int c = a % b;
if(c == 0){
  Console.WriteLine("кратно");
}
else {
  Console.WriteLine("не кратно, остаток " + c);
}