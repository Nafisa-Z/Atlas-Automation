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

namespace UAT2.Modules
{
#pragma warning disable 0436 //(CS0436) The type 'type' in 'assembly' conflicts with the imported type 'type2' in 'assembly'. Using the type defined in 'assembly'.
    /// <summary>
    ///The DuplicateTC_04 recording.
    /// </summary>
    [TestModule("e864cf89-d470-4205-9ac6-45d28ddd8a7a", ModuleType.Recording, 1)]
    public partial class DuplicateTC_04 : ITestModule
    {
        /// <summary>
        /// Holds an instance of the global::UAT2.UAT2Repository repository.
        /// </summary>
        public static global::UAT2.UAT2Repository repo = global::UAT2.UAT2Repository.Instance;

        static DuplicateTC_04 instance = new DuplicateTC_04();

        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public DuplicateTC_04()
        {
        }

        /// <summary>
        /// Gets a static instance of this recording.
        /// </summary>
        public static DuplicateTC_04 Instance
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

            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'SkySuite' at Center.", repo.SkySuite.SelfInfo, new RecordItemIndex(0));
            repo.SkySuite.Self.Click();
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'SkySuite.evaluationJobs' at Center.", repo.SkySuite.evaluationJobsInfo, new RecordItemIndex(1));
            repo.SkySuite.evaluationJobs.Click();
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Right Click item 'SkySuite.evalMed' at Center.", repo.SkySuite.evalMedInfo, new RecordItemIndex(2));
            repo.SkySuite.evalMed.Click(System.Windows.Forms.MouseButtons.Right);
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'SkySuiteEasyJetUAT2.DUplicate' at Center.", repo.SkySuiteEasyJetUAT2.DUplicateInfo, new RecordItemIndex(3));
            repo.SkySuiteEasyJetUAT2.DUplicate.Click();
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'SkySuiteEasyJetUAT2.ToCurrentScenario' at Center.", repo.SkySuiteEasyJetUAT2.ToCurrentScenarioInfo, new RecordItemIndex(4));
            repo.SkySuiteEasyJetUAT2.ToCurrentScenario.Click();
            Delay.Milliseconds(0);
            
        }

#region Image Feature Data
#endregion
    }
#pragma warning restore 0436
}
