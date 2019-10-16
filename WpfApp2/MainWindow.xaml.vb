Class MainWindow


    Dim var As Double

    Public Sub Button_Click(sender As Object, e As RoutedEventArgs)
        Console.WriteLine("hello world!")
    End Sub

    Private Sub Button_Click_1(sender As Object, e As RoutedEventArgs)
        Console.WriteLine("hello world!")
    End Sub

    Private Sub Button_Click_2(sender As Object, e As RoutedEventArgs)
        Console.WriteLine("hello world!")
        txtButtonHW.Text = "Aaaaa"
    End Sub
End Class
