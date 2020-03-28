using System;
using System.IO;
using System.Linq;
using NUnit.Framework;
using Xamarin.UITest;
using Xamarin.UITest.Queries;
using TestPrism.UITests.Pages;

namespace TestPrism.UITests.Tests
{
    public class MainPageTests : AbstractSetup
    {
        public MainPageTests(Platform platform)
            : base(platform)
        {
        }

        [Test]
        public void DidAppStart()
        {
            var mainPage = new MainPage();
            mainPage.AppStarted();
        }
    }
}
