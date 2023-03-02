using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace Kantorekfajowy.UnitTest
{
    internal class PrzelicznikYenToTests
    {
        [Test]
        public void YenToUSD()
        {
            // Arrange
            Waluta waluta1 = new Waluta("Yen", 0.032);
            Waluta waluta2 = new Waluta("USD", 3.95);
            double kwota = 1;

            // Act
            double result = Przelicznik.przelicz(waluta1, waluta2, kwota);

            // Assert
            Assert.AreEqual(0.008, result, 0.001);
        }

        [Test]
        public void YenToEUR()
        {
            // Arrange
            Waluta waluta1 = new Waluta("Yen", 0.032);
            Waluta waluta2 = new Waluta("USD", 4.70);
            double kwota = 1;

            // Act
            double result = Przelicznik.przelicz(waluta1, waluta2, kwota);

            // Assert
            Assert.AreEqual(0.006, result, 0.001);
        }

        [Test]
        public void YenToFunt()
        {
            // Arrange
            Waluta waluta1 = new Waluta("Yen", 0.032);
            Waluta waluta2 = new Waluta("USD", 5.30);
            double kwota = 1;

            // Act
            double result = Przelicznik.przelicz(waluta1, waluta2, kwota);

            // Assert
            Assert.AreEqual(0.006, result, 0.001);
        }
    }
}