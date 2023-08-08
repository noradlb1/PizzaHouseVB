Imports System
Imports System.Windows.Forms

Namespace PizzaSiparisOtomasyonu
    Public Partial Class AnaSayfa
        Inherits Form
        Public Sub New()
            InitializeComponent()
        End Sub
        Public Ekstralar As String

        'Projede istenilen metot
        Public Function SiparisTutariHesapla(ByVal PizzaBoyu As Integer, ByVal PizzaAdeti As Integer, ByVal Icecek As Integer, ByVal IcecekAdeti As Integer, ByVal Ekstra As Integer) As Integer
            Return PizzaBoyu * PizzaAdeti + Icecek * IcecekAdeti + Ekstra
        End Function

        Private Sub AnaSayfa_Load(ByVal sender As Object, ByVal e As EventArgs)
            listView2.Visible = False

            numericUpDown1.Value = 1
            numericUpDown2.Value = 1

            'Pizzanın büyüklüğünü seçmemizi sağlar

            comboBox1.Items.Add("Small Size - 20₺")
            comboBox1.Items.Add("Medium Size - 25₺")
            comboBox1.Items.Add("Large - 30₺")

            'İçecek kısmı için seçmemizi sağlar

            comboBox2.Items.Add("Kutu Coca Cola - 5₺")
            comboBox2.Items.Add("Kutu Fanta - 5₺")
            comboBox2.Items.Add("Kutu Ice Tea - 5₺")
            comboBox2.Items.Add("Ayran(250 ml) - 4₺")
            comboBox2.Items.Add("Ayran(400 ml) - 5₺")
            comboBox2.Items.Add("Ayran(1 lt) - 10₺")
            comboBox2.Items.Add("1 Litre Coca Cola - 12₺")
            comboBox2.Items.Add("1 Litre Fanta - 12₺")
            comboBox2.Items.Add("1 Litre Ice Tea - 12₺")




            'listview için başlıklar
            listView1.View = View.Details
            listView1.FullRowSelect = True
            listView1.Columns.Add("Adı Soyadı", 126)
            listView1.Columns.Add("Telefon", 150)
            listView1.Columns.Add("Adres", 170)
            listView1.Columns.Add("Pizza Boyu ve Adet", 140)
            listView1.Columns.Add("İçecek Boyu ve Adet", 130)
            listView1.Columns.Add("Ekstralar", 100)
            listView1.Columns.Add("Toplam Tutar", 100)
            listView1.Columns.Add("Sipariş Tarihi", 110)
            timer1.Enabled = True

            listView2.View = View.Details
            listView2.FullRowSelect = True
            listView2.Columns.Add("Adı Soyadı", 126)
            listView2.Columns.Add("Telefon", 150)
            listView2.Columns.Add("Adres", 170)
            listView2.Columns.Add("Pizza Boyu ve Adet", 140)
            listView2.Columns.Add("İçecek Boyu ve Adet", 130)
            listView2.Columns.Add("Ekstralar", 100)
            listView2.Columns.Add("Toplam Tutar", 100)
            listView2.Columns.Add("Sipariş Tarihi", 110)



        End Sub

        Private Sub groupBox1_Enter(ByVal sender As Object, ByVal e As EventArgs)

        End Sub

        Private Sub timer1_Tick(ByVal sender As Object, ByVal e As EventArgs)
            textBox3.Text = Date.Now.ToLongTimeString()
        End Sub

        Private Sub textBox3_TextChanged(ByVal sender As Object, ByVal e As EventArgs)

        End Sub

        Private Sub listView1_SelectedIndexChanged(ByVal sender As Object, ByVal e As EventArgs)

        End Sub

        Private Sub comboBox1_SelectedIndexChanged(ByVal sender As Object, ByVal e As EventArgs)



        End Sub

        Private Sub comboBox2_SelectedIndexChanged(ByVal sender As Object, ByVal e As EventArgs)


        End Sub

        Private Sub button1_Click(ByVal sender As Object, ByVal e As EventArgs)


            Dim comboboxPizzaBoyu As Integer
            Dim comboboxIcecek As Integer
            Dim EkstraToplamTutar = 0
            Dim AdSoyad As String
            Dim TelefonNo As String
            Dim Adres As String
            Dim PizzaBoyuAdet As String
            Dim IcecekAdet As String
            Dim Tutar As Integer
            Dim tarih = Date.Now.ToString("MM/dd/yyyy HH:mm")


            'ekstraların fiyatını belirler
            If checkBox1.Checked = True Then EkstraToplamTutar += 3

            If checkBox2.Checked = True Then EkstraToplamTutar += 3

            If checkBox3.Checked = True Then EkstraToplamTutar += 3

            If checkBox4.Checked = True Then EkstraToplamTutar += 3

            If checkBox5.Checked = True Then EkstraToplamTutar += 3

            If checkBox6.Checked = True Then EkstraToplamTutar += 3



            If Equals(textBox1.Text, "") OrElse Equals(textBox2.Text, "") OrElse Equals(maskedTextBox1.Text, "") Then
                MessageBox.Show("Lütfen Müşteri Bilgilerini Doldurunuz!!")
                Return
            End If

            If comboBox1.SelectedIndex = -1 Then
                MessageBox.Show("Lütfen Pizzanın Boyutunu Seçiniz!!")
                Return

            End If


            'hangi pizza seçilecek onu belirler
            If Equals(comboBox1.SelectedItem.ToString(), "Küçük Boy - 20₺") Then
                comboboxPizzaBoyu = 20

            ElseIf Equals(comboBox1.SelectedItem.ToString(), "Orta Boy - 25₺") Then
                comboboxPizzaBoyu = 25
            Else
                comboboxPizzaBoyu = 30
            End If




            'içecek seçilmemişse içeceğe 0 atar seçilmişse içeceği belirleyip fiyatını comboboxaIcecek'e çeker
            If comboBox2.SelectedIndex = -1 Then
                comboboxIcecek = 0
            Else
                If Equals(comboBox2.SelectedItem.ToString(), "Kutu Coca Cola - 5₺") OrElse Equals(comboBox2.SelectedItem.ToString(), "Kutu Fanta - 5₺") OrElse Equals(comboBox2.SelectedItem.ToString(), "Kutu Ice Tea - 5₺") OrElse Equals(comboBox2.SelectedItem.ToString(), "Ayran(400 ml) - 5₺") Then
                    comboboxIcecek = 5

                ElseIf Equals(comboBox2.SelectedItem.ToString(), "Ayran(250 ml) - 4₺") Then
                    comboboxIcecek = 4

                ElseIf Equals(comboBox2.SelectedItem.ToString(), "Ayran(1 lt) - 10₺") Then
                    comboboxIcecek = 10

                ElseIf Equals(comboBox2.SelectedItem.ToString(), "1 Litre Coca Cola - 12₺") OrElse Equals(comboBox2.SelectedItem.ToString(), "1 Litre Fanta - 12₺") Then
                    comboboxIcecek = 12
                Else
                    comboboxIcecek = 12
                End If
            End If







            'metotu çağırıp tutara aktarır
            Tutar = SiparisTutariHesapla(comboboxPizzaBoyu, Convert.ToInt16(numericUpDown1.Value), comboboxIcecek, Convert.ToInt16(numericUpDown2.Value), EkstraToplamTutar)
            Call MessageBox.Show("Toplam Ödenmesi Gereken Tutar: " & Tutar.ToString() & "₺")
            listView2.Visible = False
            listView1.Visible = True

            'textboxları listviewe aktarmak için ilgili yerlere aktarma işlemi 
            AdSoyad = textBox1.Text
            TelefonNo = maskedTextBox1.Text
            Adres = textBox2.Text
            PizzaBoyuAdet = comboBox1.Text
            IcecekAdet = comboBox2.Text
            If EkstraToplamTutar <> 0 Then Ekstralar = Ekstralar.Substring(0, Ekstralar.Length - 1)



            'listview aktarma işlemi
            Dim ListViewAktarma = {AdSoyad, TelefonNo, Adres, PizzaBoyuAdet, IcecekAdet, Ekstralar, Convert.ToString(Tutar) & "₺", tarih}
            listView1.Items.Add(New ListViewItem(ListViewAktarma))


        End Sub

        'listview için ekstralar kısmına aktarmak için tek tek bütün checkboxları kontrol eder
        Private Sub checkBox1_CheckedChanged(ByVal sender As Object, ByVal e As EventArgs)
            If checkBox1.Checked = True Then Ekstralar = Ekstralar & checkBox1.Text & ","
        End Sub

        Private Sub checkBox2_CheckedChanged(ByVal sender As Object, ByVal e As EventArgs)
            If checkBox2.Checked = True Then Ekstralar = Ekstralar & checkBox2.Text & ","
        End Sub

        Private Sub checkBox3_CheckedChanged(ByVal sender As Object, ByVal e As EventArgs)
            If checkBox3.Checked = True Then Ekstralar = Ekstralar & checkBox3.Text & ","
        End Sub

        Private Sub checkBox4_CheckedChanged(ByVal sender As Object, ByVal e As EventArgs)
            If checkBox4.Checked = True Then Ekstralar = Ekstralar & checkBox4.Text & ","
        End Sub

        Private Sub checkBox5_CheckedChanged(ByVal sender As Object, ByVal e As EventArgs)
            If checkBox5.Checked = True Then Ekstralar = Ekstralar & checkBox5.Text & ","
        End Sub

        Private Sub checkBox6_CheckedChanged(ByVal sender As Object, ByVal e As EventArgs)
            If checkBox6.Checked = True Then Ekstralar = Ekstralar & checkBox6.Text & ","
        End Sub



        'temizle tuşuna basınca her şeyi temizler
        Private Sub button2_Click(ByVal sender As Object, ByVal e As EventArgs)
            textBox1.Clear()
            maskedTextBox1.Clear()
            textBox2.Clear()
            comboBox1.SelectedItem = Nothing
            comboBox2.SelectedItem = Nothing
            numericUpDown1.Value = 1
            numericUpDown2.Value = 1
            checkBox1.Checked = False
            checkBox2.Checked = False
            checkBox3.Checked = False
            checkBox4.Checked = False
            checkBox5.Checked = False
            checkBox6.Checked = False
            listView1.Visible = False
            listView2.Visible = True

        End Sub

        Private Sub numericUpDown1_ValueChanged(ByVal sender As Object, ByVal e As EventArgs)

        End Sub

        Private Sub listView2_SelectedIndexChanged(ByVal sender As Object, ByVal e As EventArgs)

        End Sub

        'yapılan tüm siparişleri getirir
        Private Sub button3_Click(ByVal sender As Object, ByVal e As EventArgs)
            listView2.Visible = False
            listView1.Visible = True
        End Sub

        Private Sub label13_Click(ByVal sender As Object, ByVal e As EventArgs)

        End Sub
    End Class
End Namespace
