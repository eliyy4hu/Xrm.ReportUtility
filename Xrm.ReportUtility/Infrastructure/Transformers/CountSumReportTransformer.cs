using System.Linq;
using Xrm.ReportUtility.Infrastructure.Transformers.Abstract;
using Xrm.ReportUtility.Interfaces;
using Xrm.ReportUtility.Models;

namespace Xrm.ReportUtility.Infrastructure.Transformers
{
    public class CountSumReportTransformer : ReportServiceTransformerBase
    {
        public CountSumReportTransformer(IDataTransformer reportService) : base(reportService)
        {
        }


        protected override Report AfterTransform(Report report, DataRow[] data)
        {
            report.Rows.Add(new ReportRow
            {
                Name = "Суммарное количество",
                Value = data.Sum(i => i.Count)
            });

            return report;
        }
    }
}