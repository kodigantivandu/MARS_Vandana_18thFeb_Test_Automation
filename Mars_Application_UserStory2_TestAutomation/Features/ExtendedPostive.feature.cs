﻿// ------------------------------------------------------------------------------
//  <auto-generated>
//      This code was generated by SpecFlow (https://www.specflow.org/).
//      SpecFlow Version:3.9.0.0
//      SpecFlow Generator Version:3.9.0.0
// 
//      Changes to this file may cause incorrect behavior and will be lost if
//      the code is regenerated.
//  </auto-generated>
// ------------------------------------------------------------------------------
#region Designer generated code
#pragma warning disable
namespace Mars_Application_UserStory2_TestAutomation.Features
{
    using TechTalk.SpecFlow;
    using System;
    using System.Linq;
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("TechTalk.SpecFlow", "3.9.0.0")]
    [System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [NUnit.Framework.TestFixtureAttribute()]
    [NUnit.Framework.DescriptionAttribute("ExtendedPostive")]
    public partial class ExtendedPostiveFeature
    {
        
        private TechTalk.SpecFlow.ITestRunner testRunner;
        
        private static string[] featureTags = ((string[])(null));
        
#line 1 "ExtendedPostive.feature"
#line hidden
        
        [NUnit.Framework.OneTimeSetUpAttribute()]
        public virtual void FeatureSetup()
        {
            testRunner = TechTalk.SpecFlow.TestRunnerManager.GetTestRunner();
            TechTalk.SpecFlow.FeatureInfo featureInfo = new TechTalk.SpecFlow.FeatureInfo(new System.Globalization.CultureInfo("en-US"), "Features", "ExtendedPostive", "Test MARS application Test cases", ProgrammingLanguage.CSharp, featureTags);
            testRunner.OnFeatureStart(featureInfo);
        }
        
        [NUnit.Framework.OneTimeTearDownAttribute()]
        public virtual void FeatureTearDown()
        {
            testRunner.OnFeatureEnd();
            testRunner = null;
        }
        
        [NUnit.Framework.SetUpAttribute()]
        public void TestInitialize()
        {
        }
        
        [NUnit.Framework.TearDownAttribute()]
        public void TestTearDown()
        {
            testRunner.OnScenarioEnd();
        }
        
        public void ScenarioInitialize(TechTalk.SpecFlow.ScenarioInfo scenarioInfo)
        {
            testRunner.OnScenarioInitialize(scenarioInfo);
            testRunner.ScenarioContext.ScenarioContainer.RegisterInstanceAs<NUnit.Framework.TestContext>(NUnit.Framework.TestContext.CurrentContext);
        }
        
        public void ScenarioStart()
        {
            testRunner.OnScenarioStart();
        }
        
        public void ScenarioCleanup()
        {
            testRunner.CollectScenarioErrors();
        }
        
        public virtual void FeatureBackground()
        {
#line 4
#line hidden
#line 6
testRunner.Given("User logs in Mars application using valid username \"kodigantivandana@gmail.com\" a" +
                    "nd password \"vandu@28june\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line hidden
#line 7
testRunner.When("User selects Profile tab", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("b1.User adds Language and levels in Profile tab")]
        [NUnit.Framework.CategoryAttribute("ExtendedPostiveTests,")]
        [NUnit.Framework.CategoryAttribute("ExtendedPostiveAddDuplicateLanguage")]
        [NUnit.Framework.TestCaseAttribute("English", "Fluent", null)]
        public void B1_UserAddsLanguageAndLevelsInProfileTab(string language, string language_Level, string[] exampleTags)
        {
            string[] @__tags = new string[] {
                    "ExtendedPostiveTests,",
                    "ExtendedPostiveAddDuplicateLanguage"};
            if ((exampleTags != null))
            {
                @__tags = System.Linq.Enumerable.ToArray(System.Linq.Enumerable.Concat(@__tags, exampleTags));
            }
            string[] tagsOfScenario = @__tags;
            System.Collections.Specialized.OrderedDictionary argumentsOfScenario = new System.Collections.Specialized.OrderedDictionary();
            argumentsOfScenario.Add("Language", language);
            argumentsOfScenario.Add("Language_Level", language_Level);
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("b1.User adds Language and levels in Profile tab", null, tagsOfScenario, argumentsOfScenario, featureTags);
#line 11
this.ScenarioInitialize(scenarioInfo);
#line hidden
            if ((TagHelper.ContainsIgnoreTag(tagsOfScenario) || TagHelper.ContainsIgnoreTag(featureTags)))
            {
                testRunner.SkipScenario();
            }
            else
            {
                this.ScenarioStart();
#line 4
this.FeatureBackground();
#line hidden
#line 12
testRunner.When(string.Format("User enters new Language details \'{0}\' \'{1}\' and clicks on Add New button", language, language_Level), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
#line 13
testRunner.Then(string.Format("Application saves the Langauge details \'{0}\' \'{1}\' for the user", language, language_Level), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            }
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("b2.User adds Duplicate Language and levels in Profile tab")]
        [NUnit.Framework.CategoryAttribute("ExtendedPostiveTests,")]
        [NUnit.Framework.CategoryAttribute("ExtendedPostiveAddDuplicateLanguage")]
        [NUnit.Framework.TestCaseAttribute("English", "Fluent", null)]
        public void B2_UserAddsDuplicateLanguageAndLevelsInProfileTab(string language, string language_Level, string[] exampleTags)
        {
            string[] @__tags = new string[] {
                    "ExtendedPostiveTests,",
                    "ExtendedPostiveAddDuplicateLanguage"};
            if ((exampleTags != null))
            {
                @__tags = System.Linq.Enumerable.ToArray(System.Linq.Enumerable.Concat(@__tags, exampleTags));
            }
            string[] tagsOfScenario = @__tags;
            System.Collections.Specialized.OrderedDictionary argumentsOfScenario = new System.Collections.Specialized.OrderedDictionary();
            argumentsOfScenario.Add("Language", language);
            argumentsOfScenario.Add("Language_Level", language_Level);
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("b2.User adds Duplicate Language and levels in Profile tab", null, tagsOfScenario, argumentsOfScenario, featureTags);
#line 20
this.ScenarioInitialize(scenarioInfo);
#line hidden
            if ((TagHelper.ContainsIgnoreTag(tagsOfScenario) || TagHelper.ContainsIgnoreTag(featureTags)))
            {
                testRunner.SkipScenario();
            }
            else
            {
                this.ScenarioStart();
#line 4
this.FeatureBackground();
#line hidden
#line 21
testRunner.And(string.Format("User enters a duplciate Language details \'{0}\' \'{1}\' and clicks on Add New button" +
                            "", language, language_Level), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "* ");
#line hidden
            }
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("b3.User adds skills and  levels in Profile tab")]
        [NUnit.Framework.CategoryAttribute("ExtendedPostiveTests,")]
        [NUnit.Framework.CategoryAttribute("ExtendedPostiveAddDuplicateSkill")]
        [NUnit.Framework.TestCaseAttribute("Automation Testing", "Expert", null)]
        public void B3_UserAddsSkillsAndLevelsInProfileTab(string skills, string skill_Level, string[] exampleTags)
        {
            string[] @__tags = new string[] {
                    "ExtendedPostiveTests,",
                    "ExtendedPostiveAddDuplicateSkill"};
            if ((exampleTags != null))
            {
                @__tags = System.Linq.Enumerable.ToArray(System.Linq.Enumerable.Concat(@__tags, exampleTags));
            }
            string[] tagsOfScenario = @__tags;
            System.Collections.Specialized.OrderedDictionary argumentsOfScenario = new System.Collections.Specialized.OrderedDictionary();
            argumentsOfScenario.Add("skills", skills);
            argumentsOfScenario.Add("Skill_Level", skill_Level);
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("b3.User adds skills and  levels in Profile tab", null, tagsOfScenario, argumentsOfScenario, featureTags);
#line 28
this.ScenarioInitialize(scenarioInfo);
#line hidden
            if ((TagHelper.ContainsIgnoreTag(tagsOfScenario) || TagHelper.ContainsIgnoreTag(featureTags)))
            {
                testRunner.SkipScenario();
            }
            else
            {
                this.ScenarioStart();
#line 4
this.FeatureBackground();
#line hidden
#line 29
testRunner.When(string.Format("User enters new skills detais \'{0}\' \'{1}\'and clicks on Add new button", skills, skill_Level), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
#line 30
testRunner.Then(string.Format("Application saves the skills details \'{0}\' \'{1}\'", skills, skill_Level), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            }
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("b4.User adds Duplicate skills and levels in Profile tab")]
        [NUnit.Framework.CategoryAttribute("ExtendedPostiveTests,")]
        [NUnit.Framework.CategoryAttribute("ExtendedPostiveAddDuplicateSkill")]
        [NUnit.Framework.TestCaseAttribute("Automation Testing", "Expert", null)]
        public void B4_UserAddsDuplicateSkillsAndLevelsInProfileTab(string skills, string skill_Level, string[] exampleTags)
        {
            string[] @__tags = new string[] {
                    "ExtendedPostiveTests,",
                    "ExtendedPostiveAddDuplicateSkill"};
            if ((exampleTags != null))
            {
                @__tags = System.Linq.Enumerable.ToArray(System.Linq.Enumerable.Concat(@__tags, exampleTags));
            }
            string[] tagsOfScenario = @__tags;
            System.Collections.Specialized.OrderedDictionary argumentsOfScenario = new System.Collections.Specialized.OrderedDictionary();
            argumentsOfScenario.Add("skills", skills);
            argumentsOfScenario.Add("Skill_Level", skill_Level);
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("b4.User adds Duplicate skills and levels in Profile tab", null, tagsOfScenario, argumentsOfScenario, featureTags);
#line 36
this.ScenarioInitialize(scenarioInfo);
#line hidden
            if ((TagHelper.ContainsIgnoreTag(tagsOfScenario) || TagHelper.ContainsIgnoreTag(featureTags)))
            {
                testRunner.SkipScenario();
            }
            else
            {
                this.ScenarioStart();
#line 4
this.FeatureBackground();
#line hidden
#line 37
testRunner.When(string.Format("User enters a duplciate skills details \'{0}\' \'{1}\' and clicks on Add New button", skills, skill_Level), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
            }
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("b5.User deletes skills and levels in Profile tab")]
        [NUnit.Framework.CategoryAttribute("ExtendedPostiveTests,")]
        [NUnit.Framework.CategoryAttribute("ExtendedPostiveAddDuplicateSkill")]
        [NUnit.Framework.TestCaseAttribute("Automation Testing", "Expert", null)]
        public void B5_UserDeletesSkillsAndLevelsInProfileTab(string skills, string skill_Level, string[] exampleTags)
        {
            string[] @__tags = new string[] {
                    "ExtendedPostiveTests,",
                    "ExtendedPostiveAddDuplicateSkill"};
            if ((exampleTags != null))
            {
                @__tags = System.Linq.Enumerable.ToArray(System.Linq.Enumerable.Concat(@__tags, exampleTags));
            }
            string[] tagsOfScenario = @__tags;
            System.Collections.Specialized.OrderedDictionary argumentsOfScenario = new System.Collections.Specialized.OrderedDictionary();
            argumentsOfScenario.Add("skills", skills);
            argumentsOfScenario.Add("Skill_Level", skill_Level);
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("b5.User deletes skills and levels in Profile tab", null, tagsOfScenario, argumentsOfScenario, featureTags);
#line 44
this.ScenarioInitialize(scenarioInfo);
#line hidden
            if ((TagHelper.ContainsIgnoreTag(tagsOfScenario) || TagHelper.ContainsIgnoreTag(featureTags)))
            {
                testRunner.SkipScenario();
            }
            else
            {
                this.ScenarioStart();
#line 4
this.FeatureBackground();
#line hidden
#line 45
testRunner.When(string.Format("User deletes skills_details \'{0}\' \'{1}\' for the user", skills, skill_Level), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
            }
            this.ScenarioCleanup();
        }
    }
}
#pragma warning restore
#endregion
