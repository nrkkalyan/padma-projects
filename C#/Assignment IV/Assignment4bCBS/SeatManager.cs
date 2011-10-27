// SeatManager.cs
// Created by: Padma Priya Duvvuri
// Created on: 22-Oct-2011

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
        //Fields
        private readonly int m_totNumOfCols; // number of columsn in the cinema
        private readonly int m_totNumOfRows; // number of Rows in the cinema
        private string[,] m_nameMatrix; // two dimensional array for storing seat names

        // to define a number of choice
        public enum DisplayOptions
        {
            AllSeats,
            VacantSeats,
            ReservedSeats
        }

        /// <summary>
        /// Custructor with initial values for number of seats
        /// </summary>
        /// <param name="totNumOfRows">number of rows</param>
        /// <param name="totNumOfCols">number of columns</param>
        public SeatManager(int totNumOfRows, int totNumOfCols)
        { 
            // intialize the matrix to have total number of rows and columns
            m_totNumOfCols = totNumOfCols;
            m_totNumOfRows = totNumOfRows;
            m_nameMatrix = new string[m_totNumOfRows,m_totNumOfCols];
        }

        /// <summary>
        /// Calculate the number of seat reserved
        /// </summary>
        /// <returns>number of reserved seats</returns>
        public int GetNumReserved()
        {
            int count = 0;
            for (int i = 0; i < m_totNumOfRows; i++)
            {
                for (int j = 0; j < m_totNumOfCols; j++)
                {
                    if (m_nameMatrix[i, j] != null && m_nameMatrix[i,j] != String.Empty)
                        count++;
                }
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
            for (int i = 0; i < m_totNumOfRows; i++)
            {
                for (int j = 0; j < m_totNumOfCols; j++)
                {
                    if (m_nameMatrix[i, j] == null || m_nameMatrix[i, j] == String.Empty)
                        count++;
                }
            }
            return count;
        }

        /// <summary>
        /// Calculate the total number of seats
        /// </summary>
        /// <returns>total number of seats</returns>
        public int TotNumOfSeats()
        {
            return m_nameMatrix.Length;
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
                return TotNumOfSeats();
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
        public bool ReserveSeat(string name, int index)
        {
            int col = 0;
            int row = index;
            IndexToRowCol(ref row, ref col);
                if (CheckIndex(row, col))
                {
                    m_nameMatrix[row,col] = name;
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
            int col = 0;
            int row = index;
            IndexToRowCol(ref row, ref col);
            if (CheckIndex(row,col))
            {
                m_nameMatrix[row,col] = null;
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
        /// seat customername, price and whether the seat is
        /// reserved or vacant.</returns>
        public string GetSeatInfoAt(int index)
        {
            int col = 0;
            int row = index;
            IndexToRowCol(ref row, ref col);
            bool isValid = CheckIndex(row, col);

            if (isValid)
            {
                if (m_nameMatrix[row, col] == null || m_nameMatrix[row, col] == String.Empty)
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
        /// Returns the status for a seat in position = index
        /// </summary>
        /// <param name="index">Index of the array position</param>
        /// <returns>A formatted string containing information about the 
        /// seat whether the seat is
        /// reserved or vacant.</returns>
        public string GetSeatInfoAt(int row, int col)
        {
            bool isValid = CheckIndex(row, col);

            if (isValid)
            {
                if (m_nameMatrix[row, col] == null || m_nameMatrix[row, col] == String.Empty)
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
        /// Converts matrix row and col values into a single vector index value
        /// </summary>
        /// <param name="row">Row</param>
        /// <param name="col">Col</param>
        /// <returns>Index Value</returns>
        public int ConvertToIndex(int row, int col)
        {
            row = row < 0 ? 0 : row;
            col = col < 0 ? 0 : col;
            return ((row + 1) * (m_totNumOfRows)) - ((m_totNumOfRows) - col);
        }

        /// <summary>
        /// Determines the index in the matrix (row, col) that corresponds to a given
        /// index in a on.dim array(listbox). This method actully is a reverse process of the method 
        /// ConvertToIndex. The parameter row contains the input, i.e. index of the element in a one.dim array. 
        /// The results(row, col) are saved and sent back to the caller via the ref variables row,col.
        /// </summary>
        /// <param name="row">Input and output parameter</param>
        /// <param name="col">Output parameter</param>
        public void IndexToRowCol(ref int row, ref int col)
        {
            int indexRow = row;

            row = indexRow / m_totNumOfRows; // row in the matrix
            col = indexRow % m_totNumOfRows; // col in the matrix
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
            strSeatInfoStrings = new string[TotNumOfSeats()];

            if (count <= 0)
                return 0;
                string strOut = "Vacant  ";
                int index = 0; // counter for return array

                for (index = 0; index < TotNumOfSeats(); index++)
                    {
                            int row = index;
                            int col = 0;
                            IndexToRowCol(ref row, ref col);
                            strOut = GetSeatInfoAt(row,col);
                            strSeatInfoStrings[index] = string.Format("{0, -5}\t{1,4}\t{2,-10}\t {3} \n", row+1, col+1, strOut, m_nameMatrix[row, col]);

                            if (choice == DisplayOptions.ReservedSeats && !strOut.Equals("Reserved"))
                            {
                                strSeatInfoStrings[index] = null;
                            }
                            else if (choice == DisplayOptions.VacantSeats && !strOut.Equals("Vacant  "))
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
        private bool CheckIndex(int row, int col)
        {
            if ( row >= 0 && row < m_totNumOfRows && col >= 0 && col < m_totNumOfCols )
                return true;
            else
                return false;
        }
    }
}
