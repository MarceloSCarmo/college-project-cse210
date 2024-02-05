using System;
using System.ComponentModel;
using System.IO.Pipes;

class Program
{
    static void Main(string[] args)
    {

        Fraction fraction1 = new Fraction();
        Fraction fraction2 = new Fraction(5);
        Fraction fraction3 = new Fraction(3,4);
        
        //DISPLAY
        Console.WriteLine(fraction1.GetFractionString());
        Console.WriteLine(fraction1.GetDecimalValue());

        Console.WriteLine(fraction2.GetFractionString());
        Console.WriteLine(fraction2.GetDecimalValue());

        Console.WriteLine(fraction3.GetDecimalValue());
        Console.WriteLine(fraction3.GetFractionString());

        fraction3.SetTop(1);
        fraction3.SetBottom(3);

        Console.WriteLine(fraction3.GetDecimalValue());
        Console.WriteLine(fraction3.GetFractionString());
    }

}