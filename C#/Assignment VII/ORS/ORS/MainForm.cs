using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.Collections;

namespace ORS
{
    public partial class MainForm : Form
    {
        CustomerManager customerMngr;
        ArrayList storedCustomers;
        ArrayList storeNames;
        public MainForm()
        {
            InitializeComponent();
            customerMngr = new CustomerManager();
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

            ReadFiles();
         

        }

        private void ReadFiles()
        {
            lstCustomers.Items.Clear();
            cmbCustomer.Items.Clear();

            

            string lineCustomer;
            string lineName;
            StreamReader trCustomers = null;
            StreamReader trNames = null;
            try
            {
                //to fill names combobx
                trNames = new StreamReader("CustomerNames.txt");
                lineName = trNames.ReadLine();
                while (lineName != null)
                {
                    cmbCustomer.Items.Add(lineName);
                    lineName = trNames.ReadLine();
                }


                storeNames = new ArrayList(cmbCustomer.Items);
                //to fill listbox with details
                trCustomers = new StreamReader("CustomerDetails.txt");
                lineCustomer = trCustomers.ReadLine();
                while (lineCustomer != null)
                {
                    lstCustomers.Items.Add(lineCustomer);
                    lineCustomer = trCustomers.ReadLine();
                }
                storedCustomers = new ArrayList(lstCustomers.Items);
                 trCustomers.Close();
                trNames.Close();
            }
            catch (Exception e)
            {
                //MessageBox.Show ("Exception: " + e.Message);
                return;
            }
            
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
            CustomerForm  frmCustomer = new CustomerForm ("Add New Customer Info");
            if (frmCustomer.ShowDialog() == DialogResult.OK)
            {
                customerMngr.AddCustomer(frmCustomer.CustomerData);
                UpdateCustomerList();
            }
        }

        /// <summary>
        /// clears the listbox and updates it with the customer values of the 
        /// customerMngr arraylist
        /// </summary>
        private void UpdateCustomerList()
        {
            StreamWriter twCustomer = null;
            StreamWriter twCustomerNames = null;

            FileStream fsCustomer = new FileStream("CustomerDetails.txt", FileMode.Append);
            FileStream fsNames = new FileStream("CustomerNames.txt", FileMode.Append);

            try
            {

                 twCustomer = new StreamWriter(fsCustomer);
                 twCustomerNames = new StreamWriter(fsNames);
                 int index1 = 0;
                index1 = (customerMngr.CountCustomers - 1);
                twCustomer.WriteLine(customerMngr.GetCustomer(index1).ToString());
                int index2 = 0;
                index2 = (customerMngr.CountNames - 1);
                 twCustomerNames.WriteLine(customerMngr.GetName(index2).ToString());

               
            }
            catch(Exception e)
			{
				Console.WriteLine("Exception: " + e.Message);
			}
            finally {
                twCustomer.Close();
                twCustomerNames.Close();
            }

            ReadFiles();
        }

        private void ChangedCustomerList()
        {
            StreamWriter twCustomer = null;
            StreamWriter twCustomerNames = null;

            FileStream fsCustomer = new FileStream("CustomerDetails.txt", FileMode.Create);
            FileStream fsNames = new FileStream("CustomerNames.txt", FileMode.Create);

            try
            {

                twCustomer = new StreamWriter(fsCustomer);
                twCustomerNames = new StreamWriter(fsNames);
                for (int i = 0; i < storedCustomers.Count; i++)
                    twCustomer.WriteLine(storedCustomers[i]);
                for (int i = 0; i < storeNames.Count; i++)
                   twCustomerNames.WriteLine(storeNames[i]);
           
            }
            catch (Exception e)
            {
                Console.WriteLine("Exception: " + e.Message);
            }
            finally
            {
                twCustomer.Close();
                twCustomerNames.Close();
            }

            ReadFiles();
        }
        private void updateToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
            {
                if (lstCustomers.Items.Count != 0)
                {
                    
                   // ReadFiles();
                    int index = lstCustomers.SelectedIndex;
                    if (index == -1)
                    {
                        MessageBox.Show("Please select an index", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                    string str = lstCustomers.SelectedItem.ToString();
                    CustomerForm frmCustomer = new CustomerForm("Update Customer Info", customerMngr.GetDetails(str));
                    customerMngr.Customers = storedCustomers;
                    customerMngr.Names = storeNames;
                    //if the customer clicks on OK button of the customer form then continue with the updation
                    if (frmCustomer.ShowDialog() == DialogResult.OK)
                    {
                        customerMngr.ChangeCustomer(frmCustomer.CustomerData, lstCustomers.SelectedIndex);
                        storedCustomers = customerMngr.Customers;
                        storeNames = customerMngr.Names;
                        ChangedCustomerList();
                    }
                    else
                    {
                        //if listbox is empty show error
                        ShowError();
                        return;
                    }
                }
               
            }
        }

        private void ShowError()
        {
            MessageBox.Show("Customer list is empty, choose the Add customer option to add a new customer.", "", MessageBoxButtons.OK);
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            SelectTime selectTime = new SelectTime();
            selectTime.Show();
        }
    }
}
