Console.Clear ();
Console.Write ("Введите любое целое число  ");
int N = int.Parse (Console.ReadLine());
for (int step = 2; step < N; step = step + 2)
{
    Console.WriteLine(step);
}