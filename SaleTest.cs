using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Sale
{
    [TestClass]
    public class SaleTest
    {
        [TestMethod]
        public void ShouldDisplayMilkPrice()
        {
            // arrange
            FakeDisplay display = new FakeDisplay();
            Sale sale = new Sale(display);

            // act
            sale.AddBarcode("1");

            // assert
            Assert.AreEqual(display.lastShowedItem(), "Milk $3.99");
        }
    }
}
