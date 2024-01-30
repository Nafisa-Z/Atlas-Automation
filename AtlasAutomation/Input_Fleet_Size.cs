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
    ///The Input_Fleet_Size recording.
    /// </summary>
    [TestModule("7e89f619-1458-42f2-88ee-9acd2e26cab1", ModuleType.Recording, 1)]
    public partial class Input_Fleet_Size : ITestModule
    {
        /// <summary>
        /// Holds an instance of the AtlasAutomationRepository repository.
        /// </summary>
        public static AtlasAutomationRepository repo = AtlasAutomationRepository.Instance;

        static Input_Fleet_Size instance = new Input_Fleet_Size();

        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public Input_Fleet_Size()
        {
        }

        /// <summary>
        /// Gets a static instance of this recording.
        /// </summary>
        public static Input_Fleet_Size Instance
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

            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'JobWindow.Job_Inputs.JobInputsBusyIndicator' at 678;42.", repo.JobWindow.Job_Inputs.JobInputsBusyIndicatorInfo, new RecordItemIndex(0));
            repo.JobWindow.Job_Inputs.JobInputsBusyIndicator.Click("678;42");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'JobWindow.TC_05.Aircraft_Expand' at 22;22.", repo.JobWindow.TC_05.Aircraft_ExpandInfo, new RecordItemIndex(1));
            repo.JobWindow.TC_05.Aircraft_Expand.Click("22;22");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Delay", "Waiting for 1s.", new RecordItemIndex(2));
            Delay.Duration(1000, false);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Down item 'JobWindow.TC_05.Fleet_size_Toggle' at 15;20.", repo.JobWindow.TC_05.Fleet_size_ToggleInfo, new RecordItemIndex(3));
            repo.JobWindow.TC_05.Fleet_size_Toggle.MoveTo("15;20");
            Mouse.ButtonDown(System.Windows.Forms.MouseButtons.Left);
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Delay", "Waiting for 1s.", new RecordItemIndex(4));
            Delay.Duration(1000, false);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'SkySuiteEasyJetUAT2.MEDFleetSize' at Center.", repo.SkySuiteEasyJetUAT2.MEDFleetSizeInfo, new RecordItemIndex(5));
            repo.SkySuiteEasyJetUAT2.MEDFleetSize.Click();
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Delay", "Waiting for 1s.", new RecordItemIndex(6));
            Delay.Duration(1000, false);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'JobWindow.TC_05.Aircraft_Expand' at 22;22.", repo.JobWindow.TC_05.Aircraft_ExpandInfo, new RecordItemIndex(7));
            repo.JobWindow.TC_05.Aircraft_Expand.Click("22;22");
            Delay.Milliseconds(0);
            
        }

#region Image Feature Data
#endregion
    }
#pragma warning restore 0436
}