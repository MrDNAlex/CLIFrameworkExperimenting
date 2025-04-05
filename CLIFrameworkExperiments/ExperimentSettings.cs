using NanoDNA.CLIFramework.Data;

namespace CLIFrameworkExperiments
{
    internal class ExperimentSettings : Setting
    {
        public override string ApplicationName => "ExperimentCLI";

        public override string GlobalFlagPrefix => DEFAULT_GLOBAL_FLAG_PREFIX;

        public override string GlobalShorthandFlagPrefix => DEFAULT_GLOBAL_SHORTHAND_FLAG_PREFIX;
    }
}
