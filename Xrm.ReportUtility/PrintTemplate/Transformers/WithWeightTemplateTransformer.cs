using Xrm.ReportUtility.PrintTemplate.Abstract;

namespace Xrm.ReportUtility.PrintTemplate.Transformers
{
    public class WithWeightTemplateTransformer : TemplateTransformerBase
    {
        public WithWeightTemplateTransformer(ITemplateTransformer templateTransformer) : base(templateTransformer)
        {
        }

        protected override PrintTemplate UpdateTemplate(PrintTemplate template)
        {
            template.HeaderRow += "\tМасса упаковки";
            template.RowTemplate += "\t{3,14}";
            return template;
        }
    }
}