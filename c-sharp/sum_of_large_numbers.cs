// sum of one-hundred 50-digit numbers
// One way to do this on a system w/o big integer support... treat it as a string, and start adding the columns, carrying the remainder... 

// But an easier way...

// >>> nums="""37107287533902102798797998220837590246510135740250 etc...
// >>> str(sum(int(x) for x in nums.split('\n')))[:10]


// And now for the hard way:

class Program
{

    static void Main(string[] args)
    {
        string [] array = { "37107287533902102798797998220837590246510135740250",
                            100 element array shortened for readability
                            "53503534226472524250874054075591789781264330331690"};

        string sum = "";
        int carry = 0;

        for (int col = 49; col >=0; --col)
        {
            for (int row = 0; row < 100; ++row)
            {
                string line = array[row];
                int digit = (int)char.GetNumericValue(line[col]);
                carry += digit;
            }

            string s = Convert.ToString(carry);

            if (col == 0 || carry <= 9)
            {
                sum = s + sum;
            }
            else
            {
                sum = s.ElementAt(s.Count() - 1) + sum;
            }

            s = s.Remove(s.Count() - 1);
            carry = Convert.ToInt32(s);
        }

        Console.WriteLine("first 10 digits: {0}", sum.Substring(0,10));
    }
}