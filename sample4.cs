using System.IO;
using System;

class Program
{
    static void Main(string[] args)
    {
        
        int age;
        Console.WriteLine("Enter Age :");
        age = Convert.ToInt32(Console.ReadLine());
        if (age >= 60)
                Console.Write("You are a senior citizen");
        else if (age >= 18)
            Console.Write("You are eligible to vote");
        else
            Console.Write("You are not eligible to vote");
        Console.ReadLine();
    }
}


