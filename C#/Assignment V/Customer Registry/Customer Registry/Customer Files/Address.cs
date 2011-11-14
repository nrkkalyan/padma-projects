// File: Address.cs
// Created by: Padma Priya Duvvuri
// Created on: 08-Nov-2011


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Customer_Registry.Customer_Files
{
    /// <summary>
    /// This class stores the information of Address of the customer. 
    /// It calls list of enum from the contries.cs
    /// </summary>
   public class Address
    {
       // declaring fields
       private string m_city;
       private Countries m_country;
       private string m_street;
       private string m_strErrMessage;
       private string m_zipCode;

       // property to read and write m_city
       public string City
       {
           get { return m_city; }
           set { m_city = value; }
       }
       // property to read and write m_country
       public Countries Country
       {
           get { return m_country; }
           set { m_country = value; }
       }
       // property to read and write m_street
       public string Street
       {
           get { return m_street; }
           set { m_street = value; }
       }
       // property to read and write Error message
       public string ErrorMessage
       {
           get { return m_strErrMessage; }
           set { m_strErrMessage = value; }
       }
       // property to read and write m_zipCode
       public string ZipCode
       {
           get { return m_zipCode; }
           set { m_zipCode = value; }
       }

       // defining consturctors

       /// <summary>
       /// Constructor with 4 parameters.  This is  constructor that has most
       /// number of parameters. It is in tis constructor that all coding 
       /// should be done.
       /// </summary>
       /// <param name="street">Input - street name</param>
       /// <param name="zip">Input - zip code</param>
       /// <param name="city">Input - city name</param>
       /// <param name="country">Input - country name</param>
       public Address(string street, string zip, string city, Countries country)
       {
           m_city = city;
           m_street = street;
           m_zipCode = zip;
           m_country = country;
       }

       /// <summary>
       /// Constructor with three parameter - calls the constructor with 
       /// four parameters, using a default value as the fourth argument.
       /// </summary>
       /// <param name="street">Input - street name</param>
       /// <param name="zip">Input - zip code</param>
       /// <param name="city">Input - city name</param>
       public Address(string street, string zip, string city)
           : this(street,city,zip, Countries.Sverige)
       { }
       
       /// <summary>
       /// Default constructor - calls the constructor with 3 parameters,
       /// using default values.
       /// </summary>
       public Address() : this(string.Empty,string.Empty,string.Empty)
       {

       }

       /// <summary>
       /// To perform the validation for city and street names
       /// </summary>
       /// <returns></returns>
       public bool CheckData()
       {
           if (!InputUtility.CheckString(m_city))
           {
               m_strErrMessage = "Enter proper City name";
               return false;
           }
        else if (!InputUtility.CheckString(m_street))
           {
               m_strErrMessage = "Street name cannot be empty!";
               return false;
           }
           else
           return true;
       }

       /// <summary>
       /// Replaces the '_' character of the selected country name
       /// if it has any.
       /// </summary>
       /// <returns></returns>
       private string GetCountryString()
       {
           string strCountry = m_country.ToString();

           return strCountry.Replace('_', ' ');
       }

       /// <summary>
       /// Delivers a formatted string with data stored in the object. The values will
       /// appear as columns. 
       /// </summary>
       /// <returns></returns>
       public override string ToString()
       {
           string str = string.Format("{0,-10} {1,-5} {2,-8} {3,-13}", m_street, m_zipCode, m_city, GetCountryString());
           return str;
       }
    }
}
