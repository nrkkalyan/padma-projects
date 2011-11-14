// File: Address.cs
// Created by: Padma Priya Duvvuri
// Created on: 08-Nov-2011

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Customer_Registry.Customer_Files;

namespace Customer_Registry.Customer_Files
{
    public class Contact
    {
        //private address, email, phone objects and 
        //private firstname adn last name fields
        private Address m_address;
        private Email m_email;
        private string m_firstName;
        private string m_lastName;
        private Phone m_phone;

        /// <summary>
        /// Default constuctor. It calls constructor with 5 parameters
        /// passing the defaluts values.
        /// </summary>
        public Contact() : this(string.Empty, string.Empty, new Address(), new Email(), new Phone()) 
        { }

        /// <summary>
        /// Constructor with 5 parameters.This is  constructor that has most
        /// number of parameters. It is in tis constructor that all coding 
        /// should be done.
        /// </summary>
        /// <param name="firstName">Input - first name</param>
        /// <param name="lastName">Input - last name</param>
        /// <param name="adr">Input - address object</param>
        /// <param name="mail">Input - mail object</param>
        /// <param name="tel">Input - phone object</param>
        public Contact(string firstName, string lastName, Address adr, Email mail, Phone tel)
        {
            m_firstName = firstName;
            m_lastName = lastName;
            m_address = adr;
            m_email = mail;
            m_phone = tel;
        }


        /// <summary>
        /// Property related to the field m_address
        /// Both read and write access
        /// </summary>
        /// <value></value>
        /// <returns></returns>
        /// <remarks></remarks>
        public Address AddressData
        {
            // private adress field
            get {return m_address;}
            set {m_address = value;}
        }


        /// <summary>
        /// Property related to the field m_email
        /// Both read and write access
        /// </summary>
        /// <value></value>
        /// <returns></returns>
        /// <remarks></remarks>
        public Email EmailData
        {
            //private email value
            get { return m_email; }
            set { m_email = value; }
        }


        /// <summary>
        /// Property related to the field m_firstname
        /// Both read and write access
        /// </summary>
        /// <value></value>
        /// <returns></returns>
        /// <remarks></remarks>
        public string FirstName
        {
            //private firstname field
            get { return m_firstName; }
            set { m_firstName = value; }
        }


        /// <summary>
        /// Property related to the field m_LastName
        /// Both read and write access
        /// </summary>
        /// <value></value>
        /// <returns></returns>
        /// <remarks></remarks>
        public string LastName
        {
            //private last name field
            get { return m_lastName; }
            set { m_lastName = value; }
        }
        
        /// <summary>
        /// It creates a string full name by adding
        /// firstname and lastname
        /// </summary>
        public string FullName
        {
            get { return m_firstName + ", " + m_lastName; }
        }


        /// <summary>
        /// Property related to the field m_phone
        /// Both read and write access
        /// </summary>
        /// <value></value>
        /// <returns></returns>
        /// <remarks></remarks>
        public Phone PhoneData
        {
            //private phone field
            get { return m_phone; }
            set { m_phone = value; }
        }


        /// <summary>
        /// Delivers a formatted string with data stored in the object. The values will
        /// appear as columns. 
        /// </summary>
        /// <returns>the Formatted strings.</returns>
        /// <remarks></remarks>
        public override string ToString()
        {
            string str = string.Format("{0,-15} {1} {2} {3}", FullName, m_address.ToString(), m_phone.ToString(),m_email.ToString());
            return str;
        }

    }
}
