using PutridParrot.SpecFlow.NUnitSta;
using TechTalk.SpecFlow.Generator.Plugins;
using TechTalk.SpecFlow.Generator.UnitTestProvider;
using TechTalk.SpecFlow.Infrastructure;
using TechTalk.SpecFlow.UnitTestProvider;

[assembly:GeneratorPlugin(typeof(NUnitStaPlugin))]

namespace PutridParrot.SpecFlow.NUnitSta
{
    public class NUnitStaPlugin : IGeneratorPlugin
    {
        public void Initialize(GeneratorPluginEvents generatorPluginEvents, GeneratorPluginParameters generatorPluginParameters,
            UnitTestProviderConfiguration unitTestProviderConfiguration)
        {
            generatorPluginEvents.CustomizeDependencies += (sender, args) =>
            {
                args.ObjectContainer
                    .RegisterTypeAs<NUnit3StaGeneratorProvider, IUnitTestGeneratorProvider>();
            };
        }
    }
}