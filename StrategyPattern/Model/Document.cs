using System;

namespace StrategyPattern.Model
{
    public class Document
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string Content { get; set; }
    }
}
