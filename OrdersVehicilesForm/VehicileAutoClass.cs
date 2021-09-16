using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OrdersVehicilesForm
{
    class VehicileAutoClass : VehicileClass
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
        int AutoNumberOfDoors = 0;

        public int CalculateAutoSaleValue(int vehicileYear, int retailValueNew)
        {
            DateTime now = DateTime.Now;
            int currentYear = now.Year;

            int vehicileAge = currentYear - vehicileYear;

//            MessageBox.Show("vehicileAge = " + vehicileAge);

            //Calculate 5% of newretail value
            //Multiply by year age
            //Subtractnfrom new retail value

//            MessageBox.Show("retailValueNew = " + retailValueNew);

            //          int value5percent = ((5 / 100) * retailValueNew);

            double value5percent = retailValueNew * 0.05;

//            MessageBox.Show("value5percent = " + value5percent);

            double moneyOff = vehicileAge * value5percent;

            double saleValue = retailValueNew - moneyOff;

            return Convert.ToInt32(saleValue);

        }

        public int CalculateAutoLeaseValue(int vehicileYear, int retailValueNew)
        {
            double monthlyLease = retailValueNew * 0.01;

//            MessageBox.Show("monthlyLease = " + monthlyLease);

            return Convert.ToInt32(monthlyLease);
        }

        public int CalculateAutoRentalValue(int vehicileYear, int retailValueNew)
        {
            double daylyRental = retailValueNew * 0.001;

//            MessageBox.Show("Daily Rental = " + daylyRental);

            return Convert.ToInt32(daylyRental);
        }

    }
}
