using System;
using System.Text;

namespace String_Calculator
{
    public class StringCalculator
    {
        public int Add(string numbers)
        {
            StringBuilder temp = new StringBuilder();
            numbers = numbers.Replace("\n", ",");
            int sum = 0;
            for (int num = 0; num < numbers.Length; num++)
            {

                if (numbers[num] >= 48 && numbers[num] <= 57)
                    temp.Append(numbers[num]);

                if (numbers[num].Equals(',') || num == numbers.Length - 1)
                {
                    try
                    {
                        int val;
                        val = Int32.Parse(temp.ToString());
                        sum += val;
                        temp.Clear();
                    }

                    catch (FormatException)
                    {
                        Console.WriteLine("Can't Parsed '{0}'", temp);
                    }
                }
            }
            return sum;
        }
    }
}
