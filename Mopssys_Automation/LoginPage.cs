using System;
using System.Threading;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace Mopssys_Automation
{
	
	public class LoginPage
	{
		
		public IWebDriver driver;

		public void Login(string url, string username, string password)
		{
			driver.Manage().Window.Maximize();
			driver.Url =url;
			Thread.Sleep(10000);
			driver.FindElement(By.Id("username")).SendKeys(username);
			driver.FindElement(By.Id("password")).SendKeys(password);
			driver.FindElement(By.CssSelector("body > div.container.page-login > div:nth-child(3) > div:nth-child(1) > div > div.panel-body > form > fieldset > div:nth-child(4) > button")).Click();
			Thread.Sleep(10000);
			string welcomeText = driver.FindElement(By.CssSelector("#dashboardHeader")).Text;
            Assert.AreEqual("Tehseen dashboard", welcomeText );
            driver.Close();
		}
	}

	

}
