namespace Task5.Console
{
    using System.Collections.Generic;
    using System;
    using Task5;
    using Task5.Solution;

    class Program
    {
        static void Main(string[] args)
        {
            var htmlConverter = new HtmlConverter();
            var laTeXConverter = new LaTeXConverter();
            var plainTextConverter = new PlainTextConverter();

            List<DocumentPart> parts = new List<DocumentPart>
                {
                    new PlainText {Text = "Some plain text"},
                    new Hyperlink {Text = "google.com", Url = "https://www.google.by/"},
                    new BoldText {Text = "Some bold text"}
                };

            Document document = new Document(parts);

            Console.WriteLine(document.Convert(htmlConverter));
            Console.WriteLine(document.Convert(plainTextConverter));
            Console.WriteLine(document.Convert(laTeXConverter));
        }
    }
}
