namespace ChainOfResponsibilityPattern
{
    public interface IHandler
    {
        object Handle(object request);

        IHandler SetNext(IHandler handler);        
    }
}
