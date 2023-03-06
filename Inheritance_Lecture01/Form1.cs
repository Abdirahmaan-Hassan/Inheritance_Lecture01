using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Inheritance_Lecture01
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            Cars car = new Cars(5, "Toyota","MD",2000,400M);
            //car.Make = txtMake.Text;
            //car.Modal = txtModal.Text;
            //car.MileAge = Convert.ToInt16(txtMile.Text);
            //car.Price = Convert.ToDecimal(txtPrice.Text);
            //car.Doors = Convert.ToInt16(txtDoors.Text);
            //

            lblMake.Text = car.Make;
            lblModal.Text = car.Modal;
            lblMile.Text = car.MileAge.ToString();
            lblPrice.Text = car.Price.ToString("C");
            lblDoors.Text = car.Doors.ToString();
        }

        private void tnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
