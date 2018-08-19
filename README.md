# NewRelicIzendaCustomAttributes
An example of how to pass custom attributes from the Izenda report life cycle to a NewRelic account.

This is a simple conversion of Izenda's IAdHocExtension samples, using the CustomReportDefinition concept to pull the Report
name of a report that has been involved in a custom aliasing process and pass it to New Relic as a custom attribute.

## Installation Instructions
1. Download and unzip.
2. Open the .sln file in Visual Studio.
3. Make any necessary customizations.
4. Build the solution.
5. Copy the CustomAdHocReports.dll and the NewRelic.Api.Agent.dll into an Izenda API's bin directory.
6. Install the New Relic .NET APM on your hosting environment and apply a license key.
