<?php

/*

Prefix expressions

Description:

You are given a prefix expression. Write a program to evaluate it.
Input sample:

The first argument will be an input file with one prefix expression per line. e.g.

* + 2 3 4
Your program has to read this and insert it into any data structure you like. Traverse that data structure and evaluate the prefix expression. Each token is delimited by a whitespace. You may assume that the only valid operators appearing in test data are '+','*' and '/' 

Output sample:

Print to stdout, the output of the prefix expression, one per line. e.g.

20


*/


function is_operand($val)
{
	return (($val != '+') &&
			($val != '*') &&
			($val != '-') &&
			($val != '/'));
}

function calc(&$stack)
{
	$val2 = array_pop($stack);
	$val1 = array_pop($stack);
	$op = array_pop($stack);	
	
	$result = 0;
	switch ($op)
	{
		case '+':
			$result = $val1 + $val2;
			break;
		case '*':
			$result = $val1 * $val2;
			break;
		case '/':
			$result = $val1 / $val2;
			break;
		case '-':
			$result = $val1 - $val2;
			break;
	}

	array_push($stack, $result);
}

$file = fopen ($argv[1], 'r') or die ("can't open file $argv[1]\n");

while (!feof ($file))
{
    $line = (trim (fgets ($file)));
	if (! empty($line))
	{
		$ops = explode(' ', $line);		
		$stack = array();

		foreach ($ops as $op)
		{
			array_push($stack, $op);
			
			while (	count($stack) > 2 && 
					is_operand(end($stack)) && 
					is_operand(prev($stack)))
					{ 
						calc($stack);
					}
		}
		
		print array_pop($stack) . PHP_EOL;
	}
}

fclose ($file);

// Test cases: 

// + 1 2
// * + 2 3 4
// / 9 - 7 4
// * + 8 6 - + 1 2 3
// + / * 2 3 - 2 1 * 5 - 4 1