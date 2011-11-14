//File: Customer.cs
//Created by: Padma Priya Duvvuri
//Created on: 10-Nov-2011

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Customer_Registry.Customer_Files
{
    public class Customer
    {
        //private fields
        private Contact m_contact;
        private string m_id;

        /// <summary>
        /// constructor that takes 2 parameters.
        /// And adds id for the customer
        /// </summary>
        /// <param name="contact">the contact object</param>
        /// <param name="id">id for the customer</param>
        public Customer(Contact contact, string id)
        {
            m_contact = contact;
            m_id = id;
        }

        /// <summary>
        /// constructor that takes 1 parameter.
        /// It calls the constructor with 2 parameters
        /// </summary>
        /// <param name="customerIn">Input - customer object</param>
        public Customer(Customer customerIn)
            : this(customerIn.ContactData, customerIn.ID)
        { }

        /// <summary>
        /// default constructor that creates a new contact 
        /// object
        /// </summary>
        public Customer(): this(new Contact())
        { }

        /// <summary>
        /// constructor with one parameter which calls the constructor
        /// with two parameters passing default value for id
        /// </summary>
        /// <param name="contactIn"></param>
        public Customer(Contact contactIn)
            : this(contactIn, string.Empty)
        { }


        /// <summary>
        /// Property related to the field contact object
        /// Both read and write access
        /// </summary>
        /// <value></value>
        /// <returns></returns>
        /// <remarks></remarks>
        public Contact ContactData
        {
            //private contact
            get { return m_contact;}
            set { m_contact = value; }
        }


        /// <summary>
        /// Property related to the field m_id
        /// Both read and write access
        /// </summary>
        /// <value></value>
        /// <returns></returns>
        /// <remarks></remarks>
        public string ID
        {
            //private id
            get { return m_id; }
            set { m_id = value; }
        }

        /// <summary>
        /// ovverrides the ToString() method to display
        /// formatted string having id and conact details of the customer
        /// </summary>
        /// <returns>formatted string</returns>
        public override string ToString()
        {
            return m_id+"   "+m_contact.ToString();
        }
    }
}
