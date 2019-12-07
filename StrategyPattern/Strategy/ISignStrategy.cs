using StrategyPattern.Model;

namespace StrategyPattern.Strategy
{
    public interface ISignStrategy
    {
        bool PrepareDocument(Document document);
        Document SignDocument(Document document);
        Document FinishSign(Document document);
    }
}
