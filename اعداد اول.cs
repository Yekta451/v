
        {
            Console.WriteLine("دریافت عدد اول");
            int num1 = int.Parse(Console.ReadLine());

            Console.WriteLine("دریافت عدد دوم ");
            int num2 = int.Parse(Console.ReadLine());

            Console.WriteLine("اعداد اول بین {0} و {1} عبارتند از:",num1,num2 );
            for (int i = Math.Min(num1, num2); i <= Math.Max(num1, num2); i++)
            {
                if (IsPrime(i))
                {
                    Console.WriteLine(i);
                }
            }
        }

        static bool IsPrime(int number)
        {
            if (number <= 1) return false;
            for (int i = 2; i <= Math.Sqrt(number); i++)
            {
                if (number % i == 0) return false;
            }
            return true;
