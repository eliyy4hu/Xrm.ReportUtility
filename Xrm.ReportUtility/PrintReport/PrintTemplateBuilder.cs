using System.Collections.Generic;
using System.Linq;

namespace Xrm.ReportUtility.PrintReport
{
    public class PrintTemplateBuilder
    {
        private readonly PrintReportTemplatePart index = new PrintReportTemplatePart();
        private readonly PrintReportTemplatePart name = new PrintReportTemplatePart();
        private readonly PrintReportTemplatePart volume = new PrintReportTemplatePart();
        private readonly PrintReportTemplatePart weight = new PrintReportTemplatePart();
        private readonly PrintReportTemplatePart cost = new PrintReportTemplatePart();
        private readonly PrintReportTemplatePart count = new PrintReportTemplatePart();
        private readonly PrintReportTemplatePart totalVolume = new PrintReportTemplatePart();
        private readonly PrintReportTemplatePart totalWeight = new PrintReportTemplatePart();

        public void SetIndex()
        {
            index.Header = "№";
            index.Row = "{0}";
        }

        public void SetName()
        {
            name.Header = "Наименование";
            name.Row = "{1,12}";
        }

        public void SetVolume()
        {
            volume.Header = "Объём упаковки";
            volume.Row += "{2,14}";
        }

        public void SetWeight()
        {
            weight.Header = "Масса упаковки";
            weight.Row = "{3,14}";
        }

        public void SetCost()
        {
            cost.Header = "Стоимость";
            cost.Row = "{4,9}";
        }

        public void SetCount()
        {
            count.Header = "Количество";
            count.Row = "{5,10}";
        }

        public void SetTotalVolume()
        {
            totalVolume.Header = "Суммарный объём";
            totalVolume.Row = "{6,15}";
        }

        public void SetTotalWeight()
        {
            totalWeight.Header = "Суммарный вес";
            totalWeight.Row = "{7,13}";
        }

        public PrintReportTemplatePart GetResult()
        {
            var order = new List<PrintReportTemplatePart> {index, name, volume, weight, cost, count, totalVolume, totalWeight};
            order = order.Where(x => x.Header != "").ToList();
            var headerTemplate = string.Join("\t", order.Select(x => x.Header));
            var rowTemplate = string.Join("\t", order.Select(x => x.Row));
            return new PrintReportTemplatePart() {Header = headerTemplate, Row = rowTemplate};
        }
    }
}