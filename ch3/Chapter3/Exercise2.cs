using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LaYumba.Functional;
using static LaYumba.Functional.F;

// 2 Write a Lookup function that will take an IEnumerable and a predicate, and
// return the first element in the IEnumerable that matches the predicate, or None
// if no matching element is found. Write its signature in arrow notation:

// bool isOdd(int i) => i % 2 == 1;
// new List<int>().Lookup(isOdd) // => None
// new List<int> { 1 }.Lookup(isOdd) // => Some(1)
namespace Chapter3
{
    public static class Exercise2
    {
        //(IEnumberable<T>, Func<T>, bool>) -> Option<T>
        public static Option<T> Lookup<T>(this IEnumerable<T> col, Func<T, bool> predicate)
        {
            foreach (var item in col)
            {
                if (predicate(item))
                {
                    return Some(item);
                }
            }

            return None;
        }
    }
}
