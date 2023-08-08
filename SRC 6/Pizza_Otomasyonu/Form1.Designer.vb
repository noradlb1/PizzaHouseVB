Imports System

Namespace Pizza_Otomasyonu
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
            label1 = New Windows.Forms.Label()
            label2 = New Windows.Forms.Label()
            cmbEbat = New Windows.Forms.ComboBox()
            label3 = New Windows.Forms.Label()
            listPizzalar = New Windows.Forms.ListBox()
            rdbInceKenar = New Windows.Forms.RadioButton()
            rdbKalinKenar = New Windows.Forms.RadioButton()
            groupBox1 = New Windows.Forms.GroupBox()
            checkBox10 = New Windows.Forms.CheckBox()
            checkBox5 = New Windows.Forms.CheckBox()
            checkBox9 = New Windows.Forms.CheckBox()
            checkBox4 = New Windows.Forms.CheckBox()
            checkBox8 = New Windows.Forms.CheckBox()
            checkBox3 = New Windows.Forms.CheckBox()
            checkBox7 = New Windows.Forms.CheckBox()
            checkBox6 = New Windows.Forms.CheckBox()
            checkBox2 = New Windows.Forms.CheckBox()
            checkBox1 = New Windows.Forms.CheckBox()
            label4 = New Windows.Forms.Label()
            btnHesapla = New Windows.Forms.Button()
            btnEkle = New Windows.Forms.Button()
            label5 = New Windows.Forms.Label()
            groupBox2 = New Windows.Forms.GroupBox()
            lblTutar = New Windows.Forms.Label()
            nudAdet = New Windows.Forms.NumericUpDown()
            label8 = New Windows.Forms.Label()
            btnOnayla = New Windows.Forms.Button()
            lblToplam = New Windows.Forms.Label()
            label6 = New Windows.Forms.Label()
            listSepet = New Windows.Forms.ListBox()
            groupBox1.SuspendLayout()
            groupBox2.SuspendLayout()
            CType(nudAdet, ComponentModel.ISupportInitialize).BeginInit()
            SuspendLayout()
            ' 
            ' label1
            ' 
            label1.BackColor = Drawing.Color.Tomato
            label1.Dock = Windows.Forms.DockStyle.Top
            label1.Font = New Drawing.Font("Microsoft Sans Serif", 36.0F, Drawing.FontStyle.Bold, Drawing.GraphicsUnit.Point, 162)
            label1.ForeColor = Drawing.SystemColors.ButtonHighlight
            label1.Location = New Drawing.Point(0, 0)
            label1.Name = "label1"
            label1.Size = New Drawing.Size(1028, 55)
            label1.TabIndex = 0
            label1.Text = "PİZZA OTOMASYONU"
            label1.TextAlign = Drawing.ContentAlignment.MiddleCenter
            ' 
            ' label2
            ' 
            label2.AutoSize = True
            label2.Font = New Drawing.Font("Microsoft Sans Serif", 12.0F, Drawing.FontStyle.Bold, Drawing.GraphicsUnit.Point, 162)
            label2.Location = New Drawing.Point(58, 48)
            label2.Name = "label2"
            label2.Size = New Drawing.Size(95, 20)
            label2.TabIndex = 1
            label2.Text = "EBATLAR:"
            ' 
            ' cmbEbat
            ' 
            cmbEbat.BackColor = Drawing.SystemColors.InactiveBorder
            cmbEbat.DropDownStyle = Windows.Forms.ComboBoxStyle.DropDownList
            cmbEbat.Font = New Drawing.Font("Microsoft Sans Serif", 12.0F, Drawing.FontStyle.Bold, Drawing.GraphicsUnit.Point, 162)
            cmbEbat.FormattingEnabled = True
            cmbEbat.Location = New Drawing.Point(159, 45)
            cmbEbat.Name = "cmbEbat"
            cmbEbat.Size = New Drawing.Size(304, 28)
            cmbEbat.TabIndex = 2
            ' 
            ' label3
            ' 
            label3.AutoSize = True
            label3.Font = New Drawing.Font("Microsoft Sans Serif", 12.0F, Drawing.FontStyle.Bold, Drawing.GraphicsUnit.Point, 162)
            label3.Location = New Drawing.Point(58, 154)
            label3.Name = "label3"
            label3.Size = New Drawing.Size(100, 20)
            label3.TabIndex = 1
            label3.Text = "PİZZALAR:"
            ' 
            ' listPizzalar
            ' 
            listPizzalar.BackColor = Drawing.SystemColors.InactiveBorder
            listPizzalar.Font = New Drawing.Font("Microsoft Sans Serif", 12.0F, Drawing.FontStyle.Bold, Drawing.GraphicsUnit.Point, 162)
            listPizzalar.FormattingEnabled = True
            listPizzalar.ItemHeight = 20
            listPizzalar.Location = New Drawing.Point(159, 154)
            listPizzalar.Name = "listPizzalar"
            listPizzalar.Size = New Drawing.Size(303, 204)
            listPizzalar.TabIndex = 3
            ' 
            ' rdbInceKenar
            ' 
            rdbInceKenar.AutoSize = True
            rdbInceKenar.Font = New Drawing.Font("Microsoft Sans Serif", 12.0F, Drawing.FontStyle.Bold, Drawing.GraphicsUnit.Point, 162)
            rdbInceKenar.Location = New Drawing.Point(159, 384)
            rdbInceKenar.Name = "rdbInceKenar"
            rdbInceKenar.Size = New Drawing.Size(134, 24)
            rdbInceKenar.TabIndex = 4
            rdbInceKenar.TabStop = True
            rdbInceKenar.Text = "İNCE KENAR"
            rdbInceKenar.UseVisualStyleBackColor = True
            ' 
            ' rdbKalinKenar
            ' 
            rdbKalinKenar.AutoSize = True
            rdbKalinKenar.Font = New Drawing.Font("Microsoft Sans Serif", 12.0F, Drawing.FontStyle.Bold, Drawing.GraphicsUnit.Point, 162)
            rdbKalinKenar.Location = New Drawing.Point(317, 384)
            rdbKalinKenar.Name = "rdbKalinKenar"
            rdbKalinKenar.Size = New Drawing.Size(143, 24)
            rdbKalinKenar.TabIndex = 4
            rdbKalinKenar.TabStop = True
            rdbKalinKenar.Text = "KALIN KENAR"
            rdbKalinKenar.UseVisualStyleBackColor = True
            ' 
            ' groupBox1
            ' 
            groupBox1.Controls.Add(checkBox10)
            groupBox1.Controls.Add(checkBox5)
            groupBox1.Controls.Add(checkBox9)
            groupBox1.Controls.Add(checkBox4)
            groupBox1.Controls.Add(checkBox8)
            groupBox1.Controls.Add(checkBox3)
            groupBox1.Controls.Add(checkBox7)
            groupBox1.Controls.Add(checkBox6)
            groupBox1.Controls.Add(checkBox2)
            groupBox1.Controls.Add(checkBox1)
            groupBox1.Font = New Drawing.Font("Microsoft Sans Serif", 12.0F, Drawing.FontStyle.Bold, Drawing.GraphicsUnit.Point, 162)
            groupBox1.Location = New Drawing.Point(151, 428)
            groupBox1.Name = "groupBox1"
            groupBox1.Size = New Drawing.Size(312, 195)
            groupBox1.TabIndex = 5
            groupBox1.TabStop = False
            groupBox1.Text = "MALZEMELER"
            ' 
            ' checkBox10
            ' 
            checkBox10.AutoSize = True
            checkBox10.Location = New Drawing.Point(171, 155)
            checkBox10.Name = "checkBox10"
            checkBox10.Size = New Drawing.Size(94, 24)
            checkBox10.TabIndex = 2
            checkBox10.Text = "PEYNİR"
            checkBox10.UseVisualStyleBackColor = True
            ' 
            ' checkBox5
            ' 
            checkBox5.AutoSize = True
            checkBox5.Location = New Drawing.Point(11, 155)
            checkBox5.Name = "checkBox5"
            checkBox5.Size = New Drawing.Size(91, 24)
            checkBox5.TabIndex = 2
            checkBox5.Text = "ZEYTİN"
            checkBox5.UseVisualStyleBackColor = True
            ' 
            ' checkBox9
            ' 
            checkBox9.AutoSize = True
            checkBox9.Location = New Drawing.Point(171, 125)
            checkBox9.Name = "checkBox9"
            checkBox9.Size = New Drawing.Size(128, 24)
            checkBox9.TabIndex = 2
            checkBox9.Text = "TON BALIĞI"
            checkBox9.UseVisualStyleBackColor = True
            ' 
            ' checkBox4
            ' 
            checkBox4.AutoSize = True
            checkBox4.Location = New Drawing.Point(11, 125)
            checkBox4.Name = "checkBox4"
            checkBox4.Size = New Drawing.Size(100, 24)
            checkBox4.TabIndex = 2
            checkBox4.Text = "ANÇUEZ"
            checkBox4.UseVisualStyleBackColor = True
            ' 
            ' checkBox8
            ' 
            checkBox8.AutoSize = True
            checkBox8.Location = New Drawing.Point(171, 95)
            checkBox8.Name = "checkBox8"
            checkBox8.Size = New Drawing.Size(101, 24)
            checkBox8.TabIndex = 2
            checkBox8.Text = "MANTAR"
            checkBox8.UseVisualStyleBackColor = True
            ' 
            ' checkBox3
            ' 
            checkBox3.AutoSize = True
            checkBox3.Location = New Drawing.Point(11, 95)
            checkBox3.Name = "checkBox3"
            checkBox3.Size = New Drawing.Size(79, 24)
            checkBox3.TabIndex = 2
            checkBox3.Text = "MISIR"
            checkBox3.UseVisualStyleBackColor = True
            ' 
            ' checkBox7
            ' 
            checkBox7.AutoSize = True
            checkBox7.Location = New Drawing.Point(169, 65)
            checkBox7.Name = "checkBox7"
            checkBox7.Size = New Drawing.Size(89, 24)
            checkBox7.TabIndex = 1
            checkBox7.Text = "SUCUK"
            checkBox7.UseVisualStyleBackColor = True
            ' 
            ' checkBox6
            ' 
            checkBox6.AutoSize = True
            checkBox6.Location = New Drawing.Point(169, 35)
            checkBox6.Name = "checkBox6"
            checkBox6.Size = New Drawing.Size(88, 24)
            checkBox6.TabIndex = 0
            checkBox6.Text = "SALAM"
            checkBox6.UseVisualStyleBackColor = True
            ' 
            ' checkBox2
            ' 
            checkBox2.AutoSize = True
            checkBox2.Location = New Drawing.Point(9, 65)
            checkBox2.Name = "checkBox2"
            checkBox2.Size = New Drawing.Size(83, 24)
            checkBox2.TabIndex = 1
            checkBox2.Text = "SOSİS"
            checkBox2.UseVisualStyleBackColor = True
            ' 
            ' checkBox1
            ' 
            checkBox1.AutoSize = True
            checkBox1.Location = New Drawing.Point(9, 35)
            checkBox1.Name = "checkBox1"
            checkBox1.Size = New Drawing.Size(154, 24)
            checkBox1.TabIndex = 0
            checkBox1.Text = "DANA JAMBON"
            checkBox1.UseVisualStyleBackColor = True
            ' 
            ' label4
            ' 
            label4.AutoSize = True
            label4.Font = New Drawing.Font("Microsoft Sans Serif", 12.0F, Drawing.FontStyle.Bold, Drawing.GraphicsUnit.Point, 162)
            label4.Location = New Drawing.Point(58, 657)
            label4.Name = "label4"
            label4.Size = New Drawing.Size(61, 20)
            label4.TabIndex = 6
            label4.Text = "ADET:"
            ' 
            ' btnHesapla
            ' 
            btnHesapla.BackColor = Drawing.Color.Tomato
            btnHesapla.Font = New Drawing.Font("Microsoft Sans Serif", 12.0F, Drawing.FontStyle.Bold, Drawing.GraphicsUnit.Point, 162)
            btnHesapla.ForeColor = Drawing.SystemColors.ButtonHighlight
            btnHesapla.Location = New Drawing.Point(62, 693)
            btnHesapla.Name = "btnHesapla"
            btnHesapla.Size = New Drawing.Size(191, 57)
            btnHesapla.TabIndex = 8
            btnHesapla.Text = "HESAPLA"
            btnHesapla.UseVisualStyleBackColor = False
            AddHandler btnHesapla.Click, New EventHandler(AddressOf btnHesapla_Click)
            ' 
            ' btnEkle
            ' 
            btnEkle.BackColor = Drawing.Color.Tomato
            btnEkle.Font = New Drawing.Font("Microsoft Sans Serif", 12.0F, Drawing.FontStyle.Bold, Drawing.GraphicsUnit.Point, 162)
            btnEkle.ForeColor = Drawing.SystemColors.ButtonHighlight
            btnEkle.Location = New Drawing.Point(287, 693)
            btnEkle.Name = "btnEkle"
            btnEkle.Size = New Drawing.Size(198, 57)
            btnEkle.TabIndex = 11
            btnEkle.Text = "SEPETE EKLE"
            btnEkle.UseVisualStyleBackColor = False
            AddHandler btnEkle.Click, New EventHandler(AddressOf btnEkle_Click)
            ' 
            ' label5
            ' 
            label5.AutoSize = True
            label5.Font = New Drawing.Font("Microsoft Sans Serif", 12.0F, Drawing.FontStyle.Bold, Drawing.GraphicsUnit.Point, 162)
            label5.Location = New Drawing.Point(283, 657)
            label5.Name = "label5"
            label5.Size = New Drawing.Size(72, 20)
            label5.TabIndex = 9
            label5.Text = "TUTAR:"
            ' 
            ' groupBox2
            ' 
            groupBox2.BackColor = Drawing.SystemColors.ButtonHighlight
            groupBox2.Controls.Add(lblTutar)
            groupBox2.Controls.Add(nudAdet)
            groupBox2.Controls.Add(label8)
            groupBox2.Controls.Add(btnOnayla)
            groupBox2.Controls.Add(lblToplam)
            groupBox2.Controls.Add(label6)
            groupBox2.Controls.Add(listSepet)
            groupBox2.Controls.Add(cmbEbat)
            groupBox2.Controls.Add(btnEkle)
            groupBox2.Controls.Add(label2)
            groupBox2.Controls.Add(label3)
            groupBox2.Controls.Add(label5)
            groupBox2.Controls.Add(listPizzalar)
            groupBox2.Controls.Add(btnHesapla)
            groupBox2.Controls.Add(rdbInceKenar)
            groupBox2.Controls.Add(rdbKalinKenar)
            groupBox2.Controls.Add(label4)
            groupBox2.Controls.Add(groupBox1)
            groupBox2.Dock = Windows.Forms.DockStyle.Fill
            groupBox2.Font = New Drawing.Font("Microsoft Sans Serif", 12.0F, Drawing.FontStyle.Bold, Drawing.GraphicsUnit.Point, 162)
            groupBox2.Location = New Drawing.Point(0, 55)
            groupBox2.Name = "groupBox2"
            groupBox2.Size = New Drawing.Size(1028, 774)
            groupBox2.TabIndex = 12
            groupBox2.TabStop = False
            groupBox2.Text = "Pizza Sipariş"
            ' 
            ' lblTutar
            ' 
            lblTutar.AutoSize = True
            lblTutar.Font = New Drawing.Font("Microsoft Sans Serif", 12.0F, Drawing.FontStyle.Bold, Drawing.GraphicsUnit.Point, 162)
            lblTutar.Location = New Drawing.Point(361, 657)
            lblTutar.Name = "lblTutar"
            lblTutar.Size = New Drawing.Size(27, 20)
            lblTutar.TabIndex = 18
            lblTutar.Text = "---"
            ' 
            ' nudAdet
            ' 
            nudAdet.BackColor = Drawing.SystemColors.InactiveBorder
            nudAdet.Location = New Drawing.Point(125, 657)
            nudAdet.Name = "nudAdet"
            nudAdet.Size = New Drawing.Size(128, 26)
            nudAdet.TabIndex = 17
            ' 
            ' label8
            ' 
            label8.AutoSize = True
            label8.Font = New Drawing.Font("Microsoft Sans Serif", 15.75F, Drawing.FontStyle.Bold, Drawing.GraphicsUnit.Point, 162)
            label8.Location = New Drawing.Point(466, 238)
            label8.Name = "label8"
            label8.Size = New Drawing.Size(51, 25)
            label8.TabIndex = 16
            label8.Text = ">>>"
            ' 
            ' btnOnayla
            ' 
            btnOnayla.BackColor = Drawing.Color.Tomato
            btnOnayla.Font = New Drawing.Font("Microsoft Sans Serif", 12.0F, Drawing.FontStyle.Bold, Drawing.GraphicsUnit.Point, 162)
            btnOnayla.ForeColor = Drawing.SystemColors.ButtonHighlight
            btnOnayla.Location = New Drawing.Point(606, 693)
            btnOnayla.Name = "btnOnayla"
            btnOnayla.Size = New Drawing.Size(342, 57)
            btnOnayla.TabIndex = 15
            btnOnayla.Text = "SİPARİŞİ ONAYLA"
            btnOnayla.UseVisualStyleBackColor = False
            AddHandler btnOnayla.Click, New EventHandler(AddressOf btnOnayla_Click)
            ' 
            ' lblToplam
            ' 
            lblToplam.AutoSize = True
            lblToplam.Location = New Drawing.Point(833, 654)
            lblToplam.Name = "lblToplam"
            lblToplam.Size = New Drawing.Size(27, 20)
            lblToplam.TabIndex = 14
            lblToplam.Text = "---"
            ' 
            ' label6
            ' 
            label6.AutoSize = True
            label6.Location = New Drawing.Point(680, 654)
            label6.Name = "label6"
            label6.Size = New Drawing.Size(147, 20)
            label6.TabIndex = 13
            label6.Text = "TOPLAM TUTAR:"
            ' 
            ' listSepet
            ' 
            listSepet.BackColor = Drawing.SystemColors.InactiveBorder
            listSepet.FormattingEnabled = True
            listSepet.HorizontalScrollbar = True
            listSepet.ItemHeight = 20
            listSepet.Location = New Drawing.Point(521, 45)
            listSepet.Name = "listSepet"
            listSepet.Size = New Drawing.Size(482, 584)
            listSepet.TabIndex = 12
            ' 
            ' Form1
            ' 
            AutoScaleDimensions = New Drawing.SizeF(6.0F, 13.0F)
            AutoScaleMode = Windows.Forms.AutoScaleMode.Font
            ClientSize = New Drawing.Size(1028, 829)
            Controls.Add(groupBox2)
            Controls.Add(label1)
            Name = "Form1"
            StartPosition = Windows.Forms.FormStartPosition.CenterScreen
            Text = "PİZZA OTOMASYONU"
            AddHandler Load, New EventHandler(AddressOf Form1_Load)
            groupBox1.ResumeLayout(False)
            groupBox1.PerformLayout()
            groupBox2.ResumeLayout(False)
            groupBox2.PerformLayout()
            CType(nudAdet, ComponentModel.ISupportInitialize).EndInit()
            ResumeLayout(False)

        End Sub

#End Region

        Private label1 As Windows.Forms.Label
        Private label2 As Windows.Forms.Label
        Private cmbEbat As Windows.Forms.ComboBox
        Private label3 As Windows.Forms.Label
        Private listPizzalar As Windows.Forms.ListBox
        Private rdbInceKenar As Windows.Forms.RadioButton
        Private rdbKalinKenar As Windows.Forms.RadioButton
        Private groupBox1 As Windows.Forms.GroupBox
        Private label4 As Windows.Forms.Label
        Private btnHesapla As Windows.Forms.Button
        Private btnEkle As Windows.Forms.Button
        Private label5 As Windows.Forms.Label
        Private groupBox2 As Windows.Forms.GroupBox
        Private btnOnayla As Windows.Forms.Button
        Private lblToplam As Windows.Forms.Label
        Private label6 As Windows.Forms.Label
        Private listSepet As Windows.Forms.ListBox
        Private checkBox10 As Windows.Forms.CheckBox
        Private checkBox5 As Windows.Forms.CheckBox
        Private checkBox9 As Windows.Forms.CheckBox
        Private checkBox4 As Windows.Forms.CheckBox
        Private checkBox8 As Windows.Forms.CheckBox
        Private checkBox3 As Windows.Forms.CheckBox
        Private checkBox7 As Windows.Forms.CheckBox
        Private checkBox6 As Windows.Forms.CheckBox
        Private checkBox2 As Windows.Forms.CheckBox
        Private checkBox1 As Windows.Forms.CheckBox
        Private label8 As Windows.Forms.Label
        Private nudAdet As Windows.Forms.NumericUpDown
        Private lblTutar As Windows.Forms.Label
    End Class
End Namespace
