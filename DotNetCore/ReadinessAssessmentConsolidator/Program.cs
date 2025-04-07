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
                    if (feedback1.Count < 82)
                    {
                        ProcessingWorksheetStructure(worksheet);
                        ProcessingFirstFile(associatedUser, worksheet);
                    }
                    else
                        ProcessingNotFirstFile(associatedUser, worksheet);
                    break;
                case "GOONYELLA":
                    if (feedback2.Count < 82)
                    {
                        ProcessingWorksheetStructure(worksheet);
                        ProcessingFirstFile(associatedUser, worksheet);
                    }
                    else
                        ProcessingNotFirstFile(associatedUser, worksheet);
                    break;
                case "BROADMEADOW":
                    if (feedback3.Count < 82)
                    {
                        ProcessingWorksheetStructure(worksheet);
                        ProcessingFirstFile(associatedUser, worksheet);
                    }
                    else
                        ProcessingNotFirstFile(associatedUser, worksheet);
                    break;
                case "CAVAL RIDGE":
                    if (feedback4.Count < 82)
                    {
                        ProcessingWorksheetStructure(worksheet);
                        ProcessingFirstFile(associatedUser, worksheet);
                    }
                    else
                        ProcessingNotFirstFile(associatedUser, worksheet);
                    break;
                case "PEAK DOWNS":
                    if (feedback5.Count < 82)
                    {
                        ProcessingWorksheetStructure(worksheet);
                        ProcessingFirstFile(associatedUser, worksheet);
                    }
                    else
                        ProcessingNotFirstFile(associatedUser, worksheet);
                    break;
                case "SARAJI":
                    if (feedback6.Count < 82)
                    {
                        ProcessingWorksheetStructure(worksheet);
                        ProcessingFirstFile(associatedUser, worksheet);
                    }
                    else
                        ProcessingNotFirstFile(associatedUser, worksheet);
                    break;
                case "SARAJI STH":
                    if (feedback7.Count < 82)
                    {
                        ProcessingWorksheetStructure(worksheet);
                        ProcessingFirstFile(associatedUser, worksheet);
                    }
                    else
                        ProcessingNotFirstFile(associatedUser, worksheet);
                    break;
                default:
                    break;
            }
        }

        private static void ProcessingWorksheetStructure(IXLWorksheet worksheet)
        {
            switch (worksheet.Name)
            {
                case "BNE DC":
                    feedback1.Add(new ExcelDataModel()
                    {
                        DataColumn1 = worksheet.Row(1).Cell(1).GetString()
                    });
                    feedback1.Add(new ExcelDataModel()
                    {
                        DataColumn1 = worksheet.Row(2).Cell(1).GetString(),
                        DataColumn2 = worksheet.Row(2).Cell(2).GetString(),
                        DataColumn3 = worksheet.Row(2).Cell(3).GetString(),
                        DataColumn4 = worksheet.Row(2).Cell(4).GetString(),
                        DataColumn5 = worksheet.Row(2).Cell(5).GetString()
                    });
                    feedback1.Add(new ExcelDataModel()
                    {
                        DataColumn1 = worksheet.Row(3).Cell(1).GetString(),
                        DataColumn2 = worksheet.Row(3).Cell(2).GetString(),
                    });
                    feedback1.Add(new ExcelDataModel());
                    break;
                case "GOONYELLA":
                    feedback2.Add(new ExcelDataModel()
                    {
                        DataColumn1 = worksheet.Row(1).Cell(1).GetString()
                    });
                    feedback2.Add(new ExcelDataModel()
                    {
                        DataColumn1 = worksheet.Row(2).Cell(1).GetString(),
                        DataColumn2 = worksheet.Row(2).Cell(2).GetString(),
                        DataColumn3 = worksheet.Row(2).Cell(3).GetString(),
                        DataColumn4 = worksheet.Row(2).Cell(4).GetString(),
                        DataColumn5 = worksheet.Row(2).Cell(5).GetString()
                    });
                    feedback2.Add(new ExcelDataModel()
                    {
                        DataColumn1 = worksheet.Row(3).Cell(1).GetString(),
                        DataColumn2 = worksheet.Row(3).Cell(2).GetString(),
                    });
                    feedback2.Add(new ExcelDataModel());
                    break;
                case "BROADMEADOW":
                    feedback3.Add(new ExcelDataModel()
                    {
                        DataColumn1 = worksheet.Row(1).Cell(1).GetString()
                    });
                    feedback3.Add(new ExcelDataModel()
                    {
                        DataColumn1 = worksheet.Row(2).Cell(1).GetString(),
                        DataColumn2 = worksheet.Row(2).Cell(2).GetString(),
                        DataColumn3 = worksheet.Row(2).Cell(3).GetString(),
                        DataColumn4 = worksheet.Row(2).Cell(4).GetString(),
                        DataColumn5 = worksheet.Row(2).Cell(5).GetString()
                    });
                    feedback3.Add(new ExcelDataModel()
                    {
                        DataColumn1 = worksheet.Row(3).Cell(1).GetString(),
                        DataColumn2 = worksheet.Row(3).Cell(2).GetString(),
                    });
                    feedback3.Add(new ExcelDataModel());
                    break;
                case "CAVAL RIDGE":
                    feedback4.Add(new ExcelDataModel()
                    {
                        DataColumn1 = worksheet.Row(1).Cell(1).GetString()
                    });
                    feedback4.Add(new ExcelDataModel()
                    {
                        DataColumn1 = worksheet.Row(2).Cell(1).GetString(),
                        DataColumn2 = worksheet.Row(2).Cell(2).GetString(),
                        DataColumn3 = worksheet.Row(2).Cell(3).GetString(),
                        DataColumn4 = worksheet.Row(2).Cell(4).GetString(),
                        DataColumn5 = worksheet.Row(2).Cell(5).GetString()
                    });
                    feedback4.Add(new ExcelDataModel()
                    {
                        DataColumn1 = worksheet.Row(3).Cell(1).GetString(),
                        DataColumn2 = worksheet.Row(3).Cell(2).GetString(),
                    });
                    feedback4.Add(new ExcelDataModel());
                    break;
                case "PEAK DOWNS":
                    feedback5.Add(new ExcelDataModel()
                    {
                        DataColumn1 = worksheet.Row(1).Cell(1).GetString()
                    });
                    feedback5.Add(new ExcelDataModel()
                    {
                        DataColumn1 = worksheet.Row(2).Cell(1).GetString(),
                        DataColumn2 = worksheet.Row(2).Cell(2).GetString(),
                        DataColumn3 = worksheet.Row(2).Cell(3).GetString(),
                        DataColumn4 = worksheet.Row(2).Cell(4).GetString(),
                        DataColumn5 = worksheet.Row(2).Cell(5).GetString()
                    });
                    feedback5.Add(new ExcelDataModel()
                    {
                        DataColumn1 = worksheet.Row(3).Cell(1).GetString(),
                        DataColumn2 = worksheet.Row(3).Cell(2).GetString(),
                    });
                    feedback5.Add(new ExcelDataModel());
                    break;
                case "SARAJI":
                    feedback6.Add(new ExcelDataModel()
                    {
                        DataColumn1 = worksheet.Row(1).Cell(1).GetString()
                    });
                    feedback6.Add(new ExcelDataModel()
                    {
                        DataColumn1 = worksheet.Row(2).Cell(1).GetString(),
                        DataColumn2 = worksheet.Row(2).Cell(2).GetString(),
                        DataColumn3 = worksheet.Row(2).Cell(3).GetString(),
                        DataColumn4 = worksheet.Row(2).Cell(4).GetString(),
                        DataColumn5 = worksheet.Row(2).Cell(5).GetString()
                    });
                    feedback6.Add(new ExcelDataModel()
                    {
                        DataColumn1 = worksheet.Row(3).Cell(1).GetString(),
                        DataColumn2 = worksheet.Row(3).Cell(2).GetString(),
                    });
                    feedback6.Add(new ExcelDataModel());
                    break;
                case "SARAJI STH":
                    feedback7.Add(new ExcelDataModel()
                    {
                        DataColumn1 = worksheet.Row(1).Cell(1).GetString()
                    });
                    feedback7.Add(new ExcelDataModel()
                    {
                        DataColumn1 = worksheet.Row(2).Cell(1).GetString(),
                        DataColumn2 = worksheet.Row(2).Cell(2).GetString(),
                        DataColumn3 = worksheet.Row(2).Cell(3).GetString(),
                        DataColumn4 = worksheet.Row(2).Cell(4).GetString(),
                        DataColumn5 = worksheet.Row(2).Cell(5).GetString()
                    });
                    feedback7.Add(new ExcelDataModel()
                    {
                        DataColumn1 = worksheet.Row(3).Cell(1).GetString(),
                        DataColumn2 = worksheet.Row(3).Cell(2).GetString(),
                    });
                    feedback7.Add(new ExcelDataModel());
                    break;
                default:
                    break;
            }
        }

        private static void ProcessingFirstFile(String associatedUser, IXLWorksheet worksheet)
        {
            foreach (var row in worksheet.Rows().Skip(4))
                switch (worksheet.Name)
                {
                    case "BNE DC":
                        if (row.RowNumber() == 11 || row.RowNumber() == 13 || row.RowNumber() == 18
                        || row.RowNumber() == 20 || row.RowNumber() == 25 || row.RowNumber() == 27
                        || row.RowNumber() == 33 || row.RowNumber() == 35 || row.RowNumber() == 43
                        || row.RowNumber() == 45 || row.RowNumber() == 55 || row.RowNumber() == 57
                        || row.RowNumber() == 64 || row.RowNumber() == 66 || row.RowNumber() == 74
                        || row.RowNumber() == 76 || row.RowNumber() == 84 || row.RowNumber() == 86
                        || row.RowNumber() == 93)
                            feedback1.Add(new ExcelDataModel());
                        else if (row.RowNumber() == 12 || row.RowNumber() == 19 || row.RowNumber() == 26
                            || row.RowNumber() == 34 || row.RowNumber() == 44 || row.RowNumber() == 56
                            || row.RowNumber() == 65 || row.RowNumber() == 75 || row.RowNumber() == 85)
                            feedback1.Add(new ExcelDataModel()
                            {
                                DataColumn1 = row.Cell(1).GetString(),
                                DataColumn2 = row.Cell(2).GetString()
                            });
                        else
                            feedback1.Add(new ExcelDataModel()
                            {
                                DataColumn1 = row.Cell(1).GetString(),
                                DataColumn2 = row.Cell(2).GetString(),
                                DataColumn3 = associatedUser + ": " + row.Cell(3).GetString(),
                                DataColumn4 = associatedUser + ": " + row.Cell(4).GetString(),
                                DataColumn5 = associatedUser + ": " + row.Cell(5).GetString()
                            });
                        break;
                    case "GOONYELLA":
                        if (row.RowNumber() == 11 || row.RowNumber() == 13 || row.RowNumber() == 18
                        || row.RowNumber() == 20 || row.RowNumber() == 25 || row.RowNumber() == 27
                        || row.RowNumber() == 33 || row.RowNumber() == 35 || row.RowNumber() == 43
                        || row.RowNumber() == 45 || row.RowNumber() == 55 || row.RowNumber() == 57
                        || row.RowNumber() == 64 || row.RowNumber() == 66 || row.RowNumber() == 74
                        || row.RowNumber() == 76 || row.RowNumber() == 84 || row.RowNumber() == 86
                        || row.RowNumber() == 93)
                            feedback2.Add(new ExcelDataModel());
                        else if (row.RowNumber() == 12 || row.RowNumber() == 19 || row.RowNumber() == 26
                            || row.RowNumber() == 34 || row.RowNumber() == 44 || row.RowNumber() == 56
                            || row.RowNumber() == 65 || row.RowNumber() == 75 || row.RowNumber() == 85)
                            feedback2.Add(new ExcelDataModel()
                            {
                                DataColumn1 = row.Cell(1).GetString(),
                                DataColumn2 = row.Cell(2).GetString()
                            });
                        else
                            feedback2.Add(new ExcelDataModel()
                            {
                                DataColumn1 = row.Cell(1).GetString(),
                                DataColumn2 = row.Cell(2).GetString(),
                                DataColumn3 = associatedUser + ": " + row.Cell(3).GetString(),
                                DataColumn4 = associatedUser + ": " + row.Cell(4).GetString(),
                                DataColumn5 = associatedUser + ": " + row.Cell(5).GetString()
                            });
                        break;
                    case "BROADMEADOW":
                        if (row.RowNumber() == 11 || row.RowNumber() == 13 || row.RowNumber() == 18
                        || row.RowNumber() == 20 || row.RowNumber() == 25 || row.RowNumber() == 27
                        || row.RowNumber() == 33 || row.RowNumber() == 35 || row.RowNumber() == 43
                        || row.RowNumber() == 45 || row.RowNumber() == 55 || row.RowNumber() == 57
                        || row.RowNumber() == 64 || row.RowNumber() == 66 || row.RowNumber() == 74
                        || row.RowNumber() == 76 || row.RowNumber() == 84 || row.RowNumber() == 86
                        || row.RowNumber() == 93)
                            feedback3.Add(new ExcelDataModel());
                        else if (row.RowNumber() == 12 || row.RowNumber() == 19 || row.RowNumber() == 26
                            || row.RowNumber() == 34 || row.RowNumber() == 44 || row.RowNumber() == 56
                            || row.RowNumber() == 65 || row.RowNumber() == 75 || row.RowNumber() == 85)
                            feedback3.Add(new ExcelDataModel()
                            {
                                DataColumn1 = row.Cell(1).GetString(),
                                DataColumn2 = row.Cell(2).GetString()
                            });
                        else
                            feedback3.Add(new ExcelDataModel()
                            {
                                DataColumn1 = row.Cell(1).GetString(),
                                DataColumn2 = row.Cell(2).GetString(),
                                DataColumn3 = associatedUser + ": " + row.Cell(3).GetString(),
                                DataColumn4 = associatedUser + ": " + row.Cell(4).GetString(),
                                DataColumn5 = associatedUser + ": " + row.Cell(5).GetString()
                            });
                        break;
                    case "CAVAL RIDGE":
                        if (row.RowNumber() == 11 || row.RowNumber() == 13 || row.RowNumber() == 18
                        || row.RowNumber() == 20 || row.RowNumber() == 25 || row.RowNumber() == 27
                        || row.RowNumber() == 33 || row.RowNumber() == 35 || row.RowNumber() == 43
                        || row.RowNumber() == 45 || row.RowNumber() == 55 || row.RowNumber() == 57
                        || row.RowNumber() == 64 || row.RowNumber() == 66 || row.RowNumber() == 74
                        || row.RowNumber() == 76 || row.RowNumber() == 84 || row.RowNumber() == 86
                        || row.RowNumber() == 93)
                            feedback4.Add(new ExcelDataModel());
                        else if (row.RowNumber() == 12 || row.RowNumber() == 19 || row.RowNumber() == 26
                            || row.RowNumber() == 34 || row.RowNumber() == 44 || row.RowNumber() == 56
                            || row.RowNumber() == 65 || row.RowNumber() == 75 || row.RowNumber() == 85)
                            feedback4.Add(new ExcelDataModel()
                            {
                                DataColumn1 = row.Cell(1).GetString(),
                                DataColumn2 = row.Cell(2).GetString()
                            });
                        else
                            feedback4.Add(new ExcelDataModel()
                            {
                                DataColumn1 = row.Cell(1).GetString(),
                                DataColumn2 = row.Cell(2).GetString(),
                                DataColumn3 = associatedUser + ": " + row.Cell(3).GetString(),
                                DataColumn4 = associatedUser + ": " + row.Cell(4).GetString(),
                                DataColumn5 = associatedUser + ": " + row.Cell(5).GetString()
                            });
                        break;
                    case "PEAK DOWNS":
                        if (row.RowNumber() == 11 || row.RowNumber() == 13 || row.RowNumber() == 18
                        || row.RowNumber() == 20 || row.RowNumber() == 25 || row.RowNumber() == 27
                        || row.RowNumber() == 33 || row.RowNumber() == 35 || row.RowNumber() == 43
                        || row.RowNumber() == 45 || row.RowNumber() == 55 || row.RowNumber() == 57
                        || row.RowNumber() == 64 || row.RowNumber() == 66 || row.RowNumber() == 74
                        || row.RowNumber() == 76 || row.RowNumber() == 84 || row.RowNumber() == 86
                        || row.RowNumber() == 93)
                            feedback5.Add(new ExcelDataModel());
                        else if (row.RowNumber() == 12 || row.RowNumber() == 19 || row.RowNumber() == 26
                            || row.RowNumber() == 34 || row.RowNumber() == 44 || row.RowNumber() == 56
                            || row.RowNumber() == 65 || row.RowNumber() == 75 || row.RowNumber() == 85)
                            feedback5.Add(new ExcelDataModel()
                            {
                                DataColumn1 = row.Cell(1).GetString(),
                                DataColumn2 = row.Cell(2).GetString()
                            });
                        else
                            feedback5.Add(new ExcelDataModel()
                            {
                                DataColumn1 = row.Cell(1).GetString(),
                                DataColumn2 = row.Cell(2).GetString(),
                                DataColumn3 = associatedUser + ": " + row.Cell(3).GetString(),
                                DataColumn4 = associatedUser + ": " + row.Cell(4).GetString(),
                                DataColumn5 = associatedUser + ": " + row.Cell(5).GetString()
                            });
                        break;
                    case "SARAJI":
                        if (row.RowNumber() == 11 || row.RowNumber() == 13 || row.RowNumber() == 18
                        || row.RowNumber() == 20 || row.RowNumber() == 25 || row.RowNumber() == 27
                        || row.RowNumber() == 33 || row.RowNumber() == 35 || row.RowNumber() == 43
                        || row.RowNumber() == 45 || row.RowNumber() == 55 || row.RowNumber() == 57
                        || row.RowNumber() == 64 || row.RowNumber() == 66 || row.RowNumber() == 74
                        || row.RowNumber() == 76 || row.RowNumber() == 84 || row.RowNumber() == 86
                        || row.RowNumber() == 93)
                            feedback6.Add(new ExcelDataModel());
                        else if (row.RowNumber() == 12 || row.RowNumber() == 19 || row.RowNumber() == 26
                            || row.RowNumber() == 34 || row.RowNumber() == 44 || row.RowNumber() == 56
                            || row.RowNumber() == 65 || row.RowNumber() == 75 || row.RowNumber() == 85)
                            feedback6.Add(new ExcelDataModel()
                            {
                                DataColumn1 = row.Cell(1).GetString(),
                                DataColumn2 = row.Cell(2).GetString()
                            });
                        else
                            feedback6.Add(new ExcelDataModel()
                            {
                                DataColumn1 = row.Cell(1).GetString(),
                                DataColumn2 = row.Cell(2).GetString(),
                                DataColumn3 = associatedUser + ": " + row.Cell(3).GetString(),
                                DataColumn4 = associatedUser + ": " + row.Cell(4).GetString(),
                                DataColumn5 = associatedUser + ": " + row.Cell(5).GetString()
                            });
                        break;
                    case "SARAJI STH":
                        if (row.RowNumber() == 11 || row.RowNumber() == 13 || row.RowNumber() == 18
                        || row.RowNumber() == 20 || row.RowNumber() == 25 || row.RowNumber() == 27
                        || row.RowNumber() == 33 || row.RowNumber() == 35 || row.RowNumber() == 43
                        || row.RowNumber() == 45 || row.RowNumber() == 55 || row.RowNumber() == 57
                        || row.RowNumber() == 64 || row.RowNumber() == 66 || row.RowNumber() == 74
                        || row.RowNumber() == 76 || row.RowNumber() == 84 || row.RowNumber() == 86
                        || row.RowNumber() == 93)
                            feedback7.Add(new ExcelDataModel());
                        else if (row.RowNumber() == 12 || row.RowNumber() == 19 || row.RowNumber() == 26
                            || row.RowNumber() == 34 || row.RowNumber() == 44 || row.RowNumber() == 56
                            || row.RowNumber() == 65 || row.RowNumber() == 75 || row.RowNumber() == 85)
                            feedback7.Add(new ExcelDataModel()
                            {
                                DataColumn1 = row.Cell(1).GetString(),
                                DataColumn2 = row.Cell(2).GetString()
                            });
                        else
                            feedback7.Add(new ExcelDataModel()
                            {
                                DataColumn1 = row.Cell(1).GetString(),
                                DataColumn2 = row.Cell(2).GetString(),
                                DataColumn3 = associatedUser + ": " + row.Cell(3).GetString(),
                                DataColumn4 = associatedUser + ": " + row.Cell(4).GetString(),
                                DataColumn5 = associatedUser + ": " + row.Cell(5).GetString()
                            });
                        break;
                    default:
                        break;
                }
        }

        private static void ProcessingNotFirstFile(String associatedUser, IXLWorksheet worksheet)
        {
            int rowCounter = 4;
            switch (worksheet.Name)
            {
                case "BNE DC":
                    foreach (var row in worksheet.Rows().Skip(4))
                    {
                        if (rowCounter == 93 || row.RowNumber() == 11 || row.RowNumber() == 13 || row.RowNumber() == 18
                        || row.RowNumber() == 20 || row.RowNumber() == 25 || row.RowNumber() == 27
                        || row.RowNumber() == 33 || row.RowNumber() == 35 || row.RowNumber() == 43
                        || row.RowNumber() == 45 || row.RowNumber() == 55 || row.RowNumber() == 57
                        || row.RowNumber() == 64 || row.RowNumber() == 66 || row.RowNumber() == 74
                        || row.RowNumber() == 76 || row.RowNumber() == 84 || row.RowNumber() == 86
                        || row.RowNumber() == 12 || row.RowNumber() == 19 || row.RowNumber() == 26
                        || row.RowNumber() == 34 || row.RowNumber() == 44 || row.RowNumber() == 56
                        || row.RowNumber() == 65 || row.RowNumber() == 75 || row.RowNumber() == 85
                        || row.RowNumber() == 93)
                        {
                            rowCounter++;
                            continue;
                        }

                        feedback1[rowCounter].DataColumn3 += "\n" + associatedUser + ": " + row.Cell(3).GetString();
                        feedback1[rowCounter].DataColumn4 += "\n" + associatedUser + ": " + row.Cell(4).GetString();
                        feedback1[rowCounter].DataColumn5 += "\n" + associatedUser + ": " + row.Cell(5).GetString();
                        rowCounter++;
                    }
                    break;
                case "GOONYELLA":
                    foreach (var row in worksheet.Rows().Skip(4))
                    {
                        if (rowCounter == 93 || row.RowNumber() == 11 || row.RowNumber() == 13 || row.RowNumber() == 18
                        || row.RowNumber() == 20 || row.RowNumber() == 25 || row.RowNumber() == 27
                        || row.RowNumber() == 33 || row.RowNumber() == 35 || row.RowNumber() == 43
                        || row.RowNumber() == 45 || row.RowNumber() == 55 || row.RowNumber() == 57
                        || row.RowNumber() == 64 || row.RowNumber() == 66 || row.RowNumber() == 74
                        || row.RowNumber() == 76 || row.RowNumber() == 84 || row.RowNumber() == 86
                        || row.RowNumber() == 12 || row.RowNumber() == 19 || row.RowNumber() == 26
                        || row.RowNumber() == 34 || row.RowNumber() == 44 || row.RowNumber() == 56
                        || row.RowNumber() == 65 || row.RowNumber() == 75 || row.RowNumber() == 85
                        || row.RowNumber() == 93)
                        {
                            rowCounter++;
                            continue;
                        }

                        feedback2[rowCounter].DataColumn3 += "\n" + associatedUser + ": " + row.Cell(3).GetString();
                        feedback2[rowCounter].DataColumn4 += "\n" + associatedUser + ": " + row.Cell(4).GetString();
                        feedback2[rowCounter].DataColumn5 += "\n" + associatedUser + ": " + row.Cell(5).GetString();
                        rowCounter++;
                    }
                    break;
                case "BROADMEADOW":
                    foreach (var row in worksheet.Rows().Skip(4))
                    {
                        if (rowCounter == 93 || row.RowNumber() == 11 || row.RowNumber() == 13 || row.RowNumber() == 18
                        || row.RowNumber() == 20 || row.RowNumber() == 25 || row.RowNumber() == 27
                        || row.RowNumber() == 33 || row.RowNumber() == 35 || row.RowNumber() == 43
                        || row.RowNumber() == 45 || row.RowNumber() == 55 || row.RowNumber() == 57
                        || row.RowNumber() == 64 || row.RowNumber() == 66 || row.RowNumber() == 74
                        || row.RowNumber() == 76 || row.RowNumber() == 84 || row.RowNumber() == 86
                        || row.RowNumber() == 12 || row.RowNumber() == 19 || row.RowNumber() == 26
                        || row.RowNumber() == 34 || row.RowNumber() == 44 || row.RowNumber() == 56
                        || row.RowNumber() == 65 || row.RowNumber() == 75 || row.RowNumber() == 85
                        || row.RowNumber() == 93)
                        {
                            rowCounter++;
                            continue;
                        }

                        feedback3[rowCounter].DataColumn3 += "\n" + associatedUser + ": " + row.Cell(3).GetString();
                        feedback3[rowCounter].DataColumn4 += "\n" + associatedUser + ": " + row.Cell(4).GetString();
                        feedback3[rowCounter].DataColumn5 += "\n" + associatedUser + ": " + row.Cell(5).GetString();
                        rowCounter++;
                    }
                    break;
                case "CAVAL RIDGE":
                    foreach (var row in worksheet.Rows().Skip(4))
                    {
                        if (rowCounter == 93 || row.RowNumber() == 11 || row.RowNumber() == 13 || row.RowNumber() == 18
                        || row.RowNumber() == 20 || row.RowNumber() == 25 || row.RowNumber() == 27
                        || row.RowNumber() == 33 || row.RowNumber() == 35 || row.RowNumber() == 43
                        || row.RowNumber() == 45 || row.RowNumber() == 55 || row.RowNumber() == 57
                        || row.RowNumber() == 64 || row.RowNumber() == 66 || row.RowNumber() == 74
                        || row.RowNumber() == 76 || row.RowNumber() == 84 || row.RowNumber() == 86
                        || row.RowNumber() == 12 || row.RowNumber() == 19 || row.RowNumber() == 26
                        || row.RowNumber() == 34 || row.RowNumber() == 44 || row.RowNumber() == 56
                        || row.RowNumber() == 65 || row.RowNumber() == 75 || row.RowNumber() == 85
                        || row.RowNumber() == 93)
                        {
                            rowCounter++;
                            continue;
                        }

                        feedback4[rowCounter].DataColumn3 += "\n" + associatedUser + ": " + row.Cell(3).GetString();
                        feedback4[rowCounter].DataColumn4 += "\n" + associatedUser + ": " + row.Cell(4).GetString();
                        feedback4[rowCounter].DataColumn5 += "\n" + associatedUser + ": " + row.Cell(5).GetString();
                        rowCounter++;
                    }
                    break;
                case "PEAK DOWNS":
                    foreach (var row in worksheet.Rows().Skip(4))
                    {
                        if (rowCounter == 93 || row.RowNumber() == 11 || row.RowNumber() == 13 || row.RowNumber() == 18
                        || row.RowNumber() == 20 || row.RowNumber() == 25 || row.RowNumber() == 27
                        || row.RowNumber() == 33 || row.RowNumber() == 35 || row.RowNumber() == 43
                        || row.RowNumber() == 45 || row.RowNumber() == 55 || row.RowNumber() == 57
                        || row.RowNumber() == 64 || row.RowNumber() == 66 || row.RowNumber() == 74
                        || row.RowNumber() == 76 || row.RowNumber() == 84 || row.RowNumber() == 86
                        || row.RowNumber() == 12 || row.RowNumber() == 19 || row.RowNumber() == 26
                        || row.RowNumber() == 34 || row.RowNumber() == 44 || row.RowNumber() == 56
                        || row.RowNumber() == 65 || row.RowNumber() == 75 || row.RowNumber() == 85
                        || row.RowNumber() == 93)
                        {
                            rowCounter++;
                            continue;
                        }

                        feedback5[rowCounter].DataColumn3 += "\n" + associatedUser + ": " + row.Cell(3).GetString();
                        feedback5[rowCounter].DataColumn4 += "\n" + associatedUser + ": " + row.Cell(4).GetString();
                        feedback5[rowCounter].DataColumn5 += "\n" + associatedUser + ": " + row.Cell(5).GetString();
                        rowCounter++;
                    }
                    break;
                case "SARAJI":
                    foreach (var row in worksheet.Rows().Skip(4))
                    {
                        if (rowCounter == 93 || row.RowNumber() == 11 || row.RowNumber() == 13 || row.RowNumber() == 18
                        || row.RowNumber() == 20 || row.RowNumber() == 25 || row.RowNumber() == 27
                        || row.RowNumber() == 33 || row.RowNumber() == 35 || row.RowNumber() == 43
                        || row.RowNumber() == 45 || row.RowNumber() == 55 || row.RowNumber() == 57
                        || row.RowNumber() == 64 || row.RowNumber() == 66 || row.RowNumber() == 74
                        || row.RowNumber() == 76 || row.RowNumber() == 84 || row.RowNumber() == 86
                        || row.RowNumber() == 12 || row.RowNumber() == 19 || row.RowNumber() == 26
                        || row.RowNumber() == 34 || row.RowNumber() == 44 || row.RowNumber() == 56
                        || row.RowNumber() == 65 || row.RowNumber() == 75 || row.RowNumber() == 85
                        || row.RowNumber() == 93)
                        {
                            rowCounter++;
                            continue;
                        }

                        feedback6[rowCounter].DataColumn3 += "\n" + associatedUser + ": " + row.Cell(3).GetString();
                        feedback6[rowCounter].DataColumn4 += "\n" + associatedUser + ": " + row.Cell(4).GetString();
                        feedback6[rowCounter].DataColumn5 += "\n" + associatedUser + ": " + row.Cell(5).GetString();
                        rowCounter++;
                    }
                    break;
                case "SARAJI STH":
                    foreach (var row in worksheet.Rows().Skip(4))
                    {
                        if (rowCounter == 93 || row.RowNumber() == 11 || row.RowNumber() == 13 || row.RowNumber() == 18
                        || row.RowNumber() == 20 || row.RowNumber() == 25 || row.RowNumber() == 27
                        || row.RowNumber() == 33 || row.RowNumber() == 35 || row.RowNumber() == 43
                        || row.RowNumber() == 45 || row.RowNumber() == 55 || row.RowNumber() == 57
                        || row.RowNumber() == 64 || row.RowNumber() == 66 || row.RowNumber() == 74
                        || row.RowNumber() == 76 || row.RowNumber() == 84 || row.RowNumber() == 86
                        || row.RowNumber() == 12 || row.RowNumber() == 19 || row.RowNumber() == 26
                        || row.RowNumber() == 34 || row.RowNumber() == 44 || row.RowNumber() == 56
                        || row.RowNumber() == 65 || row.RowNumber() == 75 || row.RowNumber() == 85
                        || row.RowNumber() == 93)
                        {
                            rowCounter++;
                            continue;
                        }

                        feedback7[rowCounter].DataColumn3 += "\n" + associatedUser + ": " + row.Cell(3).GetString();
                        feedback7[rowCounter].DataColumn4 += "\n" + associatedUser + ": " + row.Cell(4).GetString();
                        feedback7[rowCounter].DataColumn5 += "\n" + associatedUser + ": " + row.Cell(5).GetString();
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
            ws.Cell(1, 1).InsertData(feedback1);
            ws = wb.Worksheets.Add("GOONYELLA");
            ws.Cell(1, 1).InsertData(feedback2);
            ws = wb.Worksheets.Add("BROADMEADOW");
            ws.Cell(1, 1).InsertData(feedback3);
            ws = wb.Worksheets.Add("CAVAL RIDGE");
            ws.Cell(1, 1).InsertData(feedback4);
            ws = wb.Worksheets.Add("PEAK DOWNS");
            ws.Cell(1, 1).InsertData(feedback5);
            ws = wb.Worksheets.Add("SARAJI");
            ws.Cell(1, 1).InsertData(feedback6);
            ws = wb.Worksheets.Add("SARAJI STH");
            ws.Cell(1, 1).InsertData(feedback7);
            // wb.SaveAs("excelFiles/BMA Technology Readiness Survey - Consolidated.xlsx");
            wb.SaveAs("results/BMA_Technology_Readiness_Survey_Consolidated_" + DateTime.Now.ToString("yyyyMMdd_HHmmss") + ".xlsx");
        }
    }
}