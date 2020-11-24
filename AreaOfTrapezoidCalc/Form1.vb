Public Class Form1
    'Declarations
    Dim LowerBase, UpperBase, Height, Area As Decimal
    Private Sub BTNCalcArea_Click(sender As Object, e As EventArgs) Handles BTNCalcArea.Click
        'Store User Input
        LowerBase = TBLowerBase.Text
        UpperBase = TBUpperBase.Text
        Height = TBHeight.Text

        'Calculate The Area Of Trapezoid
        Area = Math.Round((((LowerBase + UpperBase) * Height) / 2), 2)

        'Output The Area
        TBArea.Text = Area & " cm²"
    End Sub
End Class
