// using System;
// using System.IO;
// using Excel = Microsoft.Office.Interop.Excel;

// namespace Test
// {
//     class ExcelTest
//     {
//         public void TestMethod()
//         {
//             String outputPath = "C:\\Test.xlsx";

//             Excel.Application excel = new Excel.Application();
//             Excel.Workbook workbook = excel.Workbooks.Add(Type.Missing);
//             Excel.Worksheet sheet = (Excel.Worksheet)workbook.ActiveSheet;

//             ((Excel.Range)sheet.Cells[1,1]).Value = "Hello";

//             workbook.SaveAs(outputPath);
//             workbook.Close();
//             excel.Quit();
//         }
//     }
// }