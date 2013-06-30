// the longest sequence using a starting number under one million
// The following iterative sequence is defined for the set of positive integers:

// n n/2 (n is even)
// n 3n + 1 (n is odd)

// Using the rule above and starting with 13, we generate the following sequence:

// 13 40 20 10 5 16 8 4 2 1
// It can be seen that this sequence (starting at 13 and finishing at 1) contains 10 terms. Although it has not been proved yet (Collatz Problem), it is thought that all starting numbers finish at 1.

// Which starting number, under one million, produces the longest chain?

// NOTE: Once the chain starts the terms are allowed to go above one million.


class Program
{
    static uint next (uint n)
    {
        if (n % 2 == 0)
            return n/2;
        else
            return 3*n+1;        
    }

    static uint sequence(uint n)
    {
        uint len = 1;

        do
        {
            ++len;
            n = next(n);
        } while (n > 1);
        
        return len;
    }

    static void Main(string[] args)
    {
        uint max = 0; uint num = 0; uint n = 2;
        for (; n < 1000*1000; ++n)
        {
            uint len = sequence(n);
            if (len > max)
            {
                max = len;
                num = n;
                Console.Write("{0}: {1}\n", num,len);
            }
        }
        Console.WriteLine("number {0} has sequence length {1}", num, max);       
    }
}