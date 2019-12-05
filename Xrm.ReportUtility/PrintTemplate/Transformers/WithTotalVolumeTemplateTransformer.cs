using Xrm.ReportUtility.PrintTemplate.Abstract;

namespace Xrm.ReportUtility.PrintTemplate.Transformers
{
    public class WithTotalVolumeTemplateTransformer : TemplateTransformerBase
    {
        public WithTotalVolumeTemplateTransformer(ITemplateTransformer templateTransformer) : base(templateTransformer)
        {
        }

        protected override PrintTemplate UpdateTemplate(PrintTemplate template)
        {
            template.HeaderRow += "\tСуммарный объём";
            template.RowTemplate += "\t{6,15}";
            return template;
        }
    }
}