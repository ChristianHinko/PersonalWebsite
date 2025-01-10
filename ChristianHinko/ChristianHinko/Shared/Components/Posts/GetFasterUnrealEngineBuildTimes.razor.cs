namespace ChristianHinko.Shared.Components.Posts;

/// <summary>
/// NOTE: Having to do code-behind for the raw string literals. Can't use raw string literals in razor components for some reason.
/// </summary>
public partial class GetFasterUnrealEngineBuildTimes
{
    protected const string BuildConfigurationXml_Default =
        """
        <?xml version="1.0" encoding="utf-8" ?>
        <Configuration xmlns="https://www.unrealengine.com/BuildConfiguration">
        </Configuration>
        """;

    protected const string BuildConfigurationXml_bAllCores =
        """
        <?xml version="1.0" encoding="utf-8" ?>
        <Configuration xmlns="https://www.unrealengine.com/BuildConfiguration">
            <BuildConfiguration>
                <bAllCores>true</bAllCores>
            </BuildConfiguration>
        </Configuration>
        """;

    protected const string BuildConfigurationXml_ProcessorCountMultiplier =
        """
        <?xml version="1.0" encoding="utf-8" ?>
        <Configuration xmlns="https://www.unrealengine.com/BuildConfiguration">
            <ParallelExecutor>
                <ProcessorCountMultiplier>4</ProcessorCountMultiplier>
            </ParallelExecutor>
        </Configuration>
        """;
}
