using Kantorekfajowy;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace Kantorekfajowy.UnitTest
{
    internal class PrzelicznikUSDToTests
    {
        [Test]
        public void USDToFunt()
        {
            // Arrange
            Waluta waluta1 = new Waluta("USD", 3.95);
            Waluta waluta2 = new Waluta("Funt", 5.3);
            double kwota = 1;

            // Act
            double result = Przelicznik.przelicz(waluta1, waluta2, kwota);

            // Assert
            Assert.AreEqual(0.74, result, 0.01);
        }

        [Test]
        public void USDToEuro()
        {
            // Arrange
            Waluta waluta1 = new Waluta("USD", 3.95);
            Waluta waluta2 = new Waluta("Euro", 4.70);
            double kwota = 1;

            // Act
            double result = Przelicznik.przelicz(waluta1, waluta2, kwota);

            // Assert
            Assert.AreEqual(0.84, result, 0.01);
        }

        [Test]
        public void USDToYen()
        {
            // Arrange
            Waluta waluta1 = new Waluta("USD", 3.95);
            Waluta waluta2 = new Waluta("Yen", 0.032);
            double kwota = 1;

            // Act
            double result = Przelicznik.przelicz(waluta1, waluta2, kwota);

            // Assert
            Assert.AreEqual(123.43, result, 0.01);
        }
    }
}