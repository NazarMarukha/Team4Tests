using System;
using OpenQA.Selenium;

namespace Team4Tests.PageObject
{
    public abstract class ObjectBase
    {
        protected readonly IWebDriver Driver;
        public ObjectBase(IWebDriver driver) => Driver = driver;
    }
}
