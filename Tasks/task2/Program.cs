System.Console.WriteLine("Введите x: ");
int x;
int y;
x = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine("Введите y: ");
y = Convert.ToInt32(Console.ReadLine());
if (x > 0 && y > 0)
{
    System.Console.WriteLine("1");
}
else if (x < 0 && y < 0)
{
    System.Console.WriteLine("3");
}
else if (x > 0 && y < 0)
{
    System.Console.WriteLine("4");
}
else if (x < 0 && y > 0)
{
    System.Console.WriteLine("2");
}