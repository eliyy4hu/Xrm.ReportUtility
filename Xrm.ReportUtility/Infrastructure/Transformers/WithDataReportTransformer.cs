using Xrm.ReportUtility.Infrastructure.Transformers.Abstract;
using Xrm.ReportUtility.Interfaces;
using Xrm.ReportUtility.Models;

namespace Xrm.ReportUtility.Infrastructure.Transformers
{
    public class WithDataReportTransformer : ReportServiceTransformerBase
    {
        public WithDataReportTransformer(IDataTransformer reportService) : base(reportService)
        {
        }

        protected override Report AfterTransform(Report report, DataRow[] data)
        {
            report.Data = data;

            return report;
        }
    }
}