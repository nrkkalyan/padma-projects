// InputUtility.cs
// Created By: Padma Priya Duvvuri
// Created On: 02-Oct-2011

///<summary>
///This class validates the user and test the user input
///and if the input is valid then the value is stored in assigned variables.
///</summary>

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Globalization;


    public class InputUtility
    {
        /// <summary>
        /// Converts a string representated Double value into a Double type, and validates 
        /// the converted value to be within (and inclusive) a range, defined by minLimit and
        /// maxLimit.
        /// </summary>
        /// <param name ="stringToConvert"> string representing the Double value. </param>
        /// <param name="dblOutValue"> output parameter, the converted Double value. </param>
        /// <param name="minLimit"> the output value should be greater or equal to minLimit. </param>
        /// <param name="maxLimit"> the output value should be less than or equal to maxLimit. </param>
        /// <returns> 
        /// true if the conversion is successful and the converted value is within the 
        /// given range
        /// </returns>


        public static bool GetDouble(string stringToConvert, out double dblOutValue, double minLimt, double maxLimit)
        {
          
           // parsing the string to check for whether value is double value or not
            bool isDouble = Double.TryParse(stringToConvert, out dblOutValue); 
            if (isDouble == true)
            {
                // if dblOutValue is within the range return true
                bool returnvalue = (dblOutValue >= minLimt && dblOutValue <= maxLimit);
                return returnvalue;
                
            }
            // return false if the value is not validated as a double
            return false;

        }

        ///<summary>
        ///Overloading the GetDouble method so it can be used when a string is to be converted
        ///to a numerical value with only minLimit Condition
        /// </summary>
        /// <param name ="stringToConvert"> string representing the Double value. </param>
        /// <param name="dblOutValue"> output parameter, the converted Double value. </param>
        /// <param name="minLimit"> the output value should be greater or equal to minLimit. </param>
        /// <returns> 
        /// true if the conversion is successful and the converted value greater than or equal to the 
        /// minLimt
        /// </returns>

        public static bool GetDouble(string stringToConvert, out double dblOutValue, double minLimt)
        {
            // parsing the string to check for whether value is double value or not
            bool isDouble = double.TryParse(stringToConvert, out dblOutValue);
            if (isDouble == true)
            {
                // if dblOutValue is greater than the min value
                return (dblOutValue >= minLimt);
            }
            // return false if the value is not validated as a double
            return false;

        }


        ///<summary>
        ///Overloading the GetDouble method so it can be used when a string is to be converted
        ///to a numerical value without any min and max conditions.
        /// </summary>
        /// <param name ="stringToConvert"> string representing the Double value. </param>
        /// <param name="dblOutValue"> output parameter, the converted Double value. </param>
        /// <returns> 
        /// true if the conversion is successful
        /// </returns>

        public static bool GetDouble(string stringToConvert, out double dblOutValue)
        {
            // parsing the string to check for whether value is double value or not
            bool isDouble = double.TryParse(stringToConvert, out dblOutValue);
            if (isDouble == true && dblOutValue > 0.0D)
            {
                // return true if value is a double
                return true;
            }
            // return false if the value is not validated as a double
            return false;

        }

        /// <summary>
        /// Converts a string representated Integer value into a Interger type, and validates 
        /// the converted value to be within (and inclusive) a range, defined by minLimit and
        /// maxLimit.
        /// </summary>
        /// <param name ="stringToConvert"> string representing the Integer value. </param>
        /// <param name="intOutValue"> output parameter, the converted Integer value. </param>
        /// <param name="minLimit"> the output value should be greater or equal to minLimit. </param>
        /// <param name="maxLimit"> the output value should be less than or equal to maxLimit. </param>
        /// <returns> 
        /// true if the conversion is successful and the converted value is within the 
        /// given range
        /// </returns>
         public static bool GetInteger(string stringToConvert, out int intOutValue, int minLimt, int maxLimit)
        {
            // parsing the string to check for whether value is integer value or not
            bool isInteger = int.TryParse(stringToConvert, out intOutValue);
            if (isInteger == true)
            {
                // if intOutValue is within the range return true
                return (intOutValue >= minLimt && intOutValue <= maxLimit);
            }
            // return false if the value is not validated as a integer
            return false;

        }

        ///<summary>
        ///Overloading the GetInteger method so it can be used when a string is to be converted
        ///to a numerical value with only minLimit Condition
        /// </summary>
        /// <param name ="stringToConvert"> string representing the Integer value. </param>
        /// <param name="intOutValue"> output parameter, the converted Integer value. </param>
        /// <param name="minLimit"> the output value should be greater or equal to minLimit. </param>
        /// <returns> 
        /// true if the conversion is successful and the converted value is within the 
        /// given range
        /// </returns>

        public static bool GetInteger(string stringToConvert, out int intOutValue, int minLimt)
        {
            // parsing the string to check for whether value is double value or not
            bool isInteger = int.TryParse(stringToConvert, out intOutValue);
            if (isInteger == true)
            {
                // if intOutValue is greater than the min value
                return (intOutValue >= minLimt);
            }
            // return false if the value is not validated as a integer
            return false;

        }


        ///<summary>
        ///Overloading the GetInteger method so it can be used when a string is to be converted
        ///to a numerical value with no min or max conditions
        /// </summary>
        /// <param name ="stringToConvert"> string representing the Integer value. </param>
        /// <param name="intOutValue"> output parameter, the converted Integer value. </param>
        /// <returns> 
        /// true if the conversion is successful and the converted value is within the 
        /// given range
        /// </returns>

        public static bool GetInteger(string stringToConvert, out int intOutValue)
        {
            // parsing the string to check for whether value is double value or not
            bool isInteger = int.TryParse(stringToConvert, out intOutValue);
            if (isInteger == true)
            {
                // return true if the value is validated as a integer
                return true;
            }
            // return false if the value is not validated as a integer
            return false;

        }


        /// <summary>
        /// Converts the string value to long value. If the parsing is successfull
        /// returns the long value
        /// </summary>
        /// <param name="stringToConvert"> string to be converted</param>
        /// <param name="longOutValue">long valued output parameter</param>
        /// <returns></returns>
        public static bool GetLong(string stringToConvert, out long longOutValue)
        {
            // parsing the string to check for whether value is double value or not
            bool isLong = long.TryParse(stringToConvert, out longOutValue);
            if (isLong == true)
            {
                // return true if the value is validated as a integer
                return true;
            }
            // return false if the value is not validated as a integer
            return false;

        }


        /// <summary>
        /// this method validates the name. If it contains any any white spaces or does not contain any value
        /// it returns true.
        /// </summary>
        /// <param name="name">the value inputted by the user</param>
        /// <returns>true if name is empty or a blank space</returns>
        public static bool CheckString(string name)
        {
            bool isNotValid = string.IsNullOrEmpty(name) || string.IsNullOrWhiteSpace(name);
            if (isNotValid)
                return false;
            else
                return true;
        }

    }

