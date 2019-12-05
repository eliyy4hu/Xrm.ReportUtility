using Xrm.ReportUtility.PrintTemplate.Abstract;

namespace Xrm.ReportUtility.PrintTemplate.Transformers
{
    public class WithIndexTemplateTransformer : TemplateTransformerBase
    {
        public WithIndexTemplateTransformer(ITemplateTransformer templateTransformer) : base(templateTransformer)
        {
        }

        protected override PrintTemplate UpdateTemplate( PrintTemplate template)
        {
            template.HeaderRow = "№\t" + template.HeaderRow;
            template.RowTemplate = "{0}\t" + template.RowTemplate;
            return template;
        }
    }
}