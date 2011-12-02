'File: Parcel.vb
'Created by: Padma Priya Duvvuri
'Created on: 02-Dec-2010
Option Strict On
Option Explicit On

''' <summary>
''' This class inherits the MailItem.vb class and 
''' overrides the methods of the baseclass if necessary
''' </summary>
''' <remarks></remarks>
Public Class Parcel
    Inherits MailItem

    ''' <summary>
    ''' constructor having 2 parameters. It calls base method's
    ''' constructors
    ''' </summary>
    ''' <param name="weight"></param>
    ''' <param name="measures"></param>
    ''' <remarks></remarks>
    Sub New(ByVal weight As Double, ByVal measures As MeasureData)
        MyBase.New(weight, measures)
    End Sub

    ''' <summary>
    ''' read only property to set price field. If parcel is long
    ''' it adds additional postage
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public ReadOnly Property ExtraLenghtPrice As Decimal
        Get
            Dim extraprice As Decimal = 0
            If IsLong() Then
                extraprice = CDec(30.0)
            End If
            Return Me.Price + extraprice
        End Get
    End Property

    ''' <summary>
    ''' readonly property to check whether the parcel is long or not
    ''' </summary>
    ''' <value></value>
    ''' <returns>true if parcel or package is long, false otherwise</returns>
    ''' <remarks></remarks>
    Public ReadOnly Property IsLong As Boolean
        Get
            If (MyBase.CheckData() = True) And (MyBase.Measures.LongestSide() > 1200) Then
                Return True
            Else
                Return False
            End If
        End Get
    End Property

    ''' <summary>
    ''' Readonly property to set the pricestring according to calculated price 
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public ReadOnly Property PriceString As String
        Get
            Return Me.ToString()
        End Get
    End Property

    ''' <summary>
    ''' This functions overrides the checkdata() methodof the 
    ''' base class i.e.MailType.vb
    ''' </summary>
    ''' <returns>true if the package dimensions are within the range and false otherwise</returns>
    ''' <remarks></remarks>
    Public Overrides Function CheckData() As Boolean
        If (MyBase.CheckData() = True) And (MyBase.Weight < 20000) And (MyBase.Measures.LongestSide < 1500) Then
            Return True
        Else
            Return False
        End If
    End Function

    ''' <summary>
    ''' This method overrides teh SetPrice() method of base class i.e. MailType.vb
    ''' and calcuates the price of postage according to weight of the Package or Parcel
    ''' </summary>
    ''' <remarks></remarks>
    Public Overrides Sub SetPrice()
        If CheckData() = True Then
            If MyBase.Weight <= 3000 Then
                MyBase.Price = CDec(132.5)
            ElseIf MyBase.Weight > 3000 And MyBase.Weight <= 5000 Then
                MyBase.Price = CDec(155.6)
            ElseIf MyBase.Weight > 5000 And MyBase.Weight <= 10000 Then
                MyBase.Price = CDec(197.2)
            ElseIf MyBase.Weight > 10000 And MyBase.Weight <= 20000 Then
                MyBase.Price = CDec(197.2 + ((20000 - MyBase.Weight) * 30))
            End If
        End If
    End Sub

    ''' <summary>
    ''' This mehtod overrides the ToString() method of the
    ''' base class and updates the price value accordingly
    ''' </summary>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Overrides Function ToString() As String
        Dim str As String = String.Empty
        If IsLong() = True Then
            Me.SetPrice()
            str = Me.ExtraLenghtPrice.ToString() + My.Resources.strLargePackageFee
        Else
            Me.SetPrice()
            str = MyBase.Price.ToString()
        End If
        Return str
    End Function

End Class
