Imports System.IO

Public Class Form1
    Public Shared EXEStream() As Byte
    Dim EXEName As String = Nothing

    Private Sub OpenToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles OpenToolStripMenuItem.Click
        Dim OpenEXEDialog As New OpenFileDialog With {
            .Filter = "EXE files|*.exe",
            .FileName = "Tsonic_win.exe"
        }

        If OpenEXEDialog.ShowDialog() = System.Windows.Forms.DialogResult.OK Then
            EXEName = OpenEXEDialog.FileName

            OpenEXE(EXEName)
            SaveToolStripMenuItem.Enabled = True
            SaveAsToolStripMenuItem.Enabled = True
            EditorsToolStripMenuItem.Enabled = True
        End If
    End Sub

    Private Sub SaveToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SaveToolStripMenuItem.Click
        SaveEXE(EXEName)
    End Sub

    Private Sub SaveAsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SaveAsToolStripMenuItem.Click
        Dim SaveEXEDialog As New SaveFileDialog With {
            .Filter = "EXE files|*.exe",
            .FileName = EXEName
        }

        If SaveEXEDialog.ShowDialog() = System.Windows.Forms.DialogResult.OK Then
            EXEName = SaveEXEDialog.FileName
            SaveEXE(EXEName)
        End If
    End Sub

    Private Sub AboutToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AboutToolStripMenuItem.Click
        AboutBox.MdiParent = Me
        AboutBox.Show()
    End Sub

    Private Sub OpenEXE(ByRef FileName As String)
        EXEStream = File.ReadAllBytes(FileName)
    End Sub

    Private Sub SaveEXE(ByRef FileName As String)
        SaveToolStripMenuItem.Enabled = False
        Dim EXESaver As New BinaryWriter(New FileStream(FileName, FileMode.Create))
        EXESaver.Write(EXEStream)
        SaveToolStripMenuItem.Enabled = True
    End Sub

    Private Sub ChaotixMissionEditorToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ChaotixMissionEditorToolStripMenuItem.Click
        ChaotixEditor.MdiParent = Me
        ChaotixEditor.Show()
    End Sub

    Private Sub MissionEditorToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles MissionEditorToolStripMenuItem.Click
        MissionEditor.MdiParent = Me
        MissionEditor.Show()
    End Sub

    Private Sub SplineEditorToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SplineEditorToolStripMenuItem.Click
        SplineEditor.MdiParent = Me
        SplineEditor.Show()
    End Sub

    Private Sub StartEndingPositionEditorToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles StartEndingPositionEditorToolStripMenuItem.Click
        StartEndEditor.MdiParent = Me
        StartEndEditor.Show()
    End Sub

    Private Sub BobsledEditorToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles BobsledEditorToolStripMenuItem.Click
        BobsledEditor.MdiParent = Me
        BobsledEditor.Show()
    End Sub

    Private Sub RankingRequirementsEditorToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles RankingRequirementsEditorToolStripMenuItem.Click
        RankingEditor.MdiParent = Me
        RankingEditor.Show()
    End Sub

    Private Sub UnlockRequirementsEditorToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles UnlockRequirementsEditorToolStripMenuItem.Click
        UnlockReqEditor.MdiParent = Me
        UnlockReqEditor.Show()
    End Sub

    Private Sub ExitToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ExitToolStripMenuItem.Click
        Close()
    End Sub
End Class