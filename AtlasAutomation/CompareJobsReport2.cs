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
    ///The CompareJobsReport2 recording.
    /// </summary>
    [TestModule("1ffbf579-462f-4848-a9c9-165fcf805f40", ModuleType.Recording, 1)]
    public partial class CompareJobsReport2 : ITestModule
    {
        /// <summary>
        /// Holds an instance of the AtlasAutomationRepository repository.
        /// </summary>
        public static AtlasAutomationRepository repo = AtlasAutomationRepository.Instance;

        static CompareJobsReport2 instance = new CompareJobsReport2();

        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public CompareJobsReport2()
        {
        }

        /// <summary>
        /// Gets a static instance of this recording.
        /// </summary>
        public static CompareJobsReport2 Instance
        {
            get { return instance; }
        }

#region Variables

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

            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'JobWindow.Report_Tab.Compare_Jobs.Compare_Button' at 4;17.", repo.JobWindow.Report_Tab.Compare_Jobs.Compare_ButtonInfo, new RecordItemIndex(0));
            repo.JobWindow.Report_Tab.Compare_Jobs.Compare_Button.Click("4;17");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'JobWindow.Report_Tab.Compare_Jobs.ToggleButton' at Center.", repo.JobWindow.Report_Tab.Compare_Jobs.ToggleButtonInfo, new RecordItemIndex(1));
            repo.JobWindow.Report_Tab.Compare_Jobs.ToggleButton.Click();
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'SkySuiteEasyJetUAT2.DemoMed' at Center.", repo.SkySuiteEasyJetUAT2.DemoMedInfo, new RecordItemIndex(2));
            repo.SkySuiteEasyJetUAT2.DemoMed.Click();
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'JobWindow.Report_Tab.Compare_Jobs.CheckBoxNet' at Center.", repo.JobWindow.Report_Tab.Compare_Jobs.CheckBoxNetInfo, new RecordItemIndex(3));
            repo.JobWindow.Report_Tab.Compare_Jobs.CheckBoxNet.Click();
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'JobWindow.Report_Tab.Compare_Jobs.Apply' at Center.", repo.JobWindow.Report_Tab.Compare_Jobs.ApplyInfo, new RecordItemIndex(4));
            repo.JobWindow.Report_Tab.Compare_Jobs.Apply.Click();
            Delay.Milliseconds(0);
            
        }

#region Image Feature Data
#endregion
    }
#pragma warning restore 0436
}