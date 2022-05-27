using Serilog;
using TestConsoleApp.Core;

namespace TestConsoleApp
{
    public static class Program
    {
        public static void Main()
        {
            Log.Logger = new LoggerConfiguration()
                .MinimumLevel.Information()
                .WriteTo.Console()
                .CreateLogger();

            Log.Information("Hello, world!");

            var greeter = new Greeter();
            greeter.Greet("John");
        }
    }
}