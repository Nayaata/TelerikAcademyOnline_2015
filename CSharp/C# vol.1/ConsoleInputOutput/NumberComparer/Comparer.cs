﻿//Problem 4. Number Comparer
//
//Write a program that gets two numbers from the console and prints the greater of them.
//Try to implement this without if statements.

using System;

class Comparer
{
    static void Main()
    {
        Console.Write("Please enter first number A: ");
        double a = double.Parse(Console.ReadLine());

        Console.Write("Please enter second number B: ");
        double b = double.Parse(Console.ReadLine());

        double greaterAB = Math.Max ( a, b);
        Console.WriteLine("The greater number is " + greaterAB);

    }
}

