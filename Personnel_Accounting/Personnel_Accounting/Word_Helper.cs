using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Word = Microsoft.Office.Interop.Word;
using System.Reflection;
using System.IO;
using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace Personnel_Accounting
{
    internal class Word_Helper
    {

        public static FileInfo _fileInfo;
        public Word_Helper(string filename)
        {
            if (File.Exists(filename))
            {
                _fileInfo = new FileInfo(filename);
            }
            else
            {
                throw new ArgumentException("File Not Found");
            }
        } 

        // поиск и замена
        public void FindReplace(Dictionary <string,string> dict, DataGridViewRow dataGridViewRow)
        {
            Word.Application app = null; 
            try
            {
                app = new Word.Application();
                Object file = _fileInfo.FullName;

                Object missing = Type.Missing;

                app.Documents.Open(file);

                foreach(var item in dict)
                {
                    Word.Find find = app.Selection.Find;
                    find.Text = item.Key;
                    find.Replacement.Text = item.Value;

                    Object wrap = Word.WdFindWrap.wdFindContinue;
                    Object replace = Word.WdReplace.wdReplaceAll;

                    find.Execute(FindText: Type.Missing, MatchCase: false, MatchWholeWord: false, MatchWildcards: false,
                            MatchSoundsLike: missing, MatchAllWordForms: false, Forward: true, Wrap: Word.WdFindWrap.wdFindContinue,
                            Format: false, ReplaceWith: missing, Replace: Word.WdReplace.wdReplaceAll);
                    Marshal.ReleaseComObject(find);

                }

                Object filename = Path.Combine(_fileInfo.DirectoryName, "Shablons", "Приказ №" + dataGridViewRow.Cells[0].Value.ToString() + ".doc");

                app.ActiveDocument.SaveAs2(filename);

                app.ActiveDocument.Close(); app.Quit();

                Marshal.ReleaseComObject(app);
            }catch {  }
            finally {   Marshal.ReleaseComObject(app); _fileInfo = null; }
            
            
        }




    }
}
