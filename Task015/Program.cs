Console.WriteLine("enter day: ");
int n = Convert.ToInt32(Console.ReadLine());

int [] Alldays = {1,2,3,4,5,6,7};

int lin = Alldays.Length;
int find = n;
int index = 0;
int days = 7;

while (find > days)
        {
            Console.WriteLine("error");
            break;
        }

while (index < lin)
{
    if (Alldays[index]==find)
    {
        if (find == 6)
        {
            Console.WriteLine("yes first week");
        }
        if (find == 7)
        {
            Console.WriteLine("yes second week");
        }
        
        Console.WriteLine("worket!!!");
        break;
    }
    index++;
}

