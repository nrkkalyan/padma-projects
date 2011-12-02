'File: MailType.vb
'Created by: Padma Priya Duvvuri
'Created on: 02-Dec-2010
Option Strict On
Option Explicit On

''' <summary>
''' This class inherits the Letter class and returns price for
''' fixed demensions of the Letter ie. post card
''' </summary>
''' <remarks></remarks>
Public Class PostCard
    Inherits Letter

    ''' <summary>
    ''' default constructor that sends default values to the base
    ''' class constructor
    ''' </summary>
    ''' <remarks></remarks>
    Public Sub New()
        MyBase.New(30, New MeasureData(10, 10, 10))

    End Sub

    ''' <summary>
    ''' ovverides the CheckData() method of the base class
    ''' i.e. Letter.vb
    ''' </summary>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Overrides Function CheckData() As Boolean
        If MyBase.CheckData() = True Then
            Return True
        Else
            Return False
        End If
    End Function

    ''' <summary>
    ''' this method overrides the SetPrice() method of the
    ''' base class and returns a fixed postal price of 5 SEK
    ''' </summary>
    ''' <remarks></remarks>
    Public Overrides Sub SetPrice()
        MyBase.Price = 5
    End Sub

    ''' <summary>
    ''' This method overrides teh ToString() method of 
    ''' the base class
    ''' </summary>
    ''' <returns>returns a string</returns>
    ''' <remarks></remarks>
    Public Overrides Function ToString() As String
        Me.SetPrice()
        Return MyBase.Price.ToString()
    End Function

End Class
