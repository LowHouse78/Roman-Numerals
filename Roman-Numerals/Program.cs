using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Roman_Numerals
{
    class Program
    {
        static void Main(string[] args)
        {
            var literals = new List<string>()
            {
                "I",
                "II",
                "III",
                "IV",
                "VIII",
                "XLII",
                "MMXIII",
                "MXI",
                "MCDXCIX",
                "MMXXII",
                "V",
                "VI",
                "CX",
                "CCCLXXV",
                "MD",
                "MDLXXV",
                "MDCL",
                "MDCCXXV",
                "MDCCC",
                "MDCCCLXXV",
                "MCML",
                "MMXXV",
                "MMC",
                "MMCLXXV",
                "MMCCL",
                "MMCCCXXV",
                "MMCD",
                "MMCDLXXV",
                "MMDL",
                "MMMMMMMMIV",
                "MMMMMMMM"
            };

            foreach (var item in literals)
            {
                var translator = new RomanNumerals();
                Console.WriteLine(item.PadRight(12,' ')+"= "+translator.TranslateRomanNumeral(item));
            }

            Console.ReadKey();
        }
    }
}
