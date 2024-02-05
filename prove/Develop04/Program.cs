using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {

        List<int> i = new List<int>();

        i.Add(5);
        i.Add(6);
        i.Add(7);
        i.Add(8);

        foreach (int index in i )
        {
            Console.WriteLine(index);
        }


    }
}