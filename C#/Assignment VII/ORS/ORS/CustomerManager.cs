// File Name: CustomerManager.cs
// Created By: Padma Priya Duvvuri
// Created On: 23-Dec-2011

using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using System.IO;
using System.Collections;

namespace ORS
{
    /// <summary>
    /// A manager class that acts as a media between MainForm and the CustomerContacts Class
    /// </summary>
    class CustomerManager
    {
        //private arraylist to store customer details
        private ArrayList customers;
        private ArrayList names;

        /// <summary>
        /// default constructor. It creates a new arraylist object.
        /// </summary>
        public CustomerManager()
        {
            customers = new ArrayList();
            names = new ArrayList();
        }

        /// <summary>
        /// Read and Write propety for customers arraylist
        /// </summary>
        public ArrayList Customers { 
            get {return customers;}
            set { customers = value; } }
        
        /// <summary>
        /// Read and Write propery for names arraylist
        /// </summary>
        public ArrayList Names {
            get { return names; }
            set { names = value; }
        }

        /// <summary>
        /// implementd if needed.
        /// </summary>
        public CustomerContacts contact
        {
            get; set; }


        /// <summary>
        /// It counts the number of customers objects that are 
        /// present in the arraylist.
        /// </summary>
        /// <returns>no.of customers present</returns>
        public int CountCustomers
        {
            get { return customers.Count; }
        }


        /// <summary>
        /// It stores the new customer details entered by the user, and returns
        /// true if added.
        /// </summary>
        /// <param name="customerIn">Input - customer details</param>
        /// <returns>True when the new customer is added</returns>
        public bool AddCustomer(CustomerContacts customerIn)
        {
            customers.Add(customerIn);
            names.Add(customerIn.FullName);
            return true;
        }
        /// <summary>
        /// validates the index of the array list.
        /// </summary>
        /// <param name="index">selected index</param>
        /// <returns>true if index is less than the arraysize</returns>
        private bool IsValidIndex(int index)
        {
            if (index >= 0 && index <= CountCustomers)
                return true;
            else
                return false;
        }

        /// <summary>
        /// If the index is valid then it will allow the updation 
        /// of the fields
        /// </summary>
        /// <param name="contactIn">details of selected customer</param>
        /// <param name="index">selected index</param>
        /// <returns>true if value is changed</returns>
        public bool ChangeCustomer(CustomerContacts contactIn, int index)
        {
            if (IsValidIndex(index))
            {
                
                string str = customers[index].ToString();
                string[] details = InputUtility.GetWords(contactIn.ToString());
                //create a new customercontacts object with selected string values
                CustomerContacts customer = new CustomerContacts(details);
                customers.RemoveAt(index);
                names.RemoveAt(index);
                customers.Insert(index, customer);
                names.Insert(index, customer.FullName);
                return true;
            }
            else
                return false;
        }

        /// <summary>
        /// If index is valid then it will remove that customer 
        /// from the arraylist.
        /// </summary>
        /// <param name="index">index at which customer need to be deleted</param>
        /// <returns></returns>
        public bool RemoveCustomer(int index)
        {
            if (IsValidIndex(index))
            {
                customers.RemoveAt(index);
                names.RemoveAt(index);
                return true;
            }
            else
                return false;
        }

        /// <summary>
        /// returns the customer object at the selected 
        /// index of the customers arraylist
        /// </summary>
        /// <param name="index">selected index by the user</param>
        /// <returns>customer object</returns>
        public CustomerContacts GetCustomer(int index)
        {
            return (CustomerContacts)customers[index];
        }

 
        /// <summary>
        /// Gets the value of string at a perticular index of names arrayList
        /// </summary>
        /// <param name="index">index</param>
        /// <returns>a name as string</returns>
        public string  GetName(int index)
        {
            return (string)names[index];
        }
         
        
    }
}
