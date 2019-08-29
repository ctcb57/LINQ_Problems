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

        public void AlphabeticallyOrderString(string feederString)
        {
            StringBuilder holder = new StringBuilder();
            var newWord = feederString.ToUpper();
            var frequencyString = from f in newWord
                                  group f by f into letterfrequency
                                  orderby letterfrequency.Key
                                  select new
                                  {
                                      Letter = letterfrequency.Key,
                                      Frequency = letterfrequency.Count()
                                  };
            foreach(var x in frequencyString)
            {
                holder.Append($"{x.Letter}{x.Frequency}");
            }
            Console.WriteLine(holder);
            Console.ReadLine();
        }

    }
}
