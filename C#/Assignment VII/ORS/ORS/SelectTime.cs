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
    public partial class SelectTime : Form
    {
        //flag to handle the closing of the form
        private bool closeForm;
        private ArrayList  details;
        private string detail;
        private string fromStation;
        private string toStation;
        private ArrayList listBoxDetails;

        public SelectTime(int choice, string title,string from, string to)
        {
            InitializeComponent();
            lstSelectedTime.Items.Add(string.Empty);
            lstSelectedTime.SetSelected(0,true);
            
            this.Text = title;
            SetValues(from, to);
            ReadTransportFiles(choice);
        
            listBoxDetails = new ArrayList();
            FilterResults();
            detail = string.Empty;

            
        }
        public ArrayList  ListBoxDetails 
        {
            get
            {
               return  listBoxDetails ;
            }
            set
            {
                value = listBoxDetails;
            }
        }

        private void FilterResults()
        {
            lstSelectedTime.Items.Clear();
            foreach (string str in details)
                {
                    string[] fromString = InputUtility.GetWords(str);
                      if(fromString[1]==fromStation && fromString[2]==toStation)
                        {
                            lstSelectedTime.Items.Add(str);
                        }
                    
                }
            listBoxDetails.AddRange(lstSelectedTime.Items);
        }

        private void SetValues(string from, string to)
        {
            fromStation = from;
            toStation = to;
        }

        private void ReadTransportFiles(int choice)
        {
            details = new ArrayList();
            switch(choice)
            { 
                case 1:
                    {
                     string transportBus;
            
            StreamReader trTransportBus = null;
           
            try
            {
                //to fill names combobx
                trTransportBus = new StreamReader("BusDetails.txt");
                transportBus  = trTransportBus.ReadLine();
                while (transportBus  != null)
                {
                    details.Add(transportBus);
                    transportBus  = trTransportBus.ReadLine();
                }

                trTransportBus.Close();
                
            }
            catch (Exception e)
            {
                //MessageBox.Show ("Exception: " + e.Message);
                return;
            }
            break;
                    }
                case 2:
                    {
                        string transportTrain;

                        StreamReader trTransportTrain = null;

                        try
                        {
                            //to fill names combobx
                            trTransportTrain = new StreamReader("TrainDetails.txt");
                            transportTrain = trTransportTrain.ReadLine();
                            while (transportTrain != null)
                            {
                                details.Add(transportTrain);
                                transportTrain = trTransportTrain.ReadLine();
                            }
                        }
                        catch (Exception e)
                        {
                            //MessageBox.Show ("Exception: " + e.Message);
                            return;
                        }
                        break;
                    }
                case 3:
                    {
                        string transportFlight;

                        StreamReader trTransportFlight = null;

                        try
                        {
                            //to fill names combobx
                            trTransportFlight  = new StreamReader("FlightDetails.txt");
                            transportFlight = trTransportFlight.ReadLine();
                            while (transportFlight != null)
                            {

                                details.Add(transportFlight);
                                transportFlight = trTransportFlight.ReadLine();

                            }

                            trTransportFlight.Close();

                        }
                        catch (Exception e)
                        {
                            //MessageBox.Show ("Exception: " + e.Message);
                            return;
                        }
                        break;
                    }

            }
            
        }

        public string Detail { get { return detail; } set { value = detail; } }

        public  string GetValue()
        {
            string str = lstSelectedTime.SelectedItem.ToString();
                return str;
       
        }



        private void btnContinue_Click(object sender, EventArgs e)
        {
            if (lstSelectedTime.SelectedIndex != -1)
                {
                detail = GetValue();
                
                this.DialogResult = DialogResult.OK;
                }
            else
            {
                MessageBox.Show("Please select an index", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            
        }

        /// <summary>
        /// Event hadler for formclosing event event of the form
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void SelectTime_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (closeForm)
                e.Cancel = false;
            else
                e.Cancel = true;
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.No;
        }

       
    }
}
