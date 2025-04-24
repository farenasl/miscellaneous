using ClosedXML.Excel;

namespace ReadinessAssessmentConsolidator.helpers
{
    class ExcelStylistHelper
    {
        public static void AddStyle(IXLWorksheet worksheet)
        {
            Console.WriteLine("Adding Styling to " + worksheet.Name + " excel sheet.");

            SettingGlobalWorksheetStyle(worksheet);
            worksheet.Range("A1:E3").Style.Font.Bold = true;
            worksheet.Column(1).Style.Font.Bold = true;
            BoldingDescriptiveTitleCells(worksheet, [12, 19, 26, 34, 44, 56, 65, 75, 85]);
            SettingRowsBackgroundColor(worksheet, ["1"], XLColor.HunterGreen);
            SettingRowsBackgroundColor(worksheet, "2", "A", "B", XLColor.LightGreen);
            SettingRowsBackgroundColor(worksheet, "2", "C", "C", XLColor.LightBlue);
            SettingRowsBackgroundColor(worksheet, "2", "D", "E", XLColor.Blue);
            worksheet.Range("C2:E2").Style.Font.FontColor = XLColor.White;
            SettingRowsBackgroundColor(worksheet, ["3", "12", "19", "26", "34", "44", "56", "65", "75", "85"], XLColor.LightGray);
            SettingRowsBackgroundColor(worksheet, ["11", "18", "25", "33", "43", "55", "64", "74", "84", "93"], XLColor.Black);
            HiddingRows(worksheet, [4, 13, 20, 27, 35, 45, 57, 66, 76, 86]);
            WrappingColumnsToContent(worksheet, [2, 3, 4, 5]);
            SettingColumnsWidthSize(worksheet, [2], 70);
            MergingDescriptiveTitleRows(worksheet, ["3", "12", "19", "26", "34", "44", "56", "65", "75", "85"]);
            SettingHeaderRowStyle(worksheet);
            AdjustColumnsToContent(worksheet, [1, 3]);

            Console.WriteLine("Style added successfully to excel sheet " + worksheet.Name + ".");
        }

        private static void BoldingDescriptiveTitleCells(IXLWorksheet worksheet, int[] rows)
        {
            foreach (int row in rows)
                worksheet.Cell(row, 2).Style.Font.Bold = true;
        }

        private static void SettingRowsBackgroundColor(IXLWorksheet worksheet, string row, string startCol, string endCol, XLColor color)
        {
            worksheet.Range(startCol + row + ":"+ endCol + row).Style.Fill.BackgroundColor = color;
        }

        private static void SettingRowsBackgroundColor(IXLWorksheet worksheet, string[] rows, XLColor color)
        {
            foreach (string row in rows)
                worksheet.Range("A" + row + ":E" + row).Style.Fill.BackgroundColor = color;
        }

        private static void HiddingRows(IXLWorksheet worksheet, int[] rows)
        {
            foreach (int row in rows)
                worksheet.Row(row).Hide();
        }

        private static void WrappingColumnsToContent(IXLWorksheet worksheet, int[] columns)
        {
            foreach (int column in columns)
                worksheet.Column(column).Style.Alignment.WrapText = true;
        }

        private static void MergingDescriptiveTitleRows(IXLWorksheet worksheet, string[] rows)
        {
            foreach (string row in rows)
                worksheet.Range("B" + row + ":E" + row).Merge();
        }

        private static void SettingGlobalWorksheetStyle(IXLWorksheet worksheet)
        {
            worksheet.Style.Font.FontName = "Arial";
            worksheet.Style.Font.FontSize = 10;
            worksheet.SheetView.ZoomScale = 60;
            SettingColumnsVerticalAlignment(worksheet, [1, 2], XLAlignmentVerticalValues.Center);
            SettingColumnsWidthSize(worksheet, [3], 30);
            SettingColumnsWidthSize(worksheet, [4, 5], 100);
            SettingColumnsVerticalAlignment(worksheet, [3, 4, 5], XLAlignmentVerticalValues.Top);
        }

        private static void SettingHeaderRowStyle(IXLWorksheet worksheet)
        {
            worksheet.Row(1).Style.Font.FontColor = XLColor.White;
            worksheet.Row(1).Style.Font.FontSize = 20;
            worksheet.Row(1).Style.Font.Bold = true;
        }

        private static void SettingColumnsWidthSize(IXLWorksheet worksheet, int[] columns, int size)
        {
            foreach (int column in columns)
                worksheet.Column(column).Width = size;
        }

        private static void SettingColumnsVerticalAlignment(IXLWorksheet worksheet, int[] columns, XLAlignmentVerticalValues alignment)
        {
            foreach (int column in columns)
                worksheet.Column(column).Style.Alignment.Vertical = alignment;
        }

        private static void AdjustColumnsToContent(IXLWorksheet worksheet, int[] columns)
        {
            foreach (int column in columns)
                worksheet.Column(column).AdjustToContents();
        }
    }
}