using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using System.IO;
using System.Collections;

namespace ORS
{
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
        /// It counts the number of customers objects that are 
        /// present in the arraylist.
        /// </summary>
        /// <returns>no.of customers present</returns>
        public int CountCustomers
        {
            get { return customers.Count; }
        }

        /// <summary>
        /// It counts the number of customers objects that are 
        /// present in the arraylist.
        /// </summary>
        /// <returns>no.of customers present</returns>
        public int CountNames
        {
            get { return names.Count; }
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
            if (index >= 0 && index < CountCustomers)
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

                CustomerContacts customer = (CustomerContacts)customers[index];
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

        public string  GetName(int index)
        {
            return (string)names[index];
        }
         
        
    }
}
