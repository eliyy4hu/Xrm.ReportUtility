using System;
using System.Linq;
using Xrm.ReportUtility.Models;

namespace Xrm.ReportUtility
{
    public class ArgParser
    {
        public string ParseName(string[] args)
        {
            return args[0];
        }

        public void ValidateArgs(string[] args)
        {
            var reportConfig = ParseReportConfig(args);
            if ((reportConfig.WithIndex || reportConfig.WithTotalVolume || reportConfig.WithTotalWeight) &&
                !reportConfig.WithData)
            {
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("Warning! No data argument specified");
                Console.ResetColor();
            }

            if (!(reportConfig.VolumeSum || reportConfig.WeightSum || reportConfig.CostSum || reportConfig.CountSum))
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Error! One of required arguments not specified. Specify at least one of required args (volumeSum, weightSum, costSum, countSum)");
                Console.ResetColor();
                Environment.Exit(0);
            }
        }

        public ReportConfig ParseReportConfig(string[] args)
        {
            return new ReportConfig
            {
                WithData = args.Contains("-data"),

                WithIndex = args.Contains("-withIndex"),
                WithTotalVolume = args.Contains("-withTotalVolume"),
                WithTotalWeight = args.Contains("-withTotalWeight"),

                VolumeSum = args.Contains("-volumeSum"),
                WeightSum = args.Contains("-weightSum"),
                CostSum = args.Contains("-costSum"),
                CountSum = args.Contains("-countSum"),
                WithoutCost = args.Contains("-withoutCost"),
                WithoutCount = args.Contains("-withoutCount"),
                WithoutWeight = args.Contains("-withoutWeight"),
                WithoutVolume = args.Contains("-withoutVolume")
                
            };
        }
    }
}