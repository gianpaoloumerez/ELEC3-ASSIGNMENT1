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

        MessageBox.Show("Text File 'output_file.txt' Created on \n" + path)

    End Sub

    Private Sub FolderBrowserDialog1_HelpRequest(sender As Object, e As EventArgs) Handles FolderBrowserDialog1.HelpRequest

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        If (FolderBrowserDialog1.ShowDialog() = DialogResult.OK) Then
            path = FolderBrowserDialog1.SelectedPath
        End If
        Dim name As String = "<name> " + TextBox1.Text + " </name>"
        Dim age As String = "<age> " + TextBox2.Text + " </age>"
        Dim address As String = "<address> " + TextBox3.Text + " </address>"
        Dim text As System.IO.StreamWriter = My.Computer.FileSystem.OpenTextFileWriter(path + "\output_file.xml", True)

        text.WriteLine(name)
        text.WriteLine(age)
        text.WriteLine(address)
        text.Close()

        MessageBox.Show("XML File 'output_file.xml' Created on \n" + path)
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        If (FolderBrowserDialog1.ShowDialog() = DialogResult.OK) Then
            path = FolderBrowserDialog1.SelectedPath
        End If
        Dim name As String = " ""Name:"" " + TextBox1.Text + ","
        Dim age As String = " ""Age:""" + TextBox2.Text + ","
        Dim address As String = " "" Address:""" + TextBox3.Text + ","
        Dim text As System.IO.StreamWriter = My.Computer.FileSystem.OpenTextFileWriter(path + "\output_file.json", True)

        text.WriteLine("{")
        text.WriteLine(name)
        text.WriteLine(age)
        text.WriteLine(address)
        text.WriteLine("}")
        text.Close()

        MessageBox.Show("JSON File 'output_file.json' Created on \n" + path)
    End Sub
End Class
