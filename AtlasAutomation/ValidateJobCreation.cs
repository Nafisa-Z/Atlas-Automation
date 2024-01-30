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
    ///The ValidateJobCreation recording.
    /// </summary>
    [TestModule("7ae14ca4-6dc8-4812-a2d7-a14496d17a68", ModuleType.Recording, 1)]
    public partial class ValidateJobCreation : ITestModule
    {
        /// <summary>
        /// Holds an instance of the AtlasAutomationRepository repository.
        /// </summary>
        public static AtlasAutomationRepository repo = AtlasAutomationRepository.Instance;

        static ValidateJobCreation instance = new ValidateJobCreation();

        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public ValidateJobCreation()
        {
        }

        /// <summary>
        /// Gets a static instance of this recording.
        /// </summary>
        public static ValidateJobCreation Instance
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

            Report.Log(ReportLevel.Info, "Wait", "Waiting 10s to exist. Associated repository item: 'JobWindow'", repo.JobWindow.SelfInfo, new ActionTimeout(10000), new RecordItemIndex(0));
            repo.JobWindow.SelfInfo.WaitForExists(10000);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating Exists on item 'JobWindow'.", repo.JobWindow.SelfInfo, new RecordItemIndex(1));
            Validate.Exists(repo.JobWindow.SelfInfo);
            Delay.Milliseconds(0);
            
            Report.Screenshot(ReportLevel.Info, "User", "TC_01 Created", repo.JobWindow.Self, false, new RecordItemIndex(2));
            
        }

#region Image Feature Data
#endregion
    }
#pragma warning restore 0436
}