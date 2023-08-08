Imports System
Imports System.Collections.Generic
Imports System.IO
Imports System.Windows.Forms

Namespace PizzaPartyPlanner
    Public Partial Class Report
        Inherits Form
        Public Sub New(ByVal Pizzas As List(Of List(Of String)), ByVal form1 As Form)
            If Pizzas IsNot Nothing Then
                Me.Pizzas = Pizzas
            End If
            main = form1
            InitializeComponent()
        End Sub

        Private Pizzas As List(Of List(Of String))
        Private main As Form

        Private Sub btnSave_Click(ByVal sender As Object, ByVal e As EventArgs)
            Try
                Dim saveFile As SaveFileDialog = New SaveFileDialog()
                saveFile.Filter = "Text (*.txt)|*.txt"
                saveFile.DefaultExt = "txt"
                saveFile.ShowDialog()
                Dim path = saveFile.FileName
                File.WriteAllText(path, txtReport.Text)
            Catch ex As Exception
                MessageBox.Show(ex.Message, Name)
            End Try

        End Sub

        Private Sub btnClose_Click(ByVal sender As Object, ByVal e As EventArgs)
            main.Show()
            Close()

        End Sub

        Private Sub Report_Load(ByVal sender As Object, ByVal e As EventArgs)
            Try
                Dim totalCost As Decimal = 0
                Dim nl = Environment.NewLine
                For Each za In Pizzas
                    Dim name = String.Format("{0} {1} {2}", za(0), za(1), nl)
                    Dim notes = String.Format("     {0} slices {1}      {2} {3}      {4:C}", za(2), nl, za(3), nl, za(4))
                    txtReport.Text += name
                    txtReport.Text += notes & nl
                    totalCost += Decimal.Parse(za(4))
                Next
                txtReport.Text += nl & "Total" & nl & "-----------" & nl
                txtReport.Text += String.Format("{0:C}", totalCost.ToString())
            Catch __unusedNullReferenceException1__ As NullReferenceException
                txtReport.Text = "No Pizzas in this Plan"
            Catch ex As Exception
                MessageBox.Show(ex.Message, Name)
            End Try
        End Sub
    End Class
End Namespace
