System.Console.WriteLine("Enter the your number");
int number;
number = Convert.ToInt32(Console.ReadLine());

if (number >= 10 && number <= 99)
{
    int a = number / 10 % 10;
    int b = number % 10;
    // System.Console.WriteLine(a);
    // System.Console.WriteLine(b);
    if (a > b)
    {
        System.Console.WriteLine(a);
    }
    else if (b > a)
    {
        System.Console.WriteLine(b);
    }
    else if (b == a ) // Для чисел по типу : 99, 77, 22.
    {
        System.Console.WriteLine(b);
    }
}   
else 
{
    System.Console.WriteLine("Please,try again");
}