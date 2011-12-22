using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ORS
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            //My initalization
            InitializeGUI();
        }

        private void InitializeGUI()
        {
            // clear and updated the cmbTransportaion with Trasportation type and select default value as Train.
            cmbTranportation.Items.Clear();
            cmbTranportation.Items.AddRange(Enum.GetNames(typeof(TransportationType)));
            cmbTranportation.SelectedIndex = (int)TransportationType.Train;

            // clear and updated the cmbFrom with Station and select default value Stockholm.
            cmbFrom.Items.Clear();
            cmbFrom.Items.AddRange(Enum.GetNames(typeof(Stations)));
            cmbFrom.SelectedIndex = (int)Stations.Stockholm;

            // clear and updated the cmbTo with Station and select default value Copenhagen.
            cmbTo.Items.Clear();
            cmbTo.Items.AddRange(Enum.GetNames(typeof(Stations)));
            cmbTo.SelectedIndex = (int)Stations.Copenhagen;

        }

        private void cmbTranportation_SelectedIndexChanged(object sender, EventArgs e)
        {
            //change image in the image control according to the selection
            pictureBox.Image = this.imgList.Images[cmbTranportation.SelectedIndex];
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AboutBox about = new AboutBox();
            about.Show();
        }

        private void trainToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Transportation train = new Transportation("Add New Train Info");
            train.Show();
            
        }

        private void bussToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Transportation bus = new Transportation("Add New Bus Info");
            bus.Show();
        }

        private void flightToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Transportation flight = new Transportation("Add New Flight Info");
            flight.Show();
        }

        private void addCustomerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Customer  addCustomer = new Customer ("Add New Customer Info");
            addCustomer.Show();
        }

        private void updateToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Customer updateCustomer = new Customer("Update Customer Info");
            updateCustomer.Show();
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            SelectTime selectTime = new SelectTime();
            selectTime.Show();
        }
    }
}
