using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrdersVehicilesForm
{
    abstract class VehicileClass     //polymorphism application to vehicile class
    {
        public int vehicileID;
        public string vehicileMake;
        public string vehicileType;
        public int vehicileYear;
        public int vehicileMiles;
        public int vehicileValueNew;
        public string vehicileAvailability;

        //abstract version of functions for polymorphism
        public abstract int CalculateSaleValue(int vehicileYear, int retailValueNew);
        public abstract int CalculateLeaseValue(int vehicileYear, int retailValueNew);
        public abstract int CalculateRentalValue(int vehicileYear, int retailValueNew);
    }
}
