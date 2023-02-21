Imports ZXing.Common
Imports ZXing
Imports ZXing.Rendering
Imports System.Drawing.Printing


Public Class Form1

    Private Function generateBarcode(barcodeData As String, labelString As String, width As Integer) As Bitmap
        Dim label As String = ""
        Dim w As Integer = width
        Dim h As Integer = 50

        Dim writer As New BarcodeWriter
        writer.Format = BarcodeFormat.CODE_128
        label = labelString + barcodeData
        writer.Options.Width = w
        writer.Options.Height = h
        writer.Options.PureBarcode = False
        Dim result = writer.Encode(barcodeData)
        Dim renderer As New BitmapRenderer
        renderer.TextFont = New Font("Arial", 12)
        Dim bitmap As Bitmap = renderer.Render(result, BarcodeFormat.CODE_128, label)
        Return bitmap
    End Function

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim qnty_img = generateBarcode("8", "Q'NTY: ", 150)
        PictureBox2.Image = qnty_img

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim img = generateBarcode("F10861876751C20", "MTA MAC: ", 400)
        PictureBox1.Image = img

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click

    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class
