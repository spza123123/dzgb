System.Console.WriteLine("Введите число: ");
int num;
num = Convert.ToInt32(Console.ReadLine());
if (num % 7 == 0 && num % 23 == 0)
{
    System.Console.WriteLine("да"); //ПРИМЕР На  положительный вывод число 161
}
else
{
    System.Console.WriteLine("нет"); //ПРИВЕР На отрицательный вывод число 200
}

