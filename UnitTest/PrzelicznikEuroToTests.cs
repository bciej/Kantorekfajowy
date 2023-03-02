using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace Kantorekfajowy.UnitTest
{
    public class PrzelicznikEuroToTests
    {

        [Test]
        public void EuroNaUSD()
        {
            // Arrange
            Waluta waluta1 = new Waluta("EUR", 4.67);
            Waluta waluta2 = new Waluta("USD", 3.95);
            double kwota = 1;

            // Act
            double result = Przelicznik.przelicz(waluta1, waluta2, kwota);

            // Assert
            Assert.AreEqual(1.18, result, 0.01);
        }

        [Test]
        public void EuroNaFunt()
        {
            // Arrange
            Waluta waluta1 = new Waluta("EUR", 4.67);
            Waluta waluta2 = new Waluta("Funt", 5.30);
            double kwota = 1;

            // Act
            double result = Przelicznik.przelicz(waluta1, waluta2, kwota);

            // Assert
            Assert.AreEqual(0.88, result, 0.01);
        }

        [Test]
        public void EuroNaYen()
        {
            // Arrange
            Waluta waluta1 = new Waluta("EUR", 4.67);
            Waluta waluta2 = new Waluta("Yen", 0.032);
            double kwota = 1;

            // Act
            double result = Przelicznik.przelicz(waluta1, waluta2, kwota);

            // Assert
            Assert.AreEqual(145.93, result, 0.01);
        }
    }
}
