using System;

class Program {
    static void Main(string[] args) {
        int low;
        do {
            Console.WriteLine("Enter a positive low number:");
            low = Convert.ToInt32(Console.ReadLine());
        }
        while (low < 0);
        
        int high;
        do {
            Console.WriteLine("Enter a high number greater than the low number:");
            high = Convert.ToInt32(Console.ReadLine());
        }
        while (high <= low);
    }
}
