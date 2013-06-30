<?php

/*

Prime Numbers

Description:

Print out the prime numbers less than a given number N. For bonus points your solution should run in N*(log(N)) time or better. You may assume that N is always a positive integer.

Input sample:

Your program should accept as its first argument a path to a filename. Each line in this file is one test case. Each test case will contain an integer n < 4,294,967,295. eg.

10
20
100
Output sample:

For each line of input, print out the prime numbers less that N, in ascending order, comma delimited. (There should not be any spaces between the comma and numbers) eg.

2,3,5,7
2,3,5,7,11,13,17,19
2,3,5,7,11,13,17,19,23,29,31,37,41,43,47,53,59,61,67,71,73,79,83,89,97

*/


function is_prime ($primes, $n)
{
    if (in_array ($n, $primes))
        return true;

    // can't use a sieve because I'm on an ancient laptop.			
    for ($i = 2; $i < (int) ( 1 + (pow ($n, 0.5))); ++$i)
    {
        if (($n % $i) === 0)
            return false;
    }

    $primes[] = $n;
    return true;
}

function print_primes ($primes, $n)
{
    // automatically print up to $n primes...	
    $format = false;
    foreach ($primes as $p)
    {
        if ($p > $n)
            break;

        if ($format)
            print ',';

        print $p;
        $format = true;
    }

    if ($n <= end ($primes))
    {
        print "\n";
        return;
    }
    else
    {
        // there is more than what we printed...	
        $i = end ($primes) + 2;
        while ($i <= $n)
        {
            if (is_prime ($primes, $i))
            {
                if ($format)
                    print(',');

                $format = true;
                print $i;
            }
            $i += 1;
        }

        print "\n";
    }
}

// init the lookup table
$primes = array (2, 3, 5, 7, 11, 13, 17, 19);

$file = fopen ($argv[1], 'r') or die ("can't open file $argv[1]\n");
while (!feof ($file))
{
    $n = (int) (trim (fgets ($file)));
    if ($n > 1)
        print_primes ($primes, $n);
}
fclose ($file);
