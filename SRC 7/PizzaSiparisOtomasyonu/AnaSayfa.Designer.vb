
Imports System

Namespace PizzaSiparisOtomasyonu
    Partial Class AnaSayfa
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
            Me.components = New System.ComponentModel.Container()
            Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(AnaSayfa))
            Me.textBox1 = New System.Windows.Forms.TextBox()
            Me.maskedTextBox1 = New System.Windows.Forms.MaskedTextBox()
            Me.groupBox1 = New System.Windows.Forms.GroupBox()
            Me.numericUpDown2 = New System.Windows.Forms.NumericUpDown()
            Me.numericUpDown1 = New System.Windows.Forms.NumericUpDown()
            Me.label7 = New System.Windows.Forms.Label()
            Me.label6 = New System.Windows.Forms.Label()
            Me.label5 = New System.Windows.Forms.Label()
            Me.label4 = New System.Windows.Forms.Label()
            Me.label3 = New System.Windows.Forms.Label()
            Me.label2 = New System.Windows.Forms.Label()
            Me.label1 = New System.Windows.Forms.Label()
            Me.textBox2 = New System.Windows.Forms.TextBox()
            Me.comboBox2 = New System.Windows.Forms.ComboBox()
            Me.comboBox1 = New System.Windows.Forms.ComboBox()
            Me.groupBox2 = New System.Windows.Forms.GroupBox()
            Me.checkBox6 = New System.Windows.Forms.CheckBox()
            Me.checkBox5 = New System.Windows.Forms.CheckBox()
            Me.checkBox4 = New System.Windows.Forms.CheckBox()
            Me.checkBox3 = New System.Windows.Forms.CheckBox()
            Me.checkBox2 = New System.Windows.Forms.CheckBox()
            Me.checkBox1 = New System.Windows.Forms.CheckBox()
            Me.button1 = New System.Windows.Forms.Button()
            Me.button2 = New System.Windows.Forms.Button()
            Me.button3 = New System.Windows.Forms.Button()
            Me.label8 = New System.Windows.Forms.Label()
            Me.dateTimePicker1 = New System.Windows.Forms.DateTimePicker()
            Me.label9 = New System.Windows.Forms.Label()
            Me.textBox3 = New System.Windows.Forms.TextBox()
            Me.listView1 = New System.Windows.Forms.ListView()
            Me.timer1 = New System.Windows.Forms.Timer(Me.components)
            Me.listView2 = New System.Windows.Forms.ListView()
            Me.pictureBox1 = New System.Windows.Forms.PictureBox()
            Me.groupBox1.SuspendLayout()
            CType(Me.numericUpDown2, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.numericUpDown1, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.groupBox2.SuspendLayout()
            CType(Me.pictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.SuspendLayout()
            '
            'textBox1
            '
            Me.textBox1.Location = New System.Drawing.Point(122, 34)
            Me.textBox1.Name = "textBox1"
            Me.textBox1.Size = New System.Drawing.Size(132, 20)
            Me.textBox1.TabIndex = 0
            '
            'maskedTextBox1
            '
            Me.maskedTextBox1.Location = New System.Drawing.Point(122, 86)
            Me.maskedTextBox1.Name = "maskedTextBox1"
            Me.maskedTextBox1.Size = New System.Drawing.Size(132, 20)
            Me.maskedTextBox1.TabIndex = 1
            '
            'groupBox1
            '
            Me.groupBox1.Controls.Add(Me.numericUpDown2)
            Me.groupBox1.Controls.Add(Me.numericUpDown1)
            Me.groupBox1.Controls.Add(Me.label7)
            Me.groupBox1.Controls.Add(Me.label6)
            Me.groupBox1.Controls.Add(Me.label5)
            Me.groupBox1.Controls.Add(Me.label4)
            Me.groupBox1.Controls.Add(Me.label3)
            Me.groupBox1.Controls.Add(Me.label2)
            Me.groupBox1.Controls.Add(Me.label1)
            Me.groupBox1.Controls.Add(Me.textBox2)
            Me.groupBox1.Controls.Add(Me.comboBox2)
            Me.groupBox1.Controls.Add(Me.comboBox1)
            Me.groupBox1.Controls.Add(Me.maskedTextBox1)
            Me.groupBox1.Controls.Add(Me.textBox1)
            Me.groupBox1.Location = New System.Drawing.Point(12, 12)
            Me.groupBox1.Name = "groupBox1"
            Me.groupBox1.Size = New System.Drawing.Size(574, 248)
            Me.groupBox1.TabIndex = 2
            Me.groupBox1.TabStop = False
            Me.groupBox1.Text = "Müşteri Bilgileri"
            '
            'numericUpDown2
            '
            Me.numericUpDown2.Location = New System.Drawing.Point(390, 201)
            Me.numericUpDown2.Name = "numericUpDown2"
            Me.numericUpDown2.Size = New System.Drawing.Size(120, 20)
            Me.numericUpDown2.TabIndex = 13
            '
            'numericUpDown1
            '
            Me.numericUpDown1.Location = New System.Drawing.Point(390, 139)
            Me.numericUpDown1.Name = "numericUpDown1"
            Me.numericUpDown1.Size = New System.Drawing.Size(120, 20)
            Me.numericUpDown1.TabIndex = 0
            '
            'label7
            '
            Me.label7.AutoSize = True
            Me.label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
            Me.label7.Location = New System.Drawing.Point(334, 203)
            Me.label7.Name = "label7"
            Me.label7.Size = New System.Drawing.Size(34, 13)
            Me.label7.TabIndex = 12
            Me.label7.Text = "Piece"
            '
            'label6
            '
            Me.label6.AutoSize = True
            Me.label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
            Me.label6.Location = New System.Drawing.Point(334, 139)
            Me.label6.Name = "label6"
            Me.label6.Size = New System.Drawing.Size(34, 13)
            Me.label6.TabIndex = 11
            Me.label6.Text = "Piece"
            '
            'label5
            '
            Me.label5.AutoSize = True
            Me.label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
            Me.label5.Location = New System.Drawing.Point(334, 16)
            Me.label5.Name = "label5"
            Me.label5.Size = New System.Drawing.Size(58, 15)
            Me.label5.TabIndex = 10
            Me.label5.Text = "Address"
            '
            'label4
            '
            Me.label4.AutoSize = True
            Me.label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
            Me.label4.Location = New System.Drawing.Point(19, 205)
            Me.label4.Name = "label4"
            Me.label4.Size = New System.Drawing.Size(99, 15)
            Me.label4.TabIndex = 9
            Me.label4.Text = "Beverage Size"
            '
            'label3
            '
            Me.label3.AutoSize = True
            Me.label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
            Me.label3.Location = New System.Drawing.Point(44, 143)
            Me.label3.Name = "label3"
            Me.label3.Size = New System.Drawing.Size(74, 15)
            Me.label3.TabIndex = 8
            Me.label3.Text = "Pizza Size"
            '
            'label2
            '
            Me.label2.AutoSize = True
            Me.label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
            Me.label2.Location = New System.Drawing.Point(6, 86)
            Me.label2.Name = "label2"
            Me.label2.Size = New System.Drawing.Size(101, 15)
            Me.label2.TabIndex = 7
            Me.label2.Text = "Phone number"
            '
            'label1
            '
            Me.label1.AutoSize = True
            Me.label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
            Me.label1.Location = New System.Drawing.Point(52, 34)
            Me.label1.Name = "label1"
            Me.label1.Size = New System.Drawing.Size(71, 15)
            Me.label1.TabIndex = 6
            Me.label1.Text = "ed master"
            '
            'textBox2
            '
            Me.textBox2.Location = New System.Drawing.Point(337, 34)
            Me.textBox2.Multiline = True
            Me.textBox2.Name = "textBox2"
            Me.textBox2.Size = New System.Drawing.Size(202, 67)
            Me.textBox2.TabIndex = 3
            '
            'comboBox2
            '
            Me.comboBox2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
            Me.comboBox2.FormattingEnabled = True
            Me.comboBox2.Location = New System.Drawing.Point(122, 204)
            Me.comboBox2.Name = "comboBox2"
            Me.comboBox2.Size = New System.Drawing.Size(132, 21)
            Me.comboBox2.TabIndex = 3
            '
            'comboBox1
            '
            Me.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
            Me.comboBox1.FormattingEnabled = True
            Me.comboBox1.Location = New System.Drawing.Point(122, 137)
            Me.comboBox1.Name = "comboBox1"
            Me.comboBox1.Size = New System.Drawing.Size(132, 21)
            Me.comboBox1.TabIndex = 2
            '
            'groupBox2
            '
            Me.groupBox2.Controls.Add(Me.checkBox6)
            Me.groupBox2.Controls.Add(Me.checkBox5)
            Me.groupBox2.Controls.Add(Me.checkBox4)
            Me.groupBox2.Controls.Add(Me.checkBox3)
            Me.groupBox2.Controls.Add(Me.checkBox2)
            Me.groupBox2.Controls.Add(Me.checkBox1)
            Me.groupBox2.Location = New System.Drawing.Point(12, 284)
            Me.groupBox2.Name = "groupBox2"
            Me.groupBox2.Size = New System.Drawing.Size(243, 130)
            Me.groupBox2.TabIndex = 13
            Me.groupBox2.TabStop = False
            Me.groupBox2.Text = "Extras"
            '
            'checkBox6
            '
            Me.checkBox6.AutoSize = True
            Me.checkBox6.Location = New System.Drawing.Point(136, 107)
            Me.checkBox6.Name = "checkBox6"
            Me.checkBox6.Size = New System.Drawing.Size(74, 17)
            Me.checkBox6.TabIndex = 19
            Me.checkBox6.Text = "Vegetable"
            Me.checkBox6.UseVisualStyleBackColor = True
            '
            'checkBox5
            '
            Me.checkBox5.AutoSize = True
            Me.checkBox5.Location = New System.Drawing.Point(136, 67)
            Me.checkBox5.Name = "checkBox5"
            Me.checkBox5.Size = New System.Drawing.Size(62, 17)
            Me.checkBox5.TabIndex = 18
            Me.checkBox5.Text = "Cheese"
            Me.checkBox5.UseVisualStyleBackColor = True
            '
            'checkBox4
            '
            Me.checkBox4.AutoSize = True
            Me.checkBox4.Location = New System.Drawing.Point(136, 33)
            Me.checkBox4.Name = "checkBox4"
            Me.checkBox4.Size = New System.Drawing.Size(62, 17)
            Me.checkBox4.TabIndex = 17
            Me.checkBox4.Text = "Cheese"
            Me.checkBox4.UseVisualStyleBackColor = True
            '
            'checkBox3
            '
            Me.checkBox3.AutoSize = True
            Me.checkBox3.Location = New System.Drawing.Point(9, 107)
            Me.checkBox3.Name = "checkBox3"
            Me.checkBox3.Size = New System.Drawing.Size(75, 17)
            Me.checkBox3.TabIndex = 16
            Me.checkBox3.Text = "Mushroom"
            Me.checkBox3.UseVisualStyleBackColor = True
            '
            'checkBox2
            '
            Me.checkBox2.AutoSize = True
            Me.checkBox2.Location = New System.Drawing.Point(9, 67)
            Me.checkBox2.Name = "checkBox2"
            Me.checkBox2.Size = New System.Drawing.Size(68, 17)
            Me.checkBox2.TabIndex = 15
            Me.checkBox2.Text = "Sausage"
            Me.checkBox2.UseVisualStyleBackColor = True
            '
            'checkBox1
            '
            Me.checkBox1.AutoSize = True
            Me.checkBox1.Location = New System.Drawing.Point(9, 33)
            Me.checkBox1.Name = "checkBox1"
            Me.checkBox1.Size = New System.Drawing.Size(68, 17)
            Me.checkBox1.TabIndex = 14
            Me.checkBox1.Text = "Sausage"
            Me.checkBox1.UseVisualStyleBackColor = True
            '
            'button1
            '
            Me.button1.BackColor = System.Drawing.SystemColors.ControlDark
            Me.button1.Location = New System.Drawing.Point(281, 299)
            Me.button1.Name = "button1"
            Me.button1.Size = New System.Drawing.Size(118, 35)
            Me.button1.TabIndex = 14
            Me.button1.Text = "Receive Order"
            Me.button1.UseVisualStyleBackColor = False
            '
            'button2
            '
            Me.button2.BackColor = System.Drawing.SystemColors.ControlDark
            Me.button2.Location = New System.Drawing.Point(281, 373)
            Me.button2.Name = "button2"
            Me.button2.Size = New System.Drawing.Size(118, 35)
            Me.button2.TabIndex = 15
            Me.button2.Text = "Clean"
            Me.button2.UseVisualStyleBackColor = False
            '
            'button3
            '
            Me.button3.BackColor = System.Drawing.SystemColors.ControlDark
            Me.button3.Location = New System.Drawing.Point(448, 299)
            Me.button3.Name = "button3"
            Me.button3.Size = New System.Drawing.Size(125, 109)
            Me.button3.TabIndex = 16
            Me.button3.Text = "All Orders"
            Me.button3.UseVisualStyleBackColor = False
            '
            'label8
            '
            Me.label8.AutoSize = True
            Me.label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
            Me.label8.Location = New System.Drawing.Point(825, 46)
            Me.label8.Name = "label8"
            Me.label8.Size = New System.Drawing.Size(65, 15)
            Me.label8.TabIndex = 18
            Me.label8.Text = "Order date"
            '
            'dateTimePicker1
            '
            Me.dateTimePicker1.Location = New System.Drawing.Point(828, 93)
            Me.dateTimePicker1.Name = "dateTimePicker1"
            Me.dateTimePicker1.Size = New System.Drawing.Size(200, 20)
            Me.dateTimePicker1.TabIndex = 19
            '
            'label9
            '
            Me.label9.AutoSize = True
            Me.label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
            Me.label9.Location = New System.Drawing.Point(825, 155)
            Me.label9.Name = "label9"
            Me.label9.Size = New System.Drawing.Size(69, 15)
            Me.label9.TabIndex = 20
            Me.label9.Text = "Order Time"
            '
            'textBox3
            '
            Me.textBox3.Location = New System.Drawing.Point(828, 189)
            Me.textBox3.Name = "textBox3"
            Me.textBox3.ReadOnly = True
            Me.textBox3.Size = New System.Drawing.Size(52, 20)
            Me.textBox3.TabIndex = 21
            '
            'listView1
            '
            Me.listView1.FullRowSelect = True
            Me.listView1.HideSelection = False
            Me.listView1.Location = New System.Drawing.Point(12, 434)
            Me.listView1.Name = "listView1"
            Me.listView1.Size = New System.Drawing.Size(1029, 97)
            Me.listView1.TabIndex = 22
            Me.listView1.UseCompatibleStateImageBehavior = False
            '
            'listView2
            '
            Me.listView2.FullRowSelect = True
            Me.listView2.HideSelection = False
            Me.listView2.Location = New System.Drawing.Point(12, 434)
            Me.listView2.Name = "listView2"
            Me.listView2.Size = New System.Drawing.Size(1029, 97)
            Me.listView2.TabIndex = 23
            Me.listView2.UseCompatibleStateImageBehavior = False
            '
            'pictureBox1
            '
            Me.pictureBox1.Image = CType(resources.GetObject("pictureBox1.Image"), System.Drawing.Image)
            Me.pictureBox1.Location = New System.Drawing.Point(618, 12)
            Me.pictureBox1.Name = "pictureBox1"
            Me.pictureBox1.Size = New System.Drawing.Size(164, 396)
            Me.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
            Me.pictureBox1.TabIndex = 24
            Me.pictureBox1.TabStop = False
            '
            'AnaSayfa
            '
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.ClientSize = New System.Drawing.Size(1053, 562)
            Me.Controls.Add(Me.pictureBox1)
            Me.Controls.Add(Me.listView2)
            Me.Controls.Add(Me.listView1)
            Me.Controls.Add(Me.textBox3)
            Me.Controls.Add(Me.label9)
            Me.Controls.Add(Me.dateTimePicker1)
            Me.Controls.Add(Me.label8)
            Me.Controls.Add(Me.button3)
            Me.Controls.Add(Me.button2)
            Me.Controls.Add(Me.button1)
            Me.Controls.Add(Me.groupBox2)
            Me.Controls.Add(Me.groupBox1)
            Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
            Me.Name = "AnaSayfa"
            Me.Text = "Pizza Order Program 7"
            Me.groupBox1.ResumeLayout(False)
            Me.groupBox1.PerformLayout()
            CType(Me.numericUpDown2, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.numericUpDown1, System.ComponentModel.ISupportInitialize).EndInit()
            Me.groupBox2.ResumeLayout(False)
            Me.groupBox2.PerformLayout()
            CType(Me.pictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
            Me.ResumeLayout(False)
            Me.PerformLayout()

        End Sub

#End Region

        Private textBox1 As Windows.Forms.TextBox
        Private maskedTextBox1 As Windows.Forms.MaskedTextBox
        Private groupBox1 As Windows.Forms.GroupBox
        Private comboBox2 As Windows.Forms.ComboBox
        Private comboBox1 As Windows.Forms.ComboBox
        Private numericUpDown2 As Windows.Forms.NumericUpDown
        Private numericUpDown1 As Windows.Forms.NumericUpDown
        Private label7 As Windows.Forms.Label
        Private label6 As Windows.Forms.Label
        Private label5 As Windows.Forms.Label
        Private label4 As Windows.Forms.Label
        Private label3 As Windows.Forms.Label
        Private label2 As Windows.Forms.Label
        Private label1 As Windows.Forms.Label
        Private textBox2 As Windows.Forms.TextBox
        Private groupBox2 As Windows.Forms.GroupBox
        Private checkBox6 As Windows.Forms.CheckBox
        Private checkBox5 As Windows.Forms.CheckBox
        Private checkBox4 As Windows.Forms.CheckBox
        Private checkBox3 As Windows.Forms.CheckBox
        Private checkBox2 As Windows.Forms.CheckBox
        Private checkBox1 As Windows.Forms.CheckBox
        Private button1 As Windows.Forms.Button
        Private button2 As Windows.Forms.Button
        Private button3 As Windows.Forms.Button
        Private label8 As Windows.Forms.Label
        Private dateTimePicker1 As Windows.Forms.DateTimePicker
        Private label9 As Windows.Forms.Label
        Private textBox3 As Windows.Forms.TextBox
        Private listView1 As Windows.Forms.ListView
        Private timer1 As Windows.Forms.Timer
        Private listView2 As Windows.Forms.ListView
        Private pictureBox1 As Windows.Forms.PictureBox
    End Class
End Namespace
