using System.Linq;
using Xrm.ReportUtility.Infrastructure.Transformers.Abstract;
using Xrm.ReportUtility.Interfaces;
using Xrm.ReportUtility.Models;

namespace Xrm.ReportUtility.Infrastructure.Transformers
{
    public class WeightSumReportTransfomer : ReportServiceTransformerBase
    {
        public WeightSumReportTransfomer(IDataTransformer reportService) : base(reportService)
        {
        }

        protected override Report AfterTransform(Report report, DataRow[] data)
        {
            report.Rows.Add(new ReportRow
            {
                Name = "Суммарный вес",
                Value = data.Sum(i => i.Weight * i.Count)
            });

            return report;
        }
    }
}