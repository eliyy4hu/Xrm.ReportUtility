using Xrm.ReportUtility.PrintTemplate.Abstract;

namespace Xrm.ReportUtility.PrintTemplate.Transformers
{
    public class WithTotalWeightTemplateTransformer : TemplateTransformerBase
    {
        public WithTotalWeightTemplateTransformer(ITemplateTransformer templateTransformer) : base(templateTransformer)
        {
        }

        protected override PrintTemplate UpdateTemplate(PrintTemplate template)
        {
            template.HeaderRow += "\tСуммарный вес";
            template.RowTemplate += "\t{7,13}";
            return template;
        }
    }
}