<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class orderForm
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(orderForm))
        Me.Label3 = New System.Windows.Forms.Label()
        Me.pdPrint = New System.Drawing.Printing.PrintDocument()
        Me.previousBtn = New System.Windows.Forms.Button()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.setBtn = New System.Windows.Forms.Button()
        Me.alaCarteBtn = New System.Windows.Forms.Button()
        Me.PrintPreviewDialog1 = New System.Windows.Forms.PrintPreviewDialog()
        Me.dispRecBtn = New System.Windows.Forms.Button()
        Me.exitBtn = New System.Windows.Forms.Button()
        Me.printReceiptBtn = New System.Windows.Forms.Button()
        Me.clearBtn = New System.Windows.Forms.Button()
        Me.lblAddress = New System.Windows.Forms.Label()
        Me.lblFoodName = New System.Windows.Forms.Label()
        Me.txtAddress = New System.Windows.Forms.TextBox()
        Me.selfPickRadBtn = New System.Windows.Forms.RadioButton()
        Me.codRadBtn = New System.Windows.Forms.RadioButton()
        Me.proceedBtn = New System.Windows.Forms.Button()
        Me.txtTotalOrder = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.txtPhone = New System.Windows.Forms.TextBox()
        Me.txtIc = New System.Windows.Forms.TextBox()
        Me.txtName = New System.Windows.Forms.TextBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtEmail = New System.Windows.Forms.TextBox()
        Me.cashradBtn = New System.Windows.Forms.RadioButton()
        Me.paymentMethodRadBtnBox = New System.Windows.Forms.GroupBox()
        Me.cardRadBtn = New System.Windows.Forms.RadioButton()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.deliveryCbox = New System.Windows.Forms.GroupBox()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.picPanel = New System.Windows.Forms.Panel()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.ribeyePicBox = New System.Windows.Forms.PictureBox()
        Me.cheeseBreadPicBox = New System.Windows.Forms.PictureBox()
        Me.tortillaPicBox = New System.Windows.Forms.PictureBox()
        Me.cappuchinoPicBox = New System.Windows.Forms.PictureBox()
        Me.rumpSteakPicBox = New System.Windows.Forms.PictureBox()
        Me.arabiataPicBox = New System.Windows.Forms.PictureBox()
        Me.feijoadaPicBox = New System.Windows.Forms.PictureBox()
        Me.caesaSaladPicBox = New System.Windows.Forms.PictureBox()
        Me.mojittoPicBox = New System.Windows.Forms.PictureBox()
        Me.salmonPicBox = New System.Windows.Forms.PictureBox()
        Me.moquecaPicBox = New System.Windows.Forms.PictureBox()
        Me.jerkyBeefPicBox = New System.Windows.Forms.PictureBox()
        Me.coconutPicBox = New System.Windows.Forms.PictureBox()
        Me.lemonadePicBox = New System.Windows.Forms.PictureBox()
        Me.americanoPicBox = New System.Windows.Forms.PictureBox()
        Me.mangoPicBox = New System.Windows.Forms.PictureBox()
        Me.skyJuicePicBox = New System.Windows.Forms.PictureBox()
        Me.matchaPicBox = New System.Windows.Forms.PictureBox()
        Me.brigaderiosPicBox = New System.Windows.Forms.PictureBox()
        Me.coconutChkBox = New System.Windows.Forms.CheckBox()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.txtRumpsteak = New System.Windows.Forms.TextBox()
        Me.txtSalmon = New System.Windows.Forms.TextBox()
        Me.addRumpsteakBtn = New System.Windows.Forms.Button()
        Me.addSalmonBtn = New System.Windows.Forms.Button()
        Me.minusRumpsteakBtn = New System.Windows.Forms.Button()
        Me.addRibeyeBtn = New System.Windows.Forms.Button()
        Me.minusSalmonBtn = New System.Windows.Forms.Button()
        Me.addTortillaBtn = New System.Windows.Forms.Button()
        Me.minusRibeyeBtn = New System.Windows.Forms.Button()
        Me.txtRibeye = New System.Windows.Forms.TextBox()
        Me.minusTortillaBtn = New System.Windows.Forms.Button()
        Me.lblRumpSteak = New System.Windows.Forms.Label()
        Me.txtTortilla = New System.Windows.Forms.TextBox()
        Me.lblSalmon = New System.Windows.Forms.Label()
        Me.lblRibeye = New System.Windows.Forms.Label()
        Me.lblTortilla = New System.Windows.Forms.Label()
        Me.drinkGpBox = New System.Windows.Forms.GroupBox()
        Me.creamyMangoChkBox = New System.Windows.Forms.CheckBox()
        Me.skyJuiceChkBox = New System.Windows.Forms.CheckBox()
        Me.americanoChkBox = New System.Windows.Forms.CheckBox()
        Me.mojittoChkBox = New System.Windows.Forms.CheckBox()
        Me.matchaChkBox = New System.Windows.Forms.CheckBox()
        Me.lemonadeChkBox = New System.Windows.Forms.CheckBox()
        Me.cappuchinoChkBox = New System.Windows.Forms.CheckBox()
        Me.comboSetPanel = New System.Windows.Forms.Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.addCheesebreadBtn = New System.Windows.Forms.Button()
        Me.PictureBox10 = New System.Windows.Forms.PictureBox()
        Me.addArabiataBtn = New System.Windows.Forms.Button()
        Me.addCaesasaladBtn = New System.Windows.Forms.Button()
        Me.addJerkybeefBtn = New System.Windows.Forms.Button()
        Me.addBrigaderiosBtn = New System.Windows.Forms.Button()
        Me.addFeijoadaBtn = New System.Windows.Forms.Button()
        Me.minusCheeseBread = New System.Windows.Forms.Button()
        Me.minusArabiataBtn = New System.Windows.Forms.Button()
        Me.minusCaesasaladBtn = New System.Windows.Forms.Button()
        Me.minusJerkyBeefBtn = New System.Windows.Forms.Button()
        Me.minusBrigaderiosBtn = New System.Windows.Forms.Button()
        Me.addMoquecaBtn = New System.Windows.Forms.Button()
        Me.minusFeijoadaBtn = New System.Windows.Forms.Button()
        Me.txtCheesebread = New System.Windows.Forms.TextBox()
        Me.minusMoquecaBtn = New System.Windows.Forms.Button()
        Me.lblCheeseBread = New System.Windows.Forms.Label()
        Me.txtArabiata = New System.Windows.Forms.TextBox()
        Me.lblArabiata = New System.Windows.Forms.Label()
        Me.txtMoqueca = New System.Windows.Forms.TextBox()
        Me.txtFeijoada = New System.Windows.Forms.TextBox()
        Me.lblCaesasalad = New System.Windows.Forms.Label()
        Me.txtCaesasalad = New System.Windows.Forms.TextBox()
        Me.lblJerkyBeef = New System.Windows.Forms.Label()
        Me.txtBrigaderios = New System.Windows.Forms.TextBox()
        Me.lblBrigaderios = New System.Windows.Forms.Label()
        Me.txtJerkybeef = New System.Windows.Forms.TextBox()
        Me.lblFeijoada = New System.Windows.Forms.Label()
        Me.lblMoqueca = New System.Windows.Forms.Label()
        Me.alacarteSetPanel = New System.Windows.Forms.Panel()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtOrder = New System.Windows.Forms.Label()
        Me.paymentMethodRadBtnBox.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.deliveryCbox.SuspendLayout()
        Me.picPanel.SuspendLayout()
        CType(Me.ribeyePicBox, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cheeseBreadPicBox, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.tortillaPicBox, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cappuchinoPicBox, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.rumpSteakPicBox, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.arabiataPicBox, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.feijoadaPicBox, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.caesaSaladPicBox, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.mojittoPicBox, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.salmonPicBox, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.moquecaPicBox, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.jerkyBeefPicBox, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.coconutPicBox, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lemonadePicBox, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.americanoPicBox, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.mangoPicBox, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.skyJuicePicBox, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.matchaPicBox, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.brigaderiosPicBox, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel2.SuspendLayout()
        Me.drinkGpBox.SuspendLayout()
        Me.comboSetPanel.SuspendLayout()
        Me.Panel4.SuspendLayout()
        CType(Me.PictureBox10, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.alacarteSetPanel.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label3
        '
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Mont Heavy DEMO", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Black
        Me.Label3.Location = New System.Drawing.Point(133, 5)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(172, 32)
        Me.Label3.TabIndex = 50
        Me.Label3.Text = "Picture Preview"
        '
        'pdPrint
        '
        '
        'previousBtn
        '
        Me.previousBtn.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.previousBtn.Font = New System.Drawing.Font("Mont Heavy DEMO", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.previousBtn.Location = New System.Drawing.Point(8, 745)
        Me.previousBtn.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.previousBtn.Name = "previousBtn"
        Me.previousBtn.Size = New System.Drawing.Size(128, 42)
        Me.previousBtn.TabIndex = 57
        Me.previousBtn.Text = "RETURN"
        Me.previousBtn.UseVisualStyleBackColor = False
        '
        'Label19
        '
        Me.Label19.BackColor = System.Drawing.Color.Transparent
        Me.Label19.Font = New System.Drawing.Font("Mont Heavy DEMO", 48.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label19.ForeColor = System.Drawing.Color.Black
        Me.Label19.Location = New System.Drawing.Point(574, 9)
        Me.Label19.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(412, 80)
        Me.Label19.TabIndex = 63
        Me.Label19.Text = "Order Form"
        '
        'setBtn
        '
        Me.setBtn.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.setBtn.Font = New System.Drawing.Font("Mont Heavy DEMO", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.setBtn.Location = New System.Drawing.Point(61, 570)
        Me.setBtn.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.setBtn.Name = "setBtn"
        Me.setBtn.Size = New System.Drawing.Size(128, 33)
        Me.setBtn.TabIndex = 34
        Me.setBtn.Text = "COMBO SET"
        Me.setBtn.UseVisualStyleBackColor = False
        '
        'alaCarteBtn
        '
        Me.alaCarteBtn.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.alaCarteBtn.Font = New System.Drawing.Font("Mont Heavy DEMO", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.alaCarteBtn.Location = New System.Drawing.Point(244, 570)
        Me.alaCarteBtn.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.alaCarteBtn.Name = "alaCarteBtn"
        Me.alaCarteBtn.Size = New System.Drawing.Size(128, 33)
        Me.alaCarteBtn.TabIndex = 37
        Me.alaCarteBtn.Text = "ALA CARTE"
        Me.alaCarteBtn.UseVisualStyleBackColor = False
        '
        'PrintPreviewDialog1
        '
        Me.PrintPreviewDialog1.AutoScrollMargin = New System.Drawing.Size(0, 0)
        Me.PrintPreviewDialog1.AutoScrollMinSize = New System.Drawing.Size(0, 0)
        Me.PrintPreviewDialog1.ClientSize = New System.Drawing.Size(400, 300)
        Me.PrintPreviewDialog1.Document = Me.pdPrint
        Me.PrintPreviewDialog1.Enabled = True
        Me.PrintPreviewDialog1.Icon = CType(resources.GetObject("PrintPreviewDialog1.Icon"), System.Drawing.Icon)
        Me.PrintPreviewDialog1.Name = "PrintPreviewDialog1"
        Me.PrintPreviewDialog1.Visible = False
        '
        'dispRecBtn
        '
        Me.dispRecBtn.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.dispRecBtn.Font = New System.Drawing.Font("Mont Heavy DEMO", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dispRecBtn.Location = New System.Drawing.Point(1384, 620)
        Me.dispRecBtn.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.dispRecBtn.Name = "dispRecBtn"
        Me.dispRecBtn.Size = New System.Drawing.Size(128, 50)
        Me.dispRecBtn.TabIndex = 61
        Me.dispRecBtn.Text = "Display Receipt"
        Me.dispRecBtn.UseVisualStyleBackColor = False
        '
        'exitBtn
        '
        Me.exitBtn.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.exitBtn.Font = New System.Drawing.Font("Mont Heavy DEMO", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.exitBtn.Location = New System.Drawing.Point(1384, 677)
        Me.exitBtn.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.exitBtn.Name = "exitBtn"
        Me.exitBtn.Size = New System.Drawing.Size(128, 45)
        Me.exitBtn.TabIndex = 60
        Me.exitBtn.Text = "Exit"
        Me.exitBtn.UseVisualStyleBackColor = False
        '
        'printReceiptBtn
        '
        Me.printReceiptBtn.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.printReceiptBtn.Font = New System.Drawing.Font("Mont Heavy DEMO", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.printReceiptBtn.Location = New System.Drawing.Point(1384, 568)
        Me.printReceiptBtn.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.printReceiptBtn.Name = "printReceiptBtn"
        Me.printReceiptBtn.Size = New System.Drawing.Size(128, 44)
        Me.printReceiptBtn.TabIndex = 62
        Me.printReceiptBtn.Text = "Print Receipt"
        Me.printReceiptBtn.UseVisualStyleBackColor = False
        '
        'clearBtn
        '
        Me.clearBtn.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.clearBtn.Font = New System.Drawing.Font("Mont Heavy DEMO", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.clearBtn.Location = New System.Drawing.Point(1232, 568)
        Me.clearBtn.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.clearBtn.Name = "clearBtn"
        Me.clearBtn.Size = New System.Drawing.Size(128, 44)
        Me.clearBtn.TabIndex = 59
        Me.clearBtn.Text = "Clear Order"
        Me.clearBtn.UseVisualStyleBackColor = False
        '
        'lblAddress
        '
        Me.lblAddress.BackColor = System.Drawing.Color.Transparent
        Me.lblAddress.Font = New System.Drawing.Font("Mont Heavy DEMO", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAddress.ForeColor = System.Drawing.Color.Black
        Me.lblAddress.Location = New System.Drawing.Point(4, 474)
        Me.lblAddress.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblAddress.Name = "lblAddress"
        Me.lblAddress.Size = New System.Drawing.Size(154, 35)
        Me.lblAddress.TabIndex = 2
        Me.lblAddress.Text = "CUSTOMER ADDRESS:"
        Me.lblAddress.Visible = False
        '
        'lblFoodName
        '
        Me.lblFoodName.BackColor = System.Drawing.SystemColors.HighlightText
        Me.lblFoodName.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblFoodName.Cursor = System.Windows.Forms.Cursors.Default
        Me.lblFoodName.Font = New System.Drawing.Font("Mont Heavy DEMO", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFoodName.ForeColor = System.Drawing.SystemColors.ControlText
        Me.lblFoodName.Location = New System.Drawing.Point(18, 309)
        Me.lblFoodName.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.lblFoodName.Name = "lblFoodName"
        Me.lblFoodName.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblFoodName.Size = New System.Drawing.Size(387, 68)
        Me.lblFoodName.TabIndex = 49
        Me.lblFoodName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'txtAddress
        '
        Me.txtAddress.Location = New System.Drawing.Point(164, 476)
        Me.txtAddress.Multiline = True
        Me.txtAddress.Name = "txtAddress"
        Me.txtAddress.Size = New System.Drawing.Size(280, 42)
        Me.txtAddress.TabIndex = 3
        Me.txtAddress.Visible = False
        '
        'selfPickRadBtn
        '
        Me.selfPickRadBtn.AutoSize = True
        Me.selfPickRadBtn.Location = New System.Drawing.Point(16, 52)
        Me.selfPickRadBtn.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.selfPickRadBtn.Name = "selfPickRadBtn"
        Me.selfPickRadBtn.Size = New System.Drawing.Size(126, 17)
        Me.selfPickRadBtn.TabIndex = 0
        Me.selfPickRadBtn.TabStop = True
        Me.selfPickRadBtn.Text = "Self Pickup (RM0.00)" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        Me.selfPickRadBtn.UseVisualStyleBackColor = True
        '
        'codRadBtn
        '
        Me.codRadBtn.AutoSize = True
        Me.codRadBtn.Location = New System.Drawing.Point(16, 29)
        Me.codRadBtn.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.codRadBtn.Name = "codRadBtn"
        Me.codRadBtn.Size = New System.Drawing.Size(110, 17)
        Me.codRadBtn.TabIndex = 0
        Me.codRadBtn.TabStop = True
        Me.codRadBtn.Text = "Delivery (RM7.00)"
        Me.codRadBtn.UseVisualStyleBackColor = True
        '
        'proceedBtn
        '
        Me.proceedBtn.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.proceedBtn.Font = New System.Drawing.Font("Mont Heavy DEMO", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.proceedBtn.Location = New System.Drawing.Point(1093, 568)
        Me.proceedBtn.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.proceedBtn.Name = "proceedBtn"
        Me.proceedBtn.Size = New System.Drawing.Size(128, 44)
        Me.proceedBtn.TabIndex = 55
        Me.proceedBtn.Text = "Proceed Order"
        Me.proceedBtn.UseVisualStyleBackColor = False
        '
        'txtTotalOrder
        '
        Me.txtTotalOrder.BackColor = System.Drawing.SystemColors.HighlightText
        Me.txtTotalOrder.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.txtTotalOrder.Cursor = System.Windows.Forms.Cursors.Default
        Me.txtTotalOrder.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold)
        Me.txtTotalOrder.ForeColor = System.Drawing.SystemColors.ControlText
        Me.txtTotalOrder.Location = New System.Drawing.Point(1195, 677)
        Me.txtTotalOrder.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.txtTotalOrder.Name = "txtTotalOrder"
        Me.txtTotalOrder.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtTotalOrder.Size = New System.Drawing.Size(165, 33)
        Me.txtTotalOrder.TabIndex = 68
        Me.txtTotalOrder.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label14
        '
        Me.Label14.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.Label14.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label14.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold)
        Me.Label14.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label14.Location = New System.Drawing.Point(1089, 672)
        Me.Label14.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.Label14.Name = "Label14"
        Me.Label14.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label14.Size = New System.Drawing.Size(96, 43)
        Me.Label14.TabIndex = 67
        Me.Label14.Text = "Total Order After Tax"
        Me.Label14.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label10
        '
        Me.Label10.BackColor = System.Drawing.Color.Transparent
        Me.Label10.Font = New System.Drawing.Font("Mont Heavy DEMO", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.ForeColor = System.Drawing.Color.Black
        Me.Label10.Location = New System.Drawing.Point(61, 11)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(348, 41)
        Me.Label10.TabIndex = 71
        Me.Label10.Text = "CUSTOMER DETAIL"
        '
        'txtPhone
        '
        Me.txtPhone.Location = New System.Drawing.Point(164, 146)
        Me.txtPhone.Name = "txtPhone"
        Me.txtPhone.Size = New System.Drawing.Size(280, 20)
        Me.txtPhone.TabIndex = 4
        '
        'txtIc
        '
        Me.txtIc.Location = New System.Drawing.Point(164, 107)
        Me.txtIc.Name = "txtIc"
        Me.txtIc.Size = New System.Drawing.Size(280, 20)
        Me.txtIc.TabIndex = 4
        '
        'txtName
        '
        Me.txtName.Location = New System.Drawing.Point(164, 74)
        Me.txtName.Name = "txtName"
        Me.txtName.Size = New System.Drawing.Size(280, 20)
        Me.txtName.TabIndex = 4
        '
        'Label12
        '
        Me.Label12.BackColor = System.Drawing.Color.Transparent
        Me.Label12.Font = New System.Drawing.Font("Mont Heavy DEMO", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.ForeColor = System.Drawing.Color.Black
        Me.Label12.Location = New System.Drawing.Point(116, 534)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(246, 26)
        Me.Label12.TabIndex = 2
        Me.Label12.Text = "CHOOSE YOUR MENU TYPE:"
        '
        'Label11
        '
        Me.Label11.BackColor = System.Drawing.Color.Transparent
        Me.Label11.Font = New System.Drawing.Font("Mont Heavy DEMO", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.ForeColor = System.Drawing.Color.Black
        Me.Label11.Location = New System.Drawing.Point(7, 233)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(137, 35)
        Me.Label11.TabIndex = 2
        Me.Label11.Text = "PAYMENT METHOD:" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'Label9
        '
        Me.Label9.BackColor = System.Drawing.Color.Transparent
        Me.Label9.Font = New System.Drawing.Font("Mont Heavy DEMO", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.Color.Black
        Me.Label9.Location = New System.Drawing.Point(11, 188)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(137, 35)
        Me.Label9.TabIndex = 2
        Me.Label9.Text = "CUSTOMER EMAIL:"
        '
        'Label5
        '
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Font = New System.Drawing.Font("Mont Heavy DEMO", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.Black
        Me.Label5.Location = New System.Drawing.Point(25, 146)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(134, 23)
        Me.Label5.TabIndex = 2
        Me.Label5.Text = "PHONE NUMBER:"
        '
        'Label4
        '
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Mont Heavy DEMO", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.Black
        Me.Label4.Location = New System.Drawing.Point(57, 108)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(101, 21)
        Me.Label4.TabIndex = 2
        Me.Label4.Text = "IC NUMBER:"
        '
        'Label6
        '
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.Label6.Font = New System.Drawing.Font("Mont Heavy DEMO", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.Black
        Me.Label6.Location = New System.Drawing.Point(12, 74)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(138, 20)
        Me.Label6.TabIndex = 2
        Me.Label6.Text = "CUSTOMER NAME:"
        '
        'txtEmail
        '
        Me.txtEmail.Location = New System.Drawing.Point(164, 188)
        Me.txtEmail.Name = "txtEmail"
        Me.txtEmail.Size = New System.Drawing.Size(280, 20)
        Me.txtEmail.TabIndex = 4
        '
        'cashradBtn
        '
        Me.cashradBtn.AutoSize = True
        Me.cashradBtn.Location = New System.Drawing.Point(8, 21)
        Me.cashradBtn.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.cashradBtn.Name = "cashradBtn"
        Me.cashradBtn.Size = New System.Drawing.Size(49, 17)
        Me.cashradBtn.TabIndex = 0
        Me.cashradBtn.TabStop = True
        Me.cashradBtn.Text = "Cash"
        Me.cashradBtn.UseVisualStyleBackColor = True
        '
        'paymentMethodRadBtnBox
        '
        Me.paymentMethodRadBtnBox.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.paymentMethodRadBtnBox.Controls.Add(Me.cardRadBtn)
        Me.paymentMethodRadBtnBox.Controls.Add(Me.cashradBtn)
        Me.paymentMethodRadBtnBox.Location = New System.Drawing.Point(164, 233)
        Me.paymentMethodRadBtnBox.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.paymentMethodRadBtnBox.Name = "paymentMethodRadBtnBox"
        Me.paymentMethodRadBtnBox.Padding = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.paymentMethodRadBtnBox.Size = New System.Drawing.Size(207, 98)
        Me.paymentMethodRadBtnBox.TabIndex = 15
        Me.paymentMethodRadBtnBox.TabStop = False
        Me.paymentMethodRadBtnBox.Text = "Payment Method:"
        '
        'cardRadBtn
        '
        Me.cardRadBtn.AutoSize = True
        Me.cardRadBtn.Location = New System.Drawing.Point(8, 44)
        Me.cardRadBtn.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.cardRadBtn.Name = "cardRadBtn"
        Me.cardRadBtn.Size = New System.Drawing.Size(107, 17)
        Me.cardRadBtn.TabIndex = 0
        Me.cardRadBtn.TabStop = True
        Me.cardRadBtn.Text = "Credit/Debit Card"
        Me.cardRadBtn.UseVisualStyleBackColor = True
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel1.Controls.Add(Me.txtAddress)
        Me.Panel1.Controls.Add(Me.lblAddress)
        Me.Panel1.Controls.Add(Me.deliveryCbox)
        Me.Panel1.Controls.Add(Me.Label16)
        Me.Panel1.Controls.Add(Me.paymentMethodRadBtnBox)
        Me.Panel1.Controls.Add(Me.txtEmail)
        Me.Panel1.Controls.Add(Me.txtPhone)
        Me.Panel1.Controls.Add(Me.txtIc)
        Me.Panel1.Controls.Add(Me.txtName)
        Me.Panel1.Controls.Add(Me.Label12)
        Me.Panel1.Controls.Add(Me.Label11)
        Me.Panel1.Controls.Add(Me.Label9)
        Me.Panel1.Controls.Add(Me.Label5)
        Me.Panel1.Controls.Add(Me.Label4)
        Me.Panel1.Controls.Add(Me.Label6)
        Me.Panel1.Controls.Add(Me.setBtn)
        Me.Panel1.Controls.Add(Me.Label10)
        Me.Panel1.Controls.Add(Me.alaCarteBtn)
        Me.Panel1.Location = New System.Drawing.Point(8, 106)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(465, 622)
        Me.Panel1.TabIndex = 70
        '
        'deliveryCbox
        '
        Me.deliveryCbox.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.deliveryCbox.Controls.Add(Me.selfPickRadBtn)
        Me.deliveryCbox.Controls.Add(Me.codRadBtn)
        Me.deliveryCbox.Location = New System.Drawing.Point(164, 353)
        Me.deliveryCbox.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.deliveryCbox.Name = "deliveryCbox"
        Me.deliveryCbox.Padding = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.deliveryCbox.Size = New System.Drawing.Size(209, 108)
        Me.deliveryCbox.TabIndex = 15
        Me.deliveryCbox.TabStop = False
        Me.deliveryCbox.Text = "Choose your delivery method"
        '
        'Label16
        '
        Me.Label16.BackColor = System.Drawing.Color.Transparent
        Me.Label16.Font = New System.Drawing.Font("Mont Heavy DEMO", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label16.ForeColor = System.Drawing.Color.Black
        Me.Label16.Location = New System.Drawing.Point(11, 357)
        Me.Label16.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(135, 30)
        Me.Label16.TabIndex = 13
        Me.Label16.Text = "DELIVERY METHOD:"
        '
        'picPanel
        '
        Me.picPanel.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.picPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.picPanel.Controls.Add(Me.Label13)
        Me.picPanel.Controls.Add(Me.Label7)
        Me.picPanel.Controls.Add(Me.ribeyePicBox)
        Me.picPanel.Controls.Add(Me.cheeseBreadPicBox)
        Me.picPanel.Controls.Add(Me.tortillaPicBox)
        Me.picPanel.Controls.Add(Me.cappuchinoPicBox)
        Me.picPanel.Controls.Add(Me.rumpSteakPicBox)
        Me.picPanel.Controls.Add(Me.arabiataPicBox)
        Me.picPanel.Controls.Add(Me.feijoadaPicBox)
        Me.picPanel.Controls.Add(Me.caesaSaladPicBox)
        Me.picPanel.Controls.Add(Me.mojittoPicBox)
        Me.picPanel.Controls.Add(Me.salmonPicBox)
        Me.picPanel.Controls.Add(Me.moquecaPicBox)
        Me.picPanel.Controls.Add(Me.jerkyBeefPicBox)
        Me.picPanel.Controls.Add(Me.coconutPicBox)
        Me.picPanel.Controls.Add(Me.lemonadePicBox)
        Me.picPanel.Controls.Add(Me.americanoPicBox)
        Me.picPanel.Controls.Add(Me.mangoPicBox)
        Me.picPanel.Controls.Add(Me.skyJuicePicBox)
        Me.picPanel.Controls.Add(Me.matchaPicBox)
        Me.picPanel.Controls.Add(Me.brigaderiosPicBox)
        Me.picPanel.Controls.Add(Me.Label3)
        Me.picPanel.Controls.Add(Me.lblFoodName)
        Me.picPanel.Location = New System.Drawing.Point(1093, 104)
        Me.picPanel.Name = "picPanel"
        Me.picPanel.Size = New System.Drawing.Size(426, 423)
        Me.picPanel.TabIndex = 69
        '
        'Label13
        '
        Me.Label13.BackColor = System.Drawing.Color.Transparent
        Me.Label13.Font = New System.Drawing.Font("Mont Heavy DEMO", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.ForeColor = System.Drawing.Color.Black
        Me.Label13.Location = New System.Drawing.Point(260, 57)
        Me.Label13.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(116, 32)
        Me.Label13.TabIndex = 50
        Me.Label13.Text = "BEVERAGE"
        '
        'Label7
        '
        Me.Label7.BackColor = System.Drawing.Color.Transparent
        Me.Label7.Font = New System.Drawing.Font("Mont Heavy DEMO", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.Black
        Me.Label7.Location = New System.Drawing.Point(68, 53)
        Me.Label7.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(86, 32)
        Me.Label7.TabIndex = 50
        Me.Label7.Text = "FOOD"
        '
        'ribeyePicBox
        '
        Me.ribeyePicBox.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.ribeyePicBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.ribeyePicBox.Image = Global.new_Project.My.Resources.Resources.Ribeye_Steak
        Me.ribeyePicBox.Location = New System.Drawing.Point(18, 88)
        Me.ribeyePicBox.Name = "ribeyePicBox"
        Me.ribeyePicBox.Size = New System.Drawing.Size(177, 155)
        Me.ribeyePicBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.ribeyePicBox.TabIndex = 48
        Me.ribeyePicBox.TabStop = False
        Me.ribeyePicBox.Visible = False
        '
        'cheeseBreadPicBox
        '
        Me.cheeseBreadPicBox.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.cheeseBreadPicBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.cheeseBreadPicBox.Image = Global.new_Project.My.Resources.Resources.Brazilian_Cheese_Bread
        Me.cheeseBreadPicBox.Location = New System.Drawing.Point(18, 88)
        Me.cheeseBreadPicBox.Name = "cheeseBreadPicBox"
        Me.cheeseBreadPicBox.Size = New System.Drawing.Size(177, 155)
        Me.cheeseBreadPicBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.cheeseBreadPicBox.TabIndex = 48
        Me.cheeseBreadPicBox.TabStop = False
        Me.cheeseBreadPicBox.Visible = False
        '
        'tortillaPicBox
        '
        Me.tortillaPicBox.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.tortillaPicBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.tortillaPicBox.Image = Global.new_Project.My.Resources.Resources.Chicken_Tortilla_Wrap
        Me.tortillaPicBox.Location = New System.Drawing.Point(18, 88)
        Me.tortillaPicBox.Name = "tortillaPicBox"
        Me.tortillaPicBox.Size = New System.Drawing.Size(177, 152)
        Me.tortillaPicBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.tortillaPicBox.TabIndex = 48
        Me.tortillaPicBox.TabStop = False
        Me.tortillaPicBox.Visible = False
        '
        'cappuchinoPicBox
        '
        Me.cappuchinoPicBox.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.cappuchinoPicBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.cappuchinoPicBox.Image = Global.new_Project.My.Resources.Resources.Cappuchino
        Me.cappuchinoPicBox.Location = New System.Drawing.Point(229, 88)
        Me.cappuchinoPicBox.Name = "cappuchinoPicBox"
        Me.cappuchinoPicBox.Size = New System.Drawing.Size(177, 165)
        Me.cappuchinoPicBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.cappuchinoPicBox.TabIndex = 48
        Me.cappuchinoPicBox.TabStop = False
        Me.cappuchinoPicBox.Visible = False
        '
        'rumpSteakPicBox
        '
        Me.rumpSteakPicBox.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.rumpSteakPicBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.rumpSteakPicBox.Image = Global.new_Project.My.Resources.Resources.Samba_Rump_Steak
        Me.rumpSteakPicBox.Location = New System.Drawing.Point(18, 88)
        Me.rumpSteakPicBox.Name = "rumpSteakPicBox"
        Me.rumpSteakPicBox.Size = New System.Drawing.Size(177, 155)
        Me.rumpSteakPicBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.rumpSteakPicBox.TabIndex = 48
        Me.rumpSteakPicBox.TabStop = False
        Me.rumpSteakPicBox.Visible = False
        '
        'arabiataPicBox
        '
        Me.arabiataPicBox.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.arabiataPicBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.arabiataPicBox.Image = Global.new_Project.My.Resources.Resources.Penne_Arabiata
        Me.arabiataPicBox.Location = New System.Drawing.Point(18, 88)
        Me.arabiataPicBox.Name = "arabiataPicBox"
        Me.arabiataPicBox.Size = New System.Drawing.Size(177, 155)
        Me.arabiataPicBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.arabiataPicBox.TabIndex = 48
        Me.arabiataPicBox.TabStop = False
        Me.arabiataPicBox.Visible = False
        '
        'feijoadaPicBox
        '
        Me.feijoadaPicBox.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.feijoadaPicBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.feijoadaPicBox.Image = Global.new_Project.My.Resources.Resources.feijoada
        Me.feijoadaPicBox.Location = New System.Drawing.Point(18, 88)
        Me.feijoadaPicBox.Name = "feijoadaPicBox"
        Me.feijoadaPicBox.Size = New System.Drawing.Size(177, 155)
        Me.feijoadaPicBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.feijoadaPicBox.TabIndex = 48
        Me.feijoadaPicBox.TabStop = False
        Me.feijoadaPicBox.Visible = False
        '
        'caesaSaladPicBox
        '
        Me.caesaSaladPicBox.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.caesaSaladPicBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.caesaSaladPicBox.Image = Global.new_Project.My.Resources.Resources.Traditional_Caesa_Salad
        Me.caesaSaladPicBox.Location = New System.Drawing.Point(18, 88)
        Me.caesaSaladPicBox.Name = "caesaSaladPicBox"
        Me.caesaSaladPicBox.Size = New System.Drawing.Size(177, 155)
        Me.caesaSaladPicBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.caesaSaladPicBox.TabIndex = 48
        Me.caesaSaladPicBox.TabStop = False
        Me.caesaSaladPicBox.Visible = False
        '
        'mojittoPicBox
        '
        Me.mojittoPicBox.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.mojittoPicBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.mojittoPicBox.Image = Global.new_Project.My.Resources.Resources.Mojitto
        Me.mojittoPicBox.Location = New System.Drawing.Point(229, 88)
        Me.mojittoPicBox.Name = "mojittoPicBox"
        Me.mojittoPicBox.Size = New System.Drawing.Size(177, 155)
        Me.mojittoPicBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.mojittoPicBox.TabIndex = 48
        Me.mojittoPicBox.TabStop = False
        Me.mojittoPicBox.Visible = False
        '
        'salmonPicBox
        '
        Me.salmonPicBox.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.salmonPicBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.salmonPicBox.Image = Global.new_Project.My.Resources.Resources.Norway_Salmon
        Me.salmonPicBox.Location = New System.Drawing.Point(18, 88)
        Me.salmonPicBox.Name = "salmonPicBox"
        Me.salmonPicBox.Size = New System.Drawing.Size(177, 155)
        Me.salmonPicBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.salmonPicBox.TabIndex = 48
        Me.salmonPicBox.TabStop = False
        Me.salmonPicBox.Visible = False
        '
        'moquecaPicBox
        '
        Me.moquecaPicBox.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.moquecaPicBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.moquecaPicBox.Image = Global.new_Project.My.Resources.Resources.moqueca
        Me.moquecaPicBox.Location = New System.Drawing.Point(18, 88)
        Me.moquecaPicBox.Name = "moquecaPicBox"
        Me.moquecaPicBox.Size = New System.Drawing.Size(177, 161)
        Me.moquecaPicBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.moquecaPicBox.TabIndex = 48
        Me.moquecaPicBox.TabStop = False
        Me.moquecaPicBox.Visible = False
        '
        'jerkyBeefPicBox
        '
        Me.jerkyBeefPicBox.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.jerkyBeefPicBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.jerkyBeefPicBox.Image = Global.new_Project.My.Resources.Resources.Jerky_Beef_with_Fries
        Me.jerkyBeefPicBox.Location = New System.Drawing.Point(18, 88)
        Me.jerkyBeefPicBox.Name = "jerkyBeefPicBox"
        Me.jerkyBeefPicBox.Size = New System.Drawing.Size(177, 165)
        Me.jerkyBeefPicBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.jerkyBeefPicBox.TabIndex = 48
        Me.jerkyBeefPicBox.TabStop = False
        Me.jerkyBeefPicBox.Visible = False
        '
        'coconutPicBox
        '
        Me.coconutPicBox.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.coconutPicBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.coconutPicBox.Image = Global.new_Project.My.Resources.Resources.Coconut_Water
        Me.coconutPicBox.Location = New System.Drawing.Point(228, 88)
        Me.coconutPicBox.Name = "coconutPicBox"
        Me.coconutPicBox.Size = New System.Drawing.Size(178, 165)
        Me.coconutPicBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.coconutPicBox.TabIndex = 48
        Me.coconutPicBox.TabStop = False
        Me.coconutPicBox.Visible = False
        '
        'lemonadePicBox
        '
        Me.lemonadePicBox.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.lemonadePicBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lemonadePicBox.Image = Global.new_Project.My.Resources.Resources.Lemonade
        Me.lemonadePicBox.Location = New System.Drawing.Point(228, 88)
        Me.lemonadePicBox.Name = "lemonadePicBox"
        Me.lemonadePicBox.Size = New System.Drawing.Size(177, 165)
        Me.lemonadePicBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.lemonadePicBox.TabIndex = 48
        Me.lemonadePicBox.TabStop = False
        Me.lemonadePicBox.Visible = False
        '
        'americanoPicBox
        '
        Me.americanoPicBox.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.americanoPicBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.americanoPicBox.Image = Global.new_Project.My.Resources.Resources.Americano1
        Me.americanoPicBox.Location = New System.Drawing.Point(228, 88)
        Me.americanoPicBox.Name = "americanoPicBox"
        Me.americanoPicBox.Size = New System.Drawing.Size(177, 165)
        Me.americanoPicBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.americanoPicBox.TabIndex = 48
        Me.americanoPicBox.TabStop = False
        Me.americanoPicBox.Visible = False
        '
        'mangoPicBox
        '
        Me.mangoPicBox.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.mangoPicBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.mangoPicBox.Image = Global.new_Project.My.Resources.Resources.Creamy_Mango
        Me.mangoPicBox.Location = New System.Drawing.Point(229, 88)
        Me.mangoPicBox.Name = "mangoPicBox"
        Me.mangoPicBox.Size = New System.Drawing.Size(177, 165)
        Me.mangoPicBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.mangoPicBox.TabIndex = 48
        Me.mangoPicBox.TabStop = False
        Me.mangoPicBox.Visible = False
        '
        'skyJuicePicBox
        '
        Me.skyJuicePicBox.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.skyJuicePicBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.skyJuicePicBox.Image = Global.new_Project.My.Resources.Resources.Sky_Juice
        Me.skyJuicePicBox.Location = New System.Drawing.Point(228, 88)
        Me.skyJuicePicBox.Name = "skyJuicePicBox"
        Me.skyJuicePicBox.Size = New System.Drawing.Size(177, 165)
        Me.skyJuicePicBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.skyJuicePicBox.TabIndex = 48
        Me.skyJuicePicBox.TabStop = False
        Me.skyJuicePicBox.Visible = False
        '
        'matchaPicBox
        '
        Me.matchaPicBox.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.matchaPicBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.matchaPicBox.Image = Global.new_Project.My.Resources.Resources.Matcha
        Me.matchaPicBox.Location = New System.Drawing.Point(228, 88)
        Me.matchaPicBox.Name = "matchaPicBox"
        Me.matchaPicBox.Size = New System.Drawing.Size(177, 165)
        Me.matchaPicBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.matchaPicBox.TabIndex = 48
        Me.matchaPicBox.TabStop = False
        Me.matchaPicBox.Visible = False
        '
        'brigaderiosPicBox
        '
        Me.brigaderiosPicBox.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.brigaderiosPicBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.brigaderiosPicBox.Image = Global.new_Project.My.Resources.Resources.brigadeiro
        Me.brigaderiosPicBox.Location = New System.Drawing.Point(18, 88)
        Me.brigaderiosPicBox.Name = "brigaderiosPicBox"
        Me.brigaderiosPicBox.Size = New System.Drawing.Size(177, 155)
        Me.brigaderiosPicBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.brigaderiosPicBox.TabIndex = 48
        Me.brigaderiosPicBox.TabStop = False
        Me.brigaderiosPicBox.Visible = False
        '
        'coconutChkBox
        '
        Me.coconutChkBox.AutoSize = True
        Me.coconutChkBox.Location = New System.Drawing.Point(14, 101)
        Me.coconutChkBox.Name = "coconutChkBox"
        Me.coconutChkBox.Size = New System.Drawing.Size(104, 19)
        Me.coconutChkBox.TabIndex = 3
        Me.coconutChkBox.Text = "Coconut water"
        Me.coconutChkBox.UseVisualStyleBackColor = True
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.SystemColors.GradientInactiveCaption
        Me.Panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel2.Controls.Add(Me.txtRumpsteak)
        Me.Panel2.Controls.Add(Me.txtSalmon)
        Me.Panel2.Controls.Add(Me.addRumpsteakBtn)
        Me.Panel2.Controls.Add(Me.addSalmonBtn)
        Me.Panel2.Controls.Add(Me.minusRumpsteakBtn)
        Me.Panel2.Controls.Add(Me.addRibeyeBtn)
        Me.Panel2.Controls.Add(Me.minusSalmonBtn)
        Me.Panel2.Controls.Add(Me.addTortillaBtn)
        Me.Panel2.Controls.Add(Me.minusRibeyeBtn)
        Me.Panel2.Controls.Add(Me.txtRibeye)
        Me.Panel2.Controls.Add(Me.minusTortillaBtn)
        Me.Panel2.Controls.Add(Me.lblRumpSteak)
        Me.Panel2.Controls.Add(Me.txtTortilla)
        Me.Panel2.Controls.Add(Me.lblSalmon)
        Me.Panel2.Controls.Add(Me.lblRibeye)
        Me.Panel2.Controls.Add(Me.lblTortilla)
        Me.Panel2.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Panel2.Location = New System.Drawing.Point(23, 38)
        Me.Panel2.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(520, 233)
        Me.Panel2.TabIndex = 4
        '
        'txtRumpsteak
        '
        Me.txtRumpsteak.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtRumpsteak.Location = New System.Drawing.Point(333, 176)
        Me.txtRumpsteak.Margin = New System.Windows.Forms.Padding(5, 4, 5, 4)
        Me.txtRumpsteak.Name = "txtRumpsteak"
        Me.txtRumpsteak.Size = New System.Drawing.Size(67, 19)
        Me.txtRumpsteak.TabIndex = 40
        Me.txtRumpsteak.Text = "0"
        Me.txtRumpsteak.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtSalmon
        '
        Me.txtSalmon.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSalmon.Location = New System.Drawing.Point(333, 126)
        Me.txtSalmon.Margin = New System.Windows.Forms.Padding(5, 4, 5, 4)
        Me.txtSalmon.Name = "txtSalmon"
        Me.txtSalmon.Size = New System.Drawing.Size(67, 19)
        Me.txtSalmon.TabIndex = 40
        Me.txtSalmon.Text = "0"
        Me.txtSalmon.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'addRumpsteakBtn
        '
        Me.addRumpsteakBtn.BackColor = System.Drawing.SystemColors.GradientInactiveCaption
        Me.addRumpsteakBtn.Location = New System.Drawing.Point(413, 171)
        Me.addRumpsteakBtn.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.addRumpsteakBtn.Name = "addRumpsteakBtn"
        Me.addRumpsteakBtn.Size = New System.Drawing.Size(76, 29)
        Me.addRumpsteakBtn.TabIndex = 3
        Me.addRumpsteakBtn.Text = "+"
        Me.addRumpsteakBtn.UseVisualStyleBackColor = False
        '
        'addSalmonBtn
        '
        Me.addSalmonBtn.BackColor = System.Drawing.SystemColors.GradientInactiveCaption
        Me.addSalmonBtn.Location = New System.Drawing.Point(413, 121)
        Me.addSalmonBtn.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.addSalmonBtn.Name = "addSalmonBtn"
        Me.addSalmonBtn.Size = New System.Drawing.Size(76, 29)
        Me.addSalmonBtn.TabIndex = 3
        Me.addSalmonBtn.Text = "+"
        Me.addSalmonBtn.UseVisualStyleBackColor = False
        '
        'minusRumpsteakBtn
        '
        Me.minusRumpsteakBtn.BackColor = System.Drawing.SystemColors.GradientInactiveCaption
        Me.minusRumpsteakBtn.Location = New System.Drawing.Point(236, 172)
        Me.minusRumpsteakBtn.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.minusRumpsteakBtn.Name = "minusRumpsteakBtn"
        Me.minusRumpsteakBtn.Size = New System.Drawing.Size(76, 33)
        Me.minusRumpsteakBtn.TabIndex = 3
        Me.minusRumpsteakBtn.Text = "-"
        Me.minusRumpsteakBtn.UseVisualStyleBackColor = False
        '
        'addRibeyeBtn
        '
        Me.addRibeyeBtn.BackColor = System.Drawing.SystemColors.GradientInactiveCaption
        Me.addRibeyeBtn.Location = New System.Drawing.Point(413, 68)
        Me.addRibeyeBtn.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.addRibeyeBtn.Name = "addRibeyeBtn"
        Me.addRibeyeBtn.Size = New System.Drawing.Size(76, 29)
        Me.addRibeyeBtn.TabIndex = 3
        Me.addRibeyeBtn.Text = "+"
        Me.addRibeyeBtn.UseVisualStyleBackColor = False
        '
        'minusSalmonBtn
        '
        Me.minusSalmonBtn.BackColor = System.Drawing.SystemColors.GradientInactiveCaption
        Me.minusSalmonBtn.Location = New System.Drawing.Point(236, 122)
        Me.minusSalmonBtn.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.minusSalmonBtn.Name = "minusSalmonBtn"
        Me.minusSalmonBtn.Size = New System.Drawing.Size(76, 33)
        Me.minusSalmonBtn.TabIndex = 3
        Me.minusSalmonBtn.Text = "-"
        Me.minusSalmonBtn.UseVisualStyleBackColor = False
        '
        'addTortillaBtn
        '
        Me.addTortillaBtn.BackColor = System.Drawing.SystemColors.GradientInactiveCaption
        Me.addTortillaBtn.Location = New System.Drawing.Point(413, 22)
        Me.addTortillaBtn.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.addTortillaBtn.Name = "addTortillaBtn"
        Me.addTortillaBtn.Size = New System.Drawing.Size(76, 29)
        Me.addTortillaBtn.TabIndex = 3
        Me.addTortillaBtn.Text = "+"
        Me.addTortillaBtn.UseVisualStyleBackColor = False
        '
        'minusRibeyeBtn
        '
        Me.minusRibeyeBtn.BackColor = System.Drawing.SystemColors.GradientInactiveCaption
        Me.minusRibeyeBtn.Location = New System.Drawing.Point(236, 69)
        Me.minusRibeyeBtn.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.minusRibeyeBtn.Name = "minusRibeyeBtn"
        Me.minusRibeyeBtn.Size = New System.Drawing.Size(76, 33)
        Me.minusRibeyeBtn.TabIndex = 3
        Me.minusRibeyeBtn.Text = "-"
        Me.minusRibeyeBtn.UseVisualStyleBackColor = False
        '
        'txtRibeye
        '
        Me.txtRibeye.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtRibeye.Location = New System.Drawing.Point(333, 75)
        Me.txtRibeye.Margin = New System.Windows.Forms.Padding(5, 4, 5, 4)
        Me.txtRibeye.Name = "txtRibeye"
        Me.txtRibeye.Size = New System.Drawing.Size(67, 19)
        Me.txtRibeye.TabIndex = 40
        Me.txtRibeye.Text = "0"
        Me.txtRibeye.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'minusTortillaBtn
        '
        Me.minusTortillaBtn.BackColor = System.Drawing.SystemColors.GradientInactiveCaption
        Me.minusTortillaBtn.Location = New System.Drawing.Point(236, 23)
        Me.minusTortillaBtn.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.minusTortillaBtn.Name = "minusTortillaBtn"
        Me.minusTortillaBtn.Size = New System.Drawing.Size(76, 33)
        Me.minusTortillaBtn.TabIndex = 3
        Me.minusTortillaBtn.Text = "-"
        Me.minusTortillaBtn.UseVisualStyleBackColor = False
        '
        'lblRumpSteak
        '
        Me.lblRumpSteak.BackColor = System.Drawing.SystemColors.HighlightText
        Me.lblRumpSteak.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblRumpSteak.Cursor = System.Windows.Forms.Cursors.Default
        Me.lblRumpSteak.Font = New System.Drawing.Font("Mont Heavy DEMO", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblRumpSteak.ForeColor = System.Drawing.SystemColors.ControlText
        Me.lblRumpSteak.Location = New System.Drawing.Point(27, 169)
        Me.lblRumpSteak.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.lblRumpSteak.Name = "lblRumpSteak"
        Me.lblRumpSteak.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblRumpSteak.Size = New System.Drawing.Size(162, 36)
        Me.lblRumpSteak.TabIndex = 11
        Me.lblRumpSteak.Text = "SET 4"
        Me.lblRumpSteak.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'txtTortilla
        '
        Me.txtTortilla.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTortilla.Location = New System.Drawing.Point(333, 29)
        Me.txtTortilla.Margin = New System.Windows.Forms.Padding(5, 4, 5, 4)
        Me.txtTortilla.Name = "txtTortilla"
        Me.txtTortilla.Size = New System.Drawing.Size(67, 19)
        Me.txtTortilla.TabIndex = 40
        Me.txtTortilla.Text = "0"
        Me.txtTortilla.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'lblSalmon
        '
        Me.lblSalmon.BackColor = System.Drawing.SystemColors.HighlightText
        Me.lblSalmon.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblSalmon.Cursor = System.Windows.Forms.Cursors.Default
        Me.lblSalmon.Font = New System.Drawing.Font("Mont Heavy DEMO", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSalmon.ForeColor = System.Drawing.SystemColors.ControlText
        Me.lblSalmon.Location = New System.Drawing.Point(27, 119)
        Me.lblSalmon.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.lblSalmon.Name = "lblSalmon"
        Me.lblSalmon.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblSalmon.Size = New System.Drawing.Size(162, 36)
        Me.lblSalmon.TabIndex = 11
        Me.lblSalmon.Text = "SET 3"
        Me.lblSalmon.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblRibeye
        '
        Me.lblRibeye.BackColor = System.Drawing.SystemColors.HighlightText
        Me.lblRibeye.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblRibeye.Cursor = System.Windows.Forms.Cursors.Default
        Me.lblRibeye.Font = New System.Drawing.Font("Mont Heavy DEMO", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblRibeye.ForeColor = System.Drawing.SystemColors.ControlText
        Me.lblRibeye.Location = New System.Drawing.Point(27, 68)
        Me.lblRibeye.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.lblRibeye.Name = "lblRibeye"
        Me.lblRibeye.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblRibeye.Size = New System.Drawing.Size(162, 36)
        Me.lblRibeye.TabIndex = 11
        Me.lblRibeye.Text = "SET 2"
        Me.lblRibeye.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblTortilla
        '
        Me.lblTortilla.BackColor = System.Drawing.SystemColors.HighlightText
        Me.lblTortilla.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblTortilla.Cursor = System.Windows.Forms.Cursors.Default
        Me.lblTortilla.Font = New System.Drawing.Font("Mont Heavy DEMO", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTortilla.ForeColor = System.Drawing.SystemColors.ControlText
        Me.lblTortilla.Location = New System.Drawing.Point(27, 20)
        Me.lblTortilla.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.lblTortilla.Name = "lblTortilla"
        Me.lblTortilla.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblTortilla.Size = New System.Drawing.Size(162, 36)
        Me.lblTortilla.TabIndex = 11
        Me.lblTortilla.Text = "SET 1"
        Me.lblTortilla.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'drinkGpBox
        '
        Me.drinkGpBox.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.drinkGpBox.Controls.Add(Me.coconutChkBox)
        Me.drinkGpBox.Controls.Add(Me.creamyMangoChkBox)
        Me.drinkGpBox.Controls.Add(Me.skyJuiceChkBox)
        Me.drinkGpBox.Controls.Add(Me.americanoChkBox)
        Me.drinkGpBox.Controls.Add(Me.mojittoChkBox)
        Me.drinkGpBox.Controls.Add(Me.matchaChkBox)
        Me.drinkGpBox.Controls.Add(Me.lemonadeChkBox)
        Me.drinkGpBox.Controls.Add(Me.cappuchinoChkBox)
        Me.drinkGpBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.drinkGpBox.Location = New System.Drawing.Point(22, 420)
        Me.drinkGpBox.Name = "drinkGpBox"
        Me.drinkGpBox.Size = New System.Drawing.Size(520, 138)
        Me.drinkGpBox.TabIndex = 42
        Me.drinkGpBox.TabStop = False
        Me.drinkGpBox.Text = "Drinks List: "
        '
        'creamyMangoChkBox
        '
        Me.creamyMangoChkBox.AutoSize = True
        Me.creamyMangoChkBox.Location = New System.Drawing.Point(201, 101)
        Me.creamyMangoChkBox.Name = "creamyMangoChkBox"
        Me.creamyMangoChkBox.Size = New System.Drawing.Size(113, 19)
        Me.creamyMangoChkBox.TabIndex = 3
        Me.creamyMangoChkBox.Text = "Creamy Mango "
        Me.creamyMangoChkBox.UseVisualStyleBackColor = True
        '
        'skyJuiceChkBox
        '
        Me.skyJuiceChkBox.AutoSize = True
        Me.skyJuiceChkBox.Location = New System.Drawing.Point(201, 56)
        Me.skyJuiceChkBox.Name = "skyJuiceChkBox"
        Me.skyJuiceChkBox.Size = New System.Drawing.Size(80, 19)
        Me.skyJuiceChkBox.TabIndex = 3
        Me.skyJuiceChkBox.Text = "Sky Juice "
        Me.skyJuiceChkBox.UseVisualStyleBackColor = True
        '
        'americanoChkBox
        '
        Me.americanoChkBox.AutoSize = True
        Me.americanoChkBox.Location = New System.Drawing.Point(201, 79)
        Me.americanoChkBox.Name = "americanoChkBox"
        Me.americanoChkBox.Size = New System.Drawing.Size(88, 19)
        Me.americanoChkBox.TabIndex = 3
        Me.americanoChkBox.Text = "Americano "
        Me.americanoChkBox.UseVisualStyleBackColor = True
        '
        'mojittoChkBox
        '
        Me.mojittoChkBox.AutoSize = True
        Me.mojittoChkBox.Location = New System.Drawing.Point(14, 78)
        Me.mojittoChkBox.Name = "mojittoChkBox"
        Me.mojittoChkBox.Size = New System.Drawing.Size(66, 19)
        Me.mojittoChkBox.TabIndex = 3
        Me.mojittoChkBox.Text = "Mojitto "
        Me.mojittoChkBox.UseVisualStyleBackColor = True
        '
        'matchaChkBox
        '
        Me.matchaChkBox.AutoSize = True
        Me.matchaChkBox.Location = New System.Drawing.Point(14, 31)
        Me.matchaChkBox.Name = "matchaChkBox"
        Me.matchaChkBox.Size = New System.Drawing.Size(70, 19)
        Me.matchaChkBox.TabIndex = 3
        Me.matchaChkBox.Text = "Matcha "
        Me.matchaChkBox.UseVisualStyleBackColor = True
        '
        'lemonadeChkBox
        '
        Me.lemonadeChkBox.AutoSize = True
        Me.lemonadeChkBox.Location = New System.Drawing.Point(201, 31)
        Me.lemonadeChkBox.Name = "lemonadeChkBox"
        Me.lemonadeChkBox.Size = New System.Drawing.Size(89, 19)
        Me.lemonadeChkBox.TabIndex = 3
        Me.lemonadeChkBox.Text = "Lemonade "
        Me.lemonadeChkBox.ThreeState = True
        Me.lemonadeChkBox.UseVisualStyleBackColor = True
        '
        'cappuchinoChkBox
        '
        Me.cappuchinoChkBox.AutoSize = True
        Me.cappuchinoChkBox.Location = New System.Drawing.Point(14, 54)
        Me.cappuchinoChkBox.Name = "cappuchinoChkBox"
        Me.cappuchinoChkBox.Size = New System.Drawing.Size(95, 19)
        Me.cappuchinoChkBox.TabIndex = 3
        Me.cappuchinoChkBox.Text = "Cappuchino " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        Me.cappuchinoChkBox.UseVisualStyleBackColor = True
        '
        'comboSetPanel
        '
        Me.comboSetPanel.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.comboSetPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.comboSetPanel.Controls.Add(Me.Panel2)
        Me.comboSetPanel.Controls.Add(Me.Label1)
        Me.comboSetPanel.Location = New System.Drawing.Point(498, 102)
        Me.comboSetPanel.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.comboSetPanel.Name = "comboSetPanel"
        Me.comboSetPanel.Size = New System.Drawing.Size(569, 308)
        Me.comboSetPanel.TabIndex = 56
        Me.comboSetPanel.Visible = False
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Mont Heavy DEMO", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Black
        Me.Label1.Location = New System.Drawing.Point(189, 4)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(209, 31)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Combo Set Menu"
        '
        'Panel4
        '
        Me.Panel4.BackColor = System.Drawing.SystemColors.GradientInactiveCaption
        Me.Panel4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel4.Controls.Add(Me.addCheesebreadBtn)
        Me.Panel4.Controls.Add(Me.PictureBox10)
        Me.Panel4.Controls.Add(Me.addArabiataBtn)
        Me.Panel4.Controls.Add(Me.addCaesasaladBtn)
        Me.Panel4.Controls.Add(Me.addJerkybeefBtn)
        Me.Panel4.Controls.Add(Me.addBrigaderiosBtn)
        Me.Panel4.Controls.Add(Me.addFeijoadaBtn)
        Me.Panel4.Controls.Add(Me.minusCheeseBread)
        Me.Panel4.Controls.Add(Me.minusArabiataBtn)
        Me.Panel4.Controls.Add(Me.minusCaesasaladBtn)
        Me.Panel4.Controls.Add(Me.minusJerkyBeefBtn)
        Me.Panel4.Controls.Add(Me.minusBrigaderiosBtn)
        Me.Panel4.Controls.Add(Me.addMoquecaBtn)
        Me.Panel4.Controls.Add(Me.minusFeijoadaBtn)
        Me.Panel4.Controls.Add(Me.txtCheesebread)
        Me.Panel4.Controls.Add(Me.minusMoquecaBtn)
        Me.Panel4.Controls.Add(Me.lblCheeseBread)
        Me.Panel4.Controls.Add(Me.txtArabiata)
        Me.Panel4.Controls.Add(Me.lblArabiata)
        Me.Panel4.Controls.Add(Me.txtMoqueca)
        Me.Panel4.Controls.Add(Me.txtFeijoada)
        Me.Panel4.Controls.Add(Me.lblCaesasalad)
        Me.Panel4.Controls.Add(Me.txtCaesasalad)
        Me.Panel4.Controls.Add(Me.lblJerkyBeef)
        Me.Panel4.Controls.Add(Me.txtBrigaderios)
        Me.Panel4.Controls.Add(Me.lblBrigaderios)
        Me.Panel4.Controls.Add(Me.txtJerkybeef)
        Me.Panel4.Controls.Add(Me.lblFeijoada)
        Me.Panel4.Controls.Add(Me.lblMoqueca)
        Me.Panel4.Location = New System.Drawing.Point(22, 38)
        Me.Panel4.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(520, 364)
        Me.Panel4.TabIndex = 4
        '
        'addCheesebreadBtn
        '
        Me.addCheesebreadBtn.BackColor = System.Drawing.SystemColors.GradientInactiveCaption
        Me.addCheesebreadBtn.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.addCheesebreadBtn.Location = New System.Drawing.Point(420, 314)
        Me.addCheesebreadBtn.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.addCheesebreadBtn.Name = "addCheesebreadBtn"
        Me.addCheesebreadBtn.Size = New System.Drawing.Size(76, 29)
        Me.addCheesebreadBtn.TabIndex = 41
        Me.addCheesebreadBtn.Text = "+"
        Me.addCheesebreadBtn.UseVisualStyleBackColor = False
        '
        'PictureBox10
        '
        Me.PictureBox10.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.PictureBox10.Location = New System.Drawing.Point(647, -117)
        Me.PictureBox10.Name = "PictureBox10"
        Me.PictureBox10.Size = New System.Drawing.Size(107, 73)
        Me.PictureBox10.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox10.TabIndex = 48
        Me.PictureBox10.TabStop = False
        Me.PictureBox10.Visible = False
        '
        'addArabiataBtn
        '
        Me.addArabiataBtn.BackColor = System.Drawing.SystemColors.GradientInactiveCaption
        Me.addArabiataBtn.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.addArabiataBtn.Location = New System.Drawing.Point(419, 268)
        Me.addArabiataBtn.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.addArabiataBtn.Name = "addArabiataBtn"
        Me.addArabiataBtn.Size = New System.Drawing.Size(76, 29)
        Me.addArabiataBtn.TabIndex = 41
        Me.addArabiataBtn.Text = "+"
        Me.addArabiataBtn.UseVisualStyleBackColor = False
        '
        'addCaesasaladBtn
        '
        Me.addCaesasaladBtn.BackColor = System.Drawing.SystemColors.GradientInactiveCaption
        Me.addCaesasaladBtn.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.addCaesasaladBtn.Location = New System.Drawing.Point(419, 221)
        Me.addCaesasaladBtn.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.addCaesasaladBtn.Name = "addCaesasaladBtn"
        Me.addCaesasaladBtn.Size = New System.Drawing.Size(76, 29)
        Me.addCaesasaladBtn.TabIndex = 41
        Me.addCaesasaladBtn.Text = "+"
        Me.addCaesasaladBtn.UseVisualStyleBackColor = False
        '
        'addJerkybeefBtn
        '
        Me.addJerkybeefBtn.BackColor = System.Drawing.SystemColors.GradientInactiveCaption
        Me.addJerkybeefBtn.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.addJerkybeefBtn.Location = New System.Drawing.Point(419, 171)
        Me.addJerkybeefBtn.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.addJerkybeefBtn.Name = "addJerkybeefBtn"
        Me.addJerkybeefBtn.Size = New System.Drawing.Size(76, 29)
        Me.addJerkybeefBtn.TabIndex = 41
        Me.addJerkybeefBtn.Text = "+"
        Me.addJerkybeefBtn.UseVisualStyleBackColor = False
        '
        'addBrigaderiosBtn
        '
        Me.addBrigaderiosBtn.BackColor = System.Drawing.SystemColors.GradientInactiveCaption
        Me.addBrigaderiosBtn.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.addBrigaderiosBtn.Location = New System.Drawing.Point(419, 121)
        Me.addBrigaderiosBtn.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.addBrigaderiosBtn.Name = "addBrigaderiosBtn"
        Me.addBrigaderiosBtn.Size = New System.Drawing.Size(76, 29)
        Me.addBrigaderiosBtn.TabIndex = 41
        Me.addBrigaderiosBtn.Text = "+"
        Me.addBrigaderiosBtn.UseVisualStyleBackColor = False
        '
        'addFeijoadaBtn
        '
        Me.addFeijoadaBtn.BackColor = System.Drawing.SystemColors.GradientInactiveCaption
        Me.addFeijoadaBtn.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.addFeijoadaBtn.Location = New System.Drawing.Point(420, 70)
        Me.addFeijoadaBtn.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.addFeijoadaBtn.Name = "addFeijoadaBtn"
        Me.addFeijoadaBtn.Size = New System.Drawing.Size(76, 29)
        Me.addFeijoadaBtn.TabIndex = 42
        Me.addFeijoadaBtn.Text = "+"
        Me.addFeijoadaBtn.UseVisualStyleBackColor = False
        '
        'minusCheeseBread
        '
        Me.minusCheeseBread.BackColor = System.Drawing.SystemColors.GradientInactiveCaption
        Me.minusCheeseBread.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.minusCheeseBread.Location = New System.Drawing.Point(230, 312)
        Me.minusCheeseBread.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.minusCheeseBread.Name = "minusCheeseBread"
        Me.minusCheeseBread.Size = New System.Drawing.Size(76, 33)
        Me.minusCheeseBread.TabIndex = 43
        Me.minusCheeseBread.Text = "-"
        Me.minusCheeseBread.UseVisualStyleBackColor = False
        '
        'minusArabiataBtn
        '
        Me.minusArabiataBtn.BackColor = System.Drawing.SystemColors.GradientInactiveCaption
        Me.minusArabiataBtn.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.minusArabiataBtn.Location = New System.Drawing.Point(229, 266)
        Me.minusArabiataBtn.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.minusArabiataBtn.Name = "minusArabiataBtn"
        Me.minusArabiataBtn.Size = New System.Drawing.Size(76, 33)
        Me.minusArabiataBtn.TabIndex = 43
        Me.minusArabiataBtn.Text = "-"
        Me.minusArabiataBtn.UseVisualStyleBackColor = False
        '
        'minusCaesasaladBtn
        '
        Me.minusCaesasaladBtn.BackColor = System.Drawing.SystemColors.GradientInactiveCaption
        Me.minusCaesasaladBtn.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.minusCaesasaladBtn.Location = New System.Drawing.Point(229, 219)
        Me.minusCaesasaladBtn.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.minusCaesasaladBtn.Name = "minusCaesasaladBtn"
        Me.minusCaesasaladBtn.Size = New System.Drawing.Size(76, 33)
        Me.minusCaesasaladBtn.TabIndex = 43
        Me.minusCaesasaladBtn.Text = "-"
        Me.minusCaesasaladBtn.UseVisualStyleBackColor = False
        '
        'minusJerkyBeefBtn
        '
        Me.minusJerkyBeefBtn.BackColor = System.Drawing.SystemColors.GradientInactiveCaption
        Me.minusJerkyBeefBtn.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.minusJerkyBeefBtn.Location = New System.Drawing.Point(229, 169)
        Me.minusJerkyBeefBtn.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.minusJerkyBeefBtn.Name = "minusJerkyBeefBtn"
        Me.minusJerkyBeefBtn.Size = New System.Drawing.Size(76, 33)
        Me.minusJerkyBeefBtn.TabIndex = 43
        Me.minusJerkyBeefBtn.Text = "-"
        Me.minusJerkyBeefBtn.UseVisualStyleBackColor = False
        '
        'minusBrigaderiosBtn
        '
        Me.minusBrigaderiosBtn.BackColor = System.Drawing.SystemColors.GradientInactiveCaption
        Me.minusBrigaderiosBtn.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.minusBrigaderiosBtn.Location = New System.Drawing.Point(229, 119)
        Me.minusBrigaderiosBtn.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.minusBrigaderiosBtn.Name = "minusBrigaderiosBtn"
        Me.minusBrigaderiosBtn.Size = New System.Drawing.Size(76, 33)
        Me.minusBrigaderiosBtn.TabIndex = 43
        Me.minusBrigaderiosBtn.Text = "-"
        Me.minusBrigaderiosBtn.UseVisualStyleBackColor = False
        '
        'addMoquecaBtn
        '
        Me.addMoquecaBtn.BackColor = System.Drawing.SystemColors.GradientInactiveCaption
        Me.addMoquecaBtn.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.addMoquecaBtn.Location = New System.Drawing.Point(419, 25)
        Me.addMoquecaBtn.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.addMoquecaBtn.Name = "addMoquecaBtn"
        Me.addMoquecaBtn.Size = New System.Drawing.Size(76, 29)
        Me.addMoquecaBtn.TabIndex = 44
        Me.addMoquecaBtn.Text = "+"
        Me.addMoquecaBtn.UseVisualStyleBackColor = False
        '
        'minusFeijoadaBtn
        '
        Me.minusFeijoadaBtn.BackColor = System.Drawing.SystemColors.GradientInactiveCaption
        Me.minusFeijoadaBtn.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.minusFeijoadaBtn.Location = New System.Drawing.Point(230, 68)
        Me.minusFeijoadaBtn.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.minusFeijoadaBtn.Name = "minusFeijoadaBtn"
        Me.minusFeijoadaBtn.Size = New System.Drawing.Size(76, 33)
        Me.minusFeijoadaBtn.TabIndex = 45
        Me.minusFeijoadaBtn.Text = "-"
        Me.minusFeijoadaBtn.UseVisualStyleBackColor = False
        '
        'txtCheesebread
        '
        Me.txtCheesebread.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCheesebread.Location = New System.Drawing.Point(329, 318)
        Me.txtCheesebread.Margin = New System.Windows.Forms.Padding(5, 4, 5, 4)
        Me.txtCheesebread.Name = "txtCheesebread"
        Me.txtCheesebread.Size = New System.Drawing.Size(72, 19)
        Me.txtCheesebread.TabIndex = 40
        Me.txtCheesebread.Text = "0"
        Me.txtCheesebread.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'minusMoquecaBtn
        '
        Me.minusMoquecaBtn.BackColor = System.Drawing.SystemColors.GradientInactiveCaption
        Me.minusMoquecaBtn.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.minusMoquecaBtn.Location = New System.Drawing.Point(229, 23)
        Me.minusMoquecaBtn.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.minusMoquecaBtn.Name = "minusMoquecaBtn"
        Me.minusMoquecaBtn.Size = New System.Drawing.Size(76, 33)
        Me.minusMoquecaBtn.TabIndex = 46
        Me.minusMoquecaBtn.Text = "-"
        Me.minusMoquecaBtn.UseVisualStyleBackColor = False
        '
        'lblCheeseBread
        '
        Me.lblCheeseBread.BackColor = System.Drawing.SystemColors.HighlightText
        Me.lblCheeseBread.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblCheeseBread.Cursor = System.Windows.Forms.Cursors.Default
        Me.lblCheeseBread.Font = New System.Drawing.Font("Mont Heavy DEMO", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCheeseBread.ForeColor = System.Drawing.SystemColors.ControlText
        Me.lblCheeseBread.Location = New System.Drawing.Point(28, 309)
        Me.lblCheeseBread.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.lblCheeseBread.Name = "lblCheeseBread"
        Me.lblCheeseBread.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblCheeseBread.Size = New System.Drawing.Size(162, 36)
        Me.lblCheeseBread.TabIndex = 11
        Me.lblCheeseBread.Text = "Brazillian Cheese " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Bread"
        Me.lblCheeseBread.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'txtArabiata
        '
        Me.txtArabiata.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtArabiata.Location = New System.Drawing.Point(328, 272)
        Me.txtArabiata.Margin = New System.Windows.Forms.Padding(5, 4, 5, 4)
        Me.txtArabiata.Name = "txtArabiata"
        Me.txtArabiata.Size = New System.Drawing.Size(72, 19)
        Me.txtArabiata.TabIndex = 40
        Me.txtArabiata.Text = "0"
        Me.txtArabiata.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'lblArabiata
        '
        Me.lblArabiata.BackColor = System.Drawing.SystemColors.HighlightText
        Me.lblArabiata.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblArabiata.Cursor = System.Windows.Forms.Cursors.Default
        Me.lblArabiata.Font = New System.Drawing.Font("Mont Heavy DEMO", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblArabiata.ForeColor = System.Drawing.SystemColors.ControlText
        Me.lblArabiata.Location = New System.Drawing.Point(27, 261)
        Me.lblArabiata.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.lblArabiata.Name = "lblArabiata"
        Me.lblArabiata.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblArabiata.Size = New System.Drawing.Size(162, 36)
        Me.lblArabiata.TabIndex = 11
        Me.lblArabiata.Text = "Penne Arabiata"
        Me.lblArabiata.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'txtMoqueca
        '
        Me.txtMoqueca.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtMoqueca.Location = New System.Drawing.Point(328, 31)
        Me.txtMoqueca.Margin = New System.Windows.Forms.Padding(5, 4, 5, 4)
        Me.txtMoqueca.Name = "txtMoqueca"
        Me.txtMoqueca.Size = New System.Drawing.Size(72, 19)
        Me.txtMoqueca.TabIndex = 40
        Me.txtMoqueca.Text = "0"
        Me.txtMoqueca.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtFeijoada
        '
        Me.txtFeijoada.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtFeijoada.Location = New System.Drawing.Point(329, 76)
        Me.txtFeijoada.Margin = New System.Windows.Forms.Padding(5, 4, 5, 4)
        Me.txtFeijoada.Name = "txtFeijoada"
        Me.txtFeijoada.Size = New System.Drawing.Size(72, 19)
        Me.txtFeijoada.TabIndex = 40
        Me.txtFeijoada.Text = "0"
        Me.txtFeijoada.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'lblCaesasalad
        '
        Me.lblCaesasalad.BackColor = System.Drawing.SystemColors.HighlightText
        Me.lblCaesasalad.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblCaesasalad.Cursor = System.Windows.Forms.Cursors.Default
        Me.lblCaesasalad.Font = New System.Drawing.Font("Mont Heavy DEMO", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCaesasalad.ForeColor = System.Drawing.SystemColors.ControlText
        Me.lblCaesasalad.Location = New System.Drawing.Point(27, 214)
        Me.lblCaesasalad.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.lblCaesasalad.Name = "lblCaesasalad"
        Me.lblCaesasalad.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblCaesasalad.Size = New System.Drawing.Size(162, 36)
        Me.lblCaesasalad.TabIndex = 11
        Me.lblCaesasalad.Text = "Traditional Caesa " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Salad"
        Me.lblCaesasalad.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'txtCaesasalad
        '
        Me.txtCaesasalad.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCaesasalad.Location = New System.Drawing.Point(328, 225)
        Me.txtCaesasalad.Margin = New System.Windows.Forms.Padding(5, 4, 5, 4)
        Me.txtCaesasalad.Name = "txtCaesasalad"
        Me.txtCaesasalad.Size = New System.Drawing.Size(72, 19)
        Me.txtCaesasalad.TabIndex = 40
        Me.txtCaesasalad.Text = "0"
        Me.txtCaesasalad.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'lblJerkyBeef
        '
        Me.lblJerkyBeef.BackColor = System.Drawing.SystemColors.HighlightText
        Me.lblJerkyBeef.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblJerkyBeef.Cursor = System.Windows.Forms.Cursors.Default
        Me.lblJerkyBeef.Font = New System.Drawing.Font("Mont Heavy DEMO", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblJerkyBeef.ForeColor = System.Drawing.SystemColors.ControlText
        Me.lblJerkyBeef.Location = New System.Drawing.Point(27, 166)
        Me.lblJerkyBeef.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.lblJerkyBeef.Name = "lblJerkyBeef"
        Me.lblJerkyBeef.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblJerkyBeef.Size = New System.Drawing.Size(162, 36)
        Me.lblJerkyBeef.TabIndex = 11
        Me.lblJerkyBeef.Text = "Jerky Beef with Fries"
        Me.lblJerkyBeef.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'txtBrigaderios
        '
        Me.txtBrigaderios.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtBrigaderios.Location = New System.Drawing.Point(328, 125)
        Me.txtBrigaderios.Margin = New System.Windows.Forms.Padding(5, 4, 5, 4)
        Me.txtBrigaderios.Name = "txtBrigaderios"
        Me.txtBrigaderios.Size = New System.Drawing.Size(72, 19)
        Me.txtBrigaderios.TabIndex = 40
        Me.txtBrigaderios.Text = "0"
        Me.txtBrigaderios.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'lblBrigaderios
        '
        Me.lblBrigaderios.BackColor = System.Drawing.SystemColors.HighlightText
        Me.lblBrigaderios.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblBrigaderios.Cursor = System.Windows.Forms.Cursors.Default
        Me.lblBrigaderios.Font = New System.Drawing.Font("Mont Heavy DEMO", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblBrigaderios.ForeColor = System.Drawing.SystemColors.ControlText
        Me.lblBrigaderios.Location = New System.Drawing.Point(27, 116)
        Me.lblBrigaderios.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.lblBrigaderios.Name = "lblBrigaderios"
        Me.lblBrigaderios.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblBrigaderios.Size = New System.Drawing.Size(162, 36)
        Me.lblBrigaderios.TabIndex = 11
        Me.lblBrigaderios.Text = "Brigaderios"
        Me.lblBrigaderios.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'txtJerkybeef
        '
        Me.txtJerkybeef.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtJerkybeef.Location = New System.Drawing.Point(328, 175)
        Me.txtJerkybeef.Margin = New System.Windows.Forms.Padding(5, 4, 5, 4)
        Me.txtJerkybeef.Name = "txtJerkybeef"
        Me.txtJerkybeef.Size = New System.Drawing.Size(72, 19)
        Me.txtJerkybeef.TabIndex = 40
        Me.txtJerkybeef.Text = "0"
        Me.txtJerkybeef.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'lblFeijoada
        '
        Me.lblFeijoada.BackColor = System.Drawing.SystemColors.HighlightText
        Me.lblFeijoada.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblFeijoada.Cursor = System.Windows.Forms.Cursors.Default
        Me.lblFeijoada.Font = New System.Drawing.Font("Mont Heavy DEMO", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFeijoada.ForeColor = System.Drawing.SystemColors.ControlText
        Me.lblFeijoada.Location = New System.Drawing.Point(28, 67)
        Me.lblFeijoada.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.lblFeijoada.Name = "lblFeijoada"
        Me.lblFeijoada.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblFeijoada.Size = New System.Drawing.Size(162, 36)
        Me.lblFeijoada.TabIndex = 11
        Me.lblFeijoada.Text = "Feijoada"
        Me.lblFeijoada.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblMoqueca
        '
        Me.lblMoqueca.BackColor = System.Drawing.SystemColors.HighlightText
        Me.lblMoqueca.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblMoqueca.Cursor = System.Windows.Forms.Cursors.Default
        Me.lblMoqueca.Font = New System.Drawing.Font("Mont Heavy DEMO", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMoqueca.ForeColor = System.Drawing.SystemColors.ControlText
        Me.lblMoqueca.Location = New System.Drawing.Point(27, 20)
        Me.lblMoqueca.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.lblMoqueca.Name = "lblMoqueca"
        Me.lblMoqueca.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblMoqueca.Size = New System.Drawing.Size(162, 36)
        Me.lblMoqueca.TabIndex = 11
        Me.lblMoqueca.Text = "Moqueca"
        Me.lblMoqueca.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'alacarteSetPanel
        '
        Me.alacarteSetPanel.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.alacarteSetPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.alacarteSetPanel.Controls.Add(Me.drinkGpBox)
        Me.alacarteSetPanel.Controls.Add(Me.Panel4)
        Me.alacarteSetPanel.Controls.Add(Me.Label8)
        Me.alacarteSetPanel.Location = New System.Drawing.Point(498, 102)
        Me.alacarteSetPanel.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.alacarteSetPanel.Name = "alacarteSetPanel"
        Me.alacarteSetPanel.Size = New System.Drawing.Size(569, 626)
        Me.alacarteSetPanel.TabIndex = 58
        Me.alacarteSetPanel.Visible = False
        '
        'Label8
        '
        Me.Label8.BackColor = System.Drawing.Color.Transparent
        Me.Label8.Font = New System.Drawing.Font("Mont Heavy DEMO", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.Black
        Me.Label8.Location = New System.Drawing.Point(171, 3)
        Me.Label8.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(225, 32)
        Me.Label8.TabIndex = 2
        Me.Label8.Text = "Ala Carte Set Menu"
        '
        'Label2
        '
        Me.Label2.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.Label2.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold)
        Me.Label2.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label2.Location = New System.Drawing.Point(1089, 623)
        Me.Label2.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label2.Size = New System.Drawing.Size(96, 43)
        Me.Label2.TabIndex = 67
        Me.Label2.Text = "Total Order"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'txtOrder
        '
        Me.txtOrder.BackColor = System.Drawing.SystemColors.HighlightText
        Me.txtOrder.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.txtOrder.Cursor = System.Windows.Forms.Cursors.Default
        Me.txtOrder.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold)
        Me.txtOrder.ForeColor = System.Drawing.SystemColors.ControlText
        Me.txtOrder.Location = New System.Drawing.Point(1195, 628)
        Me.txtOrder.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.txtOrder.Name = "txtOrder"
        Me.txtOrder.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtOrder.Size = New System.Drawing.Size(165, 33)
        Me.txtOrder.TabIndex = 68
        Me.txtOrder.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'orderForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.ClientSize = New System.Drawing.Size(1533, 795)
        Me.Controls.Add(Me.previousBtn)
        Me.Controls.Add(Me.Label19)
        Me.Controls.Add(Me.proceedBtn)
        Me.Controls.Add(Me.dispRecBtn)
        Me.Controls.Add(Me.clearBtn)
        Me.Controls.Add(Me.exitBtn)
        Me.Controls.Add(Me.printReceiptBtn)
        Me.Controls.Add(Me.txtOrder)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txtTotalOrder)
        Me.Controls.Add(Me.Label14)
        Me.Controls.Add(Me.picPanel)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.comboSetPanel)
        Me.Controls.Add(Me.alacarteSetPanel)
        Me.name = "orderForm"
        Me.Text = "orderForm"
        Me.paymentMethodRadBtnBox.ResumeLayout(False)
        Me.paymentMethodRadBtnBox.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.deliveryCbox.ResumeLayout(False)
        Me.deliveryCbox.PerformLayout()
        Me.picPanel.ResumeLayout(False)
        CType(Me.ribeyePicBox, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cheeseBreadPicBox, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.tortillaPicBox, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cappuchinoPicBox, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.rumpSteakPicBox, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.arabiataPicBox, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.feijoadaPicBox, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.caesaSaladPicBox, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.mojittoPicBox, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.salmonPicBox, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.moquecaPicBox, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.jerkyBeefPicBox, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.coconutPicBox, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lemonadePicBox, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.americanoPicBox, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.mangoPicBox, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.skyJuicePicBox, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.matchaPicBox, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.brigaderiosPicBox, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.drinkGpBox.ResumeLayout(False)
        Me.drinkGpBox.PerformLayout()
        Me.comboSetPanel.ResumeLayout(False)
        Me.Panel4.ResumeLayout(False)
        Me.Panel4.PerformLayout()
        CType(Me.PictureBox10, System.ComponentModel.ISupportInitialize).EndInit()
        Me.alacarteSetPanel.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Label3 As Label
    Friend WithEvents pdPrint As Printing.PrintDocument
    Friend WithEvents previousBtn As Button
    Friend WithEvents Label19 As Label
    Friend WithEvents setBtn As Button
    Friend WithEvents alaCarteBtn As Button
    Friend WithEvents PrintPreviewDialog1 As PrintPreviewDialog
    Friend WithEvents dispRecBtn As Button
    Friend WithEvents exitBtn As Button
    Friend WithEvents printReceiptBtn As Button
    Friend WithEvents clearBtn As Button
    Friend WithEvents lblAddress As Label
    Friend WithEvents lblFoodName As Label
    Friend WithEvents txtAddress As TextBox
    Friend WithEvents moquecaPicBox As PictureBox
    Friend WithEvents feijoadaPicBox As PictureBox
    Friend WithEvents tortillaPicBox As PictureBox
    Friend WithEvents brigaderiosPicBox As PictureBox
    Friend WithEvents ribeyePicBox As PictureBox
    Friend WithEvents rumpSteakPicBox As PictureBox
    Friend WithEvents mojittoPicBox As PictureBox
    Friend WithEvents coconutPicBox As PictureBox
    Friend WithEvents lemonadePicBox As PictureBox
    Friend WithEvents skyJuicePicBox As PictureBox
    Friend WithEvents americanoPicBox As PictureBox
    Friend WithEvents mangoPicBox As PictureBox
    Friend WithEvents selfPickRadBtn As RadioButton
    Friend WithEvents codRadBtn As RadioButton
    Friend WithEvents proceedBtn As Button
    Friend WithEvents txtTotalOrder As Label
    Friend WithEvents Label14 As Label
    Friend WithEvents matchaPicBox As PictureBox
    Friend WithEvents Label10 As Label
    Friend WithEvents txtPhone As TextBox
    Friend WithEvents txtIc As TextBox
    Friend WithEvents txtName As TextBox
    Friend WithEvents Label12 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents txtEmail As TextBox
    Friend WithEvents cashradBtn As RadioButton
    Friend WithEvents cheeseBreadPicBox As PictureBox
    Friend WithEvents paymentMethodRadBtnBox As GroupBox
    Friend WithEvents cardRadBtn As RadioButton
    Friend WithEvents Panel1 As Panel
    Friend WithEvents picPanel As Panel
    Friend WithEvents jerkyBeefPicBox As PictureBox
    Friend WithEvents salmonPicBox As PictureBox
    Friend WithEvents caesaSaladPicBox As PictureBox
    Friend WithEvents arabiataPicBox As PictureBox
    Friend WithEvents cappuchinoPicBox As PictureBox
    Friend WithEvents coconutChkBox As CheckBox
    Friend WithEvents Panel2 As Panel
    Friend WithEvents drinkGpBox As GroupBox
    Friend WithEvents creamyMangoChkBox As CheckBox
    Friend WithEvents skyJuiceChkBox As CheckBox
    Friend WithEvents americanoChkBox As CheckBox
    Friend WithEvents mojittoChkBox As CheckBox
    Friend WithEvents matchaChkBox As CheckBox
    Friend WithEvents lemonadeChkBox As CheckBox
    Friend WithEvents cappuchinoChkBox As CheckBox
    Friend WithEvents txtRumpsteak As TextBox
    Friend WithEvents txtSalmon As TextBox
    Friend WithEvents addRumpsteakBtn As Button
    Friend WithEvents addSalmonBtn As Button
    Friend WithEvents minusRumpsteakBtn As Button
    Friend WithEvents addRibeyeBtn As Button
    Friend WithEvents minusSalmonBtn As Button
    Friend WithEvents addTortillaBtn As Button
    Friend WithEvents minusRibeyeBtn As Button
    Friend WithEvents txtRibeye As TextBox
    Friend WithEvents minusTortillaBtn As Button
    Friend WithEvents lblRumpSteak As Label
    Friend WithEvents txtTortilla As TextBox
    Friend WithEvents lblSalmon As Label
    Friend WithEvents lblRibeye As Label
    Friend WithEvents lblTortilla As Label
    Friend WithEvents comboSetPanel As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents Panel4 As Panel
    Friend WithEvents addCheesebreadBtn As Button
    Friend WithEvents PictureBox10 As PictureBox
    Friend WithEvents addArabiataBtn As Button
    Friend WithEvents addCaesasaladBtn As Button
    Friend WithEvents addJerkybeefBtn As Button
    Friend WithEvents addBrigaderiosBtn As Button
    Friend WithEvents addFeijoadaBtn As Button
    Friend WithEvents minusCheeseBread As Button
    Friend WithEvents minusArabiataBtn As Button
    Friend WithEvents minusCaesasaladBtn As Button
    Friend WithEvents minusJerkyBeefBtn As Button
    Friend WithEvents minusBrigaderiosBtn As Button
    Friend WithEvents addMoquecaBtn As Button
    Friend WithEvents minusFeijoadaBtn As Button
    Friend WithEvents txtCheesebread As TextBox
    Friend WithEvents txtArabiata As TextBox
    Friend WithEvents minusMoquecaBtn As Button
    Friend WithEvents txtCaesasalad As TextBox
    Friend WithEvents txtJerkybeef As TextBox
    Friend WithEvents txtBrigaderios As TextBox
    Friend WithEvents txtFeijoada As TextBox
    Friend WithEvents lblCheeseBread As Label
    Friend WithEvents lblArabiata As Label
    Friend WithEvents txtMoqueca As TextBox
    Friend WithEvents lblCaesasalad As Label
    Friend WithEvents lblJerkyBeef As Label
    Friend WithEvents lblBrigaderios As Label
    Friend WithEvents lblFeijoada As Label
    Friend WithEvents lblMoqueca As Label
    Friend WithEvents alacarteSetPanel As Panel
    Friend WithEvents Label8 As Label
    Friend WithEvents Label16 As Label
    Friend WithEvents deliveryCbox As GroupBox
    Friend WithEvents Label2 As Label
    Friend WithEvents txtOrder As Label
    Friend WithEvents Label13 As Label
    Friend WithEvents Label7 As Label
End Class
