using NanoDNA.CLIFramework.Flags;

namespace CLIFrameworkExperiments
{
    public class Verbose : Flag
    {
        public Verbose(string[] arguments) : base(arguments)
        {
            Console.WriteLine("Verbose Flag Activated");
        }

        public override string Name => "verbose";

        public override string ShorthandName => "v";

        public override string Description => "Adds a more Verbose Debugging to the CLI App";
    }
}
