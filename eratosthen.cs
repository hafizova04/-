using System;
namespace App
{
    class Pogram
    {
        static void Main() 
        {
            int n = int.Parse(Console.ReadLine());
            bool [] A = new bool [n];
            for (int i = 2; i < n; i++) A [i]= true;
            for (int i= 2 ;i*i <= n ; ++i)
            {
                if (A[i])
                {
                    for(int y = i*i; y< n; y+=i)
                    {
                        A[y]=false;
                    }
                }
            }
            Console.WriteLine();
            for(int i=2;i<n;i++)
            {
                if(A[i]) Console.Write($"{i} ");
            }
        }
    }
}