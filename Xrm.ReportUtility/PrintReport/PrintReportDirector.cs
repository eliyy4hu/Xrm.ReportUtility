﻿using Xrm.ReportUtility.Models;

namespace Xrm.ReportUtility.PrintReport
{
    public class PrintReportDirector
    {
        public PrintReportDirector()
        {
        }

        public void Construct(PrintTemplateBuilder builder, ReportConfig config)
        {
            builder.SetName();
            if (!config.WithoutVolume)
            {
                builder.SetVolume();
            }

            if (!config.WithoutWeight)
            {
                builder.SetWeight();
            }

            if (!config.WithoutCost)
            {
                builder.SetCost();
            }

            if (!config.WithoutCount)
            {
                builder.SetCount();
            }

            if (config.WithIndex)
            {
                builder.SetIndex();
            }

            if (config.WithTotalVolume)
            {
                builder.SetTotalVolume();
            }

            if (config.WithTotalWeight)
            {
                builder.SetTotalWeight();
            }
        }
    }
}