using System;

class ExponentiationTest
{
    static void Main()
    {
        Exponentiation exponentiation = new Exponentiation();

        Console.WriteLine("\n\t\t<<<<<<<<< Exponentiation calculator >>>>>>>>>\n\n");

        Console.Write("Please enter the base value: ");
        int exponentiationtheBaseValue = int.Parse(Console.ReadLine());
        exponentiation.SetBaseValue(exponentiationtheBaseValue);

        Console.Write("\nPlease enter the exponent value: ");
        int exponentiationtheExponentValue = int.Parse(Console.ReadLine());
        exponentiation.SetExponentValue(exponentiationtheExponentValue);

        Console.WriteLine($"\n\nThe result for your calculation is: {exponentiation.IntegerPower()}");


    }
}

