Class StartEndEditor
    Dim ProgramIsChangingStuff As Boolean = False
    Dim CurrentStartOffset As Integer = -1
    Dim CurrentEndOffset As Integer = -1
    Dim CurrentMultiOffset As Integer = -1
    Dim CurrentBragOffset As Integer = -1

    Private Sub Form1PStartEditor_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        SingleTSonicX.Maximum = Decimal.MaxValue
        SingleTSonicY.Maximum = Decimal.MaxValue
        SingleTSonicZ.Maximum = Decimal.MaxValue
        SingleTSonicX.Minimum = Decimal.MinValue
        SingleTSonicY.Minimum = Decimal.MinValue
        SingleTSonicZ.Minimum = Decimal.MinValue

        SingleTDarkX.Maximum = Decimal.MaxValue
        SingleTDarkY.Maximum = Decimal.MaxValue
        SingleTDarkZ.Maximum = Decimal.MaxValue
        SingleTDarkX.Minimum = Decimal.MinValue
        SingleTDarkY.Minimum = Decimal.MinValue
        SingleTDarkZ.Minimum = Decimal.MinValue

        SingleTRoseX.Maximum = Decimal.MaxValue
        SingleTRoseY.Maximum = Decimal.MaxValue
        SingleTRoseZ.Maximum = Decimal.MaxValue
        SingleTRoseX.Minimum = Decimal.MinValue
        SingleTRoseY.Minimum = Decimal.MinValue
        SingleTRoseZ.Minimum = Decimal.MinValue

        SingleTChaotixX.Maximum = Decimal.MaxValue
        SingleTChaotixY.Maximum = Decimal.MaxValue
        SingleTChaotixZ.Maximum = Decimal.MaxValue
        SingleTChaotixX.Minimum = Decimal.MinValue
        SingleTChaotixY.Minimum = Decimal.MinValue
        SingleTChaotixZ.Minimum = Decimal.MinValue

        SingleTSuperX.Maximum = Decimal.MaxValue
        SingleTSuperY.Maximum = Decimal.MaxValue
        SingleTSuperZ.Maximum = Decimal.MaxValue
        SingleTSuperX.Minimum = Decimal.MinValue
        SingleTSuperY.Minimum = Decimal.MinValue
        SingleTSuperZ.Minimum = Decimal.MinValue

        EndingTSonicX.Maximum = Decimal.MaxValue
        EndingTSonicY.Maximum = Decimal.MaxValue
        EndingTSonicZ.Maximum = Decimal.MaxValue
        EndingTSonicX.Minimum = Decimal.MinValue
        EndingTSonicY.Minimum = Decimal.MinValue
        EndingTSonicZ.Minimum = Decimal.MinValue

        EndingTDarkX.Maximum = Decimal.MaxValue
        EndingTDarkY.Maximum = Decimal.MaxValue
        EndingTDarkZ.Maximum = Decimal.MaxValue
        EndingTDarkX.Minimum = Decimal.MinValue
        EndingTDarkY.Minimum = Decimal.MinValue
        EndingTDarkZ.Minimum = Decimal.MinValue

        EndingTRoseX.Maximum = Decimal.MaxValue
        EndingTRoseY.Maximum = Decimal.MaxValue
        EndingTRoseZ.Maximum = Decimal.MaxValue
        EndingTRoseX.Minimum = Decimal.MinValue
        EndingTRoseY.Minimum = Decimal.MinValue
        EndingTRoseZ.Minimum = Decimal.MinValue

        EndingTChaotixX.Maximum = Decimal.MaxValue
        EndingTChaotixY.Maximum = Decimal.MaxValue
        EndingTChaotixZ.Maximum = Decimal.MaxValue
        EndingTChaotixX.Minimum = Decimal.MinValue
        EndingTChaotixY.Minimum = Decimal.MinValue
        EndingTChaotixZ.Minimum = Decimal.MinValue

        EndingTSuperX.Maximum = Decimal.MaxValue
        EndingTSuperY.Maximum = Decimal.MaxValue
        EndingTSuperZ.Maximum = Decimal.MaxValue
        EndingTSuperX.Minimum = Decimal.MinValue
        EndingTSuperY.Minimum = Decimal.MinValue
        EndingTSuperZ.Minimum = Decimal.MinValue

        MultiP1X.Maximum = Decimal.MaxValue
        MultiP1Y.Maximum = Decimal.MaxValue
        MultiP1Z.Maximum = Decimal.MaxValue
        MultiP1X.Minimum = Decimal.MinValue
        MultiP1Y.Minimum = Decimal.MinValue
        MultiP1Z.Minimum = Decimal.MinValue

        MultiP2X.Maximum = Decimal.MaxValue
        MultiP2Y.Maximum = Decimal.MaxValue
        MultiP2Z.Maximum = Decimal.MaxValue
        MultiP2X.Minimum = Decimal.MinValue
        MultiP2Y.Minimum = Decimal.MinValue
        MultiP2Z.Minimum = Decimal.MinValue

        BragTSonicX.Maximum = Decimal.MaxValue
        BragTSonicY.Maximum = Decimal.MaxValue
        BragTSonicZ.Maximum = Decimal.MaxValue
        BragTSonicX.Minimum = Decimal.MinValue
        BragTSonicY.Minimum = Decimal.MinValue
        BragTSonicZ.Minimum = Decimal.MinValue

        BragTDarkX.Maximum = Decimal.MaxValue
        BragTDarkY.Maximum = Decimal.MaxValue
        BragTDarkZ.Maximum = Decimal.MaxValue
        BragTDarkX.Minimum = Decimal.MinValue
        BragTDarkY.Minimum = Decimal.MinValue
        BragTDarkZ.Minimum = Decimal.MinValue

        BragTRoseX.Maximum = Decimal.MaxValue
        BragTRoseY.Maximum = Decimal.MaxValue
        BragTRoseZ.Maximum = Decimal.MaxValue
        BragTRoseX.Minimum = Decimal.MinValue
        BragTRoseY.Minimum = Decimal.MinValue
        BragTRoseZ.Minimum = Decimal.MinValue

        BragTChaotixX.Maximum = Decimal.MaxValue
        BragTChaotixY.Maximum = Decimal.MaxValue
        BragTChaotixZ.Maximum = Decimal.MaxValue
        BragTChaotixX.Minimum = Decimal.MinValue
        BragTChaotixY.Minimum = Decimal.MinValue
        BragTChaotixZ.Minimum = Decimal.MinValue

        BragTSuperX.Maximum = Decimal.MaxValue
        BragTSuperY.Maximum = Decimal.MaxValue
        BragTSuperZ.Maximum = Decimal.MaxValue
        BragTSuperX.Minimum = Decimal.MinValue
        BragTSuperY.Minimum = Decimal.MinValue
        BragTSuperZ.Minimum = Decimal.MinValue
    End Sub

    Private Sub ComboBoxLevel1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBoxLevel1.SelectedIndexChanged
        GroupBox1.Enabled = True
        GroupBox3.Enabled = True
        GroupBox5.Enabled = True
        GroupBox7.Enabled = True
        GroupBox9.Enabled = True

        CurrentStartOffset = &H3C2FC8 + ComboBoxLevel1.SelectedIndex * &H90
        PopulateAllBoxes1(CurrentStartOffset)
    End Sub

    Private Sub ComboBoxLevel2_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBoxLevel2.SelectedIndexChanged
        GroupBox15.Enabled = True
        GroupBox27.Enabled = True
        GroupBox29.Enabled = True
        GroupBox31.Enabled = True
        GroupBox33.Enabled = True

        CurrentEndOffset = &H3C45B8 + ComboBoxLevel2.SelectedIndex * &H68
        PopulateAllBoxes2(CurrentEndOffset)
    End Sub

    Private Sub ComboBoxLevel3_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBoxLevel3.SelectedIndexChanged
        GroupBox11.Enabled = True
        GroupBox13.Enabled = True

        CurrentMultiOffset = &H3C5E18 + ComboBoxLevel3.SelectedIndex * &H3C
        PopulateAllBoxes3(CurrentMultiOffset)
    End Sub

    Private Sub ComboBoxLevel4_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBoxLevel4.SelectedIndexChanged
        GroupBox17.Enabled = True
        GroupBox19.Enabled = True
        GroupBox21.Enabled = True
        GroupBox23.Enabled = True
        GroupBox25.Enabled = True

        CurrentBragOffset = &H3C6380 + ComboBoxLevel4.SelectedIndex * &H54
        PopulateAllBoxes4(CurrentBragOffset)
    End Sub

    Sub PopulateAllBoxes1(Level As Integer)
        ProgramIsChangingStuff = True

        SingleTSonicX.Value = BitConverter.ToSingle(Form1.EXEStream, Level + &H4)
        SingleTSonicY.Value = BitConverter.ToSingle(Form1.EXEStream, Level + &H8)
        SingleTSonicZ.Value = BitConverter.ToSingle(Form1.EXEStream, Level + &HC)
        SingleTSonicAngle.Value = Convert.ToSingle(BitConverter.ToUInt16(Form1.EXEStream, Level + &H10)) * 360.0 / 65536.0
        SingleTSonicMode.SelectedIndex = Form1.EXEStream(Level + &H18)
        SingleTSonicHold.Value = BitConverter.ToUInt16(Form1.EXEStream, Level + &H1C)

        SingleTDarkX.Value = BitConverter.ToSingle(Form1.EXEStream, Level + &H4 + &H1C)
        SingleTDarkY.Value = BitConverter.ToSingle(Form1.EXEStream, Level + &H8 + &H1C)
        SingleTDarkZ.Value = BitConverter.ToSingle(Form1.EXEStream, Level + &HC + &H1C)
        SingleTDarkAngle.Value = Convert.ToSingle(BitConverter.ToUInt16(Form1.EXEStream, Level + &H10 + &H1C)) * 360.0 / 65536.0
        SingleTDarkMode.SelectedIndex = Form1.EXEStream(Level + &H18 + &H1C)
        SingleTDarkHold.Value = BitConverter.ToUInt16(Form1.EXEStream, Level + &H1C + &H1C)

        SingleTRoseX.Value = BitConverter.ToSingle(Form1.EXEStream, Level + &H4 + &H38)
        SingleTRoseY.Value = BitConverter.ToSingle(Form1.EXEStream, Level + &H8 + &H38)
        SingleTRoseZ.Value = BitConverter.ToSingle(Form1.EXEStream, Level + &HC + &H38)
        SingleTRoseAngle.Value = Convert.ToSingle(BitConverter.ToUInt16(Form1.EXEStream, Level + &H10 + &H38)) * 360.0 / 65536.0
        SingleTRoseMode.SelectedIndex = Form1.EXEStream(Level + &H18 + &H38)
        SingleTRoseHold.Value = BitConverter.ToUInt16(Form1.EXEStream, Level + &H1C + &H38)

        SingleTChaotixX.Value = BitConverter.ToSingle(Form1.EXEStream, Level + &H4 + &H54)
        SingleTChaotixY.Value = BitConverter.ToSingle(Form1.EXEStream, Level + &H8 + &H54)
        SingleTChaotixZ.Value = BitConverter.ToSingle(Form1.EXEStream, Level + &HC + &H54)
        SingleTChaotixAngle.Value = Convert.ToSingle(BitConverter.ToUInt16(Form1.EXEStream, Level + &H10 + &H54)) * 360.0 / 65536.0
        SingleTChaotixMode.SelectedIndex = Form1.EXEStream(Level + &H18 + &H54)
        SingleTChaotixHold.Value = BitConverter.ToUInt16(Form1.EXEStream, Level + &H1C + &H54)

        SingleTSuperX.Value = BitConverter.ToSingle(Form1.EXEStream, Level + &H4 + &H70)
        SingleTSuperY.Value = BitConverter.ToSingle(Form1.EXEStream, Level + &H8 + &H70)
        SingleTSuperZ.Value = BitConverter.ToSingle(Form1.EXEStream, Level + &HC + &H70)
        SingleTSuperAngle.Value = Convert.ToSingle(BitConverter.ToUInt16(Form1.EXEStream, Level + &H10 + &H70)) * 360.0 / 65536.0
        SingleTSuperMode.SelectedIndex = Form1.EXEStream(Level + &H18 + &H70)
        SingleTSuperHold.Value = BitConverter.ToUInt16(Form1.EXEStream, Level + &H1C + &H70)

        ProgramIsChangingStuff = False
    End Sub

    Sub PopulateAllBoxes2(Level As Integer)
        ProgramIsChangingStuff = True

        EndingTSonicX.Value = BitConverter.ToSingle(Form1.EXEStream, Level + &H4)
        EndingTSonicY.Value = BitConverter.ToSingle(Form1.EXEStream, Level + &H8)
        EndingTSonicZ.Value = BitConverter.ToSingle(Form1.EXEStream, Level + &HC)
        EndingTSonicAngle.Value = Convert.ToSingle(BitConverter.ToUInt16(Form1.EXEStream, Level + &H10)) * 360.0 / 65536.0

        EndingTDarkX.Value = BitConverter.ToSingle(Form1.EXEStream, Level + &H4 + &H14)
        EndingTDarkY.Value = BitConverter.ToSingle(Form1.EXEStream, Level + &H8 + &H14)
        EndingTDarkZ.Value = BitConverter.ToSingle(Form1.EXEStream, Level + &HC + &H14)
        EndingTDarkAngle.Value = Convert.ToSingle(BitConverter.ToUInt16(Form1.EXEStream, Level + &H10 + &H14)) * 360.0 / 65536.0

        EndingTRoseX.Value = BitConverter.ToSingle(Form1.EXEStream, Level + &H4 + &H28)
        EndingTRoseY.Value = BitConverter.ToSingle(Form1.EXEStream, Level + &H8 + &H28)
        EndingTRoseZ.Value = BitConverter.ToSingle(Form1.EXEStream, Level + &HC + &H28)
        EndingTRoseAngle.Value = Convert.ToSingle(BitConverter.ToUInt16(Form1.EXEStream, Level + &H10 + &H28)) * 360.0 / 65536.0

        EndingTChaotixX.Value = BitConverter.ToSingle(Form1.EXEStream, Level + &H4 + &H3C)
        EndingTChaotixY.Value = BitConverter.ToSingle(Form1.EXEStream, Level + &H8 + &H3C)
        EndingTChaotixZ.Value = BitConverter.ToSingle(Form1.EXEStream, Level + &HC + &H3C)
        EndingTChaotixAngle.Value = Convert.ToSingle(BitConverter.ToUInt16(Form1.EXEStream, Level + &H10 + &H3C)) * 360.0 / 65536.0

        EndingTSuperX.Value = BitConverter.ToSingle(Form1.EXEStream, Level + &H4 + &H50)
        EndingTSuperY.Value = BitConverter.ToSingle(Form1.EXEStream, Level + &H8 + &H50)
        EndingTSuperZ.Value = BitConverter.ToSingle(Form1.EXEStream, Level + &HC + &H50)
        EndingTSuperAngle.Value = Convert.ToSingle(BitConverter.ToUInt16(Form1.EXEStream, Level + &H10 + &H50)) * 360.0 / 65536.0

        ProgramIsChangingStuff = False
    End Sub

    Sub PopulateAllBoxes3(Level As Integer)
        ProgramIsChangingStuff = True

        MultiP1X.Value = BitConverter.ToSingle(Form1.EXEStream, Level + &H4)
        MultiP1Y.Value = BitConverter.ToSingle(Form1.EXEStream, Level + &H8)
        MultiP1Z.Value = BitConverter.ToSingle(Form1.EXEStream, Level + &HC)
        MultiP1Angle.Value = Convert.ToSingle(BitConverter.ToUInt16(Form1.EXEStream, Level + &H10)) * 360.0 / 65536.0
        MultiP1Mode.SelectedIndex = Form1.EXEStream(Level + &H18)
        MultiP1Hold.Value = BitConverter.ToUInt16(Form1.EXEStream, Level + &H1C)

        MultiP2X.Value = BitConverter.ToSingle(Form1.EXEStream, Level + &H4 + &H1C)
        MultiP2Y.Value = BitConverter.ToSingle(Form1.EXEStream, Level + &H8 + &H1C)
        MultiP2Z.Value = BitConverter.ToSingle(Form1.EXEStream, Level + &HC + &H1C)
        MultiP2Angle.Value = Convert.ToSingle(BitConverter.ToUInt16(Form1.EXEStream, Level + &H10 + &H1C)) * 360.0 / 65536.0
        MultiP2Mode.SelectedIndex = Form1.EXEStream(Level + &H18 + &H1C)
        MultiP2Hold.Value = BitConverter.ToUInt16(Form1.EXEStream, Level + &H1C + &H1C)

        ProgramIsChangingStuff = False
    End Sub

    Sub PopulateAllBoxes4(Level As Integer)
        ProgramIsChangingStuff = True

        BragTSonicX.Value = BitConverter.ToSingle(Form1.EXEStream, Level + &H4)
        BragTSonicY.Value = BitConverter.ToSingle(Form1.EXEStream, Level + &H8)
        BragTSonicZ.Value = BitConverter.ToSingle(Form1.EXEStream, Level + &HC)
        BragTSonicAngle.Value = Convert.ToSingle(BitConverter.ToUInt16(Form1.EXEStream, Level + &H10)) * 360.0 / 65536.0

        BragTDarkX.Value = BitConverter.ToSingle(Form1.EXEStream, Level + &H4 + &H10)
        BragTDarkY.Value = BitConverter.ToSingle(Form1.EXEStream, Level + &H8 + &H10)
        BragTDarkZ.Value = BitConverter.ToSingle(Form1.EXEStream, Level + &HC + &H10)
        BragTDarkAngle.Value = Convert.ToSingle(BitConverter.ToUInt16(Form1.EXEStream, Level + &H10 + &H10)) * 360.0 / 65536.0

        BragTRoseX.Value = BitConverter.ToSingle(Form1.EXEStream, Level + &H4 + &H20)
        BragTRoseY.Value = BitConverter.ToSingle(Form1.EXEStream, Level + &H8 + &H20)
        BragTRoseZ.Value = BitConverter.ToSingle(Form1.EXEStream, Level + &HC + &H20)
        BragTRoseAngle.Value = Convert.ToSingle(BitConverter.ToUInt16(Form1.EXEStream, Level + &H10 + &H20)) * 360.0 / 65536.0

        BragTChaotixX.Value = BitConverter.ToSingle(Form1.EXEStream, Level + &H4 + &H30)
        BragTChaotixY.Value = BitConverter.ToSingle(Form1.EXEStream, Level + &H8 + &H30)
        BragTChaotixZ.Value = BitConverter.ToSingle(Form1.EXEStream, Level + &HC + &H30)
        BragTChaotixAngle.Value = Convert.ToSingle(BitConverter.ToUInt16(Form1.EXEStream, Level + &H10 + &H30)) * 360.0 / 65536.0

        BragTSuperX.Value = BitConverter.ToSingle(Form1.EXEStream, Level + &H4 + &H40)
        BragTSuperY.Value = BitConverter.ToSingle(Form1.EXEStream, Level + &H8 + &H40)
        BragTSuperZ.Value = BitConverter.ToSingle(Form1.EXEStream, Level + &HC + &H40)
        BragTSuperAngle.Value = Convert.ToSingle(BitConverter.ToUInt16(Form1.EXEStream, Level + &H10 + &H40)) * 360.0 / 65536.0

        ProgramIsChangingStuff = False
    End Sub

    Private Sub SingleTSonicX_ValueChanged(sender As Object, e As EventArgs) Handles SingleTSonicX.ValueChanged
        If ProgramIsChangingStuff = False Then
            Form1.EXEStream(CurrentStartOffset + &H4) = BitConverter.GetBytes(SingleTSonicX.Value)(0)
            Form1.EXEStream(CurrentStartOffset + &H5) = BitConverter.GetBytes(SingleTSonicX.Value)(1)
            Form1.EXEStream(CurrentStartOffset + &H6) = BitConverter.GetBytes(SingleTSonicX.Value)(2)
            Form1.EXEStream(CurrentStartOffset + &H7) = BitConverter.GetBytes(SingleTSonicX.Value)(3)
        End If
    End Sub

    Private Sub SingleTSonicY_ValueChanged(sender As Object, e As EventArgs) Handles SingleTSonicY.ValueChanged
        If ProgramIsChangingStuff = False Then
            Form1.EXEStream(CurrentStartOffset + &H8) = BitConverter.GetBytes(SingleTSonicY.Value)(0)
            Form1.EXEStream(CurrentStartOffset + &H9) = BitConverter.GetBytes(SingleTSonicY.Value)(1)
            Form1.EXEStream(CurrentStartOffset + &HA) = BitConverter.GetBytes(SingleTSonicY.Value)(2)
            Form1.EXEStream(CurrentStartOffset + &HB) = BitConverter.GetBytes(SingleTSonicY.Value)(3)
        End If
    End Sub

    Private Sub SingleTSonicZ_ValueChanged(sender As Object, e As EventArgs) Handles SingleTSonicZ.ValueChanged
        If ProgramIsChangingStuff = False Then
            Form1.EXEStream(CurrentStartOffset + &HC) = BitConverter.GetBytes(SingleTSonicZ.Value)(0)
            Form1.EXEStream(CurrentStartOffset + &HD) = BitConverter.GetBytes(SingleTSonicZ.Value)(1)
            Form1.EXEStream(CurrentStartOffset + &HE) = BitConverter.GetBytes(SingleTSonicZ.Value)(2)
            Form1.EXEStream(CurrentStartOffset + &HF) = BitConverter.GetBytes(SingleTSonicZ.Value)(3)
        End If
    End Sub

    Private Sub SingleTSonicAngle_ValueChanged(sender As Object, e As EventArgs) Handles SingleTSonicAngle.ValueChanged
        If ProgramIsChangingStuff = False Then
            Dim AngleAsUInt16 As UInt16 = SingleTSonicAngle.Value * 65536.0 / 360.0

            Form1.EXEStream(CurrentStartOffset + &H10) = BitConverter.GetBytes(AngleAsUInt16)(0)
            Form1.EXEStream(CurrentStartOffset + &H11) = BitConverter.GetBytes(AngleAsUInt16)(1)
            Form1.EXEStream(CurrentStartOffset + &H12) = 0
            Form1.EXEStream(CurrentStartOffset + &H13) = 0
        End If
    End Sub

    Private Sub SingleTSonicMode_SelectedIndexChanged(sender As Object, e As EventArgs) Handles SingleTSonicMode.SelectedIndexChanged
        If ProgramIsChangingStuff = False Then
            Form1.EXEStream(CurrentStartOffset + &H18) = SingleTSonicMode.SelectedIndex
            Form1.EXEStream(CurrentStartOffset + &H19) = 0
            Form1.EXEStream(CurrentStartOffset + &H1A) = 0
            Form1.EXEStream(CurrentStartOffset + &H1B) = 0
        End If
    End Sub

    Private Sub SingleTSonicHold_ValueChanged(sender As Object, e As EventArgs) Handles SingleTSonicHold.ValueChanged
        If ProgramIsChangingStuff = False Then
            Dim Value As UInt16 = SingleTSonicHold.Value

            Form1.EXEStream(CurrentStartOffset + &H1C) = BitConverter.GetBytes(Value)(0)
            Form1.EXEStream(CurrentStartOffset + &H1D) = BitConverter.GetBytes(Value)(1)
            Form1.EXEStream(CurrentStartOffset + &H1E) = 0
            Form1.EXEStream(CurrentStartOffset + &H1F) = 0
        End If
    End Sub

    Private Sub SingleTDarkX_ValueChanged(sender As Object, e As EventArgs) Handles SingleTDarkX.ValueChanged
        If ProgramIsChangingStuff = False Then
            Form1.EXEStream(CurrentStartOffset + &H4 + &H1C) = BitConverter.GetBytes(SingleTDarkX.Value)(0)
            Form1.EXEStream(CurrentStartOffset + &H5 + &H1C) = BitConverter.GetBytes(SingleTDarkX.Value)(1)
            Form1.EXEStream(CurrentStartOffset + &H6 + &H1C) = BitConverter.GetBytes(SingleTDarkX.Value)(2)
            Form1.EXEStream(CurrentStartOffset + &H7 + &H1C) = BitConverter.GetBytes(SingleTDarkX.Value)(3)
        End If
    End Sub

    Private Sub SingleTDarkY_ValueChanged(sender As Object, e As EventArgs) Handles SingleTDarkY.ValueChanged
        If ProgramIsChangingStuff = False Then
            Form1.EXEStream(CurrentStartOffset + &H8 + &H1C) = BitConverter.GetBytes(SingleTDarkY.Value)(0)
            Form1.EXEStream(CurrentStartOffset + &H9 + &H1C) = BitConverter.GetBytes(SingleTDarkY.Value)(1)
            Form1.EXEStream(CurrentStartOffset + &HA + &H1C) = BitConverter.GetBytes(SingleTDarkY.Value)(2)
            Form1.EXEStream(CurrentStartOffset + &HB + &H1C) = BitConverter.GetBytes(SingleTDarkY.Value)(3)
        End If
    End Sub

    Private Sub SingleTDarkZ_ValueChanged(sender As Object, e As EventArgs) Handles SingleTDarkZ.ValueChanged
        If ProgramIsChangingStuff = False Then
            Form1.EXEStream(CurrentStartOffset + &HC + &H1C) = BitConverter.GetBytes(SingleTDarkZ.Value)(0)
            Form1.EXEStream(CurrentStartOffset + &HD + &H1C) = BitConverter.GetBytes(SingleTDarkZ.Value)(1)
            Form1.EXEStream(CurrentStartOffset + &HE + &H1C) = BitConverter.GetBytes(SingleTDarkZ.Value)(2)
            Form1.EXEStream(CurrentStartOffset + &HF + &H1C) = BitConverter.GetBytes(SingleTDarkZ.Value)(3)
        End If
    End Sub

    Private Sub SingleTDarkAngle_ValueChanged(sender As Object, e As EventArgs) Handles SingleTDarkAngle.ValueChanged
        If ProgramIsChangingStuff = False Then
            Dim AngleAsUInt16 As UInt16 = SingleTDarkAngle.Value * 65536.0 / 360.0

            Form1.EXEStream(CurrentStartOffset + &H10 + &H1C) = BitConverter.GetBytes(AngleAsUInt16)(0)
            Form1.EXEStream(CurrentStartOffset + &H11 + &H1C) = BitConverter.GetBytes(AngleAsUInt16)(1)
            Form1.EXEStream(CurrentStartOffset + &H12 + &H1C) = 0
            Form1.EXEStream(CurrentStartOffset + &H13 + &H1C) = 0
        End If
    End Sub

    Private Sub SingleTDarkMode_SelectedIndexChanged(sender As Object, e As EventArgs) Handles SingleTDarkMode.SelectedIndexChanged
        If ProgramIsChangingStuff = False Then
            Form1.EXEStream(CurrentStartOffset + &H18 + &H1C) = SingleTDarkMode.SelectedIndex
            Form1.EXEStream(CurrentStartOffset + &H19 + &H1C) = 0
            Form1.EXEStream(CurrentStartOffset + &H1A + &H1C) = 0
            Form1.EXEStream(CurrentStartOffset + &H1B + &H1C) = 0
        End If
    End Sub

    Private Sub SingleTDarkHold_ValueChanged(sender As Object, e As EventArgs) Handles SingleTDarkHold.ValueChanged
        If ProgramIsChangingStuff = False Then
            Dim Value As UInt16 = SingleTDarkHold.Value

            Form1.EXEStream(CurrentStartOffset + &H1C + &H1C) = BitConverter.GetBytes(Value)(0)
            Form1.EXEStream(CurrentStartOffset + &H1D + &H1C) = BitConverter.GetBytes(Value)(1)
            Form1.EXEStream(CurrentStartOffset + &H1E + &H1C) = 0
            Form1.EXEStream(CurrentStartOffset + &H1F + &H1C) = 0
        End If
    End Sub

    Private Sub SingleTRoseX_ValueChanged(sender As Object, e As EventArgs) Handles SingleTRoseX.ValueChanged
        If ProgramIsChangingStuff = False Then
            Form1.EXEStream(CurrentStartOffset + &H4 + &H38) = BitConverter.GetBytes(SingleTRoseX.Value)(0)
            Form1.EXEStream(CurrentStartOffset + &H5 + &H38) = BitConverter.GetBytes(SingleTRoseX.Value)(1)
            Form1.EXEStream(CurrentStartOffset + &H6 + &H38) = BitConverter.GetBytes(SingleTRoseX.Value)(2)
            Form1.EXEStream(CurrentStartOffset + &H7 + &H38) = BitConverter.GetBytes(SingleTRoseX.Value)(3)
        End If
    End Sub

    Private Sub SingleTRoseY_ValueChanged(sender As Object, e As EventArgs) Handles SingleTRoseY.ValueChanged
        If ProgramIsChangingStuff = False Then
            Form1.EXEStream(CurrentStartOffset + &H8 + &H38) = BitConverter.GetBytes(SingleTRoseY.Value)(0)
            Form1.EXEStream(CurrentStartOffset + &H9 + &H38) = BitConverter.GetBytes(SingleTRoseY.Value)(1)
            Form1.EXEStream(CurrentStartOffset + &HA + &H38) = BitConverter.GetBytes(SingleTRoseY.Value)(2)
            Form1.EXEStream(CurrentStartOffset + &HB + &H38) = BitConverter.GetBytes(SingleTRoseY.Value)(3)
        End If
    End Sub

    Private Sub SingleTRoseZ_ValueChanged(sender As Object, e As EventArgs) Handles SingleTRoseZ.ValueChanged
        If ProgramIsChangingStuff = False Then
            Form1.EXEStream(CurrentStartOffset + &HC + &H38) = BitConverter.GetBytes(SingleTRoseZ.Value)(0)
            Form1.EXEStream(CurrentStartOffset + &HD + &H38) = BitConverter.GetBytes(SingleTRoseZ.Value)(1)
            Form1.EXEStream(CurrentStartOffset + &HE + &H38) = BitConverter.GetBytes(SingleTRoseZ.Value)(2)
            Form1.EXEStream(CurrentStartOffset + &HF + &H38) = BitConverter.GetBytes(SingleTRoseZ.Value)(3)
        End If
    End Sub

    Private Sub SingleTRoseAngle_ValueChanged(sender As Object, e As EventArgs) Handles SingleTRoseAngle.ValueChanged
        If ProgramIsChangingStuff = False Then
            Dim AngleAsUInt16 As UInt16 = SingleTRoseAngle.Value * 65536.0 / 360.0

            Form1.EXEStream(CurrentStartOffset + &H10 + &H38) = BitConverter.GetBytes(AngleAsUInt16)(0)
            Form1.EXEStream(CurrentStartOffset + &H11 + &H38) = BitConverter.GetBytes(AngleAsUInt16)(1)
            Form1.EXEStream(CurrentStartOffset + &H12 + &H38) = 0
            Form1.EXEStream(CurrentStartOffset + &H13 + &H38) = 0
        End If
    End Sub

    Private Sub SingleTRoseMode_SelectedIndexChanged(sender As Object, e As EventArgs) Handles SingleTRoseMode.SelectedIndexChanged
        If ProgramIsChangingStuff = False Then
            Form1.EXEStream(CurrentStartOffset + &H18 + &H38) = SingleTRoseMode.SelectedIndex
            Form1.EXEStream(CurrentStartOffset + &H19 + &H38) = 0
            Form1.EXEStream(CurrentStartOffset + &H1A + &H38) = 0
            Form1.EXEStream(CurrentStartOffset + &H1B + &H38) = 0
        End If
    End Sub

    Private Sub SingleTRoseHold_ValueChanged(sender As Object, e As EventArgs) Handles SingleTRoseHold.ValueChanged
        If ProgramIsChangingStuff = False Then
            Dim Value As UInt16 = SingleTRoseHold.Value

            Form1.EXEStream(CurrentStartOffset + &H1C + &H38) = BitConverter.GetBytes(Value)(0)
            Form1.EXEStream(CurrentStartOffset + &H1D + &H38) = BitConverter.GetBytes(Value)(1)
            Form1.EXEStream(CurrentStartOffset + &H1E + &H38) = 0
            Form1.EXEStream(CurrentStartOffset + &H1F + &H38) = 0
        End If
    End Sub

    Private Sub SingleTChaotixX_ValueChanged(sender As Object, e As EventArgs) Handles SingleTChaotixX.ValueChanged
        If ProgramIsChangingStuff = False Then
            Form1.EXEStream(CurrentStartOffset + &H4 + &H54) = BitConverter.GetBytes(SingleTChaotixX.Value)(0)
            Form1.EXEStream(CurrentStartOffset + &H5 + &H54) = BitConverter.GetBytes(SingleTChaotixX.Value)(1)
            Form1.EXEStream(CurrentStartOffset + &H6 + &H54) = BitConverter.GetBytes(SingleTChaotixX.Value)(2)
            Form1.EXEStream(CurrentStartOffset + &H7 + &H54) = BitConverter.GetBytes(SingleTChaotixX.Value)(3)
        End If
    End Sub

    Private Sub SingleTChaotixY_ValueChanged(sender As Object, e As EventArgs) Handles SingleTChaotixY.ValueChanged
        If ProgramIsChangingStuff = False Then
            Form1.EXEStream(CurrentStartOffset + &H8 + &H54) = BitConverter.GetBytes(SingleTChaotixY.Value)(0)
            Form1.EXEStream(CurrentStartOffset + &H9 + &H54) = BitConverter.GetBytes(SingleTChaotixY.Value)(1)
            Form1.EXEStream(CurrentStartOffset + &HA + &H54) = BitConverter.GetBytes(SingleTChaotixY.Value)(2)
            Form1.EXEStream(CurrentStartOffset + &HB + &H54) = BitConverter.GetBytes(SingleTChaotixY.Value)(3)
        End If
    End Sub

    Private Sub SingleTChaotixZ_ValueChanged(sender As Object, e As EventArgs) Handles SingleTChaotixZ.ValueChanged
        If ProgramIsChangingStuff = False Then
            Form1.EXEStream(CurrentStartOffset + &HC + &H54) = BitConverter.GetBytes(SingleTChaotixZ.Value)(0)
            Form1.EXEStream(CurrentStartOffset + &HD + &H54) = BitConverter.GetBytes(SingleTChaotixZ.Value)(1)
            Form1.EXEStream(CurrentStartOffset + &HE + &H54) = BitConverter.GetBytes(SingleTChaotixZ.Value)(2)
            Form1.EXEStream(CurrentStartOffset + &HF + &H54) = BitConverter.GetBytes(SingleTChaotixZ.Value)(3)
        End If
    End Sub

    Private Sub SingleTChaotixAngle_ValueChanged(sender As Object, e As EventArgs) Handles SingleTChaotixAngle.ValueChanged
        If ProgramIsChangingStuff = False Then
            Dim AngleAsUInt16 As UInt16 = SingleTChaotixAngle.Value * 65536.0 / 360.0

            Form1.EXEStream(CurrentStartOffset + &H10 + &H54) = BitConverter.GetBytes(AngleAsUInt16)(0)
            Form1.EXEStream(CurrentStartOffset + &H11 + &H54) = BitConverter.GetBytes(AngleAsUInt16)(1)
            Form1.EXEStream(CurrentStartOffset + &H12 + &H54) = 0
            Form1.EXEStream(CurrentStartOffset + &H13 + &H54) = 0
        End If
    End Sub

    Private Sub SingleTChaotixMode_SelectedIndexChanged(sender As Object, e As EventArgs) Handles SingleTChaotixMode.SelectedIndexChanged
        If ProgramIsChangingStuff = False Then
            Form1.EXEStream(CurrentStartOffset + &H18 + &H54) = SingleTChaotixMode.SelectedIndex
            Form1.EXEStream(CurrentStartOffset + &H19 + &H54) = 0
            Form1.EXEStream(CurrentStartOffset + &H1A + &H54) = 0
            Form1.EXEStream(CurrentStartOffset + &H1B + &H54) = 0
        End If
    End Sub

    Private Sub SingleTChaotixHold_ValueChanged(sender As Object, e As EventArgs) Handles SingleTChaotixHold.ValueChanged
        If ProgramIsChangingStuff = False Then
            Dim Value As UInt16 = SingleTChaotixHold.Value

            Form1.EXEStream(CurrentStartOffset + &H1C + &H54) = BitConverter.GetBytes(Value)(0)
            Form1.EXEStream(CurrentStartOffset + &H1D + &H54) = BitConverter.GetBytes(Value)(1)
            Form1.EXEStream(CurrentStartOffset + &H1E + &H54) = 0
            Form1.EXEStream(CurrentStartOffset + &H1F + &H54) = 0
        End If
    End Sub

    Private Sub SingleTSuperX_ValueChanged(sender As Object, e As EventArgs) Handles SingleTSuperX.ValueChanged
        If ProgramIsChangingStuff = False Then
            Form1.EXEStream(CurrentStartOffset + &H4 + &H70) = BitConverter.GetBytes(SingleTSuperX.Value)(0)
            Form1.EXEStream(CurrentStartOffset + &H5 + &H70) = BitConverter.GetBytes(SingleTSuperX.Value)(1)
            Form1.EXEStream(CurrentStartOffset + &H6 + &H70) = BitConverter.GetBytes(SingleTSuperX.Value)(2)
            Form1.EXEStream(CurrentStartOffset + &H7 + &H70) = BitConverter.GetBytes(SingleTSuperX.Value)(3)
        End If
    End Sub

    Private Sub SingleTSuperY_ValueChanged(sender As Object, e As EventArgs) Handles SingleTSuperY.ValueChanged
        If ProgramIsChangingStuff = False Then
            Form1.EXEStream(CurrentStartOffset + &H8 + &H70) = BitConverter.GetBytes(SingleTSuperY.Value)(0)
            Form1.EXEStream(CurrentStartOffset + &H9 + &H70) = BitConverter.GetBytes(SingleTSuperY.Value)(1)
            Form1.EXEStream(CurrentStartOffset + &HA + &H70) = BitConverter.GetBytes(SingleTSuperY.Value)(2)
            Form1.EXEStream(CurrentStartOffset + &HB + &H70) = BitConverter.GetBytes(SingleTSuperY.Value)(3)
        End If
    End Sub

    Private Sub SingleTSuperZ_ValueChanged(sender As Object, e As EventArgs) Handles SingleTSuperZ.ValueChanged
        If ProgramIsChangingStuff = False Then
            Form1.EXEStream(CurrentStartOffset + &HC + &H70) = BitConverter.GetBytes(SingleTSuperZ.Value)(0)
            Form1.EXEStream(CurrentStartOffset + &HD + &H70) = BitConverter.GetBytes(SingleTSuperZ.Value)(1)
            Form1.EXEStream(CurrentStartOffset + &HE + &H70) = BitConverter.GetBytes(SingleTSuperZ.Value)(2)
            Form1.EXEStream(CurrentStartOffset + &HF + &H70) = BitConverter.GetBytes(SingleTSuperZ.Value)(3)
        End If
    End Sub

    Private Sub SingleTSuperAngle_ValueChanged(sender As Object, e As EventArgs) Handles SingleTSuperAngle.ValueChanged
        If ProgramIsChangingStuff = False Then
            Dim AngleAsUInt16 As UInt16 = SingleTSuperAngle.Value * 65536.0 / 360.0

            Form1.EXEStream(CurrentStartOffset + &H10 + &H70) = BitConverter.GetBytes(AngleAsUInt16)(0)
            Form1.EXEStream(CurrentStartOffset + &H11 + &H70) = BitConverter.GetBytes(AngleAsUInt16)(1)
            Form1.EXEStream(CurrentStartOffset + &H12 + &H70) = 0
            Form1.EXEStream(CurrentStartOffset + &H13 + &H70) = 0
        End If
    End Sub

    Private Sub SingleTSuperMode_SelectedIndexChanged(sender As Object, e As EventArgs) Handles SingleTSuperMode.SelectedIndexChanged
        If ProgramIsChangingStuff = False Then
            Form1.EXEStream(CurrentStartOffset + &H18 + &H70) = SingleTSuperMode.SelectedIndex
            Form1.EXEStream(CurrentStartOffset + &H19 + &H70) = 0
            Form1.EXEStream(CurrentStartOffset + &H1A + &H70) = 0
            Form1.EXEStream(CurrentStartOffset + &H1B + &H70) = 0
        End If
    End Sub

    Private Sub SingleTSuperHold_ValueChanged(sender As Object, e As EventArgs) Handles SingleTSuperHold.ValueChanged
        If ProgramIsChangingStuff = False Then
            Dim Value As UInt16 = SingleTSuperHold.Value

            Form1.EXEStream(CurrentStartOffset + &H1C + &H70) = BitConverter.GetBytes(Value)(0)
            Form1.EXEStream(CurrentStartOffset + &H1D + &H70) = BitConverter.GetBytes(Value)(1)
            Form1.EXEStream(CurrentStartOffset + &H1E + &H70) = 0
            Form1.EXEStream(CurrentStartOffset + &H1F + &H70) = 0
        End If
    End Sub

    Private Sub EndingTSonicX_ValueChanged(sender As Object, e As EventArgs) Handles EndingTSonicX.ValueChanged
        If ProgramIsChangingStuff = False Then
            Form1.EXEStream(CurrentEndOffset + &H4) = BitConverter.GetBytes(EndingTSonicX.Value)(0)
            Form1.EXEStream(CurrentEndOffset + &H5) = BitConverter.GetBytes(EndingTSonicX.Value)(1)
            Form1.EXEStream(CurrentEndOffset + &H6) = BitConverter.GetBytes(EndingTSonicX.Value)(2)
            Form1.EXEStream(CurrentEndOffset + &H7) = BitConverter.GetBytes(EndingTSonicX.Value)(3)
        End If
    End Sub

    Private Sub EndingTSonicY_ValueChanged(sender As Object, e As EventArgs) Handles EndingTSonicY.ValueChanged
        If ProgramIsChangingStuff = False Then
            Form1.EXEStream(CurrentEndOffset + &H8) = BitConverter.GetBytes(EndingTSonicY.Value)(0)
            Form1.EXEStream(CurrentEndOffset + &H9) = BitConverter.GetBytes(EndingTSonicY.Value)(1)
            Form1.EXEStream(CurrentEndOffset + &HA) = BitConverter.GetBytes(EndingTSonicY.Value)(2)
            Form1.EXEStream(CurrentEndOffset + &HB) = BitConverter.GetBytes(EndingTSonicY.Value)(3)
        End If
    End Sub

    Private Sub EndingTSonicZ_ValueChanged(sender As Object, e As EventArgs) Handles EndingTSonicZ.ValueChanged
        If ProgramIsChangingStuff = False Then
            Form1.EXEStream(CurrentEndOffset + &HC) = BitConverter.GetBytes(EndingTSonicZ.Value)(0)
            Form1.EXEStream(CurrentEndOffset + &HD) = BitConverter.GetBytes(EndingTSonicZ.Value)(1)
            Form1.EXEStream(CurrentEndOffset + &HE) = BitConverter.GetBytes(EndingTSonicZ.Value)(2)
            Form1.EXEStream(CurrentEndOffset + &HF) = BitConverter.GetBytes(EndingTSonicZ.Value)(3)
        End If
    End Sub

    Private Sub EndingTSonicAngle_ValueChanged(sender As Object, e As EventArgs) Handles EndingTSonicAngle.ValueChanged
        If ProgramIsChangingStuff = False Then
            Dim AngleAsUInt16 As UInt16 = EndingTSonicAngle.Value * 65536.0 / 360.0

            Form1.EXEStream(CurrentEndOffset + &H10) = BitConverter.GetBytes(AngleAsUInt16)(0)
            Form1.EXEStream(CurrentEndOffset + &H11) = BitConverter.GetBytes(AngleAsUInt16)(1)
            Form1.EXEStream(CurrentEndOffset + &H12) = 0
            Form1.EXEStream(CurrentEndOffset + &H13) = 0
        End If
    End Sub

    Private Sub EndingTDarkX_ValueChanged(sender As Object, e As EventArgs) Handles EndingTDarkX.ValueChanged
        If ProgramIsChangingStuff = False Then
            Form1.EXEStream(CurrentEndOffset + &H4 + &H14) = BitConverter.GetBytes(EndingTDarkX.Value)(0)
            Form1.EXEStream(CurrentEndOffset + &H5 + &H14) = BitConverter.GetBytes(EndingTDarkX.Value)(1)
            Form1.EXEStream(CurrentEndOffset + &H6 + &H14) = BitConverter.GetBytes(EndingTDarkX.Value)(2)
            Form1.EXEStream(CurrentEndOffset + &H7 + &H14) = BitConverter.GetBytes(EndingTDarkX.Value)(3)
        End If
    End Sub

    Private Sub EndingTDarkY_ValueChanged(sender As Object, e As EventArgs) Handles EndingTDarkY.ValueChanged
        If ProgramIsChangingStuff = False Then
            Form1.EXEStream(CurrentEndOffset + &H8 + &H14) = BitConverter.GetBytes(EndingTDarkY.Value)(0)
            Form1.EXEStream(CurrentEndOffset + &H9 + &H14) = BitConverter.GetBytes(EndingTDarkY.Value)(1)
            Form1.EXEStream(CurrentEndOffset + &HA + &H14) = BitConverter.GetBytes(EndingTDarkY.Value)(2)
            Form1.EXEStream(CurrentEndOffset + &HB + &H14) = BitConverter.GetBytes(EndingTDarkY.Value)(3)
        End If
    End Sub

    Private Sub EndingTDarkZ_ValueChanged(sender As Object, e As EventArgs) Handles EndingTDarkZ.ValueChanged
        If ProgramIsChangingStuff = False Then
            Form1.EXEStream(CurrentEndOffset + &HC + &H14) = BitConverter.GetBytes(EndingTDarkZ.Value)(0)
            Form1.EXEStream(CurrentEndOffset + &HD + &H14) = BitConverter.GetBytes(EndingTDarkZ.Value)(1)
            Form1.EXEStream(CurrentEndOffset + &HE + &H14) = BitConverter.GetBytes(EndingTDarkZ.Value)(2)
            Form1.EXEStream(CurrentEndOffset + &HF + &H14) = BitConverter.GetBytes(EndingTDarkZ.Value)(3)
        End If
    End Sub

    Private Sub EndingTDarkAngle_ValueChanged(sender As Object, e As EventArgs) Handles EndingTDarkAngle.ValueChanged
        If ProgramIsChangingStuff = False Then
            Dim AngleAsUInt16 As UInt16 = EndingTDarkAngle.Value * 65536.0 / 360.0

            Form1.EXEStream(CurrentEndOffset + &H10 + &H14) = BitConverter.GetBytes(AngleAsUInt16)(0)
            Form1.EXEStream(CurrentEndOffset + &H11 + &H14) = BitConverter.GetBytes(AngleAsUInt16)(1)
            Form1.EXEStream(CurrentEndOffset + &H12 + &H14) = 0
            Form1.EXEStream(CurrentEndOffset + &H13 + &H14) = 0
        End If
    End Sub

    Private Sub EndingTRoseX_ValueChanged(sender As Object, e As EventArgs) Handles EndingTRoseX.ValueChanged
        If ProgramIsChangingStuff = False Then
            Form1.EXEStream(CurrentEndOffset + &H4 + &H28) = BitConverter.GetBytes(EndingTRoseX.Value)(0)
            Form1.EXEStream(CurrentEndOffset + &H5 + &H28) = BitConverter.GetBytes(EndingTRoseX.Value)(1)
            Form1.EXEStream(CurrentEndOffset + &H6 + &H28) = BitConverter.GetBytes(EndingTRoseX.Value)(2)
            Form1.EXEStream(CurrentEndOffset + &H7 + &H28) = BitConverter.GetBytes(EndingTRoseX.Value)(3)
        End If
    End Sub

    Private Sub EndingTRoseY_ValueChanged(sender As Object, e As EventArgs) Handles EndingTRoseY.ValueChanged
        If ProgramIsChangingStuff = False Then
            Form1.EXEStream(CurrentEndOffset + &H8 + &H28) = BitConverter.GetBytes(EndingTRoseY.Value)(0)
            Form1.EXEStream(CurrentEndOffset + &H9 + &H28) = BitConverter.GetBytes(EndingTRoseY.Value)(1)
            Form1.EXEStream(CurrentEndOffset + &HA + &H28) = BitConverter.GetBytes(EndingTRoseY.Value)(2)
            Form1.EXEStream(CurrentEndOffset + &HB + &H28) = BitConverter.GetBytes(EndingTRoseY.Value)(3)
        End If
    End Sub

    Private Sub EndingTRoseZ_ValueChanged(sender As Object, e As EventArgs) Handles EndingTRoseZ.ValueChanged
        If ProgramIsChangingStuff = False Then
            Form1.EXEStream(CurrentEndOffset + &HC + &H28) = BitConverter.GetBytes(EndingTRoseZ.Value)(0)
            Form1.EXEStream(CurrentEndOffset + &HD + &H28) = BitConverter.GetBytes(EndingTRoseZ.Value)(1)
            Form1.EXEStream(CurrentEndOffset + &HE + &H28) = BitConverter.GetBytes(EndingTRoseZ.Value)(2)
            Form1.EXEStream(CurrentEndOffset + &HF + &H28) = BitConverter.GetBytes(EndingTRoseZ.Value)(3)
        End If
    End Sub

    Private Sub EndingTRoseAngle_ValueChanged(sender As Object, e As EventArgs) Handles EndingTRoseAngle.ValueChanged
        If ProgramIsChangingStuff = False Then
            Dim AngleAsUInt16 As UInt16 = EndingTRoseAngle.Value * 65536.0 / 360.0

            Form1.EXEStream(CurrentEndOffset + &H10 + &H28) = BitConverter.GetBytes(AngleAsUInt16)(0)
            Form1.EXEStream(CurrentEndOffset + &H11 + &H28) = BitConverter.GetBytes(AngleAsUInt16)(1)
            Form1.EXEStream(CurrentEndOffset + &H12 + &H28) = 0
            Form1.EXEStream(CurrentEndOffset + &H13 + &H28) = 0
        End If
    End Sub
    Private Sub EndingTChaotixX_ValueChanged(sender As Object, e As EventArgs) Handles EndingTChaotixX.ValueChanged
        If ProgramIsChangingStuff = False Then
            Form1.EXEStream(CurrentEndOffset + &H4 + &H3C) = BitConverter.GetBytes(EndingTChaotixX.Value)(0)
            Form1.EXEStream(CurrentEndOffset + &H5 + &H3C) = BitConverter.GetBytes(EndingTChaotixX.Value)(1)
            Form1.EXEStream(CurrentEndOffset + &H6 + &H3C) = BitConverter.GetBytes(EndingTChaotixX.Value)(2)
            Form1.EXEStream(CurrentEndOffset + &H7 + &H3C) = BitConverter.GetBytes(EndingTChaotixX.Value)(3)
        End If
    End Sub

    Private Sub EndingTChaotixY_ValueChanged(sender As Object, e As EventArgs) Handles EndingTChaotixY.ValueChanged
        If ProgramIsChangingStuff = False Then
            Form1.EXEStream(CurrentEndOffset + &H8 + &H3C) = BitConverter.GetBytes(EndingTChaotixY.Value)(0)
            Form1.EXEStream(CurrentEndOffset + &H9 + &H3C) = BitConverter.GetBytes(EndingTChaotixY.Value)(1)
            Form1.EXEStream(CurrentEndOffset + &HA + &H3C) = BitConverter.GetBytes(EndingTChaotixY.Value)(2)
            Form1.EXEStream(CurrentEndOffset + &HB + &H3C) = BitConverter.GetBytes(EndingTChaotixY.Value)(3)
        End If
    End Sub

    Private Sub EndingTChaotixZ_ValueChanged(sender As Object, e As EventArgs) Handles EndingTChaotixZ.ValueChanged
        If ProgramIsChangingStuff = False Then
            Form1.EXEStream(CurrentEndOffset + &HC + &H3C) = BitConverter.GetBytes(EndingTChaotixZ.Value)(0)
            Form1.EXEStream(CurrentEndOffset + &HD + &H3C) = BitConverter.GetBytes(EndingTChaotixZ.Value)(1)
            Form1.EXEStream(CurrentEndOffset + &HE + &H3C) = BitConverter.GetBytes(EndingTChaotixZ.Value)(2)
            Form1.EXEStream(CurrentEndOffset + &HF + &H3C) = BitConverter.GetBytes(EndingTChaotixZ.Value)(3)
        End If
    End Sub

    Private Sub EndingTChaotixAngle_ValueChanged(sender As Object, e As EventArgs) Handles EndingTChaotixAngle.ValueChanged
        If ProgramIsChangingStuff = False Then
            Dim AngleAsUInt16 As UInt16 = EndingTChaotixAngle.Value * 65536.0 / 360.0

            Form1.EXEStream(CurrentEndOffset + &H10 + &H3C) = BitConverter.GetBytes(AngleAsUInt16)(0)
            Form1.EXEStream(CurrentEndOffset + &H11 + &H3C) = BitConverter.GetBytes(AngleAsUInt16)(1)
            Form1.EXEStream(CurrentEndOffset + &H12 + &H3C) = 0
            Form1.EXEStream(CurrentEndOffset + &H13 + &H3C) = 0
        End If
    End Sub
    Private Sub EndingTSuperX_ValueChanged(sender As Object, e As EventArgs) Handles EndingTSuperX.ValueChanged
        If ProgramIsChangingStuff = False Then
            Form1.EXEStream(CurrentEndOffset + &H4 + &H50) = BitConverter.GetBytes(EndingTSuperX.Value)(0)
            Form1.EXEStream(CurrentEndOffset + &H5 + &H50) = BitConverter.GetBytes(EndingTSuperX.Value)(1)
            Form1.EXEStream(CurrentEndOffset + &H6 + &H50) = BitConverter.GetBytes(EndingTSuperX.Value)(2)
            Form1.EXEStream(CurrentEndOffset + &H7 + &H50) = BitConverter.GetBytes(EndingTSuperX.Value)(3)
        End If
    End Sub

    Private Sub EndingTSuperY_ValueChanged(sender As Object, e As EventArgs) Handles EndingTSuperY.ValueChanged
        If ProgramIsChangingStuff = False Then
            Form1.EXEStream(CurrentEndOffset + &H8 + &H50) = BitConverter.GetBytes(EndingTSuperY.Value)(0)
            Form1.EXEStream(CurrentEndOffset + &H9 + &H50) = BitConverter.GetBytes(EndingTSuperY.Value)(1)
            Form1.EXEStream(CurrentEndOffset + &HA + &H50) = BitConverter.GetBytes(EndingTSuperY.Value)(2)
            Form1.EXEStream(CurrentEndOffset + &HB + &H50) = BitConverter.GetBytes(EndingTSuperY.Value)(3)
        End If
    End Sub

    Private Sub EndingTSuperZ_ValueChanged(sender As Object, e As EventArgs) Handles EndingTSuperZ.ValueChanged
        If ProgramIsChangingStuff = False Then
            Form1.EXEStream(CurrentEndOffset + &HC + &H50) = BitConverter.GetBytes(EndingTSuperZ.Value)(0)
            Form1.EXEStream(CurrentEndOffset + &HD + &H50) = BitConverter.GetBytes(EndingTSuperZ.Value)(1)
            Form1.EXEStream(CurrentEndOffset + &HE + &H50) = BitConverter.GetBytes(EndingTSuperZ.Value)(2)
            Form1.EXEStream(CurrentEndOffset + &HF + &H50) = BitConverter.GetBytes(EndingTSuperZ.Value)(3)
        End If
    End Sub

    Private Sub EndingTSuperAngle_ValueChanged(sender As Object, e As EventArgs) Handles EndingTSuperAngle.ValueChanged
        If ProgramIsChangingStuff = False Then
            Dim AngleAsUInt16 As UInt16 = EndingTSuperAngle.Value * 65536.0 / 360.0

            Form1.EXEStream(CurrentEndOffset + &H10 + &H50) = BitConverter.GetBytes(AngleAsUInt16)(0)
            Form1.EXEStream(CurrentEndOffset + &H11 + &H50) = BitConverter.GetBytes(AngleAsUInt16)(1)
            Form1.EXEStream(CurrentEndOffset + &H12 + &H50) = 0
            Form1.EXEStream(CurrentEndOffset + &H13 + &H50) = 0
        End If
    End Sub

    Private Sub MultiP1X_ValueChanged(sender As Object, e As EventArgs) Handles MultiP1X.ValueChanged
        If ProgramIsChangingStuff = False Then
            Form1.EXEStream(CurrentMultiOffset + &H4) = BitConverter.GetBytes(MultiP1X.Value)(0)
            Form1.EXEStream(CurrentMultiOffset + &H5) = BitConverter.GetBytes(MultiP1X.Value)(1)
            Form1.EXEStream(CurrentMultiOffset + &H6) = BitConverter.GetBytes(MultiP1X.Value)(2)
            Form1.EXEStream(CurrentMultiOffset + &H7) = BitConverter.GetBytes(MultiP1X.Value)(3)
        End If
    End Sub

    Private Sub MultiP1Y_ValueChanged(sender As Object, e As EventArgs) Handles MultiP1Y.ValueChanged
        If ProgramIsChangingStuff = False Then
            Form1.EXEStream(CurrentMultiOffset + &H8) = BitConverter.GetBytes(MultiP1Y.Value)(0)
            Form1.EXEStream(CurrentMultiOffset + &H9) = BitConverter.GetBytes(MultiP1Y.Value)(1)
            Form1.EXEStream(CurrentMultiOffset + &HA) = BitConverter.GetBytes(MultiP1Y.Value)(2)
            Form1.EXEStream(CurrentMultiOffset + &HB) = BitConverter.GetBytes(MultiP1Y.Value)(3)
        End If
    End Sub

    Private Sub MultiP1Z_ValueChanged(sender As Object, e As EventArgs) Handles MultiP1Z.ValueChanged
        If ProgramIsChangingStuff = False Then
            Form1.EXEStream(CurrentMultiOffset + &HC) = BitConverter.GetBytes(MultiP1Z.Value)(0)
            Form1.EXEStream(CurrentMultiOffset + &HD) = BitConverter.GetBytes(MultiP1Z.Value)(1)
            Form1.EXEStream(CurrentMultiOffset + &HE) = BitConverter.GetBytes(MultiP1Z.Value)(2)
            Form1.EXEStream(CurrentMultiOffset + &HF) = BitConverter.GetBytes(MultiP1Z.Value)(3)
        End If
    End Sub

    Private Sub MultiP1Angle_ValueChanged(sender As Object, e As EventArgs) Handles MultiP1Angle.ValueChanged
        If ProgramIsChangingStuff = False Then
            Dim AngleAsUInt16 As UInt16 = MultiP1Angle.Value * 65536.0 / 360.0

            Form1.EXEStream(CurrentMultiOffset + &H10) = BitConverter.GetBytes(AngleAsUInt16)(0)
            Form1.EXEStream(CurrentMultiOffset + &H11) = BitConverter.GetBytes(AngleAsUInt16)(1)
            Form1.EXEStream(CurrentMultiOffset + &H12) = 0
            Form1.EXEStream(CurrentMultiOffset + &H13) = 0
        End If
    End Sub

    Private Sub MultiP1Mode_SelectedIndexChanged(sender As Object, e As EventArgs) Handles MultiP1Mode.SelectedIndexChanged
        If ProgramIsChangingStuff = False Then
            Form1.EXEStream(CurrentMultiOffset + &H18) = MultiP1Mode.SelectedIndex
            Form1.EXEStream(CurrentMultiOffset + &H19) = 0
            Form1.EXEStream(CurrentMultiOffset + &H1A) = 0
            Form1.EXEStream(CurrentMultiOffset + &H1B) = 0
        End If
    End Sub

    Private Sub MultiP1Hold_ValueChanged(sender As Object, e As EventArgs) Handles MultiP1Hold.ValueChanged
        If ProgramIsChangingStuff = False Then
            Dim Value As UInt16 = MultiP1Hold.Value

            Form1.EXEStream(CurrentMultiOffset + &H1C) = BitConverter.GetBytes(MultiP1Hold.Value)(0)
            Form1.EXEStream(CurrentMultiOffset + &H1D) = BitConverter.GetBytes(MultiP1Hold.Value)(1)
            Form1.EXEStream(CurrentMultiOffset + &H1E) = 0
            Form1.EXEStream(CurrentMultiOffset + &H1F) = 0
        End If
    End Sub

    Private Sub MultiP2X_ValueChanged(sender As Object, e As EventArgs) Handles MultiP2X.ValueChanged
        If ProgramIsChangingStuff = False Then
            Form1.EXEStream(CurrentMultiOffset + &H4 + &H1C) = BitConverter.GetBytes(MultiP2X.Value)(0)
            Form1.EXEStream(CurrentMultiOffset + &H5 + &H1C) = BitConverter.GetBytes(MultiP2X.Value)(1)
            Form1.EXEStream(CurrentMultiOffset + &H6 + &H1C) = BitConverter.GetBytes(MultiP2X.Value)(2)
            Form1.EXEStream(CurrentMultiOffset + &H7 + &H1C) = BitConverter.GetBytes(MultiP2X.Value)(3)
        End If
    End Sub

    Private Sub MultiP2Y_ValueChanged(sender As Object, e As EventArgs) Handles MultiP2Y.ValueChanged
        If ProgramIsChangingStuff = False Then
            Form1.EXEStream(CurrentMultiOffset + &H8 + &H1C) = BitConverter.GetBytes(MultiP2Y.Value)(0)
            Form1.EXEStream(CurrentMultiOffset + &H9 + &H1C) = BitConverter.GetBytes(MultiP2Y.Value)(1)
            Form1.EXEStream(CurrentMultiOffset + &HA + &H1C) = BitConverter.GetBytes(MultiP2Y.Value)(2)
            Form1.EXEStream(CurrentMultiOffset + &HB + &H1C) = BitConverter.GetBytes(MultiP2Y.Value)(3)
        End If
    End Sub

    Private Sub MultiP2Z_ValueChanged(sender As Object, e As EventArgs) Handles MultiP2Z.ValueChanged
        If ProgramIsChangingStuff = False Then
            Form1.EXEStream(CurrentMultiOffset + &HC + &H1C) = BitConverter.GetBytes(MultiP2Z.Value)(0)
            Form1.EXEStream(CurrentMultiOffset + &HD + &H1C) = BitConverter.GetBytes(MultiP2Z.Value)(1)
            Form1.EXEStream(CurrentMultiOffset + &HE + &H1C) = BitConverter.GetBytes(MultiP2Z.Value)(2)
            Form1.EXEStream(CurrentMultiOffset + &HF + &H1C) = BitConverter.GetBytes(MultiP2Z.Value)(3)
        End If
    End Sub

    Private Sub MultiP2Angle_ValueChanged(sender As Object, e As EventArgs) Handles MultiP2Angle.ValueChanged
        If ProgramIsChangingStuff = False Then
            Dim AngleAsUInt16 As UInt16 = MultiP2Angle.Value * 65536.0 / 360.0

            Form1.EXEStream(CurrentMultiOffset + &H10 + &H1C) = BitConverter.GetBytes(AngleAsUInt16)(0)
            Form1.EXEStream(CurrentMultiOffset + &H11 + &H1C) = BitConverter.GetBytes(AngleAsUInt16)(1)
            Form1.EXEStream(CurrentMultiOffset + &H12 + &H1C) = 0
            Form1.EXEStream(CurrentMultiOffset + &H13 + &H1C) = 0
        End If
    End Sub

    Private Sub MultiP2Mode_SelectedIndexChanged(sender As Object, e As EventArgs) Handles MultiP2Mode.SelectedIndexChanged
        If ProgramIsChangingStuff = False Then
            Form1.EXEStream(CurrentMultiOffset + &H18 + &H1C) = MultiP2Mode.SelectedIndex
            Form1.EXEStream(CurrentMultiOffset + &H19 + &H1C) = 0
            Form1.EXEStream(CurrentMultiOffset + &H1A + &H1C) = 0
            Form1.EXEStream(CurrentMultiOffset + &H1B + &H1C) = 0
        End If
    End Sub

    Private Sub MultiP2Hold_ValueChanged(sender As Object, e As EventArgs) Handles MultiP2Hold.ValueChanged
        If ProgramIsChangingStuff = False Then
            Dim Value As UInt16 = MultiP2Hold.Value

            Form1.EXEStream(CurrentMultiOffset + &H1C + &H1C) = BitConverter.GetBytes(MultiP2Hold.Value)(0)
            Form1.EXEStream(CurrentMultiOffset + &H1D + &H1C) = BitConverter.GetBytes(MultiP2Hold.Value)(1)
            Form1.EXEStream(CurrentMultiOffset + &H1E + &H1C) = 0
            Form1.EXEStream(CurrentMultiOffset + &H1F + &H1C) = 0
        End If
    End Sub

    Private Sub BragTSonicX_ValueChanged(sender As Object, e As EventArgs) Handles BragTSonicX.ValueChanged
        If ProgramIsChangingStuff = False Then
            Form1.EXEStream(CurrentBragOffset + &H4) = BitConverter.GetBytes(BragTSonicX.Value)(0)
            Form1.EXEStream(CurrentBragOffset + &H5) = BitConverter.GetBytes(BragTSonicX.Value)(1)
            Form1.EXEStream(CurrentBragOffset + &H6) = BitConverter.GetBytes(BragTSonicX.Value)(2)
            Form1.EXEStream(CurrentBragOffset + &H7) = BitConverter.GetBytes(BragTSonicX.Value)(3)
        End If
    End Sub

    Private Sub BragTSonicY_ValueChanged(sender As Object, e As EventArgs) Handles BragTSonicY.ValueChanged
        If ProgramIsChangingStuff = False Then
            Form1.EXEStream(CurrentBragOffset + &H8) = BitConverter.GetBytes(BragTSonicY.Value)(0)
            Form1.EXEStream(CurrentBragOffset + &H9) = BitConverter.GetBytes(BragTSonicY.Value)(1)
            Form1.EXEStream(CurrentBragOffset + &HA) = BitConverter.GetBytes(BragTSonicY.Value)(2)
            Form1.EXEStream(CurrentBragOffset + &HB) = BitConverter.GetBytes(BragTSonicY.Value)(3)
        End If
    End Sub

    Private Sub BragTSonicZ_ValueChanged(sender As Object, e As EventArgs) Handles BragTSonicZ.ValueChanged
        If ProgramIsChangingStuff = False Then
            Form1.EXEStream(CurrentBragOffset + &HC) = BitConverter.GetBytes(BragTSonicZ.Value)(0)
            Form1.EXEStream(CurrentBragOffset + &HD) = BitConverter.GetBytes(BragTSonicZ.Value)(1)
            Form1.EXEStream(CurrentBragOffset + &HE) = BitConverter.GetBytes(BragTSonicZ.Value)(2)
            Form1.EXEStream(CurrentBragOffset + &HF) = BitConverter.GetBytes(BragTSonicZ.Value)(3)
        End If
    End Sub

    Private Sub BragTSonicAngle_ValueChanged(sender As Object, e As EventArgs) Handles BragTSonicAngle.ValueChanged
        If ProgramIsChangingStuff = False Then
            Dim AngleAsUInt16 As UInt16 = BragTSonicAngle.Value * 65536.0 / 360.0

            Form1.EXEStream(CurrentBragOffset + &H10) = BitConverter.GetBytes(AngleAsUInt16)(0)
            Form1.EXEStream(CurrentBragOffset + &H11) = BitConverter.GetBytes(AngleAsUInt16)(1)
            Form1.EXEStream(CurrentBragOffset + &H12) = 0
            Form1.EXEStream(CurrentBragOffset + &H13) = 0
        End If
    End Sub

    Private Sub BragTDarkX_ValueChanged(sender As Object, e As EventArgs) Handles BragTDarkX.ValueChanged
        If ProgramIsChangingStuff = False Then
            Form1.EXEStream(CurrentBragOffset + &H4 + &H10) = BitConverter.GetBytes(BragTDarkX.Value)(0)
            Form1.EXEStream(CurrentBragOffset + &H5 + &H10) = BitConverter.GetBytes(BragTDarkX.Value)(1)
            Form1.EXEStream(CurrentBragOffset + &H6 + &H10) = BitConverter.GetBytes(BragTDarkX.Value)(2)
            Form1.EXEStream(CurrentBragOffset + &H7 + &H10) = BitConverter.GetBytes(BragTDarkX.Value)(3)
        End If
    End Sub

    Private Sub BragTDarkY_ValueChanged(sender As Object, e As EventArgs) Handles BragTDarkY.ValueChanged
        If ProgramIsChangingStuff = False Then
            Form1.EXEStream(CurrentBragOffset + &H8 + &H10) = BitConverter.GetBytes(BragTDarkY.Value)(0)
            Form1.EXEStream(CurrentBragOffset + &H9 + &H10) = BitConverter.GetBytes(BragTDarkY.Value)(1)
            Form1.EXEStream(CurrentBragOffset + &HA + &H10) = BitConverter.GetBytes(BragTDarkY.Value)(2)
            Form1.EXEStream(CurrentBragOffset + &HB + &H10) = BitConverter.GetBytes(BragTDarkY.Value)(3)
        End If
    End Sub

    Private Sub BragTDarkZ_ValueChanged(sender As Object, e As EventArgs) Handles BragTDarkZ.ValueChanged
        If ProgramIsChangingStuff = False Then
            Form1.EXEStream(CurrentBragOffset + &HC + &H10) = BitConverter.GetBytes(BragTDarkZ.Value)(0)
            Form1.EXEStream(CurrentBragOffset + &HD + &H10) = BitConverter.GetBytes(BragTDarkZ.Value)(1)
            Form1.EXEStream(CurrentBragOffset + &HE + &H10) = BitConverter.GetBytes(BragTDarkZ.Value)(2)
            Form1.EXEStream(CurrentBragOffset + &HF + &H10) = BitConverter.GetBytes(BragTDarkZ.Value)(3)
        End If
    End Sub

    Private Sub BragTDarkAngle_ValueChanged(sender As Object, e As EventArgs) Handles BragTDarkAngle.ValueChanged
        If ProgramIsChangingStuff = False Then
            Dim AngleAsUInt16 As UInt16 = BragTDarkAngle.Value * 65536.0 / 360.0

            Form1.EXEStream(CurrentBragOffset + &H10 + &H10) = BitConverter.GetBytes(AngleAsUInt16)(0)
            Form1.EXEStream(CurrentBragOffset + &H11 + &H10) = BitConverter.GetBytes(AngleAsUInt16)(1)
            Form1.EXEStream(CurrentBragOffset + &H12 + &H10) = 0
            Form1.EXEStream(CurrentBragOffset + &H13 + &H10) = 0
        End If
    End Sub

    Private Sub BragTRoseX_ValueChanged(sender As Object, e As EventArgs) Handles BragTRoseX.ValueChanged
        If ProgramIsChangingStuff = False Then
            Form1.EXEStream(CurrentBragOffset + &H4 + &H20) = BitConverter.GetBytes(BragTRoseX.Value)(0)
            Form1.EXEStream(CurrentBragOffset + &H5 + &H20) = BitConverter.GetBytes(BragTRoseX.Value)(1)
            Form1.EXEStream(CurrentBragOffset + &H6 + &H20) = BitConverter.GetBytes(BragTRoseX.Value)(2)
            Form1.EXEStream(CurrentBragOffset + &H7 + &H20) = BitConverter.GetBytes(BragTRoseX.Value)(3)
        End If
    End Sub

    Private Sub BragTRoseY_ValueChanged(sender As Object, e As EventArgs) Handles BragTRoseY.ValueChanged
        If ProgramIsChangingStuff = False Then
            Form1.EXEStream(CurrentBragOffset + &H8 + &H20) = BitConverter.GetBytes(BragTRoseY.Value)(0)
            Form1.EXEStream(CurrentBragOffset + &H9 + &H20) = BitConverter.GetBytes(BragTRoseY.Value)(1)
            Form1.EXEStream(CurrentBragOffset + &HA + &H20) = BitConverter.GetBytes(BragTRoseY.Value)(2)
            Form1.EXEStream(CurrentBragOffset + &HB + &H20) = BitConverter.GetBytes(BragTRoseY.Value)(3)
        End If
    End Sub

    Private Sub BragTRoseZ_ValueChanged(sender As Object, e As EventArgs) Handles BragTRoseZ.ValueChanged
        If ProgramIsChangingStuff = False Then
            Form1.EXEStream(CurrentBragOffset + &HC + &H20) = BitConverter.GetBytes(BragTRoseZ.Value)(0)
            Form1.EXEStream(CurrentBragOffset + &HD + &H20) = BitConverter.GetBytes(BragTRoseZ.Value)(1)
            Form1.EXEStream(CurrentBragOffset + &HE + &H20) = BitConverter.GetBytes(BragTRoseZ.Value)(2)
            Form1.EXEStream(CurrentBragOffset + &HF + &H20) = BitConverter.GetBytes(BragTRoseZ.Value)(3)
        End If
    End Sub

    Private Sub BragTRoseAngle_ValueChanged(sender As Object, e As EventArgs) Handles BragTRoseAngle.ValueChanged
        If ProgramIsChangingStuff = False Then
            Dim AngleAsUInt16 As UInt16 = BragTRoseAngle.Value * 65536.0 / 360.0

            Form1.EXEStream(CurrentBragOffset + &H10 + &H20) = BitConverter.GetBytes(AngleAsUInt16)(0)
            Form1.EXEStream(CurrentBragOffset + &H11 + &H20) = BitConverter.GetBytes(AngleAsUInt16)(1)
            Form1.EXEStream(CurrentBragOffset + &H12 + &H20) = 0
            Form1.EXEStream(CurrentBragOffset + &H13 + &H20) = 0
        End If
    End Sub

    Private Sub BragTChaotixX_ValueChanged(sender As Object, e As EventArgs) Handles BragTChaotixX.ValueChanged
        If ProgramIsChangingStuff = False Then
            Form1.EXEStream(CurrentBragOffset + &H4 + &H30) = BitConverter.GetBytes(BragTChaotixX.Value)(0)
            Form1.EXEStream(CurrentBragOffset + &H5 + &H30) = BitConverter.GetBytes(BragTChaotixX.Value)(1)
            Form1.EXEStream(CurrentBragOffset + &H6 + &H30) = BitConverter.GetBytes(BragTChaotixX.Value)(2)
            Form1.EXEStream(CurrentBragOffset + &H7 + &H30) = BitConverter.GetBytes(BragTChaotixX.Value)(3)
        End If
    End Sub

    Private Sub BragTChaotixY_ValueChanged(sender As Object, e As EventArgs) Handles BragTChaotixY.ValueChanged
        If ProgramIsChangingStuff = False Then
            Form1.EXEStream(CurrentBragOffset + &H8 + &H30) = BitConverter.GetBytes(BragTChaotixY.Value)(0)
            Form1.EXEStream(CurrentBragOffset + &H9 + &H30) = BitConverter.GetBytes(BragTChaotixY.Value)(1)
            Form1.EXEStream(CurrentBragOffset + &HA + &H30) = BitConverter.GetBytes(BragTChaotixY.Value)(2)
            Form1.EXEStream(CurrentBragOffset + &HB + &H30) = BitConverter.GetBytes(BragTChaotixY.Value)(3)
        End If
    End Sub

    Private Sub BragTChaotixZ_ValueChanged(sender As Object, e As EventArgs) Handles BragTChaotixZ.ValueChanged
        If ProgramIsChangingStuff = False Then
            Form1.EXEStream(CurrentBragOffset + &HC + &H30) = BitConverter.GetBytes(BragTChaotixZ.Value)(0)
            Form1.EXEStream(CurrentBragOffset + &HD + &H30) = BitConverter.GetBytes(BragTChaotixZ.Value)(1)
            Form1.EXEStream(CurrentBragOffset + &HE + &H30) = BitConverter.GetBytes(BragTChaotixZ.Value)(2)
            Form1.EXEStream(CurrentBragOffset + &HF + &H30) = BitConverter.GetBytes(BragTChaotixZ.Value)(3)
        End If
    End Sub

    Private Sub BragTChaotixAngle_ValueChanged(sender As Object, e As EventArgs) Handles BragTChaotixAngle.ValueChanged
        If ProgramIsChangingStuff = False Then
            Dim AngleAsUInt16 As UInt16 = BragTChaotixAngle.Value * 65536.0 / 360.0

            Form1.EXEStream(CurrentBragOffset + &H10 + &H30) = BitConverter.GetBytes(AngleAsUInt16)(0)
            Form1.EXEStream(CurrentBragOffset + &H11 + &H30) = BitConverter.GetBytes(AngleAsUInt16)(1)
            Form1.EXEStream(CurrentBragOffset + &H12 + &H30) = 0
            Form1.EXEStream(CurrentBragOffset + &H13 + &H30) = 0
        End If
    End Sub

    Private Sub BragTSuperX_ValueChanged(sender As Object, e As EventArgs) Handles BragTSuperX.ValueChanged
        If ProgramIsChangingStuff = False Then
            Form1.EXEStream(CurrentBragOffset + &H4 + &H40) = BitConverter.GetBytes(BragTSuperX.Value)(0)
            Form1.EXEStream(CurrentBragOffset + &H5 + &H40) = BitConverter.GetBytes(BragTSuperX.Value)(1)
            Form1.EXEStream(CurrentBragOffset + &H6 + &H40) = BitConverter.GetBytes(BragTSuperX.Value)(2)
            Form1.EXEStream(CurrentBragOffset + &H7 + &H40) = BitConverter.GetBytes(BragTSuperX.Value)(3)
        End If
    End Sub

    Private Sub BragTSuperY_ValueChanged(sender As Object, e As EventArgs) Handles BragTSuperY.ValueChanged
        If ProgramIsChangingStuff = False Then
            Form1.EXEStream(CurrentBragOffset + &H8 + &H40) = BitConverter.GetBytes(BragTSuperY.Value)(0)
            Form1.EXEStream(CurrentBragOffset + &H9 + &H40) = BitConverter.GetBytes(BragTSuperY.Value)(1)
            Form1.EXEStream(CurrentBragOffset + &HA + &H40) = BitConverter.GetBytes(BragTSuperY.Value)(2)
            Form1.EXEStream(CurrentBragOffset + &HB + &H40) = BitConverter.GetBytes(BragTSuperY.Value)(3)
        End If
    End Sub

    Private Sub BragTSuperZ_ValueChanged(sender As Object, e As EventArgs) Handles BragTSuperZ.ValueChanged
        If ProgramIsChangingStuff = False Then
            Form1.EXEStream(CurrentBragOffset + &HC + &H40) = BitConverter.GetBytes(BragTSuperZ.Value)(0)
            Form1.EXEStream(CurrentBragOffset + &HD + &H40) = BitConverter.GetBytes(BragTSuperZ.Value)(1)
            Form1.EXEStream(CurrentBragOffset + &HE + &H40) = BitConverter.GetBytes(BragTSuperZ.Value)(2)
            Form1.EXEStream(CurrentBragOffset + &HF + &H40) = BitConverter.GetBytes(BragTSuperZ.Value)(3)
        End If
    End Sub

    Private Sub BragTSuperAngle_ValueChanged(sender As Object, e As EventArgs) Handles BragTSuperAngle.ValueChanged
        If ProgramIsChangingStuff = False Then
            Dim AngleAsUInt16 As UInt16 = BragTSuperAngle.Value * 65536.0 / 360.0

            Form1.EXEStream(CurrentBragOffset + &H10 + &H40) = BitConverter.GetBytes(AngleAsUInt16)(0)
            Form1.EXEStream(CurrentBragOffset + &H11 + &H40) = BitConverter.GetBytes(AngleAsUInt16)(1)
            Form1.EXEStream(CurrentBragOffset + &H12 + &H40) = 0
            Form1.EXEStream(CurrentBragOffset + &H13 + &H40) = 0
        End If
    End Sub
End Class