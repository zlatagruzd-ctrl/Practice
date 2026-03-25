namespace Gruzd_8
{
    public static class заметки
    {
        /// <summary>
        /// Интерфейс IFilter&lt;T&gt; — определяет метод фильтрации коллекции.
        /// Используется для отбора элементов по условию (предикату).
        /// </summary>
        public const string IFilter =
            "Интерфейс IFilter<T> определяет метод Filter, который принимает коллекцию " +
            "и предикат (условие), и возвращает только те элементы, которые удовлетворяют этому условию.";

        /// <summary>
        /// Класс SimpleFilter&lt;T&gt; — базовая реализация интерфейса IFilter&lt;T&gt;.
        /// Выполняет фильтрацию элементов, перебирая коллекцию и применяя предикат.
        /// </summary>
        public const string SimpleFilter =
            "SimpleFilter<T> — простая реализация фильтрации. " +
            "Проходит по коллекции и возвращает элементы, для которых предикат возвращает true.";

        /// <summary>
        /// Класс FilterRepository&lt;T&gt; — хранилище элементов.
        /// Позволяет добавлять элементы и получать всю коллекцию.
        /// </summary>
        public const string Repository =
            "FilterRepository<T> — репозиторий, который хранит элементы в списке. " +
            "Предоставляет методы Add и GetAll.";

        /// <summary>
        /// Класс FilterManager&lt;T&gt; — бизнес-логика.
        /// Выполняет фильтрацию через IFilter&lt;T&gt; и выводит результат.
        /// </summary>
        public const string Manager =
            "FilterManager<T> — сервисный класс, который использует IFilter<T> и FilterRepository<T>. " +
            "Позволяет выводить отфильтрованные элементы через метод PrintFiltered.";
    }
}