using System.Linq;
using Xrm.ReportUtility.Infrastructure.Transformers.Abstract;
using Xrm.ReportUtility.Interfaces;
using Xrm.ReportUtility.Models;

namespace Xrm.ReportUtility.Infrastructure.Transformers
{
    public class VolumeSumReportTransformer : ReportServiceTransformerBase
    {
        public VolumeSumReportTransformer(IDataTransformer reportService) : base(reportService)
        {
        }


        protected override Report AfterTransform(Report report, DataRow[] data)
        {
            report.Rows.Add(new ReportRow
            {
                Name = "Суммарный объём",
                Value = data.Sum(i => i.Volume * i.Count)
            });

            return report;
        }
    }
}