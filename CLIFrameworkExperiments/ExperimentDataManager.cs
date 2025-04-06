using NanoDNA.CLIFramework.Data;
using NanoDNA.CLIFramework.Flags;

namespace CLIFrameworkExperiments
{
    internal class ExperimentDataManager : DataManager
    {
        public ExperimentDataManager(Setting settings, Dictionary<Type, Flag> globalFlags) : base(settings, globalFlags)
        {

        }
    }
}
