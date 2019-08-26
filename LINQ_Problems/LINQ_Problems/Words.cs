using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LINQ_Problems
{
    class Words
    {

        public List<string> FilterTh(List<string> feederList)
        {
            var filteredWords = feederList.Where(a => a.Contains("th")).ToList();
            foreach(var word in filteredWords)
            {
                Console.WriteLine(word);
            }
            return filteredWords;
        }

        public List<string> RemoveDuplicateStringFromList(List<string> feederList)
        {
            var noDuplicateList = feederList.Distinct().ToList();
            foreach(var word in noDuplicateList)
            {
                Console.WriteLine(word);
            }
            return noDuplicateList;
        }


        public double ClassGradeAverage(List<string> feederList)
        {
            var listTwo = new List<double>();
            double runningAverage = 0;
            for(int i = 0; i < feederList.Count; i++)
            {
                var numbers = feederList[i].Split(",").Select(double.Parse).ToList();
                listTwo = numbers.OrderByDescending(g => g).Take(numbers.Count() - 1).ToList();
                var listTwoNumbers = listTwo.Average();
                runningAverage += listTwoNumbers;
            }
            double finalAverage = runningAverage / feederList.Count;
            return finalAverage;
        }

    }
}
