
Option Strict On
Option Explicit On
''' <summary>
''' This class defines  the measurements of postal object, such as
''' letter, package, etc.
''' You job:  Review and understand teh code. Use it in your projecdt 
''' (optional).
''' The documentation of the methods is also left for you.
''' </summary>
''' <remarks></remarks>
Public Class MeasureData
    Private m_length As Double
    Private m_Width As Double
    Private m_thickness As Double

    Public Sub New()

    End Sub

    Public Property Length() As Double
        Get
            Return m_length
        End Get
        Set(ByVal value As Double)
            m_length = value
        End Set
    End Property


    Public Property Width() As Double
        Get
            Return m_Width
        End Get
        Set(ByVal value As Double)
            m_Width = value
        End Set
    End Property

    Public Property Thickness() As Double
        Get
            Return m_thickness
        End Get
        Set(ByVal value As Double)
            m_thickness = value
        End Set
    End Property

    Public Function CheckData() As Boolean
        If (m_length > 0) Or (m_Width > 0) Or (m_thickness > 0) Then
            Return True
        Else
            Return False
        End If
    End Function

    Public Function LongestSide() As Double
        Return Math.Max(m_length, Math.Max(m_Width, m_thickness))
    End Function

End Class