using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XmlParserLogic
{
    class TextNode
    {
        public TextNode(string content)
        {
            this.Content = content;
        }
        public string Content { get; }
        public double FontSize { get; set; }
        public string FontFamily { get; set; }
        public int LineHeight { get; set; }
        public double TextIndent { get; set; }
        public string TextAlign { get; set; }
        public string ItalicBoldUnderlinedStrikethrough { get; set; }
        public string SupSub { get; set; }
        public string Color { get; set; }
        public string Background { get; set; }
    }
}
