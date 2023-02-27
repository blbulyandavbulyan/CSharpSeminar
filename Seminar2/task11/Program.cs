// Напишите программу, которая выводит случайное трехзначное число и удаляет вторую цифру этого числа.
int random_number = Random.Shared.Next(100, 1000);
Console.WriteLine(random_number);
int first_digit = random_number / 100; // первая цифра трёхзначного числа
int last_digit = random_number % 10;// последняя цифра трёхзначного числа
int result = first_digit * 10 + last_digit;// формула разложения двухзначного числа по разрядам
Console.WriteLine(result);