Console.WriteLine("enter num: ");
int num = Convert.ToInt32(Console.ReadLine());
            do
            {
                num = num / 10;
 
                if (num < 100)
                {
                    Console.WriteLine(num.ToString().ToCharArray()[1]);
                }
            }
            while (num > 100);
