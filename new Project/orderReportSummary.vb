Public Class orderReportSummary
    Private Sub showReportBtn_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub showReportBtn_Click_1(sender As Object, e As EventArgs) Handles showReportBtn.Click

    End Sub

    Private Sub logOutBtn_Click_1(sender As Object, e As EventArgs) Handles logOutBtn.Click
        Me.Hide()
        staffInterface.Show()
        MessageBox.Show("Logging out...", "System")
    End Sub
End Class