Imports System
Imports System.Windows.Forms

Namespace Pizza_Otomasyonu
    Public Partial Class Form1
        Inherits Form
        Public Sub New()
            InitializeComponent()
        End Sub

        Private Sub Form1_Load(ByVal sender As Object, ByVal e As EventArgs)

            ' Ebat Tanımlamaları.

            Dim Kucuk As Ebat = New Ebat With {
                .Adi = "KÜÇÜK BOY",
                .Carpan = 1
            }
            Dim Orta As Ebat = New Ebat With {
                .Adi = "ORTA BOY",
                .Carpan = 1.25
            }
            Dim Buyuk As Ebat = New Ebat With {
                .Adi = "BÜYÜK BOY",
                .Carpan = 1.75
            }
            Dim Maxi As Ebat = New Ebat With {
                .Adi = "MAXİ BOY",
                .Carpan = 2
            }
            cmbEbat.Items.Add(Kucuk)
            cmbEbat.Items.Add(Orta)
            cmbEbat.Items.Add(Buyuk)
            cmbEbat.Items.Add(Maxi)


            ' Pizza Tanımlamaları.

            Dim Klasik As Pizza = New Pizza With {
                .Adi = "KLASİK PİZZA",
                .Fiyat = 14
            }
            Dim Karisik As Pizza = New Pizza With {
                .Adi = "KARIŞIK PİZZA",
                .Fiyat = 17
            }
            Dim Turkish As Pizza = New Pizza With {
                .Adi = "TURKISH PİZZA",
                .Fiyat = 20
            }
            Dim Tuna As Pizza = New Pizza With {
                .Adi = "TUNA PİZZA",
                .Fiyat = 21
            }
            Dim Akdeniz As Pizza = New Pizza With {
                .Adi = "AKDENİZ PİZZA",
                .Fiyat = 19
            }
            Dim Karadeniz As Pizza = New Pizza With {
                .Adi = "KARADENİZ PİZZA",
                .Fiyat = 22
            }
            listPizzalar.Items.Add(Klasik)
            listPizzalar.Items.Add(Karisik)
            listPizzalar.Items.Add(Turkish)
            listPizzalar.Items.Add(Tuna)
            listPizzalar.Items.Add(Akdeniz)
            listPizzalar.Items.Add(Karadeniz)


            ' KenarTip Tanımlamaları.

            Dim İnceKenar As KenarTip = New KenarTip With {
                .Adi = "İNCE KENAR",
                .EkFiyat = 0
            }
            rdbInceKenar.Tag = İnceKenar
            Dim KalınKenar As KenarTip = New KenarTip With {
                .Adi = "KALIN KENAR",
                .EkFiyat = 2
            }
            rdbKalinKenar.Tag = KalınKenar

        End Sub
        Private Sub Temizle()
            cmbEbat.SelectedItem = 0
            ' listPizzalar.SelectedItem = -1;

            For Each ctrl As CheckBox In groupBox1.Controls
                ctrl.Checked = False
            Next
            lblTutar.Text = 0.ToString()
            nudAdet.Value = 0
        End Sub
        Private Sub btnHesapla_Click(ByVal sender As Object, ByVal e As EventArgs)
            Dim pizza = CType(listPizzalar.SelectedItem, Pizza)
            pizza.Ebati = CType(cmbEbat.SelectedItem, Ebat)
            pizza.KenarTipi = If(rdbInceKenar.Checked, CType(rdbInceKenar.Tag, KenarTip), CType(rdbKalinKenar.Tag, KenarTip))

            For Each ctrl As CheckBox In groupBox1.Controls
                If ctrl.Checked Then
                    pizza.Malzemeler.Add(ctrl.Text)
                End If
            Next

            Dim araTutar = nudAdet.Value * pizza.Tutar
            lblTutar.Text = araTutar.ToString()
            siparis = New Siparis()
            siparis.piz = pizza
            siparis.Adet = CInt(nudAdet.Value)
        End Sub
        Private siparis As Siparis
        Private Sub btnEkle_Click(ByVal sender As Object, ByVal e As EventArgs)
            If siparis IsNot Nothing Then
                listSepet.Items.Add(siparis)
            End If
            Temizle()
        End Sub



        Private Sub btnOnayla_Click(ByVal sender As Object, ByVal e As EventArgs)
            Dim toplamTutar As Decimal = 0
            Dim adet = 0
            For Each spr As Siparis In listSepet.Items
                toplamTutar += spr.Adet * spr.piz.Tutar
                adet += 1
            Next
            lblToplam.Text = toplamTutar.ToString()
            MessageBox.Show(String.Format("Toplam Sipariş Adediniz: {0} Toplam Sipariş Tutarınız: {1}", adet, toplamTutar), "UYARI", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End Sub
    End Class
End Namespace
