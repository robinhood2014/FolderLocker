Imports System.IO
Public Class frmFolderLocker
    Public Property Locker As Object = $"{My.Computer.FileSystem.CurrentDirectory}\Locker"
    Public Property Title As Object = "Folder Locker"
    ' Make directory subroutine to be executed if locked folder does not exist
    Private Sub MakeLockedFolder()
        ' Create the folder
        My.Computer.FileSystem.CreateDirectory(directory:=Locker)
        MessageBox.Show(text:="Locker created successfully.", caption:=Title, buttons:=MessageBoxButtons.OK, icon:=vbInformation)
    End Sub
    ' Lock subroutine
    Private Sub LockFolder()
        ' Wait for user input
        If MessageBox.Show(
            text:="Are you sure you want to Lock the folder?", caption:=Title, buttons:=MessageBoxButtons.YesNo, icon:=vbQuestion) = vbYes Then
            ' If user clicks yes, set hidden and system attributes
            File.SetAttributes(path:=Locker, fileAttributes:=File.GetAttributes(path:=Locker) + 6)
            MessageBox.Show(text:="Folder locked.", caption:=Title, buttons:=MessageBoxButtons.OK, icon:=vbInformation)
        End If
    End Sub
    Private Sub FrmFolderLocker_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Hide()  ' hide the form at startup
        If Not Directory.Exists(path:=Locker) Then  ' if folder doesn't exist
            MakeLockedFolder()  ' create it
            End ' we're done here
        ElseIf Not File.GetAttributes(path:=Locker) And 6 Then  ' if folder exists and is unlocked
            LockFolder()  ' lock it
            End ' we're done here
        Else    ' if folder exists and is locked
            Show()  ' show the form to try to unlock the folder
        End If
    End Sub
    ' if the user clicks OK
    Private Sub BtnOK_Click(sender As Object, e As EventArgs) Handles btnOK.Click
        If txtPassword.Text = "Test" Then  ' if correct password
            ' Clear hidden and system attributes
            File.SetAttributes(path:=Locker, fileAttributes:=File.GetAttributes(path:=Locker) - 6)
            MessageBox.Show(text:="Folder Unlocked successfully.", caption:=Title, buttons:=MessageBoxButtons.OK, icon:=vbInformation)
        Else    ' if wrong password
            MessageBox.Show(text:="Invalid password!", caption:=Title, buttons:=MessageBoxButtons.OK, icon:=vbCritical)
        End If
        End ' we're done here
    End Sub

    Private Sub BtnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        End ' we're done here
    End Sub
End Class