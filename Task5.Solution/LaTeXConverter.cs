using System;
namespace Task5.Solution
{
    public class LaTeXConverter : IConverter
    {
        public string ConvertBoldText(string text)
        {
            return "\\textbf{" + text + "}";
        }

        public string ConvertHyperlink(string text, string url)
        {
            return "\\href{" + url + "}{" + text + "}";
        }

        public string ConvertPlainText(string text)
        {
            return text;
        }
    }
}
