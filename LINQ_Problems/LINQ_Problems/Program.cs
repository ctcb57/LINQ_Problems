﻿using System;
using System.Collections.Generic;
using System.Linq;

namespace LINQ_Problems
{
    class Program
    {
        static void Main(string[] args)
        {
            Words test = new Words();
            List<string> testList = new List<string>() { "the", "bike", "this", "it", "tenth", "mathematics" };
            test.FilterTh(testList);
            List<string> testList2 = new List<string>() { "Mike", "Brad", "Nevin", "Ian", "Mike" };
            test.RemoveDuplicateStringFromList(testList2);
            List<string> testList3 = new List<string>() { "80,100,92,89,65",
            "93,81,78,84,69",
            "73,88,83,99,64",
            "98,100,66,74,55"};
            test.ClassGradeAverage(testList3);
            test.AlphabeticallyOrderString("Terrill");

        }
    }
}
