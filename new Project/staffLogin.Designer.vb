<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class staffLogin
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.StaffBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.BrasasBrazuciaStaffDataDataSet = New new_Project.BrasasBrazuciaStaffDataDataSet()
        Me.StaffBindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.StaffTableAdapter = New new_Project.BrasasBrazuciaStaffDataDataSetTableAdapters.StaffTableAdapter()
        Me.TableAdapterManager = New new_Project.BrasasBrazuciaStaffDataDataSetTableAdapters.TableAdapterManager()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtPassword = New System.Windows.Forms.TextBox()
        Me.txtStaffId = New System.Windows.Forms.TextBox()
        Me.backHomeBtn = New System.Windows.Forms.Button()
        Me.showPassCbox = New System.Windows.Forms.CheckBox()
        Me.clearStaffInfoBtn = New System.Windows.Forms.Button()
        Me.loginStaffBtn = New System.Windows.Forms.Button()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        CType(Me.StaffBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BrasasBrazuciaStaffDataDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.StaffBindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'StaffBindingSource
        '
        Me.StaffBindingSource.DataMember = "Staff"
        '
        'BrasasBrazuciaStaffDataDataSet
        '
        Me.BrasasBrazuciaStaffDataDataSet.DataSetName = "BrasasBrazuciaStaffDataDataSet"
        Me.BrasasBrazuciaStaffDataDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'StaffBindingSource1
        '
        Me.StaffBindingSource1.DataMember = "Staff"
        Me.StaffBindingSource1.DataSource = Me.BrasasBrazuciaStaffDataDataSet
        '
        'StaffTableAdapter
        '
        Me.StaffTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.StaffTableAdapter = Me.StaffTableAdapter
        Me.TableAdapterManager.UpdateOrder = new_Project.BrasasBrazuciaStaffDataDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'Label2
        '
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Mont Heavy DEMO", 36.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Black
        Me.Label2.Location = New System.Drawing.Point(182, 43)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(343, 64)
        Me.Label2.TabIndex = 11
        Me.Label2.Text = "STAFF LOGIN PAGE"
        '
        'txtPassword
        '
        Me.txtPassword.Location = New System.Drawing.Point(142, 84)
        Me.txtPassword.Name = "txtPassword"
        Me.txtPassword.Size = New System.Drawing.Size(290, 20)
        Me.txtPassword.TabIndex = 6
        '
        'txtStaffId
        '
        Me.txtStaffId.Location = New System.Drawing.Point(142, 41)
        Me.txtStaffId.Name = "txtStaffId"
        Me.txtStaffId.Size = New System.Drawing.Size(290, 20)
        Me.txtStaffId.TabIndex = 6
        '
        'backHomeBtn
        '
        Me.backHomeBtn.BackColor = System.Drawing.SystemColors.GradientInactiveCaption
        Me.backHomeBtn.Font = New System.Drawing.Font("Mont Heavy DEMO", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.backHomeBtn.Location = New System.Drawing.Point(80, 399)
        Me.backHomeBtn.Name = "backHomeBtn"
        Me.backHomeBtn.Size = New System.Drawing.Size(110, 36)
        Me.backHomeBtn.TabIndex = 10
        Me.backHomeBtn.Text = "BACK"
        Me.backHomeBtn.UseVisualStyleBackColor = False
        '
        'showPassCbox
        '
        Me.showPassCbox.AutoSize = True
        Me.showPassCbox.Location = New System.Drawing.Point(142, 119)
        Me.showPassCbox.Name = "showPassCbox"
        Me.showPassCbox.Size = New System.Drawing.Size(102, 17)
        Me.showPassCbox.TabIndex = 4
        Me.showPassCbox.Text = "Show Password"
        Me.showPassCbox.UseVisualStyleBackColor = True
        '
        'clearStaffInfoBtn
        '
        Me.clearStaffInfoBtn.BackColor = System.Drawing.SystemColors.GradientInactiveCaption
        Me.clearStaffInfoBtn.Font = New System.Drawing.Font("Mont Heavy DEMO", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.clearStaffInfoBtn.Location = New System.Drawing.Point(248, 157)
        Me.clearStaffInfoBtn.Name = "clearStaffInfoBtn"
        Me.clearStaffInfoBtn.Size = New System.Drawing.Size(101, 30)
        Me.clearStaffInfoBtn.TabIndex = 3
        Me.clearStaffInfoBtn.Text = "CLEAR"
        Me.clearStaffInfoBtn.UseVisualStyleBackColor = False
        '
        'loginStaffBtn
        '
        Me.loginStaffBtn.BackColor = System.Drawing.SystemColors.GradientInactiveCaption
        Me.loginStaffBtn.Font = New System.Drawing.Font("Mont Heavy DEMO", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.loginStaffBtn.Location = New System.Drawing.Point(142, 157)
        Me.loginStaffBtn.Name = "loginStaffBtn"
        Me.loginStaffBtn.Size = New System.Drawing.Size(100, 30)
        Me.loginStaffBtn.TabIndex = 3
        Me.loginStaffBtn.Text = "ENTER"
        Me.loginStaffBtn.UseVisualStyleBackColor = False
        '
        'Label4
        '
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Mont Heavy DEMO", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.Black
        Me.Label4.Location = New System.Drawing.Point(17, 82)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(111, 35)
        Me.Label4.TabIndex = 2
        Me.Label4.Text = "PASSWORD: "
        '
        'Label3
        '
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Mont Heavy DEMO", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Black
        Me.Label3.Location = New System.Drawing.Point(38, 38)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(87, 35)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "STAFF ID :"
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Panel1.Controls.Add(Me.txtPassword)
        Me.Panel1.Controls.Add(Me.txtStaffId)
        Me.Panel1.Controls.Add(Me.showPassCbox)
        Me.Panel1.Controls.Add(Me.clearStaffInfoBtn)
        Me.Panel1.Controls.Add(Me.loginStaffBtn)
        Me.Panel1.Controls.Add(Me.Label4)
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Location = New System.Drawing.Point(80, 128)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(550, 240)
        Me.Panel1.TabIndex = 10
        '
        'staffLogin
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.ClientSize = New System.Drawing.Size(702, 447)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.backHomeBtn)
        Me.Name = "staffLogin"
        Me.Text = "staffLogin"
        CType(Me.StaffBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BrasasBrazuciaStaffDataDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.StaffBindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents StaffBindingSource As BindingSource
    Friend WithEvents BrasasBrazuciaStaffDataDataSet As BrasasBrazuciaStaffDataDataSet
    Friend WithEvents StaffBindingSource1 As BindingSource
    Friend WithEvents StaffTableAdapter As BrasasBrazuciaStaffDataDataSetTableAdapters.StaffTableAdapter
    Friend WithEvents TableAdapterManager As BrasasBrazuciaStaffDataDataSetTableAdapters.TableAdapterManager
    Friend WithEvents Label2 As Label
    Friend WithEvents txtPassword As TextBox
    Friend WithEvents txtStaffId As TextBox
    Friend WithEvents backHomeBtn As Button
    Friend WithEvents showPassCbox As CheckBox
    Friend WithEvents clearStaffInfoBtn As Button
    Friend WithEvents loginStaffBtn As Button
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Panel1 As Panel
End Class
