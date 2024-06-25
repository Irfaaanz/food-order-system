Public Class staffInterface
    Private Sub staffInterface_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'BrasasBrazuciaStaffDataDataSet.Staff' table. You can move, or remove it, as needed.
        Me.StaffTableAdapter.Fill(Me.BrasasBrazuciaStaffDataDataSet.Staff)
        'HIDE THE TEXT OF THE txtPassword ON THE FIRST LOAD
        PasswordTextBox.UseSystemPasswordChar = True
        txtConfirm.UseSystemPasswordChar = True
    End Sub
    Private Sub showPassCbox_CheckedChanged(sender As Object, e As EventArgs) Handles showPassCbox.CheckedChanged
        'CHECKING IF THE CHECKBOX WAS CHECKED OR NOT.
        If showPassCbox.CheckState = CheckState.Checked Then
            'IF TRUE, IT SHOWS THE TEXT
            PasswordTextBox.UseSystemPasswordChar = False
            txtConfirm.UseSystemPasswordChar = False
        Else
            'IF FALSE, IT WILL HIDE THE TEXT AND IT WILL TURN INTO BULLETS.
            PasswordTextBox.UseSystemPasswordChar = True
            txtConfirm.UseSystemPasswordChar = True
        End If
    End Sub

    Private Sub orderSummaryBtn_Click(sender As Object, e As EventArgs) Handles orderSummaryBtn.Click
        orderReportSummary.Show()
        dataPanel.Hide()
        registerPanel.Hide()
    End Sub

    Private Sub registerNewBtn_Click(sender As Object, e As EventArgs) Handles registerNewBtn.Click
        registerPanel.Visible = True
        dataPanel.Visible = False
    End Sub

    Private Sub showDataBtn_Click(sender As Object, e As EventArgs) Handles showDataBtn.Click
        dataPanel.Visible = True
        registerPanel.Visible = False
    End Sub

    Private Sub returnBtn_Click(sender As Object, e As EventArgs) Handles returnBtn.Click
        Me.Hide()
        staffLogin.Show()
        MsgBox("Logging out...", "System")
    End Sub

    Private Sub addBtn_Click(sender As Object, e As EventArgs) Handles addBtn.Click
        Me.StaffBindingSource.AddNew()
    End Sub

    Private Sub registerBtn_Click(sender As Object, e As EventArgs) Handles registerBtn.Click
        Try
            If txtConfirm.Text = PasswordTextBox.Text Then
                Me.StaffBindingSource.EndEdit()
                TableAdapterManager.UpdateAll(Me.BrasasBrazuciaStaffDataDataSet)
                MessageBox.Show("Data Registered", "Data Registration", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Else
                MessageBox.Show("Password Does Not Match", "Password", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Data Registration", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub updateBtn_Click(sender As Object, e As EventArgs) Handles updateBtn.Click
        Me.Validate()
        Me.StaffBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.BrasasBrazuciaStaffDataDataSet)
        MessageBox.Show("Staff Data Updated", "Update", MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub

    Private Sub deleteBtn_Click(sender As Object, e As EventArgs) Handles deleteBtn.Click
        Me.StaffBindingSource.RemoveCurrent()
        Me.TableAdapterManager.UpdateAll(Me.BrasasBrazuciaStaffDataDataSet)
        MessageBox.Show("Staff Data has been removed")
    End Sub

    Private Sub firstBtn_Click(sender As Object, e As EventArgs) Handles firstBtn.Click
        Me.StaffBindingSource.MoveFirst()
    End Sub

    Private Sub nextBtn_Click(sender As Object, e As EventArgs) Handles nextBtn.Click
        Me.StaffBindingSource.MoveNext()
    End Sub

    Private Sub previousBtn_Click(sender As Object, e As EventArgs) Handles previousBtn.Click
        Me.StaffBindingSource.MovePrevious()
    End Sub

    Private Sub lastBtn_Click(sender As Object, e As EventArgs) Handles lastBtn.Click
        Me.StaffBindingSource.MoveLast()
    End Sub
End Class