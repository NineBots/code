using Microsoft.Office.Interop.Excel;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using Excel = Microsoft.Office.Interop.Excel;
namespace Personnel_Accounting
{
    internal class Excel_Helper: IDisposable
    {
        private FileInfo _fileInfo = null;
        private Application _excel = null;
        private Workbook _workbook = null;
        private Excel.Worksheet _worksheet = null;

        public Excel_Helper()
        {

            _excel = new Excel.Application();

        }

        public void Dispose()
        {
            try
            {
                if(_workbook != null)
                {

                    _workbook.Close(false, Type.Missing, Type.Missing);

                    _excel.Workbooks.Close();

                    Marshal.ReleaseComObject(_workbook);

                }
            }catch (Exception ex) { }
            finally
            {
                _excel.Quit();
                GC.Collect();
                Marshal.ReleaseComObject(_excel);
               
            }

        }

        public bool Open(string filePath)
        {
            string newFile = Path.Combine(@"C: \Users\Yakovka\Desktop\Personnel_Accounting\Personnel_Accounting\bin\Debug", "Отчет за " + DateTime.Now.Year.ToString() + ".xlsx");
            try
            {
                if (File.Exists(newFile))
                {
                    _fileInfo = new FileInfo(newFile);
                    _workbook = _excel.Workbooks.Open(newFile);
                }
                else
                {
                    if (File.Exists(filePath))
                    {
                        _fileInfo = new FileInfo(filePath);
                        _workbook = _excel.Workbooks.Open(filePath);
                    }
                    else
                    {
                        _workbook = _excel.Workbooks.Add();
                    }
                }           

                return true;

            }catch (Exception ex) { }
            return false;

        }

        internal bool Set(string column, int row, string data)
        {
            try
            {

                _worksheet = (Excel.Worksheet) _workbook.ActiveSheet;
                _worksheet.Cells[row,column] = data;

                return true;

            }catch(Exception ex) { }
            return false;

        }

        internal void Save()
        {
            try
            {
                string newFile_path = Path.Combine(_fileInfo.DirectoryName, "Отчет за " + DateTime.Now.Year.ToString() + ".xlsx");
                _workbook.SaveAs(newFile_path);

            }
            catch (Exception ex) { }
                
            
        }
    }
}
