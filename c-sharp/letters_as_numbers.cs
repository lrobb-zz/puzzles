/*
how many letters to write out the numbers
I see from the forums that most people brute-forced this one, building the actual string then doing the count. Much better this way. 

If the numbers 1 to 5 are written out in words: one, two, three, four, five, then there are 3 + 3 + 5 + 4 + 4 = 19 letters used in total.

If all the numbers from 1 to 1000 (one thousand) inclusive were written out in words, how many letters would be used?
*/
class Program
{
	static void Main(string[] args)
	{
		string ones="onetwothreefourfivesixseveneightnine";
		string teens="teneleventwelvethirteenfourteenfifteensixteenseventeeneighteennineteen";
		string tens = "twentythirtyfortyfiftysixtyseventyeightyninety";

		/*
		 * 1-100 = 10*tensl + teensl + 9*onesl
		 * 1-200 = 99*(len("one")+len("hundredand")) + (len("one")+len("hundred")) + 
		 *      (2 * 10 * len(tens)) + (2 * len(teens)) + (2 * 9 * len(ones))
		 * 1-300 = (99*(len("onetwo")+ 2*len("hundredand"))) + (len("onetwo")+
		 *      2*len("hundred")) + 3*((10 * tensl) + (teensl) + (9 * onesl))
		 * 1-999 = (99*(len(ones)+ 9*len("hundredand"))) + (len(ones)+9*len("hundred")) 
		 *      + 10*((10 * tensl) + (teensl) + (9 * onesl)) 
		 * 1000 = len("onethousand")
		*/

		int sum = (99 * (ones.Length + 9 * "hundredand".Length)) 
			+ (ones.Length + 9 * "hundred".Length) +
			10 * ((10 * tens.Length) + (teens.Length) + (9 * ones.Length));
		sum += "onethousand".Length;

		Console.WriteLine("sum: {0}", sum);
	}
}