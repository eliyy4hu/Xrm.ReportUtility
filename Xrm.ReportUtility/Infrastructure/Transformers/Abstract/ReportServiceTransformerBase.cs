using Xrm.ReportUtility.Interfaces;
using Xrm.ReportUtility.Models;

namespace Xrm.ReportUtility.Infrastructure.Transformers.Abstract
{
    public abstract class ReportServiceTransformerBase : IDataTransformer
    {
        private readonly IDataTransformer dataTransformer; 

        protected ReportServiceTransformerBase(IDataTransformer dataTransformer)
        {
            this.dataTransformer = dataTransformer;
        }

        public Report TransformData(DataRow[] data)
        {
            var report = dataTransformer.TransformData(data);
            return AfterTransform(report,data);
        }

        protected abstract Report AfterTransform(Report report,DataRow[] data );
    }
}
