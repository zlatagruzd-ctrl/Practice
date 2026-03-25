using System;
using System.Collections.Generic;

namespace Gruzd_8
{
    /// <inheritdoc cref="заметки.SimpleFilter"/>
    public class SimpleFilter<T> : IFilter<T>
    {
        public IEnumerable<T> Filter(IEnumerable<T> items, Func<T, bool> predicate)
        {
            foreach (var item in items)
            {
                if (predicate(item))
                    yield return item;
            }
        }
    }
}