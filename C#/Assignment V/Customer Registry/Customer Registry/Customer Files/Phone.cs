using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Customer_Registry.Customer_Files
{
    public class Phone
    {
        private string m_home;
        private string m_cell;

        public Phone(string homePhone, string cellPhone)
        {
            m_cell = cellPhone;
            m_home = homePhone;
           
        }

        public Phone(string homePhone)
            :this(homePhone,string.Empty)
        { }

        public Phone()
            : this(string.Empty, string.Empty)
        { }

        public string Home
        {
            get { return m_home; }
            set { m_home = value; }
        }
        
        public string Cell
        {
            get { return m_cell; }
            set { m_cell = value; }
        }

        public override string ToString()
        {
            string strOut = string.Format("{0,-12} {1,-12}",m_home,m_cell);
            return strOut;
        }

    }
}
