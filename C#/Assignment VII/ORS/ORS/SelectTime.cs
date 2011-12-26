// File Name: SelectTime.cs
// Created By: Padma Priya Duvvuri
// Created On: 25-Dec-2011

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
    /// <summary>
    /// This form shows the available transport between the locations provided
    /// by the user in the main form.
    /// </summary>
    public partial class SelectTime : Form
    {
        //flag to handle the closing of the form
        private bool closeForm;
        private ArrayList  details; //to store the transports between user provided locations or stations
        private string detail; //get selected transport details
        private string fromStation; //from station
        private string toStation;//tostation
        private ArrayList listBoxDetails; //to show the filtered results to the user

        /// <summary>
        /// Constructor that takes 4 paramerters
        /// </summary>
        /// <param name="choice">To get user choice of transport</param>
        /// <param name="title">Title of the form</param>
        /// <param name="from">from station</param>
        /// <param name="to">to station</param>
        public SelectTime(int choice, string title,string from, string to)
        {
            InitializeComponent();
            lstSelectedTime.Items.Add(string.Empty); 
            lstSelectedTime.SetSelected(0,true);
            
            this.Text = title;
            SetValues(from, to); //get the user selected stations
            ReadTransportFiles(choice); //read the transportdetails
        
            listBoxDetails = new ArrayList();
            FilterResults(); //filter the results to match customer needs
            detail = string.Empty;
        }

        /// <summary>
        /// Read and write property for listBoxDetails
        /// </summary>
        public ArrayList  ListBoxDetails 
        {
            get { return  listBoxDetails; }
            set { value = listBoxDetails; }
        }

        /// <summary>
        /// Depending on user selected stations filter the results
        /// and show them in listbox
        /// </summary>
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
            //add the results to the listboxdetails for the use in main menu
            listBoxDetails.AddRange(lstSelectedTime.Items);
        }

        /// <summary>
        /// Set the values of user selected station to the use if for filter results
        /// </summary>
        /// <param name="from"></param>
        /// <param name="to"></param>
        private void SetValues(string from, string to)
        {
            fromStation = from;
            toStation = to;
        }

        /// <summary>
        /// Depening on user choice of transport, read the corresponding 
        /// files
        /// </summary>
        /// <param name="choice"></param>
        private void ReadTransportFiles(int choice)
        {
            details = new ArrayList();
            switch(choice)
            { 
                //For Bus
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
                //for train
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
                            trTransportTrain.Close();
                        }
                        catch (Exception e)
                        {
                            //MessageBox.Show ("Exception: " + e.Message);
                            return;
                        }
                        break;
                    }
                 //for flight
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

        /// <summary>
        /// Read and write property for detail variable
        /// </summary>
        public string Detail { get { return detail; } set { value = detail; } }

        /// <summary>
        /// stores the value of user selected choice of travel time
        /// </summary>
        /// <returns>a string containing the user choice</returns>
        public  string GetValue()
        {
            string str = lstSelectedTime.SelectedItem.ToString();
            return str;
       
        }

        /// <summary>
        /// Event handler for Click event of btnContinue button
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnContinue_Click(object sender, EventArgs e)
        {
            //If no matching transport is found get the selected string else show the messsage
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

        /// <summary>
        /// Event-handler for Click for btnBack button. If this button is clicked reservation
        /// will not be continued.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnBack_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.No;
        }

       
    }
}
