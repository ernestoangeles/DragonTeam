using System;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
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
            driver = new ChromeDriver(@"C:\Driver\");
        }

        [AfterFeature]
        public static void AfterFeature()
        {
            driver.Quit();
        }

        [Given(@"i enter the game")]
        public void GivenIEnterTheGame()
        {
            driver.Url = "http://localhost/CodeFighter/Home/Index";
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

        [Then(@"player two life is ""(.*)""")]
        public void ThenPlayerTwoLifeIs(int player2lifeExpected)
        {
            var currentlifePlayer2 = driver.FindElement(By.Id("life-player2")).Text;
            Assert.AreEqual(player2lifeExpected, currentlifePlayer2);
        }

        [Then(@"player one life is ""(.*)""")]
        public void ThenPlayerOneLifeIs(int player1lifeExpected)
        {
            var currentlifePlayer1 = driver.FindElement(By.Id("life-player1")).Text;
            Assert.AreEqual(player1lifeExpected, currentlifePlayer1);
        }

        [Then(@"i should see ""(.*)""")]
        public void ThenIShouldSee(string expectedMessage)
        {
            var winMessage = driver.FindElement(By.Id("winner-message")).Text;
            Assert.AreEqual(expectedMessage, winMessage);
        }

        [Then(@"show ""(.*)"" and ""(.*)""")]
        public void ThenShowAnd(string player1Expected, string player2Expected)
        {
            var currentPlayer1 = driver.FindElement(By.Id("current-player1")).Text;
            var currentPlayer2 = driver.FindElement(By.Id("current-player2")).Text;

            Assert.AreEqual(player1Expected, currentPlayer1);
            Assert.AreEqual(player2Expected, currentPlayer2);
        }

    }
}

