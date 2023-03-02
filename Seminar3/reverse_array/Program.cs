//Написать метод для разворота массива, не используя память под дополнительный массив
int getInt(string msg){
  Console.Write(msg);
  return Convert.ToInt32(Console.ReadLine()); 
}
void reverseArray(int []arr){
  for(int i = 0; i < arr.Length / 2; i++){
    int temp = arr[i];
    arr[i] = arr[arr.Length - i - 1];
    arr[arr.Length - i - 1] = temp;
  }
  // return arr;
}
void printArray(int []arr){
  for(int i = 0; i < arr.Length; i++){
    Console.Write($"{arr[i]} ");
  }
  Console.WriteLine("");
}
int n = getInt("Введите размер массива: ");
int []arr = new int[n];
for(int i = 0; i < n; i++){
  arr[i] = getInt($"Введите {i+1} элемент массива: ");
}
reverseArray(arr);
printArray(arr);