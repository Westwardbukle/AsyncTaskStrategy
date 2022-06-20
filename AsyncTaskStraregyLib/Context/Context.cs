namespace AsyncTaskStraregyLib.Context;

public class Context
{
    private IStrategy _strategy;


    public Context(IStrategy strategy)
    {
        _strategy = strategy;
    }
    
    /*public */
}