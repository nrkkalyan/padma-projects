'File Name: InputUtility.vb
'Created by: Padma Priya Duvvuri
'Created on: 04-Oct-2011

Option Explicit On
Option Strict On
''' <summary>
''' This class holds the shared methods which are used to validate the user inputs.
''' It validates double, string and integer inputs
''' </summary>
''' <remarks></remarks>

Public Class InputUtility

    ''' <summary>
    ''' Converts a string represented double value into a double type, and validates
    ''' the converted value to be within (and inclusive) a range, defined by minLimit and
    ''' max Limit
    ''' </summary>
    ''' <param name="stringToConvert">string representing the double value</param>
    ''' <param name="dblOutValue">output parameter, the converted double</param>
    ''' <param name="minLimit">output value should be greater than or equal to minLimit</param>
    ''' <param name="maxLimit">output value should be less than or equal to maxLimit</param>
    ''' <returns>true if the conversion is successful and value is within the 
    ''' given range</returns>
    ''' <remarks></remarks>
    Public Shared Function GetDouble(ByVal stringToConvert As String, ByRef dblOutValue As Double, _
                                     ByVal minLimit As Double, ByVal maxLimit As Double) As Boolean
        ' parsing the string to check for whether value is dobule value or not
        Dim isDouble As Boolean = Double.TryParse(stringToConvert, dblOutValue)
        If isDouble = True Then
            'if dblOutValue within the range then return true
            Dim returnValue As Boolean = ((dblOutValue >= minLimit And dblOutValue <= maxLimit))
            Return returnValue
        End If
        'return false if the value is not validated as double
        Return False
    End Function


    ''' <summary>
    ''' Overloading the GetDouble Function so it can be used when a string is to be converted
    ''' to a numerical value with only minLimit Condition
    ''' </summary>
    ''' <param name="stringToConvert">string representing the double value</param>
    ''' <param name="dblOutValue">output parameter, the converted double</param>
    ''' <param name="minLimit">output value should be greater than or equal to minLimit</param>
    ''' <returns> true if the converstion is successful and the value is greater than or 
    ''' equal to minLimt</returns>
    ''' <remarks></remarks>
    Public Shared Function GetDouble(ByVal stringToConvert As String, ByRef dblOutValue As Double, _
                                     ByVal minLimit As Double) As Boolean
        ' parsing the string to check for whether value is dobule value or not
        Dim isDouble As Boolean = Double.TryParse(stringToConvert, dblOutValue)
        If isDouble = True Then
            'if dblOutValue is greater than minLimt retrun true
            Dim returnValue As Boolean = (dblOutValue >= minLimit)
            Return returnValue
        End If
        'return false if the value is not validated as double
        Return False
    End Function


    ''' <summary>
    ''' Overloading the GetDouble Function so it can be used when a string is to be converted
    ''' to a numerical value withoug any max or min conditions
    ''' </summary>
    ''' <param name="stringToConvert">string representing the double value</param>
    ''' <param name="dblOutValue">output parameter, the converted double</param>
    ''' <returns> true if the converstion is successful and the value is greater than or 
    ''' equal to minLimt</returns>
    ''' <remarks></remarks>
    Public Shared Function GetDouble(ByVal stringToConvert As String, ByRef dblOutValue As Double) As Boolean
        ' parsing the string to check for whether value is dobule value or not
        Dim isDouble As Boolean = Double.TryParse(stringToConvert, dblOutValue)
        If isDouble = True Then
            'if dblOutValue is a double return true
            Return True
        End If
        'return false if the value is not validated as double
        Return False
    End Function
    ''' <summary>
    ''' Convers a string represented long value into a long type. If parsing sucessfull
    ''' returns the long value
    ''' </summary>
    ''' <param name="stringToConvert">the string to be converted</param>
    ''' <param name="longOutValue">long valued out put parameter</param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Shared Function GetLong(ByVal stringToConvert As String, ByRef longOutValue As Long) As Boolean
        Dim isLong As Boolean = Long.TryParse(stringToConvert, longOutValue)
        If isLong = True Then
            'if longOutValue is a long return true
            Return True
        End If
        'return false if teh value is not validated as long
        Return False
    End Function

    ''' <summary>
    ''' Converts a string represented Integer value into a integer type, and validates
    ''' the converted value to be within (and inclusive) a range, defined by minLimit and
    ''' max Limit
    ''' </summary>
    ''' <param name="stringToConvert">string representing the integer value</param>
    ''' <param name="intOutValue">output parameter, the converted integer</param>
    ''' <param name="minLimit">output value should be greater than or equal to minLimit</param>
    ''' <param name="maxLimit">output value should be less than or equal to maxLimit</param>
    ''' <returns>true if the conversion is successful and value is within the 
    ''' given range</returns>
    ''' <remarks></remarks>
    Public Shared Function GetInteger(ByVal stringToConvert As String, ByRef intOutValue As Integer, _
                                     ByVal minLimit As Integer, ByVal maxLimit As Integer) As Boolean
        ' parsing the string to check for whether value is integer value or not
        Dim isInteger As Boolean = Integer.TryParse(stringToConvert, intOutValue)
        If isInteger = True Then
            'if intOutValue within the range then return true
            Dim returnValue As Boolean = ((intOutValue >= minLimit And intOutValue <= maxLimit))
            Return returnValue
        End If
        'return false if the value is not validated as integer
        Return False
    End Function


    ''' <summary>
    ''' Overloading the GetInteger Function so it can be used when a string is to be converted
    ''' to a numerical value with only minLimit Condition
    ''' </summary>
    ''' <param name="stringToConvert">string representing the integer value</param>
    ''' <param name="intOutValue">output parameter, the converted integer</param>
    ''' <param name="minLimit">output value should be greater than or equal to minLimit</param>
    ''' <returns> true if the converstion is successful and the value is greater than or 
    ''' equal to minLimt</returns>
    ''' <remarks></remarks>
    Public Shared Function GetInteger(ByVal stringToConvert As String, ByRef intOutValue As Integer, _
                                     ByVal minLimit As Integer) As Boolean
        ' parsing the string to check for whether value is integer value or not
        Dim isInteger As Boolean = Integer.TryParse(stringToConvert, intOutValue)
        If isInteger = True Then
            'if intOutValue is greater than minLimt retrun true
            Dim returnValue As Boolean = (intOutValue >= minLimit)
            Return returnValue
        End If
        'return false if the value is not validated as integer
        Return False
    End Function


    ''' <summary>
    ''' Overloading the GetInteger Function so it can be used when a string is to be converted
    ''' to a numerical value with no min or max conditions
    ''' </summary>
    ''' <param name="stringToConvert">string representing the integer value</param>
    ''' <param name="intOutValue">output parameter, the converted integer</param>
    ''' <returns> true if the converstion is successful and the value is greater than or 
    ''' equal to minLimt</returns>
    ''' <remarks></remarks>
    Public Shared Function GetInteger(ByVal stringToConvert As String, ByRef intOutValue As Integer) As Boolean
        ' parsing the string to check for whether value is integer value or not
        Dim isInteger As Boolean = Integer.TryParse(stringToConvert, intOutValue)
        If isInteger = True Then
            'if value is valid as integer return true
            Return True
        End If
        'return false if the value is not validated as integer
        Return False
    End Function

    ''' <summary>
    ''' this function evaluates the name. If it contains any white spaces or does not contain any value
    ''' it returns true.
    ''' </summary>
    ''' <param name="stringName">the name inputted by the user</param>
    ''' <returns>true if name is empty or a blank space</returns>
    ''' <remarks></remarks>
    Public Shared Function CheckString(ByVal stringName As String) As Boolean

        Dim isNotValid As Boolean = (String.IsNullOrEmpty(stringName)) Or (String.IsNullOrWhiteSpace(stringName))
        If isNotValid = True Then
            Return True
        Else
            Return False
        End If

    End Function
End Class
