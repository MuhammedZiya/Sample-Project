using System.IO;
using System;
CLASS:
class Student
{
    public int RollNumber{get;set;}
    public int Name{get;set;}
    public int Gender{get;set;}
    
    static void Main()
    {
        Student student=new Student();
        student.RollNumber=1;
        student.Name="Ziya";
        student.Gender="male";
    
        Console.WriteLine(student.RollNumber+"\t"+student.Name+"\t"+student.Gender);
        Console.ReadLine();
    }
}