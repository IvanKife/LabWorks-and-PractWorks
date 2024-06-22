using System.Runtime.InteropServices;
using Excel = Microsoft.Office.Interop.Excel;

var excelApp = new Excel.Application();
excelApp.Visible = true;

object template = Path.Combine(Environment.CurrentDirectory, "template.xlsx");
var workbook = excelApp.Workbooks.Add(template);

var worksheet1 = workbook.Worksheets[1];
var worksheet2 = workbook.Worksheets[2];

Console.WriteLine("Введите каталог: ");
var path = Console.ReadLine();
DirectoryInfo directory = new(path);

excelApp.Quit();
if (workbook != null)
    Marshal.ReleaseComObject(workbook);
if (excelApp != null)
    Marshal.ReleaseComObject(excelApp);
workbook = null;
excelApp = null;
GC.Collect();