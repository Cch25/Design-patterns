using StrategyPattern.Model;

namespace StrategyPattern.Strategy
{
    public class SignMode<SM> where SM : ISignStrategy, new()
    {
        private readonly ISignStrategy _signStrategy = new SM();

        public Document SignDocument(Document document)
        {
            bool isValid = _signStrategy.PrepareDocument(document);
            if (isValid)
            {
                Document signedDocument = _signStrategy.SignDocument(document);
                return _signStrategy.FinishSign(signedDocument);
            }
            return null;
        }

    }
}
