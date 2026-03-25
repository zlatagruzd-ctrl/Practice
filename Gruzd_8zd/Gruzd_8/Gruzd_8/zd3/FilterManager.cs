using System;
using System.Collections.Generic;

namespace Gruzd_8
{
    /// <inheritdoc cref="заметки.Manager"/>
    public class FilterManager<T>
    {
        private readonly IFilter<T> filter;
        private readonly FilterRepository<T> repository;

        public FilterManager(IFilter<T> filter, FilterRepository<T> repository)
        {
            this.filter = filter;
            this.repository = repository;
        }

        public void PrintFiltered(Func<T, bool> predicate)
        {
            var filtered = filter.Filter(repository.GetAll(), predicate);

            foreach (var item in filtered)
                Console.WriteLine(item);
        }
    }
}