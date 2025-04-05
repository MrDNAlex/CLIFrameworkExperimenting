using NanoDNA.CLIFramework.Commands;

namespace CLIFrameworkExperiments
{
    internal class HelloWorld : Command
    {
        public override string Name => "hello-world";

        public override string Description => "Says Hello World in the Console";

        public override void Execute(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
    }
}
