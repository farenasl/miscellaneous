using ClosedXML.Excel;
using System.IO;

using ReadinessAssessmentConsolidator.models;
using ReadinessAssessmentConsolidator.helpers;

namespace ReadinessAssessmentConsolidator
{
    class Program
    {
        private static List<ExcelDataModel> feedback1 = new();
        private static List<ExcelDataModel> feedback2 = new();
        private static List<ExcelDataModel> feedback3 = new();
        private static List<ExcelDataModel> feedback4 = new();
        private static List<ExcelDataModel> feedback5 = new();
        private static List<ExcelDataModel> feedback6 = new();
        private static List<ExcelDataModel> feedback7 = new();
        private static Dictionary<string, List<ExcelDataModel>> feedbackMap = new Dictionary<string, List<ExcelDataModel>>
        {
            { "BNE DC", feedback1 },
            { "GOONYELLA", feedback2 },
            { "BROADMEADOW", feedback3 },
            { "CAVAL RIDGE", feedback4 },
            { "PEAK DOWNS", feedback5 },
            { "SARAJI", feedback6 },
            { "SARAJI STH", feedback7 }
        };
        private static DateTime startTime = DateTime.Now, endTime;

        private static void Main(string[] args)
        {
            Console.WriteLine("Starting the Readiness Assessment Consolidator program at " + startTime.ToString("HH:mm:ss"));
            Console.WriteLine("Reading all excels inside of excelFiles folder");
            Console.WriteLine("Only files with the extension XLSX will be considered");

            string[] files = Directory.GetFiles("excelFiles/", "*.xlsx");

            Console.WriteLine("We have found " + files.Length + " Excel files to process");

            if (files.Length != 0)
            {
                Array.ForEach(files, ProcessExcel);
                SavingConsolidatedExcel();
            }            

            Console.WriteLine("Ending the Readiness Assessment Consolidator program at " + endTime.ToString("HH:mm:ss"));
            Console.WriteLine(files.Length + " files processed in " + endTime.Subtract(startTime).TotalSeconds + " seconds");
            Console.WriteLine("Press any key to close the program...");
            Console.ReadKey();
        }

        private static void ProcessExcel(String filePath)
        {
            Console.WriteLine("Starting processing file " + filePath);

            using (var workbook = new XLWorkbook(filePath))
            {
                foreach (var sheet in workbook.Worksheets)
                    if (!(sheet.Name == "INTRO" || sheet.Name == "How To"))
                        ProcessFeedback(filePath.Split(" - ")[1].Replace(".xlsx", string.Empty)
                            , workbook.Worksheet(sheet.Name));
            }

            Console.WriteLine("End processing file " + filePath);
        }

        private static void ProcessFeedback(string associatedUser, IXLWorksheet worksheet)
        {
            if (feedbackMap.TryGetValue(worksheet.Name, out var feedbackList))
            {
                if (feedbackList.Count < 82)
                {
                    ProcessingWorksheetStructure(worksheet);
                    ProcessingFirstFile(associatedUser, worksheet);
                }
                else
                    ProcessingNotFirstFile(associatedUser, worksheet);
            }
        }

        private static void ProcessingWorksheetStructure(IXLWorksheet worksheet)
        {
            if (feedbackMap.TryGetValue(worksheet.Name, out var feedbackList))
                ExcelDataHelper.ProcessingExcelDataStructure(feedbackList, worksheet);
        }

        private static void ProcessingFirstFile(String associatedUser, IXLWorksheet worksheet)
        {
            foreach (var row in worksheet.Rows().Skip(4))
                if (feedbackMap.TryGetValue(worksheet.Name, out var feedbackList))
                    ExcelDataHelper.ProcessingFirstFileExcelData(row, feedbackList, associatedUser);
        }

        private static void ProcessingNotFirstFile(String associatedUser, IXLWorksheet worksheet)
        {
            int rowCounter = 4;
            if (feedbackMap.TryGetValue(worksheet.Name, out var feedbackList))
                ExcelDataHelper.ProcessingNonFirstFileExcelData(worksheet, rowCounter, feedbackList, associatedUser);
        }

        private static void SavingConsolidatedExcel()
        {
            var wb = new XLWorkbook();

            foreach (var (sheetName, feedbackList) in feedbackMap)
            {
                var ws = wb.Worksheets.Add(sheetName);
                ws.Cell(1, 1).InsertData(feedbackList);
                ExcelStylistHelper.AddStyle(ws);
            }

            endTime = DateTime.Now;
            wb.SaveAs("results/BMA_Technology_Readiness_Survey_Consolidated_" + endTime.ToString("yyyyMMdd_HHmmss") + ".xlsx");

            Console.WriteLine("File BMA_Technology_Readiness_Survey_Consolidated_" + endTime.ToString("yyyyMMdd_HHmmss") + ".xlsx generated successfully!");
        }        
    }
}