using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
class Program {
    public static void Main(string[] args)
    {
        int Number = 8;


        //Cria Fatorial
        IEnumerable<int> ints = Enumerable.Range(1, Number);
        int factorial = ints.Aggregate((f, s) => f * s);
        Console.WriteLine(factorial);

        List<int> fibs = new List<int>();
        Enumerable.Range(0, Number)
            .ToList()
            .ForEach(f => fibs.Add((f <= 1 ? 1 : fibs[f - 2] + fibs[f - 1])));
        Console.WriteLine(fibs[Number-1].ToString());


        /*
        int Pos = 10;
        int[] Num_Fib = Fibonacci(Pos);
        int res = (from fib in Num_Fib orderby fib descending select fib).FirstOrDefault();
        Console.WriteLine(res);


        int[] Num_Fact = Fatorial(5);

        res = (from fac in Num_Fact orderby fac descending select fac).FirstOrDefault();
        Console.WriteLine("Resultado factorial: "+ res.ToString());*/

    }
    /*
    public static int[] Fibonacci(int Num)
    {

        int[] Fib = new int[Num];

        Fib[0] = 0;
        Fib[1] = 1;
        for (int i = 2; i < Num; i++)
        {
            Fib[i] = Fib[i - 2] + Fib[i - 1];
        }

        return Fib;
    }


    public static int[] Fatorial(int Num)
    {

        int[] Fact = new int[Num+1];

        Fact[0] = 1;
        Fact[1] = 1;
        for (int i = 2; i <= Num; i++)
        {
            Fact[i] = Fact[i - 1] * i;
        }

        return Fact;
    }*/

}