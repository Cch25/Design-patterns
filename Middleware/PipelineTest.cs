using System;

namespace Middleware
{
    public class PipelineTest
    {
        public void PipeTest()
        {
            Action<string> pipe = new PipeBuilder<string>(msg => Console.WriteLine($"\t\tMain execution {msg}"))
                .AddPipe(typeof(Try<string>))
                .AddPipe(typeof(Try<string>))
                .AddPipe(typeof(Wrap<string>))
                .AddPipe(typeof(Wrap<string>))
                .AddPipe(typeof(Try<string>))
                .AddPipe(typeof(Wrap<string>))
                .AddPipe(typeof(Wrap<string>))
                .Build();
            pipe("from pipe");
        }
    }
}
