using System.IO;
using Xrm.ReportUtility.Infrastructure;
using Xrm.ReportUtility.Interfaces;
using Xrm.ReportUtility.Models;

namespace Xrm.ReportUtility.Services
{
    
    public abstract class ReportServiceBase : IReportService 
    {
        private readonly string[] _args;
        private ArgParser argParser;

        protected ReportServiceBase(string[] args, ArgParser argParser)
        {
            _args = args;
            this.argParser = argParser;
        }

        public Report CreateReport() // шаблонный метод(использует внутри абстрактный метод GetDataRows(), реализуеммый наследниками)
        {
            var config = argParser.ParseReportConfig(_args);
            var dataTransformer = DataTransformerCreator.CreateTransformer(config);

            var fileName = argParser.ParseName(_args);
            var text = File.ReadAllText(fileName);
            var data = GetDataRows(text);
            return dataTransformer.TransformData(data);
        }

        protected abstract DataRow[] GetDataRows(string text);
    }
}
