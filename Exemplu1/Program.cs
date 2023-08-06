//Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.
//456 -> 5
//782 -> 8
//918 -> 1


  static void Main(string[] args)
  {

// Ввод трехзначного числа с клавиатуры.
            Console.Write(Console.Write"Введите  число: ");
            
           int number = int.Parse(Console.ReadLine());

// Находим вторую цифру числа.
            
           int secondDigit = (number / 10) % 10;

           // Вывод результата
            Console.WriteLine(Console.WriteLine($"Rezult: {secondDigit}"));
  }
