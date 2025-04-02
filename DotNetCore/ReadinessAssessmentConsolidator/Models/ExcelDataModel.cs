
namespace ReadinessAssessmentConsolidator.models
{
    public class ExcelDataModel
    {
        public String? UserEstimation { get; set; }
        public String? UserJustification { get; set; }
        public String? UserRecommendation { get; set; }

        public override string ToString() {
            return UserEstimation + "\n" + UserJustification + "\n" + UserRecommendation;
        }
    }
}