using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Task1.Controllers;
using Task1.Interfaces;

namespace Task1
{
    public partial class Form1 : Form
    {
        public IDBController dBController;
        private string ID_Point;
        private string ID_Type;
        public Form1()
        {
            InitializeComponent();
            dBController = new DBController();
        }

        private void FixAllDateTimes_Click(object sender, EventArgs e)
        {
            dBController.FixAllDateTimes(ID_Point, ID_Type);
        }

        private void ID_POINT_TextChanged(object sender, EventArgs e)
        {
            ID_Point = ID_POINT.Text;
        }

        private void ID_TYPE_TextChanged(object sender, EventArgs e)
        {
            ID_Type = ID_TYPE.Text;
        }
    }
}
