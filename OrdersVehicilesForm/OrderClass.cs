using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrdersVehicilesForm
{
    class OrderClass
    {

        public int orderID;
        public string orderCustomerName;
        public int orderVehicileID;
        public string orderType;
        public string orderVehicileType;
        public int orderDuration;
        public int orderValue;

        /*
        public void AddCarOrder()
        {
            Car CarOrder = new Car();
        }
        */

        //                public void AssignVehicileOrder()
        //                {
        //                    /*public*/ VehicileAutoClass orderAutoComposition = new VehicileAutoClass();
        //                }

        public VehicileAutoClass orderAutoComposition = new VehicileAutoClass();

        public VehicileBusClass orderBusComposition = new VehicileBusClass();

        public VehicileTruckClass orderTruckComposition = new VehicileTruckClass();

    }
}
