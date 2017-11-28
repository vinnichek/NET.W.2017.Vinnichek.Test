using System;
namespace Task5.Solution
{
    public class HtmlConverter : IConverter
    {
        public string Convert(DocumentPart part)
        {
            if (part.GetType() == typeof(BoldText))
            {
                var text = (BoldText)part;
                return "<b>" + text.Text + "</b>";
            }

            if (part.GetType() == typeof(Hyperlink))
            {
                var text = (Hyperlink)part;
                return "<a href=\"" + text.Url + "\">" + text.Text + "</a>";
            }

            if (part.GetType() == typeof(PlainText))
            {
                var text = (PlainText)part;
                return "\\textbf{" + text.Text + "}";
            }
        }
    }
}
