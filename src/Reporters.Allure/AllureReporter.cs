using Gravity.Abstraction.Logging;

using Rhino.Api.Contracts.Attributes;
using Rhino.Api.Contracts.AutomationProvider;
using Rhino.Api.Contracts.Configuration;
using Rhino.Api.Reporter;

using System;

namespace Rhino.Reporters.Allure
{
    /// <summary>
    /// A Rhino plugin that facilitates the generation of Allure Report output, conforming to the Allure standard for test reporting.
    /// </summary>
    [Reporter(
        name: "AllureReporter",
        Description = "A Rhino plugin that facilitates the generation of Allure Report output, conforming to the Allure standard for test reporting.")]
    public class AllureReporter : RhinoReporter
    {
        #region *** Constructors ***
        /// <summary>
        /// Initializes a new instance of the <see cref="AllureReporter"/> class with configuration.
        /// </summary>
        /// <param name="configuration">The RhinoConfiguration to use for reporting.</param>
        public AllureReporter(RhinoConfiguration configuration)
            : base(configuration)
        { }

        /// <summary>
        /// Initializes a new instance of the <see cref="AllureReporter"/> class with configuration and a logger.
        /// </summary>
        /// <param name="configuration">The RhinoConfiguration to use for reporting.</param>
        /// <param name="logger">The logger to use for logging.</param>
        public AllureReporter(RhinoConfiguration configuration, ILogger logger)
            : base(configuration, logger)
        { }
        #endregion

        // TODO: Implement the logic to generate Allure `json` files based on the provided `testRun` data.
        /// <summary>
        /// Generates Allure `json` files based on the `testRun` data.
        /// </summary>
        /// <param name="testRun">The RhinoTestRun data to generate Allure reports from.</param>
        protected override void OnCreate(RhinoTestRun testRun)
        {
            throw new NotImplementedException();
        }
    }
}
