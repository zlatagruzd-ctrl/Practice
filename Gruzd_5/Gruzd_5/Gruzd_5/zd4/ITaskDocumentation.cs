using System.Collections.Generic;

namespace Gruzd_5;

public interface ITaskDocumentation
{
    /// <summary>
    /// Расширяющий метод для List&lt;int&gt;.
    /// Находит медиану: сортирует список и выбирает центральное значение 
    /// (или среднее двух центральных для четного кол-ва).
    /// </summary>
    double GetMedian(List<int> numbers);
}