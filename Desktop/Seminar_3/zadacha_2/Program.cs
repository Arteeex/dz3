Console.Clear();

int a = Convert.ToInt32(Console.ReadLine());

int count = 0;
for (int i = 1; i<a+1; i++)
{
    count = Convert.ToInt32(Math.Pow(i, 3));
    System.Console.WriteLine(count);
}