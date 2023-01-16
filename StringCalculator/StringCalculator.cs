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
            char delimiter = ',';
            int sum = 0,num=0;

            if(numbers.StartsWith("//"))
            {
                num = 3;
                delimiter=numbers[2];
            }
            for (; num < numbers.Length; num++)
            {

                if (numbers[num] >= 48 && numbers[num] <= 57)
                    temp.Append(numbers[num]);

                if (numbers[num].Equals(delimiter) || num == numbers.Length - 1)
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
