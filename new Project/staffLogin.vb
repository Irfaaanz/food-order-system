Imports System.Data.OleDb
Public Class staffLogin
    Private Sub staffLogin_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'BrasasBrazuciaStaffDataDataSet.Staff' table. You can move, or remove it, as needed.
        Me.StaffTableAdapter.Fill(Me.BrasasBrazuciaStaffDataDataSet.Staff)
        'HIDE THE TEXT OF THE txtPassword ON THE FIRST LOAD
        txtPassword.UseSystemPasswordChar = True
    End Sub

    Private Sub showPassCbox_CheckedChanged_1(sender As Object, e As EventArgs) Handles showPassCbox.CheckedChanged
        'CHECKING IF THE CHECKBOX WAS CHECKED OR NOT.
        If showPassCbox.CheckState = CheckState.Checked Then
            'IF TRUE, IT SHOWS THE TEXT
            txtPassword.UseSystemPasswordChar = False
        Else
            'IF FALSE, IT WILL HIDE THE TEXT AND IT WILL TURN INTO BULLETS.
            txtPassword.UseSystemPasswordChar = True
        End If
    End Sub

    Private Sub loginStaffBtn_Click_1(sender As Object, e As EventArgs) Handles loginStaffBtn.Click
        Dim conn As New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" & Application.StartupPath & "\BrasasBrazuciaStaffData.accdb")

        Dim cmd As New OleDbCommand("SELECT * FROM Staff WHERE Staff_ID='" & txtStaffId.Text & "' and Password='" & txtPassword.Text & "'", conn)

        Dim user As String = " "
        Dim pass As String = " "

        conn.Open()
        Dim sdr As OleDbDataReader = cmd.ExecuteReader()

        If (sdr.Read() = True) Then
            user = sdr("Staff_ID")
            pass = sdr("Password")

            MsgBox("Login Successful!", "Welcome")
            Me.Hide()
            staffInterface.Show()

        Else
            MsgBox("Invalid username or password")
        End If

        staffInterface.Show()
        MsgBox("Welcome to Staff Data Information!",, "System")

        txtStaffId.Text = Nothing
        txtPassword.Text = Nothing
    End Sub

    Private Sub clearStaffInfoBtn_Click_1(sender As Object, e As EventArgs) Handles clearStaffInfoBtn.Click
        txtStaffId.Text = Nothing
        txtPassword.Text = Nothing
    End Sub

    Private Sub backHomeBtn_Click_1(sender As Object, e As EventArgs) Handles backHomeBtn.Click
        homePage.Show()
        Me.Hide()
    End Sub
End Class