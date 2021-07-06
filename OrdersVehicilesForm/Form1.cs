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
        //        int vehicileRowNumber = 0;

        int orderArrayRowNumber = 0;
        int vehicileArrayRowNumber = 0;

        VehicileClass[] vehicilesArray = new VehicileClass[1010];
        OrderClass[] ordersArray = new OrderClass[175];

        public Form1()
        {
            InitializeComponent();

            ReadOrdersFile();
            ReadVehicilesFile();
        }


        public void ReadOrdersFile()
        {

            string fileToReadName = @"C:\app\rizla\csharp_test\vehicile_orders_csv_test.txt";
            string lineRead;
            int arrayCounter = 0;
            int counter = 0;

            string fileToWriteName = @"C:\app\rizla\csharp_test\vehicile_orders_csv_dump.txt"; // test only

            //Orders[] ordersArray = new Orders[175];

            //string[] fileLines = File.ReadAllLines(fileToReadName);

            //using FileStream fileToRead = new FileStream(fileToReadName, FileMode.Open, FileAccess.Read);

            StreamReader fileToRead = new StreamReader(fileToReadName);
            StreamWriter fileToWrite = new StreamWriter(fileToWriteName);  // test only

            arrayCounter = 0;

            while (((lineRead = fileToRead.ReadLine()) != null) && (arrayCounter < 20))
            {

                ordersArray[arrayCounter] = new OrderClass();

                string[] lineElements = lineRead.Split(',');

                try
                {
                    ordersArray[arrayCounter].orderID = Int32.Parse(lineElements[0]);
                    ordersArray[arrayCounter].orderCustomerName = lineElements[1];
                    ordersArray[arrayCounter].orderType = lineElements[2];
                    ordersArray[arrayCounter].orderDuration = Int32.Parse(lineElements[3]);
                    ordersArray[arrayCounter].orderVehicileType = lineElements[4];

                    string lineOutString = "Order ID = " + lineElements[0] + " " + "Customer Name = " + lineElements[1]
+ " " + "Order Type = " + lineElements[2] + " " + "Order Duration = " + lineElements[3]
+ " " + "Vehicile Type = " + lineElements[4]; // test only

                    File.WriteAllText(fileToWriteName, lineOutString); //test only

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

                    /*
                    Console.WriteLine("Order ID = " + lineElements[0] + " " + "Customer Name = " + lineElements[1]
                    + " " + "Order Type = " + lineElements[2] + " " + "Order Duration = " + lineElements[3]
                    + " " + "Vehicile Type = " + lineElements[4]);
                    */

                    string lineOutString = "Order ID = " + lineElements[0] + " " + "Customer Name = " + lineElements[1]
+ " " + "Order Type = " + lineElements[2] + " " + "Order Duration = " + lineElements[3]
+ " " + "Vehicile Type = " + lineElements[4]; // test only

                    fileToWrite.WriteLine(lineOutString);

                    //File.WriteAllText(fileToWriteName, lineOutString); //test only

                }

                arrayCounter++;
            }

            MessageBox.Show("records read = " + arrayCounter);


            fileToRead.Close();
            fileToWrite.Close(); // test only

        }


        public void ReadVehicilesFile()
        {

            string fileToReadName = @"C:\app\rizla\csharp_test\vehiciles_csv_test.txt";
            string lineRead;
            int arrayCounter = 0;
            int counter = 0;

            string fileToWriteName = @"C:\app\rizla\csharp_test\vehicile_csv_dump.txt"; // test only

            //Orders[] ordersArray = new Orders[175];

            //string[] fileLines = File.ReadAllLines(fileToReadName);

            //using FileStream fileToRead = new FileStream(fileToReadName, FileMode.Open, FileAccess.Read);

            StreamReader fileToRead = new StreamReader(fileToReadName);
            StreamWriter fileToWrite = new StreamWriter(fileToWriteName);  // test only

            arrayCounter = 0;

            while (((lineRead = fileToRead.ReadLine()) != null) && (arrayCounter < 20))
            {

                vehicilesArray[arrayCounter] = new VehicileClass();

                string[] lineElements = lineRead.Split(',');

                try
                {

                    vehicilesArray[arrayCounter].vehicileID = Int32.Parse(lineElements[0]);
                    vehicilesArray[arrayCounter].vehicileMake = lineElements[1];
                    vehicilesArray[arrayCounter].vehicileType = lineElements[2];
                    vehicilesArray[arrayCounter].vehicileYear = Int32.Parse(lineElements[3]);
                    vehicilesArray[arrayCounter].vehicileMiles = Int32.Parse(lineElements[4]);
                    vehicilesArray[arrayCounter].vehicileValueNew = Int32.Parse(lineElements[5]);
                    vehicilesArray[arrayCounter].vehicileAvailability = lineElements[6];

                    string lineOutString = "Vehicile ID = " + lineElements[0] + " " + "Vehicile Make = " + lineElements[1]
+ " " + "Vehicile Type = " + lineElements[2] + " " + "Vehicile Year = " + lineElements[3]
+ " " + "Vehicile Miles = " + lineElements[4] + " " + "Vehicile Value = " + lineElements[5] + " " + "Vehicile Availability = " + lineElements[6]; // test only

                    File.WriteAllText(fileToWriteName, lineOutString); //test only

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

                    /*
                    Console.WriteLine("Order ID = " + lineElements[0] + " " + "Customer Name = " + lineElements[1]
                    + " " + "Order Type = " + lineElements[2] + " " + "Order Duration = " + lineElements[3]
                    + " " + "Vehicile Type = " + lineElements[4]);
                    */

                    string lineOutString = "Vehicile ID = " + lineElements[0] + " " + "Vehicile Make = " + lineElements[1]
+ " " + "Vehicile Type = " + lineElements[2] + " " + "Vehicile Year = " + lineElements[3]
+ " " + "Vehicile Miles = " + lineElements[4] + " " + "Vehicile Value = " + lineElements[5] + " " + "Vehicile Availability = " + lineElements[6]; // test only



                    fileToWrite.WriteLine(lineOutString);

                    //File.WriteAllText(fileToWriteName, lineOutString); //test only

                }

                arrayCounter++;
            }

            MessageBox.Show("records read = " + arrayCounter);


            fileToRead.Close();
            fileToWrite.Close(); // test only

        }

    }
}
