// Problem: Create a Win32 console application and implement the following function.
 
// PrintPattern( int patternSize )
// {
      // . . .
// }
 

    // The function should print an alternating square pattern using the letters 'X' and 'O'
    // The height of the pattern will be passed into the program as a parameter… The pattern should be sized appropriately for any valid value of the parameter.
    // You can be guaranteed that the parameter will be a positive ODD number.
    // An ideal solution would not allocate a buffer to store the data before printing.


// Example Output:
 
 
// patternSize = 1
// X
 
// patternSize = 3
// OOO
// OXO
// OOO
 
// patternSize = 5
// XXXXX
// XOOOX
// XOXOX
// XOOOX
// XXXXX
 
// patternSize = 7
// OOOOOOO
// OXXXXXO
// OXOOOXO
// OXOXOXO
// OXOOOXO
// OXXXXXO
// OOOOOOO

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


namespace puzzle
{
    class Program
    {
        static void PrintPattern(int patternSize)
        {
            int middle = patternSize / 2;
            char c = (middle % 2 == 0 ? 'X' : 'O');
            int pad = 0;

            for (int y = 0; y < patternSize; ++y)
            {
                int x = 0;
                char t = (middle % 2 == 0 ? 'X' : 'O');

                for (int j = 0; j < pad; ++j)
                {
                    Console.Write(t);
                    t = (t == 'X' ? 'O' : 'X');
                }

                for (; x < patternSize - 2 * pad; ++x)
                {
                    Console.Write(c);
                }

                for (int j = 0; j < pad; ++j)
                {
                    t = (t == 'X' ? 'O' : 'X');
                    Console.Write(t);
                }

                Console.WriteLine();
                c = (c == 'X' ? 'O' : 'X');

                if (y < middle) pad++;
                else pad--;
            }

            Console.WriteLine();
        }

        static void Main(string[] args)
        {
            PrintPattern(1);
            PrintPattern(3);
            PrintPattern(5);
            PrintPattern(7);
            PrintPattern(9);
        }

        //static void surround(ref char[,] pattern, int middle, int offset, char letter, int patternSize)
        //{
        //    for (int j = middle - offset; j < patternSize; ++j)
        //    {
        //        pattern[j, middle - offset] = letter;
        //        pattern[j, middle + offset] = letter;
        //        pattern[middle + offset, j] = letter;
        //        pattern[middle - offset, j] = letter;
        //    }
        //}

        //static void SimpleButNotIdeal(int patternSize)
        //{
        //    // it's not ideal, but it's simple
        //    char[,] pattern = new char[patternSize, patternSize];

        //    int middle = (int)(patternSize / 2);
        //    pattern[middle, middle] = 'X';

        //    // build it
        //    char c = 'O';
        //    for (int offset = 1; offset <= middle; ++offset)
        //    {
        //        surround(ref pattern, middle, offset, c, patternSize);

        //        if (c == 'O') c = 'X';
        //        else c = 'O';
        //    }

        //    // print it
        //    for (int x = 0; x < patternSize; ++x)
        //    {
        //        for (int y = 0; y < patternSize; ++y)
        //        {
        //            Console.Write(pattern[x, y]);
        //        }
        //        Console.WriteLine();
        //    }
        //}

    }
}
