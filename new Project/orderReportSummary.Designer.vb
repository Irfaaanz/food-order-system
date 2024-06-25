<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class orderReportSummary
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
        Me.logOutBtn = New System.Windows.Forms.Button()
        Me.showReportBtn = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.orderSummary = New System.Windows.Forms.ListBox()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'logOutBtn
        '
        Me.logOutBtn.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.logOutBtn.Font = New System.Drawing.Font("Mont Heavy DEMO", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.logOutBtn.Location = New System.Drawing.Point(414, 479)
        Me.logOutBtn.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.logOutBtn.Name = "logOutBtn"
        Me.logOutBtn.Size = New System.Drawing.Size(145, 45)
        Me.logOutBtn.TabIndex = 51
        Me.logOutBtn.Text = "LOG OUT"
        Me.logOutBtn.UseVisualStyleBackColor = False
        '
        'showReportBtn
        '
        Me.showReportBtn.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.showReportBtn.Font = New System.Drawing.Font("Mont Heavy DEMO", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.showReportBtn.Location = New System.Drawing.Point(200, 479)
        Me.showReportBtn.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.showReportBtn.Name = "showReportBtn"
        Me.showReportBtn.Size = New System.Drawing.Size(158, 45)
        Me.showReportBtn.TabIndex = 52
        Me.showReportBtn.Text = "DISPLAY REPORT"
        Me.showReportBtn.UseVisualStyleBackColor = False
        '
        'Label2
        '
        Me.Label2.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.Label2.Font = New System.Drawing.Font("Mont Heavy DEMO", 36.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Black
        Me.Label2.Location = New System.Drawing.Point(60, 17)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(700, 59)
        Me.Label2.TabIndex = 50
        Me.Label2.Text = "CUSTOMER ORDER REPORT"
        '
        'orderSummary
        '
        Me.orderSummary.FormattingEnabled = True
        Me.orderSummary.Location = New System.Drawing.Point(63, 167)
        Me.orderSummary.Name = "orderSummary"
        Me.orderSummary.Size = New System.Drawing.Size(668, 290)
        Me.orderSummary.TabIndex = 49
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Location = New System.Drawing.Point(-5, 3)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(810, 100)
        Me.Panel1.TabIndex = 54
        '
        'orderReportSummary
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.ClientSize = New System.Drawing.Size(800, 554)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.logOutBtn)
        Me.Controls.Add(Me.showReportBtn)
        Me.Controls.Add(Me.orderSummary)
        Me.Name = "orderReportSummary"
        Me.Text = "orderReportSummary"
        Me.Panel1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents logOutBtn As Button
    Friend WithEvents showReportBtn As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents orderSummary As ListBox
    Friend WithEvents Panel1 As Panel
End Class
