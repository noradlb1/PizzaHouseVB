
Namespace Pizza_Otomasyonu
    Friend Class Siparis
        Public Property piz As Pizza
        Public Property Adet As Integer
        Public Property ToplamTutar As Decimal

        Public Overrides Function ToString() As String
            Dim spr = ""
            spr += piz.Ebati.Adi & ","
            spr += piz.Adi & ","
            spr += piz.KenarTipi.Adi & ","

            For Each mlz In piz.Malzemeler
                spr += String.Format("{0},", mlz)
            Next
            spr = spr.Remove(spr.Length - 1, 1)
            spr += String.Format(" {0} X {1} = {2}", Adet, piz.Tutar, Adet * piz.Tutar)
            Return spr
        End Function
    End Class
End Namespace
