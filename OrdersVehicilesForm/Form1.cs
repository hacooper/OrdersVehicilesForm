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

            Read_Orders_File();
        }


        public void Read_Orders_File()
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


    }
}
