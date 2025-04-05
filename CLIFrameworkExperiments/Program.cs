namespace CLIFrameworkExperiments
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ExperimentCLI cliApp = new ExperimentCLI();

            cliApp.Run(args);
        }
    }
}
