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
    public partial class Customer : Form
    {
         //flag to handle the closing of the form
        private bool closeForm;

        //constructor with one parameter (title of the form)
        public Customer(string title)
        {
            InitializeComponent();
            //Other initalizations
            this.Text = title;
            closeForm = true;

        }

         /// <summary>
        /// Event hadler for formclosing event event of the form
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Customer_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (closeForm)
                e.Cancel = false;
            else
                e.Cancel = true;
        }
    }
}
