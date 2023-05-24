using Gravity.Abstraction.Logging;

using Rhino.Api.Contracts.Attributes;
using Rhino.Api.Contracts.AutomationProvider;
using Rhino.Api.Contracts.Configuration;
using Rhino.Api.Reporter;

using System;

namespace Reporters.Allure
{
    [Reporter("AllureReporter", Description = "Rhino plugin for creating Allure Report output that can be served and used as a standard Allure Report.")]
    public class AllureReporter : RhinoReporter
    {
        public AllureReporter(RhinoConfiguration configuration)
            : base(configuration)
        { }

        public AllureReporter(RhinoConfiguration configuration, ILogger logger)
            : base(configuration, logger)
        { }

        // TODO: generate all Allure `json` files based on the `testRun` data.
        protected override void OnCreate(RhinoTestRun testRun)
        {
            throw new NotImplementedException();
        }
    }
}
