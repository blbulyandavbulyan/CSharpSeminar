// Задача 4: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.

// 2, 3, 7 -> 7
// 44 5 78 -> 78
// 22 3 9 -> 22
Console.Write("Введите 1 число: ");
int max = Convert.ToInt32(Console.ReadLine());
for(int i = 0; i < 2; i++){
    Console.Write("Введите " + (i+2) + " число: ");
    int n = Convert.ToInt32(Console.ReadLine());
    if(i == 0){
      max = n; 
    }
    if(n > max)max = n;

}
Console.WriteLine("Максимальное " + max);