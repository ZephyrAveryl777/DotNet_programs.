using System;
using System.Collections.Generic;
namespace SampleApp
{
    internal class Program
    {
        private static void Main() // Progrma.cs 
        {
            List<double> number = new List<double>(); // collection of data 
            Console.Write("Size of data to be added are: "); // Defining Size input for list (need to be improved).
            int size = int.Parse(Console.ReadLine());
            for (int i = 0; i < size; i++) // Continue For Loop until i is < the needed amount.
            {
                Console.Write($"Enter data at position {i+1} to list: "); // Asks for user input into array.
                int ListInput = int.Parse(Console.ReadLine()); // User inputs value into field.
                number.Add(ListInput); // adding to list
            }
            double mean = number.Mean(); // calculating mean
            double variance = number.Variance(); // calculating variance 
            double sd = number.StandardDeviation(); // calculating standardDeviation
 
            Console.WriteLine("\nMean: {0}  , Variance: {1}  , SD: {2}  ",  //output
                               mean, variance, sd);
            Console.ReadKey();
        }
    }
    public static class list
    {
        public static double Mean(this List<double> values)// calculating mean function
        {
            return values.Count == 0 ? 0 : values.Mean(0, values.Count);// if value =0 mean =0, use of short-hand if-else
        }
 
        public static double Mean(this List<double> values, 
                                  int start, int end)
        {
            double s = 0;
 
            for (int i = start; i < end; i++)
            {
                s += values[i];
            }
 
            return s / (end - start);//mean == avg = tital/size, (size = end-start)
        }
 
        public static double Variance(this List<double> values)
        {
            return values.Variance(values.Mean(), 0, values.Count);
        }
 
        public static double Variance(this List<double> values, double mean)
        {
            return values.Variance(mean, 0, values.Count);
        }
 
        public static double Variance(this List<double> values, double mean, 
                                      int start, int end)
        {
            double variance = 0;
 
            for (int i = start; i < end; i++)
            {
                variance += Math.Pow((values[i] - mean), 2);
            }
 
            int n = end - start;
            if (start > 0) n -= 1;
 
            return variance / (n);
        }
        public static double StandardDeviation(this List<double> values)
        {
            return values.Count == 0 ? 0 : values.StandardDeviation(0, values.Count);
        }
        public static double StandardDeviation(this List<double> values, 
                                               int start, int end)
        {
            double mean = values.Mean(start, end);
            double variance = values.Variance(mean, start, end);
            return Math.Sqrt(variance);
        }
    }
}
