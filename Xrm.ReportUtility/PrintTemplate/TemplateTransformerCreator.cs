using Xrm.ReportUtility.Models;
using Xrm.ReportUtility.PrintTemplate.Transformers;

namespace Xrm.ReportUtility.PrintTemplate
{
    public static class TemplateTransformerCreator
    {
        public static ITemplateTransformer CreateTemplateTransformer(ReportConfig config)
        {
            ITemplateTransformer transformer = new BaseTemplateTransformer();
            if (!config.WithoutVolume)
            {
                transformer = new WithVolumeTemplateTransformer(transformer);
            }

            if (!config.WithoutWeight)
            {
                transformer = new WithWeightTemplateTransformer(transformer);
            }

            if (!config.WithoutCost)
            {
                transformer = new WithCostTemplateTransformer(transformer);
            }

            if (!config.WithoutCount)
            {
                transformer = new WithCountTemplateTransformer(transformer);
            }

            if (config.WithIndex)
            {
                transformer = new WithIndexTemplateTransformer(transformer);
            }

            if (config.WithTotalVolume)
            {
                transformer = new WithTotalVolumeTemplateTransformer(transformer);
            }

            if (config.WithTotalWeight)
            {
                transformer = new WithTotalWeightTemplateTransformer(transformer);
            }

            return transformer;
        }
    }
}