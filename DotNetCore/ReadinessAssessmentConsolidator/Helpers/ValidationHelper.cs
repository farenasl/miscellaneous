using ClosedXML.Excel;
using ReadinessAssessmentConsolidator.models;

namespace ReadinessAssessmentConsolidator.helpers
{
    class ValidationHelper
    {
        public static bool ExistInArray(int[] array, int number)
        {
            return Array.Exists(array, e => e == number);
        }

        public static bool IsExcelCellEmpty(IXLRow row, int rowNumber)
        {
            return row.Cell(rowNumber).GetString() != String.Empty;
        }
    }
}