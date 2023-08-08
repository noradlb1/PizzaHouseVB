Imports System.Collections.Generic

Namespace Pizza_Otomasyonu
    Friend Class Pizza

        Public Sub New()
            Malzemeler = New List(Of String)()
        End Sub

        Public Property Adi As String
        Public Property Fiyat As Decimal
        Public Property Ebati As Ebat
        Public Property KenarTipi As KenarTip
        Public Property Malzemeler As List(Of String)

        Public ReadOnly Property Tutar As Decimal
            Get
                Dim lTutar As Decimal = 0
                lTutar = Fiyat * CDec(Ebati.Carpan) + KenarTipi.EkFiyat
                Return lTutar
            End Get
        End Property

        Public Overrides Function ToString() As String ' Varsayılan metod ezilerek Adi propertysi yazdırılır.
            Return Adi
        End Function
    End Class
End Namespace
