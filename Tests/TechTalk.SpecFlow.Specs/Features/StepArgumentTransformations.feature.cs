﻿// ------------------------------------------------------------------------------
//  <auto-generated>
//      This code was generated by SpecFlow (http://www.specflow.org/).
//      SpecFlow Version:1.7.1.0
//      SpecFlow Generator Version:1.7.0.0
//      Runtime Version:4.0.30319.225
// 
//      Changes to this file may cause incorrect behavior and will be lost if
//      the code is regenerated.
//  </auto-generated>
// ------------------------------------------------------------------------------
#region Designer generated code
namespace TechTalk.SpecFlow.Specs.Features
{
    using TechTalk.SpecFlow;
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("TechTalk.SpecFlow", "1.7.1.0")]
    [System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [NUnit.Framework.TestFixtureAttribute()]
    [NUnit.Framework.DescriptionAttribute("Step Argument Transformations")]
    public partial class StepArgumentTransformationsFeature
    {
        
        private static TechTalk.SpecFlow.ITestRunner testRunner;
        
#line 1 "StepArgumentTransformations.feature"
#line hidden
        
        [NUnit.Framework.TestFixtureSetUpAttribute()]
        public virtual void FeatureSetup()
        {
            testRunner = TechTalk.SpecFlow.TestRunnerManager.GetTestRunner();
            TechTalk.SpecFlow.FeatureInfo featureInfo = new TechTalk.SpecFlow.FeatureInfo(new System.Globalization.CultureInfo("en-US"), "Step Argument Transformations", "In order to reduce the amount of code and repetitive tasks in my steps\r\nAs a prog" +
                    "rammer\r\nI want to define reusable transformations for my step arguments", ProgrammingLanguage.CSharp, ((string[])(null)));
            testRunner.OnFeatureStart(featureInfo);
        }
        
        [NUnit.Framework.TestFixtureTearDownAttribute()]
        public virtual void FeatureTearDown()
        {
            testRunner.OnFeatureEnd();
            testRunner = null;
        }
        
        [NUnit.Framework.SetUpAttribute()]
        public virtual void TestInitialize()
        {
        }
        
        [NUnit.Framework.TearDownAttribute()]
        public virtual void ScenarioTearDown()
        {
            testRunner.OnScenarioEnd();
        }
        
        public virtual void ScenarioSetup(TechTalk.SpecFlow.ScenarioInfo scenarioInfo)
        {
            testRunner.OnScenarioStart(scenarioInfo);
        }
        
        public virtual void ScenarioCleanup()
        {
            testRunner.CollectScenarioErrors();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("Should be able to convert steps arguments to arbritrary class instances")]
        public virtual void ShouldBeAbleToConvertStepsArgumentsToArbritraryClassInstances()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Should be able to convert steps arguments to arbritrary class instances", ((string[])(null)));
#line 6
this.ScenarioSetup(scenarioInfo);
#line hidden
#line 7
 testRunner.Given("the following class", "public class User\r\n{\r\npublic string Name { get; set; }\r\n}", ((TechTalk.SpecFlow.Table)(null)));
#line hidden
#line 14
 testRunner.And("the following step argument transformation", "[StepArgumentTransformation]\r\npublic User ConvertUser(string name)\r\n{\r\nreturn new" +
                    " User {Name = name};\r\n}", ((TechTalk.SpecFlow.Table)(null)));
#line hidden
#line 22
 testRunner.And("the following step definition", "[When(@\"(.*) books a flight\")]\r\npublic void WhenSomebodyBooksAFlight(User user)\r\n" +
                    "{}", ((TechTalk.SpecFlow.Table)(null)));
#line hidden
#line 28
 testRunner.And("a scenario \'Simple Scenario\' as", "When Bob books a flight", ((TechTalk.SpecFlow.Table)(null)));
#line 32
 testRunner.When("I execute the tests");
#line 33
 testRunner.Then("the binding method \'WhenSomebodyBooksAFlight\' is executed");
#line hidden
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("Should be able to convert step arguments to simple .NET types")]
        public virtual void ShouldBeAbleToConvertStepArgumentsToSimple_NETTypes()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Should be able to convert step arguments to simple .NET types", ((string[])(null)));
#line 35
this.ScenarioSetup(scenarioInfo);
#line hidden
#line 36
 testRunner.Given("the following step argument transformation", "[StepArgumentTransformation(@\"in (\\d+) days\")]\r\npublic DateTime ConvertInDays(int" +
                    " days)\r\n{\r\nreturn DateTime.Today.AddDays(days);\r\n}", ((TechTalk.SpecFlow.Table)(null)));
#line hidden
#line 44
 testRunner.And("the following step definition", "[Given(@\"I have an appointment (.*)\")]\r\npublic void GivenIHaveAnAppointmentAt(Dat" +
                    "eTime time)\r\n{}", ((TechTalk.SpecFlow.Table)(null)));
#line hidden
#line 50
 testRunner.And("a scenario \'Simple Scenario\' as", "Given I have an appointment in 2 days", ((TechTalk.SpecFlow.Table)(null)));
#line 54
 testRunner.When("I execute the tests");
#line 55
 testRunner.Then("the binding method \'GivenIHaveAnAppointmentAt\' is executed");
#line hidden
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("Multi-line text arguments can be converted")]
        public virtual void Multi_LineTextArgumentsCanBeConverted()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Multi-line text arguments can be converted", ((string[])(null)));
#line 57
this.ScenarioSetup(scenarioInfo);
#line hidden
#line 58
 testRunner.Given("the following step argument transformation", "[StepArgumentTransformation]\r\npublic XmlDocument TransformXml(string xml)\r\n{\r\n   " +
                    " XmlDocument result = new XmlDocument();\r\n    result.LoadXml(xml);\r\n    return r" +
                    "esult;\r\n}", ((TechTalk.SpecFlow.Table)(null)));
#line hidden
#line 68
 testRunner.And("the following step definition", "[Given(@\"the following XML file\")]\r\npublic void GivenTheFollowingXMLFile(XmlDocum" +
                    "ent xmlDocument)\r\n{}", ((TechTalk.SpecFlow.Table)(null)));
#line hidden
#line 74
 testRunner.And("a scenario \'Simple Scenario\' as", "Given the following XML file\r\n\'\'\'\r\n<Root>\r\n<Child attr=\"value\" />\r\n</Root>\r\n\'\'\'", ((TechTalk.SpecFlow.Table)(null)));
#line 83
 testRunner.When("I execute the tests");
#line 84
 testRunner.Then("the binding method \'GivenTheFollowingXMLFile\' is executed");
#line hidden
            this.ScenarioCleanup();
        }
    }
}
#endregion
