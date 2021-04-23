using System.IO;
using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter what you want to do. \n 1.add \n 2.sub");
        int Choice=Convert.ToInt32(Console.ReadLine());
        switch(Choice){
            case 1:
                Console.WriteLine("Add");
                break;
            case 2:
                Console.WriteLine("SUB");
                break;
            default:
                Console.WriteLine("nthg");
                break;
        }
        Console.ReadLine();
    }
}