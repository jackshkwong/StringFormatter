﻿using System.Text;

namespace PointsBet_Backend_Online_Code_Test
{

    /*
    Improve a block of code as you see fit in C#.
    You may make any improvements you see fit, for example:
      - Cleaning up code
      - Removing redundancy
      - Refactoring / simplifying
      - Fixing typos
      - Any other light-weight optimisation
    */
    public class StringFormatter
    {

        //Code to improve
        public static string ToCommaSeparatedList(string[] items, string quote)
        {
            if (items.Length == 0) return "";
            
            StringBuilder qry = new StringBuilder();
            for (int i = 0; i < items.Length; i++)
            {
                qry.Append(string.Format("{0}{1}{0}, ", quote, items[i]));
            }
            qry.Remove(qry.Length - 2, 2);

            return qry.ToString();
        }
    }
}
