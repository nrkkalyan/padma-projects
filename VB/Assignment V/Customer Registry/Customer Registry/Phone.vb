'File: Phone.vb
'Created by: Padma Priya Duvvuri
'Created on: 10-Nov-2010

Option Strict On
Option Explicit On

Public Class Phone
    ' private fields for Home and cell phone numbers
    Private m_home As String
    Private m_cell As String


    ''' <summary>
    ''' Constructor with two parameters. This is  constructor that has most
    ''' number of parameters. It is in tis constructor that all coding 
    ''' should be done.
    ''' </summary>
    ''' <param name="homePhone">Input - Home Phone</param>
    ''' <param name="cellPhone">Input - Cell Phone</param>
    ''' <remarks></remarks>
    Public Sub New(ByVal homePhone As String, ByVal cellPhone As String)
        m_home = homePhone
        m_cell = cellPhone
    End Sub


    ''' <summary>
    ''' Constructor with one parameter - calls the constructor with 
    ''' two parameters, using a default value as the second argument.
    ''' </summary>
    ''' <param name="homePhone">input coming from the client object</param>
    ''' <remarks></remarks>
    Public Sub New(ByVal homePhone As String)
        Me.New(homePhone, String.Empty)
    End Sub

    ''' <summary>
    ''' Default consturctor - calls another constructor in the class
    ''' </summary>
    ''' <remarks></remarks>
    Public Sub New()
        Me.New(String.Empty, String.Empty)
    End Sub


    ''' <summary>
    ''' Property related to the field m_home
    ''' Both read and write access
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Property Home As String
        Get
            Home = m_home
        End Get
        Set(ByVal value As String)
            m_home = value
        End Set
    End Property


    ''' <summary>
    ''' Property related to the field m_cell
    ''' Both read and write access
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Property Cell As String
        Get
            Cell = m_cell
        End Get
        Set(ByVal value As String)
            m_cell = value
        End Set
    End Property


    ''' <summary>
    ''' Delivers a formatted string with data stored in the object. The values will
    ''' appear as columns. 
    ''' </summary>
    ''' <returns>the Formatted strings.</returns>
    ''' <remarks></remarks>
    Public Overrides Function ToString() As String
        Dim strOut As String = String.Format("{0,-12} {1, -12}", m_home, m_cell)
        Return strOut
    End Function


End Class
