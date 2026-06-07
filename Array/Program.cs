using System.Numerics;
using System;
using System.Collections.Generic;

namespace Array;

class Program
{
    static void Main(string[] args)
    {
        bool keepRunning = true;
        List<int> players = new List<int>();
        players.Add(1);
        players.Add(4);
        Console.WriteLine(players);


        while (keepRunning)
        {
            Console.WriteLine("\n=== C# Practice Menu ===");
            Console.WriteLine("1. Temperature Log");
            Console.WriteLine("2. Student Score Board");
            Console.WriteLine("3. Product Price Finder");
            Console.WriteLine("4. Race Finish Times");
            Console.WriteLine("5. Classroom Grade Report");
            Console.WriteLine("6. Warehouse Inventory Check");
            Console.WriteLine("7. Library Book Shelf Scanner");
            Console.WriteLine("8. Exit");
            Console.Write("Select a problem to run (1-8): ");

            string choice = Console.ReadLine();
            Console.WriteLine();

            switch (choice)
            {
                case "1": RunTemperatureLog(); break;
                case "2": RunStudentScoreBoard(); break;
                case "3": RunProductPriceFinder(); break;
                case "4": RunRaceFinishTimes(); break;
                case "5": RunClassroomGradeReport(); break;
                case "6": RunWarehouseInventoryCheck(); break;
                case "7": RunLibraryBookShelfScanner(); break;
                case "8":
                    keepRunning = false;
                    Console.WriteLine("Exiting program.");
                    break;
                default:
                    Console.WriteLine("Invalid selection. Please try again.");
                    break;
            }
        }
    }

    static void RunTemperatureLog()
    {
        Console.WriteLine("--- Problem 1: Temperature Log ---");
        List<double> temperatures = new List<double> { 32.1, 34.5, 33.0, 31.2, 35.6, 36.1, 34.2 };
        
        for (int i = 0; i < temperatures.Count; i++)
        {
            Console.WriteLine($"Day {i + 1}: {temperatures[i]} C");
        }
        Console.WriteLine($"Total readings: {temperatures.Count}");
    }

    static void RunStudentScoreBoard()
    {
        Console.WriteLine("--- Problem 2: Student Score Board ---");
        List<int> scores = new List<int> { 85, 92, 78, 90, 88, 76 };
        
        Console.WriteLine("Original Order:");
        foreach (int score in scores)
        {
            Console.WriteLine(score);
        }
        
        scores.Reverse();
        
        Console.WriteLine("\nReversed Order:");
        foreach (int score in scores)
        {
            Console.WriteLine(score);
        }
    }

    static void RunProductPriceFinder()
    {
        Console.WriteLine("--- Problem 3: Product Price Finder ---");
        List<double> prices = new List<double> { 4.99, 12.50, 8.99, 15.00, 3.50 };
        
        for (int i = 0; i < prices.Count; i++)
        {
            Console.WriteLine($"Product {i + 1}: {prices[i]}");
        }
        
        double targetPrice = 8.99;
        int priceIndex = prices.IndexOf(targetPrice);
        
        if (priceIndex != -1)
        {
            Console.WriteLine($"\nTarget price {targetPrice} found at index {priceIndex}");
        }
        else
        {
            Console.WriteLine($"\nTarget price {targetPrice} not found.");
        }
    }

    static void RunRaceFinishTimes()
    {
        Console.WriteLine("--- Problem 4: Race Finish Times ---");
        List<int> finishTimes = new List<int> { 320, 280, 310, 295, 275, 305, 330, 290 };
        
        Console.WriteLine("Original Times:");
        foreach (int time in finishTimes)
        {
            Console.WriteLine(time);
        }
        
        finishTimes.Sort();
        
        Console.WriteLine("\nSorted Times (Fastest First):");
        foreach (int time in finishTimes)
        {
            Console.WriteLine(time);
        }
        Console.WriteLine($"\nTotal participants: {finishTimes.Count}");
    }

    static void RunClassroomGradeReport()
    {
        Console.WriteLine("--- Problem 5: Classroom Grade Report ---");
        List<int> grades = new List<int> { 85, 92, 78, 90, 88, 76, 100, 65, 82, 95 };
        
        grades.Sort();
        grades.Reverse();
        
        for (int i = 0; i < grades.Count; i++)
        {
            Console.WriteLine($"Rank {i + 1}: {grades[i]}");
        }
    }

    static void RunWarehouseInventoryCheck()
    {
        Console.WriteLine("--- Problem 6: Warehouse Inventory Check ---");
        List<int> quantities = new List<int> { 15, 42, 8, 23, 19, 50, 4, 12 };
        int totalStock = 0;
        
        for (int i = 0; i < quantities.Count; i++)
        {
            totalStock += quantities[i];
        }
        
        Console.WriteLine($"Total stock: {totalStock}");
        Console.WriteLine($"Average stock: {(double)totalStock / quantities.Count}");
        
        int targetQty = 23;
        int qtyIndex = quantities.IndexOf(targetQty);
        
        if (qtyIndex != -1)
        {
            Console.WriteLine($"Target quantity {targetQty} found at slot index {qtyIndex}");
        }
        else
        {
            Console.WriteLine($"Target quantity {targetQty} not found");
        }
    }

    static void RunLibraryBookShelfScanner()
    {
        Console.WriteLine("--- Problem 7: Library Book Shelf Scanner ---");
        List<int> copies = new List<int> { 3, 5, 1, 0, 8, 2, 4, 12, 0 };
        
        Console.WriteLine("Original Copies List:");
        foreach (int copy in copies)
        {
            Console.WriteLine(copy);
        }
        
        copies.Sort();
        
        Console.WriteLine("\nSorted Copies List:");
        foreach (int copy in copies)
        {
            Console.WriteLine(copy);
        }
        
        Console.WriteLine($"\nMost copies available for a single title: {copies[copies.Count - 1]}");
        
        bool hasZero = false;
        for (int i = 0; i < copies.Count; i++)
        {
            if (copies[i] == 0)
            {
                hasZero = true;
                break;
            }
        }
        
        if (hasZero)
        {
            Console.WriteLine("Alert: There is at least one title with zero copies.");
        }
        else
        {
            Console.WriteLine("All titles currently have at least one copy.");
        }
    }
}
    
