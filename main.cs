using System;

class Program
{
    static void Main(string[] args) {

        Console.Write("\n enter your first name : ");
        string firstName = Console.ReadLine();
        Console.Write("\n enter your surname : ");
        string lastName = Console.ReadLine();
        Console.Write("\n enter your student ID : ");
        int studentID = Convert.ToInt32(Console.ReadLine());
        Console.Write("\n enter year of birth : ");
        int yearOfBirth = Convert.ToInt32(Console.ReadLine());
        Console.Write("\n enter current year : ");
        int currentYear = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine($"\n {firstName} {lastName}");
        Console.WriteLine($"\n {currentYear - yearOfBirth}");
    }
    
};
