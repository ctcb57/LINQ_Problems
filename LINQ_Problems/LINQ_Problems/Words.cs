using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LINQ_Problems
{
    class Words
    {
        public void FilterTh()
        {
            List<string> words = new List<string>() { "the", "bike", "this", "it", "tenth", "mathematics" };
            var wordsWithTh = words.Where(a => a.Contains("th"));
            foreach(var word in wordsWithTh)
            {
                Console.WriteLine(word);
            }
        }

        public void RemoveDuplicates()
        {
            List<string> names = new List<string>() { "Mike", "Brad", "Nevin", "Ian", "Mike" };
            var noDuplicateNames = names.Distinct();
            foreach(var name in noDuplicateNames)
            {
                Console.WriteLine(name);
            }
            Console.ReadLine();
        }
    }
}
