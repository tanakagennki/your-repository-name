using System;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace MySeleniumProject
{
    class Program
    {
        static void Main(string[] args)
        {
            // ChromeDriver�̃C���X�^���X���쐬
            IWebDriver driver = new ChromeDriver();

            // Google�̃E�F�u�y�[�W���J��
            driver.Navigate().GoToUrl("https://www.google.com");

            // �I������
            driver.Quit();
        }
    }
}
