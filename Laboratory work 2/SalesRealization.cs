using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboratory_work_2
{
    public struct SalesRealization
    {
        public int quantity;
        public int day;
        public string genre;
    }

    public void AddSale(string genree, int quantityy, int dayy)
    {
        SalesRealization sale = new SalesRealization { genre = genree, day = dayy, quantity = quantityy };
    }
}
