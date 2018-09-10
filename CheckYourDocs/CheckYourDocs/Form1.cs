using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using XmlParserLogic;
using System.IO;
using System.Text.RegularExpressions;
using System.Windows.Forms.VisualStyles;
using SI = XmlParserLogic.StaticInstruments;

namespace CheckYourDocs
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void startBT_Click_1(object sender, EventArgs e)
        {
            Regex re = new Regex("<body>*</body>");
            string wordPath = SI.GetFilePath();
            string HtmlBodyContent = SI.GetHtmlBodyContent(SI.ConvertDocToHtml(@wordPath));
            string WordContent = File.ReadAllText(@wordPath);
            htmlTB.Text = HtmlBodyContent;
            wordTB.Text = WordContent;
        }
    }
}
