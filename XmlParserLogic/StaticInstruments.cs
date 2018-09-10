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

        public static string ConvertDocToHtml(string input_path)
        {
            Microsoft.Office.Interop.Word.Application App = new Microsoft.Office.Interop.Word.Application();
            if (File.Exists(@input_path))
            {
                Regex re = new Regex(".docx?$");
                string save_pass = re.Replace(input_path, ".html");
                Document doc = App.Documents.Open(@input_path);
                doc.SaveAs(@save_pass, WdSaveFormat.wdFormatFilteredHTML);
                doc.Save();
                doc.Close();
                App.Quit();
                return save_pass;
            }
            App.Quit();
            throw new Exception("Wrong file directory");
        }

        public static string GetHtmlBodyContent(string htmlPath)
        {
            if (File.Exists(@htmlPath))
            {
                string HtmlContent = File.ReadAllText(@htmlPath);
                int tmp = HtmlContent.Length;
                int start = HtmlContent.IndexOf("</head>");
                int end = HtmlContent.IndexOf("</body>");
                if (start<0 || end<0)
                {
                    throw new Exception("Got not an HTML file");
                }
                return HtmlContent.Substring(start + 7, end - start);
            }
            throw new Exception("File does not exist");
        }
    }
}
