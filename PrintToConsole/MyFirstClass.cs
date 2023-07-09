using System;

namespace PrintToConsole;

public class MyFirstClass
{
    public static void Main(string[] args)
    {
        Console.WriteLine("I love C#");
        Console.WriteLine("I Wanted to learn it");
        string i = "true";
        bool j = Convert.ToBoolean(i);

        Console.WriteLine(j.GetTypeCode());
        // To collect user input
        Console.WriteLine("Enter your name: ");
        String name = Console.ReadLine();
        
        Console.WriteLine("Your name is "+name);
        
        //to collect user input int
        Console.WriteLine("Enter your age: ");
        int age = Convert.ToInt32(Console.ReadLine());
        
        Console.WriteLine("You are "+ age+" years old");

        Console.WriteLine("Good day! your name is "+name+" and your age is "+age);
        Console.ReadKey();
    }
}