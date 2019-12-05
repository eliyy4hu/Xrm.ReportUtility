using System;
using System.Linq;
using Xrm.ReportUtility.Interfaces;
using Xrm.ReportUtility.Models;
using Xrm.ReportUtility.Services;

namespace Xrm.ReportUtility
{
    public static class Program
    {
        // "Files/table.txt" -data -weightSum -costSum -withIndex -withTotalVolume
        public static void Main(string[] args)
        {
            var argParser = new ArgParser();
            argParser.ValidateArgs(args);
            var service = GetReportService(args, argParser);

            var report = service.CreateReport();

            PrintReport(report);

            Console.WriteLine("");
            Console.WriteLine("Press enter...");
            Console.ReadLine();
        }

        private static IReportService GetReportService(string[] args, ArgParser argParser)
        {
            // статический фабричный метод
            var filename = argParser.ParseName(args);

            if (filename.EndsWith(".txt"))
            {
                return new TxtReportService(args, argParser);
            }

            if (filename.EndsWith(".csv"))
            {
                return new CsvReportService(args, argParser);
            }

            if (filename.EndsWith(".xlsx"))
            {
                return new XlsxReportService(args, argParser);
            }

            throw new NotSupportedException("this extension not supported");
        }

        private static void PrintReport(Report report)
        {
            if (report.Config.WithData && report.Data != null && report.Data.Any())
            {
                var printReportBuilder = new PrintTemplateBuilder();
                var printReportDirector = new PrintReportDirector(printReportBuilder, report.Config);
                var template = printReportBuilder.GetResult();
                var headerRow = template.Header;
                var rowTemplate = template.Row;

                Console.WriteLine(headerRow);

                for (var i = 0; i < report.Data.Length; i++)
                {
                    var dataRow = report.Data[i];
                    Console.WriteLine(rowTemplate, i + 1, dataRow.Name, dataRow.Volume, dataRow.Weight, dataRow.Cost,
                        dataRow.Count, dataRow.Volume * dataRow.Count, dataRow.Weight * dataRow.Count);
                }

                Console.WriteLine();
            }

            if (report.Rows != null && report.Rows.Any())
            {
                Console.WriteLine("Итого:");
                foreach (var reportRow in report.Rows)
                {
                    Console.WriteLine(string.Format("  {0,-20}\t{1}", reportRow.Name, reportRow.Value));
                }
            }
        }
    }
}