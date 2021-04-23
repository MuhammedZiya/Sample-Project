using System.IO;
using System;

class Program
{
    static void Main(string[] args)
    {
        int age;
        Console.WriteLine("Enter Age :");
        age = Convert.ToInt32(Console.ReadLine());
        if(age >=18){
            Console.WriteLine("He is eligible to vote");
        }
        else{
            Console.WriteLine("He is not eligible to vote");
        }
        
        Console.ReadLine();
        
    }
}


