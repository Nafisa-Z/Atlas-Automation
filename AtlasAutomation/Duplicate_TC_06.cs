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
    ///The Duplicate_TC_06 recording.
    /// </summary>
    [TestModule("c39b839d-8380-4431-adf3-b5133c3de041", ModuleType.Recording, 1)]
    public partial class Duplicate_TC_06 : ITestModule
    {
        /// <summary>
        /// Holds an instance of the AtlasAutomationRepository repository.
        /// </summary>
        public static AtlasAutomationRepository repo = AtlasAutomationRepository.Instance;

        static Duplicate_TC_06 instance = new Duplicate_TC_06();

        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public Duplicate_TC_06()
        {
            Jb9_Name = "Adapt_Low";
        }

        /// <summary>
        /// Gets a static instance of this recording.
        /// </summary>
        public static Duplicate_TC_06 Instance
        {
            get { return instance; }
        }

#region Variables

        string _Jb9_Name;

        /// <summary>
        /// Gets or sets the value of variable Jb9_Name.
        /// </summary>
        [TestVariable("ed3ef62b-d781-422b-a200-0e7ac7605b69")]
        public string Jb9_Name
        {
            get { return _Jb9_Name; }
            set { _Jb9_Name = value; }
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

            Report.Log(ReportLevel.Info, "Mouse", "Mouse Right Click item 'SkySuite.Eval_med_3' at Center.", repo.SkySuite.Eval_med_3Info, new RecordItemIndex(0));
            repo.SkySuite.Eval_med_3.Click(System.Windows.Forms.MouseButtons.Right);
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Delay", "Waiting for 1s.", new RecordItemIndex(1));
            Delay.Duration(1000, false);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'SkySuiteEasyJetUAT2.DUplicate' at Center.", repo.SkySuiteEasyJetUAT2.DUplicateInfo, new RecordItemIndex(2));
            repo.SkySuiteEasyJetUAT2.DUplicate.Click();
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'SkySuiteEasyJetUAT2.ToCurrentScenario' at Center.", repo.SkySuiteEasyJetUAT2.ToCurrentScenarioInfo, new RecordItemIndex(3));
            repo.SkySuiteEasyJetUAT2.ToCurrentScenario.Click();
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating Exists on item 'DuplicateJobToCurrentScenario'.", repo.DuplicateJobToCurrentScenario.SelfInfo, new RecordItemIndex(4));
            Validate.Exists(repo.DuplicateJobToCurrentScenario.SelfInfo);
            Delay.Milliseconds(0);
            
            Report.Screenshot(ReportLevel.Info, "User", "", repo.DuplicateJobToCurrentScenario.Self, false, new RecordItemIndex(5));
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'DuplicateJobToCurrentScenario.Job_Name' at CenterRight.", repo.DuplicateJobToCurrentScenario.Job_NameInfo, new RecordItemIndex(6));
            repo.DuplicateJobToCurrentScenario.Job_Name.Click(Location.CenterRight);
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence '{Back 24}' with focus on 'DuplicateJobToCurrentScenario.Job_Name'.", repo.DuplicateJobToCurrentScenario.Job_NameInfo, new RecordItemIndex(7));
            repo.DuplicateJobToCurrentScenario.Job_Name.PressKeys("{Back 24}");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence from variable '$Jb9_Name' with focus on 'DuplicateJobToCurrentScenario.Job_Name'.", repo.DuplicateJobToCurrentScenario.Job_NameInfo, new RecordItemIndex(8));
            repo.DuplicateJobToCurrentScenario.Job_Name.PressKeys(Jb9_Name);
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'DuplicateJobToCurrentScenario.Create' at Center.", repo.DuplicateJobToCurrentScenario.CreateInfo, new RecordItemIndex(9));
            repo.DuplicateJobToCurrentScenario.Create.Click();
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Delay", "Waiting for 10s.", new RecordItemIndex(10));
            Delay.Duration(10000, false);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating Exists on item 'JobWindow'.", repo.JobWindow.SelfInfo, new RecordItemIndex(11));
            Validate.Exists(repo.JobWindow.SelfInfo);
            Delay.Milliseconds(0);
            
            Report.Screenshot(ReportLevel.Info, "User", "", repo.JobWindow.Self, false, new RecordItemIndex(12));
            
        }

#region Image Feature Data
#endregion
    }
#pragma warning restore 0436
}