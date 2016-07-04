using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TechTalk.SpecFlow;

namespace CodeFighter.Features.StepsDefinitions
{
    [Binding]
    public sealed class CommonSteps
        {
            static IWebDriver driver;

            [BeforeFeature]
            public static void BeforeFeature()
            {
                driver = new FirefoxDriver();
                //driver = new ChromeDriver(@"C:\Proyectos\pponce\chromedriver_win32");
            }

            [AfterFeature]
            public static void AfterFeature()
            {
                driver.Quit();
            }

            [Given(@"i enter the game")]
            public void GivenIEnterTheGame()
            {
                driver.Url = "http://localhost:1694/";
            }

        [When(@"i enter player one ""(.*)""")]
        public void WhenIEnterPlayerOne(string player1)
        {
            driver.FindElement(By.Id("player1")).SendKeys(player1);
        }

        [When(@"i enter player two ""(.*)""")]
        public void WhenIEnterPlayerTwo(string player2)
        {
            driver.FindElement(By.Id("player2")).SendKeys(player2);
        }

        [When(@"i click ""(.*)""")]
        public void WhenIClick(string boton)
        {
            driver.FindElement(By.Id(boton)).Click();
        }

        [Then(@"i should see ""(.*)"" and ""(.*)""")]
        public void ThenIShouldSeeAnd(string player1Expected, string player2Expected)
        {
            var currentPlayer1 = driver.FindElement(By.Id("current-player1")).Text;
            var currentPlayer2 = driver.FindElement(By.Id("current-player2")).Text;

            Assert.AreEqual(player1Expected, currentPlayer1);
            Assert.AreEqual(player2Expected, currentPlayer2);
        }
    }
}

