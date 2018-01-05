using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static func_action_linq.Program;

namespace func_action_linq
{
    public static class myFunc
    {
        public static IEnumerable<T> myWhere<T>(this IEnumerable<T> sequence ,Func<T, bool> predicate)
        {
            IEnumerator<T> enumerator = sequence.GetEnumerator();
            while (enumerator.MoveNext())
            {
                if (predicate(enumerator.Current))
                {
                    yield return enumerator.Current;
                }
            }
        }

        public static int myCount<T>(this IEnumerable<T> sequence)
        {
            int count = 0;

            foreach (var item in sequence)
            {
                count++;
            }
            return count;
        }

        public static IEnumerable<TSource> mynewWhere<TSource>(this IEnumerable<TSource> source, Func<TSource, bool> predicate)
        {
            IEnumerator<TSource> enumerator = source.GetEnumerator();
            while (enumerator.MoveNext())
            {
                if (predicate(enumerator.Current))
                {
                   yield return enumerator.Current;
                }
            }
        }
    }
}
