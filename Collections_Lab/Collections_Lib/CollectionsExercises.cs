using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;
using System.Linq;

namespace Collections_Lib
{
	public class CollectionsExercises
    {

        // 3 / 3 DONE (missing one test)

        /* removes and returns the next num entries in the queue, as a comma separated string */
        public static string NextInQueue(int num, Queue<string> queue)
        {

			string result = "";

			if (queue.Count == 0)
			{
				return "";
			}
			else if (queue.Count < num) 
			{
				for (var i = 0; i < queue.Count; i++)
				{
					var nextInQueue = queue.ElementAt(i);
					result += $"{nextInQueue}";

					if (i < queue.Count - 1)
					{
						result += $", ";
					}
				}
                queue.Clear();
                return result;
			}

			for (var i = 0; i < num; i++) 
			{
				var dequeue = queue.Dequeue();
				result += $"{dequeue}";

				if (i < num - 1) 
				{
					result += $", ";
				}
			}
			
			return result;
        }





		/* uses a Stack to create and return array of ints in reverse order to the one supplied */
		public static int[] Reverse(int[] original)
		{

			int[] reversed = new int[original.Length];

			var stack = new Stack<int>();

            foreach (var n in original)
            {
                stack.Push(n);
            }

			for (int i = 0; i < original.Length; i++)
			{
				reversed[i] = stack.Pop();
			}

			return reversed;
        }





		// using a Dictionary, counts and returns (as a string) the occurence of the digits 0-9 in the given string
		public static string CountDigits(string input)
		{
			string result = "";
			var countDict = new Dictionary<char, int>();

			Regex regex = new Regex("[0-9]");
            //Regex lttRegex = new Regex("[^a-zA-Z]");
			Regex lttRegex = new Regex("/ ^[a - zA - Z] *$/");

            //List<int> regexSorta = new List<int> { '0', '1', '2', '3', '4', '5', '6', '7', '8', '9' };
            //regex.IsMatch(input)
            //input.All(Char.IsDigit))

            if (countDict.Count > 0)
			{
				for (var key = 0; key < countDict.Count; key++)
				{

					result += $"[{countDict.ElementAt(key).Key}, {countDict.ElementAt(key).Value}]";
				}
			}

			// try parse on the input to see if its type
			foreach (var c in input)
			{
				if (countDict.ContainsKey(c) && input.Any(Char.IsDigit))
				{
					countDict[c]++;
				}
				else if (!countDict.ContainsKey(c) && input.Any(Char.IsDigit))
				{
					countDict.Add(c, 1);
				}
            }

            for (var c = 0; c < countDict.Count; c++)
            {
                if (countDict.ElementAt(c).Key.Equals(lttRegex))
                {
                    countDict.Remove(countDict.ElementAt(c).Key);
                }
            }

            for (var key = 0; key < countDict.Count; key++)
			{

				result += $"[{countDict.ElementAt(key).Key}, {countDict.ElementAt(key).Value}]";
			}
            return result;
		}
	}
}
