using System;
using System.IO;
using System.IO.Enumeration;
using System.IO.IsolatedStorage;
using System.Threading;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;

namespace lami;

[TestFixture()]
public class LamiTests
{
    [Test()]
    public void TestCase1()
    {
        
        WebDriver driver = new ChromeDriver();
        driver.Navigate().GoToUrl("https://calc.by/building-calculators/laminate.html");

        var lengthInput=driver.FindElement(By.Id("ln_room_id"));
        lengthInput.Clear();
        lengthInput.SendKeys("500");

        var widthInput=driver.FindElement(By.Id("wd_room_id"));
        widthInput.Clear();
        widthInput.SendKeys("400");

        var lengthLamInput=driver.FindElement(By.Id("ln_lam_id"));
        lengthLamInput.Clear();
        lengthLamInput.SendKeys("2000");

        var selector = driver.FindElement(By.Id("laying_method_laminate"));
        var select = new SelectElement(selector);
        select.SelectByValue("1");
        
        var widthLamInput=driver.FindElement(By.Id("wd_lam_id"));
        widthLamInput.Clear();
        widthLamInput.SendKeys("200");

        Thread.Sleep(1000);
        var radio = driver.FindElement(By.Id("direction-laminate-id1"));
        Thread.Sleep(1000);
        radio.Click();

        var calcButton = driver.FindElement(By.ClassName("calc-btn"));
        calcButton.Click();
        
        Thread.Sleep(2000);
        var closeButton = driver.FindElement(By.ClassName("mfp-close"));
        closeButton.Click();
        Thread.Sleep(2000);

        var lamiAmount = driver.FindElement(By.XPath("//*[@id='t3-content']/div[3]/article/section/div[2]/div[3]/div[2]/div[1]/span")).Text;
        var packsAmount = driver.FindElement(By.XPath("//*[@id='t3-content']/div[3]/article/section/div[2]/div[3]/div[2]/div[2]/span")).Text;
        
        driver.Quit();        
        
        Assert.AreEqual(52, Convert.ToInt32(lamiAmount));
        Assert.AreEqual(7, Convert.ToInt32(packsAmount));
    }
    
    
    [Test()]
    public void TestCase2()
    {
        WebDriver driver = new ChromeDriver();
        driver.Navigate().GoToUrl("https://calc.by/building-calculators/laminate.html");

        var lengthInput=driver.FindElement(By.Id("ln_room_id"));
        lengthInput.Clear();
        lengthInput.SendKeys("500");

        var widthInput=driver.FindElement(By.Id("wd_room_id"));
        widthInput.Clear();
        widthInput.SendKeys("400");

        var lengthLamInput=driver.FindElement(By.Id("ln_lam_id"));
        lengthLamInput.Clear();
        lengthLamInput.SendKeys("2000");

        var selector = driver.FindElement(By.Id("laying_method_laminate"));
        var select = new SelectElement(selector);
        select.SelectByValue("0");
        
        var widthLamInput=driver.FindElement(By.Id("wd_lam_id"));
        widthLamInput.Clear();
        widthLamInput.SendKeys("200");

        var radio = driver.FindElement(By.Id("direction-laminate-id1"));
        Thread.Sleep(2000);
        radio.Click();


        var calcButton = driver.FindElement(By.ClassName("calc-btn"));
        calcButton.Click();
        
        Thread.Sleep(2000);
        var closeButton = driver.FindElement(By.ClassName("mfp-close"));
        closeButton.Click();
        Thread.Sleep(2000);

        var lamiAmount = driver.FindElement(By.XPath("//*[@id='t3-content']/div[3]/article/section/div[2]/div[3]/div[2]/div[1]/span")).Text;
        var packsAmount = driver.FindElement(By.XPath("//*[@id='t3-content']/div[3]/article/section/div[2]/div[3]/div[2]/div[2]/span")).Text;

        
        
        driver.Quit();        
        
        Assert.AreEqual(51, Convert.ToInt32(lamiAmount));
        Assert.AreEqual(7, Convert.ToInt32(packsAmount));
    }
    
    [Test()]
    public void TestCase3()
    {
        WebDriver driver = new ChromeDriver();
        driver.Navigate().GoToUrl("https://calc.by/building-calculators/laminate.html");

        var lengthInput=driver.FindElement(By.Id("ln_room_id"));
        lengthInput.Clear();
        lengthInput.SendKeys("500");

        var widthInput=driver.FindElement(By.Id("wd_room_id"));
        widthInput.Clear();
        widthInput.SendKeys("400");

        var lengthLamInput=driver.FindElement(By.Id("ln_lam_id"));
        lengthLamInput.Clear();
        lengthLamInput.SendKeys("2000");

        var selector = driver.FindElement(By.Id("laying_method_laminate"));
        var select = new SelectElement(selector);
        select.SelectByValue("2");
        
        var widthLamInput=driver.FindElement(By.Id("wd_lam_id"));
        widthLamInput.Clear();
        widthLamInput.SendKeys("200");
        

        
        var radio = driver.FindElement(By.Id("direction-laminate-id1"));
        
        Thread.Sleep(3000);
        radio.Click();


        var calcButton = driver.FindElement(By.ClassName("calc-btn"));
        calcButton.Click();
        
        Thread.Sleep(7000);
        
        var closeButton = driver.FindElement(By.ClassName("mfp-close"));
        closeButton.Click();
        Thread.Sleep(2000);


        var lamiAmount = driver.FindElement(By.XPath("//*[@id='t3-content']/div[3]/article/section/div[2]/div[3]/div[2]/div[1]/span")).Text;
        var packsAmount = driver.FindElement(By.XPath("//*[@id='t3-content']/div[3]/article/section/div[2]/div[3]/div[2]/div[2]/span")).Text;

             
        
        Assert.AreEqual(53, Convert.ToInt32(lamiAmount));
        Assert.AreEqual(7, Convert.ToInt32(packsAmount));
        
        driver.Quit();   
    }
}