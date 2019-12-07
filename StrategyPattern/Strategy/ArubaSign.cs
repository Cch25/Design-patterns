using StrategyPattern.Model;
using System;
using System.Text;

namespace StrategyPattern.Strategy
{
    public class ArubaSign : ISignStrategy
    {
        private StringBuilder _sb;
        private const string SIGNATURE_MARK = " Signed by Aruba";
        public Document FinishSign(Document document)
        {
            if (document.Content.Contains(SIGNATURE_MARK))
            {
                return document;
            }
            return null;
        }

        public bool PrepareDocument(Document document)
        {
            Console.WriteLine("Checking your document");
            if (document.Id == null || string.IsNullOrEmpty(document.Name) || string.IsNullOrEmpty(document.Content))
            {
                Console.WriteLine("Invalid document");
                return false;
            }
            return true;
        }

        public Document SignDocument(Document document)
        {
            Console.WriteLine("Signing your document");
            _sb = new StringBuilder(document.Content);
            _sb.AppendLine(SIGNATURE_MARK);
            document.Content = _sb.ToString();
            return document;
        }
    }
}
