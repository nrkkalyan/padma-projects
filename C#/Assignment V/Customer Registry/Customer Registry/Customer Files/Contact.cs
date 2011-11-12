using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Customer_Registry.Customer_Files;

namespace Customer_Registry.Customer_Files
{
    public class Contact
    {
        private Address m_address;
        private Email m_email;
        private string m_firstName;
        private string m_lastName;
        private Phone m_phone;

        public Contact() : this(string.Empty, string.Empty, new Address(), new Email(), new Phone()) 
        { }

        public Contact(string firstName, string lastName, Address adr, Email mail, Phone tel)
        {
            m_firstName = firstName;
            m_lastName = lastName;
            m_address = adr;
            m_email = mail;
            m_phone = tel;
        }


        public Address AddressData
        {
            get {return m_address;}
            set {m_address = value;}
        }

        public Email EmailData
        {
            get { return m_email; }
            set { m_email = value; }
        }
        public string FirstName
        {
            get { return m_firstName; }
            set { m_firstName = value; }
        }
        public string LastName
        {
            get { return m_lastName; }
            set { m_lastName = value; }
        }
        public string FullName
        {
            get { return m_firstName + ", " + m_lastName; }
        }
        public Phone PhoneData
        {
            get { return m_phone; }
            set { m_phone = value; }
        }


        public override string ToString()
        {
            string str = string.Format("{0} {1} {2} {3}", FullName, m_address.ToString(), m_phone.ToString(),m_email.ToString());
            return str;
        }

    }
}
