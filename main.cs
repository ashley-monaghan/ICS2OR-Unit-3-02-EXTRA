// Created by: Ashley Monaghan
// Created on: Oct 2022
//
//This program calculates the volume of a rectangular pyramid

using System;

class Program
{
    public static void Main(string[] args)
    {
        // This function accepts user imput
        decimal length;
        decimal width;
        decimal height;
        decimal volume;

        Console.WriteLine("This program calculates the volume of a rectangular pyramid.");
        Console.WriteLine("");

        Console.Write("Enter the length (cm): ");
        length = Convert.ToDecimal(Console.ReadLine());
        Console.Write("Enter the width (cm): ");
        width = Convert.ToDecimal(Console.ReadLine());
        Console.Write("Enter the height (cm): ");
        height = Convert.ToDecimal(Console.ReadLine());

        volume = (length * width * height) / 3;

        Console.WriteLine("");
        Console.WriteLine("The volume is: " + volume.ToString("0.00") + " cm³. ");

        Console.WriteLine("\nDone.");
    }
}