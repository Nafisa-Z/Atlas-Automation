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
    ///The ExportJobSetup recording.
    /// </summary>
    [TestModule("af0eb9fd-654e-4dcd-a51c-9e130bbc685d", ModuleType.Recording, 1)]
    public partial class ExportJobSetup : ITestModule
    {
        /// <summary>
        /// Holds an instance of the AtlasAutomationRepository repository.
        /// </summary>
        public static AtlasAutomationRepository repo = AtlasAutomationRepository.Instance;

        static ExportJobSetup instance = new ExportJobSetup();

        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public ExportJobSetup()
        {
        }

        /// <summary>
        /// Gets a static instance of this recording.
        /// </summary>
        public static ExportJobSetup Instance
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

            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'SkySuite.industryJobs' at Center.", repo.SkySuite.industryJobsInfo, new RecordItemIndex(0));
            repo.SkySuite.industryJobs.Click();
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'SkySuite.job1' at Center.", repo.SkySuite.job1Info, new RecordItemIndex(1));
            repo.SkySuite.job1.Click();
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'SkySuite.Export_Button' at Center.", repo.SkySuite.Export_ButtonInfo, new RecordItemIndex(2));
            repo.SkySuite.Export_Button.Click();
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'SkySuiteEasyJetUAT2.ScenariosTabToolbarSetupMenuItem' at Center.", repo.SkySuiteEasyJetUAT2.ScenariosTabToolbarSetupMenuItemInfo, new RecordItemIndex(3));
            repo.SkySuiteEasyJetUAT2.ScenariosTabToolbarSetupMenuItem.Click();
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'ExportJobSetup' at Center.", repo.ExportJobSetup.SelfInfo, new RecordItemIndex(4));
            repo.ExportJobSetup.Self.Click();
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'ExportJobSetup.JobSetupAndParameterFiles' at Center.", repo.ExportJobSetup.JobSetupAndParameterFilesInfo, new RecordItemIndex(5));
            repo.ExportJobSetup.JobSetupAndParameterFiles.Click();
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'ExportJobSetup.DatasetInputFiles' at Center.", repo.ExportJobSetup.DatasetInputFilesInfo, new RecordItemIndex(6));
            repo.ExportJobSetup.DatasetInputFiles.Click();
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'ExportJobSetup.SaveAsZip' at Center.", repo.ExportJobSetup.SaveAsZipInfo, new RecordItemIndex(7));
            repo.ExportJobSetup.SaveAsZip.Click();
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'ExportJobSetup.Export' at Center.", repo.ExportJobSetup.ExportInfo, new RecordItemIndex(8));
            repo.ExportJobSetup.Export.Click();
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Delay", "Waiting for 18m.", new RecordItemIndex(9));
            Delay.Duration(1080000, false);
            
        }

#region Image Feature Data
#endregion
    }
#pragma warning restore 0436
}