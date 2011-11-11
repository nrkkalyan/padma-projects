using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Customer_Registry.Customer_Files
{
    public class Phone
    {
        private string m_home;
        private string m_other;
        private string m_work;

        public Phone(string homePhone, string workPhone, string otherPhone)
        {
            m_home = homePhone;
            m_work = workPhone;
            m_other = otherPhone;
        }

        public Phone(string homePhone, string workPhone)
            :this(homePhone,workPhone,string.Empty)
        { }

        public Phone()
            : this(string.Empty, string.Empty)
        { }

        public string Home
        {
            get { return m_home; }
            set { m_home = value; }
        }
        public string Work
        {
            get { return m_work; }
            set { m_work = value; }
        }
        public string Other
        {
            get { return m_other; }
            set { m_other = value; }
        }

        public override string ToString()
        {
            string strOut = string.Format("{0} {1} {2}", m_home, m_work,m_other);
            return strOut;
        }
    }
}
