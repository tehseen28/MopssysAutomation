using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace Mopssys_Automation
{
	[TestClass]
	public class Execution
	{
		IWebDriver driver = new ChromeDriver();

		[TestMethod]
		public void LoginTC()
		{
			#region Initializations
			LoginPage loginPage = new LoginPage();
			loginPage.driver = this.driver;
			#endregion

			#region Steps
			loginPage.Login("https://mops4.mopssys.com/", "shamiteh1","mopssys");


            #endregion

        [TestMethod]
        public void InvalidLoginTC()
        {
            #region Initializations
            LoginPage loginPage = new LoginPage();
            loginPage.driver = this.driver;
            #endregion

            #region Steps
            loginPage.Login("https://mops4.mopssys.com/", "shamiteh1", "mopssys");


            #endregion
        }

    }
}
