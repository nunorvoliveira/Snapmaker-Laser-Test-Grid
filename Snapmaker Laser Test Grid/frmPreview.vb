Public Class frmPreview

    Private Sub frmPreview_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        '// Ser window caption
        Me.Text = Application.ProductName & " - gCode Preview"

        '// set cursos on textbox first place
        txtGcodePreview.SelectionStart = 0
        txtGcodePreview.SelectionLength = 0

    End Sub

    Private Sub btnCopy_Click(sender As Object, e As EventArgs) Handles btnCopy.Click

        '// Copy to clipboard
        Clipboard.Clear()
        Clipboard.SetText(txtGcodePreview.Text)

    End Sub

    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click

        '// Closes form
        Me.Close()

    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click

        '// Setup save dialog
        frmMain.dlgSave.AddExtension = True
        frmMain.dlgSave.CheckFileExists = False
        frmMain.dlgSave.CheckPathExists = True
        frmMain.dlgSave.FileName = "test_grid"
        frmMain.dlgSave.Filter = "nc files (*.nc)|*.nc|All files (*.*)|*.*"
        frmMain.dlgSave.FilterIndex = 1
        frmMain.dlgSave.OverwritePrompt = True
        frmMain.dlgSave.RestoreDirectory = True
        frmMain.dlgSave.Title = "Save gCode laser file as..."
        '// Show save dialog
        If frmMain.dlgSave.ShowDialog() = DialogResult.OK Then
            '// Create file stream
            Dim myStream As IO.Stream
            myStream = frmMain.dlgSave.OpenFile()
            myStream.Write(System.Text.Encoding.UTF8.GetBytes(frmMain.txtGCode.Text), 0, System.Text.Encoding.UTF8.GetBytes(frmMain.txtGCode.Text).Length)
            myStream.Close()
        End If

    End Sub
End Class