'File: Letter.vb
'Created by: Padma Priya Duvvuri
'Created on: 02-Dec-2010
Option Strict On
Option Explicit On

''' <summary>
''' This class inherits MailItem class and calcualtes
''' the postage prices so as to do so it overrides some of 
''' the methods of the MailItem class
''' </summary>
''' <remarks></remarks>
Public Class Letter
    Inherits MailItem
    ''' <summary>
    ''' constructor with 2 parameters. It calls constructor of the
    ''' base class i.e. MailType.vb
    ''' </summary>
    ''' <param name="weight"></param>
    ''' <param name="measures"></param>
    ''' <remarks></remarks>
    Sub New(ByVal weight As Double, ByVal measures As MeasureData)
        MyBase.New(weight, measures)
    End Sub

    ''' <summary>
    ''' ReadOnly property of the Price. It returns the
    ''' price accordance with weight of the letter
    ''' </summary>
    ''' <value></value>
    ''' <returns>string having the final price of the Letter</returns>
    ''' <remarks></remarks>
    Public ReadOnly Property PriceString As String
        Get
            Return Me.ToString()
        End Get
    End Property

    ''' <summary>
    ''' This method overrides the CheckData() of the base method
    ''' and returns true if Letter is in within the limits
    ''' </summary>
    ''' <returns>True if Letter dimensions are valid and False otherwise</returns>
    ''' <remarks></remarks>
    Public Overrides Function CheckData() As Boolean
        If (MyBase.CheckData() = True) And (MyBase.Weight < 2000) And (MyBase.Measures.LongestSide < 500) Then
            Return True
        Else
            Return False
        End If
    End Function

    ''' <summary>
    ''' Calculate the prices according to the weight of the letter
    ''' </summary>
    ''' <remarks></remarks>
    Public Overrides Sub SetPrice()
        If CheckData() = True Then
            If MyBase.Weight <= 20 Then
                MyBase.Price = CDec(5.3)
            ElseIf MyBase.Weight > 20 And MyBase.Weight <= 100 Then
                MyBase.Price = CDec(10.6)
            ElseIf MyBase.Weight > 100 And MyBase.Weight <= 250 Then
                MyBase.Price = CDec(21.3)
            ElseIf MyBase.Weight > 250 And MyBase.Weight <= 500 Then
                MyBase.Price = CDec(31.8)
            ElseIf MyBase.Weight > 500 And MyBase.Weight <= 1000 Then
                MyBase.Price = CDec(42.5)
            ElseIf MyBase.Weight > 1000 And MyBase.Weight <= 2000 Then
                MyBase.Price = CDec(63.6)
            End If
        End If
    End Sub

    ''' <summary>
    ''' This method overrides the ToString() method of the 
    ''' MailType.vb and updates the price and returns the price
    ''' as string
    ''' </summary>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Overrides Function ToString() As String
        Dim str As String = String.Empty
        If IsLarge() = True Then 'If letter is large then calcualate the price by calling LargeEnvolopeCharger()
            Me.SetPrice()
            str = Me.LargeEnvolopeCharger().ToString() + My.Resources.strLargeEnvolopeFee
        Else
            Me.SetPrice()
            str = MyBase.Price.ToString()
        End If
        Return str
    End Function

    ''' <summary>
    ''' Checks if the letter's logest dimension is greater than 30mm
    ''' </summary>
    ''' <returns>true if longest dimension greater than 30mm else otherwise</returns>
    ''' <remarks></remarks>
    Public Function IsLarge() As Boolean
        If (MyBase.CheckData() = True) And (MyBase.Measures.LongestSide() > 30) Then
            Return True
        Else
            Return False
        End If
    End Function

    ''' <summary>
    ''' If envolope is large then add teh extra price to the original
    ''' price and return the total price
    ''' </summary>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Function LargeEnvolopeCharger() As Decimal
        Dim extraprice As Decimal = 0
        If IsLarge() Then
            extraprice = CDec(12.0)
        End If
        Return Me.Price + extraprice
    End Function

End Class
