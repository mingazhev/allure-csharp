﻿// ------------------------------------------------------------------------------
//  <auto-generated>
//      This code was generated by SpecFlow (http://www.specflow.org/).
//      SpecFlow Version:2.1.0.0
//      SpecFlow Generator Version:2.0.0.0
// 
//      Changes to this file may cause incorrect behavior and will be lost if
//      the code is regenerated.
//  </auto-generated>
// ------------------------------------------------------------------------------
#region Designer generated code
#pragma warning disable
namespace Allure.SpecFlowPlugin.Tests.Data.TestData
{
    using TechTalk.SpecFlow;
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("TechTalk.SpecFlow", "2.1.0.0")]
    [System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [TechTalk.SpecRun.FeatureAttribute("Attachments", SourceFile="Test Data\\Attachments.feature", SourceLine=0)]
    public partial class AttachmentsFeature
    {
        
        private TechTalk.SpecFlow.ITestRunner testRunner;
        
#line 1 "Attachments.feature"
#line hidden
        
        [TechTalk.SpecRun.FeatureInitialize()]
        public virtual void FeatureSetup()
        {
            testRunner = TechTalk.SpecFlow.TestRunnerManager.GetTestRunner();
            TechTalk.SpecFlow.FeatureInfo featureInfo = new TechTalk.SpecFlow.FeatureInfo(new System.Globalization.CultureInfo("en-US"), "Attachments", null, ProgrammingLanguage.CSharp, ((string[])(null)));
            testRunner.OnFeatureStart(featureInfo);
        }
        
        [TechTalk.SpecRun.FeatureCleanup()]
        public virtual void FeatureTearDown()
        {
            testRunner.OnFeatureEnd();
            testRunner = null;
        }
        
        public virtual void TestInitialize()
        {
        }
        
        [TechTalk.SpecRun.ScenarioCleanup()]
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
        
        [TechTalk.SpecRun.ScenarioAttribute("With attachments", new string[] {
                "attachment",
                "beforescenario",
                "afterscenario"}, SourceLine=3)]
        public virtual void WithAttachments()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("With attachments", new string[] {
                        "attachment",
                        "beforescenario",
                        "afterscenario"});
#line 4
this.ScenarioSetup(scenarioInfo);
#line 5
 testRunner.Given("Step with attachment", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 6
 testRunner.Given("Step is \'passed\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [TechTalk.SpecRun.ScenarioAttribute("Failed BeforeScenario with attachment", new string[] {
                "failed",
                "attachment",
                "beforescenario"}, SourceLine=8)]
        public virtual void FailedBeforeScenarioWithAttachment()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Failed BeforeScenario with attachment", new string[] {
                        "failed",
                        "attachment",
                        "beforescenario"});
#line 9
this.ScenarioSetup(scenarioInfo);
#line 10
 testRunner.Given("Step with attachment", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 11
 testRunner.Given("Step is \'passed\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [TechTalk.SpecRun.ScenarioAttribute("Failed AfterScenario with attachment", new string[] {
                "failed",
                "attachment",
                "afterscenario"}, SourceLine=13)]
        public virtual void FailedAfterScenarioWithAttachment()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Failed AfterScenario with attachment", new string[] {
                        "failed",
                        "attachment",
                        "afterscenario"});
#line 14
this.ScenarioSetup(scenarioInfo);
#line 15
 testRunner.Given("Step with attachment", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 16
 testRunner.Given("Step is \'passed\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [TechTalk.SpecRun.ScenarioAttribute("Failed BeforeStep with attachment", new string[] {
                "failed",
                "attachment",
                "beforestep"}, SourceLine=18)]
        public virtual void FailedBeforeStepWithAttachment()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Failed BeforeStep with attachment", new string[] {
                        "failed",
                        "attachment",
                        "beforestep"});
#line 19
this.ScenarioSetup(scenarioInfo);
#line 20
 testRunner.Given("Step with attachment", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 21
 testRunner.Given("Step is \'passed\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [TechTalk.SpecRun.ScenarioAttribute("Failed AfterStep with attachment", new string[] {
                "failed",
                "attachment",
                "afterstep"}, SourceLine=23)]
        public virtual void FailedAfterStepWithAttachment()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Failed AfterStep with attachment", new string[] {
                        "failed",
                        "attachment",
                        "afterstep"});
#line 24
this.ScenarioSetup(scenarioInfo);
#line 25
 testRunner.Given("Step with attachment", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 26
 testRunner.Given("Step is \'passed\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [TechTalk.SpecRun.TestRunCleanup()]
        public virtual void TestRunCleanup()
        {
            TechTalk.SpecFlow.TestRunnerManager.GetTestRunner().OnTestRunEnd();
        }
    }
}
#pragma warning restore
#endregion