using System;
using NUnit.Framework;

namespace Team4Tests.Framework
{
    public static class Settings
    {
        public static readonly string Url = "http://52.177.12.77:8080";
        public static readonly Drivers Driver =
            (Drivers)Enum.Parse(typeof(Drivers), TestContext.Parameters["Driver"] ?? "Chrome");
        public static readonly TimeSpan implicitWait = TimeSpan.FromMilliseconds(3000);
        
    }
}
