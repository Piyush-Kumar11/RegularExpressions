using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace RegularExpression
{
    internal class RegexExamples
    {
        public void ExtractDate()
        {
            string pattern = @"([a-zA-Z]+) (\d)";
            string input = "Tomorrow the date is June 8";

            Match match = Regex.Match(input, pattern);
            if (match.Success)
            {
                Console.WriteLine("Match found: " + match.Value);
            }
            else
            {
                Console.WriteLine("No match found");
            }
        }
        public void ExtractMultipleMatches()
        {
            string pattern = @"([a-zA-Z]+) (\d+)";
            string input = "Tomorrow the date is June 8 and today is June 7 so after eight days it will be June 15";
            MatchCollection collection = Regex.Matches(input, pattern);
            if (collection.Count>0)
            {
                foreach (Match match in collection)
                {
                    Console.WriteLine(match.Value);
                }
            }
            else
            {
                Console.WriteLine("No match found");
            }
        }

        public void CheckValidMobile()
        {
            string input = "+91 9852276519";
            string pattern = @"^\+(\d{2})\s(\d{10})";
            Regex r = new Regex(pattern);
            if (r.IsMatch(input))
            {
                Console.WriteLine("Valid Phone number!");
            }
            else
            {
                Console.WriteLine("Invalid Phone Number!");
            }
        }
        public void ValidateEmail()
        {
            string input = "piyush@gmail.com";
            string pattern = @"^[a-zA-Z0-9._%+-]+@[a-zA-Z0-9.-]+\.[a-zA-Z]{2,}$";
            Regex r = new Regex(pattern);
            if (r.IsMatch(input))
            {
                Console.WriteLine("Valid email id");
            }
            else
            {
                Console.WriteLine("Invalid Email");
            }
        }

    }
}
