' -------------------------------------------------------------------
'  Name: Zackery Crews
'  Project: Final Project
'  Description: A pizza ordering application.
' -------------------------------------------------------------------

Imports System
Imports System.ComponentModel.DataAnnotations
Imports System.Drawing
Imports System.Text
Imports System.Windows.Forms
Imports System.Net
Imports System.Net.Mail

Namespace PizzaApp
    Public Partial Class PizzaForm
        Inherits Form
        Private currentPizzaTotal As Double
        Private allPizzaTotal As Double
        Private allSideTotal As Double
        Private subTotal As Double
        Private taxAmount As Double
        Private tipAmount As Double
        Private grandTotal As Double

        Private email As EmailAddressAttribute

        Private pizzaOrder As String
        Private sideOrder As String

        Private counterCrust, counterDelivery, counterPizzaOrder, counterSideOrder As Integer

        Public Sub New()
            InitializeComponent()
        End Sub

        Private Sub PizzaForm_Load(ByVal sender As Object, ByVal e As EventArgs)
            Dim intro As String = "Welcome to Zack's Pizza and Cafe ordering application!" & Microsoft.VisualBasic.Constants.vbLf & Microsoft.VisualBasic.Constants.vbLf & "Thank you for choosing us! We have the finest pies in all" & Microsoft.VisualBasic.Constants.vbLf & "of Jacksonville. If you have any questions please contact" & Microsoft.VisualBasic.Constants.vbLf & "us either by email, phone, or in person. Our contact info" & Microsoft.VisualBasic.Constants.vbLf & "is under the about tab in the application." & Microsoft.VisualBasic.Constants.vbLf & Microsoft.VisualBasic.Constants.vbLf & "Because of resource restrictions at our store, we ask that" & Microsoft.VisualBasic.Constants.vbLf & "you keep all orders below 10 pizzas and 10 sides. This is" & Microsoft.VisualBasic.Constants.vbLf & "the maximum we can process at a time. We are sorry for any" & Microsoft.VisualBasic.Constants.vbLf & "inconvenience this will cause. Thank you!"


            txtBxBeverageAmount.Text = "Quantity..."
            txtBxSidesAmount.Text = "Quantity..."
            counterCrust = 0
            counterDelivery = 0
            counterPizzaOrder = 0
            counterSideOrder = 0
            pizzaOrder = ""
            sideOrder = ""

            cmBxSize.Enabled = False
            cmBxCrust.Enabled = False
            cmBxSauce.Enabled = False
            checkBxMeats.Enabled = False
            checkBxVeggies.Enabled = False
            btnFinishOrder.Enabled = False
            For i = 0 To 8
                checkBxMeats.SetItemChecked(i, False)
            Next
            For i = 0 To 10
                checkBxVeggies.SetItemChecked(i, False)
            Next
            checkBxVeggies.SetItemChecked(0, True)
            lblPizzaTotal.Text = String.Format("{0:C}", 0.00)
            currentPizzaTotal = 0
            lblCurrentTotal.Text = String.Format("{0:C}", 0.00)
            subTotal = 0
            lblTaxAmount.Text = String.Format("{0:C}", 0.00)
            taxAmount = 0
            lblTipAmount.Text = String.Format("{0:C}", 0.00)
            tipAmount = 0
            lblGrandTotal.Text = String.Format("{0:C}", 0.00)
            grandTotal = 0
            allPizzaTotal = 0
            allSideTotal = 0
            rdBtnDelivery.Checked = False
            rdBtnWalkIn.Checked = False

            If MessageBox.Show(intro, "Welcome!", MessageBoxButtons.OKCancel) = DialogResult.Cancel Then
                If MessageBox.Show("Are you sure you want to exit?", "Well do ya?", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) = DialogResult.Yes Then Call Application.Exit()
            End If

            ChangeConnectionStatus()

        End Sub

        Private Sub exitToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs)
            If MessageBox.Show("Are you sure you want to exit?", "Well do ya?", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) = DialogResult.Yes Then Call Application.Exit()
        End Sub

        Private Sub viewCurrentOrderToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs)
            tabControl1.SelectTab(2)
        End Sub

        Private Sub aboutToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs)
            Dim about As String = "Zack's Pizza and Cafe was created in 2016 by Zackery Kyle Crews as" & Microsoft.VisualBasic.Constants.vbLf & "a simple business to fulfill the requirements of his programming project." & Microsoft.VisualBasic.Constants.vbLf & Microsoft.VisualBasic.Constants.vbLf & "Owner: Zackery Crews" & Microsoft.VisualBasic.Constants.vbLf & "Location: 2800 University Blvd." & Microsoft.VisualBasic.Constants.vbLf & "Phone: (904) 555 - 8888" & Microsoft.VisualBasic.Constants.vbLf & "Email: ZacksPizzaCS160@outlook.com"

            MessageBox.Show(about, "Info", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End Sub

        Private Sub cmBxPizzaType_SelectedIndexChanged(ByVal sender As Object, ByVal e As EventArgs)
            For i = 0 To 8
                checkBxMeats.SetItemChecked(i, False)
            Next
            checkBxMeats.Enabled = False
            For i = 0 To 10
                checkBxVeggies.SetItemChecked(i, False)
            Next
            checkBxVeggies.Enabled = False

            Select Case cmBxPizzaType.SelectedIndex
                Case 0
                    checkBxVeggies.Enabled = True
                    checkBxMeats.Enabled = True
                    cmBxSize.Enabled = True
                    cmBxCrust.Enabled = True
                    cmBxSauce.Enabled = True
                    SetSizePrices()
                Case 1
                    checkBxVeggies.Enabled = True
                    checkBxMeats.Enabled = True

                    checkBxMeats.SetItemChecked(0, True)
                    checkBxVeggies.SetItemChecked(0, True)
                    cmBxSize.Enabled = True
                    cmBxCrust.Enabled = True
                    cmBxSauce.SelectedIndex = 0
                    cmBxSauce.Enabled = True
                    SetSizePrices()
                Case 2
                    checkBxVeggies.Enabled = True
                    checkBxMeats.Enabled = True

                    checkBxVeggies.SetItemChecked(0, True)
                    cmBxSize.Enabled = True
                    cmBxCrust.Enabled = True
                    cmBxSauce.SelectedIndex = 0
                    cmBxSauce.Enabled = True
                    SetSizePrices()
                Case 3
                    checkBxVeggies.Enabled = True
                    checkBxMeats.Enabled = True

                    checkBxMeats.SetItemChecked(4, True)
                    checkBxMeats.SetItemChecked(5, True)
                    checkBxVeggies.SetItemChecked(8, True)
                    checkBxVeggies.SetItemChecked(0, True)
                    cmBxSize.Enabled = True
                    cmBxCrust.Enabled = True
                    cmBxSauce.SelectedIndex = 0
                    cmBxSauce.Enabled = True
                    SetSizePrices()
                Case 4
                    checkBxVeggies.Enabled = True
                    checkBxMeats.Enabled = True

                    checkBxMeats.SetItemChecked(6, True)
                    checkBxMeats.SetItemChecked(5, True)
                    checkBxVeggies.SetItemChecked(10, True)
                    checkBxVeggies.SetItemChecked(0, True)
                    cmBxSize.Enabled = True
                    cmBxCrust.Enabled = True
                    cmBxSauce.SelectedIndex = 1
                    cmBxSauce.Enabled = True
                    SetSizePrices()
                Case 5
                    checkBxVeggies.Enabled = True
                    checkBxMeats.Enabled = True

                    checkBxMeats.SetItemChecked(0, True)
                    checkBxMeats.SetItemChecked(1, True)
                    checkBxMeats.SetItemChecked(4, True)
                    checkBxMeats.SetItemChecked(5, True)
                    checkBxMeats.SetItemChecked(7, True)
                    checkBxMeats.SetItemChecked(8, True)
                    checkBxVeggies.SetItemChecked(0, True)
                    cmBxSize.Enabled = True
                    cmBxCrust.Enabled = True
                    cmBxSauce.SelectedIndex = 0
                    cmBxSauce.Enabled = True
                    SetSizePrices()
                Case 6
                    checkBxVeggies.Enabled = True
                    checkBxMeats.Enabled = True

                    checkBxVeggies.SetItemChecked(0, True)
                    checkBxVeggies.SetItemChecked(1, True)
                    checkBxVeggies.SetItemChecked(4, True)
                    checkBxVeggies.SetItemChecked(6, True)
                    checkBxVeggies.SetItemChecked(10, True)
                    checkBxVeggies.SetItemChecked(5, True)
                    cmBxSize.Enabled = True
                    cmBxCrust.Enabled = True
                    cmBxSauce.SelectedIndex = 0
                    cmBxSauce.Enabled = True
                    SetSizePrices()
                Case 7
                    checkBxVeggies.Enabled = True
                    checkBxMeats.Enabled = True

                    checkBxMeats.SetItemChecked(1, True)
                    checkBxMeats.SetItemChecked(8, True)
                    checkBxMeats.SetItemChecked(7, True)
                    checkBxVeggies.SetItemChecked(0, True)
                    checkBxVeggies.SetItemChecked(1, True)
                    checkBxVeggies.SetItemChecked(6, True)
                    checkBxVeggies.SetItemChecked(4, True)
                    cmBxSize.Enabled = True
                    cmBxCrust.Enabled = True
                    cmBxSauce.SelectedIndex = 0
                    cmBxSauce.Enabled = True
                    SetSizePrices()
                Case 8
                    checkBxVeggies.Enabled = True
                    checkBxMeats.Enabled = True

                    checkBxMeats.SetItemChecked(0, True)
                    checkBxVeggies.SetItemChecked(3, True)
                    checkBxVeggies.SetItemChecked(6, True)
                    checkBxVeggies.SetItemChecked(7, True)
                    checkBxVeggies.SetItemChecked(9, True)
                    checkBxVeggies.SetItemChecked(0, True)
                    cmBxSize.Enabled = True
                    cmBxCrust.Enabled = True
                    cmBxSauce.SelectedIndex = 0
                    cmBxSauce.Enabled = True
                    SetSizePrices()
                Case 9
                    checkBxVeggies.Enabled = True
                    checkBxMeats.Enabled = True

                    For i = 0 To 8
                        checkBxMeats.SetItemChecked(i, True)
                    Next
                    For i = 0 To 10
                        checkBxVeggies.SetItemChecked(i, True)
                    Next
                    cmBxSize.Enabled = True
                    cmBxCrust.Enabled = True
                    cmBxSauce.SelectedIndex = 0
                    cmBxSauce.Enabled = True
                    SetSizePrices()
                Case Else
                    For i = 0 To 8
                        checkBxMeats.SetItemChecked(i, False)
                    Next
                    checkBxMeats.Enabled = True
                    For i = 0 To 10
                        checkBxVeggies.SetItemChecked(i, False)
                    Next
                    checkBxVeggies.Enabled = True
            End Select
        End Sub

        Private Sub cmBxSize_SelectedIndexChanged(ByVal sender As Object, ByVal e As EventArgs)
            Select Case cmBxPizzaType.SelectedIndex
                Case 0, 2
                    SetLevelOnePrice()
                Case 1, 3, 5, 6, 7
                    SetLevelTwoPrice()
                Case 4, 8, 9
                    SetLevelThreePrice()
            End Select
        End Sub

        Private Sub cmBxCrust_SelectedIndexChanged(ByVal sender As Object, ByVal e As EventArgs)
            Select Case cmBxCrust.SelectedIndex
                Case 0, 1, 2

                    If counterCrust = 1 Then
                        AddRemovePizzaPrice(-2.00)
                        counterCrust -= 1
                    End If
                Case 3

                    If counterCrust = 0 Then
                        AddRemovePizzaPrice(2.00)
                        counterCrust += 1
                    End If

                Case Else
            End Select
        End Sub

        Private Sub checkBxMeats_SelectedIndexChanged(ByVal sender As Object, ByVal e As EventArgs)
            If checkBxMeats.GetItemChecked(checkBxMeats.SelectedIndex) = True Then
                Select Case cmBxSize.SelectedIndex
                    Case 0
                        AddRemovePizzaPrice(0.50)
                    Case 1, 2
                        AddRemovePizzaPrice(1.00)
                    Case 3
                        AddRemovePizzaPrice(1.50)
                End Select
            End If

            If checkBxMeats.GetItemChecked(checkBxMeats.SelectedIndex) = False Then
                Select Case cmBxSize.SelectedIndex
                    Case 0
                        AddRemovePizzaPrice(-0.50)
                    Case 1, 2
                        AddRemovePizzaPrice(-1.00)
                    Case 3
                        AddRemovePizzaPrice(-1.50)
                End Select
            End If
        End Sub

        Private Sub checkBxVeggies_SelectedIndexChanged(ByVal sender As Object, ByVal e As EventArgs)
            If checkBxVeggies.GetItemChecked(checkBxVeggies.SelectedIndex) = True Then
                Select Case cmBxSize.SelectedIndex
                    Case 0
                        AddRemovePizzaPrice(0.50)
                    Case 1, 2
                        AddRemovePizzaPrice(1.00)
                    Case 3
                        AddRemovePizzaPrice(1.50)
                End Select
            End If

            If checkBxVeggies.GetItemChecked(checkBxVeggies.SelectedIndex) = False Then
                Select Case cmBxSize.SelectedIndex
                    Case 0
                        AddRemovePizzaPrice(-0.50)
                    Case 1, 2
                        AddRemovePizzaPrice(-1.00)
                    Case 3
                        AddRemovePizzaPrice(-1.50)
                End Select
            End If

        End Sub

        Private Sub btnAddPizza_Click(ByVal sender As Object, ByVal e As EventArgs)
            If Equals(cmBxPizzaType.Text, "") Then
                MessageBox.Show("You have to select a pizza type in order to add a pizza!", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error)
            ElseIf Equals(cmBxSize.Text, "") Then
                MessageBox.Show("You have to select a size in order to add a pizza!", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error)
            ElseIf Equals(cmBxCrust.Text, "") Then
                MessageBox.Show("You have to select a crust type in order to add a pizza!", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error)
            ElseIf Equals(cmBxSauce.Text, "") Then
                MessageBox.Show("You have to select a sauce in order to add a pizza!", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error)
            ElseIf counterPizzaOrder > 9 Then
                MessageBox.Show("I am sorry. You have reached the maximum number of pizza's available to be ordered at our cafe." & " Please remove a pizza from the checkout tab, or reconsider your choice.", "Sorry.")
            Else
                counterPizzaOrder += 1
                subTotal += currentPizzaTotal
                allPizzaTotal += currentPizzaTotal
                CalculateTaxTipAndGrand()
                lblCurrentTotal.Text = String.Format("{0:C}", subTotal)
                pizzaOrder += "1x "
                Select Case cmBxSize.SelectedIndex
                    Case 0
                        pizzaOrder += "Personal "
                    Case 1
                        pizzaOrder += "Medium "
                    Case 2
                        pizzaOrder += "Large "
                    Case 3
                        pizzaOrder += "X Large "
                    Case Else
                        pizzaOrder += "Unknown Error "
                End Select
                pizzaOrder += cmBxPizzaType.Text & " (" & currentPizzaTotal.ToString("C") & ")" & Microsoft.VisualBasic.Constants.vbCrLf
                AddOrderToBoxes()
                cmBxPizzaType.SelectedIndex = -1
                cmBxSize.SelectedIndex = -1
                cmBxCrust.SelectedIndex = -1
                cmBxSauce.SelectedIndex = -1
                counterCrust = 0
                cmBxSize.Enabled = False
                cmBxCrust.Enabled = False
                cmBxSauce.Enabled = False
                checkBxMeats.Enabled = False
                checkBxVeggies.Enabled = False
                For i = 0 To 8
                    checkBxMeats.SetItemChecked(i, False)
                Next
                For i = 0 To 10
                    checkBxVeggies.SetItemChecked(i, False)
                Next
                checkBxVeggies.SetItemChecked(0, True)
                lblPizzaTotal.Text = String.Format("{0:C}", 0.00)
                currentPizzaTotal = 0

                MessageBox.Show("Your pizza has been added to your cart!", "YAY!")

            End If
        End Sub

        Private Sub btnClearSelections_Click(ByVal sender As Object, ByVal e As EventArgs)
            If MessageBox.Show("Are you sure you want to clear your current pizza selections?", "Well do ya?", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) = DialogResult.Yes Then
                cmBxPizzaType.SelectedIndex = -1
                cmBxSize.SelectedIndex = -1
                cmBxCrust.SelectedIndex = -1
                cmBxSauce.SelectedIndex = -1
                counterCrust = 0
                cmBxSize.Enabled = False
                cmBxCrust.Enabled = False
                cmBxSauce.Enabled = False
                checkBxMeats.Enabled = False
                checkBxVeggies.Enabled = False
                For i = 0 To 8
                    checkBxMeats.SetItemChecked(i, False)
                Next
                For i = 0 To 10
                    checkBxVeggies.SetItemChecked(i, False)
                Next
                checkBxVeggies.SetItemChecked(0, True)
                lblPizzaTotal.Text = String.Format("{0:C}", 0.00)
                currentPizzaTotal = 0
            End If
        End Sub

        Private Sub btnAddBeverage_Click(ByVal sender As Object, ByVal e As EventArgs)
            Dim quantity = 0

            Dim dummyCost As Double = 0

            If Equals(cmBxBeverageType.Text, "") Then
                MessageBox.Show("You have to select a beverage type in order to add a beverage!", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error)
            ElseIf Equals(cmBxBeverageSize.Text, "") Then
                MessageBox.Show("You have to select a beverage size in order to add a beverage!", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error)
            ElseIf Equals(txtBxBeverageAmount.Text, "Quantity...") Then
                MessageBox.Show("You have to select a beverage quantity in order to add a beverage!", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error)
            ElseIf Integer.TryParse(txtBxBeverageAmount.Text, quantity) = False Or quantity < 1 Then
                MessageBox.Show("Please only enter positive integers for the beverage quantity!", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error)
            ElseIf counterSideOrder > 9 Then
                MessageBox.Show("I am sorry. You have reached the maximum number of sides available to be ordered at our cafe. Please remove a side from the checkout tab, or reconsider your choice.", "Sorry.")
            Else
                counterSideOrder += 1
                sideOrder += quantity.ToString() & "x "
                Select Case cmBxBeverageSize.SelectedIndex
                    Case 0
                        dummyCost = 1.79 * quantity
                        sideOrder += "18-20 fl oz bottle of "
                        sideOrder += cmBxBeverageType.Text & " (" & dummyCost.ToString("C") & ")" & Microsoft.VisualBasic.Constants.vbCrLf
                    Case 1
                        dummyCost = 2.99 * quantity
                        sideOrder += "2 liter bottle of "
                        sideOrder += cmBxBeverageType.Text & " (" & dummyCost.ToString("C") & ")" & Microsoft.VisualBasic.Constants.vbCrLf
                End Select
                allSideTotal += dummyCost
                subTotal += dummyCost
                CalculateTaxTipAndGrand()
                AddOrderToBoxes()
                cmBxBeverageType.SelectedIndex = -1
                cmBxBeverageSize.SelectedIndex = -1
                txtBxBeverageAmount.Text = "Quantity..."
                lblCurrentTotal.Text = String.Format("{0:C}", subTotal)
                MessageBox.Show("The Beverage has successfully been added to your cart!", "YAY")
            End If
        End Sub

        Private Sub btnAddWings_Click(ByVal sender As Object, ByVal e As EventArgs)
            Dim dummyCost As Double = 0

            If Equals(cmBxWingType.Text, "") Then
                MessageBox.Show("You have to select a wing type in order to add wings!", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error)
            ElseIf Equals(cmBxWingSauce.Text, "") Then
                MessageBox.Show("You have to select a wing sauce in order to add wings!", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error)
            ElseIf Equals(cmBxWingAmount.Text, "") Then
                MessageBox.Show("You have to select a quantity of wings in order to add wings!", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error)
            ElseIf counterSideOrder > 9 Then
                MessageBox.Show("I am sorry. You have reached the maximum number of sides available to be ordered at our cafe. Please remove a side from the checkout tab, or reconsider your choice.", "Sorry.")
            Else
                counterSideOrder += 1
                Select Case cmBxWingAmount.SelectedIndex
                    Case 0
                        dummyCost = 6.99
                        sideOrder += "6 Piece "
                        sideOrder += cmBxWingSauce.Text & " " & cmBxWingType.Text & " Wings"
                        sideOrder += " (" & dummyCost.ToString("C") & ")"
                    Case 1
                        dummyCost = 13.49
                        sideOrder += "12 Piece "
                        sideOrder += cmBxWingSauce.Text & " " & cmBxWingType.Text & " Wings"
                        sideOrder += " (" & dummyCost.ToString("C") & ")"
                    Case 2
                        dummyCost = 18.99
                        sideOrder += "18 Piece "
                        sideOrder += cmBxWingSauce.Text & " " & cmBxWingType.Text & " Wings"
                        sideOrder += " (" & dummyCost.ToString("C") & ")"
                    Case 3
                        dummyCost = 37.98
                        sideOrder += "36 Piece "
                        sideOrder += cmBxWingSauce.Text & " " & cmBxWingType.Text & " Wings"
                        sideOrder += " (" & dummyCost.ToString("C") & ")"
                End Select
                subTotal += dummyCost
                allSideTotal += dummyCost
                lblCurrentTotal.Text = String.Format("{0:C}", subTotal)
                CalculateTaxTipAndGrand()
                sideOrder += Microsoft.VisualBasic.Constants.vbCrLf
                AddOrderToBoxes()
                cmBxWingType.SelectedIndex = -1
                cmBxWingSauce.SelectedIndex = -1
                cmBxWingAmount.SelectedIndex = -1
                MessageBox.Show("The wings have been added to your cart!", "YAY")
            End If
        End Sub

        Private Sub btnAddSides_Click(ByVal sender As Object, ByVal e As EventArgs)
            Dim quantity = 0

            Dim dummyCost As Double = 0

            If Equals(cmBxSidesType.Text, "") Then
                MessageBox.Show("You have to select a side in order to add a side!", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error)
            ElseIf Equals(txtBxSidesAmount.Text, "Quantity...") Then
                MessageBox.Show("You have to enter a quantity for your side in order to add a side!", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error)
            ElseIf Integer.TryParse(txtBxSidesAmount.Text, quantity) = False Or quantity < 1 Then
                MessageBox.Show("Please only enter positive integers for a side quantity.", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error)
            ElseIf counterSideOrder > 9 Then
                MessageBox.Show("I am sorry. You have reached the maximum number of sides available to be ordered at our cafe. Please remove a side from the checkout tab, or reconsider your choice.", "Sorry.")
            Else
                counterSideOrder += 1
                Select Case cmBxSidesType.SelectedIndex
                    Case 0
                        dummyCost = 4.29 * quantity
                        sideOrder += quantity.ToString() & "x Bread Sticks" & " (" & dummyCost.ToString("C") & ")"
                    Case 1
                        dummyCost = 5.29 * quantity
                        sideOrder += quantity.ToString() & "x Cheesesticks" & " (" & dummyCost.ToString("C") & ")"
                    Case 2
                        dummyCost = 4.29 * quantity
                        sideOrder += quantity.ToString() & "x Hot Pepper Bread Sticks" & " (" & dummyCost.ToString("C") & ")"
                    Case 3
                        dummyCost = 3.49 * quantity
                        sideOrder += quantity.ToString() & "x Fries" & " (" & dummyCost.ToString("C") & ")"
                    Case 4
                        dummyCost = 3.49 * quantity
                        sideOrder += quantity.ToString() & "x Cajun Seasoned Fries" & " (" & dummyCost.ToString("C") & ")"
                    Case 5
                        dummyCost = 4.49 * quantity
                        sideOrder += quantity.ToString() & "x Mozzarella Cheesesticks" & " (" & dummyCost.ToString("C") & ")"
                End Select
                subTotal += dummyCost * quantity
                allSideTotal += dummyCost * quantity
                CalculateTaxTipAndGrand()
                lblCurrentTotal.Text = String.Format("{0:C}", subTotal)
                sideOrder += Microsoft.VisualBasic.Constants.vbCrLf
                AddOrderToBoxes()
                cmBxSidesType.SelectedIndex = -1
                txtBxSidesAmount.Text = "Quantity..."
                MessageBox.Show("The side has been added to your cart!", "YAY")
            End If
        End Sub

        Private Sub btnCheckoutAddPizza_Click(ByVal sender As Object, ByVal e As EventArgs)
            tabControl1.SelectTab(0)
        End Sub

        Private Sub rdBtnDelivery_CheckedChanged(ByVal sender As Object, ByVal e As EventArgs)
            If rdBtnDelivery.Checked = True Then
                If counterDelivery <> 1 Then
                    subTotal += 2
                    lblCurrentTotal.Text = String.Format("{0:C}", subTotal)
                    counterDelivery += 1
                    CalculateTaxTipAndGrand()
                End If
            End If
        End Sub

        Private Sub rdBtnWalkIn_CheckedChanged(ByVal sender As Object, ByVal e As EventArgs)
            If rdBtnWalkIn.Checked = True Then
                If counterDelivery <> 0 Then
                    subTotal -= 2
                    lblCurrentTotal.Text = String.Format("{0:C}", subTotal)
                    counterDelivery -= 1
                    CalculateTaxTipAndGrand()
                End If
            End If

        End Sub

        Private Sub btnFinalizeOrder_Click(ByVal sender As Object, ByVal e As EventArgs)
            If rdBtnDelivery.Checked = False And rdBtnWalkIn.Checked = False Then
                MessageBox.Show("Please choose a delivery option in the checkout menu!", "Pretty please.")
            ElseIf subTotal = 0 Or subTotal < 0 Then
                MessageBox.Show("You don't have anything in your cart!", "Awkward.")
            Else
                MessageBox.Show("Alright, this is the final step of the process. Please enter your contact" & " information below so that we may create a profile on hand. This will allow for" & " speedy checkouts. By just giving us your phone number, we will already know" & " who we're delivering to and where we need to go." & Microsoft.VisualBasic.Constants.vbLf & Microsoft.VisualBasic.Constants.vbLf & "Thank you for chosing Zack's Pizza and Cafe!!!", "Thank you!")
                tabControl1.SelectTab(3)
                btnFinishOrder.Enabled = True
            End If
        End Sub

        Private Sub btnCheckoutRemovePizza_Click(ByVal sender As Object, ByVal e As EventArgs)
            If MessageBox.Show("Are you sure you want to remove all of your pizza selections from your cart?" & Microsoft.VisualBasic.Constants.vbLf & "There is no going back.", "Well do ya?", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) = DialogResult.Yes Then
                counterPizzaOrder = 0
                txtBxPizzaOrder.Clear()
                subTotal -= allPizzaTotal
                allPizzaTotal = 0
                lblCurrentTotal.Text = String.Format("{0:C}", subTotal)
                CalculateTaxTipAndGrand()
            End If
        End Sub

        Private Sub btnCheckoutRemoveSide_Click(ByVal sender As Object, ByVal e As EventArgs)
            If MessageBox.Show("Are you sure you want to remove all of your side selections from your cart?" & Microsoft.VisualBasic.Constants.vbLf & "There is no going back.", "Well do ya?", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) = DialogResult.Yes Then
                counterSideOrder = 0
                txtBxSidesOrder.Clear()
                subTotal -= allSideTotal
                allSideTotal = 0
                lblCurrentTotal.Text = String.Format("{0:C}", subTotal)
                CalculateTaxTipAndGrand()
            End If
        End Sub

        Private Sub SetLevelOnePrice()
            Select Case cmBxSize.SelectedIndex
                Case 0
                    lblPizzaTotal.Text = "$4.29"
                    currentPizzaTotal = 4.29
                Case 1
                    lblPizzaTotal.Text = "$7.99"
                    currentPizzaTotal = 7.99
                Case 2
                    lblPizzaTotal.Text = "$9.99"
                    currentPizzaTotal = 9.99
                Case 3
                    lblPizzaTotal.Text = "$12.99"
                    currentPizzaTotal = 12.99
                Case Else
                    lblPizzaTotal.Text = "$0.00"
                    currentPizzaTotal = 0.00
            End Select
        End Sub

        Private Sub SetLevelTwoPrice()
            Select Case cmBxSize.SelectedIndex
                Case 0
                    lblPizzaTotal.Text = "$4.79"
                    currentPizzaTotal = 4.79
                Case 1
                    lblPizzaTotal.Text = "$11.99"
                    currentPizzaTotal = 11.99
                Case 2
                    lblPizzaTotal.Text = "$14.99"
                    currentPizzaTotal = 14.99
                Case 3
                    lblPizzaTotal.Text = "$17.99"
                    currentPizzaTotal = 17.99
                Case Else
                    lblPizzaTotal.Text = "$0.00"
                    currentPizzaTotal = 0.00
            End Select
        End Sub

        Private Sub SetLevelThreePrice()
            Select Case cmBxSize.SelectedIndex
                Case 0
                    lblPizzaTotal.Text = "$5.29"
                    currentPizzaTotal = 5.29
                Case 1
                    lblPizzaTotal.Text = "$12.99"
                    currentPizzaTotal = 12.99
                Case 2
                    lblPizzaTotal.Text = "$15.99"
                    currentPizzaTotal = 15.99
                Case 3
                    lblPizzaTotal.Text = "$18.99"
                    currentPizzaTotal = 18.99
                Case Else
                    lblPizzaTotal.Text = "$0.00"
                    currentPizzaTotal = 0.00
            End Select
        End Sub

        Private Sub btnCheckoutAddSides_Click(ByVal sender As Object, ByVal e As EventArgs)
            tabControl1.SelectTab(1)
        End Sub

        Private Sub SetSizePrices()
            Select Case cmBxPizzaType.SelectedIndex
                Case 0, 2
                    SetLevelOnePrice()
                Case 1, 3, 5, 6, 7
                    SetLevelTwoPrice()
                Case 4, 8, 9
                    SetLevelThreePrice()
            End Select
        End Sub

        Private Sub AddRemovePizzaPrice(ByVal addRemove As Double)
            Dim dummy = currentPizzaTotal

            dummy += addRemove
            currentPizzaTotal = dummy
            lblPizzaTotal.Text = String.Format("{0:C}", dummy)
        End Sub

        Private Sub txtBxBeverageAmount_MouseHover(ByVal sender As Object, ByVal e As EventArgs)
            txtBxBeverageAmount.Text = ""
        End Sub

        Private Sub txtBxSidesAmount_MouseHover(ByVal sender As Object, ByVal e As EventArgs)
            txtBxSidesAmount.Text = ""
        End Sub

        Private Sub CalculateTaxTipAndGrand()
            taxAmount = subTotal * 0.06
            lblTaxAmount.Text = String.Format("{0:C}", taxAmount)
            tipAmount = subTotal * 0.15
            lblTipAmount.Text = String.Format("{0:C}", tipAmount)
            grandTotal = subTotal + taxAmount + tipAmount
            lblGrandTotal.Text = String.Format("{0:C}", grandTotal)
            lblGrandTotalContact.Text = String.Format("{0:C}", grandTotal)
        End Sub

        Private Sub btnChangeOrder_Click(ByVal sender As Object, ByVal e As EventArgs)
            tabControl1.SelectTab(2)
        End Sub

        Private Sub btnFinishOrder_Click(ByVal sender As Object, ByVal e As EventArgs)
            Dim dummy As Double
            Dim emailValid As Boolean

            email = New EmailAddressAttribute()
            emailValid = email.IsValid(txtBxEmail.Text)

            If Equals(txtBxName.Text, "") Then
                MessageBox.Show("Please enter a name into the Name box.", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error)
            ElseIf Equals(txtBxPhone.Text, "") Then
                MessageBox.Show("Please enter a phone number into the phone box.", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error)
            ElseIf txtBxPhone.Text.Length < 10 Or txtBxPhone.Text.Length > 10 Or Double.TryParse(txtBxPhone.Text, dummy) = False Then
                MessageBox.Show("Please only enter a 10 digit numeric phone number into the phone box. No symbols required.", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error)
            ElseIf emailValid = False Then
                MessageBox.Show("Please enter a valid email address.", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error)
            ElseIf Equals(txtBxHomeAddress.Text, "") Then
                MessageBox.Show("Please enter a home address or we can't deliver to you!", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Else
                CalculateTaxTipAndGrand()

                Try

                    Dim emailMessage As MailMessage = New MailMessage("ZacksPizzaCS160@outlook.com", txtBxEmail.Text)
                    Dim client As SmtpClient = New SmtpClient()
                    client.Port = 25
                    client.DeliveryMethod = SmtpDeliveryMethod.Network
                    client.UseDefaultCredentials = False
                    client.Credentials = New NetworkCredential("ZacksPizzaCS160@outlook.com", "zack310302")
                    client.EnableSsl = True
                    client.Timeout = 10000
                    client.Host = "smtp.live.com"
                    emailMessage.Subject = "Zacks Pizza and Cafe Online Order Receipt"
                    emailMessage.Body = "Zack's Pizza and Cafe" & Microsoft.VisualBasic.Constants.vbLf & "Owner: Zackery Crews" & Microsoft.VisualBasic.Constants.vbLf & "Location: 2800 University Blvd." & Microsoft.VisualBasic.Constants.vbLf & "Phone: (904) 555 - 8888" & Microsoft.VisualBasic.Constants.vbLf & "Email: ZacksPizzaCS160@outlook.com" & Microsoft.VisualBasic.Constants.vbLf & Microsoft.VisualBasic.Constants.vbLf & "Pizza's" & Microsoft.VisualBasic.Constants.vbLf & Microsoft.VisualBasic.Constants.vbLf & pizzaOrder & Microsoft.VisualBasic.Constants.vbLf & Microsoft.VisualBasic.Constants.vbLf & "Sides" & Microsoft.VisualBasic.Constants.vbLf & Microsoft.VisualBasic.Constants.vbLf & sideOrder & Microsoft.VisualBasic.Constants.vbLf & Microsoft.VisualBasic.Constants.vbLf & "Subtotal: " & subTotal.ToString("C") & Microsoft.VisualBasic.Constants.vbLf & "Tax: " & taxAmount.ToString("C") & Microsoft.VisualBasic.Constants.vbLf & "Tip (15%): " & tipAmount.ToString() & Microsoft.VisualBasic.Constants.vbLf & Microsoft.VisualBasic.Constants.vbLf & "Grand Total: " & grandTotal.ToString() & Microsoft.VisualBasic.Constants.vbLf & Microsoft.VisualBasic.Constants.vbLf & Microsoft.VisualBasic.Constants.vbLf & "Thank you for choosing Zack's Pizza" & " and Cafe!" & Microsoft.VisualBasic.Constants.vbLf & "Your order will be done within 30 minutes." & Microsoft.VisualBasic.Constants.vbLf & "Other wise everything is half off! Enjoy!"
                    emailMessage.BodyEncoding = Encoding.UTF8
                    emailMessage.DeliveryNotificationOptions = DeliveryNotificationOptions.OnFailure
                    client.Send(emailMessage)
                    MessageBox.Show("Your email receipt has been sent! Thank you for choosing Zack's Pizza and Cafe! Enjoy your food!" & Microsoft.VisualBasic.Constants.vbLf & Microsoft.VisualBasic.Constants.vbLf & "The application will now exit...")
                    Call Application.Exit()
                Catch
                    If MessageBox.Show("Something went wrong and the application couldn't send the email receipt." & Microsoft.VisualBasic.Constants.vbLf & Microsoft.VisualBasic.Constants.vbLf & "Do you wish to double check your email address/order? If not the application will close, " & "and a receipt will be given to you when you receive your order!", "Error!", MessageBoxButtons.YesNo, MessageBoxIcon.Error) = DialogResult.No Then

                        MessageBox.Show("Thank you for choosing Zack's Pizza and Cafe! Enjoy your food!")

                        Call Application.Exit()
                    End If
                End Try
            End If
        End Sub

        Private Sub AddOrderToBoxes()
            txtBxPizzaOrder.Text = pizzaOrder
            txtBxSidesOrder.Text = sideOrder
        End Sub

        Private Function CheckForInternetConnection() As Boolean
            Try
                Using client = New WebClient()
                    Using stream = client.OpenRead("http://www.google.com")
                        Return True
                    End Using
                End Using

            Catch
                Return False
            End Try
        End Function

        Private Sub ChangeConnectionStatus()
            Dim result As Boolean

            result = CheckForInternetConnection()

            If result = True Then
                internetConnectionToolStripMenuItem.BackColor = Color.Green
                internetConnectionToolStripMenuItem.ForeColor = Color.White
                internetConnectionToolStripMenuItem.Image = Image.FromFile("greenCheckMark.jpg")
            Else
                internetConnectionToolStripMenuItem.BackColor = Color.Transparent
                internetConnectionToolStripMenuItem.ForeColor = Color.Black
                internetConnectionToolStripMenuItem.Image = Image.FromFile("redXMark.png")
            End If
        End Sub
    End Class
End Namespace
