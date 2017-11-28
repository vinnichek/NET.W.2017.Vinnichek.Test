using System;
namespace Task5.Solution
{
    public class PlainTextConverter : IConverter
    {
        public string Convert(DocumentPart part)
        {
            if (part.GetType() == typeof(BoldText))
            {
                var text = (BoldText)part;
                return "**" + text.Text + "**";
            }

            if (part.GetType() == typeof(Hyperlink))
            {
                var text = (Hyperlink)part;
                return text.Text + " [" + text.Url + "]";
            }

            if (part.GetType() == typeof(PlainText))
            {
                var text = (PlainText)part;
                return text.Text;
            }
        }
    }
}
