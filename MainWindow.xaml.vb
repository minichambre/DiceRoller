Class MainWindow
    Dim value As New Integer
    Dim dice As New Random(value)

    Private Sub Button_Click(sender As Object, e As RoutedEventArgs) Handles btnD2.Click
        lblDisplay.Text = ""
        lblDisplay.Text = dice.Next(1, 4)
    End Sub

    Private Sub btnD3_Click(sender As Object, e As RoutedEventArgs) Handles btnD3.Click
        lblDisplay.Text = ""
        lblDisplay.Text = dice.Next(1, 5)
    End Sub

    Private Sub btnD4_Click(sender As Object, e As RoutedEventArgs) Handles btnD4.Click
        lblDisplay.Text = ""
        lblDisplay.Text = dice.Next(1, 7)
    End Sub

    Private Sub btnD6_Click(sender As Object, e As RoutedEventArgs) Handles btnD6.Click
        lblDisplay.Text = ""
        lblDisplay.Text = dice.Next(1, 9)
    End Sub

    Private Sub btnD8_Click(sender As Object, e As RoutedEventArgs) Handles btnD8.Click
        lblDisplay.Text = ""
        lblDisplay.Text = dice.Next(1, 11)
    End Sub

    Private Sub btnD12_Click(sender As Object, e As RoutedEventArgs) Handles btnD12.Click
        lblDisplay.Text = ""
        lblDisplay.Text = dice.Next(1, 13)
    End Sub

    Private Sub btnD20_Click(sender As Object, e As RoutedEventArgs) Handles btnD20.Click
        lblDisplay.Text = ""
        lblDisplay.Text = dice.Next(1, 21)
    End Sub

    Private Sub lblDisplay_click(sender As Object, e As RoutedEventArgs) Handles lblDisplay.MouseLeftButtonDown
        Me.lblDisplay.Text = "Roll Something"
    End Sub
End Class
