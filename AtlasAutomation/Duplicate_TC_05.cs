﻿///////////////////////////////////////////////////////////////////////////////
//
// This file was automatically generated by RANOREX.
// DO NOT MODIFY THIS FILE! It is regenerated by the designer.
// All your modifications will be lost!
// http://www.ranorex.com
//
///////////////////////////////////////////////////////////////////////////////

using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;
using System.Drawing;
using System.Threading;
using WinForms = System.Windows.Forms;

using Ranorex;
using Ranorex.Core;
using Ranorex.Core.Testing;
using Ranorex.Core.Repository;

namespace AtlasAutomation
{
#pragma warning disable 0436 //(CS0436) The type 'type' in 'assembly' conflicts with the imported type 'type2' in 'assembly'. Using the type defined in 'assembly'.
    /// <summary>
    ///The Duplicate_TC_05 recording.
    /// </summary>
    [TestModule("518c92c7-6761-41a2-acee-2ef23a7f6735", ModuleType.Recording, 1)]
    public partial class Duplicate_TC_05 : ITestModule
    {
        /// <summary>
        /// Holds an instance of the AtlasAutomationRepository repository.
        /// </summary>
        public static AtlasAutomationRepository repo = AtlasAutomationRepository.Instance;

        static Duplicate_TC_05 instance = new Duplicate_TC_05();

        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public Duplicate_TC_05()
        {
            Jb8_Name = "Adapt_Peak";
        }

        /// <summary>
        /// Gets a static instance of this recording.
        /// </summary>
        public static Duplicate_TC_05 Instance
        {
            get { return instance; }
        }

#region Variables

        string _Jb8_Name;

        /// <summary>
        /// Gets or sets the value of variable Jb8_Name.
        /// </summary>
        [TestVariable("85b2653b-03c0-4362-bc9a-cd44a319a1c6")]
        public string Jb8_Name
        {
            get { return _Jb8_Name; }
            set { _Jb8_Name = value; }
        }

#endregion

        /// <summary>
        /// Starts the replay of the static recording <see cref="Instance"/>.
        /// </summary>
        [System.CodeDom.Compiler.GeneratedCode("Ranorex", global::Ranorex.Core.Constants.CodeGenVersion)]
        public static void Start()
        {
            TestModuleRunner.Run(Instance);
        }

        /// <summary>
        /// Performs the playback of actions in this recording.
        /// </summary>
        /// <remarks>You should not call this method directly, instead pass the module
        /// instance to the <see cref="TestModuleRunner.Run(ITestModule)"/> method
        /// that will in turn invoke this method.</remarks>
        [System.CodeDom.Compiler.GeneratedCode("Ranorex", global::Ranorex.Core.Constants.CodeGenVersion)]
        void ITestModule.Run()
        {
            Mouse.DefaultMoveTime = 300;
            Keyboard.DefaultKeyPressTime = 20;
            Delay.SpeedFactor = 1.00;

            Init();

            Report.Log(ReportLevel.Info, "Mouse", "Mouse Right Click item 'SkySuite.Eval_Peak' at Center.", repo.SkySuite.Eval_PeakInfo, new RecordItemIndex(0));
            repo.SkySuite.Eval_Peak.Click(System.Windows.Forms.MouseButtons.Right);
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'SkySuiteEasyJetUAT2.DUplicate' at Center.", repo.SkySuiteEasyJetUAT2.DUplicateInfo, new RecordItemIndex(1));
            repo.SkySuiteEasyJetUAT2.DUplicate.Click();
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'SkySuiteEasyJetUAT2.ToCurrentScenario' at Center.", repo.SkySuiteEasyJetUAT2.ToCurrentScenarioInfo, new RecordItemIndex(2));
            repo.SkySuiteEasyJetUAT2.ToCurrentScenario.Click();
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating Exists on item 'DuplicateJobToCurrentScenario'.", repo.DuplicateJobToCurrentScenario.SelfInfo, new RecordItemIndex(3));
            Validate.Exists(repo.DuplicateJobToCurrentScenario.SelfInfo);
            Delay.Milliseconds(0);
            
            Report.Screenshot(ReportLevel.Info, "User", "", repo.DuplicateJobToCurrentScenario.Self, false, new RecordItemIndex(4));
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'DuplicateJobToCurrentScenario.Job_Name' at CenterRight.", repo.DuplicateJobToCurrentScenario.Job_NameInfo, new RecordItemIndex(5));
            repo.DuplicateJobToCurrentScenario.Job_Name.Click(Location.CenterRight);
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence '{Back 70}' with focus on 'DuplicateJobToCurrentScenario.Job_Name'.", repo.DuplicateJobToCurrentScenario.Job_NameInfo, new RecordItemIndex(6));
            repo.DuplicateJobToCurrentScenario.Job_Name.PressKeys("{Back 70}");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence from variable '$Jb8_Name' with focus on 'DuplicateJobToCurrentScenario.Job_Name'.", repo.DuplicateJobToCurrentScenario.Job_NameInfo, new RecordItemIndex(7));
            repo.DuplicateJobToCurrentScenario.Job_Name.PressKeys(Jb8_Name);
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'DuplicateJobToCurrentScenario.Create' at Center.", repo.DuplicateJobToCurrentScenario.CreateInfo, new RecordItemIndex(8));
            repo.DuplicateJobToCurrentScenario.Create.Click();
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Delay", "Waiting for 10s.", new RecordItemIndex(9));
            Delay.Duration(10000, false);
            
            Report.Screenshot(ReportLevel.Info, "User", "", repo.JobWindow.Self, false, new RecordItemIndex(10));
            
            Report.Log(ReportLevel.Info, "Validation", "Validating Exists on item 'JobWindow'.", repo.JobWindow.SelfInfo, new RecordItemIndex(11));
            Validate.Exists(repo.JobWindow.SelfInfo);
            Delay.Milliseconds(0);
            
        }

#region Image Feature Data
#endregion
    }
#pragma warning restore 0436
}