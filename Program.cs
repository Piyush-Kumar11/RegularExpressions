using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RegularExpression
{
    internal class Program
    {
        static RegexExamples reg = new RegexExamples();
        static void Main(string[] args)
        {

            //reg.ExtractDate();
            //reg.ExtractMultipleMatches();
            //reg.CheckValidMobile();
            reg.ValidateEmail();
        }
    }
}
