using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;
using System.Windows.Input;
using System.Windows.Forms;
using System.Drawing;
using Microsoft.VisualStudio.TestTools.UITesting;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Microsoft.VisualStudio.TestTools.UITest.Extension;
using Keyboard = Microsoft.VisualStudio.TestTools.UITesting.Keyboard;
using ezLogUITest;
using Microsoft.VisualStudio.TestTools.UITesting.WinControls;


namespace UITesting
{
    /// <summary>
    /// Summary description for CodedUITest1
    /// </summary>
    [CodedUITest]
    public class UITest
    {
        private string FILE_PATH = "../../../UITestingExample/bin/debug/UITestingExample.exe";
        private string UI_TESTING_EXAMPLE_TITLE = "UITestingExample";
        private UITestControl _root;

        [TestInitialize()]
        public void Initialize()
        {
            _root = Robot.Initialize(FILE_PATH, UI_TESTING_EXAMPLE_TITLE);
        }

        [TestCleanup()]
        public void Cleanup()
        {
            Robot.CleanUp();
        }

        [TestMethod()]
        [DeploymentItem("UITestingExample.exe")]
        public void TestPickedColor()
        {
            Robot.ClickLabel("colorLabel");
            Robot.ClickColorDialogColor(4, 3); // Blue
            Robot.ClickColorDialogColor(0, 1); // Red
            Robot.ClickColorDialogOk();
            Robot.ClickButton("addButton");
            Robot.AssertLabelColor("colorLabel", Color.Red);
            Robot.AssertCellColor("dataGridView", 0, 1, Color.Red);
        }

        [TestMethod()]
        [DeploymentItem("UITestingExample.exe")]
        public void TestWindowColor()
        {
            string[] menuList = { "showMenuItem", "windowMenuItem" };
            Robot.ClickMenuItem(menuList);
            Robot.AssertFormBackColor("popUpForm", SystemColors.Control);
        }

        [TestMethod()]
        [DeploymentItem("UITestingExample.exe")]
        public void TestPopUpWindowExist()
        {
            string[] menuList = { "showMenuItem", "windowMenuItem" };
            Robot.ClickMenuItem(menuList);
            Robot.AssertWindowExist("popUpForm", true);
            Robot.CloseWindow("popUpForm");
            Robot.AssertWindowExist("popUpForm", false);
        }
    }
}
