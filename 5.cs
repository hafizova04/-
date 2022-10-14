using System;

int[] Array = new int[100];
Random rnd = new Random(DateTime.Now.Millisecond);

int i;
for (i = 0; i < Array.Length; i++)
{
    int x = rnd.Next(1001);
    Array[i] = rnd.Next(2) == 0 ? x : -x;
    //Console.Write(Array[i] + ", ");
}

Console.WriteLine("Случайные чётные числа:");
for (i = 0; i < Array.Length; i++)
{
    if (Array[i] % 2 == 0)
    {
    Console.Write(Array[i] + ", ");
    }
}
Console.WriteLine("\nСлучайные числа кратные 3");
for (i = 0; i < Array.Length; i++)
{
    if (Array[i] % 3 == 0)
    {
        Console.Write(Array[i] + ", ");
    }
}
Console.WriteLine("\nСумма всех случайных отрицательных чисел");

int count = 0;
for (i = 0; i< Array.Length; i++)
{
    if (Array[i] < 0)
    {
        count += Array[i];
    }
}
Console.Write(count);