
namespace ReadinessAssessmentConsolidator.models
{
    public class ExcelDataModel
    {
        public String? DataColumn1 { get; set; }
        public String? DataColumn2 { get; set; }
        public String? DataColumn3 { get; set; }
        public String? DataColumn4 { get; set; }
        public String? DataColumn5 { get; set; }

        public override string ToString()
        {
            return DataColumn3 + "\n" + DataColumn4 + "\n" + DataColumn5;
        }
    }
}