using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ORS
{
   public class CustomerContacts
    {
        private string m_firstName;
        private string m_lastName;
        private string m_phone;
        private string m_email;

        public string FirstName 
        { 
            get 
            {
                return m_firstName;
            } 
            set
            {
                m_firstName = value;
            }
        }

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

        public string FullName
        {
            get
            {
                return m_firstName + " " + m_lastName;
            }
        }

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

        public CustomerContacts(string firstName, string lastName, string phone, string email)
        {
            m_firstName = firstName;
            m_lastName = lastName;
            m_phone = phone;
            m_email = email;
        }

        public CustomerContacts() : this(string.Empty, string.Empty,string.Empty,string.Empty)
        { }

        public override string ToString()
        {
            string str = string.Format("{0,-15} {1} {2}", FullName, m_phone.ToString(),m_email.ToString());
            return str;
        }
    }
}
