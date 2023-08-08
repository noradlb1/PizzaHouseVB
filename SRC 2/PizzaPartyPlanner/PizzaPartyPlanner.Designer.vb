Imports System

Namespace PizzaPartyPlanner
    Partial Class frmPizzaParty
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
            cboPizzaSize = New System.Windows.Forms.ComboBox()
            rdoBYO = New System.Windows.Forms.RadioButton()
            rdoSpecialty = New System.Windows.Forms.RadioButton()
            groupBox1 = New System.Windows.Forms.GroupBox()
            lblPizzaSize = New System.Windows.Forms.Label()
            cboPizzaType = New System.Windows.Forms.ComboBox()
            lblPizzaType = New System.Windows.Forms.Label()
            brnAdd = New System.Windows.Forms.Button()
            grpToppings = New System.Windows.Forms.GroupBox()
            ckbArtichoke = New System.Windows.Forms.CheckBox()
            ckbOlives = New System.Windows.Forms.CheckBox()
            ckbOions = New System.Windows.Forms.CheckBox()
            ckbPeppers = New System.Windows.Forms.CheckBox()
            ckbMushrooms = New System.Windows.Forms.CheckBox()
            ckbBeef = New System.Windows.Forms.CheckBox()
            ckbBacon = New System.Windows.Forms.CheckBox()
            ckbHam = New System.Windows.Forms.CheckBox()
            ckbSausage = New System.Windows.Forms.CheckBox()
            ckbPep = New System.Windows.Forms.CheckBox()
            cboSlices = New System.Windows.Forms.ComboBox()
            lblSlices = New System.Windows.Forms.Label()
            txtNotes = New System.Windows.Forms.TextBox()
            label1 = New System.Windows.Forms.Label()
            label2 = New System.Windows.Forms.Label()
            lblPizzaCost = New System.Windows.Forms.Label()
            btnReport = New System.Windows.Forms.Button()
            btnRemove = New System.Windows.Forms.Button()
            label3 = New System.Windows.Forms.Label()
            lblTotal = New System.Windows.Forms.Label()
            lstPizzaType = New System.Windows.Forms.ListBox()
            label4 = New System.Windows.Forms.Label()
            txtDisplayNotes = New System.Windows.Forms.TextBox()
            btnClear = New System.Windows.Forms.Button()
            groupBox1.SuspendLayout()
            grpToppings.SuspendLayout()
            SuspendLayout()
            ' 
            ' cboPizzaSize
            ' 
            cboPizzaSize.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
            cboPizzaSize.FormattingEnabled = True
            cboPizzaSize.Items.AddRange(New Object() {"Small", "Medium", "Large"})
            cboPizzaSize.Location = New Drawing.Point(127, 72)
            cboPizzaSize.Name = "cboPizzaSize"
            cboPizzaSize.Size = New Drawing.Size(121, 21)
            cboPizzaSize.TabIndex = 0
            AddHandler cboPizzaSize.SelectedIndexChanged, New EventHandler(AddressOf cboPizzaSize_SelectedIndexChanged)
            ' 
            ' rdoBYO
            ' 
            rdoBYO.AutoSize = True
            rdoBYO.Location = New Drawing.Point(115, 19)
            rdoBYO.Name = "rdoBYO"
            rdoBYO.Size = New Drawing.Size(98, 17)
            rdoBYO.TabIndex = 1
            rdoBYO.TabStop = True
            rdoBYO.Text = "Build Your Own"
            rdoBYO.UseVisualStyleBackColor = True
            ' 
            ' rdoSpecialty
            ' 
            rdoSpecialty.AutoSize = True
            rdoSpecialty.Location = New Drawing.Point(6, 19)
            rdoSpecialty.Name = "rdoSpecialty"
            rdoSpecialty.Size = New Drawing.Size(103, 17)
            rdoSpecialty.TabIndex = 2
            rdoSpecialty.TabStop = True
            rdoSpecialty.Text = "Speciality Pizzas"
            rdoSpecialty.UseVisualStyleBackColor = True
            ' 
            ' groupBox1
            ' 
            groupBox1.Controls.Add(rdoSpecialty)
            groupBox1.Controls.Add(rdoBYO)
            groupBox1.Location = New Drawing.Point(12, 12)
            groupBox1.Name = "groupBox1"
            groupBox1.Size = New Drawing.Size(235, 54)
            groupBox1.TabIndex = 3
            groupBox1.TabStop = False
            groupBox1.Text = "Pizza Type"
            ' 
            ' lblPizzaSize
            ' 
            lblPizzaSize.AutoSize = True
            lblPizzaSize.Location = New Drawing.Point(36, 80)
            lblPizzaSize.Name = "lblPizzaSize"
            lblPizzaSize.Size = New Drawing.Size(27, 13)
            lblPizzaSize.TabIndex = 4
            lblPizzaSize.Text = "Size"
            ' 
            ' cboPizzaType
            ' 
            cboPizzaType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
            cboPizzaType.FormattingEnabled = True
            cboPizzaType.Items.AddRange(New Object() {"Surpreme", "BBQ Chicken", "Hawaiian", "Meat Lovers", "Veggy", "Greek", "Cheeseburger"})
            cboPizzaType.Location = New Drawing.Point(127, 99)
            cboPizzaType.Name = "cboPizzaType"
            cboPizzaType.Size = New Drawing.Size(121, 21)
            cboPizzaType.TabIndex = 5
            AddHandler cboPizzaType.SelectedIndexChanged, New EventHandler(AddressOf cboPizzaSize_SelectedIndexChanged)
            ' 
            ' lblPizzaType
            ' 
            lblPizzaType.AutoSize = True
            lblPizzaType.Location = New Drawing.Point(36, 107)
            lblPizzaType.Name = "lblPizzaType"
            lblPizzaType.Size = New Drawing.Size(59, 13)
            lblPizzaType.TabIndex = 6
            lblPizzaType.Text = "Pizza Type"
            ' 
            ' brnAdd
            ' 
            brnAdd.Location = New Drawing.Point(12, 246)
            brnAdd.Name = "brnAdd"
            brnAdd.Size = New Drawing.Size(75, 23)
            brnAdd.TabIndex = 7
            brnAdd.Text = "Add Pizza"
            brnAdd.UseVisualStyleBackColor = True
            AddHandler brnAdd.Click, New EventHandler(AddressOf brnAdd_Click)
            ' 
            ' grpToppings
            ' 
            grpToppings.Controls.Add(ckbArtichoke)
            grpToppings.Controls.Add(ckbOlives)
            grpToppings.Controls.Add(ckbOions)
            grpToppings.Controls.Add(ckbPeppers)
            grpToppings.Controls.Add(ckbMushrooms)
            grpToppings.Controls.Add(ckbBeef)
            grpToppings.Controls.Add(ckbBacon)
            grpToppings.Controls.Add(ckbHam)
            grpToppings.Controls.Add(ckbSausage)
            grpToppings.Controls.Add(ckbPep)
            grpToppings.Location = New Drawing.Point(277, 20)
            grpToppings.Name = "grpToppings"
            grpToppings.Size = New Drawing.Size(221, 151)
            grpToppings.TabIndex = 3
            grpToppings.TabStop = False
            grpToppings.Text = "Toppings sm-$0.25, md-$0.50 lg-$0.75"
            ' 
            ' ckbArtichoke
            ' 
            ckbArtichoke.AutoSize = True
            ckbArtichoke.Location = New Drawing.Point(106, 110)
            ckbArtichoke.Name = "ckbArtichoke"
            ckbArtichoke.Size = New Drawing.Size(71, 17)
            ckbArtichoke.TabIndex = 9
            ckbArtichoke.Text = "Artichoke"
            ckbArtichoke.UseVisualStyleBackColor = True
            AddHandler ckbArtichoke.CheckedChanged, New EventHandler(AddressOf checkbos)
            ' 
            ' ckbOlives
            ' 
            ckbOlives.AutoSize = True
            ckbOlives.Location = New Drawing.Point(106, 87)
            ckbOlives.Name = "ckbOlives"
            ckbOlives.Size = New Drawing.Size(55, 17)
            ckbOlives.TabIndex = 8
            ckbOlives.Text = "Olives"
            ckbOlives.UseVisualStyleBackColor = True
            AddHandler ckbOlives.CheckedChanged, New EventHandler(AddressOf checkbos)
            ' 
            ' ckbOions
            ' 
            ckbOions.AutoSize = True
            ckbOions.Location = New Drawing.Point(106, 64)
            ckbOions.Name = "ckbOions"
            ckbOions.Size = New Drawing.Size(59, 17)
            ckbOions.TabIndex = 7
            ckbOions.Text = "Onions"
            ckbOions.UseVisualStyleBackColor = True
            AddHandler ckbOions.CheckedChanged, New EventHandler(AddressOf checkbos)
            ' 
            ' ckbPeppers
            ' 
            ckbPeppers.AutoSize = True
            ckbPeppers.Location = New Drawing.Point(106, 38)
            ckbPeppers.Name = "ckbPeppers"
            ckbPeppers.Size = New Drawing.Size(65, 17)
            ckbPeppers.TabIndex = 6
            ckbPeppers.Text = "Peppers"
            ckbPeppers.UseVisualStyleBackColor = True
            AddHandler ckbPeppers.CheckedChanged, New EventHandler(AddressOf checkbos)
            ' 
            ' ckbMushrooms
            ' 
            ckbMushrooms.AutoSize = True
            ckbMushrooms.Location = New Drawing.Point(106, 15)
            ckbMushrooms.Name = "ckbMushrooms"
            ckbMushrooms.Size = New Drawing.Size(80, 17)
            ckbMushrooms.TabIndex = 5
            ckbMushrooms.Text = "Mushrooms"
            ckbMushrooms.UseVisualStyleBackColor = True
            AddHandler ckbMushrooms.CheckedChanged, New EventHandler(AddressOf checkbos)
            ' 
            ' ckbBeef
            ' 
            ckbBeef.AutoSize = True
            ckbBeef.Location = New Drawing.Point(3, 106)
            ckbBeef.Name = "ckbBeef"
            ckbBeef.Size = New Drawing.Size(48, 17)
            ckbBeef.TabIndex = 4
            ckbBeef.Text = "Beef"
            ckbBeef.UseVisualStyleBackColor = True
            AddHandler ckbBeef.CheckedChanged, New EventHandler(AddressOf checkbos)
            ' 
            ' ckbBacon
            ' 
            ckbBacon.AutoSize = True
            ckbBacon.Location = New Drawing.Point(3, 83)
            ckbBacon.Name = "ckbBacon"
            ckbBacon.Size = New Drawing.Size(57, 17)
            ckbBacon.TabIndex = 3
            ckbBacon.Text = "Bacon"
            ckbBacon.UseVisualStyleBackColor = True
            AddHandler ckbBacon.CheckedChanged, New EventHandler(AddressOf checkbos)
            ' 
            ' ckbHam
            ' 
            ckbHam.AutoSize = True
            ckbHam.Location = New Drawing.Point(3, 62)
            ckbHam.Name = "ckbHam"
            ckbHam.Size = New Drawing.Size(48, 17)
            ckbHam.TabIndex = 2
            ckbHam.Text = "Ham"
            ckbHam.UseVisualStyleBackColor = True
            AddHandler ckbHam.CheckedChanged, New EventHandler(AddressOf checkbos)
            ' 
            ' ckbSausage
            ' 
            ckbSausage.AutoSize = True
            ckbSausage.Location = New Drawing.Point(3, 39)
            ckbSausage.Name = "ckbSausage"
            ckbSausage.Size = New Drawing.Size(68, 17)
            ckbSausage.TabIndex = 1
            ckbSausage.Text = "Sausage"
            ckbSausage.UseVisualStyleBackColor = True
            AddHandler ckbSausage.CheckedChanged, New EventHandler(AddressOf checkbos)
            ' 
            ' ckbPep
            ' 
            ckbPep.AutoSize = True
            ckbPep.Location = New Drawing.Point(3, 16)
            ckbPep.Name = "ckbPep"
            ckbPep.Size = New Drawing.Size(62, 17)
            ckbPep.TabIndex = 0
            ckbPep.Text = "Peproni"
            ckbPep.UseVisualStyleBackColor = True
            AddHandler ckbPep.CheckedChanged, New EventHandler(AddressOf checkbos)
            ' 
            ' cboSlices
            ' 
            cboSlices.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
            cboSlices.FormattingEnabled = True
            cboSlices.Items.AddRange(New Object() {"4", "6", "8", "10"})
            cboSlices.Location = New Drawing.Point(127, 126)
            cboSlices.Name = "cboSlices"
            cboSlices.Size = New Drawing.Size(121, 21)
            cboSlices.TabIndex = 8
            AddHandler cboSlices.SelectedIndexChanged, New EventHandler(AddressOf cboPizzaSize_SelectedIndexChanged)
            ' 
            ' lblSlices
            ' 
            lblSlices.AutoSize = True
            lblSlices.Location = New Drawing.Point(36, 134)
            lblSlices.Name = "lblSlices"
            lblSlices.Size = New Drawing.Size(85, 13)
            lblSlices.TabIndex = 9
            lblSlices.Text = "Number of slices"
            ' 
            ' txtNotes
            ' 
            txtNotes.Location = New Drawing.Point(127, 155)
            txtNotes.Multiline = True
            txtNotes.Name = "txtNotes"
            txtNotes.Size = New Drawing.Size(121, 71)
            txtNotes.TabIndex = 10
            ' 
            ' label1
            ' 
            label1.AutoSize = True
            label1.Location = New Drawing.Point(36, 158)
            label1.Name = "label1"
            label1.Size = New Drawing.Size(35, 13)
            label1.TabIndex = 11
            label1.Text = "Notes"
            ' 
            ' label2
            ' 
            label2.AutoSize = True
            label2.Location = New Drawing.Point(103, 250)
            label2.Name = "label2"
            label2.Size = New Drawing.Size(90, 13)
            label2.TabIndex = 12
            label2.Text = "Cost of this Pizza:"
            ' 
            ' lblPizzaCost
            ' 
            lblPizzaCost.AutoSize = True
            lblPizzaCost.Location = New Drawing.Point(199, 250)
            lblPizzaCost.Name = "lblPizzaCost"
            lblPizzaCost.Size = New Drawing.Size(34, 13)
            lblPizzaCost.TabIndex = 13
            lblPizzaCost.Text = "$0.00"
            ' 
            ' btnReport
            ' 
            btnReport.Location = New Drawing.Point(239, 488)
            btnReport.Name = "btnReport"
            btnReport.Size = New Drawing.Size(98, 44)
            btnReport.TabIndex = 15
            btnReport.Text = "Create Report"
            btnReport.UseVisualStyleBackColor = True
            AddHandler btnReport.Click, New EventHandler(AddressOf btnReport_Click)
            ' 
            ' btnRemove
            ' 
            btnRemove.Location = New Drawing.Point(12, 488)
            btnRemove.Name = "btnRemove"
            btnRemove.Size = New Drawing.Size(83, 44)
            btnRemove.TabIndex = 16
            btnRemove.Text = "Remove Selected"
            btnRemove.UseVisualStyleBackColor = True
            AddHandler btnRemove.Click, New EventHandler(AddressOf btnRemove_Click)
            ' 
            ' label3
            ' 
            label3.AutoSize = True
            label3.Location = New Drawing.Point(417, 488)
            label3.Name = "label3"
            label3.Size = New Drawing.Size(31, 13)
            label3.TabIndex = 17
            label3.Text = "Total"
            ' 
            ' lblTotal
            ' 
            lblTotal.AutoSize = True
            lblTotal.Location = New Drawing.Point(492, 488)
            lblTotal.Name = "lblTotal"
            lblTotal.Size = New Drawing.Size(34, 13)
            lblTotal.TabIndex = 18
            lblTotal.Text = "$0.00"
            ' 
            ' lstPizzaType
            ' 
            lstPizzaType.FormattingEnabled = True
            lstPizzaType.Location = New Drawing.Point(12, 296)
            lstPizzaType.Name = "lstPizzaType"
            lstPizzaType.Size = New Drawing.Size(200, 186)
            lstPizzaType.TabIndex = 19
            AddHandler lstPizzaType.SelectedIndexChanged, New EventHandler(AddressOf lstPizzaType_SelectedIndexChanged)
            ' 
            ' label4
            ' 
            label4.AutoSize = True
            label4.Location = New Drawing.Point(15, 280)
            label4.Name = "label4"
            label4.Size = New Drawing.Size(32, 13)
            label4.TabIndex = 20
            label4.Text = "Pizza"
            ' 
            ' txtDisplayNotes
            ' 
            txtDisplayNotes.Location = New Drawing.Point(239, 296)
            txtDisplayNotes.Multiline = True
            txtDisplayNotes.Name = "txtDisplayNotes"
            txtDisplayNotes.Size = New Drawing.Size(287, 186)
            txtDisplayNotes.TabIndex = 21
            ' 
            ' btnClear
            ' 
            btnClear.Location = New Drawing.Point(137, 488)
            btnClear.Name = "btnClear"
            btnClear.Size = New Drawing.Size(75, 44)
            btnClear.TabIndex = 22
            btnClear.Text = "Remove All"
            btnClear.UseVisualStyleBackColor = True
            ' 
            ' frmPizzaParty
            ' 
            AutoScaleDimensions = New Drawing.SizeF(6.0F, 13.0F)
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            ClientSize = New Drawing.Size(529, 546)
            Controls.Add(btnClear)
            Controls.Add(txtDisplayNotes)
            Controls.Add(label4)
            Controls.Add(lstPizzaType)
            Controls.Add(lblTotal)
            Controls.Add(label3)
            Controls.Add(btnRemove)
            Controls.Add(btnReport)
            Controls.Add(lblPizzaCost)
            Controls.Add(label2)
            Controls.Add(label1)
            Controls.Add(txtNotes)
            Controls.Add(lblSlices)
            Controls.Add(cboSlices)
            Controls.Add(grpToppings)
            Controls.Add(brnAdd)
            Controls.Add(lblPizzaType)
            Controls.Add(cboPizzaType)
            Controls.Add(lblPizzaSize)
            Controls.Add(groupBox1)
            Controls.Add(cboPizzaSize)
            Name = "frmPizzaParty"
            Text = "Pizza Party Planner"
            groupBox1.ResumeLayout(False)
            groupBox1.PerformLayout()
            grpToppings.ResumeLayout(False)
            grpToppings.PerformLayout()
            ResumeLayout(False)
            PerformLayout()

        End Sub

#End Region

        Private cboPizzaSize As System.Windows.Forms.ComboBox
        Private rdoBYO As System.Windows.Forms.RadioButton
        Private rdoSpecialty As System.Windows.Forms.RadioButton
        Private groupBox1 As System.Windows.Forms.GroupBox
        Private lblPizzaSize As System.Windows.Forms.Label
        Private cboPizzaType As System.Windows.Forms.ComboBox
        Private lblPizzaType As System.Windows.Forms.Label
        Private brnAdd As System.Windows.Forms.Button
        Private grpToppings As System.Windows.Forms.GroupBox
        Private ckbPep As System.Windows.Forms.CheckBox
        Private cboSlices As System.Windows.Forms.ComboBox
        Private lblSlices As System.Windows.Forms.Label
        Private txtNotes As System.Windows.Forms.TextBox
        Private label1 As System.Windows.Forms.Label
        Private ckbArtichoke As System.Windows.Forms.CheckBox
        Private ckbOlives As System.Windows.Forms.CheckBox
        Private ckbOions As System.Windows.Forms.CheckBox
        Private ckbPeppers As System.Windows.Forms.CheckBox
        Private ckbMushrooms As System.Windows.Forms.CheckBox
        Private ckbBeef As System.Windows.Forms.CheckBox
        Private ckbBacon As System.Windows.Forms.CheckBox
        Private ckbHam As System.Windows.Forms.CheckBox
        Private ckbSausage As System.Windows.Forms.CheckBox
        Private label2 As System.Windows.Forms.Label
        Private lblPizzaCost As System.Windows.Forms.Label
        Private btnReport As System.Windows.Forms.Button
        Private btnRemove As System.Windows.Forms.Button
        Private label3 As System.Windows.Forms.Label
        Private lblTotal As System.Windows.Forms.Label
        Private lstPizzaType As System.Windows.Forms.ListBox
        Private label4 As System.Windows.Forms.Label
        Private txtDisplayNotes As System.Windows.Forms.TextBox
        Private btnClear As System.Windows.Forms.Button
    End Class
End Namespace
