using NanoDNA.CLIFramework.Commands;

namespace CLIFrameworkExperiments
{
    internal class HelloWorld : Command
    {
        public HelloWorld(ExperimentDataManager dataManager) : base(dataManager) { }

        public override string Name => "hello-world";

        public override string Description => "Says Hello World in the Console";

        public override void Execute(string[] args)
        {
            Console.WriteLine("Hello World!");

            foreach (Type type in DataManager.GlobalFlags.Keys)
            {
                Console.WriteLine($"Global Flag: {type.Name}");
            }

            if (HasFlag<Verbose>())
            {
                Console.WriteLine("VERBOSE!");
            }
        }
    }
}
