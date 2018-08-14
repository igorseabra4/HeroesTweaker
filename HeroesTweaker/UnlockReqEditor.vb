Public Class UnlockReqEditor
    Dim ProgramIsChangingStuff As Boolean

    Private Sub UnlockReqEditor_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ProgramIsChangingStuff = True
        NumericUpDown1.Value = Form1.EXEStream(&H3433C0)
        NumericUpDown2.Value = Form1.EXEStream(&H3433C1)
        NumericUpDown3.Value = Form1.EXEStream(&H3433C2)
        NumericUpDown4.Value = Form1.EXEStream(&H3433C3)
        NumericUpDown5.Value = Form1.EXEStream(&H3433C4)
        NumericUpDown6.Value = Form1.EXEStream(&H3433C5)
        NumericUpDown7.Value = Form1.EXEStream(&H3433C6)

        NumericUpDown8.Value = Form1.EXEStream(&H5642D)
        NumericUpDown9.Value = Form1.EXEStream(&H56456)
        NumericUpDown10.Value = Form1.EXEStream(&H5647F)
        NumericUpDown11.Value = Form1.EXEStream(&H564A8)
        NumericUpDown12.Value = Form1.EXEStream(&H564CF)
        ProgramIsChangingStuff = False
    End Sub

    Private Sub NumericUpDown1_ValueChanged(sender As Object, e As EventArgs) Handles NumericUpDown1.ValueChanged
        If ProgramIsChangingStuff = False Then
            Form1.EXEStream(&H3433C0) = NumericUpDown1.Value
        End If
    End Sub

    Private Sub NumericUpDown2_ValueChanged(sender As Object, e As EventArgs) Handles NumericUpDown2.ValueChanged
        If ProgramIsChangingStuff = False Then
            Form1.EXEStream(&H3433C1) = NumericUpDown2.Value
        End If
    End Sub

    Private Sub NumericUpDown3_ValueChanged(sender As Object, e As EventArgs) Handles NumericUpDown3.ValueChanged
        If ProgramIsChangingStuff = False Then
            Form1.EXEStream(&H3433C2) = NumericUpDown3.Value
        End If
    End Sub

    Private Sub NumericUpDown4_ValueChanged(sender As Object, e As EventArgs) Handles NumericUpDown4.ValueChanged
        If ProgramIsChangingStuff = False Then
            Form1.EXEStream(&H3433C3) = NumericUpDown4.Value
        End If
    End Sub

    Private Sub NumericUpDown5_ValueChanged(sender As Object, e As EventArgs) Handles NumericUpDown5.ValueChanged
        If ProgramIsChangingStuff = False Then
            Form1.EXEStream(&H3433C4) = NumericUpDown5.Value
        End If
    End Sub

    Private Sub NumericUpDown6_ValueChanged(sender As Object, e As EventArgs) Handles NumericUpDown6.ValueChanged
        If ProgramIsChangingStuff = False Then
            Form1.EXEStream(&H3433C5) = NumericUpDown6.Value
        End If
    End Sub

    Private Sub NumericUpDown7_ValueChanged(sender As Object, e As EventArgs) Handles NumericUpDown7.ValueChanged
        If ProgramIsChangingStuff = False Then
            Form1.EXEStream(&H3433C6) = NumericUpDown7.Value
        End If
    End Sub

    Private Sub NumericUpDown8_ValueChanged(sender As Object, e As EventArgs) Handles NumericUpDown8.ValueChanged
        If ProgramIsChangingStuff = False Then
            Form1.EXEStream(&H5642D) = NumericUpDown8.Value
        End If
    End Sub

    Private Sub NumericUpDown9_ValueChanged(sender As Object, e As EventArgs) Handles NumericUpDown9.ValueChanged
        If ProgramIsChangingStuff = False Then
            Form1.EXEStream(&H56456) = NumericUpDown9.Value
        End If
    End Sub

    Private Sub NumericUpDown10_ValueChanged(sender As Object, e As EventArgs) Handles NumericUpDown10.ValueChanged
        If ProgramIsChangingStuff = False Then
            Form1.EXEStream(&H5647F) = NumericUpDown10.Value
        End If
    End Sub

    Private Sub NumericUpDown11_ValueChanged(sender As Object, e As EventArgs) Handles NumericUpDown11.ValueChanged
        If ProgramIsChangingStuff = False Then
            Form1.EXEStream(&H564A8) = NumericUpDown11.Value
        End If
    End Sub

    Private Sub NumericUpDown12_ValueChanged(sender As Object, e As EventArgs) Handles NumericUpDown12.ValueChanged
        If ProgramIsChangingStuff = False Then
            Form1.EXEStream(&H564CF) = NumericUpDown12.Value
        End If
    End Sub
End Class