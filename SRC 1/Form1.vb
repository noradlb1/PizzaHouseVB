Imports System
Imports System.Windows.Forms

Namespace Pizzacı
    Public Partial Class Form1
        Inherits Form
        Public Sub New()
            InitializeComponent()
        End Sub

        Private Sub checkBox4_CheckedChanged(ByVal sender As Object, ByVal e As EventArgs)
            label18.Text = checkBox6.Text
        End Sub
        Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
            listBox1.Items.Add(textBox1.Text)
            listBox2.Items.Add(textBox2.Text)
            listBox3.Items.Add(textBox3.Text)
            listBox4.Items.Add(comboBox1.Text)
            listBox5.Items.Add(comboBox2.Text)
            listBox6.Items.Add(label13.Text & " " & label14.Text & " " & label15.Text & " " & label16.Text & " " & label17.Text & " " & label18.Text)
        End Sub

        Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click

            textBox1.Clear()
            textBox2.Clear()
            textBox3.Clear()
            comboBox1.Text = ""
            comboBox2.Text = ""
            label13.Text = ""
            label14.Text = ""
            label15.Text = ""
            label16.Text = ""
            label17.Text = ""
            label18.Text = ""
        End Sub

        Private Sub checkBox1_CheckedChanged(ByVal sender As Object, ByVal e As EventArgs)
            label13.Text = checkBox1.Text
        End Sub

        Private Sub checkBox2_CheckedChanged(ByVal sender As Object, ByVal e As EventArgs)
            label14.Text = checkBox2.Text
        End Sub

        Private Sub checkBox3_CheckedChanged(ByVal sender As Object, ByVal e As EventArgs)
            label15.Text = checkBox3.Text
        End Sub

        Private Sub checkBox6_CheckedChanged(ByVal sender As Object, ByVal e As EventArgs)
            label16.Text = checkBox4.Text
        End Sub

        Private Sub checkBox5_CheckedChanged(ByVal sender As Object, ByVal e As EventArgs)
            label17.Text = checkBox5.Text
        End Sub
    End Class
End Namespace
