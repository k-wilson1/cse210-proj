using System;

class Program
{
    static void Main(string[] args)
    {
        // Fraction f1 = new Fraction();
        // Console.WriteLine(f1.GetFractionString());

        // Fraction f2 = new Fraction(6);
        // Console.WriteLine(f2.GetFractionString());

        // Fraction f3 = new Fraction(6,7);
        // Console.WriteLine(f3.GetFractionString());

        // Fraction f = new Fraction();
        // f.SetTop(5);
        // Console.WriteLine(f.GetFractionString());

        // f.SetBottom(10);
        // Console.WriteLine(f.GetFractionString());

        // f.SetTop(8);
        // f.SetBottom(3);
        // Console.WriteLine(f.GetFractionString());

        Fraction f5 = new Fraction(1,3);
        Console.WriteLine(f5.GetFractionString());
        Console.WriteLine(f5.GetDecimalValue());
    }
}