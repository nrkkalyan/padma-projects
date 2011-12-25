// File Name: CustomerContacts.cs
// Created By: Padma Priya Duvvuri
// Created On: 23-Dec-2011

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ORS
{
    /// <summary>
    /// This class stores the information about a customer
    /// </summary>
   public class CustomerContacts
    {
       //Instance variables
        private string m_firstName; //first name of customer
        private string m_lastName; //last name of customer
        private string m_phone; //phone nubmer of customer
        private string m_email; //email of customer

       /// <summary>
       /// Read and Write property for m_firstName
       /// </summary>
        public string FirstName 
        { 
            get { return m_firstName; } 
            set { m_firstName = value; }
        }

        /// <summary>
        /// Read and Write property for m_lastName
        /// </summary>
       public string LastName
        {
            get
            {
                return m_lastName;
            }
            set
            {
                m_lastName = value;
            }
        }

       /// <summary>
       /// Read only property to get Full name of the customer
       /// </summary> 
       public string FullName
        {
            get
            {
                return m_firstName + " " + m_lastName;
            }
        }

        /// <summary>
        /// Read and Write property for m_email
        /// </summary> 
       public string Email 
        {
            get
            {
                return m_email;
            }
            set
            {
                m_email = value;
            }
        }
       /// <summary>
       /// Read and Write property for m_phone
       /// </summary> 
       public string Phone
       {
           get
           {
               return m_phone;
           }
           set
           {
               m_phone = value;
           }
       }

       /// <summary>
       /// Constructor that takes 4 parameters and sets the values
       /// </summary>
       /// <param name="firstName">first name of customer</param>
       /// <param name="lastName">last name of customer</param>
       /// <param name="phone">phone number of the customer</param>
       /// <param name="email">email of the customer</param>
        public CustomerContacts(string firstName, string lastName, string phone, string email)
        {
            m_firstName = firstName;
            m_lastName = lastName;
            m_phone = phone;
            m_email = email;
        }

       /// <summary>
       /// Defaults constructor that calls constructor having 4 parameters
       /// </summary>
       public CustomerContacts() : this(string.Empty, string.Empty,string.Empty,string.Empty)
       { }

       /// <summary>
       /// assigns the values of string array to customer contact details
       /// </summary>
       /// <param name="details">array of string containing customerInfo</param>
       public CustomerContacts(string[] details)
       {
            m_firstName = details[0];
            m_lastName = details[1];
            m_phone = details[2];
            m_email = details[3];
        }

       /// <summary>
       /// overrides the ToString() method to give formatted string having customer details
       /// </summary>
       /// <returns>formatted strings</returns>
        public override string ToString()
        {
            string str = string.Format("{0} ,{1} ,{2,10} , {3,20}", m_firstName, m_lastName, m_phone.ToString(), m_email.ToString());
            return str;
        }
    }
}
