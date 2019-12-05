using Xrm.ReportUtility.PrintTemplate.Abstract;

namespace Xrm.ReportUtility.PrintTemplate.Transformers
{
    public class WithVolumeTemplateTransformer : TemplateTransformerBase
    {
        public WithVolumeTemplateTransformer(ITemplateTransformer templateTransformer) : base(templateTransformer)
        {
        }

        protected override PrintTemplate UpdateTemplate(PrintTemplate template)
        {
            template.HeaderRow += "\tОбъём упаковки";
            template.RowTemplate += "\t{2,14}";
            return template;
        }
    }
}