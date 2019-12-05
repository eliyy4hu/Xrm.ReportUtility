namespace Xrm.ReportUtility.Models
{
    public class ReportConfig
    {
        public bool WithData { get; set; }

        public bool WithIndex { get; set; }
        public bool WithTotalVolume { get; set; }
        public bool WithTotalWeight { get; set; }
        public bool WithoutVolume { get; set; }
        public bool WithoutWeight { get; set; }
        public bool WithoutCost { get; set; }
        public bool WithoutCount { get; set; }

        public bool VolumeSum { get; set; }
        public bool WeightSum { get; set; }
        public bool CostSum { get; set; }
        public bool CountSum { get; set; }
    }
}