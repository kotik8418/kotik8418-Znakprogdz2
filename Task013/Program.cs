Console.WriteLine("enter n: ");
int n = Convert.ToInt32(Console.ReadLine());
if(n > 1000)
{
    Console.WriteLine((n / 100) % 10);
}
else
{
Console.WriteLine("маленькое число");
}