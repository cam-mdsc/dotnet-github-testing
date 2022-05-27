using Serilog;

namespace TestConsoleApp.Core
{
    public sealed class Greeter
    {
        public void Greet(string name) => Log.Information($"Hello, {name}!");
    }
}
