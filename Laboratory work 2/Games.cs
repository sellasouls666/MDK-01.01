using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboratory_work_2
{
    public class Games
    {
        private string Name;
        private double Price;

        public void SetName(string n)
        {
            Name = n;
        }
        
        public string GetName()
        { 
            return Name; 
        }

        public void SetPrice(double p)
        {
            p = Price;
        }

        public Games(string namee, double pricee)
        {
            Name = namee;
            Price = pricee;
        }
    }
}
