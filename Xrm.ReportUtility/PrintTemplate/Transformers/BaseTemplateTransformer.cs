using Xrm.ReportUtility.Models;

namespace Xrm.ReportUtility.PrintTemplate.Transformers
{
    public class BaseTemplateTransformer : ITemplateTransformer
    {
        public PrintTemplate CreateTemplate(ReportConfig reportConfig)
        {
            //var headerRow = "Наименование\tОбъём упаковки\tМасса упаковки\tСтоимость\tКоличество";
            var headerRow = "Наименование";
           // var rowTemplate = "{1,12}\t{2,14}\t{3,14}\t{4,9}\t{5,10}";
           var rowTemplate = "{1,12}";
            return new PrintTemplate() {HeaderRow = headerRow, RowTemplate = rowTemplate};
        }
    }
}