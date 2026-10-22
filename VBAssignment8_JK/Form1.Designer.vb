<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.txtRainfall = New System.Windows.Forms.TextBox()
        Me.lstRainfall = New System.Windows.Forms.ListBox()
        Me.lstStatistics = New System.Windows.Forms.ListBox()
        Me.btnCalculate = New System.Windows.Forms.Button()
        Me.btnSubmit = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'txtRainfall
        '
        Me.txtRainfall.Location = New System.Drawing.Point(502, 54)
        Me.txtRainfall.Name = "txtRainfall"
        Me.txtRainfall.Size = New System.Drawing.Size(100, 38)
        Me.txtRainfall.TabIndex = 0
        '
        'lstRainfall
        '
        Me.lstRainfall.FormattingEnabled = True
        Me.lstRainfall.ItemHeight = 30
        Me.lstRainfall.Location = New System.Drawing.Point(56, 44)
        Me.lstRainfall.Name = "lstRainfall"
        Me.lstRainfall.Size = New System.Drawing.Size(272, 544)
        Me.lstRainfall.TabIndex = 1
        '
        'lstStatistics
        '
        Me.lstStatistics.FormattingEnabled = True
        Me.lstStatistics.ItemHeight = 30
        Me.lstStatistics.Location = New System.Drawing.Point(759, 44)
        Me.lstStatistics.Name = "lstStatistics"
        Me.lstStatistics.Size = New System.Drawing.Size(336, 544)
        Me.lstStatistics.TabIndex = 2
        '
        'btnCalculate
        '
        Me.btnCalculate.Enabled = False
        Me.btnCalculate.Location = New System.Drawing.Point(576, 603)
        Me.btnCalculate.Name = "btnCalculate"
        Me.btnCalculate.Size = New System.Drawing.Size(136, 88)
        Me.btnCalculate.TabIndex = 3
        Me.btnCalculate.Text = "Calculate"
        Me.btnCalculate.UseVisualStyleBackColor = True
        '
        'btnSubmit
        '
        Me.btnSubmit.Location = New System.Drawing.Point(381, 603)
        Me.btnSubmit.Name = "btnSubmit"
        Me.btnSubmit.Size = New System.Drawing.Size(136, 88)
        Me.btnSubmit.TabIndex = 4
        Me.btnSubmit.Text = "Submit"
        Me.btnSubmit.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(13.0!, 30.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1153, 766)
        Me.Controls.Add(Me.btnSubmit)
        Me.Controls.Add(Me.btnCalculate)
        Me.Controls.Add(Me.lstStatistics)
        Me.Controls.Add(Me.lstRainfall)
        Me.Controls.Add(Me.txtRainfall)
        Me.Font = New System.Drawing.Font("Comic Sans MS", 13.0!)
        Me.Margin = New System.Windows.Forms.Padding(5, 6, 5, 6)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents txtRainfall As TextBox
    Friend WithEvents lstRainfall As ListBox
    Friend WithEvents lstStatistics As ListBox
    Friend WithEvents btnCalculate As Button
    Friend WithEvents btnSubmit As Button
End Class
