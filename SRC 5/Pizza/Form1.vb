Imports System
Imports System.Windows.Forms

Namespace Pizza
    Public Partial Class Form1
        Inherits Form
        Public Sub New()
            InitializeComponent()
        End Sub

        Private Sub label11_Click(ByVal sender As Object, ByVal e As EventArgs)

        End Sub

        Private Sub button1_Click(ByVal sender As Object, ByVal e As EventArgs)
            listBox1.Items.Add(textBox1.Text)
            listBox2.Items.Add(textBox2.Text)
            listBox3.Items.Add(textBox3.Text)
            listBox4.Items.Add(comboBox1.Text)
            listBox5.Items.Add(comboBox2.Text)
            listBox6.Items.Add(label12.Text & " " & label13.Text & " " & label14.Text & " " & label15.Text & " ")
        End Sub

        Private Sub checkBox1_CheckedChanged(ByVal sender As Object, ByVal e As EventArgs)
            label12.Text = checkBox1.Text
        End Sub

        Private Sub checkBox2_CheckedChanged(ByVal sender As Object, ByVal e As EventArgs)
            label13.Text = checkBox2.Text
        End Sub

        Private Sub checkBox3_CheckedChanged(ByVal sender As Object, ByVal e As EventArgs)
            label14.Text = checkBox3.Text
        End Sub

        Private Sub checkBox4_CheckedChanged(ByVal sender As Object, ByVal e As EventArgs)
            label15.Text = checkBox4.Text
        End Sub



    End Class
End Namespace
