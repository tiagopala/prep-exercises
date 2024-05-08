﻿namespace HackerRank.Sorting;

internal class InsertionSortPart1
{
    // You could check the full problem at www.hackerrank.com/challenges/insertionsort1/problem

    private static void PrintArray(List<int> array)
    {
        for (int j = 0; j < array.Count; j++)
        {
            Console.Write($"{array[j]} ");
        }

        Console.Write("\n");
    }

    private static void InsertionSort(int n, List<int> arr)
    {
        int lastValue = 0;

        for (int i = n - 1; i >= 0; i--)
        {
            int initialValue = arr[i];

            if (i == 0)
            {
                arr[i] = lastValue;
            }
            else
            {
                int previous = arr[i - 1];

                if (previous < lastValue)
                {
                    arr[i] = lastValue;
                    lastValue = arr[i - 1];
                }
                else
                {
                    if (lastValue == 0)
                    {
                        lastValue = arr[i];
                    }

                    arr[i] = arr[i - 1];
                }
            }

            if (initialValue != arr[i])
            {
                PrintArray(arr);
            }
        }
    }

    public static void Execute()
    {
        Console.WriteLine("\nInserting Sort Part 1 Exercise");

        int n = 5;

        List<int> arr = new() { 2, 4, 6, 8, 3 };

        InsertionSortPart1.InsertionSort(n, arr);
    }
}