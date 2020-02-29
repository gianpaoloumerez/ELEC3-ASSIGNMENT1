Imports System.IO
Imports System.Text

Public Class Form1
    Dim path As String
    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click

    End Sub

    Private Sub Label3_Click(sender As Object, e As EventArgs) Handles Label3.Click

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If (FolderBrowserDialog1.ShowDialog() = DialogResult.OK) Then
            path = FolderBrowserDialog1.SelectedPath
        End If
        Dim name As String = "Name: " + TextBox1.Text
        Dim age As String = "Age: " + TextBox2.Text
        Dim address As String = "Address: " + TextBox3.Text
        Dim text As System.IO.StreamWriter = My.Computer.FileSystem.OpenTextFileWriter(path + "\output_file.txt", True)

        text.WriteLine(name)
        text.WriteLine(age)
        text.WriteLine(address)
        text.Close()

    End Sub

    Private Sub FolderBrowserDialog1_HelpRequest(sender As Object, e As EventArgs) Handles FolderBrowserDialog1.HelpRequest

    End Sub
End Class
