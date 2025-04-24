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

        private static void Main(string[] args)
        {
            Console.WriteLine("Starting the Readiness Assessment Consolidator program!!");
            Console.WriteLine("Reading all excels inside of excelFiles folder");
            Console.WriteLine("Only files with the extension XLSX will be considered");

            string[] files = Directory.GetFiles("excelFiles/", "*.xlsx");

            Console.WriteLine("We have found " + files.Length + " Excel files to process");

            if (files.Length != 0)
            {
                Array.ForEach(files, ProcessExcel);
                SavingConsolidatedExcel();
            }            

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
                        if (ValidationHelper.ExistInArray([11, 13, 18, 20, 25, 27, 33, 35, 43, 45,
                         55, 57, 64, 66, 74, 76, 84, 86, 93], row.RowNumber()))
                            feedback1.Add(new ExcelDataModel());
                        else if (ValidationHelper.ExistInArray([12, 19, 26, 34, 44, 56, 65, 75, 85], row.RowNumber()))
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
                        if (ValidationHelper.ExistInArray([11, 13, 18, 20, 25, 27, 33, 35, 43, 45,
                         55, 57, 64, 66, 74, 76, 84, 86, 93], row.RowNumber()))
                            feedback2.Add(new ExcelDataModel());
                        else if (ValidationHelper.ExistInArray([12, 19, 26, 34, 44, 56, 65, 75, 85], row.RowNumber()))
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
                        if (ValidationHelper.ExistInArray([11, 13, 18, 20, 25, 27, 33, 35, 43, 45,
                         55, 57, 64, 66, 74, 76, 84, 86, 93], row.RowNumber()))
                            feedback3.Add(new ExcelDataModel());
                        else if (ValidationHelper.ExistInArray([12, 19, 26, 34, 44, 56, 65, 75, 85], row.RowNumber()))
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
                        if (ValidationHelper.ExistInArray([11, 13, 18, 20, 25, 27, 33, 35, 43, 45,
                         55, 57, 64, 66, 74, 76, 84, 86, 93], row.RowNumber()))
                            feedback4.Add(new ExcelDataModel());
                        else if (ValidationHelper.ExistInArray([12, 19, 26, 34, 44, 56, 65, 75, 85], row.RowNumber()))
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
                        if (ValidationHelper.ExistInArray([11, 13, 18, 20, 25, 27, 33, 35, 43, 45,
                         55, 57, 64, 66, 74, 76, 84, 86, 93], row.RowNumber()))
                            feedback5.Add(new ExcelDataModel());
                        else if (ValidationHelper.ExistInArray([12, 19, 26, 34, 44, 56, 65, 75, 85], row.RowNumber()))
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
                        if (ValidationHelper.ExistInArray([11, 13, 18, 20, 25, 27, 33, 35, 43, 45,
                         55, 57, 64, 66, 74, 76, 84, 86, 93], row.RowNumber()))
                            feedback6.Add(new ExcelDataModel());
                        else if (ValidationHelper.ExistInArray([12, 19, 26, 34, 44, 56, 65, 75, 85], row.RowNumber()))
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
                        if (ValidationHelper.ExistInArray([11, 13, 18, 20, 25, 27, 33, 35, 43, 45,
                         55, 57, 64, 66, 74, 76, 84, 86, 93], row.RowNumber()))
                            feedback7.Add(new ExcelDataModel());
                        else if (ValidationHelper.ExistInArray([12, 19, 26, 34, 44, 56, 65, 75, 85], row.RowNumber()))
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
                        if (rowCounter == 93 
                        || ValidationHelper.ExistInArray([11, 12, 13, 18, 19, 20, 25, 26, 27, 33, 34, 35, 43, 44,
                         45, 55, 56, 57, 64, 65, 66, 74, 75, 76, 84, 85, 86, 93], row.RowNumber()))
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
                        if (rowCounter == 93 
                        || ValidationHelper.ExistInArray([11, 12, 13, 18, 19, 20, 25, 26, 27, 33, 34, 35, 43, 44,
                         45, 55, 56, 57, 64, 65, 66, 74, 75, 76, 84, 85, 86, 93], row.RowNumber()))
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
                        if (rowCounter == 93 
                        || ValidationHelper.ExistInArray([11, 12, 13, 18, 19, 20, 25, 26, 27, 33, 34, 35, 43, 44,
                         45, 55, 56, 57, 64, 65, 66, 74, 75, 76, 84, 85, 86, 93], row.RowNumber()))
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
                        if (rowCounter == 93 
                        || ValidationHelper.ExistInArray([11, 12, 13, 18, 19, 20, 25, 26, 27, 33, 34, 35, 43, 44,
                         45, 55, 56, 57, 64, 65, 66, 74, 75, 76, 84, 85, 86, 93], row.RowNumber()))
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
                        if (rowCounter == 93 
                        || ValidationHelper.ExistInArray([11, 12, 13, 18, 19, 20, 25, 26, 27, 33, 34, 35, 43, 44,
                         45, 55, 56, 57, 64, 65, 66, 74, 75, 76, 84, 85, 86, 93], row.RowNumber()))
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
                        if (rowCounter == 93 
                        || ValidationHelper.ExistInArray([11, 12, 13, 18, 19, 20, 25, 26, 27, 33, 34, 35, 43, 44,
                         45, 55, 56, 57, 64, 65, 66, 74, 75, 76, 84, 85, 86, 93], row.RowNumber()))
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
                        if (rowCounter == 93 
                        || ValidationHelper.ExistInArray([11, 12, 13, 18, 19, 20, 25, 26, 27, 33, 34, 35, 43, 44,
                         45, 55, 56, 57, 64, 65, 66, 74, 75, 76, 84, 85, 86, 93], row.RowNumber())) 
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
            ExcelStylistHelper.AddStyle(ws);
            ws = wb.Worksheets.Add("GOONYELLA");
            ws.Cell(1, 1).InsertData(feedback2);
            ExcelStylistHelper.AddStyle(ws);
            ws = wb.Worksheets.Add("BROADMEADOW");
            ws.Cell(1, 1).InsertData(feedback3);
            ExcelStylistHelper.AddStyle(ws);
            ws = wb.Worksheets.Add("CAVAL RIDGE");
            ws.Cell(1, 1).InsertData(feedback4);
            ExcelStylistHelper.AddStyle(ws);
            ws = wb.Worksheets.Add("PEAK DOWNS");
            ws.Cell(1, 1).InsertData(feedback5);
            ExcelStylistHelper.AddStyle(ws);
            ws = wb.Worksheets.Add("SARAJI");
            ws.Cell(1, 1).InsertData(feedback6);
            ExcelStylistHelper.AddStyle(ws);
            ws = wb.Worksheets.Add("SARAJI STH");
            ws.Cell(1, 1).InsertData(feedback7);
            ExcelStylistHelper.AddStyle(ws);
            
            String dateTime = DateTime.Now.ToString("yyyyMMdd_HHmmss");
            wb.SaveAs("results/BMA_Technology_Readiness_Survey_Consolidated_" + dateTime + ".xlsx");

            Console.WriteLine("File BMA_Technology_Readiness_Survey_Consolidated_" + dateTime + ".xlsx generated successfully!");
        }

        
    }
}