using System;
using System.Collections.Generic;

namespace Collections_Lib
{
    public class ListExercises
    {

            // 1 / 2 DONE

        // returns a list of all the integers between 1 to max inclusive
        // that are multiples of 5
        public static List<int> MakeFiveList(int max)
        {
            List<int> IntBetween = new List<int>();


            for (var i = 0; i <= max; i++) 
            {
                if (i % 5 == 0 && i != 0)
                {
                    IntBetween.Add(i);
                }
            }            

            return IntBetween;

        }

        // returns a list of all the strings in sourceList that start with the letter 'A' or 'a'
        public static List<string> MakeAList(List<string> sourceList)
        {

            List<string> AListers = new List<string>();


            foreach(var el in sourceList)
            {
                if (el.StartsWith('A') || el.StartsWith('a') )
                {
                    AListers.Add(el);
                }
            }

            return AListers;


        }
    }
}
