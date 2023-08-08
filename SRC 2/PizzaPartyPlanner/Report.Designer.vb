Imports System

Namespace PizzaPartyPlanner
    Partial Class Report
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
            txtReport = New System.Windows.Forms.TextBox()
            btnClose = New System.Windows.Forms.Button()
            btnSave = New System.Windows.Forms.Button()
            SuspendLayout()
            ' 
            ' txtReport
            ' 
            txtReport.Location = New Drawing.Point(0, 0)
            txtReport.Multiline = True
            txtReport.Name = "txtReport"
            txtReport.Size = New Drawing.Size(391, 480)
            txtReport.TabIndex = 0
            ' 
            ' btnClose
            ' 
            btnClose.Location = New Drawing.Point(12, 486)
            btnClose.Name = "btnClose"
            btnClose.Size = New Drawing.Size(75, 23)
            btnClose.TabIndex = 1
            btnClose.Text = "Close"
            btnClose.UseVisualStyleBackColor = True
            AddHandler btnClose.Click, New EventHandler(AddressOf btnClose_Click)
            ' 
            ' btnSave
            ' 
            btnSave.Location = New Drawing.Point(306, 486)
            btnSave.Name = "btnSave"
            btnSave.Size = New Drawing.Size(75, 23)
            btnSave.TabIndex = 2
            btnSave.Text = "Save"
            btnSave.UseVisualStyleBackColor = True
            AddHandler btnSave.Click, New EventHandler(AddressOf btnSave_Click)
            ' 
            ' Report
            ' 
            AutoScaleDimensions = New Drawing.SizeF(6.0F, 13.0F)
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            ClientSize = New Drawing.Size(393, 517)
            Controls.Add(btnSave)
            Controls.Add(btnClose)
            Controls.Add(txtReport)
            Name = "Report"
            Text = "Report"
            AddHandler Load, New EventHandler(AddressOf Report_Load)
            ResumeLayout(False)
            PerformLayout()

        End Sub

#End Region

        Private txtReport As System.Windows.Forms.TextBox
        Private btnClose As System.Windows.Forms.Button
        Private btnSave As System.Windows.Forms.Button
    End Class
End Namespace
