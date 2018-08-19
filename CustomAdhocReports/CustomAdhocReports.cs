using Izenda.BI.Framework.CustomConfiguration;
using System;
using System.Collections.Generic;
using System.Linq;
using Izenda.BI.Framework.Models;
using System.ComponentModel.Composition;
using Izenda.BI.Framework.Models.ReportDesigner;
using Izenda.BI.Framework.Utility;
using Izenda.BI.Framework.Models.Contexts; //For Referencing User Context

namespace CustomAdhocReports
{
    [Export(typeof(IAdHocExtension))]
    class CustomAdhocReports : DefaultAdHocExtension
    {
        /// <summary>
        /// Adds custom formats for a specified data type.
        /// </summary>
        public override List<DataFormat> LoadCustomDataFormat()
        {
            return CustomDataFormat.LoadCustomDataFormat();
        }

        /// <summary>
        /// Customizes the report content on the fly before it is executed.
        /// </summary>
        public override ReportDefinition OnPreExecute(ReportDefinition reportDefinition)
        {
            return CustomReportDefinition.OnPreExecute(reportDefinition);
        }
    }
}
