'File: MeasureData.vb
'Created by: Padma Priya Duvvuri
'Created on: 02-Dec-2010

Option Strict On
Option Explicit On
''' <summary>
''' This class defines  the measurements of postal object, such as
''' letter, package, etc.
''' </summary>
''' <remarks></remarks>
Public Class MeasureData
    'to store the values of the dimenstions
    Private m_length As Double
    Private m_Width As Double
    Private m_thickness As Double

    ''' <summary>
    ''' Constructor taking 3 perameters
    ''' </summary>
    ''' <param name="lenght"></param>
    ''' <param name="width"></param>
    ''' <param name="thickness"></param>
    ''' <remarks></remarks>
    Public Sub New(ByRef lenght As Double, ByRef width As Double, ByRef thickness As Double)
        m_length = lenght
        m_Width = width
        m_thickness = thickness
    End Sub

    ''' <summary>
    ''' Read and Write property for m_lenght
    ''' variable
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Property Length() As Double
        Get
            Return m_length
        End Get
        Set(ByVal value As Double)
            m_length = value
        End Set
    End Property

    ''' <summary>
    ''' read adn write property for m_width
    ''' field
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Property Width() As Double
        Get
            Return m_Width
        End Get
        Set(ByVal value As Double)
            m_Width = value
        End Set
    End Property

    ''' <summary>
    ''' read and write property for m_thickness
    ''' of Double datatype
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Property Thickness() As Double
        Get
            Return m_thickness
        End Get
        Set(ByVal value As Double)
            m_thickness = value
        End Set
    End Property

    ''' <summary>
    ''' If all dimensions are valid numbers 
    ''' returns true
    ''' </summary>
    ''' <returns>true if all fields are valid and returns false otherwise</returns>
    ''' <remarks></remarks>
    Public Function CheckData() As Boolean
        If (m_length > 0) Or (m_Width > 0) Or (m_thickness > 0) Then
            Return True
        Else
            Return False
        End If
    End Function

    ''' <summary>
    ''' This method calculates the maximum value of the
    ''' dimensions
    ''' </summary>
    ''' <returns>maximum value of the dimensions </returns>
    ''' <remarks></remarks>
    Public Function LongestSide() As Double
        Return Math.Max(m_length, Math.Max(m_Width, m_thickness))
    End Function

End Class