using Xrm.ReportUtility.PrintTemplate.Abstract;

namespace Xrm.ReportUtility.PrintTemplate.Transformers
{
    public class WithCountTemplateTransformer : TemplateTransformerBase
    {
        public WithCountTemplateTransformer(ITemplateTransformer templateTransformer) : base(templateTransformer)
        {
        }

        protected override PrintTemplate UpdateTemplate(PrintTemplate template)
        {
            template.HeaderRow += "\tКоличество";
            template.RowTemplate += "\t{5,10}";
            return template;
        }
    }
}