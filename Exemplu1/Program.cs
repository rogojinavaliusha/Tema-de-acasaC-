

// Ввод трехзначного числа с клавиатуры
            Console.Write(Console.Write"Введите трехзначное число: ");
            
           int number = int.Parse(Console.ReadLine());

// Находим вторую цифру числа
            
           int secondDigit = (number / 10) % 10;

           // Вывод результата
            Console.WriteLine(Console.WriteLine($"Вторая цифра числа: {secondDigit}"));

