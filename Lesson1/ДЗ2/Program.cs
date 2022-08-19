Console.Clear ();
Console.Write ("Введите первое число  ");
int number1 = int.Parse (Console.ReadLine());
Console.Write ("Введите второе число  ");
int number2 = int.Parse (Console.ReadLine());
Console.Write ("Введите третье число  ");
int number3 = int.Parse (Console.ReadLine());
int maximum;
if (number1<number2)
{
maximum = number2;
}
else
{
maximum = number1;
}
if (maximum<number3)
{
maximum = number3;
}
else
{
maximum = maximum;
}
Console.WriteLine($"Большим числом является {maximum}");