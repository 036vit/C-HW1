Console.Clear ();
Console.Write ("Введите любое целое число  ");
int number = int.Parse (Console.ReadLine());
int result = number % 2;
if (result > 0)
{
Console.WriteLine("Это нечётное число");  
}
else
{
Console.WriteLine("Это чётное число");  
}