using System;

class Program {
    static void Main(string[] args) {
        Console.WriteLine("Enter the low integer: ");
        int low = Convert.ToInt32(Console.ReadLine());
        
        Console.WriteLine("Enter the high integer: ");
        int high = Convert.ToInt32(Console.ReadLine());
        
        int difference = high - low;
        
        Console.WriteLine("The difference between the two integers is: " + difference);
    }
}
