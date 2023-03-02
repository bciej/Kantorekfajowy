using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kantorekfajowy
{
    public class Przelicznik
    {
        public static double przelicz(Waluta waluta1, Waluta waluta2, double kwota)
        {
            return (waluta1.getPrice() * kwota) / waluta2.getPrice();
        }
    }
}
