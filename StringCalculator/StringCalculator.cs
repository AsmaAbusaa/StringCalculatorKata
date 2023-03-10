using System;
using System.Text;

namespace String_Calculator
{
    public class StringCalculator
    {
        private const int maxValue = 1000;

        public int Add(string numbers)
        {
            StringBuilder temp = new StringBuilder();
            StringBuilder negativeValues = new StringBuilder();
            numbers = numbers.Replace("\n", ",");
            char delimiter = ',';
            int sum = 0, index = 0;

            if (numbers.StartsWith("//")) {
                index = 3;
                delimiter = numbers[2];
            }
            for (; index < numbers.Length; index++) {

                if (numbers[index] >= 48 && numbers[index] <= 57 || numbers[index] == '-')
                    temp.Append(numbers[index]);

                if (numbers[index].Equals(delimiter) || index == numbers.Length - 1) {

                    int value;
                    value = Int32.Parse(temp.ToString());
                    if (value > 0 && value <= maxValue)
                        sum += value;
                    else if (value < 0) negativeValues.Append(value + " ");
                    temp.Clear();

                }
            }
            if (negativeValues.Length != 0)
                throw new Exception($"negatives not allowed:{negativeValues}");
            return sum;
        }
    }
}
