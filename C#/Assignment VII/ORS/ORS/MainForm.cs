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
        TransportaionManager transportMngr;
        ArrayList storedCustomers;
        ArrayList storeNames;
        string reservation;
        public MainForm()
        {
            InitializeComponent();
            customerMngr = new CustomerManager();
            transportMngr = new TransportaionManager();
            //My initalization
            InitializeGUI();
        }

        private void InitializeGUI()
        {
            dateOfJourney.MinDate = DateTime.Today;
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
            Transportation frmTrain = new Transportation("Add New Train Info");
           

            if (frmTrain.ShowDialog() == DialogResult.OK)
            {
                transportMngr.AddTrain(frmTrain.TransportData);
                UpdateTrainList();
            }
            
        }

        private void bussToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Transportation frmBus = new Transportation("Add New Bus Info");
          
            if (frmBus.ShowDialog() == DialogResult.OK)
            {
                transportMngr.AddBus(frmBus.TransportData);
                UpdateBusList ();
            }
        }

        private void UpdateBusList()
            {
            StreamWriter twBus = null;

            FileStream fsBus = new FileStream("BusDetails.txt", FileMode.Append);

            try
            {

                twBus  = new StreamWriter(fsBus );
                int index1 = 0;
                index1 = (transportMngr.CountBusses  - 1);
                twBus.WriteLine(transportMngr.GetBus(index1).ToString());


            }
            catch (Exception e)
            {
                MessageBox.Show ("Exception: " + e.Message);
            }
            finally
            {
                twBus.Close();
            }
            }
            private void UpdateFlightList()
                {
            StreamWriter twFlight = null;

            FileStream fsFlight = new FileStream("FlightDetails.txt", FileMode.Append);

            try
            {

                twFlight  = new StreamWriter(fsFlight );
                int index3 = 0;
                index3 = (transportMngr.CountFlights  - 1);
                twFlight.WriteLine(transportMngr.GetFlight(index3).ToString());


            }
            catch (Exception e)
            {
                MessageBox.Show ("Exception: " + e.Message);
            }
            finally
            {
                twFlight.Close();
            }
                }

        private void UpdateTrainList()
        {
            StreamWriter twTrain = null;

            FileStream fsTrain = new FileStream("TrainDetails.txt", FileMode.Append);

            try
            {

                twTrain  = new StreamWriter(fsTrain );
                int index2 = 0;
                index2 = (transportMngr.CountTrains  - 1);
                twTrain.WriteLine(transportMngr.GetTrain(index2).ToString());


            }
            catch (Exception e)
            {
                MessageBox.Show ("Exception: " + e.Message);
            }
            finally
            {
                twTrain.Close();
            }
        }

        private void flightToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Transportation frmFlight = new Transportation("Add New Flight Info");
            

            if (frmFlight.ShowDialog() == DialogResult.OK)
            {
                transportMngr.AddFlight(frmFlight.TransportData);
                UpdateFlightList ();
            }
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
            if(ValidInput())
        {
            SelectTime frmSelectTime = new SelectTime(cmbTranportation.SelectedIndex+1,SelectTitle());
            frmSelectTime.SetValues(cmbFrom.SelectedItem.ToString(), cmbTo.SelectedItem.ToString());
            if(frmSelectTime.ShowDialog() == DialogResult.OK)
                {
                    lblCustomerName.Text = cmbCustomer.SelectedItem.ToString();
                    string[] str = customerMngr.GetDetails(lstCustomers.Items[cmbCustomer.SelectedIndex].ToString());
                    lblCustomerPhone.Text = str[2];
                    lblReservationUpto.Text = frmSelectTime.Detail;
                    lblPrice.Text = GetPrice().ToString("#.##");

            AddReservations(lblCustomerName.Text, lblCustomerPhone.Text, lblReservationUpto.Text, lblPrice.Text);
                }
                else
                {
                    AddReservations("Nothing available",string.Empty,string.Empty,string.Empty);
                }
         }
            else
            {
                MessageBox.Show("Please select all fields", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
                }

        }

        private void AddReservations(string name, string phone, string fromto, string price)
        {
            reservation = string.Format("{0}- Phone:{1,10}- Details:{2,-10}- Price: {3,20} SEK", name, phone,fromto, price);
            lstReservations.Items.Add(reservation);
            UpdateReservations();
        }

        private void UpdateReservations()
        {
            StreamWriter twReservation = null;

            FileStream fsReservation = new FileStream("Reservations.txt", FileMode.Append);

            try
            {

                twReservation = new StreamWriter(fsReservation);
                int index3 = 0;
                index3 = (transportMngr.CountFlights - 1);
                twReservation.WriteLine(transportMngr.GetFlight(index3).ToString());


            }
            catch (Exception e)
            {
                MessageBox.Show("Exception: " + e.Message);
            }
            finally
            {
                twReservation.Close();
            }
        }

        private decimal  GetPrice()
        {
            decimal price;
            if(cmbTranportation.SelectedIndex == 0)
            {
                Bus bus = new Bus();
                price = bus.GetPrice((int)numericAdults.Value, (int)numericChildren.Value);
            }
            else if (cmbTranportation.SelectedIndex == 1)
            {
                Train train = new Train();
                price = train.GetPrice((int)numericAdults.Value, (int)numericChildren.Value);
            }
            else
            {
                Flight flight = new Flight();
                price = flight.GetPrice((int)numericAdults.Value, (int)numericChildren.Value);
            }
            if(checkBoxLessThan2.Checked == true)
            {
                return price * 0.15M;
            }
            {
                return price;
            }
        }

        private string SelectTitle()
        {
            string str = string.Empty;
            if (cmbTranportation.SelectedIndex == 0)
                str = "Select Bus";
            else if(cmbTranportation.SelectedIndex == 1)
                str = "Select Train";
            else
             str = "Select Flight";

            return str;

        }

        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (lstCustomers.Items.Count != 0)
            {
                int index = lstCustomers.SelectedIndex;
                customerMngr.Customers = storedCustomers;
                customerMngr.Names = storeNames;
                //show error if no index is selected, otherwise call the removeCustomer method of customerMngr for
                //deleting specific customerdetails at selected index
                if (index == -1)
                {
                    MessageBox.Show("Please select an index", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                customerMngr.RemoveCustomer(index);
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

        public bool ValidInput() 
        {
            if (cmbFrom.SelectedItem.ToString() == cmbTo.SelectedItem.ToString())
            {
                MessageBox.Show("Select different Stations", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                lblFrom.Text = "From*";
                lblTo.Text = "To*";
                return false;
            }
            if(cmbCustomer.SelectedIndex == -1)
            {
                MessageBox.Show("Select Customer", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                lblName.Text = "Customer Name*";
                return false;
            }

            if (numericAdults.Value == 0 || numericChildren.Value == 0)
            {
                MessageBox.Show("At least one passenger must be selected", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                lblPassengers.Text = "No.Of Passengers *";
                return false;
            }

            if(cmbTranportation.SelectedIndex == -1)
            {
                MessageBox.Show("Select Transportation Type", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                lblTransportType.Text = "Select the means of Transportaione*";
                return false;
            }
            return true;
        }
    }
}
