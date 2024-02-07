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
    ///The CreateandCancel recording.
    /// </summary>
    [TestModule("189fdd04-1309-4676-938f-7e91617269fa", ModuleType.Recording, 1)]
    public partial class CreateandCancel : ITestModule
    {
        /// <summary>
        /// Holds an instance of the AtlasAutomationRepository repository.
        /// </summary>
        public static AtlasAutomationRepository repo = AtlasAutomationRepository.Instance;

        static CreateandCancel instance = new CreateandCancel();

        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public CreateandCancel()
        {
            scName = "Demo_IB";
            jb1Name = "Demo_IB";
            datesMed = "18Sep2023 to 24Sep2023";
        }

        /// <summary>
        /// Gets a static instance of this recording.
        /// </summary>
        public static CreateandCancel Instance
        {
            get { return instance; }
        }

#region Variables

        string _scName;

        /// <summary>
        /// Gets or sets the value of variable scName.
        /// </summary>
        [TestVariable("32465b30-3651-46fb-9e2c-66821e4f4c2f")]
        public string scName
        {
            get { return _scName; }
            set { _scName = value; }
        }

        string _jb1Name;

        /// <summary>
        /// Gets or sets the value of variable jb1Name.
        /// </summary>
        [TestVariable("fd8e4a7f-da2b-4019-957a-6b60ebc3caa1")]
        public string jb1Name
        {
            get { return _jb1Name; }
            set { _jb1Name = value; }
        }

        string _datesMed;

        /// <summary>
        /// Gets or sets the value of variable datesMed.
        /// </summary>
        [TestVariable("9b0fd9d2-ca6f-4b51-9701-ac8be23b9f4e")]
        public string datesMed
        {
            get { return _datesMed; }
            set { _datesMed = value; }
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

            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'NewJob.JobNameTextBox' at Center.", repo.NewJob.JobNameTextBoxInfo, new RecordItemIndex(0));
            repo.NewJob.JobNameTextBox.Click();
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence from variable '$jb1Name' with focus on 'NewJob.JobNameTextBox'.", repo.NewJob.JobNameTextBoxInfo, new RecordItemIndex(1));
            repo.NewJob.JobNameTextBox.PressKeys(jb1Name);
            Delay.Milliseconds(20);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'NewJob.JobTypeToggle' at Center.", repo.NewJob.JobTypeToggleInfo, new RecordItemIndex(2));
            repo.NewJob.JobTypeToggle.Click();
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'SkySuiteEasyJetUAT2.Forecast' at Center.", repo.SkySuiteEasyJetUAT2.ForecastInfo, new RecordItemIndex(3));
            repo.SkySuiteEasyJetUAT2.Forecast.Click();
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'NewJob.JobDates' at Center.", repo.NewJob.JobDatesInfo, new RecordItemIndex(4));
            repo.NewJob.JobDates.Click();
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence from variable '$datesMed' with focus on 'NewJob.JobDates'.", repo.NewJob.JobDatesInfo, new RecordItemIndex(5));
            repo.NewJob.JobDates.PressKeys(datesMed);
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'NewJob.Cancel' at Center.", repo.NewJob.CancelInfo, new RecordItemIndex(6));
            repo.NewJob.Cancel.Click();
            Delay.Milliseconds(0);
            
        }

#region Image Feature Data
#endregion
    }
#pragma warning restore 0436
}