    // SeatManager.cs
// Created by: Padma Priya Duvvuri
// Created on: 21-Oct-2011

///<summary>
///This class performs necessary operations to manage the seat details that 
///are reserved or not reserved along with the calculations needed to 
///cancel a reservation.
///</summary>
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Assignment4CBS
{
    class SeatManager
    {
        // declaring variables to store total number of seats, names and Price
        private int m_totNumOfSeats;
        private string[] m_nameList;
        private double[] m_price;

        // to define a number of choice
        public enum DisplayOptions
        {
            AllSeats,
            VacantSeats,
            ReservedSeats
        }

        /// <summary>
        /// Constructor - to perform initialization for the class level variables
        /// </summary>
        /// <param name="maxNumberOfSeats">Total Number of seats</param>
        public SeatManager(int maxNumberOfSeats)
        {
            //only time m_totaNumOfSeats can be assigned a value
            m_totNumOfSeats = maxNumberOfSeats;
            m_nameList = new string[m_totNumOfSeats];
            m_price = new double[m_totNumOfSeats];
        }

        /// <summary>
        /// Calculate the number of seat reserved
        /// </summary>
        /// <returns>number of reserved seats</returns>
        public int GetNumReserved()
        {
            int count = 0;
            for (int i = 0; i < m_totNumOfSeats; i++)
            {
                if (m_nameList[i] != null && m_nameList[i] != String.Empty)
                    count++;
            }
            return count;
        }

        /// <summary>
        /// Calculate the number of seat that are vacant
        /// </summary>
        /// <returns>number of vacant seats</returns>
        public int GetNumVacant()
        {
            int count = 0;
            for (int i = 0; i < m_totNumOfSeats; i++)
            {
                if (m_nameList[i] == null || m_nameList[i] == String.Empty)
                    count++;
            }
            return count;
        }


        /// <summary>
        /// Get number of seats depending on the value of choice 
        /// defined in the enum DisplayOptions
        /// </summary>
        /// <param name="choice"> a member of the enum DisplayOption</param>
        /// <returns>The number of seats for the chosen option</returns>
        public int GetNumOfSeats(DisplayOptions choice)
        {
            if (choice == DisplayOptions.ReservedSeats)
                return GetNumReserved();
            else if (choice == DisplayOptions.VacantSeats)
                return GetNumVacant();
            else
                return m_totNumOfSeats;
        }

        /// <summary>
        /// Adds a reservation. Save name in the nameList and the price int the
        /// price list int the position index
        /// </summary>
        /// <param name="name">name of the cinema customer</param>
        /// <param name="price">Price paid for the seat</param>
        /// <param name="index">Index of the array position</param>
        /// <returns>True if seat is successfully reserved, false if it is already
        /// occupied</returns>
        public bool ReserveSeat(string name, double price, int index)
        {
                if (CheckIndex(index))
                {
                    m_price[index] = price;
                    m_nameList[index] = name;
                    return true;
                }
                else
                    return false;
        }

        /// <summary>
        /// Cancel a reservation. Assign a value Nothing in the nameList, and 0.0D in the
        /// priceList in the position = index
        /// </summary>
        /// <param name="index">Index for array position</param>
        /// <returns>true if seat was successfully cancelled, false if the seat already is
        /// occupied</returns>
        public bool CancelSeat(int index)
        {
            if (CheckIndex(index))
            {
                m_price[index] = 0.0d;
                m_nameList[index] = null;

                return true;
            }
            else
                return false;
        }

        /// <summary>
        /// Returns the status for a seat in position = index
        /// </summary>
        /// <param name="index">Index of the array position</param>
        /// <returns>A formatted string containing information about the 
        /// seat whether the seat is
        /// reserved or vacant.</returns>
        public string GetSeatInfoAt(int index)
        {
            
            bool isValid = CheckIndex(index);

            if (isValid)
            {
                if (m_nameList[index] == null || m_nameList[index] == String.Empty)
                {
                    return "Vacant  ";
                }
                else
                    return "Reserved";
            }
            else
            { 
                return null;
            }

            
        }

        /// <summary>
        /// This method prepares an array of string with information about all seats.
        /// Each element is a string formatted using the GetSeatInfo function.
        /// </summary>
        /// <param name="choice">Choice of seats that needs to be displayed</param>
        /// <param name="strSeatInfoStrings"> updates the array</param>
        /// <returns></returns>
        public int GetSeatInfoStrings(DisplayOptions choice, out string[] strSeatInfoStrings)
        {
            int count = GetNumOfSeats(choice);
            strSeatInfoStrings = new string[m_totNumOfSeats];

            if (count <= 0)
                return 0;
            string strOut = "Vacant  ";
            int i = 0; // counter for return array
            //is the element corresponding with the index empty
            for (int index = 0; index < m_totNumOfSeats; index++)
            {
                strOut = GetSeatInfoAt(index);
                
                strSeatInfoStrings[index] = string.Format("{0,-5}\t{1,15} {2,10}\t {3} \n", ++i, strOut, m_price[index].ToString("F"), m_nameList[index]);
                
                if (choice == DisplayOptions.ReservedSeats && !strOut.Equals("Reserved"))
                {
                    strSeatInfoStrings[index] = null;        
                }
                
                if (choice == DisplayOptions.VacantSeats  && !strOut.Equals("Vacant  "))
                {
                    strSeatInfoStrings[index] = null;            
                }
                        
             }
                
            return count;
        }

        /// <summary>
        /// Check so the value of an index is within the array range,
        /// i.e index >= 0 and index is less than m-totNumOfSeats.
        /// </summary>
        /// <param name="index">index of parameter</param>
        /// <returns>true if the index is within the range, false
        /// otherwise</returns>
        /// <remarks></remarks>
        private bool CheckIndex(int index)
        {
            if (index >= 0 && index <= m_totNumOfSeats)
                return true;
            else
                return false;
        }
    }
}
