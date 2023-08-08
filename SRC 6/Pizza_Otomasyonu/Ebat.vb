
Namespace Pizza_Otomasyonu
    Friend Class Ebat
        Public Property Adi As String
        Public Property Carpan As Double

        Public Overrides Function ToString() As String ' Varsayılan metod ezilerek Adi propertysi yazdırılır.
            Return Adi
        End Function
    End Class
End Namespace
