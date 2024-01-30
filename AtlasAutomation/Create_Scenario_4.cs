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
    ///The Create_Scenario_4 recording.
    /// </summary>
    [TestModule("30701a83-5693-489b-b9f5-b3336727caf4", ModuleType.Recording, 1)]
    public partial class Create_Scenario_4 : ITestModule
    {
        /// <summary>
        /// Holds an instance of the AtlasAutomationRepository repository.
        /// </summary>
        public static AtlasAutomationRepository repo = AtlasAutomationRepository.Instance;

        static Create_Scenario_4 instance = new Create_Scenario_4();

        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public Create_Scenario_4()
        {
            ScNameEval = "Eval_Jobs";
            Jb4_Name = "TC_04";
            Dates_Med = "18Sep2023 to 24Sep2023";
            Workspace_Name = "Atlas_Cycle1";
        }

        /// <summary>
        /// Gets a static instance of this recording.
        /// </summary>
        public static Create_Scenario_4 Instance
        {
            get { return instance; }
        }

#region Variables

        string _ScNameEval;

        /// <summary>
        /// Gets or sets the value of variable ScNameEval.
        /// </summary>
        [TestVariable("94b96abf-dc8a-435a-a28e-d700655b8eee")]
        public string ScNameEval
        {
            get { return _ScNameEval; }
            set { _ScNameEval = value; }
        }

        string _Dates_Med;

        /// <summary>
        /// Gets or sets the value of variable Dates_Med.
        /// </summary>
        [TestVariable("e6ea2878-77c9-4d66-9021-2d1ec622fb08")]
        public string Dates_Med
        {
            get { return _Dates_Med; }
            set { _Dates_Med = value; }
        }

        /// <summary>
        /// Gets or sets the value of variable Workspace_Name.
        /// </summary>
        [TestVariable("3013f374-57e1-4896-b74b-5663b612e152")]
        public string Workspace_Name
        {
            get { return repo.Workspace_Name; }
            set { repo.Workspace_Name = value; }
        }

        /// <summary>
        /// Gets or sets the value of variable Jb4_Name.
        /// </summary>
        [TestVariable("146de5d7-b8e2-4d67-a246-24dd56921b4f")]
        public string Jb4_Name
        {
            get { return repo.Jb4_Name; }
            set { repo.Jb4_Name = value; }
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

            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'SkySuite' at 747;26.", repo.SkySuite.SelfInfo, new RecordItemIndex(0));
            repo.SkySuite.Self.Click("747;26");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Right Click item 'SkySuite.Workspace' at 156;15.", repo.SkySuite.WorkspaceInfo, new RecordItemIndex(1));
            repo.SkySuite.Workspace.Click(System.Windows.Forms.MouseButtons.Right, "156;15");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Delay", "Waiting for 1s.", new RecordItemIndex(2));
            Delay.Duration(1000, false);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'SkySuiteEasyJetUAT2.NewScenario1' at 60;10.", repo.SkySuiteEasyJetUAT2.NewScenario1Info, new RecordItemIndex(3));
            repo.SkySuiteEasyJetUAT2.NewScenario1.Click("60;10");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating Exists on item 'NewScenario'.", repo.NewScenario.SelfInfo, new RecordItemIndex(4));
            Validate.Exists(repo.NewScenario.SelfInfo);
            Delay.Milliseconds(0);
            
            Report.Screenshot(ReportLevel.Info, "User", "", repo.NewScenario.Self, false, new RecordItemIndex(5));
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'NewScenario' at 369;21.", repo.NewScenario.SelfInfo, new RecordItemIndex(6));
            repo.NewScenario.Self.Click("369;21");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'NewScenario.SomeContainer.Scenario_Name' at CenterRight.", repo.NewScenario.SomeContainer.Scenario_NameInfo, new RecordItemIndex(7));
            repo.NewScenario.SomeContainer.Scenario_Name.Click(Location.CenterRight);
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence from variable '$ScNameEval' with focus on 'NewScenario.SomeContainer.Scenario_Name'.", repo.NewScenario.SomeContainer.Scenario_NameInfo, new RecordItemIndex(8));
            repo.NewScenario.SomeContainer.Scenario_Name.PressKeys(ScNameEval);
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'NewScenario.Job_Name' at CenterRight.", repo.NewScenario.Job_NameInfo, new RecordItemIndex(9));
            repo.NewScenario.Job_Name.Click(Location.CenterRight);
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence from variable '$Jb4_Name' with focus on 'NewScenario.Job_Name'.", repo.NewScenario.Job_NameInfo, new RecordItemIndex(10));
            repo.NewScenario.Job_Name.PressKeys(Jb4_Name);
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'NewScenario.SomeContainer.Job_Type_Toggle' at 10;16.", repo.NewScenario.SomeContainer.Job_Type_ToggleInfo, new RecordItemIndex(11));
            repo.NewScenario.SomeContainer.Job_Type_Toggle.Click("10;16");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'SkySuiteEasyJetUAT2.Optimization' at 82;11.", repo.SkySuiteEasyJetUAT2.OptimizationInfo, new RecordItemIndex(12));
            repo.SkySuiteEasyJetUAT2.Optimization.Click("82;11");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'NewScenario.SomeContainer.Job_Description' at 10;13.", repo.NewScenario.SomeContainer.Job_DescriptionInfo, new RecordItemIndex(13));
            repo.NewScenario.SomeContainer.Job_Description.Click("10;13");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'SkySuiteEasyJetUAT2.Evaluation' at 264;14.", repo.SkySuiteEasyJetUAT2.EvaluationInfo, new RecordItemIndex(14));
            repo.SkySuiteEasyJetUAT2.Evaluation.Click("264;14");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'NewScenario.SomeContainer.Job_Dates' at 131;7.", repo.NewScenario.SomeContainer.Job_DatesInfo, new RecordItemIndex(15));
            repo.NewScenario.SomeContainer.Job_Dates.Click("131;7");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence from variable '$Dates_Med' with focus on 'NewScenario.SomeContainer.Job_Dates'.", repo.NewScenario.SomeContainer.Job_DatesInfo, new RecordItemIndex(16));
            repo.NewScenario.SomeContainer.Job_Dates.PressKeys(Dates_Med);
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'NewScenario.Create' at 49;8.", repo.NewScenario.CreateInfo, new RecordItemIndex(17));
            repo.NewScenario.Create.Click("49;8");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'JobWindow' at 197;704.", repo.JobWindow.SelfInfo, new RecordItemIndex(18));
            repo.JobWindow.Self.Click("197;704");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Delay", "Waiting for 10s.", new RecordItemIndex(19));
            Delay.Duration(10000, false);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating Exists on item 'JobWindow'.", repo.JobWindow.SelfInfo, new RecordItemIndex(20));
            Validate.Exists(repo.JobWindow.SelfInfo);
            Delay.Milliseconds(0);
            
            Report.Screenshot(ReportLevel.Info, "User", "", repo.JobWindow.Self, false, new RecordItemIndex(21));
            
        }

#region Image Feature Data
#endregion
    }
#pragma warning restore 0436
}