using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OrdersVehicilesForm
{
    class VehicileBusClass : VehicileClass
    {
/*        public int vehicileID;
        public string vehicileMake;
        public string vehicileType;
        public int vehicileYear;
        public int vehicileMiles;
        public int vehicileValueNew;
        public string vehicileAvailability;
*/

        //class specific properties
        int BusNumberOfPassengers = 0;
        int BusNumberOfDoors = 0;

        public int CalculateBusSaleValue(int vehicileYear, int retailValueNew)
        {
            DateTime now = DateTime.Now;
            int currentYear = now.Year;

            int vehicileAge = currentYear - vehicileYear;

            //Calculate 5% of newretail value
            //Multiply by year age
            //Subtractnfrom new retail value

            double value5percent = retailValueNew * 0.05;

            double moneyOff = vehicileAge * value5percent;

            double saleValue = retailValueNew - moneyOff;

            return Convert.ToInt32(saleValue);

        }

        public int CalculateBusLeaseValue(int vehicileYear, int retailValueNew)
        {
            double monthlyLease = retailValueNew * 0.01;

            return Convert.ToInt32(monthlyLease);
        }

        public int CalculateBusRentalValue(int vehicileYear, int retailValueNew)
        {
            double daylyRental = retailValueNew * 0.001;

            return Convert.ToInt32(daylyRental);
        }

    }
}
