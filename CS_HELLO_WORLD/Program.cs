using System;
class Program {
    static void Main() {
        PrintToConsole();
        PrintWeekdays();
    }

    static void PrintToConsole() {
        Console.WriteLine("Hello, C#");
    }

    static void PrintWeekdays() {
        string[] days = new string[1];
        days = ["Monday", "Tuesday", "Wednesday"];

        foreach(string day in days){
            Console.WriteLine($"{day}");
        }
    }
}