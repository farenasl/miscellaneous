using ClosedXML.Excel;
using System.IO;

using ReadinessAssessmentConsolidator.models;

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

        private static void ProcessExcel(String filePath)
        {
            Console.WriteLine("Starting processing file " + filePath);

            using (var workbook = new XLWorkbook(filePath))
            {
                foreach (var sheet in workbook.Worksheets)
                {
                    if (!(sheet.Name == "INTRO" || sheet.Name == "How To"))
                        ProcessFeedback(filePath.Split(" - ")[1].Replace(".xlsx", string.Empty)
                            , workbook.Worksheet(sheet.Name));
                }
            }

            Console.WriteLine("End processing file " + filePath);
        }

        private static void ProcessFeedback(String associatedUser, IXLWorksheet worksheet)
        {
            switch (worksheet.Name)
            {
                case "BNE DC":
                    if (feedback1.Count < 79)
                        ProcessingFirstFile(associatedUser, worksheet);
                    else
                        ProcessingNotFirstFile(associatedUser, worksheet);
                    break;
                case "GOONYELLA":
                    if (feedback2.Count < 79)
                        ProcessingFirstFile(associatedUser, worksheet);
                    else
                        ProcessingNotFirstFile(associatedUser, worksheet);
                    break;
                case "BROADMEADOW":
                    if (feedback3.Count < 79)
                        ProcessingFirstFile(associatedUser, worksheet);
                    else
                        ProcessingNotFirstFile(associatedUser, worksheet);
                    break;
                case "CAVAL RIDGE":
                    if (feedback4.Count < 79)
                        ProcessingFirstFile(associatedUser, worksheet);
                    else
                        ProcessingNotFirstFile(associatedUser, worksheet);
                    break;
                case "PEAK DOWNS":
                    if (feedback5.Count < 79)
                        ProcessingFirstFile(associatedUser, worksheet);
                    else
                        ProcessingNotFirstFile(associatedUser, worksheet);
                    break;
                case "SARAJI":
                    if (feedback6.Count < 79)
                        ProcessingFirstFile(associatedUser, worksheet);
                    else
                        ProcessingNotFirstFile(associatedUser, worksheet);
                    break;
                case "SARAJI STH":
                    if (feedback7.Count < 79)
                        ProcessingFirstFile(associatedUser, worksheet);
                    else
                        ProcessingNotFirstFile(associatedUser, worksheet);
                    break;
                default:
                    break;
            }
        }

        private static void ProcessingFirstFile(String associatedUser, IXLWorksheet worksheet)
        {
            foreach (var row in worksheet.RowsUsed().Skip(4))
                switch (worksheet.Name)
                {
                    case "BNE DC":
                        feedback1.Add(new ExcelDataModel()
                        {
                            UserEstimation = associatedUser + ": " + row.Cell(3).GetString(),
                            UserJustification = associatedUser + ": " + row.Cell(4).GetString(),
                            UserRecommendation = associatedUser + ": " + row.Cell(5).GetString()
                        });
                        break;
                    case "GOONYELLA":
                        feedback2.Add(new ExcelDataModel()
                        {
                            UserEstimation = associatedUser + ": " + row.Cell(3).GetString(),
                            UserJustification = associatedUser + ": " + row.Cell(4).GetString(),
                            UserRecommendation = associatedUser + ": " + row.Cell(5).GetString()
                        });
                        break;
                    case "BROADMEADOW":
                        feedback3.Add(new ExcelDataModel()
                        {
                            UserEstimation = associatedUser + ": " + row.Cell(3).GetString(),
                            UserJustification = associatedUser + ": " + row.Cell(4).GetString(),
                            UserRecommendation = associatedUser + ": " + row.Cell(5).GetString()
                        });
                        break;
                    case "CAVAL RIDGE":
                        feedback4.Add(new ExcelDataModel()
                        {
                            UserEstimation = associatedUser + ": " + row.Cell(3).GetString(),
                            UserJustification = associatedUser + ": " + row.Cell(4).GetString(),
                            UserRecommendation = associatedUser + ": " + row.Cell(5).GetString()
                        });
                        break;
                    case "PEAK DOWNS":
                        feedback5.Add(new ExcelDataModel()
                        {
                            UserEstimation = associatedUser + ": " + row.Cell(3).GetString(),
                            UserJustification = associatedUser + ": " + row.Cell(4).GetString(),
                            UserRecommendation = associatedUser + ": " + row.Cell(5).GetString()
                        });
                        break;
                    case "SARAJI":
                        feedback6.Add(new ExcelDataModel()
                        {
                            UserEstimation = associatedUser + ": " + row.Cell(3).GetString(),
                            UserJustification = associatedUser + ": " + row.Cell(4).GetString(),
                            UserRecommendation = associatedUser + ": " + row.Cell(5).GetString()
                        });
                        break;
                    case "SARAJI STH":
                        feedback7.Add(new ExcelDataModel()
                        {
                            UserEstimation = associatedUser + ": " + row.Cell(3).GetString(),
                            UserJustification = associatedUser + ": " + row.Cell(4).GetString(),
                            UserRecommendation = associatedUser + ": " + row.Cell(5).GetString()
                        });
                        break;
                    default:
                        break;
                }
        }

        private static void ProcessingNotFirstFile(String associatedUser, IXLWorksheet worksheet)
        {
            int rowCounter = 0;
            switch (worksheet.Name)
            {
                case "BNE DC":
                    foreach (var row in worksheet.RowsUsed().Skip(4))
                    {
                        feedback1[rowCounter].UserEstimation += "\n" + associatedUser + ": " + row.Cell(3).GetString();
                        feedback1[rowCounter].UserJustification += "\n" + associatedUser + ": " + row.Cell(4).GetString();
                        feedback1[rowCounter].UserRecommendation += "\n" + associatedUser + ": " + row.Cell(5).GetString();
                        rowCounter++;
                    }
                    break;
                case "GOONYELLA":
                    foreach (var row in worksheet.RowsUsed().Skip(4))
                    {
                        feedback2[rowCounter].UserEstimation += "\n" + associatedUser + ": " + row.Cell(3).GetString();
                        feedback2[rowCounter].UserJustification += "\n" + associatedUser + ": " + row.Cell(4).GetString();
                        feedback2[rowCounter].UserRecommendation += "\n" + associatedUser + ": " + row.Cell(5).GetString();
                        rowCounter++;
                    }
                    break;
                case "BROADMEADOW":
                    foreach (var row in worksheet.RowsUsed().Skip(4))
                    {
                        feedback3[rowCounter].UserEstimation += "\n" + associatedUser + ": " + row.Cell(3).GetString();
                        feedback3[rowCounter].UserJustification += "\n" + associatedUser + ": " + row.Cell(4).GetString();
                        feedback3[rowCounter].UserRecommendation += "\n" + associatedUser + ": " + row.Cell(5).GetString();
                        rowCounter++;
                    }
                    break;
                case "CAVAL RIDGE":
                    foreach (var row in worksheet.RowsUsed().Skip(4))
                    {
                        feedback4[rowCounter].UserEstimation += "\n" + associatedUser + ": " + row.Cell(3).GetString();
                        feedback4[rowCounter].UserJustification += "\n" + associatedUser + ": " + row.Cell(4).GetString();
                        feedback4[rowCounter].UserRecommendation += "\n" + associatedUser + ": " + row.Cell(5).GetString();
                        rowCounter++;
                    }
                    break;
                case "PEAK DOWNS":
                    foreach (var row in worksheet.RowsUsed().Skip(4))
                    {
                        feedback5[rowCounter].UserEstimation += "\n" + associatedUser + ": " + row.Cell(3).GetString();
                        feedback5[rowCounter].UserJustification += "\n" + associatedUser + ": " + row.Cell(4).GetString();
                        feedback5[rowCounter].UserRecommendation += "\n" + associatedUser + ": " + row.Cell(5).GetString();
                        rowCounter++;
                    }
                    break;
                case "SARAJI":
                    foreach (var row in worksheet.RowsUsed().Skip(4))
                    {
                        feedback6[rowCounter].UserEstimation += "\n" + associatedUser + ": " + row.Cell(3).GetString();
                        feedback6[rowCounter].UserJustification += "\n" + associatedUser + ": " + row.Cell(4).GetString();
                        feedback6[rowCounter].UserRecommendation += "\n" + associatedUser + ": " + row.Cell(5).GetString();
                        rowCounter++;
                    }
                    break;
                case "SARAJI STH":
                    foreach (var row in worksheet.RowsUsed().Skip(4))
                    {
                        feedback7[rowCounter].UserEstimation += "\n" + associatedUser + ": " + row.Cell(3).GetString();
                        feedback7[rowCounter].UserJustification += "\n" + associatedUser + ": " + row.Cell(4).GetString();
                        feedback7[rowCounter].UserRecommendation += "\n" + associatedUser + ": " + row.Cell(5).GetString();
                        rowCounter++;
                    }
                    break;
                default:
                    break;
            }
        }

        private static void SavingConsolidatedExcel()
        {
            var wb = new XLWorkbook();
            var ws = wb.Worksheets.Add("BNE DC");
            ws.Cell(5, 3).InsertData(feedback1);
            ws = wb.Worksheets.Add("GOONYELLA");
            ws.Cell(5, 3).InsertData(feedback2);
            ws = wb.Worksheets.Add("BROADMEADOW");
            ws.Cell(5, 3).InsertData(feedback3);
            ws = wb.Worksheets.Add("CAVAL RIDGE");
            ws.Cell(5, 3).InsertData(feedback4);
            ws = wb.Worksheets.Add("PEAK DOWNS");
            ws.Cell(5, 3).InsertData(feedback5);
            ws = wb.Worksheets.Add("SARAJI");
            ws.Cell(5, 3).InsertData(feedback6);
            ws = wb.Worksheets.Add("SARAJI STH");
            ws.Cell(5, 3).InsertData(feedback7);
            // wb.SaveAs("excelFiles/BMA Technology Readiness Survey - Consolidated.xlsx");
            wb.SaveAs("results/BMA_Technology_Readiness_Survey_Consolidated_" + DateTime.Now.ToString("yyyyMMdd_HHmmss") + ".xlsx");
        }
    }
}