using StrategyPattern.Model;
using StrategyPattern.Strategy;
using System;
using System.Linq;

namespace StrategyPattern
{
    public class StrategyExample
    {
        private const string Alphabet = "ABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789";
        private Random rnd = new Random();
        public void SignDocumentStrategy()
        {
            Document document = new Document
            {
                Id = Guid.NewGuid(),
                Name = "MyFile.txt",
                Content = new string(Enumerable.Repeat(Alphabet, 3).Select(x => x[rnd.Next(25)]).ToArray())
            };

            SignMode<ArubaSign> arubaSign = new SignMode<ArubaSign>();
            Document signedDocument = arubaSign.SignDocument(document);
            ShowDocumentInfo(signedDocument);

            document.Content = new string(Enumerable.Repeat(Alphabet, 3).Select(x => x[rnd.Next(5)]).ToArray());
            SignMode<InfocertSign> infocertSign = new SignMode<InfocertSign>();
            signedDocument = infocertSign.SignDocument(document);
            ShowDocumentInfo(signedDocument);
        }

        private void ShowDocumentInfo(Document document)
        {
            Console.WriteLine($"Document id: {document.Id}");
            Console.WriteLine($"Document name: {document.Name}");
            Console.WriteLine($"Document content: {document.Content}");

        }

    }
}
