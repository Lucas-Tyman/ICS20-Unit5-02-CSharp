// Created by: Kenny Le
// Created on: Apr 2022
//
// This program determines if an integer is positive or negative

using System;

class Program
{
    public static void Main(string[] args)
    {
        // This program determines if an integer is positive or negativechanges in c
        int number;

        // input
        Console.WriteLine("Is your number positive or negative?");

        Console.WriteLine("");
        Console.Write("Please input an integer: ");
        number = Convert.ToInt32(Console.ReadLine());

        // process and output
        Console.WriteLine("");
        if (number > 0)
        {
            Console.WriteLine("Your number is positive!");
        }
        else
        {
            Console.WriteLine("Your number is negative!");
        }

        Console.WriteLine("\nDone.");
    }
}