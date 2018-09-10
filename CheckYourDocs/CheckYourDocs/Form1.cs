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
            string wordPath = SI.GetFilePath();
            string HtmlContent = File.ReadAllText(SI.ConvertDocToHtml(@wordPath));
            string WordContent = File.ReadAllText(@wordPath);
            htmlTB.Text = HtmlContent;
            wordTB.Text = WordContent;
        }
    }
}
