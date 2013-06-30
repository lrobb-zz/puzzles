<?php
/*
First Non-Repeated Character

Description:

Write a program to find the first non repeated character in a string.

Input sample:

The first argument will be a text file containing strings. e.g. 

yellow
tooth
Output sample:

Print to stdout, the first non repeating character, one per line.
e.g.

y
h
*/

$file = fopen ($argv[1], 'r') or die ("can't open file $argv[1]\n");

function find_first($str)
{
	// An array in PHP is actually an ordered map
	$hash = array();
	
	foreach (str_split($str) as $c)
	{
		if (isset($hash[$c]))
			$hash[$c] = 0;
		else
			$hash[$c] = 1;	
	}

	foreach ($hash as $k => $v)
	{
		if ($v === 1)
		{
			printf ($k . PHP_EOL);
			break;			
		}
	}
}

while (!feof ($file))
{
    $str = (trim (fgets ($file)));
	if (! empty($str))
		find_first ($str);
}

fclose ($file);

