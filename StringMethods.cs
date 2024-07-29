using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TMS_5_Strings
{
    internal class StringMethods
    {
        public static void replaceNumbersToWords(string input)
        {
            string input1 = input
                .Replace("1", "ONE")
                .Replace("2", "TWO")
                .Replace("3", "THREE")
                .Replace("4", "FOUR")
                .Replace("5", "FIVE")
                .Replace("6", "SIX")
                .Replace("7", "SEVEN")
                .Replace("8", "EIGHT")
                .Replace("9", "NINE")
                .Replace("0", "ZERO");
            Console.WriteLine(input1);
        }

        public static void findLongestWord(string input)
        {
            string[] exclusionСharacters = input.Split(' ', ',', '.', ':', '!', '?', ';');
            int maxlen = 0, index = 0;
            for (int i = 0; i < exclusionСharacters.Length; i++)
            {
                if (exclusionСharacters[i].Length > maxlen)
                {
                    maxlen = exclusionСharacters[i].Length;
                    index = i;
                    //bool isCont = input.Contains(str[index]);
                }
            }
            Console.Write("Самое длинное слово: {0}", exclusionСharacters[index]);
            string searchWord = exclusionСharacters[index];
            char[] separators = [' ', ',', '.', ':', '!', '?', ';'];
            string[] source = input.Split(separators, StringSplitOptions.RemoveEmptyEntries);
            var matchQuery = from word in source
                             where word.Equals(searchWord, StringComparison.InvariantCultureIgnoreCase)
                             select word;
            int wordCount = matchQuery.Count();
            Console.WriteLine($"\nСлово {searchWord} встречается {wordCount} раз");
        }

        public static void FindWordWhichConsistMaxNumbers(string input)
        {
            var separators = input.Split(new char[] { ' ', ',', '.', ':', '!', '?', ';' }, StringSplitOptions.RemoveEmptyEntries);
            var list = separators.Select(x => new { value = x, count = x.Where(c => input.Contains(c)).Count() }).OrderBy(x => x.count);
            foreach (var item in list)
            {
                Console.WriteLine($"{item.value} ({item.count})");
            }

            var aCnt = separators.Where(x => x.Count(c => c == ) >= 2);

            Console.WriteLine("\n----------- a > 2 -----------");
            foreach (var a in aCnt) Console.WriteLine(a);

            Console.Read();



        }



    }


}
