<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class staffInterface
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
        Me.components = New System.ComponentModel.Container()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.registerPanel = New System.Windows.Forms.Panel()
        Me.IDTextBox = New System.Windows.Forms.TextBox()
        Me.StaffBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.BrasasBrazuciaStaffDataDataSet = New new_Project.BrasasBrazuciaStaffDataDataSet()
        Me.showPassCbox = New System.Windows.Forms.CheckBox()
        Me.txtConfirm = New System.Windows.Forms.TextBox()
        Me.Staff_IDTextBox = New System.Windows.Forms.TextBox()
        Me.deleteBtn = New System.Windows.Forms.Button()
        Me.updateBtn = New System.Windows.Forms.Button()
        Me.Staff_NameTextBox = New System.Windows.Forms.TextBox()
        Me.registerBtn = New System.Windows.Forms.Button()
        Me.addBtn = New System.Windows.Forms.Button()
        Me.E_mailTextBox = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.PasswordTextBox = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.dataPanel = New System.Windows.Forms.Panel()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.StaffIDDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.StaffNameDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.EmailDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PasswordDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.IDDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.firstBtn = New System.Windows.Forms.Button()
        Me.nextBtn = New System.Windows.Forms.Button()
        Me.previousBtn = New System.Windows.Forms.Button()
        Me.lastBtn = New System.Windows.Forms.Button()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.showDataBtn = New System.Windows.Forms.Button()
        Me.returnBtn = New System.Windows.Forms.Button()
        Me.orderSummaryBtn = New System.Windows.Forms.Button()
        Me.registerNewBtn = New System.Windows.Forms.Button()
        Me.StaffTableAdapter = New new_Project.BrasasBrazuciaStaffDataDataSetTableAdapters.StaffTableAdapter()
        Me.TableAdapterManager = New new_Project.BrasasBrazuciaStaffDataDataSetTableAdapters.TableAdapterManager()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.registerPanel.SuspendLayout()
        CType(Me.StaffBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BrasasBrazuciaStaffDataDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.dataPanel.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label19
        '
        Me.Label19.BackColor = System.Drawing.Color.Transparent
        Me.Label19.Font = New System.Drawing.Font("Mont Heavy DEMO", 36.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label19.ForeColor = System.Drawing.Color.Black
        Me.Label19.Location = New System.Drawing.Point(448, 9)
        Me.Label19.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(303, 64)
        Me.Label19.TabIndex = 65
        Me.Label19.Text = "STAFF INFO"
        '
        'registerPanel
        '
        Me.registerPanel.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.registerPanel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.registerPanel.Controls.Add(Me.IDTextBox)
        Me.registerPanel.Controls.Add(Me.showPassCbox)
        Me.registerPanel.Controls.Add(Me.txtConfirm)
        Me.registerPanel.Controls.Add(Me.Staff_IDTextBox)
        Me.registerPanel.Controls.Add(Me.deleteBtn)
        Me.registerPanel.Controls.Add(Me.updateBtn)
        Me.registerPanel.Controls.Add(Me.Staff_NameTextBox)
        Me.registerPanel.Controls.Add(Me.registerBtn)
        Me.registerPanel.Controls.Add(Me.addBtn)
        Me.registerPanel.Controls.Add(Me.E_mailTextBox)
        Me.registerPanel.Controls.Add(Me.Label8)
        Me.registerPanel.Controls.Add(Me.PasswordTextBox)
        Me.registerPanel.Controls.Add(Me.Label3)
        Me.registerPanel.Controls.Add(Me.Label4)
        Me.registerPanel.Controls.Add(Me.Label1)
        Me.registerPanel.Controls.Add(Me.Label9)
        Me.registerPanel.Controls.Add(Me.Label6)
        Me.registerPanel.Controls.Add(Me.Label7)
        Me.registerPanel.Location = New System.Drawing.Point(309, 114)
        Me.registerPanel.Name = "registerPanel"
        Me.registerPanel.Size = New System.Drawing.Size(608, 360)
        Me.registerPanel.TabIndex = 71
        Me.registerPanel.Visible = False
        '
        'IDTextBox
        '
        Me.IDTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.StaffBindingSource, "ID", True))
        Me.IDTextBox.Font = New System.Drawing.Font("Mont Heavy DEMO", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.IDTextBox.Location = New System.Drawing.Point(169, 70)
        Me.IDTextBox.Name = "IDTextBox"
        Me.IDTextBox.Size = New System.Drawing.Size(197, 25)
        Me.IDTextBox.TabIndex = 83
        '
        'StaffBindingSource
        '
        Me.StaffBindingSource.DataMember = "Staff"
        Me.StaffBindingSource.DataSource = Me.BrasasBrazuciaStaffDataDataSet
        '
        'BrasasBrazuciaStaffDataDataSet
        '
        Me.BrasasBrazuciaStaffDataDataSet.DataSetName = "BrasasBrazuciaStaffDataDataSet"
        Me.BrasasBrazuciaStaffDataDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'showPassCbox
        '
        Me.showPassCbox.AutoSize = True
        Me.showPassCbox.Location = New System.Drawing.Point(169, 302)
        Me.showPassCbox.Name = "showPassCbox"
        Me.showPassCbox.Size = New System.Drawing.Size(102, 17)
        Me.showPassCbox.TabIndex = 5
        Me.showPassCbox.Text = "Show Password"
        Me.showPassCbox.UseVisualStyleBackColor = True
        '
        'txtConfirm
        '
        Me.txtConfirm.Font = New System.Drawing.Font("Mont Heavy DEMO", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtConfirm.Location = New System.Drawing.Point(169, 256)
        Me.txtConfirm.Name = "txtConfirm"
        Me.txtConfirm.Size = New System.Drawing.Size(197, 25)
        Me.txtConfirm.TabIndex = 4
        '
        'Staff_IDTextBox
        '
        Me.Staff_IDTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.StaffBindingSource, "Staff ID", True))
        Me.Staff_IDTextBox.Font = New System.Drawing.Font("Mont Heavy DEMO", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Staff_IDTextBox.Location = New System.Drawing.Point(169, 105)
        Me.Staff_IDTextBox.Name = "Staff_IDTextBox"
        Me.Staff_IDTextBox.Size = New System.Drawing.Size(197, 25)
        Me.Staff_IDTextBox.TabIndex = 76
        '
        'deleteBtn
        '
        Me.deleteBtn.BackColor = System.Drawing.SystemColors.GradientInactiveCaption
        Me.deleteBtn.Font = New System.Drawing.Font("Mont Heavy DEMO", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.deleteBtn.Location = New System.Drawing.Point(454, 213)
        Me.deleteBtn.Name = "deleteBtn"
        Me.deleteBtn.Size = New System.Drawing.Size(105, 36)
        Me.deleteBtn.TabIndex = 72
        Me.deleteBtn.Text = "DELETE"
        Me.deleteBtn.UseVisualStyleBackColor = False
        '
        'updateBtn
        '
        Me.updateBtn.BackColor = System.Drawing.SystemColors.GradientInactiveCaption
        Me.updateBtn.Font = New System.Drawing.Font("Mont Heavy DEMO", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.updateBtn.Location = New System.Drawing.Point(454, 165)
        Me.updateBtn.Name = "updateBtn"
        Me.updateBtn.Size = New System.Drawing.Size(105, 36)
        Me.updateBtn.TabIndex = 72
        Me.updateBtn.Text = "UPDATE"
        Me.updateBtn.UseVisualStyleBackColor = False
        '
        'Staff_NameTextBox
        '
        Me.Staff_NameTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.StaffBindingSource, "Staff Name", True))
        Me.Staff_NameTextBox.Font = New System.Drawing.Font("Mont Heavy DEMO", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Staff_NameTextBox.Location = New System.Drawing.Point(169, 147)
        Me.Staff_NameTextBox.Name = "Staff_NameTextBox"
        Me.Staff_NameTextBox.Size = New System.Drawing.Size(197, 25)
        Me.Staff_NameTextBox.TabIndex = 78
        '
        'registerBtn
        '
        Me.registerBtn.BackColor = System.Drawing.SystemColors.GradientInactiveCaption
        Me.registerBtn.Font = New System.Drawing.Font("Mont Heavy DEMO", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.registerBtn.Location = New System.Drawing.Point(454, 117)
        Me.registerBtn.Name = "registerBtn"
        Me.registerBtn.Size = New System.Drawing.Size(105, 36)
        Me.registerBtn.TabIndex = 72
        Me.registerBtn.Text = "REGISTER"
        Me.registerBtn.UseVisualStyleBackColor = False
        '
        'addBtn
        '
        Me.addBtn.BackColor = System.Drawing.SystemColors.GradientInactiveCaption
        Me.addBtn.Font = New System.Drawing.Font("Mont Heavy DEMO", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.addBtn.Location = New System.Drawing.Point(454, 70)
        Me.addBtn.Name = "addBtn"
        Me.addBtn.Size = New System.Drawing.Size(105, 36)
        Me.addBtn.TabIndex = 72
        Me.addBtn.Text = "ADD"
        Me.addBtn.UseVisualStyleBackColor = False
        '
        'E_mailTextBox
        '
        Me.E_mailTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.StaffBindingSource, "E-mail", True))
        Me.E_mailTextBox.Font = New System.Drawing.Font("Mont Heavy DEMO", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.E_mailTextBox.Location = New System.Drawing.Point(169, 187)
        Me.E_mailTextBox.Name = "E_mailTextBox"
        Me.E_mailTextBox.Size = New System.Drawing.Size(197, 25)
        Me.E_mailTextBox.TabIndex = 80
        '
        'Label8
        '
        Me.Label8.BackColor = System.Drawing.Color.Transparent
        Me.Label8.Font = New System.Drawing.Font("Mont Heavy DEMO", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.Black
        Me.Label8.Location = New System.Drawing.Point(4, 259)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(164, 35)
        Me.Label8.TabIndex = 2
        Me.Label8.Text = "CONFIRM PASSWORD:"
        '
        'PasswordTextBox
        '
        Me.PasswordTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.StaffBindingSource, "Password", True))
        Me.PasswordTextBox.Font = New System.Drawing.Font("Mont Heavy DEMO", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PasswordTextBox.Location = New System.Drawing.Point(169, 222)
        Me.PasswordTextBox.Name = "PasswordTextBox"
        Me.PasswordTextBox.Size = New System.Drawing.Size(197, 25)
        Me.PasswordTextBox.TabIndex = 82
        '
        'Label3
        '
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Mont Heavy DEMO", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Black
        Me.Label3.Location = New System.Drawing.Point(71, 225)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(114, 35)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "PASSWORD:"
        '
        'Label4
        '
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Mont Heavy DEMO", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.Black
        Me.Label4.Location = New System.Drawing.Point(130, 77)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(28, 20)
        Me.Label4.TabIndex = 2
        Me.Label4.Text = "ID: "
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Mont Heavy DEMO", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Black
        Me.Label1.Location = New System.Drawing.Point(89, 112)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(79, 18)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "STAFF ID: "
        '
        'Label9
        '
        Me.Label9.BackColor = System.Drawing.Color.Transparent
        Me.Label9.Font = New System.Drawing.Font("Mont Heavy DEMO", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.Color.Black
        Me.Label9.Location = New System.Drawing.Point(65, 190)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(114, 35)
        Me.Label9.TabIndex = 2
        Me.Label9.Text = "STAFF EMAIL:"
        '
        'Label6
        '
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.Label6.Font = New System.Drawing.Font("Mont Heavy DEMO", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.Black
        Me.Label6.Location = New System.Drawing.Point(65, 150)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(114, 23)
        Me.Label6.TabIndex = 2
        Me.Label6.Text = "STAFF NAME:"
        '
        'Label7
        '
        Me.Label7.BackColor = System.Drawing.Color.Transparent
        Me.Label7.Font = New System.Drawing.Font("Mont Heavy DEMO", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.Black
        Me.Label7.Location = New System.Drawing.Point(3, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(406, 36)
        Me.Label7.TabIndex = 2
        Me.Label7.Text = "Please enter staff detail for staff registration" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'dataPanel
        '
        Me.dataPanel.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.dataPanel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.dataPanel.Controls.Add(Me.DataGridView1)
        Me.dataPanel.Controls.Add(Me.firstBtn)
        Me.dataPanel.Controls.Add(Me.nextBtn)
        Me.dataPanel.Controls.Add(Me.previousBtn)
        Me.dataPanel.Controls.Add(Me.lastBtn)
        Me.dataPanel.Controls.Add(Me.Label17)
        Me.dataPanel.Location = New System.Drawing.Point(309, 114)
        Me.dataPanel.Name = "dataPanel"
        Me.dataPanel.Size = New System.Drawing.Size(608, 360)
        Me.dataPanel.TabIndex = 73
        Me.dataPanel.Visible = False
        '
        'DataGridView1
        '
        Me.DataGridView1.AutoGenerateColumns = False
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.StaffIDDataGridViewTextBoxColumn, Me.StaffNameDataGridViewTextBoxColumn, Me.EmailDataGridViewTextBoxColumn, Me.PasswordDataGridViewTextBoxColumn, Me.IDDataGridViewTextBoxColumn})
        Me.DataGridView1.DataSource = Me.StaffBindingSource
        Me.DataGridView1.Location = New System.Drawing.Point(17, 58)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(543, 193)
        Me.DataGridView1.TabIndex = 77
        '
        'StaffIDDataGridViewTextBoxColumn
        '
        Me.StaffIDDataGridViewTextBoxColumn.DataPropertyName = "Staff ID"
        Me.StaffIDDataGridViewTextBoxColumn.HeaderText = "Staff ID"
        Me.StaffIDDataGridViewTextBoxColumn.Name = "StaffIDDataGridViewTextBoxColumn"
        '
        'StaffNameDataGridViewTextBoxColumn
        '
        Me.StaffNameDataGridViewTextBoxColumn.DataPropertyName = "Staff Name"
        Me.StaffNameDataGridViewTextBoxColumn.HeaderText = "Staff Name"
        Me.StaffNameDataGridViewTextBoxColumn.Name = "StaffNameDataGridViewTextBoxColumn"
        '
        'EmailDataGridViewTextBoxColumn
        '
        Me.EmailDataGridViewTextBoxColumn.DataPropertyName = "E-mail"
        Me.EmailDataGridViewTextBoxColumn.HeaderText = "E-mail"
        Me.EmailDataGridViewTextBoxColumn.Name = "EmailDataGridViewTextBoxColumn"
        '
        'PasswordDataGridViewTextBoxColumn
        '
        Me.PasswordDataGridViewTextBoxColumn.DataPropertyName = "Password"
        Me.PasswordDataGridViewTextBoxColumn.HeaderText = "Password"
        Me.PasswordDataGridViewTextBoxColumn.Name = "PasswordDataGridViewTextBoxColumn"
        '
        'IDDataGridViewTextBoxColumn
        '
        Me.IDDataGridViewTextBoxColumn.DataPropertyName = "ID"
        Me.IDDataGridViewTextBoxColumn.HeaderText = "ID"
        Me.IDDataGridViewTextBoxColumn.Name = "IDDataGridViewTextBoxColumn"
        '
        'firstBtn
        '
        Me.firstBtn.BackColor = System.Drawing.SystemColors.GradientInactiveCaption
        Me.firstBtn.Font = New System.Drawing.Font("Mont Heavy DEMO", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.firstBtn.Location = New System.Drawing.Point(23, 292)
        Me.firstBtn.Name = "firstBtn"
        Me.firstBtn.Size = New System.Drawing.Size(110, 36)
        Me.firstBtn.TabIndex = 73
        Me.firstBtn.Text = "FIRST"
        Me.firstBtn.UseVisualStyleBackColor = False
        '
        'nextBtn
        '
        Me.nextBtn.BackColor = System.Drawing.SystemColors.GradientInactiveCaption
        Me.nextBtn.Font = New System.Drawing.Font("Mont Heavy DEMO", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.nextBtn.Location = New System.Drawing.Point(165, 292)
        Me.nextBtn.Name = "nextBtn"
        Me.nextBtn.Size = New System.Drawing.Size(110, 36)
        Me.nextBtn.TabIndex = 74
        Me.nextBtn.Text = "NEXT"
        Me.nextBtn.UseVisualStyleBackColor = False
        '
        'previousBtn
        '
        Me.previousBtn.BackColor = System.Drawing.SystemColors.GradientInactiveCaption
        Me.previousBtn.Font = New System.Drawing.Font("Mont Heavy DEMO", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.previousBtn.Location = New System.Drawing.Point(307, 292)
        Me.previousBtn.Name = "previousBtn"
        Me.previousBtn.Size = New System.Drawing.Size(110, 36)
        Me.previousBtn.TabIndex = 75
        Me.previousBtn.Text = "PREVIOUS"
        Me.previousBtn.UseVisualStyleBackColor = False
        '
        'lastBtn
        '
        Me.lastBtn.BackColor = System.Drawing.SystemColors.GradientInactiveCaption
        Me.lastBtn.Font = New System.Drawing.Font("Mont Heavy DEMO", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lastBtn.Location = New System.Drawing.Point(449, 292)
        Me.lastBtn.Name = "lastBtn"
        Me.lastBtn.Size = New System.Drawing.Size(111, 36)
        Me.lastBtn.TabIndex = 76
        Me.lastBtn.Text = "LAST"
        Me.lastBtn.UseVisualStyleBackColor = False
        '
        'Label17
        '
        Me.Label17.BackColor = System.Drawing.Color.Transparent
        Me.Label17.Font = New System.Drawing.Font("Mont Heavy DEMO", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label17.ForeColor = System.Drawing.Color.Black
        Me.Label17.Location = New System.Drawing.Point(11, 10)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(406, 36)
        Me.Label17.TabIndex = 2
        Me.Label17.Text = "BRASAS BRAZUCA STAFF DATA"
        '
        'showDataBtn
        '
        Me.showDataBtn.BackColor = System.Drawing.SystemColors.GradientInactiveCaption
        Me.showDataBtn.Font = New System.Drawing.Font("Mont Heavy DEMO", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.showDataBtn.Location = New System.Drawing.Point(35, 130)
        Me.showDataBtn.Name = "showDataBtn"
        Me.showDataBtn.Size = New System.Drawing.Size(129, 55)
        Me.showDataBtn.TabIndex = 72
        Me.showDataBtn.Text = "SHOW STAFF DATA"
        Me.showDataBtn.UseVisualStyleBackColor = False
        '
        'returnBtn
        '
        Me.returnBtn.BackColor = System.Drawing.SystemColors.GradientInactiveCaption
        Me.returnBtn.Font = New System.Drawing.Font("Mont Heavy DEMO", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.returnBtn.Location = New System.Drawing.Point(35, 357)
        Me.returnBtn.Name = "returnBtn"
        Me.returnBtn.Size = New System.Drawing.Size(129, 52)
        Me.returnBtn.TabIndex = 72
        Me.returnBtn.Text = "RETURN"
        Me.returnBtn.UseVisualStyleBackColor = False
        '
        'orderSummaryBtn
        '
        Me.orderSummaryBtn.BackColor = System.Drawing.SystemColors.GradientInactiveCaption
        Me.orderSummaryBtn.Font = New System.Drawing.Font("Mont Heavy DEMO", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.orderSummaryBtn.Location = New System.Drawing.Point(35, 282)
        Me.orderSummaryBtn.Name = "orderSummaryBtn"
        Me.orderSummaryBtn.Size = New System.Drawing.Size(129, 55)
        Me.orderSummaryBtn.TabIndex = 72
        Me.orderSummaryBtn.Text = "CUSTOMER ORDER REPORT"
        Me.orderSummaryBtn.UseVisualStyleBackColor = False
        '
        'registerNewBtn
        '
        Me.registerNewBtn.BackColor = System.Drawing.SystemColors.GradientInactiveCaption
        Me.registerNewBtn.Font = New System.Drawing.Font("Mont Heavy DEMO", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.registerNewBtn.Location = New System.Drawing.Point(35, 201)
        Me.registerNewBtn.Name = "registerNewBtn"
        Me.registerNewBtn.Size = New System.Drawing.Size(129, 60)
        Me.registerNewBtn.TabIndex = 72
        Me.registerNewBtn.Text = "REGISTER NEW STAFF"
        Me.registerNewBtn.UseVisualStyleBackColor = False
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
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Panel1.Controls.Add(Me.showDataBtn)
        Me.Panel1.Controls.Add(Me.returnBtn)
        Me.Panel1.Controls.Add(Me.registerNewBtn)
        Me.Panel1.Controls.Add(Me.orderSummaryBtn)
        Me.Panel1.Location = New System.Drawing.Point(-4, -5)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(200, 521)
        Me.Panel1.TabIndex = 74
        '
        'staffInterface
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.ClientSize = New System.Drawing.Size(981, 513)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Label19)
        Me.Controls.Add(Me.registerPanel)
        Me.Controls.Add(Me.dataPanel)
        Me.Name = "staffInterface"
        Me.Text = "staffInterface"
        Me.registerPanel.ResumeLayout(False)
        Me.registerPanel.PerformLayout()
        CType(Me.StaffBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BrasasBrazuciaStaffDataDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.dataPanel.ResumeLayout(False)
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Label19 As Label
    Friend WithEvents registerPanel As Panel
    Friend WithEvents txtConfirm As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents showPassCbox As CheckBox
    Friend WithEvents deleteBtn As Button
    Friend WithEvents updateBtn As Button
    Friend WithEvents registerBtn As Button
    Friend WithEvents addBtn As Button
    Friend WithEvents showDataBtn As Button
    Friend WithEvents returnBtn As Button
    Friend WithEvents orderSummaryBtn As Button
    Friend WithEvents registerNewBtn As Button
    Friend WithEvents dataPanel As Panel
    Friend WithEvents Label17 As Label
    Friend WithEvents BrasasBrazuciaStaffDataDataSet As BrasasBrazuciaStaffDataDataSet
    Friend WithEvents StaffBindingSource As BindingSource
    Friend WithEvents StaffTableAdapter As BrasasBrazuciaStaffDataDataSetTableAdapters.StaffTableAdapter
    Friend WithEvents TableAdapterManager As BrasasBrazuciaStaffDataDataSetTableAdapters.TableAdapterManager
    Friend WithEvents firstBtn As Button
    Friend WithEvents nextBtn As Button
    Friend WithEvents previousBtn As Button
    Friend WithEvents lastBtn As Button
    Friend WithEvents Staff_IDTextBox As TextBox
    Friend WithEvents Staff_NameTextBox As TextBox
    Friend WithEvents E_mailTextBox As TextBox
    Friend WithEvents PasswordTextBox As TextBox
    Friend WithEvents IDTextBox As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents StaffIDDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents StaffNameDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents EmailDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents PasswordDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents IDDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents Panel1 As Panel
End Class
