﻿using OpenQA.Selenium.Interactions;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;
using System.Xml.Linq;
using System.Security.Policy;

namespace Framework.Pages
{
    public class TeliaPrekes
    {
        private static string firstProduct = "//*[@class='js-product-compare-image']";
        private static string firstProductTitle = "(//*[@class='col-lg-4 col-sm-6 col-xs-12 ']//*[@class='mobiles-product-card__title js-open-product'])[1]";
        private static string firstProductComparisonCheckbox = "//*[@class='col-lg-4 col-sm-6 col-xs-12 ']//*[text()='Palyginti']";  
        private static string secondProductComparisonCheckbox = "(//*[@class='col-lg-4 col-sm-6 col-xs-12 ']//*[text()='Palyginti'])[2]";
        private static string productComparisonButton = "//*[@class='sticky-navigation-footer__button']";
        private static string openProductComparisonPageButton = "//*[@href='/palyginimas/prekes/mobilieji-telefonai']";
        private static string comparisonModalProduct_1 = "(//*[@class='compare-basket']//*[@class='col-sm-4'])[1]";
        private static string comparisonModalProduct_2 = "(//*[@class='compare-basket']//*[@class='col-sm-4'])[2]";
        private static string comparisonPageProduct_1 = "(//*[@class='product-compare__wrapper']//*[@class='col-lg-3 col-sm-4'])[1]";
        private static string comparisonPageProduct_2 = "(//*[@class='product-compare__wrapper']//*[@class='col-lg-3 col-sm-4'])[2]";
        private static string checkboxApplePhones = "(//*[@id='facet_eshop_brandTabletsPhones']//*[@class='checkbox__content'])[2]";
        private static string showMoreButton = "//*[@id='facet_eshop_brandTabletsPhones']//*[@href='#']";
        private static string resultsData = "//*[@class='col-lg-4 col-sm-6 col-xs-12 ']//*[@class='js-product-compare-image']";

        public static void ClickOnFirstProduct()
        {
            Common.ClickElement(firstProduct);
        }

        public static void SelectFirstProductComparisonCheckbox()
        {
            Common.ClickElement(firstProductComparisonCheckbox);
        }

        public static void SelectSecondProductComparisonCheckbox()
        {
            Common.ClickElement(secondProductComparisonCheckbox);
        }

        public static void ClickOnProductComparisonButton()
        {
            Common.WaitForElementToBeVisible(productComparisonButton);
            Common.ClickElement(productComparisonButton);
        }

        public static string GetTitleFromProductComparisonModal_1()
        {
            string element = Common.GetElementAttribute(comparisonModalProduct_1, "value");
            return element;
        }

        public static string GetTitleFromProductComparisonModal_2()
        {
            string element = Common.GetElementAttribute(comparisonModalProduct_2, "value");
            return element;
        }

        public static void ClickOnButtonToOpenProductComparisonPage()
        {
            Common.WaitForElementToBeVisible(openProductComparisonPageButton);
            Common.ClickElement(openProductComparisonPageButton);
        }

        public static string GetComparedProductTile_1()
        {
            string element = Common.GetElementAttribute(comparisonPageProduct_1, "value");
            return element;
        }

        public static string GetComparedProductTile_2()
        {
            string element = Common.GetElementAttribute(comparisonPageProduct_2, "value");
            return element;
        }

        public static void SelectCheckboxApplePhones()
        {
            new Actions(Driver.driver.Value).ScrollToElement(Common.GetElement(showMoreButton)).Perform();
            Common.ClickElement(checkboxApplePhones);
        }

        public static List<string> GetAllFilteredSearchResults()
        {
            string elementTitleValue = Common.GetElementText(checkboxApplePhones);

            List<string> resultsList = new List<string>();
            List<IWebElement> elements = Common.GetElements(resultsData);
            foreach (IWebElement element in elements)
            {
                if (element.GetAttribute("title").Contains(elementTitleValue))
                {
                    resultsList.Add(element.GetAttribute("title"));
                }
            }
            return resultsList;
        }

        public static List<string> CompareAllFilteredSearchResults()
        {
            string elementTitleValue = Common.GetElementText(checkboxApplePhones);
            List<string> resultsList = new List<string>();

            foreach (string element in GetAllFilteredSearchResults())
            {
                if (element.Contains(elementTitleValue))
                {
                    resultsList.Add(element);
                }
            }
            return resultsList;
        }

        //public static bool GetAllFilteredSearchResults()
        //{
        //    string elementTitleValue = Common.GetElementText(checkboxApplePhones);

        //    List<bool> resultsList = new List<bool>();
        //    List<IWebElement> elements = Common.GetElements(resultsData);
        //    foreach (IWebElement element in elements)
        //    {
        //        if (element.GetAttribute("title").Contains(elementTitleValue))
        //        {
        //            resultsList.Add(element.Enabled);
        //        }  
        //    }
        //    if (resultsList.Contains(true))
        //    {
        //        return true;
        //    }
        //    else
        //    { 
        //        return false;   
        //    }
        //}

        public static string GetProductTitle()
        {
            string elementTitleValue = Common.GetElementText(firstProductTitle);
            return elementTitleValue;
        }
    }
}
