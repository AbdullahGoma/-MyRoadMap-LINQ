using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewSecond
{
    internal static class Extensions
    {
        //Deffered Execution
        public static IEnumerable<TSource> Filter<TSource>(this IEnumerable<TSource> source, Predicate<TSource> predicate)
        {
            foreach (var item in source)
            {
                if (predicate(item))
                    yield return item;
            }
        }

        //Deffered Execution
        public static IEnumerable<TResult> Choose<TSource, TResult>(this IEnumerable<TSource> source, Func<TSource, TResult> chooser)
        {
            //Tsource: Courses, TResult: Names
            foreach (var item in source)
            {
                yield return chooser(item);
            }
        }

        public static int MyCount<TSource>(this IEnumerable<TSource> source)
        {
            int counter = 0;
            foreach (var item in source)
            {
                counter++;
            }
            return counter;
        }

        //public static int MaxOrDefault<T>(this IEnumerable<T> enumeration, Func<T, int> selector)
        //{
        //    return enumeration.Any() ? enumeration.Max(selector) : default(int);
        //}

        //public static TResult MaxOrDefault<T, TResult>(this IEnumerable<T> enumerable, Func<T, TResult> func) 
        //{
        //    return enumerable.Select(func).DefaultIfEmpty().Max();
        //}

        ////Eager Execution: If Data is Big
        //public static IEnumerable<T> Filter<T>(this IEnumerable<T> source, Predicate<T> predicate)
        //{
        //    List<T> result = new List<T>();
        //    foreach (var item in source)
        //    {
        //        result.Add(item);
        //    }
        //    foreach (var item in result)
        //    {
        //        if (predicate(item))
        //            yield return item;
        //    }
        //}

        ////Eager Execution: If Data is Big
        //public static IEnumerable<TResult> Choose<TSource, TResult>(this IEnumerable<TSource> source, Func<TSource, TResult> chooser)
        //{
        //    List<TSource> result = new List<TSource>();
        //    foreach(var item in source)
        //    {
        //        result.Add(item);
        //    }
        //    //Tsource: Courses, TResult: Names
        //    foreach (var item in result)
        //    {
        //        yield return chooser(item);
        //    }
        //}




    }
}
