using System;
using System.Linq;
using Izenda.BI.Framework.Models.ReportDesigner;
using Izenda.BI.Framework.Constants;
using System.Collections.Generic;

namespace CustomAdhocReports
{
    /// <summary>
    /// The custom report definition class.
    /// </summary>
    static class CustomReportDefinition
    {
        /// <summary>
        /// Customizes the report definition before it is executed.
        /// </summary>
        /// <param name="reportDefinition">The report definition to be customized.</param>
        /// <returns>Returns the customized report definition.</returns>
        public static ReportDefinition OnPreExecute(ReportDefinition reportDefinition)
        {

            // Updates a column's name/alias
            const string columnToBeCustomized = "Status";
            foreach (var reportPart in reportDefinition.ReportPart.Select(f => f.ReportPartContent))
            {
                if (reportPart.GetAllFields().Any(f => f.FieldNameAlias == columnToBeCustomized))
                {
                    var filteredFieldsWithColumn = reportPart.GetAllFields().Where(f => f.FieldNameAlias == columnToBeCustomized).ToList();
                    filteredFieldsWithColumn.ForEach(f => f.FieldNameAlias = "OrderStatus");
                }
            }

            //NewRelic Custom Parameter
            var ReportName = reportDefinition.Name;
            var eventAttributes = new Dictionary<string, object>() { { "ReportDefinition", ReportName } };
            NewRelic.Api.Agent.NewRelic.RecordCustomEvent("DockerApiCustomEvent", eventAttributes);
            return reportDefinition;
        }
    }
}
