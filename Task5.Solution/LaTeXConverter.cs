using System;
namespace Task5.Solution
{
    public class LaTeXConverter : IConverter
    {
        public string Convert(DocumentPart part)
        {
            if (part.GetType() == typeof(BoldText))
            {
                var text = (BoldText)part;
                return "\\textbf{" + text.Text + "}";
            }

            if (part.GetType() == typeof(Hyperlink))
            {
                var text = (Hyperlink)part;
                return "\\href{" + text.Url + "}{" + text.Text + "}";
            }

            if (part.GetType() == typeof(PlainText))
            {
                var text = (PlainText)part;
                return text.Text;
            }
        }
    }
}
