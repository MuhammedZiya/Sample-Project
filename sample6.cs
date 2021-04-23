using System.IO;
using System;

class Program
{
    static void Main(string[] args)
    {
        int[] arr=new int[4];
        int sum=0;
        Console.WriteLine("Enter the values");
        for(int i=0;i<arr.Length;i++){
            arr[i]=Convert.ToInt32(Console.ReadLine());
            sum=arr[i]+sum;
        }
        Console.WriteLine("Sum :" +sum);
        Console.ReadLine();
    }
}