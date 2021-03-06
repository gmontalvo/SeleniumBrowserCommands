﻿// ------------------------------------------------------------------------------
//  <auto-generated>
//      This code was generated by SpecFlow (http://www.specflow.org/).
//      SpecFlow Version:1.9.0.77
//      SpecFlow Generator Version:1.9.0.0
//      Runtime Version:4.0.30319.34209
// 
//      Changes to this file may cause incorrect behavior and will be lost if
//      the code is regenerated.
//  </auto-generated>
// ------------------------------------------------------------------------------
#region Designer generated code
#pragma warning disable
namespace RegistrationDemo.Tests.Features
{
    using TechTalk.SpecFlow;
    using Autofac;
    using Autofac.Configuration;
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("TechTalk.SpecFlow", "1.9.0.77")]
    [System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [NUnit.Framework.TestFixtureAttribute()]
    [NUnit.Framework.DescriptionAttribute("UserRegistration")]
    public partial class UserRegistrationFeature
    {
        
        private OpenQA.Selenium.IWebDriver driver;
        
        private IContainer container;
        
        private static TechTalk.SpecFlow.ITestRunner testRunner;
        
#line 1 "UserRegistration.feature"
#line hidden
        
        [NUnit.Framework.TestFixtureSetUpAttribute()]
        public virtual void FeatureSetup()
        {
            var builder = new ContainerBuilder();
            builder.RegisterModule(new ConfigurationSettingsReader());
            this.container = builder.Build();
            testRunner = TechTalk.SpecFlow.TestRunnerManager.GetTestRunner();
            TechTalk.SpecFlow.FeatureInfo featureInfo = new TechTalk.SpecFlow.FeatureInfo(new System.Globalization.CultureInfo("en-US"), "UserRegistration", "In order to use the features only available to members\r\nAs a Guest user \r\nI want " +
                    "to register a new account", ProgrammingLanguage.CSharp, ((string[])(null)));
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
            try { System.Threading.Thread.Sleep(50); this.driver.Quit(); } catch (System.Exception) {}
            this.driver = null;
            ScenarioContext.Current.Remove("Driver");
            ScenarioContext.Current.Remove("Container");
        }
        
        public virtual void ScenarioSetup(TechTalk.SpecFlow.ScenarioInfo scenarioInfo)
        {
            testRunner.OnScenarioStart(scenarioInfo);
            if(this.driver != null)
                ScenarioContext.Current.Add("Driver", this.driver);
            if(this.container != null)
                ScenarioContext.Current.Add("Container", this.container);
        }
        
        public virtual void ScenarioCleanup()
        {
            testRunner.CollectScenarioErrors();
        }
        
        private void InitializeSelenium(string browser)
        {
            this.driver = this.container.ResolveNamed<OpenQA.Selenium.IWebDriver>(browser);
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("User signs up with valid details")]
        [NUnit.Framework.TestCaseAttribute("Firefox", Category="Firefox", TestName="UserSignsUpWithValidDetails on Firefox")]
        public virtual void UserSignsUpWithValidDetails(string browser)
        {
            InitializeSelenium(browser);
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("User signs up with valid details", new string[] {
                        "Browser:Firefox"});
#line 7
this.ScenarioSetup(scenarioInfo);
#line 8
testRunner.Given("I am on the home page", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 9
testRunner.And("I am not logged in", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 10
testRunner.When("I click the register button", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
            TechTalk.SpecFlow.Table table1 = new TechTalk.SpecFlow.Table(new string[] {
                        "field",
                        "value"});
            table1.AddRow(new string[] {
                        "UserName",
                        "joe.{0}@snuffy.com"});
            table1.AddRow(new string[] {
                        "Password",
                        "Password_01"});
            table1.AddRow(new string[] {
                        "ConfirmPassword",
                        "Password_01"});
#line 11
testRunner.And("fill of the registration form with the following details", ((string)(null)), table1, "And ");
#line 16
testRunner.And("I submit the form", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 17
testRunner.Then("I am redirected to the home page", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 18
testRunner.And("I will be logged in", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("User signs up with mismatched passwords")]
        [NUnit.Framework.TestCaseAttribute("Firefox", Category="Firefox", TestName="UserSignsUpWithMismatchedPasswords on Firefox")]
        public virtual void UserSignsUpWithMismatchedPasswords(string browser)
        {
            InitializeSelenium(browser);
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("User signs up with mismatched passwords", new string[] {
                        "Browser:Firefox"});
#line 21
this.ScenarioSetup(scenarioInfo);
#line 22
testRunner.Given("I am on the home page", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 23
testRunner.And("I am not logged in", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 24
testRunner.When("I click the register button", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
            TechTalk.SpecFlow.Table table2 = new TechTalk.SpecFlow.Table(new string[] {
                        "field",
                        "value"});
            table2.AddRow(new string[] {
                        "UserName",
                        "joe.{0}@snuffy.com"});
            table2.AddRow(new string[] {
                        "Password",
                        "Password_01"});
            table2.AddRow(new string[] {
                        "ConfirmPassword",
                        "Pasword_01"});
#line 25
testRunner.And("fill of the registration form with the following details", ((string)(null)), table2, "And ");
#line 30
testRunner.And("I submit the form", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 31
testRunner.Then("I will see the message The password and confirmation password do not match.", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }
    }
}
#pragma warning restore
#endregion
