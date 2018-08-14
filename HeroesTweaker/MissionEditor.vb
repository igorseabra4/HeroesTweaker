Public Class MissionEditor
    Dim ProgramIsChangingStuff As Boolean = False

    Private Sub MissionEditor_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ProgramIsChangingStuff = True

        NumericTS03.Value = Form1.EXEStream(&H3C6A68 + 5)
        NumericTS04.Value = Form1.EXEStream(&H3C6A68 + 1 * 8 + 5)
        NumericTS05.Value = Form1.EXEStream(&H3C6A68 + 2 * 8 + 5)
        NumericTS06.Value = Form1.EXEStream(&H3C6A68 + 3 * 8 + 5)
        NumericTS07.Value = Form1.EXEStream(&H3C6A68 + 4 * 8 + 5)
        NumericTS08.Value = Form1.EXEStream(&H3C6A68 + 5 * 8 + 5)
        NumericTS09.Value = Form1.EXEStream(&H3C6A68 + 6 * 8 + 5)
        NumericTS10.Value = Form1.EXEStream(&H3C6A68 + 7 * 8 + 5)
        NumericTS11.Value = Form1.EXEStream(&H3C6A68 + 8 * 8 + 5)
        NumericTS12.Value = Form1.EXEStream(&H3C6A68 + 9 * 8 + 5)
        NumericTS13.Value = Form1.EXEStream(&H3C6A68 + 10 * 8 + 5)
        NumericTS14.Value = Form1.EXEStream(&H3C6A68 + 11 * 8 + 5)
        NumericTS15.Value = Form1.EXEStream(&H3C6A68 + 12 * 8 + 5)
        NumericTS16.Value = Form1.EXEStream(&H3C6A68 + 13 * 8 + 5)
        NumericTS17.Value = Form1.EXEStream(&H3C6A68 + 6)
        NumericTS18.Value = Form1.EXEStream(&H3C6A68 + 1 * 8 + 6)
        NumericTS19.Value = Form1.EXEStream(&H3C6A68 + 2 * 8 + 6)
        NumericTS20.Value = Form1.EXEStream(&H3C6A68 + 3 * 8 + 6)
        NumericTS21.Value = Form1.EXEStream(&H3C6A68 + 4 * 8 + 6)
        NumericTS22.Value = Form1.EXEStream(&H3C6A68 + 5 * 8 + 6)
        NumericTS23.Value = Form1.EXEStream(&H3C6A68 + 6 * 8 + 6)
        NumericTS24.Value = Form1.EXEStream(&H3C6A68 + 7 * 8 + 6)
        NumericTS25.Value = Form1.EXEStream(&H3C6A68 + 8 * 8 + 6)
        NumericTS26.Value = Form1.EXEStream(&H3C6A68 + 9 * 8 + 6)
        NumericTS27.Value = Form1.EXEStream(&H3C6A68 + 10 * 8 + 6)
        NumericTS28.Value = Form1.EXEStream(&H3C6A68 + 11 * 8 + 6)
        NumericTS29.Value = Form1.EXEStream(&H3C6A68 + 12 * 8 + 6)
        NumericTS30.Value = Form1.EXEStream(&H3C6A68 + 13 * 8 + 6)

        NumericTDarkEnemies.Value = Form1.EXEStream(&H1A9993)

        NumericTRoseRings.Maximum = &H7FFFFFFF

        NumericTRoseRings.Value = BitConverter.ToInt32(Form1.EXEStream, &H1A9E0F)

        ProgramIsChangingStuff = False
    End Sub

    Private Sub NumericTS03_ValueChanged(sender As Object, e As EventArgs) Handles NumericTS03.ValueChanged
        If ProgramIsChangingStuff = False Then
            Form1.EXEStream(&H3C6A68 + 5) = NumericTS03.Value
        End If
    End Sub

    Private Sub NumericTS04_ValueChanged(sender As Object, e As EventArgs) Handles NumericTS04.ValueChanged
        If ProgramIsChangingStuff = False Then
            Form1.EXEStream(&H3C6A68 + 1 * 8 + 5) = NumericTS04.Value
        End If
    End Sub

    Private Sub NumericTS05_ValueChanged(sender As Object, e As EventArgs) Handles NumericTS05.ValueChanged
        If ProgramIsChangingStuff = False Then
            Form1.EXEStream(&H3C6A68 + 2 * 8 + 5) = NumericTS05.Value
        End If
    End Sub

    Private Sub NumericTS06_ValueChanged(sender As Object, e As EventArgs) Handles NumericTS06.ValueChanged
        If ProgramIsChangingStuff = False Then
            Form1.EXEStream(&H3C6A68 + 3 * 8 + 5) = NumericTS06.Value
        End If
    End Sub

    Private Sub NumericTS07_ValueChanged(sender As Object, e As EventArgs) Handles NumericTS07.ValueChanged
        If ProgramIsChangingStuff = False Then
            Form1.EXEStream(&H3C6A68 + 4 * 8 + 5) = NumericTS07.Value
        End If
    End Sub

    Private Sub NumericTS08_ValueChanged(sender As Object, e As EventArgs) Handles NumericTS08.ValueChanged
        If ProgramIsChangingStuff = False Then
            Form1.EXEStream(&H3C6A68 + 5 * 8 + 5) = NumericTS08.Value
        End If
    End Sub

    Private Sub NumericTS09_ValueChanged(sender As Object, e As EventArgs) Handles NumericTS09.ValueChanged
        If ProgramIsChangingStuff = False Then
            Form1.EXEStream(&H3C6A68 + 6 * 8 + 5) = NumericTS09.Value
        End If
    End Sub

    Private Sub NumericTS10_ValueChanged(sender As Object, e As EventArgs) Handles NumericTS10.ValueChanged, NumericTS24.ValueChanged
        If ProgramIsChangingStuff = False Then
            Form1.EXEStream(&H3C6A68 + 7 * 8 + 5) = NumericTS10.Value
        End If
    End Sub

    Private Sub NumericTS11_ValueChanged(sender As Object, e As EventArgs) Handles NumericTS11.ValueChanged, NumericTS25.ValueChanged
        If ProgramIsChangingStuff = False Then
            Form1.EXEStream(&H3C6A68 + 8 * 8 + 5) = NumericTS11.Value
        End If
    End Sub

    Private Sub NumericTS12_ValueChanged(sender As Object, e As EventArgs) Handles NumericTS12.ValueChanged, NumericTS26.ValueChanged
        If ProgramIsChangingStuff = False Then
            Form1.EXEStream(&H3C6A68 + 9 * 8 + 5) = NumericTS12.Value
        End If
    End Sub

    Private Sub NumericTS13_ValueChanged(sender As Object, e As EventArgs) Handles NumericTS13.ValueChanged, NumericTS27.ValueChanged
        If ProgramIsChangingStuff = False Then
            Form1.EXEStream(&H3C6A68 + 10 * 8 + 5) = NumericTS13.Value
        End If
    End Sub

    Private Sub NumericTS14_ValueChanged(sender As Object, e As EventArgs) Handles NumericTS14.ValueChanged, NumericTS28.ValueChanged
        If ProgramIsChangingStuff = False Then
            Form1.EXEStream(&H3C6A68 + 11 * 8 + 5) = NumericTS14.Value
        End If
    End Sub

    Private Sub NumericTS15_ValueChanged(sender As Object, e As EventArgs) Handles NumericTS15.ValueChanged, NumericTS29.ValueChanged
        If ProgramIsChangingStuff = False Then
            Form1.EXEStream(&H3C6A68 + 12 * 8 + 5) = NumericTS15.Value
        End If
    End Sub

    Private Sub NumericTS16_ValueChanged(sender As Object, e As EventArgs) Handles NumericTS16.ValueChanged, NumericTS30.ValueChanged
        If ProgramIsChangingStuff = False Then
            Form1.EXEStream(&H3C6A68 + 13 * 8 + 5) = NumericTS16.Value
        End If
    End Sub

    Private Sub NumericTS17_ValueChanged(sender As Object, e As EventArgs) Handles NumericTS17.ValueChanged
        If ProgramIsChangingStuff = False Then
            Form1.EXEStream(&H3C6A68 + 6) = NumericTS17.Value
        End If
    End Sub

    Private Sub NumericTS18_ValueChanged(sender As Object, e As EventArgs) Handles NumericTS18.ValueChanged
        If ProgramIsChangingStuff = False Then
            Form1.EXEStream(&H3C6A68 + 1 * 8 + 6) = NumericTS18.Value
        End If
    End Sub

    Private Sub NumericTS19_ValueChanged(sender As Object, e As EventArgs) Handles NumericTS19.ValueChanged
        If ProgramIsChangingStuff = False Then
            Form1.EXEStream(&H3C6A68 + 2 * 8 + 6) = NumericTS19.Value
        End If
    End Sub

    Private Sub NumericTS20_ValueChanged(sender As Object, e As EventArgs) Handles NumericTS20.ValueChanged
        If ProgramIsChangingStuff = False Then
            Form1.EXEStream(&H3C6A68 + 3 * 8 + 6) = NumericTS20.Value
        End If
    End Sub

    Private Sub NumericTS21_ValueChanged(sender As Object, e As EventArgs) Handles NumericTS21.ValueChanged
        If ProgramIsChangingStuff = False Then
            Form1.EXEStream(&H3C6A68 + 4 * 8 + 6) = NumericTS07.Value
        End If
    End Sub

    Private Sub NumericTS22_ValueChanged(sender As Object, e As EventArgs) Handles NumericTS22.ValueChanged
        If ProgramIsChangingStuff = False Then
            Form1.EXEStream(&H3C6A68 + 5 * 8 + 6) = NumericTS08.Value
        End If
    End Sub

    Private Sub NumericTS23_ValueChanged(sender As Object, e As EventArgs) Handles NumericTS23.ValueChanged
        If ProgramIsChangingStuff = False Then
            Form1.EXEStream(&H3C6A68 + 6 * 8 + 6) = NumericTS09.Value
        End If
    End Sub

    Private Sub NumericTS24_ValueChanged(sender As Object, e As EventArgs) Handles NumericTS24.ValueChanged
        If ProgramIsChangingStuff = False Then
            Form1.EXEStream(&H3C6A68 + 7 * 8 + 6) = NumericTS10.Value
        End If
    End Sub

    Private Sub NumericTS25_ValueChanged(sender As Object, e As EventArgs) Handles NumericTS25.ValueChanged
        If ProgramIsChangingStuff = False Then
            Form1.EXEStream(&H3C6A68 + 8 * 8 + 6) = NumericTS11.Value
        End If
    End Sub

    Private Sub NumericTS26_ValueChanged(sender As Object, e As EventArgs) Handles NumericTS26.ValueChanged
        If ProgramIsChangingStuff = False Then
            Form1.EXEStream(&H3C6A68 + 9 * 8 + 6) = NumericTS12.Value
        End If
    End Sub

    Private Sub NumericTS27_ValueChanged(sender As Object, e As EventArgs) Handles NumericTS27.ValueChanged
        If ProgramIsChangingStuff = False Then
            Form1.EXEStream(&H3C6A68 + 10 * 8 + 6) = NumericTS13.Value
        End If
    End Sub

    Private Sub NumericTS28_ValueChanged(sender As Object, e As EventArgs) Handles NumericTS28.ValueChanged
        If ProgramIsChangingStuff = False Then
            Form1.EXEStream(&H3C6A68 + 11 * 8 + 6) = NumericTS14.Value
        End If
    End Sub

    Private Sub NumericTS29_ValueChanged(sender As Object, e As EventArgs) Handles NumericTS29.ValueChanged
        If ProgramIsChangingStuff = False Then
            Form1.EXEStream(&H3C6A68 + 12 * 8 + 6) = NumericTS15.Value
        End If
    End Sub

    Private Sub NumericTS30_ValueChanged(sender As Object, e As EventArgs) Handles NumericTS30.ValueChanged
        If ProgramIsChangingStuff = False Then
            Form1.EXEStream(&H3C6A68 + 13 * 8 + 6) = NumericTS16.Value
        End If
    End Sub
    Private Sub NumericTDarkEnemies_ValueChanged(sender As Object, e As EventArgs) Handles NumericTDarkEnemies.ValueChanged
        If ProgramIsChangingStuff = False Then
            Form1.EXEStream(&H1A9993) = NumericTDarkEnemies.Value
            Form1.EXEStream(&H1A9984) = NumericTDarkEnemies.Value
        End If
    End Sub

    Private Sub NumericTRoseRings_ValueChanged(sender As Object, e As EventArgs) Handles NumericTRoseRings.ValueChanged
        If ProgramIsChangingStuff = False Then
            Form1.EXEStream(&H1A9E0F) = BitConverter.GetBytes(NumericTRoseRings.Value)(0)
            Form1.EXEStream(&H1A9E0F + 1) = BitConverter.GetBytes(NumericTRoseRings.Value)(1)
            Form1.EXEStream(&H1A9E0F + 2) = BitConverter.GetBytes(NumericTRoseRings.Value)(2)
            Form1.EXEStream(&H1A9E0F + 3) = BitConverter.GetBytes(NumericTRoseRings.Value)(3)
        End If
    End Sub
End Class