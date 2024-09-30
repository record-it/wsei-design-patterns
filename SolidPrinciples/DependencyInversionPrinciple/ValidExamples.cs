namespace SolidPrinciples.DependencyInversionPrinciple;

public class DIPMonitor
{
    private ILogger _logger;

    public DIPMonitor(ILogger logger)
    {
        _logger = logger;
    }

    public void ProcessRequest()
    {
        _logger.Log("Processing request");
    }
}

public class ConsoleLogger : ILogger
{
    public void Log(string message)
    {
        Console.WriteLine($"Log {DateTime.Now}: {message}");
    }
}

public interface ILogger
{
    public void Log(string message);
}

public class DependencyInversionDemo()
{
    public static void Run()
    {
        Monitor monitor1 = new Monitor();
        DIPMonitor monitor2 = new DIPMonitor(new ConsoleLogger());
        monitor1.ProcessRequest();
        monitor2.ProcessRequest();
    }
}