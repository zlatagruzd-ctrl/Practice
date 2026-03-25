using System;
using System.Collections.Generic;

namespace Gruzd_8
{ /// <inheritdoc cref="заметки.IFilter"/>
    public interface IFilter<T>
    {
        IEnumerable<T> Filter(IEnumerable<T> items, Func<T, bool> predicate);
    }
}