Public Class menuDisplay
    Private Sub btnBeverages_Click(sender As Object, e As EventArgs) Handles btnBeverages.Click
        alaCartePanel.Hide()
        comboPanel.Hide()
        beveragesPanel.Show()
    End Sub

    Private Sub menuBtn_Click(sender As Object, e As EventArgs) Handles menuBtn.Click
        comboPanel.Show()
        alaCartePanel.Hide()
        beveragesPanel.Hide()
    End Sub

    Private Sub alaCbtn_Click_1(sender As Object, e As EventArgs) Handles alaCbtn.Click
        alaCartePanel.Show()
        comboPanel.Hide()
        beveragesPanel.Hide()
    End Sub

    Private Sub makeOrderBtn_Click_1(sender As Object, e As EventArgs) Handles makeOrderBtn.Click
        orderForm.Show()
        Me.Hide()
    End Sub

    Private Sub backBtn_Click_1(sender As Object, e As EventArgs) Handles backBtn.Click
        homePage.Show()
        Me.Hide()
    End Sub
End Class