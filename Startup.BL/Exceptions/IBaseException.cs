namespace Startup.BL.Exceptions;

public interface IBaseException
{
    public int Code { get; }
    public string Message { get; }
}
