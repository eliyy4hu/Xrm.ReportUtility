﻿using System.Linq;
using Xrm.ReportUtility.Infrastructure.Transformers.Abstract;
using Xrm.ReportUtility.Interfaces;
using Xrm.ReportUtility.Models;

namespace Xrm.ReportUtility.Infrastructure.Transformers
{
    public class CostSumReportTransformer : ReportServiceTransformerBase
    {
        public CostSumReportTransformer(IDataTransformer dataTransformer) : base(dataTransformer)
        {
        }


        protected override Report AfterTransform(Report report, DataRow[] data)
        {
            report.Rows.Add(new ReportRow
            {
                Name = "Суммарная стоимость",
                Value = data.Sum(i => i.Cost * i.Count)
            });

            return report;
        }
    }
}