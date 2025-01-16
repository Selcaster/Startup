namespace Startup.BL.Exceptions.Common;

public class NotFoundException<T> : Exception, IBaseException
{
    public int Code => throw new NotImplementedException();
    public string ErrorMessage { get; }

    public NotFoundException() : base(typeof(T).Name + " is not found!")
    {
        ErrorMessage = typeof(T).Name + " is not found!";
    }

    public NotFoundException(string message) : base(message)
    {
        ErrorMessage = message;
    }
}