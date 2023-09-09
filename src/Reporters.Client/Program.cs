using Gravity.Services.DataContracts;

using Rhino.Api.Extensions;
using Rhino.Api.Contracts.Configuration;

using System;
using System.Collections.Generic;
using System.IO;

// Creates a RhinoConfiguration object with specific settings.
var configuration = new RhinoConfiguration
{
    // Set the name of the configuration.
    Name = "Test Configuration",

    // Define the repository of test files.
    TestsRepository = new[]
    {
        File.ReadAllText("001GooglePositiveTest.txt"),
        //File.ReadAllText("002GoogleNegativeTest.txt"),
    },

    // Configure the driver parameters, which specify how the Rhino framework interacts with the web driver.
    // Create an array of dictionaries, where each dictionary represents a set of driver parameters.
    DriverParameters = new[]
    {
        new Dictionary<string, object>
        {
            // Specify the type of web driver to use. In this case, it's "ChromeDriver".
            ["driver"] = "ChromeDriver",

            // Define the directory where the driver binaries are located.
            // The "." typically refers to the current working directory.
            // It means that the driver binaries should be available in the current directory.
            ["driverBinaries"] = "."
        }
    },

    // Configure authentication settings.
    Authentication = new Authentication
    {
        Username = "",
        Password = ""
    },

    // Configure the connector used for tests.
    ConnectorConfiguration = new RhinoConnectorConfiguration
    {
        Connector = "ConnectorText"
    },

    // Configure the engine settings.
    EngineConfiguration = new RhinoEngineConfiguration
    {
        MaxParallel = 5,
        ReturnExceptions = true,
        ReturnPerformancePoints = true,
        ReturnEnvironment = true
    },

    // Configure screenshot settings.
    ScreenshotsConfiguration = new RhinoScreenshotsConfiguration
    {
        ReturnScreenshots = true,
        ScreenshotsOut = Path.Combine(Environment.CurrentDirectory, "Reports", "Images"),
        KeepOriginal = true
    },

    // Create the ReportConfiguration section of the RhinoConfiguration.
    ReportConfiguration = new RhinoReportConfiguration
    {
        // Specify the output directory for the test reports.
        // The reports will be stored in the "Reports/Rhino" subdirectory of the current working directory.
        ReportOut = Path.Combine(Environment.CurrentDirectory, "Reports", "Rhino"),

        // Define the reporters that will be used for generating test reports.
        // In this case, two reporters are configured: "BasicReporter" and "AllureReporter".
        Reporters = new[]
        {
            "BasicReporter",    // The "BasicReporter" generates basic test reports.
            "AllureReporter"    // The "AllureReporter" generates reports in Allure format.
        },

        // Specify the directory where log files will be stored.
        // Log files are typically used to capture detailed information about test execution.
        // Logs will be stored in the "Reports/Logs" subdirectory of the current working directory.
        LogsOut = Path.Combine(Environment.CurrentDirectory, "Reports", "Logs"),

        // Enable the option to add Gravity-specific data to the test reports.
        // This might include additional information or context related to test execution.
        AddGravityData = true
    }
};

// Invoke the configuration with specified types.
var t = Utilities.Types;
configuration.Invoke(Utilities.Types);
