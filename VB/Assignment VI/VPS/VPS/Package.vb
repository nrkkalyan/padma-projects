'File: Package.vb
'Created by: Padma Priya Duvvuri
'Created on: 02-Dec-2010

Option Strict On
Option Explicit On

''' <summary>
''' This class inherits the Parcel.vb class
''' and sets the values of price and other details
''' </summary>
''' <remarks></remarks>
Public Class Package
    Inherits Parcel

    ''' <summary>
    ''' construcor having 2 parameters. It assigns the values to 
    ''' the base class constructor
    ''' </summary>
    ''' <param name="weight"></param>
    ''' <param name="measures"></param>
    ''' <remarks></remarks>
    Sub New(ByVal weight As Double, ByVal measures As MeasureData)
        MyBase.New(weight, measures)
    End Sub

    ''' <summary>
    ''' It overrides the CheckData() method of base class
    ''' </summary>
    ''' <returns>true if data is valid and false otherwise</returns>
    ''' <remarks></remarks>
    Public Overrides Function CheckData() As Boolean
        Return MyBase.CheckData()
    End Function

    ''' <summary>
    ''' this method overrides teh SetPrice() method of the base
    ''' class and sets teh value of price
    ''' </summary>
    ''' <remarks></remarks>
    Public Overrides Sub SetPrice()
        MyBase.SetPrice()
    End Sub

    Public Overrides Function ToString() As String
        Return MyBase.ToString()
    End Function

End Class
