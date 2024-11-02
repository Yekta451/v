
          Console.WriteLine("یک عدد وارد کنید:");
        int num = Convert.ToInt32(Console.ReadLine());

        int a = 0, b = 1, c = 0;
        bool isFibonacci = false;

        if (num == 0 , num == 1)
        {
            isFibonacci = true;
        }
        else
        {
            while (c<num)
            {
                c = a + b;
                a = b;
                b = c;
                if (c == num)
                {
                    isFibonacci = true;
                    break;
                }
            }
        }

        if (isFibonacci)
{
    Console.WriteLine("{num} جزو دنباله فیبوناچی است.");
}
else
{
    Console.WriteLine("{num} جزو دنباله فیبوناچی نیست.");
}
    }
}


