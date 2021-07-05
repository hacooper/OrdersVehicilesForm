using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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
        }
    }
}
