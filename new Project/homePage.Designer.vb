<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class homePage
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
        Me.menuBtn = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.aboutBtn = New System.Windows.Forms.Button()
        Me.staffLogBtn = New System.Windows.Forms.Button()
        Me.exitBtn = New System.Windows.Forms.Button()
        Me.contactBtn = New System.Windows.Forms.Button()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'menuBtn
        '
        Me.menuBtn.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.menuBtn.Font = New System.Drawing.Font("Mont Heavy DEMO", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.menuBtn.Location = New System.Drawing.Point(35, 93)
        Me.menuBtn.Name = "menuBtn"
        Me.menuBtn.Size = New System.Drawing.Size(129, 33)
        Me.menuBtn.TabIndex = 20
        Me.menuBtn.Text = "Customer"
        Me.menuBtn.UseVisualStyleBackColor = False
        '
        'Label2
        '
        Me.Label2.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.Label2.Font = New System.Drawing.Font("Mont Heavy DEMO", 28.2!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(218, 119)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(301, 179)
        Me.Label2.TabIndex = 21
        Me.Label2.Text = "WELCOME TO BRASAS BRAZUCA"
        '
        'aboutBtn
        '
        Me.aboutBtn.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.aboutBtn.Font = New System.Drawing.Font("Mont Heavy DEMO", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.aboutBtn.Location = New System.Drawing.Point(35, 228)
        Me.aboutBtn.Name = "aboutBtn"
        Me.aboutBtn.Size = New System.Drawing.Size(129, 33)
        Me.aboutBtn.TabIndex = 16
        Me.aboutBtn.Text = "About Us"
        Me.aboutBtn.UseVisualStyleBackColor = False
        '
        'staffLogBtn
        '
        Me.staffLogBtn.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.staffLogBtn.Font = New System.Drawing.Font("Mont Heavy DEMO", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.staffLogBtn.Location = New System.Drawing.Point(35, 165)
        Me.staffLogBtn.Name = "staffLogBtn"
        Me.staffLogBtn.Size = New System.Drawing.Size(129, 33)
        Me.staffLogBtn.TabIndex = 19
        Me.staffLogBtn.Text = "Staff"
        Me.staffLogBtn.UseVisualStyleBackColor = False
        '
        'exitBtn
        '
        Me.exitBtn.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.exitBtn.Font = New System.Drawing.Font("Mont Heavy DEMO", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.exitBtn.Location = New System.Drawing.Point(35, 365)
        Me.exitBtn.Name = "exitBtn"
        Me.exitBtn.Size = New System.Drawing.Size(129, 33)
        Me.exitBtn.TabIndex = 17
        Me.exitBtn.Text = "Exit"
        Me.exitBtn.UseVisualStyleBackColor = False
        '
        'contactBtn
        '
        Me.contactBtn.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.contactBtn.Font = New System.Drawing.Font("Mont Heavy DEMO", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.contactBtn.Location = New System.Drawing.Point(35, 296)
        Me.contactBtn.Name = "contactBtn"
        Me.contactBtn.Size = New System.Drawing.Size(129, 33)
        Me.contactBtn.TabIndex = 18
        Me.contactBtn.Text = "Contact Us"
        Me.contactBtn.UseVisualStyleBackColor = False
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.Panel1.Controls.Add(Me.menuBtn)
        Me.Panel1.Controls.Add(Me.contactBtn)
        Me.Panel1.Controls.Add(Me.exitBtn)
        Me.Panel1.Controls.Add(Me.aboutBtn)
        Me.Panel1.Controls.Add(Me.staffLogBtn)
        Me.Panel1.Location = New System.Drawing.Point(-2, -3)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(200, 462)
        Me.Panel1.TabIndex = 23
        '
        'homePage
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.ClientSize = New System.Drawing.Size(557, 454)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Label2)
        Me.Name = "homePage"
        Me.Text = "Homepage"
        Me.Panel1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents menuBtn As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents aboutBtn As Button
    Friend WithEvents staffLogBtn As Button
    Friend WithEvents exitBtn As Button
    Friend WithEvents contactBtn As Button
    Friend WithEvents Panel1 As Panel
End Class
