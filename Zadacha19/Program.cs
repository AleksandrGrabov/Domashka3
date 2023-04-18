// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
// 14212 -> нет
// 12821 -> да
// 23432 -> да


Console.WriteLine("Введите пятизначное число:");
            string input = Console.ReadLine();

            if (input.Length != 5)
            {
                Console.WriteLine("Ошибка: введите пятизначное число.");
                return;
            }

            bool isPalindrome = input[0] == input[4] && input[1] == input[3];

            if (isPalindrome)
            {
                Console.WriteLine("да");
            }
            else
            {
                Console.WriteLine("нет");
            }