using System;
namespace Task5.Solution
{
    public class PlainText : DocumentPart
    {
        public override string Convert(IConverter converter) => converter.ConvertPlainText(this.Text);
    }
}
