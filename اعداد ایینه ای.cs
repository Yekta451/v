
            Console.WriteLine("دریافت عدد اول");
            int n = int.Parse(Console.ReadLine());

            Console.WriteLine("دریافت عدد دوم");
            int M = int.Parse(Console.ReadLine());

            Console.WriteLine("اعداد آیینه‌ای بین {0} و {1} عبارتند از:", n, M);
            for (int i = Math.Min(n, M); i <= Math.Max(n, M); i++)
            {
                if (IsMirrorNumber(i))
                {
                    Console.WriteLine(i);
                }
            }
        }

        static bool IsMirrorNumber(int number)
        {
            int original = number;
            int reverse = 0;

            while (number > 0)
            {
                reverse = reverse * 10 + number % 10;
                number /= 10;
            }

            return original == reverse;
        }
