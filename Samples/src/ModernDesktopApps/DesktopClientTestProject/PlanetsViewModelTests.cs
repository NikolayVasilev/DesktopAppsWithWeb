using System;
using DesktopClient.ViewModels;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace DesktopClientTestProject
{
    [TestClass]
    public class PlanetsViewModelTests
    {
        [TestMethod]
        public void TestPlanetsViewModel()
        {
            var viewModel = new PlanetsViewModel(new TestSWAPIRestClient());
            viewModel.ItemsSource.Clear();

            Assert.AreEqual(0, viewModel.ItemsSource.Count);

            viewModel.Refresh();

            Assert.IsTrue(viewModel.ItemsSource.Count > 0);
        }
    }
}
