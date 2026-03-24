namespace Gruzd_8.zd3;

public class OrderLimitExceededException : Exception
{
    public OrderLimitExceededException(string message)
        : base(message)
    {
    }
}