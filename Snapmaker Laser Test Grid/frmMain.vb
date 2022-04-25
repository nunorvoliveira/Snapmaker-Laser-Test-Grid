Imports System.ComponentModel

Public Class frmMain

    Dim LetterWidth As Integer = 6
    Dim LetterSpace As Integer = 4
    Dim MainSpacer As Integer
    Dim bExportGcode As Boolean = False
    Dim msRapidSpeed As Integer
    Dim sMatrixThumbnailB64 As String = ""

    Private Sub frmMain_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        '// Define window caption
        Me.Text = Application.ProductName

        '// Define vertical space
        MainSpacer = picGraphics.Width / 12

        '// Make textbox full size
        txtGCode.Left = 12
        txtGCode.Width = Me.Width - 41

        '// Update display picture
        UpdateGraphics()

        '// Loas settings
        msRapidSpeed = My.Settings.RapidSpeed
    End Sub


#Region "Draw Numbers"

    Private Sub DrawNumber(ByVal xCoord As Integer, ByVal yCoord As Integer, ByVal Number As Integer, ByRef g As Graphics)

        Dim sText As String = Number.ToString
        Dim sChar As String
        Dim iNumber As Integer

        For i = 1 To sText.Length
            sChar = Mid(sText, i, 1)
            iNumber = CInt(sChar)
            DrawThisNumber(xCoord + (i - 1) * (LetterWidth + LetterSpace), yCoord, iNumber, g)
        Next

    End Sub

    Private Sub DrawThisNumber(ByVal xCoord As Integer, ByVal yCoord As Integer, ByVal Number As Integer, ByRef g As Graphics)

        Select Case Number
            Case 0
                DrawNumber0(xCoord, yCoord, g)
            Case 1
                DrawNumber1(xCoord, yCoord, g)
            Case 2
                DrawNumber2(xCoord, yCoord, g)
            Case 3
                DrawNumber3(xCoord, yCoord, g)
            Case 4
                DrawNumber4(xCoord, yCoord, g)
            Case 5
                DrawNumber5(xCoord, yCoord, g)
            Case 6
                DrawNumber6(xCoord, yCoord, g)
            Case 7
                DrawNumber7(xCoord, yCoord, g)
            Case 8
                DrawNumber8(xCoord, yCoord, g)
            Case 9
                DrawNumber9(xCoord, yCoord, g)
        End Select

    End Sub

    Private Sub DrawNumber0(ByVal xCoord As Integer, ByVal yCoord As Integer, ByRef g As Graphics)

        gCodeWriteText(xCoord + 0, picGraphics.Height - yCoord - 0, xCoord + LetterWidth, picGraphics.Height - yCoord - 0, g)
        gCodeWriteText(xCoord + LetterWidth, picGraphics.Height - yCoord - 0, xCoord + LetterWidth, picGraphics.Height - yCoord - 2 * LetterWidth, g)
        gCodeWriteText(xCoord + LetterWidth, picGraphics.Height - yCoord - 2 * LetterWidth, xCoord + 0, picGraphics.Height - yCoord - 2 * LetterWidth, g)
        gCodeWriteText(xCoord + 0, picGraphics.Height - yCoord - 2 * LetterWidth, xCoord + 0, picGraphics.Height - yCoord - 0, g)

    End Sub

    Private Sub DrawNumber1(ByVal xCoord As Integer, ByVal yCoord As Integer, ByRef g As Graphics)

        gCodeWriteText(xCoord + LetterWidth, picGraphics.Height - yCoord - 0, xCoord + LetterWidth, picGraphics.Height - yCoord - 2 * LetterWidth, g)

    End Sub

    Private Sub DrawNumber2(ByVal xCoord As Integer, ByVal yCoord As Integer, ByRef g As Graphics)

        gCodeWriteText(xCoord + LetterWidth, picGraphics.Height - yCoord - 0, xCoord + 0, picGraphics.Height - yCoord - 0, g)
        gCodeWriteText(xCoord + 0, picGraphics.Height - yCoord - 0, xCoord + 0, picGraphics.Height - yCoord - LetterWidth, g)
        gCodeWriteText(xCoord + 0, picGraphics.Height - yCoord - LetterWidth, xCoord + LetterWidth, picGraphics.Height - yCoord - LetterWidth, g)
        gCodeWriteText(xCoord + LetterWidth, picGraphics.Height - yCoord - LetterWidth, xCoord + LetterWidth, picGraphics.Height - yCoord - 2 * LetterWidth, g)
        gCodeWriteText(xCoord + LetterWidth, picGraphics.Height - yCoord - 2 * LetterWidth, xCoord + 0, picGraphics.Height - yCoord - 2 * LetterWidth, g)

    End Sub

    Private Sub DrawNumber3(ByVal xCoord As Integer, ByVal yCoord As Integer, ByRef g As Graphics)

        gCodeWriteText(xCoord + 0, picGraphics.Height - yCoord - 0, xCoord + LetterWidth, picGraphics.Height - yCoord - 0, g)
        gCodeWriteText(xCoord + LetterWidth, picGraphics.Height - yCoord - 0, xCoord + LetterWidth, picGraphics.Height - yCoord - 2 * LetterWidth, g)
        gCodeWriteText(xCoord + LetterWidth, picGraphics.Height - yCoord - 2 * LetterWidth, xCoord + 0, picGraphics.Height - yCoord - 2 * LetterWidth, g)
        gCodeWriteText(xCoord + LetterWidth, picGraphics.Height - yCoord - LetterWidth, xCoord + 0, picGraphics.Height - yCoord - LetterWidth, g)

    End Sub

    Private Sub DrawNumber4(ByVal xCoord As Integer, ByVal yCoord As Integer, ByRef g As Graphics)

        gCodeWriteText(xCoord + LetterWidth, picGraphics.Height - yCoord - 0, xCoord + LetterWidth, picGraphics.Height - yCoord - 2 * LetterWidth, g)
        gCodeWriteText(xCoord + LetterWidth, picGraphics.Height - yCoord - LetterWidth, xCoord + 0, picGraphics.Height - yCoord - LetterWidth, g)
        gCodeWriteText(xCoord + 0, picGraphics.Height - yCoord - LetterWidth, xCoord + 0, picGraphics.Height - yCoord - 2 * LetterWidth, g)

    End Sub
    Private Sub DrawNumber5(ByVal xCoord As Integer, ByVal yCoord As Integer, ByRef g As Graphics)

        gCodeWriteText(xCoord + 0, picGraphics.Height - yCoord - 0, xCoord + LetterWidth, picGraphics.Height - yCoord - 0, g)
        gCodeWriteText(xCoord + LetterWidth, picGraphics.Height - yCoord - 0, xCoord + LetterWidth, picGraphics.Height - yCoord - LetterWidth, g)
        gCodeWriteText(xCoord + LetterWidth, picGraphics.Height - yCoord - LetterWidth, xCoord + 0, picGraphics.Height - yCoord - LetterWidth, g)
        gCodeWriteText(xCoord + 0, picGraphics.Height - yCoord - LetterWidth, xCoord + 0, picGraphics.Height - yCoord - 2 * LetterWidth, g)
        gCodeWriteText(xCoord + 0, picGraphics.Height - yCoord - 2 * LetterWidth, xCoord + LetterWidth, picGraphics.Height - yCoord - 2 * LetterWidth, g)

    End Sub

    Private Sub DrawNumber6(ByVal xCoord As Integer, ByVal yCoord As Integer, ByRef g As Graphics)

        gCodeWriteText(xCoord + 0, picGraphics.Height - yCoord - 0, xCoord + LetterWidth, picGraphics.Height - yCoord - 0, g)
        gCodeWriteText(xCoord + LetterWidth, picGraphics.Height - yCoord - 0, xCoord + LetterWidth, picGraphics.Height - yCoord - LetterWidth, g)
        gCodeWriteText(xCoord + LetterWidth, picGraphics.Height - yCoord - LetterWidth, xCoord + 0, picGraphics.Height - yCoord - LetterWidth, g)
        gCodeWriteText(xCoord + 0, picGraphics.Height - yCoord - 0, xCoord + 0, picGraphics.Height - yCoord - 2 * LetterWidth, g)
        gCodeWriteText(xCoord + 0, picGraphics.Height - yCoord - 2 * LetterWidth, xCoord + LetterWidth, picGraphics.Height - yCoord - 2 * LetterWidth, g)

    End Sub

    Private Sub DrawNumber7(ByVal xCoord As Integer, ByVal yCoord As Integer, ByRef g As Graphics)

        gCodeWriteText(xCoord + LetterWidth, picGraphics.Height - yCoord - 0, xCoord + LetterWidth, picGraphics.Height - yCoord - 2 * LetterWidth, g)
        gCodeWriteText(xCoord + LetterWidth, picGraphics.Height - yCoord - 2 * LetterWidth, xCoord + 0, picGraphics.Height - yCoord - 2 * LetterWidth, g)

    End Sub

    Private Sub DrawNumber8(ByVal xCoord As Integer, ByVal yCoord As Integer, ByRef g As Graphics)

        DrawNumber0(xCoord, yCoord, g)
        gCodeWriteText(xCoord + 0, picGraphics.Height - yCoord - LetterWidth, xCoord + LetterWidth, picGraphics.Height - yCoord - LetterWidth, g)

    End Sub

    Private Sub DrawNumber9(ByVal xCoord As Integer, ByVal yCoord As Integer, ByRef g As Graphics)

        gCodeWriteText(xCoord + 0, picGraphics.Height - yCoord - 0, xCoord + LetterWidth, picGraphics.Height - yCoord - 0, g)
        gCodeWriteText(xCoord + LetterWidth, picGraphics.Height - yCoord - 0, xCoord + LetterWidth, picGraphics.Height - yCoord - 2 * LetterWidth, g)
        gCodeWriteText(xCoord + LetterWidth, picGraphics.Height - yCoord - 2 * LetterWidth, xCoord + 0, picGraphics.Height - yCoord - 2 * LetterWidth, g)
        gCodeWriteText(xCoord + 0, picGraphics.Height - yCoord - 2 * LetterWidth, xCoord + 0, picGraphics.Height - yCoord - LetterWidth, g)
        gCodeWriteText(xCoord + 0, picGraphics.Height - yCoord - LetterWidth, xCoord + LetterWidth, picGraphics.Height - yCoord - LetterWidth, g)

    End Sub

#End Region

#Region "Update Graphics"

    Private Sub nudLaserStart_ValueChanged(sender As Object, e As EventArgs) Handles nudLaserStart.ValueChanged
        '// Update display picture
        UpdateGraphics()
        '// Checks for errors
        If nudLaserStart.Value + nudLaserIncrement.Value * 8 >= 100 Then
            errProvider.SetError(nudLaserStart, "The starting value for laser power in combination with the increment value results in" & Environment.NewLine & "excessive laser power. Please reduce those values.")
        Else
            errProvider.SetError(nudLaserStart, String.Empty)
        End If

    End Sub

    Private Sub nudLaserIncrement_ValueChanged(sender As Object, e As EventArgs) Handles nudLaserIncrement.ValueChanged
        '// Update display picture
        UpdateGraphics()
        '// Checks for errors
        If nudLaserStart.Value + nudLaserIncrement.Value * 8 >= 100 Then
            errProvider.SetError(nudLaserStart, "The starting value for laser power in combination with the increment value results in excessive laser power")
        Else
            errProvider.SetError(nudLaserStart, String.Empty)
        End If

    End Sub

    Private Sub nudSpeedStart_ValueChanged(sender As Object, e As EventArgs) Handles nudSpeedStart.ValueChanged
        '// Update display picture
        UpdateGraphics()
    End Sub

    Private Sub nudSpeedIncrement_ValueChanged(sender As Object, e As EventArgs) Handles nudSpeedIncrement.ValueChanged
        '// Update display picture
        UpdateGraphics()
    End Sub

    Private Sub cboOrigin_ValueMemberChanged(sender As Object, e As EventArgs) Handles cboOrigin.ValueMemberChanged
        '// Update display picture
        UpdateGraphics()
    End Sub

    Private Sub tmrOriginUpdate_Tick(sender As Object, e As EventArgs) Handles tmrOriginUpdate.Tick
        '// Update display picture
        UpdateGraphics()
    End Sub

    Private Sub chkOuterBox_CheckedChanged(sender As Object, e As EventArgs) Handles chkOuterBox.CheckedChanged
        '// Update display picture
        UpdateGraphics()
    End Sub

    Private Sub chkMiddleBox_CheckedChanged(sender As Object, e As EventArgs) Handles chkMiddleBox.CheckedChanged
        '// Update display picture
        UpdateGraphics()
    End Sub

    Private Sub chkInnerBox_CheckedChanged(sender As Object, e As EventArgs) Handles chkInnerBox.CheckedChanged
        '// Update display picture
        UpdateGraphics()
    End Sub

    Private Sub chkCross_CheckedChanged(sender As Object, e As EventArgs) Handles chkCross.CheckedChanged
        '// Update display picture
        UpdateGraphics()
    End Sub

    Private Sub cboOrigin_DropDown(sender As Object, e As EventArgs) Handles cboOrigin.DropDown
        '// Enable timer for dinamically updating origin location
        tmrOriginUpdate.Enabled = True
    End Sub

    Private Sub cboOrigin_DropDownClosed(sender As Object, e As EventArgs) Handles cboOrigin.DropDownClosed
        '// Disable timer for dinamically updating origin location
        tmrOriginUpdate.Enabled = False
        '// Update display picture
        UpdateGraphics()
    End Sub

    Private Sub UpdateGraphics()

        '// Create new graphic
        Dim bmp As New Bitmap(picGraphics.Width, picGraphics.Height)
        Dim thumb As New Bitmap(picGraphics.Width, picGraphics.Height, Imaging.PixelFormat.Format8bppIndexed)
        Dim g As Graphics = Graphics.FromImage(bmp)
        Dim xOffset As Integer
        Dim iLaserPower As Integer

        '// Fiil background with white
        Dim whitebrush As SolidBrush = New SolidBrush(Color.White)
        Dim rect As RectangleF
        rect.X = 0
        rect.Y = 0
        rect.Width = picGraphics.Width
        rect.Height = picGraphics.Height
        g.FillRectangle(whitebrush, rect)

        '// Add gCode comment
        If bExportGcode Then
            txtGCode.Text += gCodeWriteComment("Starting laser power scale")
        End If

        '// Draw laser power scale
        For i = 0 To 9
            Select Case nudLaserStart.Value + (nudLaserIncrement.Value * i)
                Case < 10
                    xOffset = LetterSpace * 4 + LetterWidth * 2
                Case < 20
                    xOffset = LetterSpace * 1 + LetterWidth * 1
                Case < 100
                    xOffset = LetterSpace * 2 + LetterWidth * 1
                Case Else
                    xOffset = 0
            End Select
            iLaserPower = nudLaserStart.Value + (nudLaserIncrement.Value * i)
            If iLaserPower > 100 Then iLaserPower = 100
            DrawNumber(xOffset / 2 + MainSpacer * 2 + MainSpacer * i, picGraphics.Height - MainSpacer * 1.7 + LetterSpace, iLaserPower, g)
        Next

        '// Add gCode comment
        If bExportGcode Then
            txtGCode.Text += gCodeWriteComment("Starting laser speed scale")
        End If

        '// Draw laser speed scale
        For i = 0 To 9
            Select Case nudSpeedStart.Value + (nudSpeedIncrement.Value * i)
                Case < 10
                    xOffset = LetterSpace * 3 + LetterWidth * 3
                Case < 100
                    xOffset = LetterSpace * 2 + LetterWidth * 2
                Case < 1000
                    xOffset = LetterSpace * 1 + LetterWidth * 1
                Case Else
                    xOffset = 0
            End Select
            DrawNumber(xOffset + LetterSpace * 3, LetterSpace * 2 + MainSpacer * i, nudSpeedStart.Value + (nudSpeedIncrement.Value * i), g)
        Next

        Dim blackpen As New Drawing.Pen(Color.Black)

        Dim iPower As Single
        Dim iSpeed As Single

        '// Add gCode comment
        If bExportGcode Then
            txtGCode.Text += gCodeWriteComment("Starting matrix design")
        End If

        '// Draw test squares
        For iPower = 0 To 9
            For iSpeed = 0 To 9
                '// Add gCode comment for power
                If bExportGcode Then
                    iLaserPower = CInt(nudLaserStart.Value + nudLaserIncrement.Value * iPower)
                    If iLaserPower >= 100 Then iLaserPower = 100
                    txtGCode.Text += gCodeWriteComment("Power level " + (iPower + 1).ToString + " = " + iLaserPower.ToString + "%")
                End If
                '// Add gCode comment for speed
                If bExportGcode Then
                    txtGCode.Text += gCodeWriteComment("Speed level " + (iSpeed + 1).ToString + " = " + CInt(nudSpeedStart.Value + nudSpeedIncrement.Value * iSpeed).ToString + "mm/min.")
                End If
                '// Cross
                If chkCross.Checked Then
                    '// Add gCode comment
                    If bExportGcode Then
                        txtGCode.Text += gCodeWriteComment("Start cross design")
                    End If
                    gCodeWriteMatrix(CSng(MainSpacer * 2 + LetterSpace + MainSpacer * iPower), CSng(picGraphics.Height - LetterSpace - MainSpacer * iSpeed), CSng(MainSpacer * 2 - LetterSpace + MainSpacer * (iPower + 1)), CSng(picGraphics.Height + LetterSpace - MainSpacer * (iSpeed + 1)), nudLaserStart.Value + nudLaserIncrement.Value * iPower, nudSpeedStart.Value + nudSpeedIncrement.Value * iSpeed, g)
                    gCodeWriteMatrix(CSng(MainSpacer * 2 + LetterSpace + MainSpacer * iPower), CSng(picGraphics.Height + LetterSpace - MainSpacer * (iSpeed + 1)), CSng(MainSpacer * 2 - LetterSpace + MainSpacer * (iPower + 1)), CSng(picGraphics.Height - LetterSpace - MainSpacer * iSpeed), nudLaserStart.Value + nudLaserIncrement.Value * iPower, nudSpeedStart.Value + nudSpeedIncrement.Value * iSpeed, g)
                End If
                '// Big square
                If chkOuterBox.Checked Then
                    '// Add gCode comment
                    If bExportGcode Then
                        txtGCode.Text += gCodeWriteComment("Start outer square design")
                    End If
                    gCodeWriteMatrix(CSng(MainSpacer * 2 - LetterSpace + MainSpacer * (iPower + 1)), CSng(picGraphics.Height - LetterSpace - MainSpacer * iSpeed), CSng(MainSpacer * 2 - LetterSpace + MainSpacer * (iPower + 1)), CSng(picGraphics.Height + LetterSpace - MainSpacer * (iSpeed + 1)), nudLaserStart.Value + nudLaserIncrement.Value * iPower, nudSpeedStart.Value + nudSpeedIncrement.Value * iSpeed, g)
                    gCodeWriteMatrix(CSng(MainSpacer * 2 - LetterSpace + MainSpacer * (iPower + 1)), CSng(picGraphics.Height + LetterSpace - MainSpacer * (iSpeed + 1)), CSng(MainSpacer * 2 + LetterSpace + MainSpacer * iPower), CSng(picGraphics.Height + LetterSpace - MainSpacer * (iSpeed + 1)), nudLaserStart.Value + nudLaserIncrement.Value * iPower, nudSpeedStart.Value + nudSpeedIncrement.Value * iSpeed, g)
                    gCodeWriteMatrix(CSng(MainSpacer * 2 + LetterSpace + MainSpacer * iPower), CSng(picGraphics.Height + LetterSpace - MainSpacer * (iSpeed + 1)), CSng(MainSpacer * 2 + LetterSpace + MainSpacer * iPower), CSng(picGraphics.Height - LetterSpace - MainSpacer * iSpeed), nudLaserStart.Value + nudLaserIncrement.Value * iPower, nudSpeedStart.Value + nudSpeedIncrement.Value * iSpeed, g)
                    gCodeWriteMatrix(CSng(MainSpacer * 2 + LetterSpace + MainSpacer * iPower), CSng(picGraphics.Height - LetterSpace - MainSpacer * iSpeed), CSng(MainSpacer * 2 - LetterSpace + MainSpacer * (iPower + 1)), CSng(picGraphics.Height - LetterSpace - MainSpacer * iSpeed), nudLaserStart.Value + nudLaserIncrement.Value * iPower, nudSpeedStart.Value + nudSpeedIncrement.Value * iSpeed, g)

                End If
                '// Medium square
                If chkMiddleBox.Checked Then
                    '// Add gCode comment
                    If bExportGcode Then
                        txtGCode.Text += gCodeWriteComment("Start medium square design")
                    End If
                    gCodeWriteMatrix(CSng(MainSpacer * 2 - LetterSpace * 2 + MainSpacer * (iPower + 1)), CSng(picGraphics.Height - LetterSpace * 2 - MainSpacer * iSpeed), CSng(MainSpacer * 2 + LetterSpace * 2 + MainSpacer * iPower), CSng(picGraphics.Height - LetterSpace * 2 - MainSpacer * iSpeed), nudLaserStart.Value + nudLaserIncrement.Value * iPower, nudSpeedStart.Value + nudSpeedIncrement.Value * iSpeed, g)
                    gCodeWriteMatrix(CSng(MainSpacer * 2 + LetterSpace * 2 + MainSpacer * iPower), CSng(picGraphics.Height - LetterSpace * 2 - MainSpacer * iSpeed), CSng(MainSpacer * 2 + LetterSpace * 2 + MainSpacer * iPower), CSng(picGraphics.Height + LetterSpace * 2 - MainSpacer * (iSpeed + 1)), nudLaserStart.Value + nudLaserIncrement.Value * iPower, nudSpeedStart.Value + nudSpeedIncrement.Value * iSpeed, g)
                    gCodeWriteMatrix(CSng(MainSpacer * 2 + LetterSpace * 2 + MainSpacer * iPower), CSng(picGraphics.Height + LetterSpace * 2 - MainSpacer * (iSpeed + 1)), CSng(MainSpacer * 2 - LetterSpace * 2 + MainSpacer * (iPower + 1)), CSng(picGraphics.Height + LetterSpace * 2 - MainSpacer * (iSpeed + 1)), nudLaserStart.Value + nudLaserIncrement.Value * iPower, nudSpeedStart.Value + nudSpeedIncrement.Value * iSpeed, g)
                    gCodeWriteMatrix(CSng(MainSpacer * 2 - LetterSpace * 2 + MainSpacer * (iPower + 1)), CSng(picGraphics.Height + LetterSpace * 2 - MainSpacer * (iSpeed + 1)), CSng(MainSpacer * 2 - LetterSpace * 2 + MainSpacer * (iPower + 1)), CSng(picGraphics.Height - LetterSpace * 2 - MainSpacer * iSpeed), nudLaserStart.Value + nudLaserIncrement.Value * iPower, nudSpeedStart.Value + nudSpeedIncrement.Value * iSpeed, g)
                End If
                '// Small square
                If chkInnerBox.Checked Then
                    '// Add gCode comment
                    If bExportGcode Then
                        txtGCode.Text += gCodeWriteComment("Start inner square design")
                    End If
                    gCodeWriteMatrix(CSng(MainSpacer * 2 - LetterSpace * 3 + MainSpacer * (iPower + 1)), CSng(picGraphics.Height - LetterSpace * 3 - MainSpacer * iSpeed), CSng(MainSpacer * 2 + LetterSpace * 3 + MainSpacer * iPower), CSng(picGraphics.Height - LetterSpace * 3 - MainSpacer * iSpeed), nudLaserStart.Value + nudLaserIncrement.Value * iPower, nudSpeedStart.Value + nudSpeedIncrement.Value * iSpeed, g)
                    gCodeWriteMatrix(CSng(MainSpacer * 2 + LetterSpace * 3 + MainSpacer * iPower), CSng(picGraphics.Height - LetterSpace * 3 - MainSpacer * iSpeed), CSng(MainSpacer * 2 + LetterSpace * 3 + MainSpacer * iPower), CSng(picGraphics.Height + LetterSpace * 3 - MainSpacer * (iSpeed + 1)), nudLaserStart.Value + nudLaserIncrement.Value * iPower, nudSpeedStart.Value + nudSpeedIncrement.Value * iSpeed, g)
                    gCodeWriteMatrix(CSng(MainSpacer * 2 + LetterSpace * 3 + MainSpacer * iPower), CSng(picGraphics.Height + LetterSpace * 3 - MainSpacer * (iSpeed + 1)), CSng(MainSpacer * 2 - LetterSpace * 3 + MainSpacer * (iPower + 1)), CSng(picGraphics.Height + LetterSpace * 3 - MainSpacer * (iSpeed + 1)), nudLaserStart.Value + nudLaserIncrement.Value * iPower, nudSpeedStart.Value + nudSpeedIncrement.Value * iSpeed, g)
                    gCodeWriteMatrix(CSng(MainSpacer * 2 - LetterSpace * 3 + MainSpacer * (iPower + 1)), CSng(picGraphics.Height + LetterSpace * 3 - MainSpacer * (iSpeed + 1)), CSng(MainSpacer * 2 - LetterSpace * 3 + MainSpacer * (iPower + 1)), CSng(picGraphics.Height - LetterSpace * 3 - MainSpacer * iSpeed), nudLaserStart.Value + nudLaserIncrement.Value * iPower, nudSpeedStart.Value + nudSpeedIncrement.Value * iSpeed, g)
                End If
            Next
        Next

        ''// Create matrix thumbnail
        thumb = bmp
        Dim ms As New IO.MemoryStream
        thumb.Save(ms, Imaging.ImageFormat.Png)
        Dim bytes() As Byte = ms.GetBuffer()
        sMatrixThumbnailB64 = Convert.ToBase64String(bytes)
        ms.Dispose()

        '// Draw origin
        Dim redbrush As SolidBrush = New SolidBrush(Color.Red)
        Select Case cboOrigin.Text
            Case "BL"
                g.FillEllipse(redbrush, -1, picGraphics.Height - 10, 10, 10)
            Case "BR"
                g.FillEllipse(redbrush, picGraphics.Width - 10, picGraphics.Height - 10, 10, 10)
            Case "TL"
                g.FillEllipse(redbrush, -1, -1, 10, 10)
            Case "TR"
                g.FillEllipse(redbrush, picGraphics.Width - 10, -1, 10, 10)
            Case "CTR"
                g.FillEllipse(redbrush, CInt(picGraphics.Width / 2), CInt(picGraphics.Height / 2), 10, 10)
        End Select
        cboOrigin.Refresh()


        '// Assign bmp to picure box
        picGraphics.Image = bmp

    End Sub

#End Region

#Region "gCode Writer"

    Private Function gCodeStartLaser(LaserPower As Integer) As String
        '// Return gCode line to start laser
        If LaserPower >= 100 Then LaserPower = 100
        Return "M3 P" + Format(LaserPower, "0") + " S" + Format(LaserPower / 100 * 255, "0") + Environment.NewLine
    End Function

    Private Function gCodeLinearWorkMove(x As Single, y As Single, iFeed As Integer) As String
        '// Return gCode line for work movement
        Return "G1 X" + Format(x, "0.00").Replace(",", ".") + " Y" + Format(y, "0.00").Replace(",", ".") + " F" + Format(iFeed, "0") + Environment.NewLine
    End Function

    Private Function gCodeLinearFastMove(x As Single, y As Single) As String
        '// Return gCode line for work movement
        Return "G0 X" + Format(x, "0.00").Replace(",", ".") + " Y" + Format(y, "0.00").Replace(",", ".") + Environment.NewLine
    End Function

    Private Function gCodeWriteComment(sComment As String, Optional bAddSpace As Boolean = True) As String
        Return ";" + If(bAddSpace = True, " ", "") + sComment + Environment.NewLine
    End Function

    Private Sub gCodeCalculateWorkOriginOffsets(ByRef X_Offset As Single, ByRef Y_Offset As Single)

        '// Calculate work origin offsets
        Select Case cboOrigin.Text
            Case "BL"
                X_Offset = 0
                Y_Offset = 0
            Case "BR"
                X_Offset = -nudMatrixSize.Value
                Y_Offset = 0
            Case "TL"
                X_Offset = 0
                Y_Offset = -nudMatrixSize.Value
            Case "TR"
                X_Offset = -nudMatrixSize.Value
                Y_Offset = -nudMatrixSize.Value
            Case "CTR"
                X_Offset = -nudMatrixSize.Value / 2
                Y_Offset = -nudMatrixSize.Value / 2
        End Select

    End Sub

    Private Sub gCodeWriteHeader()

        '// Clears output
        txtGCode.Clear()

        '// Header
        txtGCode.Text += gCodeWriteComment(Application.ProductName.Replace("Snapmaker ", "") + " for power vs. speed comparison")
        txtGCode.Text += gCodeWriteComment("Created using " + Application.ProductName + " by Nuno Vaz Oliveira")
        txtGCode.Text += Environment.NewLine
        '// Thumbnail
        txtGCode.Text += gCodeWriteComment("Header Start", False)
        txtGCode.Text += gCodeWriteComment("thumbnail: data:image/png;base64," + sMatrixThumbnailB64, False)
        txtGCode.Text += gCodeWriteComment("Header End", False)
        txtGCode.Text += Environment.NewLine

        '// Settings
        txtGCode.Text += gCodeWriteComment("Laser start power: " + nudLaserStart.Value.ToString + "%")
        txtGCode.Text += gCodeWriteComment("Laser power increment: " + nudLaserIncrement.Value.ToString + "%")
        txtGCode.Text += gCodeWriteComment("Laser start speed: " + nudSpeedStart.Value.ToString + "mm/min.")
        txtGCode.Text += gCodeWriteComment("Laser speed increment: " + nudSpeedIncrement.Value.ToString + "mm/min.")
        txtGCode.Text += gCodeWriteComment("Work origin: " + cboOrigin.Text.ToString)
        txtGCode.Text += gCodeWriteComment("Text laser speed: " + nudTextSpeed.Value.ToString + "mm/min.")
        txtGCode.Text += gCodeWriteComment("Text laser power: " + nudTextPower.Value.ToString + "%")
        txtGCode.Text += Environment.NewLine
        '// gCode Setup
        txtGCode.Text += "G90 ; Absolute Positioning" + Environment.NewLine
        txtGCode.Text += "G21 ; Millimeter Units" + Environment.NewLine
        txtGCode.Text += "M106 P0 S255 ; Set Fan speed to maximum" + Environment.NewLine
        txtGCode.Text += "G0 F" + Format(msRapidSpeed, "0") + " ; Set fast moves speed" + Environment.NewLine
        txtGCode.Text += Environment.NewLine

    End Sub

    Private Sub gCodeWriteFooter()
        '// Stop the fan
        txtGCode.Text += Environment.NewLine + "M107 P0 ; Stop Fan" + Environment.NewLine
    End Sub

    Private Sub gCodeWriteText(x1 As Integer, y1 As Integer, x2 As Integer, y2 As Integer, g As Graphics)

        '// Create variables for gCode
        Dim gCodeX1 As Single
        Dim gCodeX2 As Single
        Dim gCodeY1 As Single
        Dim gCodeY2 As Single
        '// Work Origin Offsets
        Dim sWorkOriginOffsetX As Single = 0
        Dim sWorkOriginOffsetY As Single = 0

        If bExportGcode Then
            '// Calculate work origin offsets
            gCodeCalculateWorkOriginOffsets(sWorkOriginOffsetX, sWorkOriginOffsetY)
            '// Calculate real coordinates
            gCodeX1 = (1.0 * x1) * nudMatrixSize.Value / picGraphics.Width
            gCodeX2 = (1.0 * x2) * nudMatrixSize.Value / picGraphics.Width
            gCodeY1 = (1.0 * (picGraphics.Height - y1)) * nudMatrixSize.Value / picGraphics.Width
            gCodeY2 = (1.0 * (picGraphics.Height - y2)) * nudMatrixSize.Value / picGraphics.Width
            '// Go to start point
            txtGCode.Text += gCodeLinearFastMove(gCodeX1 + sWorkOriginOffsetX, gCodeY1 + sWorkOriginOffsetY)
            '// gCode start laser
            txtGCode.Text += gCodeStartLaser(nudTextPower.Value)
            '// gCode burn to second point
            txtGCode.Text += gCodeLinearWorkMove(gCodeX2 + sWorkOriginOffsetX, gCodeY2 + sWorkOriginOffsetY, nudTextSpeed.Value)
            '// gCode stop laser
            txtGCode.Text += "M5" + Environment.NewLine
        End If

        '// Create pen for drawing
        Dim blackpen As New Drawing.Pen(Color.Black)
        '// Draw line
        g.DrawLine(blackpen, x1, y1, x2, y2)

    End Sub

    Private Sub gCodeWriteMatrix(x1 As Integer, y1 As Integer, x2 As Integer, y2 As Integer, LaserPower As Integer, LaserSpeed As Integer, g As Graphics)

        '// Create variables for gCode
        Dim gCodeX1 As Single
        Dim gCodeX2 As Single
        Dim gCodeY1 As Single
        Dim gCodeY2 As Single
        '// Work Origin Offsets
        Dim sWorkOriginOffsetX As Single = 0
        Dim sWorkOriginOffsetY As Single = 0

        If bExportGcode Then
            '// Calculate work origin offsets
            gCodeCalculateWorkOriginOffsets(sWorkOriginOffsetX, sWorkOriginOffsetY)
            '// Calculate real coordinates
            gCodeX1 = (1.0 * x1) * nudMatrixSize.Value / picGraphics.Width
            gCodeX2 = (1.0 * x2) * nudMatrixSize.Value / picGraphics.Width
            gCodeY1 = (1.0 * (picGraphics.Height - y1)) * nudMatrixSize.Value / picGraphics.Width
            gCodeY2 = (1.0 * (picGraphics.Height - y2)) * nudMatrixSize.Value / picGraphics.Width
            '// Go to start point
            txtGCode.Text += gCodeLinearFastMove(gCodeX1 + sWorkOriginOffsetX, gCodeY1 + sWorkOriginOffsetY)
            '// gCode start laser
            txtGCode.Text += gCodeStartLaser(LaserPower)
            '// gCode burn to second point
            txtGCode.Text += gCodeLinearWorkMove(gCodeX2 + sWorkOriginOffsetX, gCodeY2 + sWorkOriginOffsetY, LaserSpeed)
            '// gCode stop laser
            txtGCode.Text += "M5" + Environment.NewLine
        End If

        '// Create pen for drawing
        Dim blackpen As New Drawing.Pen(Color.Black)
        '// Draw line
        g.DrawLine(blackpen, x1, y1, x2, y2)

    End Sub

    Private Sub gCodeCreate()

        '// Create gCode
        gCodeWriteHeader()
        bExportGcode = True
        UpdateGraphics()
        bExportGcode = False
        gCodeWriteFooter()

    End Sub


#End Region

    Private Sub btnCopy_Click(sender As Object, e As EventArgs) Handles btnCopy.Click

        '// Create gCode
        gCodeCreate()
        '// Copy to clipboard
        Clipboard.Clear()
        Clipboard.SetText(txtGCode.Text)

    End Sub

    Private Sub btnPreview_Click(sender As Object, e As EventArgs) Handles btnPreview.Click

        '// Create gCode
        gCodeCreate()

        '// Display new form
        Dim frmPreviewGcode As New frmPreview
        frmPreviewGcode.txtGcodePreview.Text = txtGCode.Text
        frmPreviewGcode.ShowDialog()
        '// Disposes form
        frmPreviewGcode.Dispose()

    End Sub

    Private Sub btnExport_Click(sender As Object, e As EventArgs) Handles btnExport.Click

        '// Create gCode
        gCodeCreate()

        '// Setup save dialog
        dlgSave.AddExtension = True
        dlgSave.CheckFileExists = False
        dlgSave.CheckPathExists = True
        dlgSave.FileName = "test_grid"
        dlgSave.Filter = "nc files (*.nc)|*.nc|All files (*.*)|*.*"
        dlgSave.FilterIndex = 1
        dlgSave.OverwritePrompt = True
        dlgSave.RestoreDirectory = True
        dlgSave.Title = "Save gCode laser file as..."
        '// Show save dialog
        If dlgSave.ShowDialog() = DialogResult.OK Then
            '// Create file stream
            Dim myStream As IO.Stream
            myStream = dlgSave.OpenFile()
            myStream.Write(System.Text.Encoding.UTF8.GetBytes(txtGCode.Text), 0, System.Text.Encoding.UTF8.GetBytes(txtGCode.Text).Length)
            myStream.Close()
        End If

    End Sub

    Private Sub btnToggleText_Click(sender As Object, e As EventArgs) Handles btnToggleText.Click
        txtGCode.Visible = Not txtGCode.Visible
    End Sub

    Private Sub cboOrigin_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboOrigin.SelectedIndexChanged
        '// Update display picture
        UpdateGraphics()
    End Sub

    Private Sub nudLaserStart_Validating(sender As Object, e As CancelEventArgs) Handles nudLaserStart.Validating



    End Sub
End Class
