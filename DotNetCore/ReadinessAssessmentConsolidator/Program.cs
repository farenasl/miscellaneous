using ClosedXML.Excel;
using System.IO;

using ReadinessAssessmentConsolidator.models;

namespace ReadinessAssessmentConsolidator
{
    class Program
    {
        private static List<ExcelDataModel> feedback = new();

        private static void Main(string[] args)
        {
            Console.WriteLine("Starting the Readiness Assessment Consolidator program!!");

            Console.WriteLine("Reading all excels inside of excelFiles folder");
            Console.WriteLine("Only files with the extension XLSX will be considered");

            string[] files = Directory.GetFiles("excelFiles/", "*.xlsx");
            Console.WriteLine("We have found " + files.Length + " Excel files to process");
            // Array.ForEach(files, Console.WriteLine);

            Array.ForEach(files, ProcessExcel);

            //feedback.ForEach(i => Console.Write("{0}\n", i));

            SavingConsolidatedExcel();

            Console.WriteLine("Ending the Readiness Assessment Consolidator program!!");
        }

        private static void ProcessExcel(String filePath){
            Console.WriteLine("Starting processing file " + filePath);

            using (var workbook = new XLWorkbook(filePath)){
                ProcessFeedback(filePath.Split(" - ")[1].Replace(".xlsx", string.Empty), workbook.Worksheet("BNE DC"));
            }
            Console.WriteLine("End processing file " + filePath);
        }

        private static void ProcessFeedback(String associatedUser, IXLWorksheet worksheet){
            if (feedback.Count < 79)
                ProcessingFirstFile(associatedUser, worksheet);
            else {
                ProcessingNotFirstFile(associatedUser, worksheet);
            }
        }

        private static void ProcessingFirstFile(String associatedUser, IXLWorksheet worksheet) {
            foreach (var row in worksheet.RowsUsed().Skip(4))
                feedback.Add(new ExcelDataModel()
                    {
                        UserEstimation = associatedUser + ": " + row.Cell(3).GetString(),
                        UserJustification = associatedUser + ": " + row.Cell(4).GetString(),
                        UserRecommendation = associatedUser + ": " + row.Cell(5).GetString()
                    }
                );
        }

        private static void ProcessingNotFirstFile(String associatedUser, IXLWorksheet worksheet) {
            int rowCounter = 0;
            foreach (var row in worksheet.RowsUsed().Skip(4)) {
                feedback[rowCounter].UserEstimation += "\n" + associatedUser + ": " + row.Cell(3).GetString();
                feedback[rowCounter].UserJustification += "\n" + associatedUser + ": " + row.Cell(4).GetString();
                feedback[rowCounter].UserRecommendation += "\n" + associatedUser + ": " + row.Cell(5).GetString();
                rowCounter++;
            }
        }

        private static void SavingConsolidatedExcel() {
            var wb = new XLWorkbook();
            var ws = wb.Worksheets.Add("BNE DC");
            ws.Cell(5, 3).InsertData(feedback);
            // wb.SaveAs("excelFiles/BMA Technology Readiness Survey - Consolidated.xlsx");
            wb.SaveAs("results/BMA_Technology_Readiness_Survey_Consolidated_" + DateTime.Now.ToString("yyyyMMdd_HHmmss")+ ".xlsx");
        }
    }
}