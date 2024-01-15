using System;
using System.Collections.Generic;
using System.IO;

class Program {
    private const string OUTPUT_FILE_NAME = "numbers.txt";

    static void Main(string[] args) {
        Util u = new Util();

        /**********************/
        /**** BEGIN INPUTS ****/
        /**********************/
        double dl = u.queryInput(0, "low");
        double dh = u.queryInput(dl, "high");
        List<double> l = new List<double>();
        for (double d = dl; d <= dh; d++) {
            l.Add(d);
        }

        /**********************/
        /**** BEGIN OUTPUT ****/
        /**********************/
        l.Reverse();
        using (StreamWriter file = new StreamWriter(OUTPUT_FILE_NAME)) {
            foreach (double d in l) {
                file.WriteLine(d);
                if (u.isPrime(d)) {
                    Console.WriteLine(d + " is a prime number.");
                }
            }
        }
        Console.WriteLine("Output to '" + OUTPUT_FILE_NAME + "'.");

        /**********************/
        /** BEGIN INPUT FILE **/
        /**********************/
        try {
            List<double> l2 = new List<double>();
            using (StreamReader sr = new StreamReader(
                File.Open(OUTPUT_FILE_NAME, FileMode.Open), true)) {
                string line;
                while ((line = sr.ReadLine()) != null) {
                    double d = double.Parse(line);
                    l2.Add(d);
                }
            }
            double d3 = 0;
            foreach (double d2 in l2) {
                d3 += d2;
            }
            Console.WriteLine("The sum is: " + d3);
        }
        catch (Exception e) {
        }
    }

    class Util {
        public double queryInput(double minValueIn, string descriptionIn) {
            while (true) {
                Console.Write("Enter the " + descriptionIn + " value: " );
                double d;
                try {
                    d = Convert.ToInt32(Console.ReadLine());
                    if (isValid(d, minValueIn)) {
                        return d;
                    } else {
                        Console.WriteLine("Entered value " + d +
                        " does not satisfy requirements (larger than " +
                        minValueIn + "). Try again.");
                    }
                } catch (Exception e) {
                    Console.WriteLine("Invalid input, try again.");
                }
            }
        }

        public bool isValid(double valueIn, double lowestValueIn) {
            return valueIn > lowestValueIn;
        }

        public bool isPrime(double valueIn) {
            for (double d = 2; d < valueIn; d++) {
                if (valueIn % d == 0) {
                    return false;
                }
            }
            return true;
        }
    }
}
    
    
    
