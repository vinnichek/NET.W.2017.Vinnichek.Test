using System;
using System.Collections.Generic;

namespace Task5.Solution
{
    public class Document
    {
        private List<DocumentPart> parts;

        public Document(IEnumerable<DocumentPart> parts)
        {
            this.parts = new List<DocumentPart>(parts);
        }

        public string Convert(IConverter converter)
        {
            string str = " ";

            foreach (var part in parts)
            {
                str += $"{part.Convert(converter)}\n";
            }

            return str;
        }

    }
}
