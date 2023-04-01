using System.CodeDom;
using System.Collections.Generic;
using TechTalk.SpecFlow.Generator.CodeDom;
using TechTalk.SpecFlow.Generator.UnitTestProvider;
using TechTalk.SpecFlow.Generator;
using System.Threading;

namespace PutridParrot.SpecFlow.NUnitSta
{
    public class NUnit3StaGeneratorProvider : IUnitTestGeneratorProvider
    {
        private readonly IUnitTestGeneratorProvider _unitTestGeneratorProvider;

        public NUnit3StaGeneratorProvider(CodeDomHelper codeDomHelper)
        {
            _unitTestGeneratorProvider = new NUnit3TestGeneratorProvider(codeDomHelper);
        }

        public UnitTestGeneratorTraits GetTraits()
        {
            return _unitTestGeneratorProvider.GetTraits();
        }

        public void SetTestClass(TestClassGenerationContext generationContext, string featureTitle, string featureDescription)
        {
            _unitTestGeneratorProvider.SetTestClass(generationContext, featureTitle, featureDescription);

            var codeFieldReference = new CodeFieldReferenceExpression(
                new CodeTypeReferenceExpression(typeof(ApartmentState)), "STA");

            var codeAttributeDeclaration =
                new CodeAttributeDeclaration("NUnit.Framework.Apartment", new CodeAttributeArgument(codeFieldReference));
            generationContext.TestClass.CustomAttributes.Add(codeAttributeDeclaration);
            //UpdateAttributes(generationContext.TestClass);
        }

        public void SetTestClassCategories(TestClassGenerationContext generationContext, IEnumerable<string> featureCategories)
        {
            _unitTestGeneratorProvider.SetTestClassCategories(generationContext, featureCategories);
        }

        public void SetTestClassIgnore(TestClassGenerationContext generationContext)
        {
            _unitTestGeneratorProvider.SetTestClassIgnore(generationContext);
        }

        public void FinalizeTestClass(TestClassGenerationContext generationContext)
        {
            _unitTestGeneratorProvider.FinalizeTestClass(generationContext);
        }

        public void SetTestClassNonParallelizable(TestClassGenerationContext generationContext)
        {
            _unitTestGeneratorProvider.SetTestClassNonParallelizable(generationContext);
        }

        public void SetTestClassInitializeMethod(TestClassGenerationContext generationContext)
        {
            _unitTestGeneratorProvider.SetTestClassInitializeMethod(generationContext);
        }

        public void SetTestClassCleanupMethod(TestClassGenerationContext generationContext)
        {
            _unitTestGeneratorProvider.SetTestClassCleanupMethod(generationContext);
        }

        public void SetTestInitializeMethod(TestClassGenerationContext generationContext)
        {
            _unitTestGeneratorProvider.SetTestInitializeMethod(generationContext);
        }

        public void SetTestCleanupMethod(TestClassGenerationContext generationContext)
        {
            _unitTestGeneratorProvider.SetTestCleanupMethod(generationContext);
        }

        public void SetTestMethod(TestClassGenerationContext generationContext, CodeMemberMethod testMethod, string friendlyTestName)
        {
            _unitTestGeneratorProvider.SetTestMethod(generationContext, testMethod, friendlyTestName);
        }

        public void SetTestMethodCategories(TestClassGenerationContext generationContext, CodeMemberMethod testMethod,
            IEnumerable<string> scenarioCategories)
        {
            _unitTestGeneratorProvider.SetTestMethodCategories(generationContext, testMethod, scenarioCategories);
        }

        public void SetTestMethodIgnore(TestClassGenerationContext generationContext, CodeMemberMethod testMethod)
        {
            _unitTestGeneratorProvider.SetTestMethodIgnore(generationContext, testMethod);
        }

        public void SetRowTest(TestClassGenerationContext generationContext, CodeMemberMethod testMethod, string scenarioTitle)
        {
            _unitTestGeneratorProvider.SetRowTest(generationContext, testMethod, scenarioTitle);
        }

        public void SetRow(TestClassGenerationContext generationContext, CodeMemberMethod testMethod, IEnumerable<string> arguments,
            IEnumerable<string> tags, bool isIgnored)
        {
            _unitTestGeneratorProvider.SetRow(generationContext, testMethod, arguments, tags, isIgnored);
        }

        public void SetTestMethodAsRow(TestClassGenerationContext generationContext, CodeMemberMethod testMethod, string scenarioTitle,
            string exampleSetName, string variantName, IEnumerable<KeyValuePair<string, string>> arguments)
        {
            _unitTestGeneratorProvider.SetTestMethodAsRow(generationContext, testMethod, scenarioTitle, exampleSetName,
                variantName, arguments);
        }
    }
}
