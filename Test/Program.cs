using Bridge;
using Builder;
using ChainOfResponsibility;
using Command.Command;
using CompositePattern;
using Decorator;
using DependecyInjection;
using ElvisOperator;
using MapperPattern;
using Middleware;
using Proxy;
using ServiceLocator;
using StrategyPattern;
using Visitor;

namespace DesignPatterns
{
    public class Program
    {
        static void Main(string[] args)
        {
            #region [ Composite pattern ]
            //CompositeDemo compositeDemo = new CompositeDemo();
            //compositeDemo.Build();
            #endregion

            #region [ Builder pattern ]
            //BuilderPattern builderPattern = new BuilderPattern();
            //builderPattern.BuildMachine();
            #endregion

            #region [ Visitor pattern ]
            //VisitorDemo visitorDemo = new VisitorDemo();
            //visitorDemo.VisitorPattern(); 
            #endregion

            #region [ Bridge pattern ]
            //BridgeDemo bridgeDemo = new BridgeDemo();
            //bridgeDemo.BridgePattern();
            #endregion

            #region [ Proxy pattern ]
            //ProxyPattern proxyPattern = new ProxyPattern();
            //proxyPattern.ProxyPropertyDemo();
            #endregion

            #region [ Chain of responsibility pattern ]
            //ChainOfResponsibilityPattern cor = new ChainOfResponsibilityPattern();
            //cor.ChainOfResponsibilityDemo();
            #endregion

            #region [ Strategy pattern ]
            //StrategyExample se = new StrategyExample();
            //se.SignDocumentStrategy();
            #endregion

            #region [ Service Locator pattern ]
            //ServiceLocatorPattern slp = new ServiceLocatorPattern();
            //slp.LocateServiceA();
            #endregion

            #region [ Maybe pattern ]
            //MaybePattern maybePattern = new MaybePattern();
            //maybePattern.Maybe();
            #endregion

            #region [ Decorator pattern ]
            //DecoratorPattern decoratorPattern = new DecoratorPattern();
            //decoratorPattern.SquareDecorator(5);
            #endregion

            #region [ Command pattern ]
            //CommandPattern commandPattern = new CommandPattern();
            //commandPattern.Command();
            #endregion

            #region [ Not GoF patterns ]

            #region [ Mapper ]
            //MapperExample me = new MapperExample();
            //me.Map();
            #endregion

            #region [ Dependecy Injection ] 
            //TestDI testDI = new TestDI();
            //testDI.TestDependecyInjection();
            #endregion

            #region [ Middlewares ]
            PipelineTest pt = new PipelineTest();
            pt.PipeTest();
            #endregion  
            
            
            
            #endregion
        }
    }
}

