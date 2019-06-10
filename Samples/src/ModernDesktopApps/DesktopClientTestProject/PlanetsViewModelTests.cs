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
            viewModel.PlanetNames.Clear();

            Assert.AreEqual(0, viewModel.PlanetNames.Count);

            viewModel.Refresh();

            Assert.IsTrue(viewModel.PlanetNames.Count > 0);
        }
    }
}
