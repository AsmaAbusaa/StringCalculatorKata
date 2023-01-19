namespace String_Calculator
{
    public class StringCalculator
    {
        public int Add(string numbers)
        {
            int sum = 0;
            foreach (var num in numbers)
            {
                if (num >= 48 && num <= 57)
                    sum += num - 48;
            }
            return sum;
        }

    }
}
