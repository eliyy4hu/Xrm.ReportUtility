using Xrm.ReportUtility.Models;

namespace Xrm.ReportUtility.PrintTemplate.Abstract
{
    public abstract class TemplateTransformerBase : ITemplateTransformer // декоратор, аналогичный DataTransformer
    {
        private ITemplateTransformer templateTransformer;

        protected TemplateTransformerBase(ITemplateTransformer templateTransformer)
        {
            this.templateTransformer = templateTransformer;
        }

        public PrintTemplate CreateTemplate(ReportConfig reportConfig)
        {
            var template = templateTransformer.CreateTemplate(reportConfig);
            template = UpdateTemplate(template);
            return template;
        }

        protected abstract PrintTemplate UpdateTemplate(PrintTemplate template);
    }
}