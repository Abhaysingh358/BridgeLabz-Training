using System;
class DataTypes
{
    static void Main(string[] args)
    {
        // primitive data types
        int a = 10;
        float b = 20.5f;
        double c = 30.99;
        char d = 'A';
        bool e = true;
        byte value1 = 240;
        short f = 30000;
        long g = 123456789L;

        Console.WriteLine("Primitive Data Types:");
        Console.WriteLine("Integer: " + a);
        Console.WriteLine("Float: " + b);
        Console.WriteLine("Double: " + c);
        Console.WriteLine("Character: " + d);
        Console.WriteLine("Boolean: " + e);
        Console.WriteLine("Byte: " + value1);
        Console.WriteLine("Short: " + f);
        Console.WriteLine("Long: " + g);

        // type conversion of variable
        Console.WriteLine("\nType Conversion");

        // implicit conversion
        byte b1 = 10;     
        int i = b1;
        long l = i;
        float f2 = l;     
        double d2 = f2;

        

        Console.WriteLine("Implicit Conversions:");
        Console.WriteLine("Byte to Int: " + i);
        Console.WriteLine("Int to Long: " + l);
        Console.WriteLine("Long to Float: " + f2);
        Console.WriteLine("Float to Double: " + d2);

        // explicit conversion
        double d3 = 123.45;   
        int i2 = (int)d3;

        long l2 = 99999;
        short s2 = (short)l2;
        int a2 = 5;
        float b2 = (float)a2; // int to float
        double d4 = Convert.ToDouble(a2);    // int to double
        

        Console.WriteLine("\nExplicit Conversions:");
        Console.WriteLine("Double to Int: " + i2);
        Console.WriteLine("Long to Short: " + s2);
        Console.WriteLine(b2.ToString("0.00")); // float to string
        Console.WriteLine(d4.ToString("0.00")); // double to string
    }
}
