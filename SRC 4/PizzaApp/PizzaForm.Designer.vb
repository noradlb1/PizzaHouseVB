Imports System

Namespace PizzaApp
    Partial Class PizzaForm
        ''' <summary>
        ''' Required designer variable.
        ''' </summary>
        Private components As ComponentModel.IContainer = Nothing

        ''' <summary>
        ''' Clean up any resources being used.
        ''' </summary>
        ''' <paramname="disposing">true if managed resources should be disposed; otherwise, false.</param>
        Protected Overrides Sub Dispose(ByVal disposing As Boolean)
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
            MyBase.Dispose(disposing)
        End Sub

#Region "Windows Form Designer generated code"

        ''' <summary>
        ''' Required method for Designer support - do not modify
        ''' the contents of this method with the code editor.
        ''' </summary>
        Private Sub InitializeComponent()
            Dim resources As ComponentModel.ComponentResourceManager = New ComponentModel.ComponentResourceManager(GetType(PizzaForm))
            tabControl1 = New System.Windows.Forms.TabControl()
            tabPizza = New System.Windows.Forms.TabPage()
            lblPizzaTotal = New System.Windows.Forms.Label()
            label8 = New System.Windows.Forms.Label()
            label6 = New System.Windows.Forms.Label()
            checkBxVeggies = New System.Windows.Forms.CheckedListBox()
            label5 = New System.Windows.Forms.Label()
            cmBxPizzaType = New System.Windows.Forms.ComboBox()
            btnClearSelections = New System.Windows.Forms.Button()
            btnAddPizza = New System.Windows.Forms.Button()
            label4 = New System.Windows.Forms.Label()
            checkBxMeats = New System.Windows.Forms.CheckedListBox()
            cmBxSauce = New System.Windows.Forms.ComboBox()
            label3 = New System.Windows.Forms.Label()
            cmBxCrust = New System.Windows.Forms.ComboBox()
            label2 = New System.Windows.Forms.Label()
            label1 = New System.Windows.Forms.Label()
            cmBxSize = New System.Windows.Forms.ComboBox()
            tabSideItems = New System.Windows.Forms.TabPage()
            groupBox3 = New System.Windows.Forms.GroupBox()
            txtBxSidesAmount = New System.Windows.Forms.TextBox()
            label12 = New System.Windows.Forms.Label()
            cmBxSidesType = New System.Windows.Forms.ComboBox()
            btnAddSides = New System.Windows.Forms.Button()
            groupBox2 = New System.Windows.Forms.GroupBox()
            cmBxWingType = New System.Windows.Forms.ComboBox()
            label19 = New System.Windows.Forms.Label()
            label11 = New System.Windows.Forms.Label()
            label17 = New System.Windows.Forms.Label()
            btnAddWings = New System.Windows.Forms.Button()
            cmBxWingSauce = New System.Windows.Forms.ComboBox()
            cmBxWingAmount = New System.Windows.Forms.ComboBox()
            groupBox1 = New System.Windows.Forms.GroupBox()
            btnAddBeverage = New System.Windows.Forms.Button()
            label10 = New System.Windows.Forms.Label()
            label18 = New System.Windows.Forms.Label()
            txtBxBeverageAmount = New System.Windows.Forms.TextBox()
            cmBxBeverageSize = New System.Windows.Forms.ComboBox()
            cmBxBeverageType = New System.Windows.Forms.ComboBox()
            tabCheckout = New System.Windows.Forms.TabPage()
            txtBxSidesOrder = New System.Windows.Forms.TextBox()
            txtBxPizzaOrder = New System.Windows.Forms.TextBox()
            btnCheckoutClearSide = New System.Windows.Forms.Button()
            btnCheckoutAddSides = New System.Windows.Forms.Button()
            btnCheckoutClearPizza = New System.Windows.Forms.Button()
            panel1 = New System.Windows.Forms.Panel()
            rdBtnWalkIn = New System.Windows.Forms.RadioButton()
            rdBtnDelivery = New System.Windows.Forms.RadioButton()
            lblGrandTotal = New System.Windows.Forms.Label()
            lblTaxAmount = New System.Windows.Forms.Label()
            lblTipAmount = New System.Windows.Forms.Label()
            label16 = New System.Windows.Forms.Label()
            label15 = New System.Windows.Forms.Label()
            label14 = New System.Windows.Forms.Label()
            label13 = New System.Windows.Forms.Label()
            label9 = New System.Windows.Forms.Label()
            btnFinalizeOrder = New System.Windows.Forms.Button()
            btnCheckoutAddPizza = New System.Windows.Forms.Button()
            tabContact = New System.Windows.Forms.TabPage()
            picBxLogo = New System.Windows.Forms.PictureBox()
            menuStrip1 = New System.Windows.Forms.MenuStrip()
            exitToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
            viewCurrentOrderToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
            aboutToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
            internetConnectionToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
            label7 = New System.Windows.Forms.Label()
            lblCurrentTotal = New System.Windows.Forms.Label()
            label20 = New System.Windows.Forms.Label()
            label21 = New System.Windows.Forms.Label()
            label22 = New System.Windows.Forms.Label()
            label23 = New System.Windows.Forms.Label()
            txtBxName = New System.Windows.Forms.TextBox()
            txtBxPhone = New System.Windows.Forms.TextBox()
            txtBxEmail = New System.Windows.Forms.TextBox()
            txtBxHomeAddress = New System.Windows.Forms.TextBox()
            label24 = New System.Windows.Forms.Label()
            lblGrandTotalContact = New System.Windows.Forms.Label()
            btnChangeOrder = New System.Windows.Forms.Button()
            btnFinishOrder = New System.Windows.Forms.Button()
            tabControl1.SuspendLayout()
            tabPizza.SuspendLayout()
            tabSideItems.SuspendLayout()
            groupBox3.SuspendLayout()
            groupBox2.SuspendLayout()
            groupBox1.SuspendLayout()
            tabCheckout.SuspendLayout()
            panel1.SuspendLayout()
            tabContact.SuspendLayout()
            CType(picBxLogo, ComponentModel.ISupportInitialize).BeginInit()
            menuStrip1.SuspendLayout()
            SuspendLayout()
            ' 
            ' tabControl1
            ' 
            tabControl1.Controls.Add(tabPizza)
            tabControl1.Controls.Add(tabSideItems)
            tabControl1.Controls.Add(tabCheckout)
            tabControl1.Controls.Add(tabContact)
            tabControl1.Location = New Drawing.Point(12, 191)
            tabControl1.Name = "tabControl1"
            tabControl1.SelectedIndex = 0
            tabControl1.Size = New Drawing.Size(619, 292)
            tabControl1.TabIndex = 0
            ' 
            ' tabPizza
            ' 
            tabPizza.Controls.Add(lblPizzaTotal)
            tabPizza.Controls.Add(label8)
            tabPizza.Controls.Add(label6)
            tabPizza.Controls.Add(checkBxVeggies)
            tabPizza.Controls.Add(label5)
            tabPizza.Controls.Add(cmBxPizzaType)
            tabPizza.Controls.Add(btnClearSelections)
            tabPizza.Controls.Add(btnAddPizza)
            tabPizza.Controls.Add(label4)
            tabPizza.Controls.Add(checkBxMeats)
            tabPizza.Controls.Add(cmBxSauce)
            tabPizza.Controls.Add(label3)
            tabPizza.Controls.Add(cmBxCrust)
            tabPizza.Controls.Add(label2)
            tabPizza.Controls.Add(label1)
            tabPizza.Controls.Add(cmBxSize)
            tabPizza.Location = New Drawing.Point(4, 25)
            tabPizza.Name = "tabPizza"
            tabPizza.Padding = New System.Windows.Forms.Padding(3)
            tabPizza.Size = New Drawing.Size(611, 263)
            tabPizza.TabIndex = 0
            tabPizza.Text = "Pizza"
            tabPizza.UseVisualStyleBackColor = True
            ' 
            ' lblPizzaTotal
            ' 
            lblPizzaTotal.AutoSize = True
            lblPizzaTotal.Location = New Drawing.Point(419, 228)
            lblPizzaTotal.Name = "lblPizzaTotal"
            lblPizzaTotal.Size = New Drawing.Size(36, 17)
            lblPizzaTotal.TabIndex = 15
            lblPizzaTotal.Text = "0.00"
            ' 
            ' label8
            ' 
            label8.AutoSize = True
            label8.Location = New Drawing.Point(321, 228)
            label8.Name = "label8"
            label8.Size = New Drawing.Size(82, 17)
            label8.TabIndex = 14
            label8.Text = "Pizza Total:"
            ' 
            ' label6
            ' 
            label6.AutoSize = True
            label6.Location = New Drawing.Point(434, 19)
            label6.Name = "label6"
            label6.Size = New Drawing.Size(145, 17)
            label6.TabIndex = 13
            label6.Text = "Veggies ($1.00 Each)"
            ' 
            ' checkBxVeggies
            ' 
            checkBxVeggies.CheckOnClick = True
            checkBxVeggies.FormattingEnabled = True
            checkBxVeggies.Items.AddRange(New Object() {"Cheese", "Mushrooms", "Spinach", "Cherry Peppers", "Red Onions", "Black Olives", "Green Bell Peppers", "Sliced Banana Peppers", "Pineapple", "Sliced Jalapenos", "Diced Tomatoes"})
            checkBxVeggies.Location = New Drawing.Point(422, 39)
            checkBxVeggies.Name = "checkBxVeggies"
            checkBxVeggies.Size = New Drawing.Size(170, 140)
            checkBxVeggies.TabIndex = 12
            AddHandler checkBxVeggies.SelectedIndexChanged, New EventHandler(AddressOf checkBxVeggies_SelectedIndexChanged)
            ' 
            ' label5
            ' 
            label5.AutoSize = True
            label5.Location = New Drawing.Point(67, 19)
            label5.Name = "label5"
            label5.Size = New Drawing.Size(94, 17)
            label5.TabIndex = 11
            label5.Text = "Type of Pizza"
            ' 
            ' cmBxPizzaType
            ' 
            cmBxPizzaType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
            cmBxPizzaType.FormattingEnabled = True
            cmBxPizzaType.Items.AddRange(New Object() {"Custom", "Pepperoni", "Cheese", "Hawaiian", "Chicken Bacon Parmesean", "Meat Lovers", "Veggie Lovers", "The Works", "Pepper Madness", "Super Surpreme"})
            cmBxPizzaType.Location = New Drawing.Point(20, 39)
            cmBxPizzaType.Name = "cmBxPizzaType"
            cmBxPizzaType.Size = New Drawing.Size(196, 24)
            cmBxPizzaType.TabIndex = 10
            AddHandler cmBxPizzaType.SelectedIndexChanged, New EventHandler(AddressOf cmBxPizzaType_SelectedIndexChanged)
            ' 
            ' btnClearSelections
            ' 
            btnClearSelections.Location = New Drawing.Point(437, 190)
            btnClearSelections.Name = "btnClearSelections"
            btnClearSelections.Size = New Drawing.Size(137, 24)
            btnClearSelections.TabIndex = 9
            btnClearSelections.Text = "Clear Selections"
            btnClearSelections.UseVisualStyleBackColor = True
            AddHandler btnClearSelections.Click, New EventHandler(AddressOf btnClearSelections_Click)
            ' 
            ' btnAddPizza
            ' 
            btnAddPizza.Location = New Drawing.Point(256, 190)
            btnAddPizza.Name = "btnAddPizza"
            btnAddPizza.Size = New Drawing.Size(122, 24)
            btnAddPizza.TabIndex = 8
            btnAddPizza.Text = "Add Pizza"
            btnAddPizza.UseVisualStyleBackColor = True
            AddHandler btnAddPizza.Click, New EventHandler(AddressOf btnAddPizza_Click)
            ' 
            ' label4
            ' 
            label4.AutoSize = True
            label4.Location = New Drawing.Point(253, 19)
            label4.Name = "label4"
            label4.Size = New Drawing.Size(132, 17)
            label4.TabIndex = 7
            label4.Text = "Meats ($1.00 Each)"
            ' 
            ' checkBxMeats
            ' 
            checkBxMeats.CheckOnClick = True
            checkBxMeats.FormattingEnabled = True
            checkBxMeats.Items.AddRange(New Object() {"Pepperoni", "Sausage", "Salami", "Meatball", "Ham", "Bacon", "Grilled Chicken", "Beef", "Pork"})
            checkBxMeats.Location = New Drawing.Point(233, 39)
            checkBxMeats.Name = "checkBxMeats"
            checkBxMeats.Size = New Drawing.Size(170, 140)
            checkBxMeats.TabIndex = 6
            AddHandler checkBxMeats.SelectedIndexChanged, New EventHandler(AddressOf checkBxMeats_SelectedIndexChanged)
            ' 
            ' cmBxSauce
            ' 
            cmBxSauce.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
            cmBxSauce.FormattingEnabled = True
            cmBxSauce.Items.AddRange(New Object() {"Classic Marinara", "Garlic Parmesean", "No Sauce"})
            cmBxSauce.Location = New Drawing.Point(20, 211)
            cmBxSauce.Name = "cmBxSauce"
            cmBxSauce.Size = New Drawing.Size(196, 24)
            cmBxSauce.TabIndex = 5
            ' 
            ' label3
            ' 
            label3.AutoSize = True
            label3.Location = New Drawing.Point(89, 190)
            label3.Name = "label3"
            label3.Size = New Drawing.Size(48, 17)
            label3.TabIndex = 4
            label3.Text = "Sauce"
            ' 
            ' cmBxCrust
            ' 
            cmBxCrust.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
            cmBxCrust.FormattingEnabled = True
            cmBxCrust.Items.AddRange(New Object() {"Pan Pizza", "Hand-Tossed", "Thin and Crispy", "Stuffed Crust ($2.00)"})
            cmBxCrust.Location = New Drawing.Point(20, 153)
            cmBxCrust.Name = "cmBxCrust"
            cmBxCrust.Size = New Drawing.Size(196, 24)
            cmBxCrust.TabIndex = 3
            AddHandler cmBxCrust.SelectedIndexChanged, New EventHandler(AddressOf cmBxCrust_SelectedIndexChanged)
            ' 
            ' label2
            ' 
            label2.AutoSize = True
            label2.Location = New Drawing.Point(96, 133)
            label2.Name = "label2"
            label2.Size = New Drawing.Size(41, 17)
            label2.TabIndex = 2
            label2.Text = "Crust"
            ' 
            ' label1
            ' 
            label1.AutoSize = True
            label1.Location = New Drawing.Point(96, 76)
            label1.Name = "label1"
            label1.Size = New Drawing.Size(35, 17)
            label1.TabIndex = 1
            label1.Text = "Size"
            ' 
            ' cmBxSize
            ' 
            cmBxSize.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
            cmBxSize.FormattingEnabled = True
            cmBxSize.Items.AddRange(New Object() {"Personal ($.50 Tops)", "Medium ", "Large ", "X Large ($1.50 Tops)"})
            cmBxSize.Location = New Drawing.Point(20, 96)
            cmBxSize.Name = "cmBxSize"
            cmBxSize.Size = New Drawing.Size(196, 24)
            cmBxSize.TabIndex = 0
            AddHandler cmBxSize.SelectedIndexChanged, New EventHandler(AddressOf cmBxSize_SelectedIndexChanged)
            ' 
            ' tabSideItems
            ' 
            tabSideItems.Controls.Add(groupBox3)
            tabSideItems.Controls.Add(groupBox2)
            tabSideItems.Controls.Add(groupBox1)
            tabSideItems.Location = New Drawing.Point(4, 25)
            tabSideItems.Name = "tabSideItems"
            tabSideItems.Padding = New System.Windows.Forms.Padding(3)
            tabSideItems.Size = New Drawing.Size(611, 263)
            tabSideItems.TabIndex = 1
            tabSideItems.Text = "Side Items"
            tabSideItems.UseVisualStyleBackColor = True
            ' 
            ' groupBox3
            ' 
            groupBox3.Controls.Add(txtBxSidesAmount)
            groupBox3.Controls.Add(label12)
            groupBox3.Controls.Add(cmBxSidesType)
            groupBox3.Controls.Add(btnAddSides)
            groupBox3.Location = New Drawing.Point(405, 6)
            groupBox3.Name = "groupBox3"
            groupBox3.Size = New Drawing.Size(200, 251)
            groupBox3.TabIndex = 29
            groupBox3.TabStop = False
            ' 
            ' txtBxSidesAmount
            ' 
            txtBxSidesAmount.Location = New Drawing.Point(53, 169)
            txtBxSidesAmount.Name = "txtBxSidesAmount"
            txtBxSidesAmount.Size = New Drawing.Size(100, 22)
            txtBxSidesAmount.TabIndex = 14
            txtBxSidesAmount.Text = "Quantity..."
            AddHandler txtBxSidesAmount.MouseHover, New EventHandler(AddressOf txtBxSidesAmount_MouseHover)
            ' 
            ' label12
            ' 
            label12.AutoSize = True
            label12.Location = New Drawing.Point(79, 22)
            label12.Name = "label12"
            label12.Size = New Drawing.Size(43, 17)
            label12.TabIndex = 7
            label12.Text = "Sides"
            ' 
            ' cmBxSidesType
            ' 
            cmBxSidesType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
            cmBxSidesType.FormattingEnabled = True
            cmBxSidesType.Items.AddRange(New Object() {"Breadsticks ($4.29)", "Cheese Sticks ($5.29)", "Hot Breadsticks ($4.29)", "Fries ($3.49)", "Cajun Fries ($3.49)", "Mozzarella Sticks ($4.49)"})
            cmBxSidesType.Location = New Drawing.Point(20, 51)
            cmBxSidesType.Name = "cmBxSidesType"
            cmBxSidesType.Size = New Drawing.Size(169, 24)
            cmBxSidesType.TabIndex = 23
            ' 
            ' btnAddSides
            ' 
            btnAddSides.Location = New Drawing.Point(13, 208)
            btnAddSides.Name = "btnAddSides"
            btnAddSides.Size = New Drawing.Size(176, 31)
            btnAddSides.TabIndex = 11
            btnAddSides.Text = "Add..."
            btnAddSides.UseVisualStyleBackColor = True
            AddHandler btnAddSides.Click, New EventHandler(AddressOf btnAddSides_Click)
            ' 
            ' groupBox2
            ' 
            groupBox2.Controls.Add(cmBxWingType)
            groupBox2.Controls.Add(label19)
            groupBox2.Controls.Add(label11)
            groupBox2.Controls.Add(label17)
            groupBox2.Controls.Add(btnAddWings)
            groupBox2.Controls.Add(cmBxWingSauce)
            groupBox2.Controls.Add(cmBxWingAmount)
            groupBox2.Location = New Drawing.Point(201, 6)
            groupBox2.Name = "groupBox2"
            groupBox2.Size = New Drawing.Size(198, 251)
            groupBox2.TabIndex = 28
            groupBox2.TabStop = False
            ' 
            ' cmBxWingType
            ' 
            cmBxWingType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
            cmBxWingType.FormattingEnabled = True
            cmBxWingType.Items.AddRange(New Object() {"Traditional", "Breaded Boneless", "Boneless"})
            cmBxWingType.Location = New Drawing.Point(12, 51)
            cmBxWingType.Name = "cmBxWingType"
            cmBxWingType.Size = New Drawing.Size(169, 24)
            cmBxWingType.TabIndex = 20
            ' 
            ' label19
            ' 
            label19.AutoSize = True
            label19.Location = New Drawing.Point(65, 92)
            label19.Name = "label19"
            label19.Size = New Drawing.Size(55, 17)
            label19.TabIndex = 26
            label19.Text = "Sauces"
            ' 
            ' label11
            ' 
            label11.AutoSize = True
            label11.Location = New Drawing.Point(70, 22)
            label11.Name = "label11"
            label11.Size = New Drawing.Size(47, 17)
            label11.TabIndex = 5
            label11.Text = "Wings"
            ' 
            ' label17
            ' 
            label17.AutoSize = True
            label17.Location = New Drawing.Point(65, 149)
            label17.Name = "label17"
            label17.Size = New Drawing.Size(61, 17)
            label17.TabIndex = 24
            label17.Text = "Quantity"
            ' 
            ' btnAddWings
            ' 
            btnAddWings.Location = New Drawing.Point(12, 208)
            btnAddWings.Name = "btnAddWings"
            btnAddWings.Size = New Drawing.Size(169, 31)
            btnAddWings.TabIndex = 10
            btnAddWings.Text = "Add..."
            btnAddWings.UseVisualStyleBackColor = True
            AddHandler btnAddWings.Click, New EventHandler(AddressOf btnAddWings_Click)
            ' 
            ' cmBxWingSauce
            ' 
            cmBxWingSauce.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
            cmBxWingSauce.FormattingEnabled = True
            cmBxWingSauce.Items.AddRange(New Object() {"Traditional BBQ", "Garlic Parmesan", "Honey BBQ", "Buffalo Mild", "Buffalo Medium", "Buffalo Screamers", "Naked"})
            cmBxWingSauce.Location = New Drawing.Point(12, 112)
            cmBxWingSauce.Name = "cmBxWingSauce"
            cmBxWingSauce.Size = New Drawing.Size(169, 24)
            cmBxWingSauce.TabIndex = 21
            ' 
            ' cmBxWingAmount
            ' 
            cmBxWingAmount.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
            cmBxWingAmount.FormattingEnabled = True
            cmBxWingAmount.Items.AddRange(New Object() {"6 Piece ($6.99)", "12 Piece ($13.49)", "18 Piece ($18.99)", "36 Piece ($37.98)"})
            cmBxWingAmount.Location = New Drawing.Point(12, 169)
            cmBxWingAmount.Name = "cmBxWingAmount"
            cmBxWingAmount.Size = New Drawing.Size(169, 24)
            cmBxWingAmount.TabIndex = 22
            ' 
            ' groupBox1
            ' 
            groupBox1.Controls.Add(btnAddBeverage)
            groupBox1.Controls.Add(label10)
            groupBox1.Controls.Add(label18)
            groupBox1.Controls.Add(txtBxBeverageAmount)
            groupBox1.Controls.Add(cmBxBeverageSize)
            groupBox1.Controls.Add(cmBxBeverageType)
            groupBox1.Location = New Drawing.Point(6, 6)
            groupBox1.Name = "groupBox1"
            groupBox1.Size = New Drawing.Size(189, 251)
            groupBox1.TabIndex = 27
            groupBox1.TabStop = False
            ' 
            ' btnAddBeverage
            ' 
            btnAddBeverage.Location = New Drawing.Point(6, 208)
            btnAddBeverage.Name = "btnAddBeverage"
            btnAddBeverage.Size = New Drawing.Size(169, 31)
            btnAddBeverage.TabIndex = 9
            btnAddBeverage.Text = "Add..."
            btnAddBeverage.UseVisualStyleBackColor = True
            AddHandler btnAddBeverage.Click, New EventHandler(AddressOf btnAddBeverage_Click)
            ' 
            ' label10
            ' 
            label10.AutoSize = True
            label10.Location = New Drawing.Point(50, 22)
            label10.Name = "label10"
            label10.Size = New Drawing.Size(76, 17)
            label10.TabIndex = 3
            label10.Text = "Beverages"
            ' 
            ' label18
            ' 
            label18.AutoSize = True
            label18.Location = New Drawing.Point(67, 92)
            label18.Name = "label18"
            label18.Size = New Drawing.Size(42, 17)
            label18.TabIndex = 25
            label18.Text = "Sizes"
            ' 
            ' txtBxBeverageAmount
            ' 
            txtBxBeverageAmount.Location = New Drawing.Point(46, 169)
            txtBxBeverageAmount.Name = "txtBxBeverageAmount"
            txtBxBeverageAmount.Size = New Drawing.Size(91, 22)
            txtBxBeverageAmount.TabIndex = 12
            txtBxBeverageAmount.Text = "Quantity..."
            AddHandler txtBxBeverageAmount.MouseHover, New EventHandler(AddressOf txtBxBeverageAmount_MouseHover)
            ' 
            ' cmBxBeverageSize
            ' 
            cmBxBeverageSize.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
            cmBxBeverageSize.FormattingEnabled = True
            cmBxBeverageSize.Items.AddRange(New Object() {"20 oz Bottle ($1.79)", "Two Liter Bottle ($2.99)"})
            cmBxBeverageSize.Location = New Drawing.Point(6, 112)
            cmBxBeverageSize.Name = "cmBxBeverageSize"
            cmBxBeverageSize.Size = New Drawing.Size(169, 24)
            cmBxBeverageSize.TabIndex = 18
            ' 
            ' cmBxBeverageType
            ' 
            cmBxBeverageType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
            cmBxBeverageType.FormattingEnabled = True
            cmBxBeverageType.Items.AddRange(New Object() {"Pepsi", "Diet Pepsi", "Mountain Dew", "Diet Mtn Dew", "Orange Crush", "Grape Crush", "Sierra Mist", "Dr. Pepper", "Diet Dr. Pepper", "Root Beer", "Water"})
            cmBxBeverageType.Location = New Drawing.Point(6, 51)
            cmBxBeverageType.Name = "cmBxBeverageType"
            cmBxBeverageType.Size = New Drawing.Size(169, 24)
            cmBxBeverageType.TabIndex = 19
            ' 
            ' tabCheckout
            ' 
            tabCheckout.Controls.Add(txtBxSidesOrder)
            tabCheckout.Controls.Add(txtBxPizzaOrder)
            tabCheckout.Controls.Add(btnCheckoutClearSide)
            tabCheckout.Controls.Add(btnCheckoutAddSides)
            tabCheckout.Controls.Add(btnCheckoutClearPizza)
            tabCheckout.Controls.Add(panel1)
            tabCheckout.Controls.Add(lblGrandTotal)
            tabCheckout.Controls.Add(lblTaxAmount)
            tabCheckout.Controls.Add(lblTipAmount)
            tabCheckout.Controls.Add(label16)
            tabCheckout.Controls.Add(label15)
            tabCheckout.Controls.Add(label14)
            tabCheckout.Controls.Add(label13)
            tabCheckout.Controls.Add(label9)
            tabCheckout.Controls.Add(btnFinalizeOrder)
            tabCheckout.Controls.Add(btnCheckoutAddPizza)
            tabCheckout.Location = New Drawing.Point(4, 25)
            tabCheckout.Name = "tabCheckout"
            tabCheckout.Size = New Drawing.Size(611, 263)
            tabCheckout.TabIndex = 3
            tabCheckout.Text = "Checkout"
            tabCheckout.UseVisualStyleBackColor = True
            ' 
            ' txtBxSidesOrder
            ' 
            txtBxSidesOrder.Location = New Drawing.Point(218, 29)
            txtBxSidesOrder.Multiline = True
            txtBxSidesOrder.Name = "txtBxSidesOrder"
            txtBxSidesOrder.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
            txtBxSidesOrder.Size = New Drawing.Size(200, 101)
            txtBxSidesOrder.TabIndex = 19
            ' 
            ' txtBxPizzaOrder
            ' 
            txtBxPizzaOrder.Location = New Drawing.Point(12, 30)
            txtBxPizzaOrder.Multiline = True
            txtBxPizzaOrder.Name = "txtBxPizzaOrder"
            txtBxPizzaOrder.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
            txtBxPizzaOrder.Size = New Drawing.Size(200, 100)
            txtBxPizzaOrder.TabIndex = 18
            ' 
            ' btnCheckoutClearSide
            ' 
            btnCheckoutClearSide.Location = New Drawing.Point(319, 136)
            btnCheckoutClearSide.Name = "btnCheckoutClearSide"
            btnCheckoutClearSide.Size = New Drawing.Size(99, 31)
            btnCheckoutClearSide.TabIndex = 17
            btnCheckoutClearSide.Text = "Clear"
            btnCheckoutClearSide.UseVisualStyleBackColor = True
            AddHandler btnCheckoutClearSide.Click, New EventHandler(AddressOf btnCheckoutRemoveSide_Click)
            ' 
            ' btnCheckoutAddSides
            ' 
            btnCheckoutAddSides.Location = New Drawing.Point(218, 136)
            btnCheckoutAddSides.Name = "btnCheckoutAddSides"
            btnCheckoutAddSides.Size = New Drawing.Size(99, 31)
            btnCheckoutAddSides.TabIndex = 16
            btnCheckoutAddSides.Text = "Add"
            btnCheckoutAddSides.UseVisualStyleBackColor = True
            AddHandler btnCheckoutAddSides.Click, New EventHandler(AddressOf btnCheckoutAddSides_Click)
            ' 
            ' btnCheckoutClearPizza
            ' 
            btnCheckoutClearPizza.Location = New Drawing.Point(113, 136)
            btnCheckoutClearPizza.Name = "btnCheckoutClearPizza"
            btnCheckoutClearPizza.Size = New Drawing.Size(99, 31)
            btnCheckoutClearPizza.TabIndex = 15
            btnCheckoutClearPizza.Text = "Clear"
            btnCheckoutClearPizza.UseVisualStyleBackColor = True
            AddHandler btnCheckoutClearPizza.Click, New EventHandler(AddressOf btnCheckoutRemovePizza_Click)
            ' 
            ' panel1
            ' 
            panel1.Controls.Add(rdBtnWalkIn)
            panel1.Controls.Add(rdBtnDelivery)
            panel1.Location = New Drawing.Point(442, 49)
            panel1.Name = "panel1"
            panel1.Size = New Drawing.Size(165, 81)
            panel1.TabIndex = 14
            ' 
            ' rdBtnWalkIn
            ' 
            rdBtnWalkIn.AutoSize = True
            rdBtnWalkIn.Location = New Drawing.Point(4, 34)
            rdBtnWalkIn.Name = "rdBtnWalkIn"
            rdBtnWalkIn.Size = New Drawing.Size(136, 21)
            rdBtnWalkIn.TabIndex = 1
            rdBtnWalkIn.TabStop = True
            rdBtnWalkIn.Text = "Walk-In (No Fee)"
            rdBtnWalkIn.UseVisualStyleBackColor = True
            AddHandler rdBtnWalkIn.CheckedChanged, New EventHandler(AddressOf rdBtnWalkIn_CheckedChanged)
            ' 
            ' rdBtnDelivery
            ' 
            rdBtnDelivery.AutoSize = True
            rdBtnDelivery.Location = New Drawing.Point(4, 7)
            rdBtnDelivery.Name = "rdBtnDelivery"
            rdBtnDelivery.Size = New Drawing.Size(158, 21)
            rdBtnDelivery.TabIndex = 0
            rdBtnDelivery.TabStop = True
            rdBtnDelivery.Text = "Delivery ($2.00 Fee)"
            rdBtnDelivery.UseVisualStyleBackColor = True
            AddHandler rdBtnDelivery.CheckedChanged, New EventHandler(AddressOf rdBtnDelivery_CheckedChanged)
            ' 
            ' lblGrandTotal
            ' 
            lblGrandTotal.AutoSize = True
            lblGrandTotal.Location = New Drawing.Point(358, 202)
            lblGrandTotal.Name = "lblGrandTotal"
            lblGrandTotal.Size = New Drawing.Size(44, 17)
            lblGrandTotal.TabIndex = 13
            lblGrandTotal.Text = "$0.00"
            ' 
            ' lblTaxAmount
            ' 
            lblTaxAmount.AutoSize = True
            lblTaxAmount.Location = New Drawing.Point(146, 215)
            lblTaxAmount.Name = "lblTaxAmount"
            lblTaxAmount.Size = New Drawing.Size(44, 17)
            lblTaxAmount.TabIndex = 12
            lblTaxAmount.Text = "$0.00"
            ' 
            ' lblTipAmount
            ' 
            lblTipAmount.AutoSize = True
            lblTipAmount.Location = New Drawing.Point(146, 190)
            lblTipAmount.Name = "lblTipAmount"
            lblTipAmount.Size = New Drawing.Size(44, 17)
            lblTipAmount.TabIndex = 11
            lblTipAmount.Text = "$0.00"
            ' 
            ' label16
            ' 
            label16.AutoSize = True
            label16.Location = New Drawing.Point(249, 202)
            label16.Name = "label16"
            label16.Size = New Drawing.Size(88, 17)
            label16.TabIndex = 10
            label16.Text = "Grand Total:"
            ' 
            ' label15
            ' 
            label15.AutoSize = True
            label15.Location = New Drawing.Point(37, 215)
            label15.Name = "label15"
            label15.Size = New Drawing.Size(35, 17)
            label15.TabIndex = 9
            label15.Text = "Tax:"
            ' 
            ' label14
            ' 
            label14.AutoSize = True
            label14.Location = New Drawing.Point(37, 190)
            label14.Name = "label14"
            label14.Size = New Drawing.Size(74, 17)
            label14.TabIndex = 8
            label14.Text = "Tip (15%):"
            ' 
            ' label13
            ' 
            label13.AutoSize = True
            label13.Location = New Drawing.Point(294, 9)
            label13.Name = "label13"
            label13.Size = New Drawing.Size(43, 17)
            label13.TabIndex = 7
            label13.Text = "Sides"
            ' 
            ' label9
            ' 
            label9.AutoSize = True
            label9.Location = New Drawing.Point(87, 10)
            label9.Name = "label9"
            label9.Size = New Drawing.Size(49, 17)
            label9.TabIndex = 6
            label9.Text = "Pizzas"
            ' 
            ' btnFinalizeOrder
            ' 
            btnFinalizeOrder.Location = New Drawing.Point(442, 195)
            btnFinalizeOrder.Name = "btnFinalizeOrder"
            btnFinalizeOrder.Size = New Drawing.Size(129, 31)
            btnFinalizeOrder.TabIndex = 3
            btnFinalizeOrder.Text = "Finalize Order"
            btnFinalizeOrder.UseVisualStyleBackColor = True
            AddHandler btnFinalizeOrder.Click, New EventHandler(AddressOf btnFinalizeOrder_Click)
            ' 
            ' btnCheckoutAddPizza
            ' 
            btnCheckoutAddPizza.Location = New Drawing.Point(12, 136)
            btnCheckoutAddPizza.Name = "btnCheckoutAddPizza"
            btnCheckoutAddPizza.Size = New Drawing.Size(99, 31)
            btnCheckoutAddPizza.TabIndex = 2
            btnCheckoutAddPizza.Text = "Add"
            btnCheckoutAddPizza.UseVisualStyleBackColor = True
            AddHandler btnCheckoutAddPizza.Click, New EventHandler(AddressOf btnCheckoutAddPizza_Click)
            ' 
            ' tabContact
            ' 
            tabContact.Controls.Add(btnFinishOrder)
            tabContact.Controls.Add(btnChangeOrder)
            tabContact.Controls.Add(lblGrandTotalContact)
            tabContact.Controls.Add(label24)
            tabContact.Controls.Add(txtBxHomeAddress)
            tabContact.Controls.Add(txtBxEmail)
            tabContact.Controls.Add(txtBxPhone)
            tabContact.Controls.Add(txtBxName)
            tabContact.Controls.Add(label23)
            tabContact.Controls.Add(label22)
            tabContact.Controls.Add(label21)
            tabContact.Controls.Add(label20)
            tabContact.Location = New Drawing.Point(4, 25)
            tabContact.Name = "tabContact"
            tabContact.Size = New Drawing.Size(611, 263)
            tabContact.TabIndex = 2
            tabContact.Text = "Contact Info"
            ' 
            ' picBxLogo
            ' 
            picBxLogo.Image = CType(resources.GetObject("picBxLogo.Image"), Drawing.Image)
            picBxLogo.Location = New Drawing.Point(16, 36)
            picBxLogo.Name = "picBxLogo"
            picBxLogo.Size = New Drawing.Size(619, 140)
            picBxLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
            picBxLogo.TabIndex = 1
            picBxLogo.TabStop = False
            ' 
            ' menuStrip1
            ' 
            menuStrip1.ImageScalingSize = New Drawing.Size(20, 20)
            menuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {exitToolStripMenuItem, viewCurrentOrderToolStripMenuItem, aboutToolStripMenuItem, internetConnectionToolStripMenuItem})
            menuStrip1.Location = New Drawing.Point(0, 0)
            menuStrip1.Name = "menuStrip1"
            menuStrip1.Size = New Drawing.Size(643, 28)
            menuStrip1.TabIndex = 2
            menuStrip1.Text = "menuStrip1"
            ' 
            ' exitToolStripMenuItem
            ' 
            exitToolStripMenuItem.Name = "exitToolStripMenuItem"
            exitToolStripMenuItem.Size = New Drawing.Size(45, 24)
            exitToolStripMenuItem.Text = "Exit"
            AddHandler exitToolStripMenuItem.Click, New EventHandler(AddressOf exitToolStripMenuItem_Click)
            ' 
            ' viewCurrentOrderToolStripMenuItem
            ' 
            viewCurrentOrderToolStripMenuItem.Name = "viewCurrentOrderToolStripMenuItem"
            viewCurrentOrderToolStripMenuItem.Size = New Drawing.Size(147, 24)
            viewCurrentOrderToolStripMenuItem.Text = "View Current Order"
            AddHandler viewCurrentOrderToolStripMenuItem.Click, New EventHandler(AddressOf viewCurrentOrderToolStripMenuItem_Click)
            ' 
            ' aboutToolStripMenuItem
            ' 
            aboutToolStripMenuItem.Name = "aboutToolStripMenuItem"
            aboutToolStripMenuItem.Size = New Drawing.Size(62, 24)
            aboutToolStripMenuItem.Text = "About"
            AddHandler aboutToolStripMenuItem.Click, New EventHandler(AddressOf aboutToolStripMenuItem_Click)
            ' 
            ' internetConnectionToolStripMenuItem
            ' 
            internetConnectionToolStripMenuItem.BackColor = Drawing.Color.Green
            internetConnectionToolStripMenuItem.ForeColor = Drawing.SystemColors.Control
            internetConnectionToolStripMenuItem.Image = CType(resources.GetObject("internetConnectionToolStripMenuItem.Image"), Drawing.Image)
            internetConnectionToolStripMenuItem.Name = "internetConnectionToolStripMenuItem"
            internetConnectionToolStripMenuItem.Size = New Drawing.Size(171, 24)
            internetConnectionToolStripMenuItem.Text = "Internet Connection"
            ' 
            ' label7
            ' 
            label7.AutoSize = True
            label7.Location = New Drawing.Point(418, 171)
            label7.Name = "label7"
            label7.Size = New Drawing.Size(73, 17)
            label7.TabIndex = 3
            label7.Text = "Sub Total:"
            ' 
            ' lblCurrentTotal
            ' 
            lblCurrentTotal.AutoSize = True
            lblCurrentTotal.Location = New Drawing.Point(519, 171)
            lblCurrentTotal.Name = "lblCurrentTotal"
            lblCurrentTotal.Size = New Drawing.Size(44, 17)
            lblCurrentTotal.TabIndex = 4
            lblCurrentTotal.Text = "$0.00"
            ' 
            ' label20
            ' 
            label20.AutoSize = True
            label20.Location = New Drawing.Point(16, 23)
            label20.Name = "label20"
            label20.Size = New Drawing.Size(49, 17)
            label20.TabIndex = 0
            label20.Text = "Name:"
            ' 
            ' label21
            ' 
            label21.AutoSize = True
            label21.Location = New Drawing.Point(16, 80)
            label21.Name = "label21"
            label21.Size = New Drawing.Size(53, 17)
            label21.TabIndex = 1
            label21.Text = "Phone:"
            ' 
            ' label22
            ' 
            label22.AutoSize = True
            label22.Location = New Drawing.Point(16, 140)
            label22.Name = "label22"
            label22.Size = New Drawing.Size(51, 17)
            label22.TabIndex = 2
            label22.Text = "E-Mail:"
            ' 
            ' label23
            ' 
            label23.AutoSize = True
            label23.Location = New Drawing.Point(16, 204)
            label23.Name = "label23"
            label23.Size = New Drawing.Size(105, 17)
            label23.TabIndex = 3
            label23.Text = "Home Address:"
            ' 
            ' txtBxName
            ' 
            txtBxName.Location = New Drawing.Point(134, 20)
            txtBxName.Name = "txtBxName"
            txtBxName.Size = New Drawing.Size(208, 22)
            txtBxName.TabIndex = 4
            ' 
            ' txtBxPhone
            ' 
            txtBxPhone.Location = New Drawing.Point(134, 77)
            txtBxPhone.Name = "txtBxPhone"
            txtBxPhone.Size = New Drawing.Size(208, 22)
            txtBxPhone.TabIndex = 5
            ' 
            ' txtBxEmail
            ' 
            txtBxEmail.Location = New Drawing.Point(134, 137)
            txtBxEmail.Name = "txtBxEmail"
            txtBxEmail.Size = New Drawing.Size(208, 22)
            txtBxEmail.TabIndex = 6
            ' 
            ' txtBxHomeAddress
            ' 
            txtBxHomeAddress.Location = New Drawing.Point(134, 201)
            txtBxHomeAddress.Name = "txtBxHomeAddress"
            txtBxHomeAddress.Size = New Drawing.Size(208, 22)
            txtBxHomeAddress.TabIndex = 7
            ' 
            ' label24
            ' 
            label24.AutoSize = True
            label24.Location = New Drawing.Point(402, 68)
            label24.Name = "label24"
            label24.Size = New Drawing.Size(88, 17)
            label24.TabIndex = 8
            label24.Text = "Grand Total:"
            ' 
            ' lblGrandTotalContact
            ' 
            lblGrandTotalContact.AutoSize = True
            lblGrandTotalContact.Location = New Drawing.Point(503, 68)
            lblGrandTotalContact.Name = "lblGrandTotalContact"
            lblGrandTotalContact.Size = New Drawing.Size(44, 17)
            lblGrandTotalContact.TabIndex = 9
            lblGrandTotalContact.Text = "$0.00"
            ' 
            ' btnChangeOrder
            ' 
            btnChangeOrder.Location = New Drawing.Point(405, 126)
            btnChangeOrder.Name = "btnChangeOrder"
            btnChangeOrder.Size = New Drawing.Size(130, 31)
            btnChangeOrder.TabIndex = 10
            btnChangeOrder.Text = "Change Order"
            btnChangeOrder.UseVisualStyleBackColor = True
            AddHandler btnChangeOrder.Click, New EventHandler(AddressOf btnChangeOrder_Click)
            ' 
            ' btnFinishOrder
            ' 
            btnFinishOrder.Location = New Drawing.Point(405, 197)
            btnFinishOrder.Name = "btnFinishOrder"
            btnFinishOrder.Size = New Drawing.Size(130, 31)
            btnFinishOrder.TabIndex = 11
            btnFinishOrder.Text = "Finish Order"
            btnFinishOrder.UseVisualStyleBackColor = True
            AddHandler btnFinishOrder.Click, New EventHandler(AddressOf btnFinishOrder_Click)
            ' 
            ' PizzaForm
            ' 
            AutoScaleDimensions = New Drawing.SizeF(8.0F, 16.0F)
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            ClientSize = New Drawing.Size(643, 495)
            Controls.Add(lblCurrentTotal)
            Controls.Add(label7)
            Controls.Add(picBxLogo)
            Controls.Add(tabControl1)
            Controls.Add(menuStrip1)
            Name = "PizzaForm"
            Text = "Zack's Pizza and Cafe"
            AddHandler Load, New EventHandler(AddressOf PizzaForm_Load)
            tabControl1.ResumeLayout(False)
            tabPizza.ResumeLayout(False)
            tabPizza.PerformLayout()
            tabSideItems.ResumeLayout(False)
            groupBox3.ResumeLayout(False)
            groupBox3.PerformLayout()
            groupBox2.ResumeLayout(False)
            groupBox2.PerformLayout()
            groupBox1.ResumeLayout(False)
            groupBox1.PerformLayout()
            tabCheckout.ResumeLayout(False)
            tabCheckout.PerformLayout()
            panel1.ResumeLayout(False)
            panel1.PerformLayout()
            tabContact.ResumeLayout(False)
            tabContact.PerformLayout()
            CType(picBxLogo, ComponentModel.ISupportInitialize).EndInit()
            menuStrip1.ResumeLayout(False)
            menuStrip1.PerformLayout()
            ResumeLayout(False)
            PerformLayout()

        End Sub

#End Region

        Private tabControl1 As System.Windows.Forms.TabControl
        Private tabPizza As System.Windows.Forms.TabPage
        Private label5 As System.Windows.Forms.Label
        Private cmBxPizzaType As System.Windows.Forms.ComboBox
        Private btnClearSelections As System.Windows.Forms.Button
        Private btnAddPizza As System.Windows.Forms.Button
        Private label4 As System.Windows.Forms.Label
        Private checkBxMeats As System.Windows.Forms.CheckedListBox
        Private cmBxSauce As System.Windows.Forms.ComboBox
        Private label3 As System.Windows.Forms.Label
        Private cmBxCrust As System.Windows.Forms.ComboBox
        Private label2 As System.Windows.Forms.Label
        Private label1 As System.Windows.Forms.Label
        Private cmBxSize As System.Windows.Forms.ComboBox
        Private tabSideItems As System.Windows.Forms.TabPage
        Private tabContact As System.Windows.Forms.TabPage
        Private tabCheckout As System.Windows.Forms.TabPage
        Private picBxLogo As System.Windows.Forms.PictureBox
        Private label6 As System.Windows.Forms.Label
        Private checkBxVeggies As System.Windows.Forms.CheckedListBox
        Private menuStrip1 As System.Windows.Forms.MenuStrip
        Private viewCurrentOrderToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
        Private aboutToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
        Private label7 As System.Windows.Forms.Label
        Private lblCurrentTotal As System.Windows.Forms.Label
        Private lblPizzaTotal As System.Windows.Forms.Label
        Private label8 As System.Windows.Forms.Label
        Private cmBxSidesType As System.Windows.Forms.ComboBox
        Private cmBxWingAmount As System.Windows.Forms.ComboBox
        Private cmBxWingSauce As System.Windows.Forms.ComboBox
        Private cmBxWingType As System.Windows.Forms.ComboBox
        Private cmBxBeverageType As System.Windows.Forms.ComboBox
        Private cmBxBeverageSize As System.Windows.Forms.ComboBox
        Private txtBxSidesAmount As System.Windows.Forms.TextBox
        Private txtBxBeverageAmount As System.Windows.Forms.TextBox
        Private btnAddSides As System.Windows.Forms.Button
        Private btnAddWings As System.Windows.Forms.Button
        Private btnAddBeverage As System.Windows.Forms.Button
        Private label12 As System.Windows.Forms.Label
        Private label11 As System.Windows.Forms.Label
        Private label10 As System.Windows.Forms.Label
        Private panel1 As System.Windows.Forms.Panel
        Private rdBtnWalkIn As System.Windows.Forms.RadioButton
        Private rdBtnDelivery As System.Windows.Forms.RadioButton
        Private lblGrandTotal As System.Windows.Forms.Label
        Private lblTaxAmount As System.Windows.Forms.Label
        Private lblTipAmount As System.Windows.Forms.Label
        Private label16 As System.Windows.Forms.Label
        Private label15 As System.Windows.Forms.Label
        Private label14 As System.Windows.Forms.Label
        Private label13 As System.Windows.Forms.Label
        Private label9 As System.Windows.Forms.Label
        Private btnFinalizeOrder As System.Windows.Forms.Button
        Private btnCheckoutAddPizza As System.Windows.Forms.Button
        Private btnCheckoutClearSide As System.Windows.Forms.Button
        Private btnCheckoutAddSides As System.Windows.Forms.Button
        Private btnCheckoutClearPizza As System.Windows.Forms.Button
        Private exitToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
        Private groupBox3 As System.Windows.Forms.GroupBox
        Private groupBox2 As System.Windows.Forms.GroupBox
        Private label19 As System.Windows.Forms.Label
        Private label17 As System.Windows.Forms.Label
        Private groupBox1 As System.Windows.Forms.GroupBox
        Private label18 As System.Windows.Forms.Label
        Private txtBxSidesOrder As System.Windows.Forms.TextBox
        Private txtBxPizzaOrder As System.Windows.Forms.TextBox
        Private internetConnectionToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
        Private btnFinishOrder As System.Windows.Forms.Button
        Private btnChangeOrder As System.Windows.Forms.Button
        Private lblGrandTotalContact As System.Windows.Forms.Label
        Private label24 As System.Windows.Forms.Label
        Private txtBxHomeAddress As System.Windows.Forms.TextBox
        Private txtBxEmail As System.Windows.Forms.TextBox
        Private txtBxPhone As System.Windows.Forms.TextBox
        Private txtBxName As System.Windows.Forms.TextBox
        Private label23 As System.Windows.Forms.Label
        Private label22 As System.Windows.Forms.Label
        Private label21 As System.Windows.Forms.Label
        Private label20 As System.Windows.Forms.Label
    End Class
End Namespace
