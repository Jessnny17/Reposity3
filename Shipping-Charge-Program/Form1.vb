' Programmed By: Deon Lundy
' Description: Program calculaets shipping charge
'              for a package when rate is $0.12/ounce.

Public Class Form1

    ' Declare Module Level variables and Constants.
    Const ship_rate As Double = 0.12

    Private Sub Package_identifier_MaskInputRejected(sender As Object, e As MaskInputRejectedEventArgs) Handles Package_identifier.MaskInputRejected

    End Sub

    Private Sub Exit_Button_Click(sender As Object, e As EventArgs) Handles Exit_Button.Click
        Me.Close()

    End Sub

    Private Sub Clear_Button_Click(sender As Object, e As EventArgs) Handles Clear_Button.Click
        Total_Box.Visible = False
        Total_Label.Visible = False
        Package_identifier.Text = ""
        Pound_textbox.Text = ""
        Ounce_textbox.Text = ""
    End Sub

    Private Sub Calculate_Button_Click(sender As Object, e As EventArgs) Handles Calculate_Button.Click
        ' Calculate Total
        Dim pounds As Decimal = Decimal.Parse(Pound_textbox.Text)
        Dim ounces As Decimal = Decimal.Parse(Ounce_textbox.Text)
        Dim total_ounces = ((pounds * 16) + ounces)
        Total_Box.Text = (total_ounces * ship_rate).ToString("C")

        ' Makes Total Box Visible/Invisble
        Total_Label.Visible = True
        Total_Box.Visible = True

    End Sub
End Class
