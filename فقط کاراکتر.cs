
            Console.WriteLine("دریافت کاراکتر");

            string input = "";
            while (true)
            {
                ConsoleKeyInfo keyInfo = Console.ReadKey(true);
                if (keyInfo.Key == ConsoleKey.Enter)
                    break;

                if (char.IsLetter(keyInfo.KeyChar))
                {
                    input += keyInfo.KeyChar;
                    Console.Write(keyInfo.KeyChar);
                }
            }

            Console.WriteLine();
            Console.WriteLine("کاراکتر‌های وارد شده " + input);
        