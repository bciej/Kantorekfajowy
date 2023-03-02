using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace Kantorekfajowy.UnitTest
{
    internal class PrzelicznikFuntToTests
    {
        [Test]
        public void FuntToUSD()
        {
            // Arrange
            Waluta waluta1 = new Waluta("Funt", 5.3);
            Waluta waluta2 = new Waluta("USD", 3.95);
            double kwota = 1;

            // Act
            double result = Przelicznik.przelicz(waluta1, waluta2, kwota);

            // Assert
            Assert.AreEqual(1.34, result, 0.01);
        }


        [Test]
        public void FuntToYen()
        {
            // Arrange
            Waluta waluta1 = new Waluta("Funt", 5.3);
            Waluta waluta2 = new Waluta("USD", 0.032);
            double kwota = 1;

            // Act
            double result = Przelicznik.przelicz(waluta1, waluta2, kwota);

            // Assert
            Assert.AreEqual(165.62, result, 0.01);
        }


        [Test]
        public void FuntToEuro()
        {
            // Arrange
            Waluta waluta1 = new Waluta("Funt", 5.3);
            Waluta waluta2 = new Waluta("USD", 4.70);
            double kwota = 1;

            // Act
            double result = Przelicznik.przelicz(waluta1, waluta2, kwota);

            // Assert
            Assert.AreEqual(1.12, result, 0.01);
        }
    }
}