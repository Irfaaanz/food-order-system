Public Class homePage

    Private Sub menuBtn_Click_1(sender As Object, e As EventArgs) Handles menuBtn.Click
        menuDisplay.Show()
        Me.Hide()
    End Sub

    Private Sub staffLogBtn_Click_1(sender As Object, e As EventArgs) Handles staffLogBtn.Click
        staffLogin.Show()
        Me.Hide()
    End Sub

    Private Sub aboutBtn_Click_1(sender As Object, e As EventArgs) Handles aboutBtn.Click
        MessageBox.Show("Brasas Brazuca Restaurant is an aesthetic and authentic Brazilian theme restaurant that provide many type of Brazillian food. " & vbNewLine & vbNewLine &
                        "Brasas Brazuca features an epic food menu, fixed price for all customers and best dining experience that will make our uniqueness of he restaurant stay remain in your mind!" & vbNewLine & vbNewLine &
                        "The quality of our food and service underscores our commitment to excellence and to your satisfaction!", "About Us")
    End Sub

    Private Sub contactBtn_Click_1(sender As Object, e As EventArgs) Handles contactBtn.Click
        MessageBox.Show("Email: brasasbrazuca@gmail.com " & vbNewLine & vbNewLine &
                        "Phone: 01446532148" & vbNewLine & vbNewLine &
                        "Address: Level 56, Menara 3 Petronas, Persiaran KLCC, Kuala Lumpur City Centre, 50088 Kuala Lumpur, Wilayah Persekutuan Kuala Lumpur", "Contact Us")
    End Sub

    Private Sub exitBtn_Click(sender As Object, e As EventArgs) Handles exitBtn.Click
        Close()
    End Sub
End Class