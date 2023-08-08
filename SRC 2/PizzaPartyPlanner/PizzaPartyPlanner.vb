Imports System
Imports System.Collections.Generic
Imports System.Data
Imports System.Linq
Imports System.Windows.Forms

Namespace PizzaPartyPlanner
    Public Partial Class frmPizzaParty
        Inherits Form
        Public Sub New()
            InitializeComponent()
        End Sub

        Private Pizzas As List(Of List(Of String)) = New List(Of List(Of String))()

        Private Sub addPizza(ByVal size As String, ByVal type As String, ByVal slices As String, ByVal notes As String, ByVal price As Decimal)
            Dim pizza As List(Of String) = New List(Of String)()
            pizza.Add(size)
            pizza.Add(type)
            pizza.Add(slices)
            pizza.Add(notes)
            pizza.Add(price.ToString())
            Pizzas.Add(pizza)
        End Sub

        Private Sub updateLst()
            lstPizzaType.Items.Clear()
            For Each pizza In Pizzas
                lstPizzaType.Items.Add(String.Format("{0} {1}", pizza(0), pizza(1)))
            Next
        End Sub


        Private Function getNotes() As String

            Dim notes = txtNotes.Text
            Dim toppings = "Toppings: "
            For Each ctrl In grpToppings.Controls.OfType(Of CheckBox)().Where(Function(t) t.Checked)
                notes += ctrl.Text

            Next
            notes += " "
            notes += toppings

            Return notes

        End Function

        Private Function isValid() As Boolean
            Dim isIt = True
            If cboPizzaType.SelectedIndex <= -1 Then

                isIt = False
            End If
            If cboPizzaSize.SelectedIndex <= -1 Then
                isIt = False
            End If
            If cboSlices.SelectedIndex <= -1 Then
                isIt = False
            End If
            Return isIt
        End Function

        Private subTotal As Decimal

        Private Sub checkbos(ByVal sender As Object, ByVal e As EventArgs)

            Dim lCheckbos = CType(sender, CheckBox)
            If lCheckbos.Checked Then
                subTotal += .50D
            Else
                If True Then
                    subTotal -= .50D
                End If
            End If
            lblPizzaCost.Text = String.Format("{0:C}", subTotal)
        End Sub

        Private Sub updatTotal()

            Dim Total As Decimal = 0
            For Each Pizza In Pizzas
                Dim subTotal As Decimal
                Decimal.TryParse(Pizza(4), subTotal)
                Total += subTotal
            Next
            lblTotal.Text = String.Format("{0:C}", Total)
        End Sub

        Private Sub brnAdd_Click(ByVal sender As Object, ByVal e As EventArgs)
            If isValid() Then

                Dim price As Decimal
                Dim sPrice = lblPizzaCost.Text.Substring(1)
                If Decimal.TryParse(sPrice, price) Then
                    addPizza(cboPizzaSize.Text, cboPizzaType.Text, cboSlices.Text, getNotes(), 9.99D)
                    updateLst()
                    updatTotal()
                End If
            Else

                MessageBox.Show("Plese make sure that you have selected something from each dropdown", Text)
            End If

            'TODO calculate cost of this pizza


        End Sub

        Private Sub btnReport_Click(ByVal sender As Object, ByVal e As EventArgs)
            'create a new for and pass the list of pizzas and 
            'this for to it via the constructor
            Dim form2 As Report = New Report(Pizzas, Me)

            'show the new form
            form2.Show()

            'hide this form
            Visible = False
        End Sub

        Private Sub btnRemove_Click(ByVal sender As Object, ByVal e As EventArgs)
            If lstPizzaType.SelectedIndex > -1 Then
                Pizzas.RemoveAt(lstPizzaType.SelectedIndex)
                updateLst()
            End If

        End Sub

        Private Sub lstPizzaType_SelectedIndexChanged(ByVal sender As Object, ByVal e As EventArgs)
            'check that something is selected
            If lstPizzaType.SelectedIndex > -1 Then
                Dim pizza = Pizzas(lstPizzaType.SelectedIndex)
                txtDisplayNotes.Text = pizza(3)
            End If
        End Sub

        Private Sub cboPizzaSize_SelectedIndexChanged(ByVal sender As Object, ByVal e As EventArgs)
            subTotal = 9.99D
            lblPizzaCost.Text = String.Format("{0:C}", subTotal.ToString())
        End Sub
    End Class
End Namespace
