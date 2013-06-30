<?php
/*
Fibonacci Series

Description:

The Fibonacci series is defined as: F(0) = 0; F(1) = 1; F(n) = F(n-1) + F(n-2) when n>1;. Given a positive integer 'n', print out the F(n).

Input sample:

The first argument will be a text file containing a positive integer, one per line. e.g. 

5
12
Output sample:

Print to stdout, the fibonacci number, F(n).
e.g.

5
144

*/
$file = fopen ($argv[1], 'r') or die ("can't open file $argv[1]\n");

function fibo($n)
{
	if ($n === 0)
		return 0;
		
	if ($n === 1)
		return 1;
	
	return fibo ($n - 1) + fibo ($n - 2);
}

while (!feof ($file))
{
	$str = trim (fgets ($file));
	if ($str !== "")
	{	
		$n = (int)($str);
		print fibo($n) . PHP_EOL;
	}
}

fclose ($file);

