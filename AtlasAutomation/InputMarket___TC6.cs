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
    ///The InputMarket___TC6 recording.
    /// </summary>
    [TestModule("105ef789-1764-43ab-a1d8-0aa1e4a18e25", ModuleType.Recording, 1)]
    public partial class InputMarket___TC6 : ITestModule
    {
        /// <summary>
        /// Holds an instance of the AtlasAutomationRepository repository.
        /// </summary>
        public static AtlasAutomationRepository repo = AtlasAutomationRepository.Instance;

        static InputMarket___TC6 instance = new InputMarket___TC6();

        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public InputMarket___TC6()
        {
        }

        /// <summary>
        /// Gets a static instance of this recording.
        /// </summary>
        public static InputMarket___TC6 Instance
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

            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'JobWindow.TC_06.Market_Expand' at 15;21.", repo.JobWindow.TC_06.Market_ExpandInfo, new RecordItemIndex(0));
            repo.JobWindow.TC_06.Market_Expand.Click("15;21");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Delay", "Waiting for 1s.", new RecordItemIndex(1));
            Delay.Duration(1000, false);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'JobWindow.TC_06.Market_Frequency_Toggle' at 16;21.", repo.JobWindow.TC_06.Market_Frequency_ToggleInfo, new RecordItemIndex(2));
            repo.JobWindow.TC_06.Market_Frequency_Toggle.Click("16;21");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Delay", "Waiting for 1s.", new RecordItemIndex(3));
            Delay.Duration(1000, false);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'SkySuiteEasyJetUAT2.LOWMarketFrequencyV1' at 64;18.", repo.SkySuiteEasyJetUAT2.LOWMarketFrequencyV1Info, new RecordItemIndex(4));
            repo.SkySuiteEasyJetUAT2.LOWMarketFrequencyV1.Click("64;18");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Delay", "Waiting for 1s.", new RecordItemIndex(5));
            Delay.Duration(1000, false);
            
        }

#region Image Feature Data
#endregion
    }
#pragma warning restore 0436
}
