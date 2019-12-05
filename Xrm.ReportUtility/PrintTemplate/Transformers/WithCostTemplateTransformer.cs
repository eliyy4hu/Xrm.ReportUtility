using Xrm.ReportUtility.PrintTemplate.Abstract;

namespace Xrm.ReportUtility.PrintTemplate.Transformers
{
    public class WithCostTemplateTransformer : TemplateTransformerBase
    {
        public WithCostTemplateTransformer(ITemplateTransformer templateTransformer) : base(templateTransformer)
        {
        }

        protected override PrintTemplate UpdateTemplate(PrintTemplate template)
        {
            template.HeaderRow += "\tСтоимость";
            template.RowTemplate += "\t{4,9}";
            return template;
        }
    }
}