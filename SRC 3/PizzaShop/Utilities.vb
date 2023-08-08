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
Imports System.Linq
Imports System.Drawing
Imports System.Windows.Forms

Namespace PizzaShop
    Friend Class Utilities
        ' *
        '  
        '   IMAGES FOR PIZZA CUSTIMIZATION
        '  
        ' 

        Public Shared ReadOnly PIZZA_WHOLE As Image = Properties.Resources.button_whole
        Public Shared ReadOnly PIZZA_WHOLE_SELECTED As Image = Properties.Resources.button_whole_selected
        Public Shared ReadOnly PIZZA_LEFT As Image = Properties.Resources.button_left
        Public Shared ReadOnly PIZZA_LEFT_SELECTED As Image = Properties.Resources.button_left_selected
        Public Shared ReadOnly PIZZA_RIGHT As Image = Properties.Resources.button_right
        Public Shared ReadOnly PIZZA_RIGHT_SELECTED As Image = Properties.Resources.button_right_selected
        Public Shared ReadOnly CRUST_HANDTOSSED As Image = Properties.Resources.crust_handtossed
        Public Shared ReadOnly CRUST_PAN As Image = Properties.Resources.crust_pan
        Public Shared ReadOnly CRUST_STUFFED As Image = Properties.Resources.crust_stuffed
        Public Shared ReadOnly CRUST_THIN As Image = Properties.Resources.crust_thin
        Public Shared ReadOnly TOP_MOZZ As Image = Properties.Resources.cheese_mozz
        Public Shared ReadOnly TOP_BACON_X As Image = Properties.Resources.topping_Bacon_extra
        Public Shared ReadOnly TOP_BACON_X_L As Image = Properties.Resources.topping_Bacon_extra_L
        Public Shared ReadOnly TOP_BACON_X_R As Image = Properties.Resources.topping_Bacon_extra_R
        Public Shared ReadOnly TOP_BACON As Image = Properties.Resources.topping_Bacon_reg
        Public Shared ReadOnly TOP_BACON_L As Image = Properties.Resources.topping_Bacon_reg_L
        Public Shared ReadOnly TOP_BACON_R As Image = Properties.Resources.topping_Bacon_reg_R
        Public Shared ReadOnly TOP_BANANA_PEPPER_X As Image = Properties.Resources.topping_BananaPepper_extra
        Public Shared ReadOnly TOP_BANANA_PEPPER_X_L As Image = Properties.Resources.topping_BananaPepper_extra_L
        Public Shared ReadOnly TOP_BANANA_PEPPER_X_R As Image = Properties.Resources.topping_BananaPepper_extra_R
        Public Shared ReadOnly TOP_BANANA_PEPPER As Image = Properties.Resources.topping_BananaPepper_reg
        Public Shared ReadOnly TOP_BANANA_PEPPER_L As Image = Properties.Resources.topping_BananaPepper_reg_L
        Public Shared ReadOnly TOP_BANANA_PEPPER_R As Image = Properties.Resources.topping_BananaPepper_reg_R
        Public Shared ReadOnly TOP_BELL_PEPPER_X As Image = Properties.Resources.topping_GreenBellPepper_extra
        Public Shared ReadOnly TOP_BELL_PEPPER_X_L As Image = Properties.Resources.topping_GreenBellPepper_extra_L
        Public Shared ReadOnly TOP_BELL_PEPPER_X_R As Image = Properties.Resources.topping_GreenBellPepper_extra_R
        Public Shared ReadOnly TOP_BELL_PEPPER As Image = Properties.Resources.topping_GreenBellPepper_reg
        Public Shared ReadOnly TOP_BELL_PEPPER_L As Image = Properties.Resources.topping_GreenBellPepper_reg_L
        Public Shared ReadOnly TOP_BELL_PEPPER_R As Image = Properties.Resources.topping_GreenBellPepper_reg_R
        Public Shared ReadOnly TOP_HAM_X As Image = Properties.Resources.topping_Ham_extra
        Public Shared ReadOnly TOP_HAM_X_L As Image = Properties.Resources.topping_Ham_extra_L
        Public Shared ReadOnly TOP_HAM_X_R As Image = Properties.Resources.topping_Ham_extra_R
        Public Shared ReadOnly TOP_HAM As Image = Properties.Resources.topping_Ham_reg
        Public Shared ReadOnly TOP_HAM_L As Image = Properties.Resources.topping_Ham_reg_L
        Public Shared ReadOnly TOP_HAM_R As Image = Properties.Resources.topping_Ham_reg_R
        Public Shared ReadOnly TOP_SAUSAGE_X As Image = Properties.Resources.topping_ItalianSausage_extra
        Public Shared ReadOnly TOP_SAUSAGE_X_L As Image = Properties.Resources.topping_ItalianSausage_extra_L
        Public Shared ReadOnly TOP_SAUSAGE_X_R As Image = Properties.Resources.topping_ItalianSausage_extra_R
        Public Shared ReadOnly TOP_SAUSAGE As Image = Properties.Resources.topping_ItalianSausage_reg
        Public Shared ReadOnly TOP_SAUSAGE_L As Image = Properties.Resources.topping_ItalianSausage_reg_L
        Public Shared ReadOnly TOP_SAUSAGE_R As Image = Properties.Resources.topping_ItalianSausage_reg_R
        Public Shared ReadOnly TOP_JALEPENO_X As Image = Properties.Resources.topping_Jalepeno_extra
        Public Shared ReadOnly TOP_JALEPENO_X_L As Image = Properties.Resources.topping_Jalepeno_extra_L
        Public Shared ReadOnly TOP_JALEPENO_X_R As Image = Properties.Resources.topping_Jalepeno_extra_R
        Public Shared ReadOnly TOP_JALEPENO As Image = Properties.Resources.topping_Jalepeno_reg
        Public Shared ReadOnly TOP_JALEPENO_L As Image = Properties.Resources.topping_Jalepeno_reg_L
        Public Shared ReadOnly TOP_JALEPENO_R As Image = Properties.Resources.topping_Jalepeno_reg_R
        Public Shared ReadOnly TOP_MUSHROOM_X As Image = Properties.Resources.topping_Mushroom_extra
        Public Shared ReadOnly TOP_MUSHROOM_X_L As Image = Properties.Resources.topping_Mushroom_extra_L
        Public Shared ReadOnly TOP_MUSHROOM_X_R As Image = Properties.Resources.topping_Mushroom_extra_R
        Public Shared ReadOnly TOP_MUSHROOM As Image = Properties.Resources.topping_Mushroom_reg
        Public Shared ReadOnly TOP_MUSHROOM_L As Image = Properties.Resources.topping_Mushroom_reg_L
        Public Shared ReadOnly TOP_MUSHROOM_R As Image = Properties.Resources.topping_Mushroom_reg_R
        Public Shared ReadOnly TOP_OLIVE_X As Image = Properties.Resources.topping_Olives_extra
        Public Shared ReadOnly TOP_OLIVE_X_L As Image = Properties.Resources.topping_Olives_extra_L
        Public Shared ReadOnly TOP_OLIVE_X_R As Image = Properties.Resources.topping_Olives_extra_R
        Public Shared ReadOnly TOP_OLIVE As Image = Properties.Resources.topping_Olives_reg
        Public Shared ReadOnly TOP_OLIVE_L As Image = Properties.Resources.topping_Olives_reg_L
        Public Shared ReadOnly TOP_OLIVE_R As Image = Properties.Resources.topping_Olives_reg_R
        Public Shared ReadOnly TOP_ONION_X As Image = Properties.Resources.topping_Onion_extra
        Public Shared ReadOnly TOP_ONION_X_L As Image = Properties.Resources.topping_Onion_extra_L
        Public Shared ReadOnly TOP_ONION_X_R As Image = Properties.Resources.topping_Onion_extra_R
        Public Shared ReadOnly TOP_ONION As Image = Properties.Resources.topping_Onion_reg
        Public Shared ReadOnly TOP_ONION_L As Image = Properties.Resources.topping_Onion_reg_L
        Public Shared ReadOnly TOP_ONION_R As Image = Properties.Resources.topping_Onion_reg_R
        Public Shared ReadOnly TOP_PEPPERONI_X As Image = Properties.Resources.topping_Pepperoni_extra
        Public Shared ReadOnly TOP_PEPPERONI_X_L As Image = Properties.Resources.topping_Pepperoni_extra_L
        Public Shared ReadOnly TOP_PEPPERONI_X_R As Image = Properties.Resources.topping_Pepperoni_extra_R
        Public Shared ReadOnly TOP_PEPPERONI As Image = Properties.Resources.topping_Pepperoni_reg
        Public Shared ReadOnly TOP_PEPPERONI_L As Image = Properties.Resources.topping_Pepperoni_reg_L
        Public Shared ReadOnly TOP_PEPPERONI_R As Image = Properties.Resources.topping_Pepperoni_reg_R
        Public Shared ReadOnly TOP_PINEAPPLE_X As Image = Properties.Resources.topping_Pineapple_extra
        Public Shared ReadOnly TOP_PINEAPPLE_X_L As Image = Properties.Resources.topping_Pineapple_extra_L
        Public Shared ReadOnly TOP_PINEAPPLE_X_R As Image = Properties.Resources.topping_Pineapple_extra_R
        Public Shared ReadOnly TOP_PINEAPPLE As Image = Properties.Resources.topping_Pineapple_reg
        Public Shared ReadOnly TOP_PINEAPPLE_L As Image = Properties.Resources.topping_Pineapple_reg_L
        Public Shared ReadOnly TOP_PINEAPPLE_R As Image = Properties.Resources.topping_Pineapple_reg_R
        Public Shared ReadOnly TOP_TOMATO_X As Image = Properties.Resources.topping_Tomato_extra
        Public Shared ReadOnly TOP_TOMATO_X_L As Image = Properties.Resources.topping_Tomato_extra_L
        Public Shared ReadOnly TOP_TOMATO_X_R As Image = Properties.Resources.topping_Tomato_extra_R
        Public Shared ReadOnly TOP_TOMATO As Image = Properties.Resources.topping_Tomato_reg
        Public Shared ReadOnly TOP_TOMATO_L As Image = Properties.Resources.topping_Tomato_reg_L
        Public Shared ReadOnly TOP_TOMATO_R As Image = Properties.Resources.topping_Tomato_reg_R

        ' *
        '  
        '   PRICES OF PIZZA, CRUSTS, SAUCES AND TOPPINGS
        '  
        ' 

        ' Sizes
        Public Shared ReadOnly SMALL_PIZZA As Double = 6.99
        Public Shared ReadOnly MEDIUM_PIZZA As Double = 8.99
        Public Shared ReadOnly LARGE_PIZZA As Double = 10.99
        ' Crusts
        Public Shared ReadOnly PAN_CRUST As Double = 0.00
        Public Shared ReadOnly HANDTOSSED_CRUST As Double = 0.99
        Public Shared ReadOnly THINNCRISPY_CRUST As Double = 0.99
        Public Shared ReadOnly STUFFED_CRUST As Double = 1.99
        ' Sauces
        Public Shared ReadOnly MARINARA As Double = 0.00
        Public Shared ReadOnly GARLIC_PARMESAN As Double = 0.99
        Public Shared ReadOnly BARBEQUE As Double = 0.99
        Public Shared ReadOnly BUFFALO As Double = 0.99
        ' Toppings
        Public Shared ReadOnly PEPPORONI As Double = 0.99
        Public Shared ReadOnly SAUSAGE As Double = 0.99
        Public Shared ReadOnly HAM As Double = 0.99
        Public Shared ReadOnly BACON As Double = 0.99
        Public Shared ReadOnly MUSHROOMS As Double = 0.99
        Public Shared ReadOnly ONIONS As Double = 0.99
        Public Shared ReadOnly OLIVES As Double = 0.99
        Public Shared ReadOnly BELL_PEPPERS As Double = 0.99
        Public Shared ReadOnly BANANA_PEPPERS As Double = 0.99
        Public Shared ReadOnly PINEAPPLE As Double = 0.99
        Public Shared ReadOnly JALAPENO As Double = 0.99
        Public Shared ReadOnly TOMATOES As Double = 0.99

        ' *
        '  
        '   THEME COLOR SCHEME 
        '  
        ' 

        Public Shared PRIMARY_COLOR As Color = Color.FromArgb(44, 62, 80)
        Public Shared SECONDARY_COLOR As Color = Color.FromArgb(52, 73, 94)
        Public Shared BACKGROUND_COLOR As Color = Color.FromArgb(90, 109, 123)
        Public Shared ACCENT_COLOR As Color = Color.FromArgb(181, 28, 11)
        Public Shared TEXT_COLOR As Color = Color.FromArgb(162, 100, 45)
        Public Shared TEXT_HOVOR_COLOR As Color = Color.FromArgb(181, 28, 11)

        Public Shared Function getPrice(ByVal cb As ComboBox) As Double
            Dim line = cb.GetItemText(cb.SelectedItem)
            Dim split As List(Of String) = New List(Of String)()

            If line.Contains("$"c) Then
                split = line.Split("$"c).ToList()
            End If
            Dim price As Double = Nothing

            If split.Count > 1 Then
                Double.TryParse(split(1), price)
                Return price
            End If

            Return 0.00
        End Function

        Public Shared Function getLabelPrice(ByVal lbl As Label) As String
            Dim line = lbl.Text
            Dim split As List(Of String) = New List(Of String)()

            If line.Contains("$"c) Then
                split = line.Split("$"c).ToList()
            End If

            If split.Count > 1 Then
                Return split(1)
            End If

            Return "0.00"
        End Function

        Public Shared Function getName(ByVal cb As ComboBox) As String
            Dim line = cb.GetItemText(cb.SelectedItem)
            Dim split As List(Of String) = New List(Of String)()

            If line.Contains("$"c) Then
                split = line.Split("-"c).ToList()
            End If

            If split.Count > 1 Then
                Return split(0)
            End If

            Return "No Name"
        End Function
    End Class
End Namespace
