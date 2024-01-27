using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace NewFirst
{
    public static class Extensions
    {
        // Eager Execution
        //public static IEnumerable<T> /*void*/ Filter<T>(this IEnumerable<T> list /*List<int> list*/, Predicate<T> predicate)
        //{
        //    List<T> l = new List<T>();
        //    foreach (var item in list)
        //    {
        //        if (predicate(item)) l.Add(item) /*Console.WriteLine(item)*/;
        //    }
        //    return l;
        //}


        //Deferred execution
        public static IEnumerable<T> Filter<T>(this IEnumerable<T> list, Predicate<T> predicate)
        {
            //List<T> l = new List<T>();
            foreach (var item in list)
            {
                if (predicate(item))
                    //l.Add(item);
                    yield return item;
            }
        }

        public static IEnumerable<int> MyFilter(this IEnumerable<int> list)
        {
            int x = 1;
            foreach (var item in list)
            {
                yield return x++;
            }
        }


        public static string RemoveVowels(this string str)
        {
            List<char> vowels = new List<char>
            {
                'A', 'E', 'I', 'O', 'U'
            };
            StringBuilder sb = new StringBuilder(); 
            foreach(char item in str)
            {
                if(!vowels.Contains(Char.ToUpper(item))) sb.Append(item);
            }
            return sb.ToString();
        }

        public static char GetMiddleCharacter(this string str)
        {
            return str[str.Length / 2];
        }

        public static void PrintMe(this char ch)
        {
            Console.WriteLine(ch);
        }


    }
}
