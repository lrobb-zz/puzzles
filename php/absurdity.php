<?php

/*

Array Absurdity

Description:

Imagine we have an immutable array of size N which we know to be filled with integers ranging from 0 to N-2, inclusive. Suppose we know that the array contains exactly one duplicated entry and that duplicate appears exactly twice. Find the duplicated entry. (For bonus points, ensure your solution has constant space and time proportional to N)

Input sample:

Your program should accept as its first argument a path to a filename. Each line in this file is one test case. Ignore all empty lines. Each line begins with a positive integer(N) i.e. the size of the array, then a semicolon followed by a comma separated list of positive numbers ranging from 0 to N-2, inclusive. i.e eg.

5;0,1,2,3,0
20;0,1,10,3,2,4,5,7,6,8,11,9,15,12,13,4,16,18,17,14
Output sample:

Print out the duplicated entry, each one on a new line eg

0
4
*/


$file = fopen ($argv[1], 'r') or die ("can't open file $argv[1]\n");

function find_first($arr)
{
	// An array in PHP is actually an ordered map
	$hash = array();
	$dup = '';
	
	foreach ($arr as $c)
	{
		if (isset($hash[$c]))
		{
			$dup = $c;
			break;
		}
		else
			$hash[$c] = 1;	
	}
	
	print ($c . PHP_EOL);
}

while (!feof ($file))
{
    $str = (trim (fgets ($file)));
	if (! empty($str))
	{
		$arr = explode (';', $str);
		$arr = explode (',', $arr[1]);
		if (! empty($arr))
			find_first ($arr);
	}
}

fclose ($file);
