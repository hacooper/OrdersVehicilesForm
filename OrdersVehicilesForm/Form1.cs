using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;


namespace OrdersVehicilesForm
{
    public partial class Form1 : Form
    {
        int vehicileArrayRowNumber = 0;

        int orderArrayRowMax = 0; // total elements in order class array
        int vehicileArrayMax = 0; // total elements in current vehicile array

        string orderTypeBoxValue = "Auto"; // global vehicile type used in fetch order button and up and down buttons
        string orderPurchaseTypeBoxValue = "P"; // global order type for Purchase, Lease or Rental Order type

        int orderArrayCounter = 0; // global current position in order class array
        int vehicileArrayCounter = 0; // general all purpose global counter used for all vehicile class array

        // global counters used in file read for each vehicile type class array
        int vehicileAutoArrayCounter = 0;
        int vehicileBusArrayCounter = 0;
        int vehicileTruckArrayCounter = 0;


        OrderClass[] ordersArray = new OrderClass[175]; //Order class array. Limit set to 175

        //Vehicile class array for each vehicile type
        VehicileAutoClass[] vehicileAutoArray = new VehicileAutoClass[1010];
        VehicileBusClass[] vehicileBusArray = new VehicileBusClass[1010];
        VehicileTruckClass[] vehicileTruckArray = new VehicileTruckClass[1010];

        public Form1()
        {
            InitializeComponent();

            OrderVehicileTypeListBox.SelectedIndex = 0;

            ReadOrdersFile();
            ReadVehicilesFile();
        }

        private void Form1_Shown(Object sender, EventArgs e)
        {

            OrderVehicileTypeListBox.SelectedIndex = 1;

        }

        public void ReadOrdersFile()
        {

            //read order file into order class array
            //order file format
            //1,Feedmix,0,R,4,Bus
            //ID,Customer name, Order Vehicile ID, Order Type Rental Lease Purchase, Order Duration, Vehicile type

            string fileToReadName = @"C:\rac_csharp_project\orders_file.txt";
            string lineRead;
            int arrayCounter = 0;

            string fileToWriteName = @"C:\rac_csharp_project\orders_file_dump.txt"; // test only

            StreamReader fileToRead = new StreamReader(fileToReadName);
            StreamWriter fileToWrite = new StreamWriter(fileToWriteName);  // test only

            // file line read limited to 150 
            while (((lineRead = fileToRead.ReadLine()) != null) && (arrayCounter < 150)) 
            {

                ordersArray[arrayCounter] = new OrderClass();

                string[] lineElements = lineRead.Split(',');

                try
                {
                    ordersArray[arrayCounter].orderID = Int32.Parse(lineElements[0]);
                    ordersArray[arrayCounter].orderCustomerName = lineElements[1];
                    ordersArray[arrayCounter].orderVehicileID = Int32.Parse(lineElements[2]);
                    ordersArray[arrayCounter].orderType = lineElements[3];
                    ordersArray[arrayCounter].orderDuration = Int32.Parse(lineElements[4]);
                    ordersArray[arrayCounter].orderVehicileType = lineElements[5];
                    /*
                                        string lineOutString = "Order ID = " + lineElements[0] + " " + "Customer Name = " + lineElements[1]
                                            + " " + "Order Vehicile ID = " + lineElements[2]
                    + " " + "Order Type = " + lineElements[3] + " " + "Order Duration = " + lineElements[4]
                    + " " + "Vehicile Type = " + lineElements[5]; // test only

                                        fileToWrite.WriteLine(lineOutString); // test only
                    */
                }
                catch (FormatException e)

                {
                    Console.WriteLine(e.Message);
                }
                finally
                {
                    /*
                    ordersArray[arrayCounter].orderID = Int32.Parse(lineElements[0]);
                    ordersArray[arrayCounter].orderCustomerName = lineElements[1];
                    ordersArray[arrayCounter].orderType = lineElements[2];
                    ordersArray[arrayCounter].orderDuration = Int32.Parse(lineElements[3]);
                    ordersArray[arrayCounter].orderVehicileType = lineElements[4];
                    */

                }

                arrayCounter++;
            }

            orderArrayRowMax = arrayCounter; //final number of maximum elements in order class array

            fileToRead.Close();
            fileToWrite.Close(); // test only

        }


        public void ReadVehicilesFile()
        {

            string fileToReadName = @"C:\rac_csharp_project\vehiciles_file.txt";
            string lineRead;
            int fileArrayCounter = 0;

            //now global
            vehicileAutoArrayCounter = 0;
            vehicileBusArrayCounter = 0;
            vehicileTruckArrayCounter = 0;

            string fileToWriteName = @"C:\rac_csharp_project\vehiciles_file_dump.txt"; // test only

            StreamReader fileToRead = new StreamReader(fileToReadName);
            StreamWriter fileToWrite = new StreamWriter(fileToWriteName);  // test only

            //vehicile file format
            //1,Sentra,Bus,2012,249397,198369,1,DUMMY
            //ID, Make, Type, Year, Value new, Miles, Available, Spare

            while (((lineRead = fileToRead.ReadLine()) != null) && (fileArrayCounter < 1000))
            {

                string[] lineElements = lineRead.Split(',');

                if (lineElements[2] == "Auto")
                {

                    vehicileAutoArray[vehicileAutoArrayCounter] = new VehicileAutoClass();

                    vehicileAutoArray[vehicileAutoArrayCounter].vehicileID = Int32.Parse(lineElements[0]);
                    vehicileAutoArray[vehicileAutoArrayCounter].vehicileMake = lineElements[1];
                    vehicileAutoArray[vehicileAutoArrayCounter].vehicileType = lineElements[2];
                    vehicileAutoArray[vehicileAutoArrayCounter].vehicileYear = Int32.Parse(lineElements[3]);
                    vehicileAutoArray[vehicileAutoArrayCounter].vehicileMiles = Int32.Parse(lineElements[4]);
                    vehicileAutoArray[vehicileAutoArrayCounter].vehicileValueNew = Int32.Parse(lineElements[5]);
                    vehicileAutoArray[vehicileAutoArrayCounter].vehicileAvailability = lineElements[6];

                    vehicileAutoArrayCounter++;

                    /*
                    string lineOutString = "ID = " + lineElements[0] + " " + "Make = " + lineElements[1]
+ " " + "Type = " + lineElements[2] + " " + "Year = " + lineElements[3]
+ " " + "Miles = " + lineElements[4] + " " + "Value = " + lineElements[5]
+ " " + "Availability = " + lineElements[6] + " " + "Spare = " + lineElements[7]; // test only

                    fileToWrite.WriteLine(lineOutString); // test only
                    */
                }
                else
                if (lineElements[2] == "Bus")
                {

                    vehicileBusArray[vehicileBusArrayCounter] = new VehicileBusClass();

                    vehicileBusArray[vehicileBusArrayCounter].vehicileID = Int32.Parse(lineElements[0]);
                    vehicileBusArray[vehicileBusArrayCounter].vehicileMake = lineElements[1];
                    vehicileBusArray[vehicileBusArrayCounter].vehicileType = lineElements[2];
                    vehicileBusArray[vehicileBusArrayCounter].vehicileYear = Int32.Parse(lineElements[3]);
                    vehicileBusArray[vehicileBusArrayCounter].vehicileMiles = Int32.Parse(lineElements[4]);
                    vehicileBusArray[vehicileBusArrayCounter].vehicileValueNew = Int32.Parse(lineElements[5]);
                    vehicileBusArray[vehicileBusArrayCounter].vehicileAvailability = lineElements[6];

                    vehicileBusArrayCounter++;

                    string lineOutString = "ID = " + lineElements[0] + " " + "Make = " + lineElements[1]
+ " " + "Type = " + lineElements[2] + " " + "Year = " + lineElements[3]
+ " " + "Miles = " + lineElements[4] + " " + "Value = " + lineElements[5]
+ " " + "Availability = " + lineElements[6] + " " + "Spare = " + lineElements[7]; // test only

                    fileToWrite.WriteLine(lineOutString);

                }
                else
                if (lineElements[2] == "Truck")
                {
                    vehicileTruckArray[vehicileTruckArrayCounter] = new VehicileTruckClass();

                    vehicileTruckArray[vehicileTruckArrayCounter].vehicileID = Int32.Parse(lineElements[0]);
                    vehicileTruckArray[vehicileTruckArrayCounter].vehicileMake = lineElements[1];
                    vehicileTruckArray[vehicileTruckArrayCounter].vehicileType = lineElements[2];
                    vehicileTruckArray[vehicileTruckArrayCounter].vehicileYear = Int32.Parse(lineElements[3]);
                    vehicileTruckArray[vehicileTruckArrayCounter].vehicileMiles = Int32.Parse(lineElements[4]);
                    vehicileTruckArray[vehicileTruckArrayCounter].vehicileValueNew = Int32.Parse(lineElements[5]);
                    vehicileTruckArray[vehicileTruckArrayCounter].vehicileAvailability = lineElements[6];

                    string lineOutString = "ID = " + lineElements[0] + " " + "Make = " + lineElements[1]
+ " " + "Type = " + lineElements[2] + " " + "Year = " + lineElements[3]
+ " " + "Miles = " + lineElements[4] + " " + "Value = " + lineElements[5]
+ " " + "Availability = " + lineElements[6] + " " + "Spare = " + lineElements[7]; // test only

                    fileToWrite.WriteLine(lineOutString);

                    vehicileTruckArrayCounter++;
                }
                fileArrayCounter++;
            }

            fileToRead.Close();
            fileToWrite.Close(); // test only

        }

        private void ordersFetchButton_Click(object sender, EventArgs e)
        {

            orderArrayCounter = 0; //Global. Also used in scroll buttons.

            orderTypeBoxValue = OrderVehicileTypeListBox.GetItemText(OrderVehicileTypeListBox.SelectedItem);

            //string OrderVehicileTypeListBoxMessage = "Unset"; // add error handling, or set default

            //get first order row of order type

            while ((orderArrayCounter < orderArrayRowMax) &&
                (ordersArray[orderArrayCounter].orderVehicileType != orderTypeBoxValue))
            {
                orderArrayCounter++;
            }

            orderCustomerNameTextBox.Text = ordersArray[orderArrayCounter].orderCustomerName;
            orderTypeTextBox.Text = ordersArray[orderArrayCounter].orderType;

            orderPurchaseTypeBoxValue = orderTypeTextBox.Text;
            
            orderDurationTextBox.Text = (ordersArray[orderArrayCounter].orderDuration).ToString();

            // reset vehicile form
            vehicileArrayCounter = 0; // reset vehicile array counter when new order vehicile type fetched
            vehicileTypeTextBox.Text = "";
            vehicileMakeTextBox.Text = "";
            vehicileYearTextBox.Text = "";
            vehicileMilesTextBox.Text = "";
            vehicileValueNewTextBox.Text = "";
            vehicileTypeTextBox.Text = "";

        }

        private void ordersGroupBox_Enter(object sender, EventArgs e)
        {

        }

        private void ordersUpButton_Click(object sender, EventArgs e)
        {
            //scroll up through order class array

            int scrollButtonCounter = 0;
            if (orderArrayCounter > 0) scrollButtonCounter = orderArrayCounter - 1;

            while ((scrollButtonCounter > 0) && 
                (ordersArray[scrollButtonCounter].orderVehicileType != orderTypeBoxValue))
            {
                scrollButtonCounter--;
            }

            if (ordersArray[scrollButtonCounter].orderVehicileType == orderTypeBoxValue)
            {
                orderArrayCounter = scrollButtonCounter;

                orderCustomerNameTextBox.Text = ordersArray[orderArrayCounter].orderCustomerName;
                orderTypeTextBox.Text = ordersArray[orderArrayCounter].orderType;
                orderDurationTextBox.Text = (ordersArray[orderArrayCounter].orderDuration).ToString();

                orderPurchaseTypeBoxValue = orderTypeTextBox.Text;
            }
        }

        private void orderButtonDown_Click(object sender, EventArgs e)
        {
            //scroll down through order class array


            int scrollButtonCounter = 0;
            if (orderArrayCounter < orderArrayRowMax) scrollButtonCounter = orderArrayCounter + 1;

            while ((scrollButtonCounter < orderArrayRowMax) && 
                (ordersArray[scrollButtonCounter].orderVehicileType != orderTypeBoxValue))
            {
                scrollButtonCounter++;
            }

                if ((scrollButtonCounter < orderArrayRowMax) && (ordersArray[scrollButtonCounter].orderVehicileType == orderTypeBoxValue))
            {
                orderArrayCounter = scrollButtonCounter;

                orderCustomerNameTextBox.Text = ordersArray[orderArrayCounter].orderCustomerName;
                orderTypeTextBox.Text = ordersArray[orderArrayCounter].orderType;
                orderDurationTextBox.Text = (ordersArray[orderArrayCounter].orderDuration).ToString();

                orderPurchaseTypeBoxValue = orderTypeTextBox.Text;
            }
        }

        private void OrderVehicileTypeListBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void vehicilesFetchButton_Click(object sender, EventArgs e)
        {
            // reset order vehicile type when vehiciles refetched
            orderTypeBoxValue = OrderVehicileTypeListBox.GetItemText(OrderVehicileTypeListBox.SelectedItem);

            //Fetch first vehicile based on order vehicile type to 
            //vehicileArrayCounter set to 0 when new order was fetched

            switch (orderTypeBoxValue)
            {
                case "Auto":
                    {
                        //set limit of array to max limit if vehicile type array
                        vehicileArrayMax = vehicileAutoArrayCounter;

                        vehicileTypeTextBox.Text = vehicileAutoArray[vehicileArrayCounter].vehicileType;
                        vehicileMakeTextBox.Text = vehicileAutoArray[vehicileArrayCounter].vehicileMake;

                        vehicileYearTextBox.Text = (vehicileAutoArray[vehicileArrayCounter].vehicileYear).ToString();
                        vehicileMilesTextBox.Text = (vehicileAutoArray[vehicileArrayCounter].vehicileMiles).ToString();
                        vehicileValueNewTextBox.Text =
                        (vehicileAutoArray[vehicileArrayCounter].vehicileValueNew).ToString();

                        vehicileTypeTextBox.Text = vehicileAutoArray[vehicileArrayCounter].vehicileType;

                        break;
                    }
                case "Bus":
                    {
                        vehicileArrayMax = vehicileBusArrayCounter;

                        vehicileTypeTextBox.Text = vehicileBusArray[vehicileArrayCounter].vehicileType;
                        vehicileMakeTextBox.Text = vehicileBusArray[vehicileArrayCounter].vehicileMake;

                        vehicileYearTextBox.Text = (vehicileBusArray[vehicileArrayCounter].vehicileYear).ToString();
                        vehicileMilesTextBox.Text = (vehicileBusArray[vehicileArrayCounter].vehicileMiles).ToString();
                        vehicileValueNewTextBox.Text =
                        (vehicileBusArray[vehicileArrayCounter].vehicileValueNew).ToString();

                        vehicileTypeTextBox.Text = vehicileBusArray[vehicileArrayCounter].vehicileType;

                        break;
                    }
                case "Truck":
                    {
                        vehicileArrayMax = vehicileTruckArrayCounter;

                        vehicileTypeTextBox.Text = vehicileTruckArray[vehicileArrayCounter].vehicileType;
                        vehicileMakeTextBox.Text = vehicileTruckArray[vehicileArrayCounter].vehicileMake;

                        vehicileYearTextBox.Text = (vehicileTruckArray[vehicileArrayCounter].vehicileYear).ToString();
                        vehicileMilesTextBox.Text = (vehicileTruckArray[vehicileArrayCounter].vehicileMiles).ToString();
                        vehicileValueNewTextBox.Text =
                        (vehicileTruckArray[vehicileArrayCounter].vehicileValueNew).ToString();

                        vehicileTypeTextBox.Text = vehicileTruckArray[vehicileArrayCounter].vehicileType;

                        break;
                    }
                default:
                    {
                        break;
                        //add error message
                    }

            }

        }

        private void vehicilesUpButton_Click(object sender, EventArgs e)
        {
            //scroll up through vehicile class array, based on order vehicile type

            if (vehicileArrayCounter > 0)
            {
                switch (orderTypeBoxValue)
                {
                    case "Auto":
                        {

                            vehicileArrayCounter--;

                            vehicileTypeTextBox.Text = vehicileAutoArray[vehicileArrayCounter].vehicileType;
                            vehicileMakeTextBox.Text = vehicileAutoArray[vehicileArrayCounter].vehicileMake;

                            vehicileYearTextBox.Text = (vehicileAutoArray[vehicileArrayCounter].vehicileYear).ToString();
                            vehicileMilesTextBox.Text = (vehicileAutoArray[vehicileArrayCounter].vehicileMiles).ToString();
                            vehicileValueNewTextBox.Text =
                            (vehicileAutoArray[vehicileArrayCounter].vehicileValueNew).ToString();

                            vehicileTypeTextBox.Text = vehicileAutoArray[vehicileArrayCounter].vehicileType;

                            break;
                        }
                    case "Bus":
                        {
                            vehicileArrayCounter--;

                            vehicileTypeTextBox.Text = vehicileBusArray[vehicileArrayCounter].vehicileType;
                            vehicileMakeTextBox.Text = vehicileBusArray[vehicileArrayCounter].vehicileMake;

                            vehicileYearTextBox.Text = (vehicileBusArray[vehicileArrayCounter].vehicileYear).ToString();
                            vehicileMilesTextBox.Text = (vehicileBusArray[vehicileArrayCounter].vehicileMiles).ToString();
                            vehicileValueNewTextBox.Text =
                            (vehicileBusArray[vehicileArrayCounter].vehicileValueNew).ToString();

                            vehicileTypeTextBox.Text = vehicileBusArray[vehicileArrayCounter].vehicileType;

                            break;
                        }
                    case "Truck":
                        {
                            vehicileArrayCounter--;

                            vehicileTypeTextBox.Text = vehicileTruckArray[vehicileArrayCounter].vehicileType;
                            vehicileMakeTextBox.Text = vehicileTruckArray[vehicileArrayCounter].vehicileMake;

                            vehicileYearTextBox.Text = (vehicileTruckArray[vehicileArrayCounter].vehicileYear).ToString();
                            vehicileMilesTextBox.Text = (vehicileTruckArray[vehicileArrayCounter].vehicileMiles).ToString();
                            vehicileValueNewTextBox.Text =
                            (vehicileTruckArray[vehicileArrayCounter].vehicileValueNew).ToString();

                            vehicileTypeTextBox.Text = vehicileTruckArray[vehicileArrayCounter].vehicileType;

                            break;
                        }
                    default:
                        {
                            break;
                        }
                }
            }
        }

        private void vehicilesDownButton_Click(object sender, EventArgs e)
        {

            //scroll down through vehicile class array, based on order vehicile type

            if (vehicileArrayCounter < vehicileArrayMax - 1)
            {

                switch (orderTypeBoxValue)
                {
                    case "Auto":
                        {
                            vehicileArrayCounter++;

                            vehicileTypeTextBox.Text = vehicileAutoArray[vehicileArrayCounter].vehicileType;
                            vehicileMakeTextBox.Text = vehicileAutoArray[vehicileArrayCounter].vehicileMake;

                            vehicileYearTextBox.Text = (vehicileAutoArray[vehicileArrayCounter].vehicileYear).ToString();
                            vehicileMilesTextBox.Text = (vehicileAutoArray[vehicileArrayCounter].vehicileMiles).ToString();
                            vehicileValueNewTextBox.Text =
                            (vehicileAutoArray[vehicileArrayCounter].vehicileValueNew).ToString();

                            vehicileTypeTextBox.Text = vehicileAutoArray[vehicileArrayCounter].vehicileType;

                            break;
                        }

                    case "Bus":
                        {
                            vehicileArrayCounter++;

                            vehicileTypeTextBox.Text = vehicileBusArray[vehicileArrayCounter].vehicileType;
                            vehicileMakeTextBox.Text = vehicileBusArray[vehicileArrayCounter].vehicileMake;

                            vehicileYearTextBox.Text = (vehicileBusArray[vehicileArrayCounter].vehicileYear).ToString();
                            vehicileMilesTextBox.Text = (vehicileBusArray[vehicileArrayCounter].vehicileMiles).ToString();
                            vehicileValueNewTextBox.Text =
                            (vehicileBusArray[vehicileArrayCounter].vehicileValueNew).ToString();

                            vehicileTypeTextBox.Text = vehicileBusArray[vehicileArrayCounter].vehicileType;

                            break;
                        }

                    case "Truck":
                        {
                            vehicileArrayCounter++;

                            vehicileTypeTextBox.Text = vehicileTruckArray[vehicileArrayCounter].vehicileType;
                            vehicileMakeTextBox.Text = vehicileTruckArray[vehicileArrayCounter].vehicileMake;

                            vehicileYearTextBox.Text = (vehicileTruckArray[vehicileArrayCounter].vehicileYear).ToString();
                            vehicileMilesTextBox.Text = (vehicileTruckArray[vehicileArrayCounter].vehicileMiles).ToString();
                            vehicileValueNewTextBox.Text =
                            (vehicileTruckArray[vehicileArrayCounter].vehicileValueNew).ToString();

                            vehicileTypeTextBox.Text = vehicileTruckArray[vehicileArrayCounter].vehicileType;

                            break;
                        }

                    default:
                        {
                            break;
                        }
                }
            }

        }

        private void vehicileOrderAssignButton_Click(object sender, EventArgs e)
        {

            //Assign vehicile to order class using composition

            //Check to see if already assigned

            if (ordersArray[orderArrayCounter].orderValue != 0) // check if order already fulfilled
            {
                //MessageBox.Show("Order " + ordersArray[orderArrayCounter].orderValue + " already assigned.");
                MessageBox.Show("Order already assigned.");
                return;
            }

            // check if vehicile already assigned
            switch (orderTypeBoxValue)
            {
                case "Auto":
                    {
                        if (vehicileAutoArray[vehicileArrayCounter].vehicileAvailability == "0")
                        {
                            MessageBox.Show("Vehicile already assigned.");
                            return;
                        }
                        break;
                    }

                case "Bus":
                    {
                        if (vehicileBusArray[vehicileArrayCounter].vehicileAvailability == "0")
                        {
                            MessageBox.Show("Vehicile already assigned.");
                            return;
                        }
                        break;
                    }

                case "Truck":
                    {
                        if (vehicileTruckArray[vehicileArrayCounter].vehicileAvailability == "0")
                        {
                            MessageBox.Show("Vehicile already assigned.");
                            return;
                        }
                        break;
                    }
            }

            //calculate order value based on vehicile type order type. 
            //update order class value and vehicile class availability

            if (orderTypeBoxValue == "Auto")
            {
                switch (orderPurchaseTypeBoxValue)
                {
                    case "P":
                        {

                            //call composition order/vehicile method
                            int tempOrderValue = ordersArray[orderArrayCounter].orderAutoComposition.CalculateAutoSaleValue(vehicileAutoArray[vehicileArrayCounter].vehicileYear, vehicileAutoArray[vehicileArrayCounter].vehicileValueNew);

                            //set calculated order value
                            ordersArray[orderArrayCounter].orderValue = tempOrderValue;

                            //set assigned vehicile as unavailable
                            vehicileAutoArray[vehicileArrayCounter].vehicileAvailability = "0";
                            ordersArray[orderArrayCounter].orderVehicileID = vehicileAutoArray[vehicileArrayCounter].vehicileID;

                            //set composition order/vehicile vehicile id
                            ordersArray[orderArrayCounter].orderAutoComposition.vehicileID = vehicileAutoArray[vehicileArrayCounter].vehicileID;

                            break;
                        }
                    case "R":
                        {

                            int tempOrderValue = ordersArray[orderArrayCounter].orderAutoComposition.CalculateAutoRentalValue(vehicileAutoArray[vehicileArrayCounter].vehicileYear, vehicileAutoArray[vehicileArrayCounter].vehicileValueNew);

                            ordersArray[orderArrayCounter].orderValue = tempOrderValue;
                            vehicileAutoArray[vehicileArrayCounter].vehicileAvailability = "0";
                            ordersArray[orderArrayCounter].orderVehicileID = vehicileAutoArray[vehicileArrayCounter].vehicileID;
                            ordersArray[orderArrayCounter].orderAutoComposition.vehicileID = vehicileAutoArray[vehicileArrayCounter].vehicileID;

                            break;
                        }
                    case "L":
                        {
                            int tempOrderValue = ordersArray[orderArrayCounter].orderAutoComposition.CalculateAutoLeaseValue(vehicileAutoArray[vehicileArrayCounter].vehicileYear, vehicileAutoArray[vehicileArrayCounter].vehicileValueNew);

                            ordersArray[orderArrayCounter].orderValue = tempOrderValue;
                            vehicileAutoArray[vehicileArrayCounter].vehicileAvailability = "0";
                            ordersArray[orderArrayCounter].orderVehicileID = vehicileAutoArray[vehicileArrayCounter].vehicileID;
                            ordersArray[orderArrayCounter].orderAutoComposition.vehicileID = vehicileAutoArray[vehicileArrayCounter].vehicileID;

                            break;
                        }
                }

                return;
            }

            if (orderTypeBoxValue == "Bus")
            {
                switch (orderPurchaseTypeBoxValue)
                {
                    case "P":
                        {
                            int tempOrderValue = ordersArray[orderArrayCounter].orderBusComposition.CalculateBusSaleValue(vehicileBusArray[vehicileArrayCounter].vehicileYear, vehicileBusArray[vehicileArrayCounter].vehicileValueNew);

                            ordersArray[orderArrayCounter].orderValue = tempOrderValue;
                            vehicileBusArray[vehicileArrayCounter].vehicileAvailability = "0";
                            ordersArray[orderArrayCounter].orderVehicileID = vehicileBusArray[vehicileArrayCounter].vehicileID;
                            ordersArray[orderArrayCounter].orderBusComposition.vehicileID = vehicileBusArray[vehicileArrayCounter].vehicileID;

                            break;
                        }
                    case "R":
                        {
                            int tempOrderValue = ordersArray[orderArrayCounter].orderBusComposition.CalculateBusRentalValue(vehicileBusArray[vehicileArrayCounter].vehicileYear, vehicileBusArray[vehicileArrayCounter].vehicileValueNew);

                            ordersArray[orderArrayCounter].orderValue = tempOrderValue;
                            vehicileBusArray[vehicileArrayCounter].vehicileAvailability = "0";
                            ordersArray[orderArrayCounter].orderVehicileID = vehicileBusArray[vehicileArrayCounter].vehicileID;
                            ordersArray[orderArrayCounter].orderBusComposition.vehicileID = vehicileBusArray[vehicileArrayCounter].vehicileID;

                            break;
                        }
                    case "L":
                        {
                            int tempOrderValue = ordersArray[orderArrayCounter].orderBusComposition.CalculateBusLeaseValue(vehicileBusArray[vehicileArrayCounter].vehicileYear, vehicileBusArray[vehicileArrayCounter].vehicileValueNew);

                            ordersArray[orderArrayCounter].orderValue = tempOrderValue;
                            vehicileBusArray[vehicileArrayCounter].vehicileAvailability = "0";
                            ordersArray[orderArrayCounter].orderVehicileID = vehicileBusArray[vehicileArrayCounter].vehicileID;
                            ordersArray[orderArrayCounter].orderBusComposition.vehicileID = vehicileBusArray[vehicileArrayCounter].vehicileID;

                            break;
                        }
                }

                return;
            }

            if (orderTypeBoxValue == "Truck")
            {
                switch (orderPurchaseTypeBoxValue)
                {
                    case "P":
                        {
                            int tempOrderValue = ordersArray[orderArrayCounter].orderTruckComposition.CalculateTruckSaleValue(vehicileTruckArray[vehicileArrayCounter].vehicileYear, vehicileTruckArray[vehicileArrayCounter].vehicileValueNew);

                            ordersArray[orderArrayCounter].orderValue = tempOrderValue;
                            vehicileTruckArray[vehicileArrayCounter].vehicileAvailability = "0";
                            ordersArray[orderArrayCounter].orderVehicileID = vehicileTruckArray[vehicileArrayCounter].vehicileID;
                            ordersArray[orderArrayCounter].orderTruckComposition.vehicileID = vehicileTruckArray[vehicileArrayCounter].vehicileID;

                            break;
                        }
                    case "R":
                        {
                            int tempOrderValue = ordersArray[orderArrayCounter].orderTruckComposition.CalculateTruckRentalValue(vehicileTruckArray[vehicileArrayCounter].vehicileYear, vehicileTruckArray[vehicileArrayCounter].vehicileValueNew);

                            ordersArray[orderArrayCounter].orderValue = tempOrderValue;
                            vehicileTruckArray[vehicileArrayCounter].vehicileAvailability = "0";
                            ordersArray[orderArrayCounter].orderVehicileID = vehicileTruckArray[vehicileArrayCounter].vehicileID;
                            ordersArray[orderArrayCounter].orderTruckComposition.vehicileID = vehicileTruckArray[vehicileArrayCounter].vehicileID;

                            break;
                        }
                    case "L":
                        {
                            int tempOrderValue = ordersArray[orderArrayCounter].orderTruckComposition.CalculateTruckLeaseValue(vehicileTruckArray[vehicileArrayCounter].vehicileYear, vehicileTruckArray[vehicileArrayCounter].vehicileValueNew);

                            ordersArray[orderArrayCounter].orderValue = tempOrderValue;
                            vehicileTruckArray[vehicileArrayCounter].vehicileAvailability = "0";
                            ordersArray[orderArrayCounter].orderVehicileID = vehicileTruckArray[vehicileArrayCounter].vehicileID;
                            ordersArray[orderArrayCounter].orderTruckComposition.vehicileID = vehicileTruckArray[vehicileArrayCounter].vehicileID;

                            break;
                        }
                }

                return;

            }
        }

        private void CommitButton_Click(object sender, EventArgs e)
        {

            //write updated orders array to outputfile

            int arrayFileOutCounter = 0;

            string fileToWriteName = @"C:\rac_csharp_project\orders_assigned_file.txt";

            StreamWriter fileToWrite = new StreamWriter(fileToWriteName);

            while (arrayFileOutCounter < orderArrayRowMax)
            {

                if (ordersArray[arrayFileOutCounter].orderValue != 0)
                {
                    string lineOutString =
                    ordersArray[arrayFileOutCounter].orderID + "," +
                    ordersArray[arrayFileOutCounter].orderCustomerName + "," +
                    ordersArray[arrayFileOutCounter].orderVehicileID + "," +
                    ordersArray[arrayFileOutCounter].orderType + "," +
                    ordersArray[arrayFileOutCounter].orderVehicileType + "," +
                    //ordersArray[arrayFileOutCounter].orderDuration  + "," 
                    ordersArray[arrayFileOutCounter].orderValue;

                    fileToWrite.WriteLine(lineOutString);
                }

                arrayFileOutCounter++;

            }

            fileToWrite.Close();

        }

    }
}
