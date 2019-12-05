using System.Collections.Generic;
using System.Linq;

namespace Xrm.ReportUtility
{
    public class PrintTemplateBuilder
    {
        private readonly PrintReportPart index = new PrintReportPart();
        private readonly PrintReportPart name = new PrintReportPart();
        private readonly PrintReportPart volume = new PrintReportPart();
        private readonly PrintReportPart weight = new PrintReportPart();
        private readonly PrintReportPart cost = new PrintReportPart();
        private readonly PrintReportPart count = new PrintReportPart();
        private readonly PrintReportPart totalVolume = new PrintReportPart();
        private readonly PrintReportPart totalWeight = new PrintReportPart();

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

        public PrintReportPart GetResult()
        {
            var order = new List<PrintReportPart> {index, name, volume, weight, cost, count, totalVolume, totalWeight};
            order = order.Where(x => x.Header != "").ToList();
            var headerTemplate = string.Join("\t", order.Select(x => x.Header));
            var rowTemplate = string.Join("\t", order.Select(x => x.Row));
            return new PrintReportPart(){Header = headerTemplate, Row = rowTemplate};
        }
        


    }
}