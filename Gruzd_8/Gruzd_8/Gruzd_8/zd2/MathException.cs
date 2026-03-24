namespace Gruzd_8.zd2;
    public class MathException : Exception
    {
        public MathException(string message, Exception inner)
            : base(message, inner)
        {
        }
    }
