using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kantorekfajowy
{
    internal class Waluta
    {
        private int id;
        public int getId()
        {
            return id;
        }
        public void setId(int id)
        {
            this.id = id;
        }

        private string name;
        public string getName()
        {
            return name;
        }

        public void setName(string name)
        {
            this.name = name;
        }
        private string description;

        public string getDescription()
        {
            return description;
        }
        public void setDescription(string description)
        {
            this.description = description;
        }
        private double price;
        public double getPrice()
        {
            return price;
        }
        public void setPrice(double price)
        {
            this.price = price;
        }

        public Waluta()
        {
            id = 0;
            name = "???";
            description = "???";
            price = 0;
        }

        public Waluta(int id, string name, string description, double price)
        {
            this.id = id;
            this.name = name;
            this.description = description;
            this.price = price;
        }
    }
}
