namespace Gruzd_8
{
    public class OverheatException : Exception
    {
        public OverheatException() 
            : base("Температура превышает допустимый предел!") { }

        public OverheatException(string message) 
            : base(message) { }

        public OverheatException(string message, Exception inner) 
            : base(message, inner) { }
    }
}