Imports System.IO


Public Class orderForm

    Dim i As Integer
    Dim menuAlaCarte() As String = {"Moqueca", "Feijoada", "Brigaderios", "Jerky Beef with Fries", "Traditional Caesa Salad", "Penne Arabiata", "Brazilian Cheese Bread"}

    Dim menuAlaCartePrice(,) = {{"Moqueca", "Feijoada", "Brigaderios", "Jerky Beef with Fries", "Traditional Caesa Salad", "Penne Arabiata", "Brazilian Cheese Bread"},
                                {20.6, 31.6, 21.6, 27.6, 15.6, 33.6, 9.6}}

    Dim menuCombo() As String = {"SET 1", "SET 2", "SET 3", "SET 4"}

    Dim menuComboPrice(,) = {{"SET 1", "SET 2", "SET 3", "SET 4"},
                                 {33.6, 55.6, 71.6, 63.2}}

    Dim drink() As String = {"Matcha", "Cappuchino", "Mojitto", "Coconut Water", "Lemonade", "Sky Juice", "Americano", "Creamy Mango"}

    Dim drinkPrice(,) = {{"Matcha", "Cappuchino", "Mojitto", "Coconut Water", "Lemonade", "Sky Juice", "Americano", "Creamy Mango"},
                         {15.0, 15.0, 15.0, 20.6, 12.6, 5.7, 15.6, 20.6}}

    Dim numOrderCombo() As String
    Dim numOrderAlaCarte() As String

    Dim personal() As String
    Dim personalInfo() As String = {"Name", "IC", "Phone Number", "Email", "Address"}

    'food menu
    Dim tortilla As Double
        Dim ribeye As Double
        Dim salmon As Double
        Dim rumpsteak As Double
        Dim moqueca As Double
        Dim feijoada As Double
        Dim brigaderios As Double
        Dim jerkybeef As Double
        Dim caesasalad As Double
        Dim arabiata As Double
        Dim cheesebread As Double

    ''drink menu
    Dim matcha As Double
        Dim cappuchino As Double
        Dim mojitto As Double
        Dim coconut As Double
        Dim lemonade As Double
        Dim skyJuice As Double
        Dim americano As Double
        Dim mango As Double

        Dim setFood() As String
        Dim comboMenu As Decimal
    Dim alaCarteMenu As Decimal

    Dim name As String
    Dim ic As String
    Dim phone As String
    Dim email As String
    Dim address As String
    Dim delivery As Double
    Dim total As Double
    Dim tax As Double
    Dim totalPrice As Double
    Dim verticalPosition As Integer
    Dim totalComboPrice As Double
    Dim totalAlaCartePrice As Double
    Dim totalDrinkPrice As Double
    Dim totalTaxPrice As Double

    Dim fileOrder As StreamWriter

    Private Sub setBtn_Click(sender As Object, e As EventArgs) Handles setBtn.Click
            comboSetPanel.Show()
            alacarteSetPanel.Hide()
        End Sub

        Private Sub alaCarteBtn_Click(sender As Object, e As EventArgs) Handles alaCarteBtn.Click
            alacarteSetPanel.Show()
        comboSetPanel.Hide()
        drinkGpBox.Show()
    End Sub

        Private Sub previousBtn_Click(sender As Object, e As EventArgs) Handles previousBtn.Click
            menuDisplay.Show()
            Me.Hide()
        End Sub

        Private Sub exitBtn_Click(sender As Object, e As EventArgs) Handles exitBtn.Click
            Close()
        MessageBox.Show("Thank you for using our system!", "Brasa Brazuca Restaurant")
        End
    End Sub

        Private Sub addTortillaBtn_Click(sender As Object, e As EventArgs) Handles addTortillaBtn.Click
            txtTortilla.Text += 1
        End Sub

        Private Sub minusTortillaBtn_Click(sender As Object, e As EventArgs) Handles minusTortillaBtn.Click
            txtTortilla.Text -= 1
            If txtTortilla.Text <= 0 Then
                txtTortilla.Text = 0
            End If
        End Sub

        Private Sub addRibeyeBtn_Click(sender As Object, e As EventArgs) Handles addRibeyeBtn.Click
            txtRibeye.Text += 1
        End Sub

        Private Sub minusRibeyeBtn_Click(sender As Object, e As EventArgs) Handles minusRibeyeBtn.Click
            txtRibeye.Text -= 1
            If txtRibeye.Text <= 0 Then
                txtRibeye.Text = 0
            End If
        End Sub

        Private Sub addSalmonBtn_Click(sender As Object, e As EventArgs) Handles addSalmonBtn.Click
            txtSalmon.Text += 1
        End Sub

        Private Sub minusSalmonBtn_Click(sender As Object, e As EventArgs) Handles minusSalmonBtn.Click
            txtSalmon.Text -= 1
            If txtSalmon.Text <= 0 Then
                txtSalmon.Text = 0
            End If
        End Sub

        Private Sub addRumpsteakBtn_Click(sender As Object, e As EventArgs) Handles addRumpsteakBtn.Click
            txtRumpsteak.Text += 1
        End Sub

        Private Sub minusRumpsteakBtn_Click(sender As Object, e As EventArgs) Handles minusRumpsteakBtn.Click
            txtRumpsteak.Text -= 1
            If txtRumpsteak.Text <= 0 Then
                txtRumpsteak.Text = 0
            End If
        End Sub

        Private Sub addMoquecaBtn_Click(sender As Object, e As EventArgs) Handles addMoquecaBtn.Click
            txtMoqueca.Text += 1
        End Sub

        Private Sub minusMoquecaBtn_Click(sender As Object, e As EventArgs) Handles minusMoquecaBtn.Click
            txtMoqueca.Text -= 1
            If txtMoqueca.Text <= 0 Then
                txtMoqueca.Text = 0
            End If
        End Sub

        Private Sub addFeijoadaBtn_Click(sender As Object, e As EventArgs) Handles addFeijoadaBtn.Click
            txtFeijoada.Text += 1
        End Sub

        Private Sub minusFeijoadaBtn_Click(sender As Object, e As EventArgs) Handles minusFeijoadaBtn.Click
            txtFeijoada.Text -= 1
            If txtFeijoada.Text <= 0 Then
                txtFeijoada.Text = 0
            End If
        End Sub

        Private Sub addBrigaderiosBtn_Click(sender As Object, e As EventArgs) Handles addBrigaderiosBtn.Click
            txtBrigaderios.Text += 1
        End Sub

        Private Sub minusBrigaderiosBtn_Click(sender As Object, e As EventArgs) Handles minusBrigaderiosBtn.Click
            txtBrigaderios.Text -= 1
            If txtBrigaderios.Text <= 0 Then
                txtBrigaderios.Text = 0
            End If
        End Sub

        Private Sub addJerkybeefBtn_Click(sender As Object, e As EventArgs) Handles addJerkybeefBtn.Click
            txtJerkybeef.Text += 1
        End Sub

        Private Sub minusJerkyBeefBtn_Click(sender As Object, e As EventArgs) Handles minusJerkyBeefBtn.Click
            txtJerkybeef.Text -= 1
            If txtJerkybeef.Text <= 0 Then
                txtJerkybeef.Text = 0
            End If
        End Sub

        Private Sub addCaesasaladBtn_Click(sender As Object, e As EventArgs) Handles addCaesasaladBtn.Click
            txtCaesasalad.Text += 1
        End Sub

        Private Sub minusCaesasaladBtn_Click(sender As Object, e As EventArgs) Handles minusCaesasaladBtn.Click
            txtCaesasalad.Text -= 1
            If txtCaesasalad.Text <= 0 Then
                txtCaesasalad.Text = 0
            End If
        End Sub

        Private Sub addArabiataBtn_Click(sender As Object, e As EventArgs) Handles addArabiataBtn.Click
            txtArabiata.Text += 1
        End Sub

        Private Sub minusArabiataBtn_Click(sender As Object, e As EventArgs) Handles minusArabiataBtn.Click
            txtArabiata.Text -= 1
            If txtArabiata.Text <= 0 Then
                txtArabiata.Text = 0
            End If
        End Sub

        Private Sub addCheesebreadBtn_Click(sender As Object, e As EventArgs) Handles addCheesebreadBtn.Click
            txtCheesebread.Text += 1
        End Sub

        Private Sub minusCheeseBread_Click(sender As Object, e As EventArgs) Handles minusCheeseBread.Click
            txtCheesebread.Text -= 1
            If txtCheesebread.Text <= 0 Then
                txtCheesebread.Text = 0
            End If
        End Sub

        Private Sub clearBtn_Click(sender As Object, e As EventArgs) Handles clearBtn.Click
            ''clear customer info
            txtName.Text = Nothing
            txtIc.Text = Nothing
            txtPhone.Text = Nothing
            txtEmail.Text = Nothing
            txtAddress.Text = Nothing
            cashradBtn.Checked = Nothing
            cardRadBtn.Checked = Nothing
            codRadBtn.Checked = Nothing
            selfPickRadBtn.Checked = Nothing
            ''clear all food order
            txtTortilla.Text = 0
            txtRibeye.Text = 0
            txtSalmon.Text = 0
            txtRumpsteak.Text = 0
            txtMoqueca.Text = 0
            txtFeijoada.Text = 0
            txtBrigaderios.Text = 0
            txtCaesasalad.Text = 0
            txtArabiata.Text = 0
            txtCheesebread.Text = 0
            txtTotalOrder.Text = 0
            matchaChkBox.Checked = Nothing
            cappuchinoChkBox.Checked = Nothing
            mojittoChkBox.Checked = Nothing
            coconutChkBox.Checked = Nothing
            lemonadeChkBox.Checked = Nothing
            skyJuiceChkBox.Checked = Nothing
            americanoChkBox.Checked = Nothing
            creamyMangoChkBox.Checked = Nothing
            moquecaPicBox.Visible = False
            feijoadaPicBox.Visible = False
            brigaderiosPicBox.Visible = False
            jerkyBeefPicBox.Visible = False
            caesaSaladPicBox.Visible = False
            arabiataPicBox.Visible = False
            cheeseBreadPicBox.Visible = False
            tortillaPicBox.Visible = False
            ribeyePicBox.Visible = False
            salmonPicBox.Visible = False
            rumpSteakPicBox.Visible = False
            matchaPicBox.Visible = False
            cappuchinoPicBox.Visible = False
            coconutPicBox.Visible = False
            lemonadePicBox.Visible = False
            skyJuicePicBox.Visible = False
            americanoPicBox.Visible = False
            mangoPicBox.Visible = False
            mojittoPicBox.Visible = False
            lblFoodName.Text = Nothing
        End Sub

        Private Sub codRadBtn_CheckedChanged(sender As Object, e As EventArgs) Handles codRadBtn.CheckedChanged
            If codRadBtn.Checked Then
            txtAddress.Visible = True
            lblAddress.Visible = True
        ElseIf selfPickRadBtn.Checked Then
            txtAddress.Visible = False
            lblAddress.Visible = False
        End If
        End Sub

    Private Sub proceedBtn_Click(sender As Object, e As EventArgs) Handles proceedBtn.Click

        If txtName.Text = String.Empty Then
            MsgBox("Please enter your name!", MsgBoxStyle.Critical, "Warning!")
            txtName.Focus()
        End If

        If txtIc.Text = String.Empty Then
            MsgBox("Please enter your IC!", MsgBoxStyle.Critical, "Warning!")
            txtIc.Focus()
        End If

        If txtPhone.Text = String.Empty Then
            MsgBox("Please enter your phone number!", MsgBoxStyle.Critical, "Warning!")
            txtPhone.Focus()
        End If

        If txtEmail.Text = String.Empty Then
            MsgBox("Please enter your email!", MsgBoxStyle.Critical, "Warning!")
            txtEmail.Focus()
        End If

        If codRadBtn.Checked Then
            delivery = 7.0
        ElseIf selfPickRadBtn.Checked Then
            delivery = 0.0
        Else
            MsgBox("Please choose your delivery method!", MsgBoxStyle.Critical, "Warning!")
        End If

        If txtAddress.Text = String.Empty And codRadBtn.Checked Then
            MsgBox("Please enter your address for delivery method!", MsgBoxStyle.Critical, "Warning!")
            txtAddress.Focus()
        End If

        'ala carte set price
        moqueca = txtMoqueca.Text * 20.6
        feijoada = txtFeijoada.Text * 31.6
        brigaderios = txtBrigaderios.Text * 21.6
        jerkybeef = txtJerkybeef.Text * 27.6
        caesasalad = txtCaesasalad.Text * 15.6
        arabiata = txtArabiata.Text * 33.6
        cheesebread = txtCheesebread.Text * 9.6

        'combo set price
        tortilla = txtTortilla.Text * 33.6
        ribeye = txtRibeye.Text * 55.6
        salmon = txtSalmon.Text * 71.6
        rumpsteak = txtRumpsteak.Text * 63.2

        'beverages
        If matchaChkBox.Checked Then
            matcha = 15.0
        End If

        If cappuchinoChkBox.Checked Then
            cappuchino = 15.0
        End If

        If mojittoChkBox.Checked Then
            mojitto = 15.0
        End If

        If coconutChkBox.Checked Then
            coconut = 20.6
        End If

        If lemonadeChkBox.Checked Then
            lemonade = 12.6
        End If

        If skyJuiceChkBox.Checked Then
            skyJuice = 5.7
        End If

        If americanoChkBox.Checked Then
            americano = 15.6
        End If

        If creamyMangoChkBox.Checked Then
            mango = 20.6
        End If

        totalComboPrice = tortilla + ribeye + salmon + rumpsteak
        totalAlaCartePrice = moqueca + feijoada + brigaderios + jerkybeef + caesasalad + arabiata + cheesebread
        totalDrinkPrice = matcha + cappuchino + mojitto + coconut + lemonade + skyJuice + americano + mango



        total = moqueca + feijoada + brigaderios + jerkybeef + caesasalad + arabiata + cheesebread + tortilla + ribeye + salmon + rumpsteak +
                matcha + cappuchino + mojitto + coconut + lemonade + skyJuice + americano + mango + delivery

        txtOrder.Text = "RM" & total.ToString("n2")

        tax = 0.06

        totalTaxPrice = total * tax

        totalPrice = total + totalTaxPrice

        txtTotalOrder.Text = "RM" & totalPrice.ToString("n2")

        address = txtAddress.Text

        ReDim numOrderCombo(4)

        numOrderCombo(0) = txtTortilla.Text
        numOrderCombo(1) = txtRibeye.Text
        numOrderCombo(2) = txtSalmon.Text
        numOrderCombo(3) = txtRumpsteak.Text

        ReDim numOrderAlaCarte(7)

        numOrderAlaCarte(0) = txtMoqueca.Text
        numOrderAlaCarte(1) = txtFeijoada.Text
        numOrderAlaCarte(2) = txtBrigaderios.Text
        numOrderAlaCarte(3) = txtJerkybeef.Text
        numOrderAlaCarte(4) = txtCaesasalad.Text
        numOrderAlaCarte(5) = txtArabiata.Text
        numOrderAlaCarte(6) = txtCheesebread.Text



        'If (name) AndAlso (phone) AndAlso (address) AndAlso (ic) AndAlso (delivery) Then

        '    txtTotalOrder.Text = "RM" & totalPrice.ToString("n2")

        '    Try
        '        fileOrder = File.AppendText("customerOrderFile.txt")

        '        fileOrder.Write("-------------------------------------------------------------------------------------------------")
        '        fileOrder.Write(ControlChars.NewLine & "Order Receipt By " & txtName.Text)
        '        fileOrder.Write(ControlChars.NewLine & "-------------------------------------------------------------------------------------------------")
        '        fileOrder.Write(ControlChars.NewLine & "Receipent Personal Information")
        '        fileOrder.Write(ControlChars.NewLine & "-------------------------------------------------------------------------------------------------")
        '        For i As Integer = 0 To personalInfo.Length - 1
        '            If (i = 1) Or (i = 3) Then
        '                fileOrder.Write(ControlChars.NewLine & personalInfo(i) & ControlChars.Tab & ": " & Personal(i))
        '            Else
        '                fileOrder.Write(ControlChars.NewLine & personalInfo(i) & ControlChars.Tab & ControlChars.Tab & ": " & Personal(i))
        '            End If
        '        Next
        '        fileOrder.Write(ControlChars.NewLine & "-------------------------------------------------------------------------------------------------")
        '        fileOrder.Write(ControlChars.NewLine & "Receipent Ordering Information")
        '        fileOrder.Write(ControlChars.NewLine & "-------------------------------------------------------------------------------------------------")
        '        fileOrder.Write(ControlChars.NewLine & "Set Order Details  : ")
        '        Dim haveSet, haveAla As Boolean
        '        Dim once As Integer
        '        once = 0
        '        haveSet = False
        '        haveAla = False
        '        For i As Integer = 0 To ListSetFood.Length - 1
        '            If setFood(i) > 0 Then
        '                haveSet = True
        '                If once = 0 Then
        '                    fileOrder.Write(ControlChars.Tab & ControlChars.Tab & ControlChars.Tab & "            " & "Quantity")
        '                    fileOrder.WriteLine(ControlChars.Tab & ControlChars.Tab & ControlChars.Tab & "Price")
        '                    once = once + 1
        '                End If
        '                fileOrder.Write(ControlChars.NewLine & ListSetFood(i) & "       " & ControlChars.Tab & ControlChars.Tab & ControlChars.Tab & ControlChars.Tab & ControlChars.Tab & ControlChars.Tab & setFood(i) & ControlChars.Tab & ControlChars.Tab & ControlChars.Tab & "$" & Format((ListSetFood1(1, i) * setFood(i)), "0.00"))
        '            End If
        '        Next
        '        If haveSet = False Then
        '            fileOrder.WriteLine(ControlChars.NewLine & "{Customer did not order any Set Menu}")
        '        End If
        '        fileOrder.Write(ControlChars.NewLine & ControlChars.NewLine & "Ala Carte Order Details  : ")
        '        once = 0
        '        For i As Integer = 0 To Menu.Length - 1
        '            If numOrders(i) > 0 Then
        '                haveAla = True
        '                If once = 0 Then
        '                    fileOrder.Write(ControlChars.Tab & ControlChars.Tab & ControlChars.Tab & "     " & "Quantity")
        '                    fileOrder.WriteLine(ControlChars.Tab & ControlChars.Tab & ControlChars.Tab & "Price")
        '                    once = once + 1
        '                End If

        '                If (i = 6) Or (i = 7) Then
        '                    fileOrder.Write(ControlChars.NewLine & orders(i) & ControlChars.Tab & ControlChars.Tab & ControlChars.Tab & ControlChars.Tab & ControlChars.Tab & numOrders(i) & ControlChars.Tab & ControlChars.Tab & ControlChars.Tab & "$" & Format((orders1(1, i) * numOrders(i)), "0.00"))
        '                Else
        '                    fileOrder.Write(ControlChars.NewLine & orders(i) & ControlChars.Tab & ControlChars.Tab & ControlChars.Tab & ControlChars.Tab & ControlChars.Tab & ControlChars.Tab & numOrders(i) & ControlChars.Tab & ControlChars.Tab & ControlChars.Tab & "$" & Format((orders1(1, i) * numOrders(i)), "0.00"))
        '                End If

        '            End If
        '        Next

        '        If haveAla = False Then
        '            fileOrder.WriteLine(ControlChars.NewLine & "{Customer did not order any Ala Cart Menu}")
        '        End If
        '        fileOrder.WriteLine(ControlChars.NewLine & "-------------------------------------------------------------------------------------------------")
        '        fileOrder.WriteLine("Total price for selected Set(s) menu : " & "$" & Format(comboMenu, "0.00"))
        '        fileOrder.WriteLine("Total price for selected Ala carte(s) menu : " & "$" & Format(alaCarteMenu, "0.00"))
        '        fileOrder.WriteLine("Delivery charge : " & "$" & Format(delivery, "0.00"))
        '        fileOrder.WriteLine("Tax Price : " & "$" & Format(tax, "0.00"))
        '        fileOrder.WriteLine("Total amount customer must pay : " & "$" & Format(totalPrice, "0.00"))
        '        fileOrder.Write(ControlChars.NewLine & "-------------------------------------------------------------------------------------------------")
        '        fileOrder.Close()

        '    Catch ex As Exception
        '        MessageBox.Show("Error: The file cannot be created.")
        '    End Try

        '    Try
        '        fileOrder = File.AppendText("orderSummaryFile.txt")

        '        fileOrder.Write(setFood(0))
        '        fileOrder.Write(":")
        '        fileOrder.Write(setFood(1))
        '        fileOrder.Write(":")
        '        fileOrder.Write(setFood(2))
        '        fileOrder.Write(":")
        '        fileOrder.Write(Format(comboMenu.ToString), 2)
        '        fileOrder.Write(":")
        '        fileOrder.Write(Format(alaCarteMenu.ToString), 2)
        '        fileOrder.Write(":")
        '        fileOrder.Write(Format(delivery.ToString), 2)
        '        fileOrder.Write(":")
        '        fileOrder.Write(Format(tax.ToString), 2)
        '        fileOrder.Write(":")
        '        fileOrder.WriteLine(Format(totalPrice.ToString), 2)

        '        fileOrder.Close()

        '    Catch ex As Exception
        '        MessageBox.Show("Error: The file cannot be created.")
        '    End Try
        'End If



        'Try
        '    customerFile = File.CreateText("customerReceipts.txt")
        '    customerFile = File.AppendText("customerReceipt.txt")
        '    customerFile.Write("-------------------------------------------")
        '    customerFile.Write("Order Receipt By" + txtName.Text)
        '    customerFile.Write("-------------------------------------------")



        'Catch ex As Exception
        '    MsgBox("Error")
        'End Try



    End Sub



    Private Sub lblMoqueca_Click(sender As Object, e As EventArgs) Handles lblMoqueca.Click
            moquecaPicBox.Visible = True
            feijoadaPicBox.Visible = False
            brigaderiosPicBox.Visible = False
            jerkyBeefPicBox.Visible = False
            caesaSaladPicBox.Visible = False
            arabiataPicBox.Visible = False
            cheeseBreadPicBox.Visible = False
            tortillaPicBox.Visible = False
            ribeyePicBox.Visible = False
            salmonPicBox.Visible = False
            rumpSteakPicBox.Visible = False
            matchaPicBox.Visible = False
            cappuchinoPicBox.Visible = False
            coconutPicBox.Visible = False
            lemonadePicBox.Visible = False
            skyJuicePicBox.Visible = False
            americanoPicBox.Visible = False
            mangoPicBox.Visible = False
            mojittoPicBox.Visible = False
            lblFoodName.Text = "Moqueca (RM20.60)"
        End Sub

        Private Sub lblFeijoada_Click(sender As Object, e As EventArgs) Handles lblFeijoada.Click
            feijoadaPicBox.Visible = True
            moquecaPicBox.Visible = False
            brigaderiosPicBox.Visible = False
            jerkyBeefPicBox.Visible = False
            caesaSaladPicBox.Visible = False
            arabiataPicBox.Visible = False
            cheeseBreadPicBox.Visible = False
            tortillaPicBox.Visible = False
            ribeyePicBox.Visible = False
            salmonPicBox.Visible = False
            rumpSteakPicBox.Visible = False
            matchaPicBox.Visible = False
            cappuchinoPicBox.Visible = False
            coconutPicBox.Visible = False
            lemonadePicBox.Visible = False
            skyJuicePicBox.Visible = False
            americanoPicBox.Visible = False
            mangoPicBox.Visible = False
            mojittoPicBox.Visible = False
            lblFoodName.Text = "Feijoada (RM31.60)"
        End Sub

        Private Sub lblBrigaderios_Click(sender As Object, e As EventArgs) Handles lblBrigaderios.Click
            brigaderiosPicBox.Visible = True
            feijoadaPicBox.Visible = False
            moquecaPicBox.Visible = False
            jerkyBeefPicBox.Visible = False
            caesaSaladPicBox.Visible = False
            arabiataPicBox.Visible = False
            cheeseBreadPicBox.Visible = False
            tortillaPicBox.Visible = False
            ribeyePicBox.Visible = False
            salmonPicBox.Visible = False
            rumpSteakPicBox.Visible = False
            matchaPicBox.Visible = False
            cappuchinoPicBox.Visible = False
            coconutPicBox.Visible = False
            lemonadePicBox.Visible = False
            skyJuicePicBox.Visible = False
            americanoPicBox.Visible = False
            mangoPicBox.Visible = False
            mojittoPicBox.Visible = False
            lblFoodName.Text = "Brigaderios (RM21.60)"
        End Sub

        Private Sub lblJerkyBeef_Click(sender As Object, e As EventArgs) Handles lblJerkyBeef.Click
            jerkyBeefPicBox.Visible = True
            brigaderiosPicBox.Visible = False
            feijoadaPicBox.Visible = False
            moquecaPicBox.Visible = False
            caesaSaladPicBox.Visible = False
            arabiataPicBox.Visible = False
            cheeseBreadPicBox.Visible = False
            tortillaPicBox.Visible = False
            ribeyePicBox.Visible = False
            salmonPicBox.Visible = False
            rumpSteakPicBox.Visible = False
            matchaPicBox.Visible = False
            cappuchinoPicBox.Visible = False
            coconutPicBox.Visible = False
            lemonadePicBox.Visible = False
            skyJuicePicBox.Visible = False
            americanoPicBox.Visible = False
            mangoPicBox.Visible = False
            mojittoPicBox.Visible = False
            lblFoodName.Text = "Jerky Beef with Fries (RM27.60)"
        End Sub

        Private Sub lblCaesasalad_Click(sender As Object, e As EventArgs) Handles lblCaesasalad.Click
            caesaSaladPicBox.Visible = True
            jerkyBeefPicBox.Visible = False
            brigaderiosPicBox.Visible = False
            feijoadaPicBox.Visible = False
            moquecaPicBox.Visible = False
            arabiataPicBox.Visible = False
            cheeseBreadPicBox.Visible = False
            tortillaPicBox.Visible = False
            ribeyePicBox.Visible = False
            salmonPicBox.Visible = False
            rumpSteakPicBox.Visible = False
            matchaPicBox.Visible = False
            cappuchinoPicBox.Visible = False
            coconutPicBox.Visible = False
            lemonadePicBox.Visible = False
            skyJuicePicBox.Visible = False
            americanoPicBox.Visible = False
            mangoPicBox.Visible = False
            mojittoPicBox.Visible = False
            lblFoodName.Text = "Traditional Caesa Salad (RM15.60)"
        End Sub

        Private Sub lblArabiata_Click(sender As Object, e As EventArgs) Handles lblArabiata.Click
            arabiataPicBox.Visible = True
            caesaSaladPicBox.Visible = False
            jerkyBeefPicBox.Visible = False
            brigaderiosPicBox.Visible = False
            feijoadaPicBox.Visible = False
            moquecaPicBox.Visible = False
            caesaSaladPicBox.Visible = False
            cheeseBreadPicBox.Visible = False
            tortillaPicBox.Visible = False
            ribeyePicBox.Visible = False
            salmonPicBox.Visible = False
            rumpSteakPicBox.Visible = False
            matchaPicBox.Visible = False
            cappuchinoPicBox.Visible = False
            coconutPicBox.Visible = False
            lemonadePicBox.Visible = False
            skyJuicePicBox.Visible = False
            americanoPicBox.Visible = False
            mangoPicBox.Visible = False
            mojittoPicBox.Visible = False
            lblFoodName.Text = "Penne Arabiata (RM33.60)"
        End Sub

        Private Sub lblCheeseBread_Click(sender As Object, e As EventArgs) Handles lblCheeseBread.Click
            cheeseBreadPicBox.Visible = True
            arabiataPicBox.Visible = False
            caesaSaladPicBox.Visible = False
            jerkyBeefPicBox.Visible = False
            brigaderiosPicBox.Visible = False
            feijoadaPicBox.Visible = False
            moquecaPicBox.Visible = False
            caesaSaladPicBox.Visible = False
            arabiataPicBox.Visible = False
            tortillaPicBox.Visible = False
            ribeyePicBox.Visible = False
            salmonPicBox.Visible = False
            rumpSteakPicBox.Visible = False
            matchaPicBox.Visible = False
            cappuchinoPicBox.Visible = False
            coconutPicBox.Visible = False
            lemonadePicBox.Visible = False
            skyJuicePicBox.Visible = False
            americanoPicBox.Visible = False
            mangoPicBox.Visible = False
            mojittoPicBox.Visible = False
            lblFoodName.Text = "Brazillian Cheese Bread (RM9.60)"
        End Sub

        Private Sub lblTortilla_Click(sender As Object, e As EventArgs) Handles lblTortilla.Click
            tortillaPicBox.Visible = True
            cheeseBreadPicBox.Visible = False
            arabiataPicBox.Visible = False
            caesaSaladPicBox.Visible = False
            jerkyBeefPicBox.Visible = False
            brigaderiosPicBox.Visible = False
            feijoadaPicBox.Visible = False
            moquecaPicBox.Visible = False
            caesaSaladPicBox.Visible = False
            arabiataPicBox.Visible = False
            cheeseBreadPicBox.Visible = False
            ribeyePicBox.Visible = False
            salmonPicBox.Visible = False
            rumpSteakPicBox.Visible = False
            matchaPicBox.Visible = False
            cappuchinoPicBox.Visible = False
            coconutPicBox.Visible = False
            lemonadePicBox.Visible = False
            skyJuicePicBox.Visible = False
            americanoPicBox.Visible = False
        mangoPicBox.Visible = True
        mojittoPicBox.Visible = False
        lblFoodName.Text = "Chicken Tortilla Wrap + Creamy Mango (RM33.60)"
    End Sub

        Private Sub lblRibeye_Click(sender As Object, e As EventArgs) Handles lblRibeye.Click
            ribeyePicBox.Visible = True
            tortillaPicBox.Visible = False
            cheeseBreadPicBox.Visible = False
            arabiataPicBox.Visible = False
            caesaSaladPicBox.Visible = False
            jerkyBeefPicBox.Visible = False
            brigaderiosPicBox.Visible = False
            feijoadaPicBox.Visible = False
            moquecaPicBox.Visible = False
            caesaSaladPicBox.Visible = False
            arabiataPicBox.Visible = False
            cheeseBreadPicBox.Visible = False
            tortillaPicBox.Visible = False
            salmonPicBox.Visible = False
            rumpSteakPicBox.Visible = False
        matchaPicBox.Visible = True
        cappuchinoPicBox.Visible = False
            coconutPicBox.Visible = False
            lemonadePicBox.Visible = False
            skyJuicePicBox.Visible = False
            americanoPicBox.Visible = False
            mangoPicBox.Visible = False
            mojittoPicBox.Visible = False
        lblFoodName.Text = "Ribeye Steak + Matcha (RM55.60)"
    End Sub

        Private Sub lblSalmon_Click(sender As Object, e As EventArgs) Handles lblSalmon.Click
            salmonPicBox.Visible = True
            ribeyePicBox.Visible = False
            tortillaPicBox.Visible = False
            cheeseBreadPicBox.Visible = False
            arabiataPicBox.Visible = False
            caesaSaladPicBox.Visible = False
            jerkyBeefPicBox.Visible = False
            brigaderiosPicBox.Visible = False
            feijoadaPicBox.Visible = False
            moquecaPicBox.Visible = False
            caesaSaladPicBox.Visible = False
            arabiataPicBox.Visible = False
            cheeseBreadPicBox.Visible = False
            tortillaPicBox.Visible = False
            ribeyePicBox.Visible = False
            rumpSteakPicBox.Visible = False
            matchaPicBox.Visible = False
            cappuchinoPicBox.Visible = False
            coconutPicBox.Visible = False
            lemonadePicBox.Visible = False
            skyJuicePicBox.Visible = False
            americanoPicBox.Visible = False
            mangoPicBox.Visible = False
        mojittoPicBox.Visible = True
        lblFoodName.Text = "Norway Salmon + Mojitto (RM71.60)"
    End Sub

        Private Sub lblRumpSteak_Click(sender As Object, e As EventArgs) Handles lblRumpSteak.Click
            rumpSteakPicBox.Visible = True
            salmonPicBox.Visible = False
            ribeyePicBox.Visible = False
            tortillaPicBox.Visible = False
            cheeseBreadPicBox.Visible = False
            arabiataPicBox.Visible = False
            caesaSaladPicBox.Visible = False
            jerkyBeefPicBox.Visible = False
            brigaderiosPicBox.Visible = False
            feijoadaPicBox.Visible = False
            moquecaPicBox.Visible = False
            caesaSaladPicBox.Visible = False
            arabiataPicBox.Visible = False
            cheeseBreadPicBox.Visible = False
            tortillaPicBox.Visible = False
            ribeyePicBox.Visible = False
            salmonPicBox.Visible = False
            matchaPicBox.Visible = False
            cappuchinoPicBox.Visible = False
        coconutPicBox.Visible = True
        lemonadePicBox.Visible = False
            skyJuicePicBox.Visible = False
            americanoPicBox.Visible = False
            mangoPicBox.Visible = False
            mojittoPicBox.Visible = False
        lblFoodName.Text = "Samba Rump Steak + Coconut Water (RM63.20)"
    End Sub

        Private Sub matchaChkBox_CheckedChanged(sender As Object, e As EventArgs) Handles matchaChkBox.CheckedChanged
            matchaPicBox.Visible = True
            rumpSteakPicBox.Visible = False
            salmonPicBox.Visible = False
            ribeyePicBox.Visible = False
            tortillaPicBox.Visible = False
            cheeseBreadPicBox.Visible = False
            arabiataPicBox.Visible = False
            caesaSaladPicBox.Visible = False
            jerkyBeefPicBox.Visible = False
            brigaderiosPicBox.Visible = False
            feijoadaPicBox.Visible = False
            moquecaPicBox.Visible = False
            caesaSaladPicBox.Visible = False
            arabiataPicBox.Visible = False
            cheeseBreadPicBox.Visible = False
            tortillaPicBox.Visible = False
            ribeyePicBox.Visible = False
            salmonPicBox.Visible = False
            rumpSteakPicBox.Visible = False
            cappuchinoPicBox.Visible = False
            coconutPicBox.Visible = False
            lemonadePicBox.Visible = False
            skyJuicePicBox.Visible = False
            americanoPicBox.Visible = False
            mangoPicBox.Visible = False
            mojittoPicBox.Visible = False
            lblFoodName.Text = "Matcha (RM15.00)"
        End Sub

        Private Sub cappuchinoChkBox_CheckedChanged(sender As Object, e As EventArgs) Handles cappuchinoChkBox.CheckedChanged
            cappuchinoPicBox.Visible = True
            matchaPicBox.Visible = False
            rumpSteakPicBox.Visible = False
            salmonPicBox.Visible = False
            ribeyePicBox.Visible = False
            tortillaPicBox.Visible = False
            cheeseBreadPicBox.Visible = False
            arabiataPicBox.Visible = False
            caesaSaladPicBox.Visible = False
            jerkyBeefPicBox.Visible = False
            brigaderiosPicBox.Visible = False
            feijoadaPicBox.Visible = False
            moquecaPicBox.Visible = False
            caesaSaladPicBox.Visible = False
            arabiataPicBox.Visible = False
            cheeseBreadPicBox.Visible = False
            tortillaPicBox.Visible = False
            ribeyePicBox.Visible = False
            salmonPicBox.Visible = False
            rumpSteakPicBox.Visible = False
            matchaPicBox.Visible = False
            coconutPicBox.Visible = False
            lemonadePicBox.Visible = False
            skyJuicePicBox.Visible = False
            americanoPicBox.Visible = False
            mangoPicBox.Visible = False
            mojittoPicBox.Visible = False
            lblFoodName.Text = "Cappuchino (RM15.00)"
        End Sub

        Private Sub mojittoChkBox_CheckedChanged(sender As Object, e As EventArgs) Handles mojittoChkBox.CheckedChanged
            mojittoPicBox.Visible = True
            cappuchinoPicBox.Visible = False
            matchaPicBox.Visible = False
            rumpSteakPicBox.Visible = False
            salmonPicBox.Visible = False
            ribeyePicBox.Visible = False
            tortillaPicBox.Visible = False
            cheeseBreadPicBox.Visible = False
            arabiataPicBox.Visible = False
            caesaSaladPicBox.Visible = False
            jerkyBeefPicBox.Visible = False
            brigaderiosPicBox.Visible = False
            feijoadaPicBox.Visible = False
            moquecaPicBox.Visible = False
            caesaSaladPicBox.Visible = False
            arabiataPicBox.Visible = False
            cheeseBreadPicBox.Visible = False
            tortillaPicBox.Visible = False
            ribeyePicBox.Visible = False
            salmonPicBox.Visible = False
            rumpSteakPicBox.Visible = False
            matchaPicBox.Visible = False
            cappuchinoPicBox.Visible = False
            coconutPicBox.Visible = False
            lemonadePicBox.Visible = False
            skyJuicePicBox.Visible = False
            americanoPicBox.Visible = False
            mangoPicBox.Visible = False
            lblFoodName.Text = "Mojitto (RM15.00)"
        End Sub

        Private Sub coconutChkBox_CheckedChanged(sender As Object, e As EventArgs) Handles coconutChkBox.CheckedChanged
            coconutPicBox.Visible = True
            mojittoPicBox.Visible = False
            cappuchinoPicBox.Visible = False
            matchaPicBox.Visible = False
            rumpSteakPicBox.Visible = False
            salmonPicBox.Visible = False
            ribeyePicBox.Visible = False
            tortillaPicBox.Visible = False
            cheeseBreadPicBox.Visible = False
            arabiataPicBox.Visible = False
            caesaSaladPicBox.Visible = False
            jerkyBeefPicBox.Visible = False
            brigaderiosPicBox.Visible = False
            feijoadaPicBox.Visible = False
            moquecaPicBox.Visible = False
            caesaSaladPicBox.Visible = False
            arabiataPicBox.Visible = False
            cheeseBreadPicBox.Visible = False
            tortillaPicBox.Visible = False
            ribeyePicBox.Visible = False
            salmonPicBox.Visible = False
            rumpSteakPicBox.Visible = False
            matchaPicBox.Visible = False
            cappuchinoPicBox.Visible = False
            lemonadePicBox.Visible = False
            skyJuicePicBox.Visible = False
            americanoPicBox.Visible = False
            mangoPicBox.Visible = False
            lblFoodName.Text = "Coconut Water (RM20.60)"
        End Sub

        Private Sub lemonadeChkBox_CheckedChanged(sender As Object, e As EventArgs) Handles lemonadeChkBox.CheckedChanged
            lemonadePicBox.Visible = True
            coconutPicBox.Visible = False
            mojittoPicBox.Visible = False
            cappuchinoPicBox.Visible = False
            matchaPicBox.Visible = False
            rumpSteakPicBox.Visible = False
            salmonPicBox.Visible = False
            ribeyePicBox.Visible = False
            tortillaPicBox.Visible = False
            cheeseBreadPicBox.Visible = False
            arabiataPicBox.Visible = False
            caesaSaladPicBox.Visible = False
            jerkyBeefPicBox.Visible = False
            brigaderiosPicBox.Visible = False
            feijoadaPicBox.Visible = False
            moquecaPicBox.Visible = False
            caesaSaladPicBox.Visible = False
            arabiataPicBox.Visible = False
            cheeseBreadPicBox.Visible = False
            tortillaPicBox.Visible = False
            ribeyePicBox.Visible = False
            salmonPicBox.Visible = False
            rumpSteakPicBox.Visible = False
            matchaPicBox.Visible = False
            cappuchinoPicBox.Visible = False
            coconutPicBox.Visible = False
            skyJuicePicBox.Visible = False
            americanoPicBox.Visible = False
            mangoPicBox.Visible = False
            lblFoodName.Text = "Lemonade (RM12.60)"
        End Sub

        Private Sub skyJuiceChkBox_CheckedChanged(sender As Object, e As EventArgs) Handles skyJuiceChkBox.CheckedChanged
            skyJuicePicBox.Visible = True
            lemonadePicBox.Visible = False
            coconutPicBox.Visible = False
            mojittoPicBox.Visible = False
            cappuchinoPicBox.Visible = False
            matchaPicBox.Visible = False
            rumpSteakPicBox.Visible = False
            salmonPicBox.Visible = False
            ribeyePicBox.Visible = False
            tortillaPicBox.Visible = False
            cheeseBreadPicBox.Visible = False
            arabiataPicBox.Visible = False
            caesaSaladPicBox.Visible = False
            jerkyBeefPicBox.Visible = False
            brigaderiosPicBox.Visible = False
            feijoadaPicBox.Visible = False
            moquecaPicBox.Visible = False
            caesaSaladPicBox.Visible = False
            arabiataPicBox.Visible = False
            cheeseBreadPicBox.Visible = False
            tortillaPicBox.Visible = False
            ribeyePicBox.Visible = False
            salmonPicBox.Visible = False
            rumpSteakPicBox.Visible = False
            matchaPicBox.Visible = False
            cappuchinoPicBox.Visible = False
            coconutPicBox.Visible = False
            americanoPicBox.Visible = False
            mangoPicBox.Visible = False
            lblFoodName.Text = "Sky Juice (RM5.70)"
        End Sub

        Private Sub americanoChkBox_CheckedChanged(sender As Object, e As EventArgs) Handles americanoChkBox.CheckedChanged
            americanoPicBox.Visible = True
            skyJuicePicBox.Visible = False
            lemonadePicBox.Visible = False
            coconutPicBox.Visible = False
            mojittoPicBox.Visible = False
            cappuchinoPicBox.Visible = False
            matchaPicBox.Visible = False
            rumpSteakPicBox.Visible = False
            salmonPicBox.Visible = False
            ribeyePicBox.Visible = False
            tortillaPicBox.Visible = False
            cheeseBreadPicBox.Visible = False
            arabiataPicBox.Visible = False
            caesaSaladPicBox.Visible = False
            jerkyBeefPicBox.Visible = False
            brigaderiosPicBox.Visible = False
            feijoadaPicBox.Visible = False
            moquecaPicBox.Visible = False
            caesaSaladPicBox.Visible = False
            arabiataPicBox.Visible = False
            cheeseBreadPicBox.Visible = False
            tortillaPicBox.Visible = False
            ribeyePicBox.Visible = False
            salmonPicBox.Visible = False
            rumpSteakPicBox.Visible = False
            matchaPicBox.Visible = False
            cappuchinoPicBox.Visible = False
            coconutPicBox.Visible = False
            mangoPicBox.Visible = False
            lblFoodName.Text = "Americano (RM15.60)"
        End Sub

        Private Sub creamyMangoChkBox_CheckedChanged(sender As Object, e As EventArgs) Handles creamyMangoChkBox.CheckedChanged
            mangoPicBox.Visible = True
            americanoPicBox.Visible = False
            skyJuicePicBox.Visible = False
            lemonadePicBox.Visible = False
            coconutPicBox.Visible = False
            mojittoPicBox.Visible = False
            cappuchinoPicBox.Visible = False
            matchaPicBox.Visible = False
            rumpSteakPicBox.Visible = False
            salmonPicBox.Visible = False
            ribeyePicBox.Visible = False
            tortillaPicBox.Visible = False
            cheeseBreadPicBox.Visible = False
            arabiataPicBox.Visible = False
            caesaSaladPicBox.Visible = False
            jerkyBeefPicBox.Visible = False
            brigaderiosPicBox.Visible = False
            feijoadaPicBox.Visible = False
            moquecaPicBox.Visible = False
            caesaSaladPicBox.Visible = False
            arabiataPicBox.Visible = False
            cheeseBreadPicBox.Visible = False
            tortillaPicBox.Visible = False
            ribeyePicBox.Visible = False
            salmonPicBox.Visible = False
            rumpSteakPicBox.Visible = False
            matchaPicBox.Visible = False
            cappuchinoPicBox.Visible = False
            coconutPicBox.Visible = False
            lblFoodName.Text = "Creamy Mango (RM20.60)"
        End Sub

        Private Sub dispRecBtn_Click(sender As Object, e As EventArgs) Handles dispRecBtn.Click
            PrintPreviewDialog1.ShowDialog()
        End Sub

    Private Sub pdPrint_PrintPage(sender As Object, e As Printing.PrintPageEventArgs) Handles pdPrint.PrintPage
        e.Graphics.DrawString("-------------------------------------------------------------------------------------------------", New Font("Arial", 12, FontStyle.Regular), Brushes.Black, 100, 40)
        e.Graphics.DrawString("Order Receipt By " & txtName.Text, New Font("Arial", 12, FontStyle.Regular), Brushes.Black, 100, 60)
        e.Graphics.DrawString("-------------------------------------------------------------------------------------------------", New Font("Arial", 12, FontStyle.Regular), Brushes.Black, 100, 80)
        e.Graphics.DrawString("Receipent Personal Information ", New Font("Arial", 12, FontStyle.Regular), Brushes.Black, 100, 100)
        e.Graphics.DrawString("-------------------------------------------------------------------------------------------------", New Font("Arial", 12, FontStyle.Regular), Brushes.Black, 100, 120)
        e.Graphics.DrawString("Name : " & txtName.Text, New Font("Arial", 12, FontStyle.Regular), Brushes.Black, 100, 160)
        e.Graphics.DrawString("IC : " & txtIc.Text, New Font("Arial", 12, FontStyle.Regular), Brushes.Black, 100, 200)
        e.Graphics.DrawString("Phone Number : " & txtPhone.Text, New Font("Arial", 12, FontStyle.Regular), Brushes.Black, 100, 240)
        e.Graphics.DrawString("Email : " & txtEmail.Text, New Font("Arial", 12, FontStyle.Regular), Brushes.Black, 100, 280)

        If cashradBtn.Checked Then
            e.Graphics.DrawString("Payment method : Cash", New Font("Arial", 12, FontStyle.Regular), Brushes.Black, 100, 320)
        ElseIf cardRadBtn.checked Then
            e.Graphics.DrawString("Payment method : Debit card/Credit card", New Font("Arial", 12, FontStyle.Regular), Brushes.Black, 100, 320)
        End If

        If codRadBtn.Checked Then
            e.Graphics.DrawString("Delivery method : Delivery", New Font("Arial", 12, FontStyle.Regular), Brushes.Black, 100, 360)
        ElseIf selfPickRadBtn.Checked Then
            e.Graphics.DrawString("Delivery method : Self-pickup", New Font("Arial", 12, FontStyle.Regular), Brushes.Black, 100, 360)
        End If

        e.Graphics.DrawString("Customer address : " & address, New Font("Arial", 12, FontStyle.Regular), Brushes.Black, 100, 400)
        e.Graphics.DrawString("-------------------------------------------------------------------------------------------------", New Font("Arial", 12, FontStyle.Regular), Brushes.Black, 100, 440)
        e.Graphics.DrawString("Receipent Ordering Information", New Font("Arial", 12, FontStyle.Regular), Brushes.Black, 100, 480)
        e.Graphics.DrawString("-------------------------------------------------------------------------------------------------", New Font("Arial", 12, FontStyle.Regular), Brushes.Black, 100, 520)

        verticalPosition = 520
        cusOrderInfo(e, verticalPosition)

        e.Graphics.DrawString("Beverages Details  :", New Font("Arial", 12, FontStyle.Regular), Brushes.Black, 100, verticalPosition)
        verticalPosition += 40


        If matchaChkBox.Checked Then
            e.Graphics.DrawString("Matcha ", New Font("Arial", 12, FontStyle.Regular), Brushes.Black, 100, verticalPosition)
            verticalPosition += 20
        End If

        If cappuchinoChkBox.Checked Then
            e.Graphics.DrawString("Cappuccino ", New Font("Arial", 12, FontStyle.Regular), Brushes.Black, 100, verticalPosition)
            verticalPosition += 20
        End If

        If mojittoChkBox.Checked Then
            e.Graphics.DrawString("Mojitto ", New Font("Arial", 12, FontStyle.Regular), Brushes.Black, 100, verticalPosition)
            verticalPosition += 20
        End If

        If coconutChkBox.Checked Then
            e.Graphics.DrawString("Coconut water ", New Font("Arial", 12, FontStyle.Regular), Brushes.Black, 100, verticalPosition)
            verticalPosition += 20
        End If

        If lemonadeChkBox.Checked Then
            e.Graphics.DrawString("Lemonade ", New Font("Arial", 12, FontStyle.Regular), Brushes.Black, 100, verticalPosition)
            verticalPosition += 20
        End If


        If skyJuiceChkBox.Checked Then
            e.Graphics.DrawString("Skyjuice ", New Font("Arial", 12, FontStyle.Regular), Brushes.Black, 100, verticalPosition)
            verticalPosition += 20
        End If


        If americanoChkBox.Checked Then
            e.Graphics.DrawString("Americano ", New Font("Arial", 12, FontStyle.Regular), Brushes.Black, 100, verticalPosition)
            verticalPosition += 20
        End If


        If creamyMangoChkBox.Checked Then
            e.Graphics.DrawString("Mango ", New Font("Arial", 12, FontStyle.Regular), Brushes.Black, 100, verticalPosition)
            verticalPosition += 20
        End If

        e.Graphics.DrawString("-------------------------------------------------------------------------------------------------", New Font("Arial", 12, FontStyle.Regular), Brushes.Black, 100, verticalPosition)
        verticalPosition += 20

        e.Graphics.DrawString("Total price for selected Combo(s) Set : " & "RM" & Format(totalComboPrice, "0.00"), New Font("Arial", 12, FontStyle.Regular), Brushes.Black, 100, verticalPosition)
        verticalPosition += 20

        e.Graphics.DrawString("Total price for selected Ala Carte(s) Set : " & "RM" & Format(totalAlaCartePrice, "0.00"), New Font("Arial", 12, FontStyle.Regular), Brushes.Black, 100, verticalPosition)
        verticalPosition += 20

        e.Graphics.DrawString("Total price for beverages : " & "RM" & Format(totalDrinkPrice, "0.00"), New Font("Arial", 12, FontStyle.Regular), Brushes.Black, 100, verticalPosition)
        verticalPosition += 20

        e.Graphics.DrawString("Delivery charge : " & "RM" & Format(delivery, "0.00"), New Font("Arial", 12, FontStyle.Regular), Brushes.Black, 100, verticalPosition)
        verticalPosition += 20

        e.Graphics.DrawString("Tax Price : " & "RM" & Format(totalTaxPrice, "0.00"), New Font("Arial", 12, FontStyle.Regular), Brushes.Black, 100, verticalPosition)
        verticalPosition += 20

        e.Graphics.DrawString("Total amount customer must pay : " & "RM" & Format(totalPrice, "0.00"), New Font("Arial", 12, FontStyle.Regular), Brushes.Black, 100, verticalPosition)
        verticalPosition += 20

        e.Graphics.DrawString("-------------------------------------------------------------------------------------------------", New Font("Arial", 12, FontStyle.Regular), Brushes.Black, 100, verticalPosition)


    End Sub

    Private Sub cusOrderInfo(e As Printing.PrintPageEventArgs, ByRef verticalPosition As Integer)
        Dim booleanCombo As Boolean = False
        Dim booleanAlaCarte As Boolean = False
        Dim booleanDrink As Boolean = False

        Dim int As Integer = 0
        verticalPosition += 40

        e.Graphics.DrawString("Combo Set Order Details  :", New Font("Arial", 12, FontStyle.Regular), Brushes.Black, 100, verticalPosition)
        verticalPosition += 40

        For i As Integer = 0 To menuCombo.Length - 1
            If numOrderCombo(i) > 0 Then
                If int = 0 Then
                    e.Graphics.DrawString("Quantity  ", New Font("Arial", 12, FontStyle.Regular), Brushes.Black, 375, verticalPosition - 30)
                    e.Graphics.DrawString("Price  ", New Font("Arial", 12, FontStyle.Regular), Brushes.Black, 600, verticalPosition - 30)
                    int += 1
                End If
                booleanCombo = True
                e.Graphics.DrawString(menuCombo(i), New Font("Arial", 11), Brushes.Black, New Point(100, verticalPosition))
                e.Graphics.DrawString(numOrderCombo(i), New Font("Arial", 11), Brushes.Black, New Point(400, verticalPosition))
                e.Graphics.DrawString("RM" & Format((menuComboPrice(1, i) * numOrderCombo(i)), "0.00"), New Font("Arial", 11), Brushes.Black, New Point(600, verticalPosition))
                verticalPosition += 20
            End If
        Next

        If booleanCombo = False Then
            e.Graphics.DrawString("{Customer did not order any Combo Set}", New Font("Arial", 11), Brushes.Black, New Point(100, verticalPosition))
        End If

        verticalPosition += 50

        e.Graphics.DrawString("Ala Carte Set Order Details  :", New Font("Arial", 12, FontStyle.Regular), Brushes.Black, 100, verticalPosition)
        verticalPosition += 30
        int = 0

        For i As Integer = 0 To menuAlaCarte.Length - 1
            If numOrderAlaCarte(i) > 0 Then
                If int = 0 Then
                    e.Graphics.DrawString("Quantity  ", New Font("Arial", 12, FontStyle.Regular), Brushes.Black, 375, verticalPosition - 30)
                    e.Graphics.DrawString("Price  ", New Font("Arial", 12, FontStyle.Regular), Brushes.Black, 600, verticalPosition - 30)
                    int += 1
                End If
                booleanAlaCarte = True
                e.Graphics.DrawString(menuAlaCarte(i), New Font("Arial", 11), Brushes.Black, New Point(100, verticalPosition))
                e.Graphics.DrawString(numOrderAlaCarte(i), New Font("Arial", 11), Brushes.Black, New Point(400, verticalPosition))
                e.Graphics.DrawString("RM" & Format((menuAlaCartePrice(1, i) * numOrderAlaCarte(i)), "0.00"), New Font("Arial", 11), Brushes.Black, New Point(600, verticalPosition))
                verticalPosition += 20
            End If
        Next

        If booleanAlaCarte = False Then
            e.Graphics.DrawString("{Customer did not order any Ala Cart Set}", New Font("Arial", 11), Brushes.Black, New Point(100, verticalPosition))
        End If

        verticalPosition += 20
    End Sub



    Private Sub printReceiptBtn_Click(sender As Object, e As EventArgs) Handles printReceiptBtn.Click
        pdPrint.Print()
    End Sub

End Class