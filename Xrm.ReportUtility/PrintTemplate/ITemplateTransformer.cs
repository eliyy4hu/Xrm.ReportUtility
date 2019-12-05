using Xrm.ReportUtility.Models;

namespace Xrm.ReportUtility.PrintTemplate
{
    public interface ITemplateTransformer
    {
        PrintTemplate CreateTemplate(ReportConfig reportConfig);
    }
}