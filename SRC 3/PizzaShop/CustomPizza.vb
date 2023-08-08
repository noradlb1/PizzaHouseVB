' *
'   Brice Allard
'   Catterina's Pizza
'   November 3, 2018
'  
'   Description: 
'       Winforms application that allows the user to choose from preselected menu
'       items or create their own custom pizza with toppings of their choice.
'       Images overlayed to display the look of the pizza has been implemented.
' 


Imports System.Collections.Generic

Namespace PizzaShop
    Public Class CustomPizza
        Public Toppings As List(Of String) = New List(Of String)()
        Public Property Size As String
        Public Property Crust As String
        Public Property Sauce As String
        Public Property Pepperoni As Boolean
        Public Property Sausage As Boolean
        Public Property Ham As Boolean
        Public Property Bacon As Boolean
        Public Property Mushrooms As Boolean
        Public Property Onions As Boolean

        Private olivesField As Boolean

        Public Function GetOlives() As Boolean
            Return olivesField
        End Function

        Public Sub SetOlives(ByVal value As Boolean)
            olivesField = value
        End Sub

        Public Property PineApple As Boolean

        Public Property Olives As Boolean
        Public Property BellPepper As Boolean
        Public Property Turkey As Boolean
        Public Property ExtraCheese As Boolean
        Public Property ExtraMushrooms As Boolean

        Public Property Price As Double

        Public Sub New()
            Size = "Large"
            Crust = "Pan"
            Sauce = "Mar"
            Pepperoni = False
            Sausage = False
            Ham = False
            Bacon = False
            Mushrooms = False
            Onions = False
            SetOlives(False)
            Price = 0.00
        End Sub

        Public Sub UpdateList()
            If Pepperoni Then Toppings.Add("Pepperoni")
            If Sausage Then Toppings.Add("Sausage")
            If Ham Then Toppings.Add("Ham")
            If Bacon Then Toppings.Add("Bacon")
            If Mushrooms Then Toppings.Add("Mushrooms")
            If Onions Then Toppings.Add("Onions")
            If GetOlives() Then Toppings.Add("Olives")
        End Sub

        Public Function GetListToStrings() As String
            Dim CombinedToppings = String.Join(", ", Toppings)

            Return CombinedToppings
        End Function
    End Class
End Namespace
