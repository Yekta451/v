
            Console.WriteLine("دریافت عدد");

            string input = "";
            while (true)
            {
                ConsoleKeyInfo keyInfo = Console.ReadKey(true);
                if (keyInfo.Key == ConsoleKey.Enter)
                    break;

                if (char.IsDigit(keyInfo.KeyChar))
                {
                    input += keyInfo.KeyChar;
                    Console.Write(keyInfo.KeyChar);
                }
            }

            Console.WriteLine();
            Console.WriteLine("عدد وارد شده: " + input);
        }