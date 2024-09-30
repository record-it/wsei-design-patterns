namespace SolidPrinciples.DependencyInversionPrinciple;

public class Monitor
{
    private Logger _logger;

    public Monitor()
    {
        _logger = new Logger();
    }

    public void ProcessRequest()
    {
        _logger.Log("Processing request");
    }
}

public class Logger
{
    public void Log(string message)
    {
        Console.WriteLine($"Log {DateTime.Now}: {message}");
    }
}