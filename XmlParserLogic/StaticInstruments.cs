using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Office.Interop.Word;
using System.IO;
using System.Text.RegularExpressions;


namespace XmlParserLogic
{
    public static class StaticInstruments
    {
        public static string GetFilePath()
        {
            OpenFileDialog OFD = new OpenFileDialog();
            if (OFD.ShowDialog() == DialogResult.OK)
            {
                return OFD.FileName;
            }
            throw new Exception("No file chosen");
        }

        public static string ConvertDocToXml(string input_path)
    {      
            Microsoft.Office.Interop.Word.Application App = new Microsoft.Office.Interop.Word.Application();
            if (File.Exists(@input_path))
            {
                Regex re = new Regex(".docx?$");
                string save_pass = String.Concat("E:/", re.Replace(input_path.Remove(0,input_path.LastIndexOf("\\")+1), ".xml"));
                Document doc = App.Documents.Open(@input_path);
                doc.SaveAs(@save_pass,WdSaveFormat.wdFormatXML);
                doc.Save();
                doc.Close();
                App.Quit();
                return save_pass;
            }
            App.Quit();
            throw new Exception("Wrong file directory");
        }
    }
}
