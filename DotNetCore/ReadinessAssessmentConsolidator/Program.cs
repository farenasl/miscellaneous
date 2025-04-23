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
            Console.WriteLine("Press any key to close the program...");
            Console.ReadKey();
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
                                DataColumn3 = (row.Cell(3).GetString() != String.Empty ? associatedUser + ": " + row.Cell(3).GetString() : String.Empty),
                                DataColumn4 = (row.Cell(4).GetString() != String.Empty ? associatedUser + ": " + row.Cell(4).GetString() : String.Empty),
                                DataColumn5 = (row.Cell(5).GetString() != String.Empty ? associatedUser + ": " + row.Cell(5).GetString() : String.Empty)
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
                                DataColumn3 = (row.Cell(3).GetString() != String.Empty ? associatedUser + ": " + row.Cell(3).GetString() : String.Empty),
                                DataColumn4 = (row.Cell(4).GetString() != String.Empty ? associatedUser + ": " + row.Cell(4).GetString() : String.Empty),
                                DataColumn5 = (row.Cell(5).GetString() != String.Empty ? associatedUser + ": " + row.Cell(5).GetString() : String.Empty)
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
                                DataColumn3 = (row.Cell(3).GetString() != String.Empty ? associatedUser + ": " + row.Cell(3).GetString() : String.Empty),
                                DataColumn4 = (row.Cell(4).GetString() != String.Empty ? associatedUser + ": " + row.Cell(4).GetString() : String.Empty),
                                DataColumn5 = (row.Cell(5).GetString() != String.Empty ? associatedUser + ": " + row.Cell(5).GetString() : String.Empty)
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
                                DataColumn3 = (row.Cell(3).GetString() != String.Empty ? associatedUser + ": " + row.Cell(3).GetString() : String.Empty),
                                DataColumn4 = (row.Cell(4).GetString() != String.Empty ? associatedUser + ": " + row.Cell(4).GetString() : String.Empty),
                                DataColumn5 = (row.Cell(5).GetString() != String.Empty ? associatedUser + ": " + row.Cell(5).GetString() : String.Empty)
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
                                DataColumn3 = (row.Cell(3).GetString() != String.Empty ? associatedUser + ": " + row.Cell(3).GetString() : String.Empty),
                                DataColumn4 = (row.Cell(4).GetString() != String.Empty ? associatedUser + ": " + row.Cell(4).GetString() : String.Empty),
                                DataColumn5 = (row.Cell(5).GetString() != String.Empty ? associatedUser + ": " + row.Cell(5).GetString() : String.Empty)
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
                                DataColumn3 = (row.Cell(3).GetString() != String.Empty ? associatedUser + ": " + row.Cell(3).GetString() : String.Empty),
                                DataColumn4 = (row.Cell(4).GetString() != String.Empty ? associatedUser + ": " + row.Cell(4).GetString() : String.Empty),
                                DataColumn5 = (row.Cell(5).GetString() != String.Empty ? associatedUser + ": " + row.Cell(5).GetString() : String.Empty)
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
                                DataColumn3 = (row.Cell(3).GetString() != String.Empty ? associatedUser + ": " + row.Cell(3).GetString() : String.Empty),
                                DataColumn4 = (row.Cell(4).GetString() != String.Empty ? associatedUser + ": " + row.Cell(4).GetString() : String.Empty),
                                DataColumn5 = (row.Cell(5).GetString() != String.Empty ? associatedUser + ": " + row.Cell(5).GetString() : String.Empty)
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

                        feedback1[rowCounter].DataColumn3 += (row.Cell(3).GetString() != String.Empty ? associatedUser + ": " + row.Cell(3).GetString() + "\n" : String.Empty);
                        feedback1[rowCounter].DataColumn4 += (row.Cell(4).GetString() != String.Empty ? associatedUser + ": " + row.Cell(4).GetString() + "\n" : String.Empty);
                        feedback1[rowCounter].DataColumn5 += (row.Cell(5).GetString() != String.Empty ? associatedUser + ": " + row.Cell(5).GetString() + "\n" : String.Empty);
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

                        feedback2[rowCounter].DataColumn3 += (row.Cell(3).GetString() != String.Empty ? associatedUser + ": " + row.Cell(3).GetString() + "\n" : String.Empty);
                        feedback2[rowCounter].DataColumn4 += (row.Cell(4).GetString() != String.Empty ? associatedUser + ": " + row.Cell(4).GetString() + "\n" : String.Empty);
                        feedback2[rowCounter].DataColumn5 += (row.Cell(5).GetString() != String.Empty ? associatedUser + ": " + row.Cell(5).GetString() + "\n" : String.Empty);
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

                        feedback3[rowCounter].DataColumn3 += (row.Cell(3).GetString() != String.Empty ? associatedUser + ": " + row.Cell(3).GetString() + "\n" : String.Empty);
                        feedback3[rowCounter].DataColumn4 += (row.Cell(4).GetString() != String.Empty ? associatedUser + ": " + row.Cell(4).GetString() + "\n" : String.Empty);
                        feedback3[rowCounter].DataColumn5 += (row.Cell(5).GetString() != String.Empty ? associatedUser + ": " + row.Cell(5).GetString() + "\n" : String.Empty);
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

                        feedback4[rowCounter].DataColumn3 += (row.Cell(3).GetString() != String.Empty ? associatedUser + ": " + row.Cell(3).GetString() + "\n" : String.Empty);
                        feedback4[rowCounter].DataColumn4 += (row.Cell(4).GetString() != String.Empty ? associatedUser + ": " + row.Cell(4).GetString() + "\n" : String.Empty);
                        feedback4[rowCounter].DataColumn5 += (row.Cell(5).GetString() != String.Empty ? associatedUser + ": " + row.Cell(5).GetString() + "\n" : String.Empty);
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

                        feedback5[rowCounter].DataColumn3 += (row.Cell(3).GetString() != String.Empty ? associatedUser + ": " + row.Cell(3).GetString() + "\n" : String.Empty);
                        feedback5[rowCounter].DataColumn4 += (row.Cell(4).GetString() != String.Empty ? associatedUser + ": " + row.Cell(4).GetString() + "\n" : String.Empty);
                        feedback5[rowCounter].DataColumn5 += (row.Cell(5).GetString() != String.Empty ? associatedUser + ": " + row.Cell(5).GetString() + "\n" : String.Empty);
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

                        feedback6[rowCounter].DataColumn3 += (row.Cell(3).GetString() != String.Empty ? associatedUser + ": " + row.Cell(3).GetString() + "\n" : String.Empty);
                        feedback6[rowCounter].DataColumn4 += (row.Cell(4).GetString() != String.Empty ? associatedUser + ": " + row.Cell(4).GetString() + "\n" : String.Empty);
                        feedback6[rowCounter].DataColumn5 += (row.Cell(5).GetString() != String.Empty ? associatedUser + ": " + row.Cell(5).GetString() + "\n" : String.Empty);
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

                        feedback7[rowCounter].DataColumn3 += (row.Cell(3).GetString() != String.Empty ? associatedUser + ": " + row.Cell(3).GetString() + "\n" : String.Empty);
                        feedback7[rowCounter].DataColumn4 += (row.Cell(4).GetString() != String.Empty ? associatedUser + ": " + row.Cell(4).GetString() + "\n" : String.Empty);
                        feedback7[rowCounter].DataColumn5 += (row.Cell(5).GetString() != String.Empty ? associatedUser + ": " + row.Cell(5).GetString() + "\n" : String.Empty);
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
            AddStyle(ws);
            ws = wb.Worksheets.Add("GOONYELLA");
            ws.Cell(1, 1).InsertData(feedback2);
            AddStyle(ws);
            ws = wb.Worksheets.Add("BROADMEADOW");
            ws.Cell(1, 1).InsertData(feedback3);
            AddStyle(ws);
            ws = wb.Worksheets.Add("CAVAL RIDGE");
            ws.Cell(1, 1).InsertData(feedback4);
            AddStyle(ws);
            ws = wb.Worksheets.Add("PEAK DOWNS");
            ws.Cell(1, 1).InsertData(feedback5);
            AddStyle(ws);
            ws = wb.Worksheets.Add("SARAJI");
            ws.Cell(1, 1).InsertData(feedback6);
            AddStyle(ws);
            ws = wb.Worksheets.Add("SARAJI STH");
            ws.Cell(1, 1).InsertData(feedback7);
            AddStyle(ws);
            
            String dateTime = DateTime.Now.ToString("yyyyMMdd_HHmmss");
            wb.SaveAs("results/BMA_Technology_Readiness_Survey_Consolidated_" + dateTime + ".xlsx");

            Console.WriteLine("File BMA_Technology_Readiness_Survey_Consolidated_" + dateTime + ".xlsx generated successfully!");
        }

        private static void AddStyle(IXLWorksheet worksheet)
        {
            Console.WriteLine("Adding Styling to " + worksheet.Name + " excel sheet.");

            // General
            worksheet.Style.Font.FontName = "Arial";
            worksheet.Style.Font.FontSize = 10;
            worksheet.SheetView.ZoomScale = 60;
            worksheet.Column(1).Style.Alignment.Vertical = XLAlignmentVerticalValues.Center;
            worksheet.Column(2).Style.Alignment.Vertical = XLAlignmentVerticalValues.Center;
            worksheet.Column(3).Width = 30;
            worksheet.Column(4).Width = 100;
            worksheet.Column(5).Width = 100;
            worksheet.Column(3).Style.Alignment.Vertical = XLAlignmentVerticalValues.Top;
            worksheet.Column(4).Style.Alignment.Vertical = XLAlignmentVerticalValues.Top;
            worksheet.Column(5).Style.Alignment.Vertical = XLAlignmentVerticalValues.Top;

            // Bolding
            worksheet.Range("A1:E3").Style.Font.Bold = true;
            worksheet.Column(1).Style.Font.Bold = true;
            worksheet.Cell(12, 2).Style.Font.Bold = true;
            worksheet.Cell(19, 2).Style.Font.Bold = true;
            worksheet.Cell(26, 2).Style.Font.Bold = true;
            worksheet.Cell(34, 2).Style.Font.Bold = true;
            worksheet.Cell(44, 2).Style.Font.Bold = true;
            worksheet.Cell(56, 2).Style.Font.Bold = true;
            worksheet.Cell(65, 2).Style.Font.Bold = true;
            worksheet.Cell(75, 2).Style.Font.Bold = true;
            worksheet.Cell(85, 2).Style.Font.Bold = true;
            
            // Setting colors
            worksheet.Range("A1:E1").Style.Fill.BackgroundColor = XLColor.HunterGreen;
            worksheet.Range("A2:B2").Style.Fill.BackgroundColor = XLColor.LightGreen;
            worksheet.Cell(2, 3).Style.Fill.BackgroundColor = XLColor.LightBlue;
            worksheet.Range("D2:E2").Style.Fill.BackgroundColor = XLColor.Blue;
            worksheet.Range("C2:E2").Style.Font.FontColor = XLColor.White;

            // Gray rows
            worksheet.Range("A3:E3").Style.Fill.BackgroundColor = XLColor.LightGray;
            worksheet.Range("A12:E12").Style.Fill.BackgroundColor = XLColor.LightGray;
            worksheet.Range("A19:E19").Style.Fill.BackgroundColor = XLColor.LightGray;
            worksheet.Range("A26:E26").Style.Fill.BackgroundColor = XLColor.LightGray;
            worksheet.Range("A34:E34").Style.Fill.BackgroundColor = XLColor.LightGray;
            worksheet.Range("A44:E44").Style.Fill.BackgroundColor = XLColor.LightGray;
            worksheet.Range("A56:E56").Style.Fill.BackgroundColor = XLColor.LightGray;
            worksheet.Range("A65:E65").Style.Fill.BackgroundColor = XLColor.LightGray;
            worksheet.Range("A75:E75").Style.Fill.BackgroundColor = XLColor.LightGray;
            worksheet.Range("A85:E85").Style.Fill.BackgroundColor = XLColor.LightGray;

            // Black rows
            worksheet.Range("A11:E11").Style.Fill.BackgroundColor = XLColor.Black;
            worksheet.Range("A18:E18").Style.Fill.BackgroundColor = XLColor.Black;
            worksheet.Range("A25:E25").Style.Fill.BackgroundColor = XLColor.Black;
            worksheet.Range("A33:E33").Style.Fill.BackgroundColor = XLColor.Black;
            worksheet.Range("A43:E43").Style.Fill.BackgroundColor = XLColor.Black;
            worksheet.Range("A55:E55").Style.Fill.BackgroundColor = XLColor.Black;
            worksheet.Range("A64:E64").Style.Fill.BackgroundColor = XLColor.Black;
            worksheet.Range("A74:E74").Style.Fill.BackgroundColor = XLColor.Black;
            worksheet.Range("A84:E84").Style.Fill.BackgroundColor = XLColor.Black;
            worksheet.Range("A93:E93").Style.Fill.BackgroundColor = XLColor.Black;

            // Hidden rows
            worksheet.Row(4).Hide();
            worksheet.Row(13).Hide();
            worksheet.Row(20).Hide();
            worksheet.Row(27).Hide();
            worksheet.Row(35).Hide();
            worksheet.Row(45).Hide();
            worksheet.Row(57).Hide();
            worksheet.Row(66).Hide();
            worksheet.Row(76).Hide();
            worksheet.Row(86).Hide();

            // Wrapped questions
            worksheet.Column(2).Style.Alignment.WrapText = true;
            worksheet.Column(3).Style.Alignment.WrapText = true;
            worksheet.Column(4).Style.Alignment.WrapText = true;
            worksheet.Column(5).Style.Alignment.WrapText = true;
            worksheet.Column(2).Width = 70;

            // Merging content
            worksheet.Range("B3:E3").Merge();
            worksheet.Range("B12:E12").Merge();
            worksheet.Range("B19:E19").Merge();
            worksheet.Range("B26:E26").Merge();
            worksheet.Range("B34:E34").Merge();
            worksheet.Range("B44:E44").Merge();
            worksheet.Range("B56:E56").Merge();
            worksheet.Range("B65:E65").Merge();
            worksheet.Range("B75:E75").Merge();
            worksheet.Range("B85:E85").Merge();

            // Header Row
            var row = worksheet.Row(1);
            row.Style.Font.FontColor = XLColor.White;
            row.Style.Font.FontSize = 20;
            row.Style.Font.Bold = true;

            worksheet.Column(1).AdjustToContents();
            worksheet.Column(3).AdjustToContents();
        }
    }
}