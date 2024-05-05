//using System;

//public class NumberAnalyzer
//{
//    public string AnalyzeNumber(int number)
//    {
//        if (number > 0)
//        {
//            return "Number is positive";
//        }
//        else
//        {
//            return "Number is non-positive";
//        }
//    }
//}


//public class MenuHandler
//{
//    public string GetChoice()
//    {
//        Console.WriteLine("Enter your choice (A, B, or anything else): ");
//        return Console.ReadLine();
//    }

//    public void ProcessChoice(string choice)
//    {
//        switch (choice)
//        {
//            case "A":
//                Console.WriteLine("You chose A");
//                break;
//            case "B":
//                Console.WriteLine("You chose B");
//                break;
//            default:
//                Console.WriteLine("Invalid choice");
//                break;
//        }
//    }
//}


//public class Looper
//{
//    public void ForLoop(int iterations)
//    {
//        for (int i = 0; i < iterations; i++)
//        {
//            Console.WriteLine($"for loop: {i}");
//        }
//    }

//    public void WhileLoop(int targetCount, int initialCount)
//    {
//        while (initialCount < targetCount)
//        {
//            Console.WriteLine($"while loop: {initialCount}");
//            initialCount++;
//        }
//    }

//    public void DoWhileLoop(int iterations)
//    {
//        int count = 0;
//        do
//        {
//            Console.WriteLine($"do-while loop: {count}");
//            count++;
//        } while (count < iterations);
//    }

//    public void ForeachLoop(string[] items)
//    {
//        foreach (string item in items)
//        {
//            Console.WriteLine($"Hello, {item}");
//        }
//    }

//    public void JumpStatements(int iterations)
//    {
//        for (int i = 0; i < iterations; i++)
//        {
//            if (i == 2)
//            {
//                continue;
//            }
//            if (i == 4)
//            {
//                break;
//            }

//            Console.WriteLine($"Jump statement: {i}");
//        }
//    }
//}

//class Program
//{
//    static void Main(string[] args)
//    {
//        NumberAnalyzer analyzer = new NumberAnalyzer();

//        int number = 10;

//        Console.WriteLine(analyzer.AnalyzeNumber(number));

//        MenuHandler menu = new MenuHandler();

//        string choice = menu.GetChoice();

//        menu.ProcessChoice(choice);

//        Looper looper = new Looper();

//        looper.ForLoop(5);

//        looper.WhileLoop(10, 0);

//        looper.DoWhileLoop(2);

//        string[] names = { "John", "Mary", "Peter" };

//        looper.ForeachLoop(names);

//        looper.JumpStatements(5);
//    }
//}