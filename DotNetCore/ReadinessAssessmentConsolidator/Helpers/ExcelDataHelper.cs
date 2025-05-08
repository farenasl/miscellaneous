using ClosedXML.Excel;
using ReadinessAssessmentConsolidator.models;

namespace ReadinessAssessmentConsolidator.helpers
{
    class ExcelDataHelper
    {
        public static void ProcessingExcelDataStructure(List<ExcelDataModel> feedbackList, IXLWorksheet ws)
        {
            AddFirstRowStructureExcelDataToFeedbackList(feedbackList, ws);
            AddSecondRowStructureExcelDataToFeedbackList(feedbackList, ws);
            AddThirdRowStructureExcelDataToFeedbackList(feedbackList, ws);
            feedbackList.Add(new ExcelDataModel());
        }

        public static void AddFirstRowStructureExcelDataToFeedbackList(List<ExcelDataModel> feedbackList, IXLWorksheet ws)
        {
            feedbackList.Add(new ExcelDataModel()
            {
                DataColumn1 = ws.Row(1).Cell(1).GetString()
            });
        }

        public static void AddSecondRowStructureExcelDataToFeedbackList(List<ExcelDataModel> feedbackList, IXLWorksheet ws)
        {
            feedbackList.Add(new ExcelDataModel()
            {
                DataColumn1 = ws.Row(2).Cell(1).GetString(),
                DataColumn2 = ws.Row(2).Cell(2).GetString(),
                DataColumn3 = ws.Row(2).Cell(3).GetString(),
                DataColumn4 = ws.Row(2).Cell(4).GetString(),
                DataColumn5 = ws.Row(2).Cell(5).GetString()
            });
        }

        public static void AddThirdRowStructureExcelDataToFeedbackList(List<ExcelDataModel> feedbackList, IXLWorksheet ws)
        {
            feedbackList.Add(new ExcelDataModel()
            {
                DataColumn1 = ws.Row(3).Cell(1).GetString(),
                DataColumn2 = ws.Row(3).Cell(2).GetString()
            });
        }

        public static void ProcessingFirstFileExcelData(IXLRow row, List<ExcelDataModel> feedbackList, String inputUser)
        {
            if (ValidationHelper.ExistInArray([11, 13, 18, 20, 25, 27, 33, 35, 43, 45,
                55, 57, 64, 66, 74, 76, 84, 86, 93], row.RowNumber()))
                feedbackList.Add(new ExcelDataModel());
            else if (ValidationHelper.ExistInArray([12, 19, 26, 34, 44, 56, 65, 75, 85], row.RowNumber()))
                AddTemplateExcelDataToFeedbackList(feedbackList, row);
            else
                AddUserInputAndTemplateExcelDataToFeedbackList(feedbackList, row, inputUser);
        }

        public static void AddTemplateExcelDataToFeedbackList(List<ExcelDataModel> feedbackList, IXLRow row)
        {
            feedbackList.Add(new ExcelDataModel()
            {
                DataColumn1 = row.Cell(1).GetString(),
                DataColumn2 = row.Cell(2).GetString()
            });
        }

        public static void AddUserInputAndTemplateExcelDataToFeedbackList(List<ExcelDataModel> feedbackList, IXLRow row, String inputUser)
        {
            feedbackList.Add(new ExcelDataModel()
            {
                DataColumn1 = row.Cell(1).GetString(),
                DataColumn2 = row.Cell(2).GetString(),
                DataColumn3 = ValidationHelper.IsExcelCellEmpty(row, 3) ? FormatInputExcelData(row, 3, inputUser) : String.Empty,
                DataColumn4 = ValidationHelper.IsExcelCellEmpty(row, 4) ? FormatInputExcelData(row, 4, inputUser) : String.Empty,
                DataColumn5 = ValidationHelper.IsExcelCellEmpty(row, 5) ? FormatInputExcelData(row, 5, inputUser) : String.Empty
            });
        }

        public static void ProcessingNonFirstFileExcelData(IXLWorksheet ws, int listCounter, List<ExcelDataModel> feedbackList, String inputUser)
        {
            foreach (var row in ws.Rows().Skip(4))
            {
                if (listCounter == 93 
                || ValidationHelper.ExistInArray([11, 12, 13, 18, 19, 20, 25, 26, 27, 33, 34, 35, 43, 44,
                    45, 55, 56, 57, 64, 65, 66, 74, 75, 76, 84, 85, 86, 93], row.RowNumber())) 
                {
                    listCounter++;
                    continue;
                }

                AddUserInputExcelDataToFeedbackList(feedbackList, listCounter, row, inputUser);
                listCounter++;
            }
        }

        public static void AddUserInputExcelDataToFeedbackList(List<ExcelDataModel> feedbackList, int index, IXLRow row, String inputUser)
        {
            feedbackList[index].DataColumn3 += ValidationHelper.IsExcelCellEmpty(row, 3) ? FormatInputExcelData(row, 3, inputUser) + "\n" : String.Empty;
            feedbackList[index].DataColumn4 += ValidationHelper.IsExcelCellEmpty(row, 4) ? FormatInputExcelData(row, 4, inputUser) + "\n" : String.Empty;
            feedbackList[index].DataColumn5 += ValidationHelper.IsExcelCellEmpty(row, 5) ? FormatInputExcelData(row, 5, inputUser) + "\n" : String.Empty;
        }

        public static String FormatInputExcelData(IXLRow row, int rowNumber, String inputUser)
        {
            return inputUser + ": " + row.Cell(rowNumber).GetString();
        }
    }
}