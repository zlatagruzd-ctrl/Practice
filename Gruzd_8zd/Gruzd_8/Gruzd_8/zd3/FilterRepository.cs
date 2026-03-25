using System.Collections.Generic;

namespace Gruzd_8
{
    
    /// <inheritdoc cref="заметки.Repository"/>
    public class FilterRepository<T>
    {
        private List<T> items = new List<T>();

        public void Add(T item)
        {
            items.Add(item);
        }

        public IEnumerable<T> GetAll()
        {
            return items;
        }
    }
}