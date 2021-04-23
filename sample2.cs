using System.IO;
using System;

class Program
{
    static void Main(string[] args)
    {
        int firstNumber,secondNumber,result;
        Console.WriteLine("Enter FirstNumber :");
        firstNumber = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Enter SecondNumber :");
        secondNumber = Convert.ToInt32(Console.ReadLine());
        result= firstNumber + secondNumber;
        Console.WriteLine("Sum of two numbers is : "+result);
        Console.ReadLine();
    }
}