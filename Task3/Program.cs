using System;
using System.IO;

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

        int[] numbers = new int[high - low + 1];

        for (int i = 0; i < numbers.Length; i++) {
            numbers[i] = low + i;
        }

        using (StreamWriter file = new StreamWriter("numbers.txt")) {
            for (int i = numbers.Length - 1; i >= 0; i--) {
                file.WriteLine(numbers[i]);
            }
        }

        Console.WriteLine("Output to 'numbers.txt'.");
    }
}

