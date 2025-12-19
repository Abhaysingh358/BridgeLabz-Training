using System;
class Operators
{
    static void Main(string[] args)
    {
        int a = 10;
        int b = 5;
        // Using arithmetic operators

        Console.WriteLine("Addition: " + (a + b)); // 15
        Console.WriteLine("Subtraction: " + (a - b)); // 5
        Console.WriteLine("Multiplication: " + (a * b)); // 50
        Console.WriteLine("Division: " + (a / b)); // 2
        Console.WriteLine("Modulus: " + (a % b)); // 0 

        // Using assignment operators
        a += b; // a = a + b
        Console.WriteLine("a += b: " + a); // 15

        a -= b; // a = a - b
        Console.WriteLine("a -= b: " + a); // 10

        a *= b; // a = a * b
        Console.WriteLine("a *= b: " + a); // 50

        a /= b; // a = a / b
        Console.WriteLine("a /= b: " + a); // 10

        a %= b; // a = a % b
        Console.WriteLine("a %= b: " + a); // 0

        // Using relational operators

        Console.WriteLine("a == b: " + (a == b)); // false
        Console.WriteLine("a != b: " + (a != b)); // true
        Console.WriteLine("a > b: " + (a > b)); // true
        Console.WriteLine("a < b: " + (a < b)); // false
        Console.WriteLine("a >= b: " + (a >= b)); // true
        Console.WriteLine("a <= b: " + (a <= b)); // false

        // Using instanceof operator
        Animal animal = new Dog();
        Console.WriteLine("animal is Animal: " + (animal is Animal)); // true
        Console.WriteLine("animal is Dog: " + (animal is Dog)); // true
        Console.WriteLine("animal is String: " + (animal is string)); // false

        // Using logical operators
        bool x = true;
        bool y = false;
        Console.WriteLine("x && y: " + (x && y)); // false
        Console.WriteLine("x || y: " + (x || y)); // true
        Console.WriteLine("!x: " + (!x)); // false
        Console.WriteLine("!y: " + (!y)); // true

        // unary operators
        Console.WriteLine("a: " + a); // 5
        Console.WriteLine("++a: " + ++a); // 6 (pre-increment)
        Console.WriteLine("a++: " + a++); // 6 (post-increment)
        Console.WriteLine("a: " + a); // 7
        Console.WriteLine("--a: " + --a); // 6 (pre-decrement)
        Console.WriteLine("a--: " + a--); // 6 (post-decrement)
        Console.WriteLine("a: " + a); // 5

        // ternary operator
        int max = (a > b) ? a : b;

        Console.WriteLine("Max: " + max); // 20
    }
}

class Animal { }

class Dog : Animal { }