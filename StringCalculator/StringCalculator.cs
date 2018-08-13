using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace StringCalculator
{
    public class StringCalculator
    {
        public int Add(string input)
        {
            if (string.IsNullOrWhiteSpace(input))
            {
                return 0;
            }
            if (input.StartsWith("//"))
            {
                var index = input.IndexOf("\n");
                input = input.Substring(index);
            }
            var numbers = Split(input);
            CheckForNegatives(numbers);
            

            return CalculateSum(numbers);
        }

        private void CheckForNegatives(IEnumerable<int> numbers)
        {
            if (numbers.Any(x => x<0))
            {
                var negatives = numbers.Where(y => y < 0);
                throw new Exception($"negatives not allowed : {string.Join(",",negatives)}");
            }
        }

        private static IEnumerable<int> Split(string input)
        {
            return input.Split(new char[] { ',', '\n', '@', '#', '$', '%', '*', '/', ';', '!', ':' }, StringSplitOptions.RemoveEmptyEntries).Select(part => Convert.ToInt32(part));
        }


        private static int CalculateSum(IEnumerable<int> numbers)
        {
            return numbers.Where(x => x <= 1000).Sum();
        }
    }
}
