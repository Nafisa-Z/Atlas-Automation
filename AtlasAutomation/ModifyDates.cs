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
    ///The ModifyDates recording.
    /// </summary>
    [TestModule("c9419b7f-a91d-4368-b462-c4656a35f714", ModuleType.Recording, 1)]
    public partial class ModifyDates : ITestModule
    {
        /// <summary>
        /// Holds an instance of the AtlasAutomationRepository repository.
        /// </summary>
        public static AtlasAutomationRepository repo = AtlasAutomationRepository.Instance;

        static ModifyDates instance = new ModifyDates();

        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public ModifyDates()
        {
            Dates_Peak = "21Aug2023 to 27Aug2023";
        }

        /// <summary>
        /// Gets a static instance of this recording.
        /// </summary>
        public static ModifyDates Instance
        {
            get { return instance; }
        }

#region Variables

        string _Dates_Peak;

        /// <summary>
        /// Gets or sets the value of variable Dates_Peak.
        /// </summary>
        [TestVariable("b5c7e78e-0a46-4d7d-a5ef-906ec1b4514f")]
        public string Dates_Peak
        {
            get { return _Dates_Peak; }
            set { _Dates_Peak = value; }
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

            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'JobWindow.Job_Details.Planning_Period' at 205;12.", repo.JobWindow.Job_Details.Planning_PeriodInfo, new RecordItemIndex(0));
            repo.JobWindow.Job_Details.Planning_Period.Click("205;12");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence from variable '$Dates_Peak' with focus on 'JobWindow.Job_Details.Planning_Period'.", repo.JobWindow.Job_Details.Planning_PeriodInfo, new RecordItemIndex(1));
            repo.JobWindow.Job_Details.Planning_Period.PressKeys(Dates_Peak);
            Delay.Milliseconds(0);
            
        }

#region Image Feature Data
#endregion
    }
#pragma warning restore 0436
}