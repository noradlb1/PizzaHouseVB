Imports System

Namespace Pizza
    Partial Class Form1
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
            Dim resources As ComponentModel.ComponentResourceManager = New ComponentModel.ComponentResourceManager(GetType(Form1))
            label1 = New System.Windows.Forms.Label()
            textBox1 = New System.Windows.Forms.TextBox()
            textBox2 = New System.Windows.Forms.TextBox()
            label2 = New System.Windows.Forms.Label()
            textBox3 = New System.Windows.Forms.TextBox()
            label3 = New System.Windows.Forms.Label()
            label4 = New System.Windows.Forms.Label()
            label5 = New System.Windows.Forms.Label()
            comboBox1 = New System.Windows.Forms.ComboBox()
            comboBox2 = New System.Windows.Forms.ComboBox()
            groupBox1 = New System.Windows.Forms.GroupBox()
            checkBox4 = New System.Windows.Forms.CheckBox()
            checkBox3 = New System.Windows.Forms.CheckBox()
            checkBox2 = New System.Windows.Forms.CheckBox()
            checkBox1 = New System.Windows.Forms.CheckBox()
            button1 = New System.Windows.Forms.Button()
            button2 = New System.Windows.Forms.Button()
            label6 = New System.Windows.Forms.Label()
            label7 = New System.Windows.Forms.Label()
            label8 = New System.Windows.Forms.Label()
            label9 = New System.Windows.Forms.Label()
            label10 = New System.Windows.Forms.Label()
            groupBox2 = New System.Windows.Forms.GroupBox()
            listBox6 = New System.Windows.Forms.ListBox()
            listBox5 = New System.Windows.Forms.ListBox()
            listBox4 = New System.Windows.Forms.ListBox()
            listBox3 = New System.Windows.Forms.ListBox()
            listBox2 = New System.Windows.Forms.ListBox()
            listBox1 = New System.Windows.Forms.ListBox()
            label11 = New System.Windows.Forms.Label()
            pictureBox1 = New System.Windows.Forms.PictureBox()
            groupBox3 = New System.Windows.Forms.GroupBox()
            label15 = New System.Windows.Forms.Label()
            label14 = New System.Windows.Forms.Label()
            label13 = New System.Windows.Forms.Label()
            label12 = New System.Windows.Forms.Label()
            groupBox1.SuspendLayout()
            groupBox2.SuspendLayout()
            CType(pictureBox1, ComponentModel.ISupportInitialize).BeginInit()
            groupBox3.SuspendLayout()
            SuspendLayout()
            ' 
            ' label1
            ' 
            label1.AutoSize = True
            label1.Font = New Drawing.Font("Microsoft Sans Serif", 13.0F, Drawing.FontStyle.Regular, Drawing.GraphicsUnit.Point, 0)
            label1.Location = New Drawing.Point(9, 27)
            label1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
            label1.Name = "label1"
            label1.Size = New Drawing.Size(134, 22)
            label1.TabIndex = 0
            label1.Text = "Name Surname"
            ' 
            ' textBox1
            ' 
            textBox1.Font = New Drawing.Font("Microsoft Sans Serif", 13.0F, Drawing.FontStyle.Regular, Drawing.GraphicsUnit.Point, 0)
            textBox1.Location = New Drawing.Point(138, 24)
            textBox1.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
            textBox1.Name = "textBox1"
            textBox1.Size = New Drawing.Size(144, 27)
            textBox1.TabIndex = 1
            ' 
            ' textBox2
            ' 
            textBox2.Font = New Drawing.Font("Microsoft Sans Serif", 13.0F, Drawing.FontStyle.Regular, Drawing.GraphicsUnit.Point, 0)
            textBox2.Location = New Drawing.Point(138, 64)
            textBox2.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
            textBox2.Name = "textBox2"
            textBox2.Size = New Drawing.Size(144, 27)
            textBox2.TabIndex = 3
            ' 
            ' label2
            ' 
            label2.AutoSize = True
            label2.Font = New Drawing.Font("Microsoft Sans Serif", 13.0F, Drawing.FontStyle.Regular, Drawing.GraphicsUnit.Point, 0)
            label2.Location = New Drawing.Point(9, 67)
            label2.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
            label2.Name = "label2"
            label2.Size = New Drawing.Size(73, 22)
            label2.TabIndex = 2
            label2.Text = "Number"
            ' 
            ' textBox3
            ' 
            textBox3.Font = New Drawing.Font("Microsoft Sans Serif", 13.0F, Drawing.FontStyle.Regular, Drawing.GraphicsUnit.Point, 0)
            textBox3.Location = New Drawing.Point(138, 103)
            textBox3.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
            textBox3.Multiline = True
            textBox3.Name = "textBox3"
            textBox3.Size = New Drawing.Size(144, 69)
            textBox3.TabIndex = 5
            ' 
            ' label3
            ' 
            label3.AutoSize = True
            label3.Font = New Drawing.Font("Microsoft Sans Serif", 13.0F, Drawing.FontStyle.Regular, Drawing.GraphicsUnit.Point, 0)
            label3.Location = New Drawing.Point(9, 106)
            label3.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
            label3.Name = "label3"
            label3.Size = New Drawing.Size(66, 22)
            label3.TabIndex = 4
            label3.Text = "Adress"
            ' 
            ' label4
            ' 
            label4.AutoSize = True
            label4.Font = New Drawing.Font("Microsoft Sans Serif", 13.0F, Drawing.FontStyle.Regular, Drawing.GraphicsUnit.Point, 0)
            label4.Location = New Drawing.Point(9, 191)
            label4.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
            label4.Name = "label4"
            label4.Size = New Drawing.Size(91, 22)
            label4.TabIndex = 6
            label4.Text = "Pizza Size"
            ' 
            ' label5
            ' 
            label5.AutoSize = True
            label5.Font = New Drawing.Font("Microsoft Sans Serif", 13.0F, Drawing.FontStyle.Regular, Drawing.GraphicsUnit.Point, 0)
            label5.Location = New Drawing.Point(9, 245)
            label5.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
            label5.Name = "label5"
            label5.Size = New Drawing.Size(52, 22)
            label5.TabIndex = 7
            label5.Text = "Drink"
            ' 
            ' comboBox1
            ' 
            comboBox1.FormattingEnabled = True
            comboBox1.Items.AddRange(New Object() {"Small ", "Medium", "Large"})
            comboBox1.Location = New Drawing.Point(138, 191)
            comboBox1.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
            comboBox1.Name = "comboBox1"
            comboBox1.Size = New Drawing.Size(144, 21)
            comboBox1.TabIndex = 8
            ' 
            ' comboBox2
            ' 
            comboBox2.FormattingEnabled = True
            comboBox2.Items.AddRange(New Object() {"Water", "Coke", "Fanta"})
            comboBox2.Location = New Drawing.Point(138, 245)
            comboBox2.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
            comboBox2.Name = "comboBox2"
            comboBox2.Size = New Drawing.Size(144, 21)
            comboBox2.TabIndex = 9
            ' 
            ' groupBox1
            ' 
            groupBox1.BackColor = Drawing.SystemColors.ButtonHighlight
            groupBox1.Controls.Add(checkBox4)
            groupBox1.Controls.Add(checkBox3)
            groupBox1.Controls.Add(checkBox2)
            groupBox1.Controls.Add(checkBox1)
            groupBox1.Font = New Drawing.Font("Microsoft Sans Serif", 15.0F, Drawing.FontStyle.Regular, Drawing.GraphicsUnit.Point, 0)
            groupBox1.Location = New Drawing.Point(323, 64)
            groupBox1.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
            groupBox1.Name = "groupBox1"
            groupBox1.Padding = New System.Windows.Forms.Padding(2, 2, 2, 2)
            groupBox1.Size = New Drawing.Size(173, 174)
            groupBox1.TabIndex = 10
            groupBox1.TabStop = False
            groupBox1.Text = "Toppings"
            ' 
            ' checkBox4
            ' 
            checkBox4.AutoSize = True
            checkBox4.Location = New Drawing.Point(23, 135)
            checkBox4.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
            checkBox4.Name = "checkBox4"
            checkBox4.Size = New Drawing.Size(76, 29)
            checkBox4.TabIndex = 6
            checkBox4.Text = "Olive"
            checkBox4.UseVisualStyleBackColor = True
            AddHandler checkBox4.CheckedChanged, New EventHandler(AddressOf checkBox4_CheckedChanged)
            ' 
            ' checkBox3
            ' 
            checkBox3.AutoSize = True
            checkBox3.Location = New Drawing.Point(23, 103)
            checkBox3.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
            checkBox3.Name = "checkBox3"
            checkBox3.Size = New Drawing.Size(124, 29)
            checkBox3.TabIndex = 3
            checkBox3.Text = "Mushroom"
            checkBox3.UseVisualStyleBackColor = True
            AddHandler checkBox3.CheckedChanged, New EventHandler(AddressOf checkBox3_CheckedChanged)
            ' 
            ' checkBox2
            ' 
            checkBox2.AutoSize = True
            checkBox2.Location = New Drawing.Point(23, 68)
            checkBox2.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
            checkBox2.Name = "checkBox2"
            checkBox2.Size = New Drawing.Size(100, 29)
            checkBox2.TabIndex = 1
            checkBox2.Text = "Cheese"
            checkBox2.UseVisualStyleBackColor = True
            AddHandler checkBox2.CheckedChanged, New EventHandler(AddressOf checkBox2_CheckedChanged)
            ' 
            ' checkBox1
            ' 
            checkBox1.AutoSize = True
            checkBox1.Location = New Drawing.Point(23, 37)
            checkBox1.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
            checkBox1.Name = "checkBox1"
            checkBox1.Size = New Drawing.Size(120, 29)
            checkBox1.TabIndex = 0
            checkBox1.Text = "Pepporoni"
            checkBox1.UseVisualStyleBackColor = True
            AddHandler checkBox1.CheckedChanged, New EventHandler(AddressOf checkBox1_CheckedChanged)
            ' 
            ' button1
            ' 
            button1.Font = New Drawing.Font("Microsoft Sans Serif", 20.0F, Drawing.FontStyle.Regular, Drawing.GraphicsUnit.Point, 0)
            button1.Location = New Drawing.Point(533, 30)
            button1.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
            button1.Name = "button1"
            button1.Size = New Drawing.Size(162, 102)
            button1.TabIndex = 11
            button1.Text = "Order"
            button1.UseVisualStyleBackColor = True
            AddHandler button1.Click, New EventHandler(AddressOf button1_Click)
            ' 
            ' button2
            ' 
            button2.Font = New Drawing.Font("Microsoft Sans Serif", 20.0F, Drawing.FontStyle.Regular, Drawing.GraphicsUnit.Point, 0)
            button2.Location = New Drawing.Point(533, 159)
            button2.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
            button2.Name = "button2"
            button2.Size = New Drawing.Size(162, 102)
            button2.TabIndex = 12
            button2.Text = "Clear"
            button2.UseVisualStyleBackColor = True
            ' 
            ' label6
            ' 
            label6.AutoSize = True
            label6.Font = New Drawing.Font("Microsoft Sans Serif", 13.0F, Drawing.FontStyle.Regular, Drawing.GraphicsUnit.Point, 0)
            label6.Location = New Drawing.Point(567, 23)
            label6.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
            label6.Name = "label6"
            label6.Size = New Drawing.Size(52, 22)
            label6.TabIndex = 17
            label6.Text = "Drink"
            ' 
            ' label7
            ' 
            label7.AutoSize = True
            label7.Font = New Drawing.Font("Microsoft Sans Serif", 13.0F, Drawing.FontStyle.Regular, Drawing.GraphicsUnit.Point, 0)
            label7.Location = New Drawing.Point(416, 23)
            label7.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
            label7.Name = "label7"
            label7.Size = New Drawing.Size(91, 22)
            label7.TabIndex = 16
            label7.Text = "Pizza Size"
            ' 
            ' label8
            ' 
            label8.AutoSize = True
            label8.Font = New Drawing.Font("Microsoft Sans Serif", 13.0F, Drawing.FontStyle.Regular, Drawing.GraphicsUnit.Point, 0)
            label8.Location = New Drawing.Point(297, 26)
            label8.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
            label8.Name = "label8"
            label8.Size = New Drawing.Size(66, 22)
            label8.TabIndex = 15
            label8.Text = "Adress"
            ' 
            ' label9
            ' 
            label9.AutoSize = True
            label9.Font = New Drawing.Font("Microsoft Sans Serif", 13.0F, Drawing.FontStyle.Regular, Drawing.GraphicsUnit.Point, 0)
            label9.Location = New Drawing.Point(158, 26)
            label9.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
            label9.Name = "label9"
            label9.Size = New Drawing.Size(73, 22)
            label9.TabIndex = 14
            label9.Text = "Number"
            ' 
            ' label10
            ' 
            label10.AutoSize = True
            label10.Font = New Drawing.Font("Microsoft Sans Serif", 13.0F, Drawing.FontStyle.Regular, Drawing.GraphicsUnit.Point, 0)
            label10.Location = New Drawing.Point(4, 26)
            label10.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
            label10.Name = "label10"
            label10.Size = New Drawing.Size(134, 22)
            label10.TabIndex = 13
            label10.Text = "Name Surname"
            ' 
            ' groupBox2
            ' 
            groupBox2.BackColor = Drawing.SystemColors.ControlDark
            groupBox2.Controls.Add(listBox6)
            groupBox2.Controls.Add(listBox5)
            groupBox2.Controls.Add(listBox4)
            groupBox2.Controls.Add(listBox3)
            groupBox2.Controls.Add(listBox2)
            groupBox2.Controls.Add(listBox1)
            groupBox2.Controls.Add(label11)
            groupBox2.Controls.Add(label10)
            groupBox2.Controls.Add(label6)
            groupBox2.Controls.Add(label9)
            groupBox2.Controls.Add(label7)
            groupBox2.Controls.Add(label8)
            groupBox2.Font = New Drawing.Font("Microsoft Sans Serif", 13.0F, Drawing.FontStyle.Regular, Drawing.GraphicsUnit.Point, 0)
            groupBox2.Location = New Drawing.Point(13, 288)
            groupBox2.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
            groupBox2.Name = "groupBox2"
            groupBox2.Padding = New System.Windows.Forms.Padding(2, 2, 2, 2)
            groupBox2.Size = New Drawing.Size(962, 285)
            groupBox2.TabIndex = 18
            groupBox2.TabStop = False
            groupBox2.Text = "Orders"
            ' 
            ' listBox6
            ' 
            listBox6.FormattingEnabled = True
            listBox6.ItemHeight = 20
            listBox6.Location = New Drawing.Point(664, 58)
            listBox6.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
            listBox6.Name = "listBox6"
            listBox6.Size = New Drawing.Size(275, 204)
            listBox6.TabIndex = 24
            ' 
            ' listBox5
            ' 
            listBox5.FormattingEnabled = True
            listBox5.ItemHeight = 20
            listBox5.Location = New Drawing.Point(536, 58)
            listBox5.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
            listBox5.Name = "listBox5"
            listBox5.Size = New Drawing.Size(114, 204)
            listBox5.TabIndex = 23
            ' 
            ' listBox4
            ' 
            listBox4.FormattingEnabled = True
            listBox4.ItemHeight = 20
            listBox4.Location = New Drawing.Point(404, 58)
            listBox4.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
            listBox4.Name = "listBox4"
            listBox4.Size = New Drawing.Size(114, 204)
            listBox4.TabIndex = 22
            ' 
            ' listBox3
            ' 
            listBox3.FormattingEnabled = True
            listBox3.ItemHeight = 20
            listBox3.Location = New Drawing.Point(272, 58)
            listBox3.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
            listBox3.Name = "listBox3"
            listBox3.Size = New Drawing.Size(114, 204)
            listBox3.TabIndex = 21
            ' 
            ' listBox2
            ' 
            listBox2.FormattingEnabled = True
            listBox2.ItemHeight = 20
            listBox2.Location = New Drawing.Point(139, 58)
            listBox2.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
            listBox2.Name = "listBox2"
            listBox2.Size = New Drawing.Size(114, 204)
            listBox2.TabIndex = 20
            ' 
            ' listBox1
            ' 
            listBox1.FormattingEnabled = True
            listBox1.ItemHeight = 20
            listBox1.Location = New Drawing.Point(8, 58)
            listBox1.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
            listBox1.Name = "listBox1"
            listBox1.Size = New Drawing.Size(114, 204)
            listBox1.TabIndex = 19
            ' 
            ' label11
            ' 
            label11.AutoSize = True
            label11.Font = New Drawing.Font("Microsoft Sans Serif", 13.0F, Drawing.FontStyle.Regular, Drawing.GraphicsUnit.Point, 0)
            label11.Location = New Drawing.Point(759, 23)
            label11.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
            label11.Name = "label11"
            label11.Size = New Drawing.Size(85, 22)
            label11.TabIndex = 18
            label11.Text = "Toppings"
            AddHandler label11.Click, New EventHandler(AddressOf label11_Click)
            ' 
            ' pictureBox1
            ' 
            pictureBox1.Image = CType(resources.GetObject("pictureBox1.Image"), Drawing.Image)
            pictureBox1.Location = New Drawing.Point(717, 30)
            pictureBox1.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
            pictureBox1.Name = "pictureBox1"
            pictureBox1.Size = New Drawing.Size(258, 232)
            pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
            pictureBox1.TabIndex = 19
            pictureBox1.TabStop = False
            ' 
            ' groupBox3
            ' 
            groupBox3.BackColor = Drawing.SystemColors.ButtonHighlight
            groupBox3.Controls.Add(label15)
            groupBox3.Controls.Add(label14)
            groupBox3.Controls.Add(label13)
            groupBox3.Controls.Add(label12)
            groupBox3.Font = New Drawing.Font("Microsoft Sans Serif", 15.0F, Drawing.FontStyle.Regular, Drawing.GraphicsUnit.Point, 0)
            groupBox3.Location = New Drawing.Point(1014, 24)
            groupBox3.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
            groupBox3.Name = "groupBox3"
            groupBox3.Padding = New System.Windows.Forms.Padding(2, 2, 2, 2)
            groupBox3.Size = New Drawing.Size(173, 240)
            groupBox3.TabIndex = 11
            groupBox3.TabStop = False
            groupBox3.Text = "Toppings"
            groupBox3.Visible = False
            ' 
            ' label15
            ' 
            label15.AutoSize = True
            label15.Location = New Drawing.Point(36, 180)
            label15.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
            label15.Name = "label15"
            label15.Size = New Drawing.Size(0, 25)
            label15.TabIndex = 3
            ' 
            ' label14
            ' 
            label14.AutoSize = True
            label14.Location = New Drawing.Point(36, 137)
            label14.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
            label14.Name = "label14"
            label14.Size = New Drawing.Size(0, 25)
            label14.TabIndex = 2
            ' 
            ' label13
            ' 
            label13.AutoSize = True
            label13.Location = New Drawing.Point(36, 97)
            label13.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
            label13.Name = "label13"
            label13.Size = New Drawing.Size(0, 25)
            label13.TabIndex = 1
            ' 
            ' label12
            ' 
            label12.AutoSize = True
            label12.Location = New Drawing.Point(36, 47)
            label12.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
            label12.Name = "label12"
            label12.Size = New Drawing.Size(0, 25)
            label12.TabIndex = 0
            ' 
            ' Form1
            ' 
            AutoScaleDimensions = New Drawing.SizeF(6.0F, 13.0F)
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            BackColor = Drawing.Color.Red
            ClientSize = New Drawing.Size(1246, 639)
            Controls.Add(groupBox3)
            Controls.Add(pictureBox1)
            Controls.Add(groupBox2)
            Controls.Add(button2)
            Controls.Add(button1)
            Controls.Add(groupBox1)
            Controls.Add(comboBox2)
            Controls.Add(comboBox1)
            Controls.Add(label5)
            Controls.Add(label4)
            Controls.Add(textBox3)
            Controls.Add(label3)
            Controls.Add(textBox2)
            Controls.Add(label2)
            Controls.Add(textBox1)
            Controls.Add(label1)
            Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
            Name = "Form1"
            Text = "Pizza Order"
            groupBox1.ResumeLayout(False)
            groupBox1.PerformLayout()
            groupBox2.ResumeLayout(False)
            groupBox2.PerformLayout()
            CType(pictureBox1, ComponentModel.ISupportInitialize).EndInit()
            groupBox3.ResumeLayout(False)
            groupBox3.PerformLayout()
            ResumeLayout(False)
            PerformLayout()

        End Sub

#End Region

        Private label1 As System.Windows.Forms.Label
        Private textBox1 As System.Windows.Forms.TextBox
        Private textBox2 As System.Windows.Forms.TextBox
        Private label2 As System.Windows.Forms.Label
        Private textBox3 As System.Windows.Forms.TextBox
        Private label3 As System.Windows.Forms.Label
        Private label4 As System.Windows.Forms.Label
        Private label5 As System.Windows.Forms.Label
        Private comboBox1 As System.Windows.Forms.ComboBox
        Private comboBox2 As System.Windows.Forms.ComboBox
        Private groupBox1 As System.Windows.Forms.GroupBox
        Private checkBox1 As System.Windows.Forms.CheckBox
        Private checkBox3 As System.Windows.Forms.CheckBox
        Private checkBox2 As System.Windows.Forms.CheckBox
        Private button1 As System.Windows.Forms.Button
        Private button2 As System.Windows.Forms.Button
        Private label6 As System.Windows.Forms.Label
        Private label7 As System.Windows.Forms.Label
        Private label8 As System.Windows.Forms.Label
        Private label9 As System.Windows.Forms.Label
        Private label10 As System.Windows.Forms.Label
        Private groupBox2 As System.Windows.Forms.GroupBox
        Private label11 As System.Windows.Forms.Label
        Private listBox1 As System.Windows.Forms.ListBox
        Private listBox2 As System.Windows.Forms.ListBox
        Private listBox3 As System.Windows.Forms.ListBox
        Private listBox4 As System.Windows.Forms.ListBox
        Private listBox5 As System.Windows.Forms.ListBox
        Private listBox6 As System.Windows.Forms.ListBox
        Private pictureBox1 As System.Windows.Forms.PictureBox
        Private groupBox3 As System.Windows.Forms.GroupBox
        Private checkBox4 As System.Windows.Forms.CheckBox
        Private label15 As System.Windows.Forms.Label
        Private label14 As System.Windows.Forms.Label
        Private label13 As System.Windows.Forms.Label
        Private label12 As System.Windows.Forms.Label
    End Class
End Namespace
