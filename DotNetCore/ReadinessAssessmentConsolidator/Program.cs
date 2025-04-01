using ClosedXML.Excel;

using ReadinessAssessmentConsolidator.models;

namespace ReadinessAssessmentConsolidator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Starting the Readiness Assessment Consolidator program!!");

            //put file folder name as part of args and then read all excel files inside
            string filePath = "excelFiles/BMA Technology Readiness Survey - Fabian Arenas.xlsx";

            int rowCounter = 1;

            List<ExcelDataModel> feedback = new();

            using (var workbook = new XLWorkbook(filePath)){
                //add worksheet names as an argument also
                var worksheet = workbook.Worksheet("BNE DC");

                //foreach (var row in worksheet.Rows())
                foreach (var row in worksheet.RowsUsed().Skip(4))
                {
                    if (feedback.Count < 89)
                        feedback.Add(new ExcelDataModel()
                            {
                                UserEstimation = filePath.Split(" - ")[1].Replace(".xlsx", string.Empty) + ": " + row.Cell(3).GetString(),
                                UserJustification = filePath.Split(" - ")[1].Replace(".xlsx", string.Empty) + ": " + row.Cell(4).GetString(),
                                UserRecommendation = filePath.Split(" - ")[1].Replace(".xlsx", string.Empty) + ": " + row.Cell(5).GetString()
                            }
                        );
                    else {
                        feedback[rowCounter].UserEstimation += "\n" + filePath.Split(" - ")[1].Replace(".xlsx", string.Empty) + ": " + row.Cell(3).GetString();
                        feedback[rowCounter].UserJustification += "\n" + filePath.Split(" - ")[1].Replace(".xlsx", string.Empty) + ": " + row.Cell(4).GetString();
                        feedback[rowCounter].UserRecommendation += "\n" + filePath.Split(" - ")[1].Replace(".xlsx", string.Empty) + ": " + row.Cell(5).GetString();
                    }

                    rowCounter++;

                    if (rowCounter > 92) //92 is the limit of the info, this can be an arg
                        break;
                }
            }

            filePath = "excelFiles/BMA Technology Readiness Survey - Nathan Young.xlsx";
            rowCounter = 1;

            using (var workbook = new XLWorkbook(filePath)){
                var worksheet = workbook.Worksheet("BNE DC");

                //foreach (var row in worksheet.Rows())
                foreach (var row in worksheet.RowsUsed().Skip(4))
                {
                    if (feedback.Count == 0)
                        feedback.Add(new ExcelDataModel()
                            {
                                UserEstimation = filePath.Split(" - ")[1].Replace(".xlsx", string.Empty) + ": " + row.Cell(3).GetString(),
                                UserJustification = filePath.Split(" - ")[1].Replace(".xlsx", string.Empty) + ": " + row.Cell(4).GetString(),
                                UserRecommendation = filePath.Split(" - ")[1].Replace(".xlsx", string.Empty) + ": " + row.Cell(5).GetString()
                            }
                        );
                    else {
                        feedback[rowCounter - 1].UserEstimation += "\n" + filePath.Split(" - ")[1].Replace(".xlsx", string.Empty) + ": " + row.Cell(3).GetString();
                        feedback[rowCounter - 1].UserJustification += "\n" + filePath.Split(" - ")[1].Replace(".xlsx", string.Empty) + ": " + row.Cell(4).GetString();
                        feedback[rowCounter - 1].UserRecommendation += "\n" + filePath.Split(" - ")[1].Replace(".xlsx", string.Empty) + ": " + row.Cell(5).GetString();
                    }

                    rowCounter++;

                    if (rowCounter > 92) //92 is the limit of the info, this can be an arg
                        break;
                }
            }

            filePath = "excelFiles/BMA Technology Readiness Survey - Michelle Fernando.xlsx";
            rowCounter = 1;

            using (var workbook = new XLWorkbook(filePath)){
                var worksheet = workbook.Worksheet("BNE DC");

                //foreach (var row in worksheet.Rows())
                foreach (var row in worksheet.RowsUsed().Skip(4))
                {
                    if (feedback.Count == 0)
                        feedback.Add(new ExcelDataModel()
                            {
                                UserEstimation = filePath.Split(" - ")[1].Replace(".xlsx", string.Empty) + ": " + row.Cell(3).GetString(),
                                UserJustification = filePath.Split(" - ")[1].Replace(".xlsx", string.Empty) + ": " + row.Cell(4).GetString(),
                                UserRecommendation = filePath.Split(" - ")[1].Replace(".xlsx", string.Empty) + ": " + row.Cell(5).GetString()
                            }
                        );
                    else {
                        feedback[rowCounter - 1].UserEstimation += "\n" + filePath.Split(" - ")[1].Replace(".xlsx", string.Empty) + ": " + row.Cell(3).GetString();
                        feedback[rowCounter - 1].UserJustification += "\n" + filePath.Split(" - ")[1].Replace(".xlsx", string.Empty) + ": " + row.Cell(4).GetString();
                        feedback[rowCounter - 1].UserRecommendation += "\n" + filePath.Split(" - ")[1].Replace(".xlsx", string.Empty) + ": " + row.Cell(5).GetString();
                    }

                    rowCounter++;

                    if (rowCounter > 92) //92 is the limit of the info, this can be an arg
                        break;
                }
            }

            filePath = "excelFiles/BMA Technology Readiness Survey - Eddie Pearson.xlsx";
            rowCounter = 1;

            using (var workbook = new XLWorkbook(filePath)){
                var worksheet = workbook.Worksheet("BNE DC");

                //foreach (var row in worksheet.Rows())
                foreach (var row in worksheet.RowsUsed().Skip(4))
                {
                    if (feedback.Count == 0)
                        feedback.Add(new ExcelDataModel()
                            {
                                UserEstimation = filePath.Split(" - ")[1].Replace(".xlsx", string.Empty) + ": " + row.Cell(3).GetString(),
                                UserJustification = filePath.Split(" - ")[1].Replace(".xlsx", string.Empty) + ": " + row.Cell(4).GetString(),
                                UserRecommendation = filePath.Split(" - ")[1].Replace(".xlsx", string.Empty) + ": " + row.Cell(5).GetString()
                            }
                        );
                    else {
                        feedback[rowCounter - 1].UserEstimation += "\n" + filePath.Split(" - ")[1].Replace(".xlsx", string.Empty) + ": " + row.Cell(3).GetString();
                        feedback[rowCounter - 1].UserJustification += "\n" + filePath.Split(" - ")[1].Replace(".xlsx", string.Empty) + ": " + row.Cell(4).GetString();
                        feedback[rowCounter - 1].UserRecommendation += "\n" + filePath.Split(" - ")[1].Replace(".xlsx", string.Empty) + ": " + row.Cell(5).GetString();
                    }

                    rowCounter++;

                    if (rowCounter > 92) //92 is the limit of the info, this can be an arg
                        break;
                }
            }

            filePath = "excelFiles/BMA Technology Readiness Survey - Chris Groves.xlsx";
            rowCounter = 1;

            using (var workbook = new XLWorkbook(filePath)){
                var worksheet = workbook.Worksheet("BNE DC");

                //foreach (var row in worksheet.Rows())
                foreach (var row in worksheet.RowsUsed().Skip(4))
                {
                    if (feedback.Count == 0)
                        feedback.Add(new ExcelDataModel()
                            {
                                UserEstimation = filePath.Split(" - ")[1].Replace(".xlsx", string.Empty) + ": " + row.Cell(3).GetString(),
                                UserJustification = filePath.Split(" - ")[1].Replace(".xlsx", string.Empty) + ": " + row.Cell(4).GetString(),
                                UserRecommendation = filePath.Split(" - ")[1].Replace(".xlsx", string.Empty) + ": " + row.Cell(5).GetString()
                            }
                        );
                    else {
                        feedback[rowCounter - 1].UserEstimation += "\n" + filePath.Split(" - ")[1].Replace(".xlsx", string.Empty) + ": " + row.Cell(3).GetString();
                        feedback[rowCounter - 1].UserJustification += "\n" + filePath.Split(" - ")[1].Replace(".xlsx", string.Empty) + ": " + row.Cell(4).GetString();
                        feedback[rowCounter - 1].UserRecommendation += "\n" + filePath.Split(" - ")[1].Replace(".xlsx", string.Empty) + ": " + row.Cell(5).GetString();
                    }

                    rowCounter++;

                    if (rowCounter > 92) //92 is the limit of the info, this can be an arg
                        break;
                }
            }

            //feedback.ForEach(i => Console.Write("{0}\n", i));

            var wb = new XLWorkbook();
            var ws = wb.Worksheets.Add("BNE DC");
            ws.Cell(5, 3).InsertData(feedback);
            // wb.SaveAs("excelFiles/BMA Technology Readiness Survey - Consolidated.xlsx");
            wb.SaveAs("excelFiles/BMA_Technology_Readiness_Survey_Consolidated.xlsx");

            Console.WriteLine("Ending the Readiness Assessment Consolidator program!!");
        }
    }
}