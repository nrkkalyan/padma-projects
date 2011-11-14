''File: Email.vb
''Created by: 
''Created on: 

Option Strict On
Option Explicit On

Public Class Email
    'private email
    Private m_personal As String
    'work mail
    Private m_work As String

    'Constructors are overloaded and called in a chain

    ''' <summary>
    ''' Default constructor - calls another constructor in this class
    ''' </summary>
    ''' <remarks></remarks>
    Public Sub New()
        Me.New(String.Empty)
    End Sub

    ''' <summary>
    ''' Constructor with one parameter - calls the constructor with 
    ''' two parameters, using a default value as the second argument.
    ''' </summary>
    ''' <param name="workMail">input coming from the client object</param>
    ''' <remarks></remarks>
    Public Sub New(ByVal workMail As String)
        Me.New(workMail, String.Empty)
    End Sub

    ''' <summary>
    ''' Constructor with two parameters. This is  constructor that has most
    ''' number of parameters. It is in tis constructor that all coding 
    ''' should be done.
    ''' </summary>
    ''' <param name="workMail">Input - office mail</param>
    ''' <param name="personalMail">Input - private mail</param>
    ''' <remarks></remarks>
    Public Sub New(ByVal workMail As String, ByVal personalMail As String)
        m_work = workMail
        m_personal = personalMail
    End Sub

    ''' <summary>
    ''' Property related to the field m_Personal
    ''' Both read and write access
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Property Personal() As String
        'private mail
        Get
            Return m_personal
        End Get

        Set(ByVal value As String)
            m_personal = value
        End Set
    End Property


    ''' <summary>
    ''' Property related to m_work field
    ''' Both read and write access
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Property Work() As String
        Get
            Return m_work
        End Get

        Set(ByVal value As String)
            m_work = value
        End Set
    End Property

    ''' <summary>
    ''' This method prepares a format string that is in sync with the ToString
    ''' method.  It will be used in the MainForm as part of the heading for the ListBox
    ''' before customer information is added in the ListBox.
    ''' </summary>
    ''' <value></value>
    ''' <returns>A formatted string as heading for the values formatted in the ToString
    ''' method below.</returns>
    ''' <remarks></remarks>
    Public ReadOnly Property GetToStringItemsHeadings() As String
        Get
            Return String.Format("{0,-20} {1, -20}", "Office Email", "Private Email")
        End Get
    End Property

    ''' <summary>
    ''' Delivers a formatted string with data stored in the object. The values will
    ''' appear as columns.  Make sure that a font like "Courier New" is used in
    ''' the control displaying this information.
    ''' </summary>
    ''' <returns>the Formatted strings.</returns>
    ''' <remarks></remarks>
    Public Overrides Function ToString() As String
        Dim strOut As String = String.Format("{0,-20} {1, -20}", m_work, m_personal)
        Return strOut
    End Function


End Class
