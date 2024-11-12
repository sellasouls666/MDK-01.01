using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboratory_work_2
{
    public class SalesReport
    {
        private List<SalesRealization> salesRealizations;
        
        public SalesReport()
        {
            salesRealizations = new List<SalesRealization>();
        }

        public void AddSale(SalesRealization realization)
        {
            salesRealizations.Add(realization);
        }

    }
}
