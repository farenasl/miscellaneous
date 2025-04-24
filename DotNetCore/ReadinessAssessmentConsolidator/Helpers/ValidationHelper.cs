namespace ReadinessAssessmentConsolidator.helpers
{
    class ValidationHelper
    {
        public static bool ExistInArray(int[] array, int number)
        {
            return Array.Exists(array, e => e == number);
        }
    }
}