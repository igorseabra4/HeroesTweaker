Public Class RankingEditor
    Dim ProgramIsChangingStuff As Boolean = False

    Private Sub ComboBoxLevelRegular_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBoxLevelRegular.SelectedIndexChanged
        GroupBox1.Enabled = True
        GroupBox2.Enabled = True
        GroupBox3.Enabled = True
        GroupBox4.Enabled = True

        ProgramIsChangingStuff = True

        NumericSonicD.Value = BitConverter.ToUInt16(Form1.EXEStream, &H3C7448 + &H24 * ComboBoxLevelRegular.SelectedIndex + 4) * 100
        NumericSonicC.Value = BitConverter.ToUInt16(Form1.EXEStream, &H3C7448 + &H24 * ComboBoxLevelRegular.SelectedIndex + 6) * 100
        NumericSonicB.Value = BitConverter.ToUInt16(Form1.EXEStream, &H3C7448 + &H24 * ComboBoxLevelRegular.SelectedIndex + 8) * 100
        NumericSonicA.Value = BitConverter.ToUInt16(Form1.EXEStream, &H3C7448 + &H24 * ComboBoxLevelRegular.SelectedIndex + 10) * 100

        NumericDarkD.Value = BitConverter.ToUInt16(Form1.EXEStream, &H3C7448 + &H24 * ComboBoxLevelRegular.SelectedIndex + 12) * 100
        NumericDarkC.Value = BitConverter.ToUInt16(Form1.EXEStream, &H3C7448 + &H24 * ComboBoxLevelRegular.SelectedIndex + 14) * 100
        NumericDarkB.Value = BitConverter.ToUInt16(Form1.EXEStream, &H3C7448 + &H24 * ComboBoxLevelRegular.SelectedIndex + 16) * 100
        NumericDarkA.Value = BitConverter.ToUInt16(Form1.EXEStream, &H3C7448 + &H24 * ComboBoxLevelRegular.SelectedIndex + 18) * 100

        NumericRoseD.Value = BitConverter.ToUInt16(Form1.EXEStream, &H3C7448 + &H24 * ComboBoxLevelRegular.SelectedIndex + 20) * 100
        NumericRoseC.Value = BitConverter.ToUInt16(Form1.EXEStream, &H3C7448 + &H24 * ComboBoxLevelRegular.SelectedIndex + 22) * 100
        NumericRoseB.Value = BitConverter.ToUInt16(Form1.EXEStream, &H3C7448 + &H24 * ComboBoxLevelRegular.SelectedIndex + 24) * 100
        NumericRoseA.Value = BitConverter.ToUInt16(Form1.EXEStream, &H3C7448 + &H24 * ComboBoxLevelRegular.SelectedIndex + 26) * 100

        NumericChaotixD.Value = BitConverter.ToUInt16(Form1.EXEStream, &H3C7448 + &H24 * ComboBoxLevelRegular.SelectedIndex + 28) * 100
        NumericChaotixC.Value = BitConverter.ToUInt16(Form1.EXEStream, &H3C7448 + &H24 * ComboBoxLevelRegular.SelectedIndex + 30) * 100
        NumericChaotixB.Value = BitConverter.ToUInt16(Form1.EXEStream, &H3C7448 + &H24 * ComboBoxLevelRegular.SelectedIndex + 32) * 100
        NumericChaotixA.Value = BitConverter.ToUInt16(Form1.EXEStream, &H3C7448 + &H24 * ComboBoxLevelRegular.SelectedIndex + 34) * 100

        ProgramIsChangingStuff = False
    End Sub

    Private Sub NumericSonicA_ValueChanged(sender As Object, e As EventArgs) Handles NumericSonicA.ValueChanged
        If ProgramIsChangingStuff = False Then
            Form1.EXEStream(&H3C7448 + &H24 * ComboBoxLevelRegular.SelectedIndex + 10) = BitConverter.GetBytes(Convert.ToUInt16(NumericSonicA.Value / 100))(0)
            Form1.EXEStream(&H3C7448 + &H24 * ComboBoxLevelRegular.SelectedIndex + 11) = BitConverter.GetBytes(Convert.ToUInt16(NumericSonicA.Value / 100))(1)
        End If
        ComboBoxLevelRegular_SelectedIndexChanged(sender, e)
    End Sub

    Private Sub NumericSonicB_ValueChanged(sender As Object, e As EventArgs) Handles NumericSonicB.ValueChanged
        If ProgramIsChangingStuff = False Then
            Form1.EXEStream(&H3C7448 + &H24 * ComboBoxLevelRegular.SelectedIndex + 8) = BitConverter.GetBytes(Convert.ToUInt16(NumericSonicB.Value / 100))(0)
            Form1.EXEStream(&H3C7448 + &H24 * ComboBoxLevelRegular.SelectedIndex + 9) = BitConverter.GetBytes(Convert.ToUInt16(NumericSonicB.Value / 100))(1)
        End If
        ComboBoxLevelRegular_SelectedIndexChanged(sender, e)
    End Sub

    Private Sub NumericSonicC_ValueChanged(sender As Object, e As EventArgs) Handles NumericSonicC.ValueChanged
        If ProgramIsChangingStuff = False Then
            Form1.EXEStream(&H3C7448 + &H24 * ComboBoxLevelRegular.SelectedIndex + 6) = BitConverter.GetBytes(Convert.ToUInt16(NumericSonicC.Value / 100))(0)
            Form1.EXEStream(&H3C7448 + &H24 * ComboBoxLevelRegular.SelectedIndex + 7) = BitConverter.GetBytes(Convert.ToUInt16(NumericSonicC.Value / 100))(1)
        End If
        ComboBoxLevelRegular_SelectedIndexChanged(sender, e)
    End Sub

    Private Sub NumericSonicD_ValueChanged(sender As Object, e As EventArgs) Handles NumericSonicD.ValueChanged
        If ProgramIsChangingStuff = False Then
            Form1.EXEStream(&H3C7448 + &H24 * ComboBoxLevelRegular.SelectedIndex + 4) = BitConverter.GetBytes(Convert.ToUInt16(NumericSonicD.Value / 100))(0)
            Form1.EXEStream(&H3C7448 + &H24 * ComboBoxLevelRegular.SelectedIndex + 5) = BitConverter.GetBytes(Convert.ToUInt16(NumericSonicD.Value / 100))(1)
        End If
        ComboBoxLevelRegular_SelectedIndexChanged(sender, e)
    End Sub

    Private Sub NumericDarkA_ValueChanged(sender As Object, e As EventArgs) Handles NumericDarkA.ValueChanged
        If ProgramIsChangingStuff = False Then
            Form1.EXEStream(&H3C7448 + &H24 * ComboBoxLevelRegular.SelectedIndex + 18) = BitConverter.GetBytes(Convert.ToUInt16(NumericDarkA.Value / 100))(0)
            Form1.EXEStream(&H3C7448 + &H24 * ComboBoxLevelRegular.SelectedIndex + 19) = BitConverter.GetBytes(Convert.ToUInt16(NumericDarkA.Value / 100))(1)
        End If
        ComboBoxLevelRegular_SelectedIndexChanged(sender, e)
    End Sub

    Private Sub NumericDarkB_ValueChanged(sender As Object, e As EventArgs) Handles NumericDarkB.ValueChanged
        If ProgramIsChangingStuff = False Then
            Form1.EXEStream(&H3C7448 + &H24 * ComboBoxLevelRegular.SelectedIndex + 16) = BitConverter.GetBytes(Convert.ToUInt16(NumericDarkB.Value / 100))(0)
            Form1.EXEStream(&H3C7448 + &H24 * ComboBoxLevelRegular.SelectedIndex + 17) = BitConverter.GetBytes(Convert.ToUInt16(NumericDarkB.Value / 100))(1)
        End If
        ComboBoxLevelRegular_SelectedIndexChanged(sender, e)
    End Sub

    Private Sub NumericDarkC_ValueChanged(sender As Object, e As EventArgs) Handles NumericDarkC.ValueChanged
        If ProgramIsChangingStuff = False Then
            Form1.EXEStream(&H3C7448 + &H24 * ComboBoxLevelRegular.SelectedIndex + 14) = BitConverter.GetBytes(Convert.ToUInt16(NumericDarkC.Value / 100))(0)
            Form1.EXEStream(&H3C7448 + &H24 * ComboBoxLevelRegular.SelectedIndex + 15) = BitConverter.GetBytes(Convert.ToUInt16(NumericDarkC.Value / 100))(1)
        End If
        ComboBoxLevelRegular_SelectedIndexChanged(sender, e)
    End Sub

    Private Sub NumericDarkD_ValueChanged(sender As Object, e As EventArgs) Handles NumericDarkD.ValueChanged
        If ProgramIsChangingStuff = False Then
            Form1.EXEStream(&H3C7448 + &H24 * ComboBoxLevelRegular.SelectedIndex + 12) = BitConverter.GetBytes(Convert.ToUInt16(NumericDarkD.Value / 100))(0)
            Form1.EXEStream(&H3C7448 + &H24 * ComboBoxLevelRegular.SelectedIndex + 13) = BitConverter.GetBytes(Convert.ToUInt16(NumericDarkD.Value / 100))(1)
        End If
        ComboBoxLevelRegular_SelectedIndexChanged(sender, e)
    End Sub

    Private Sub NumericRoseA_ValueChanged(sender As Object, e As EventArgs) Handles NumericRoseA.ValueChanged
        If ProgramIsChangingStuff = False Then
            Form1.EXEStream(&H3C7448 + &H24 * ComboBoxLevelRegular.SelectedIndex + 26) = BitConverter.GetBytes(Convert.ToUInt16(NumericRoseA.Value / 100))(0)
            Form1.EXEStream(&H3C7448 + &H24 * ComboBoxLevelRegular.SelectedIndex + 27) = BitConverter.GetBytes(Convert.ToUInt16(NumericRoseA.Value / 100))(1)
        End If
        ComboBoxLevelRegular_SelectedIndexChanged(sender, e)
    End Sub

    Private Sub NumericRoseB_ValueChanged(sender As Object, e As EventArgs) Handles NumericRoseB.ValueChanged
        If ProgramIsChangingStuff = False Then
            Form1.EXEStream(&H3C7448 + &H24 * ComboBoxLevelRegular.SelectedIndex + 24) = BitConverter.GetBytes(Convert.ToUInt16(NumericRoseB.Value / 100))(0)
            Form1.EXEStream(&H3C7448 + &H24 * ComboBoxLevelRegular.SelectedIndex + 25) = BitConverter.GetBytes(Convert.ToUInt16(NumericRoseB.Value / 100))(1)
        End If
        ComboBoxLevelRegular_SelectedIndexChanged(sender, e)
    End Sub

    Private Sub NumericRoseC_ValueChanged(sender As Object, e As EventArgs) Handles NumericRoseC.ValueChanged
        If ProgramIsChangingStuff = False Then
            Form1.EXEStream(&H3C7448 + &H24 * ComboBoxLevelRegular.SelectedIndex + 22) = BitConverter.GetBytes(Convert.ToUInt16(NumericRoseC.Value / 100))(0)
            Form1.EXEStream(&H3C7448 + &H24 * ComboBoxLevelRegular.SelectedIndex + 23) = BitConverter.GetBytes(Convert.ToUInt16(NumericRoseC.Value / 100))(1)
        End If
        ComboBoxLevelRegular_SelectedIndexChanged(sender, e)
    End Sub

    Private Sub NumericRoseD_ValueChanged(sender As Object, e As EventArgs) Handles NumericRoseD.ValueChanged
        If ProgramIsChangingStuff = False Then
            Form1.EXEStream(&H3C7448 + &H24 * ComboBoxLevelRegular.SelectedIndex + 20) = BitConverter.GetBytes(Convert.ToUInt16(NumericRoseD.Value / 100))(0)
            Form1.EXEStream(&H3C7448 + &H24 * ComboBoxLevelRegular.SelectedIndex + 21) = BitConverter.GetBytes(Convert.ToUInt16(NumericRoseD.Value / 100))(1)
        End If
        ComboBoxLevelRegular_SelectedIndexChanged(sender, e)
    End Sub

    Private Sub NumericChaotixA_ValueChanged(sender As Object, e As EventArgs) Handles NumericChaotixA.ValueChanged
        If ProgramIsChangingStuff = False Then
            Form1.EXEStream(&H3C7448 + &H24 * ComboBoxLevelRegular.SelectedIndex + 34) = BitConverter.GetBytes(Convert.ToUInt16(NumericChaotixA.Value / 100))(0)
            Form1.EXEStream(&H3C7448 + &H24 * ComboBoxLevelRegular.SelectedIndex + 35) = BitConverter.GetBytes(Convert.ToUInt16(NumericChaotixA.Value / 100))(1)
        End If
        ComboBoxLevelRegular_SelectedIndexChanged(sender, e)
    End Sub

    Private Sub NumericChaotixB_ValueChanged(sender As Object, e As EventArgs) Handles NumericChaotixB.ValueChanged
        If ProgramIsChangingStuff = False Then
            Form1.EXEStream(&H3C7448 + &H24 * ComboBoxLevelRegular.SelectedIndex + 32) = BitConverter.GetBytes(Convert.ToUInt16(NumericChaotixB.Value / 100))(0)
            Form1.EXEStream(&H3C7448 + &H24 * ComboBoxLevelRegular.SelectedIndex + 33) = BitConverter.GetBytes(Convert.ToUInt16(NumericChaotixB.Value / 100))(1)
        End If
        ComboBoxLevelRegular_SelectedIndexChanged(sender, e)
    End Sub

    Private Sub NumericChaotixC_ValueChanged(sender As Object, e As EventArgs) Handles NumericChaotixC.ValueChanged
        If ProgramIsChangingStuff = False Then
            Form1.EXEStream(&H3C7448 + &H24 * ComboBoxLevelRegular.SelectedIndex + 30) = BitConverter.GetBytes(Convert.ToUInt16(NumericChaotixC.Value / 100))(0)
            Form1.EXEStream(&H3C7448 + &H24 * ComboBoxLevelRegular.SelectedIndex + 31) = BitConverter.GetBytes(Convert.ToUInt16(NumericChaotixC.Value / 100))(1)
        End If
        ComboBoxLevelRegular_SelectedIndexChanged(sender, e)
    End Sub

    Private Sub NumericChaotixD_ValueChanged(sender As Object, e As EventArgs) Handles NumericChaotixD.ValueChanged
        If ProgramIsChangingStuff = False Then
            Form1.EXEStream(&H3C7448 + &H24 * ComboBoxLevelRegular.SelectedIndex + 28) = BitConverter.GetBytes(Convert.ToUInt16(NumericChaotixD.Value / 100))(0)
            Form1.EXEStream(&H3C7448 + &H24 * ComboBoxLevelRegular.SelectedIndex + 29) = BitConverter.GetBytes(Convert.ToUInt16(NumericChaotixD.Value / 100))(1)
        End If
        ComboBoxLevelRegular_SelectedIndexChanged(sender, e)
    End Sub

    Private Sub ComboBoxLevelExtra_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBoxLevelExtra.SelectedIndexChanged
        GroupBox5.Enabled = True
        GroupBox6.Enabled = True

        ProgramIsChangingStuff = True

        NumericSonicED.Value = BitConverter.ToUInt16(Form1.EXEStream, &H3C7668 + &H14 * ComboBoxLevelExtra.SelectedIndex + 4) * 100
        NumericSonicEC.Value = BitConverter.ToUInt16(Form1.EXEStream, &H3C7668 + &H14 * ComboBoxLevelExtra.SelectedIndex + 6) * 100
        NumericSonicEB.Value = BitConverter.ToUInt16(Form1.EXEStream, &H3C7668 + &H14 * ComboBoxLevelExtra.SelectedIndex + 8) * 100
        NumericSonicEA.Value = BitConverter.ToUInt16(Form1.EXEStream, &H3C7668 + &H14 * ComboBoxLevelExtra.SelectedIndex + 10) * 100

        NumericChaotixED.Value = BitConverter.ToUInt16(Form1.EXEStream, &H3C7668 + &H14 * ComboBoxLevelExtra.SelectedIndex + 12) * 100
        NumericChaotixEC.Value = BitConverter.ToUInt16(Form1.EXEStream, &H3C7668 + &H14 * ComboBoxLevelExtra.SelectedIndex + 14) * 100
        NumericChaotixEB.Value = BitConverter.ToUInt16(Form1.EXEStream, &H3C7668 + &H14 * ComboBoxLevelExtra.SelectedIndex + 16) * 100
        NumericChaotixEA.Value = BitConverter.ToUInt16(Form1.EXEStream, &H3C7668 + &H14 * ComboBoxLevelExtra.SelectedIndex + 18) * 100

        ProgramIsChangingStuff = False
    End Sub

    Private Sub NumericSonicEA_ValueChanged(sender As Object, e As EventArgs) Handles NumericSonicEA.ValueChanged
        If ProgramIsChangingStuff = False Then
            Form1.EXEStream(&H3C7668 + &H14 * ComboBoxLevelExtra.SelectedIndex + 10) = BitConverter.GetBytes(Convert.ToUInt16(NumericSonicEA.Value / 100))(0)
            Form1.EXEStream(&H3C7668 + &H14 * ComboBoxLevelExtra.SelectedIndex + 11) = BitConverter.GetBytes(Convert.ToUInt16(NumericSonicEA.Value / 100))(1)
        End If
        ComboBoxLevelExtra_SelectedIndexChanged(sender, e)
    End Sub

    Private Sub NumericSonicEB_ValueChanged(sender As Object, e As EventArgs) Handles NumericSonicEB.ValueChanged
        If ProgramIsChangingStuff = False Then
            Form1.EXEStream(&H3C7668 + &H14 * ComboBoxLevelExtra.SelectedIndex + 8) = BitConverter.GetBytes(Convert.ToUInt16(NumericSonicEB.Value / 100))(0)
            Form1.EXEStream(&H3C7668 + &H14 * ComboBoxLevelExtra.SelectedIndex + 9) = BitConverter.GetBytes(Convert.ToUInt16(NumericSonicEB.Value / 100))(1)
        End If
        ComboBoxLevelExtra_SelectedIndexChanged(sender, e)
    End Sub

    Private Sub NumericSonicEC_ValueChanged(sender As Object, e As EventArgs) Handles NumericSonicEC.ValueChanged
        If ProgramIsChangingStuff = False Then
            Form1.EXEStream(&H3C7668 + &H14 * ComboBoxLevelExtra.SelectedIndex + 6) = BitConverter.GetBytes(Convert.ToUInt16(NumericSonicEC.Value / 100))(0)
            Form1.EXEStream(&H3C7668 + &H14 * ComboBoxLevelExtra.SelectedIndex + 7) = BitConverter.GetBytes(Convert.ToUInt16(NumericSonicEC.Value / 100))(1)
        End If
        ComboBoxLevelExtra_SelectedIndexChanged(sender, e)
    End Sub

    Private Sub NumericSonicED_ValueChanged(sender As Object, e As EventArgs) Handles NumericSonicED.ValueChanged
        If ProgramIsChangingStuff = False Then
            Form1.EXEStream(&H3C7668 + &H14 * ComboBoxLevelExtra.SelectedIndex + 4) = BitConverter.GetBytes(Convert.ToUInt16(NumericSonicED.Value / 100))(0)
            Form1.EXEStream(&H3C7668 + &H14 * ComboBoxLevelExtra.SelectedIndex + 5) = BitConverter.GetBytes(Convert.ToUInt16(NumericSonicED.Value / 100))(1)
        End If
        ComboBoxLevelExtra_SelectedIndexChanged(sender, e)
    End Sub

    Private Sub NumericChaotixEA_ValueChanged(sender As Object, e As EventArgs) Handles NumericChaotixEA.ValueChanged
        If ProgramIsChangingStuff = False Then
            Form1.EXEStream(&H3C7668 + &H14 * ComboBoxLevelExtra.SelectedIndex + 18) = BitConverter.GetBytes(Convert.ToUInt16(NumericChaotixEA.Value / 100))(0)
            Form1.EXEStream(&H3C7668 + &H14 * ComboBoxLevelExtra.SelectedIndex + 19) = BitConverter.GetBytes(Convert.ToUInt16(NumericChaotixEA.Value / 100))(1)
        End If
        ComboBoxLevelExtra_SelectedIndexChanged(sender, e)
    End Sub

    Private Sub NumericChaotixEB_ValueChanged(sender As Object, e As EventArgs) Handles NumericChaotixEB.ValueChanged
        If ProgramIsChangingStuff = False Then
            Form1.EXEStream(&H3C7668 + &H14 * ComboBoxLevelExtra.SelectedIndex + 16) = BitConverter.GetBytes(Convert.ToUInt16(NumericChaotixEB.Value / 100))(0)
            Form1.EXEStream(&H3C7668 + &H14 * ComboBoxLevelExtra.SelectedIndex + 17) = BitConverter.GetBytes(Convert.ToUInt16(NumericChaotixEB.Value / 100))(1)
        End If
        ComboBoxLevelExtra_SelectedIndexChanged(sender, e)
    End Sub

    Private Sub NumericChaotixEC_ValueChanged(sender As Object, e As EventArgs) Handles NumericChaotixEC.ValueChanged
        If ProgramIsChangingStuff = False Then
            Form1.EXEStream(&H3C7668 + &H14 * ComboBoxLevelExtra.SelectedIndex + 14) = BitConverter.GetBytes(Convert.ToUInt16(NumericChaotixEC.Value / 100))(0)
            Form1.EXEStream(&H3C7668 + &H14 * ComboBoxLevelExtra.SelectedIndex + 15) = BitConverter.GetBytes(Convert.ToUInt16(NumericChaotixEC.Value / 100))(1)
        End If
        ComboBoxLevelExtra_SelectedIndexChanged(sender, e)
    End Sub

    Private Sub NumericChaotixED_ValueChanged(sender As Object, e As EventArgs) Handles NumericChaotixED.ValueChanged
        If ProgramIsChangingStuff = False Then
            Form1.EXEStream(&H3C7668 + &H14 * ComboBoxLevelExtra.SelectedIndex + 12) = BitConverter.GetBytes(Convert.ToUInt16(NumericChaotixED.Value / 100))(0)
            Form1.EXEStream(&H3C7668 + &H14 * ComboBoxLevelExtra.SelectedIndex + 13) = BitConverter.GetBytes(Convert.ToUInt16(NumericChaotixED.Value / 100))(1)
        End If
        ComboBoxLevelExtra_SelectedIndexChanged(sender, e)
    End Sub

    Private Sub ComboBoxLevelTime_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBoxLevelTime.SelectedIndexChanged
        GroupBox7.Enabled = True
        GroupBox8.Enabled = True

        ProgramIsChangingStuff = True

        NumericDarkEDMin.Value = Form1.EXEStream(&H3C78E0 + &H14 * ComboBoxLevelTime.SelectedIndex + 4)
        NumericDarkEDSec.Value = Form1.EXEStream(&H3C78E0 + &H14 * ComboBoxLevelTime.SelectedIndex + 5)
        NumericDarkECMin.Value = Form1.EXEStream(&H3C78E0 + &H14 * ComboBoxLevelTime.SelectedIndex + 6)
        NumericDarkECSec.Value = Form1.EXEStream(&H3C78E0 + &H14 * ComboBoxLevelTime.SelectedIndex + 7)
        NumericDarkEBMin.Value = Form1.EXEStream(&H3C78E0 + &H14 * ComboBoxLevelTime.SelectedIndex + 8)
        NumericDarkEBSec.Value = Form1.EXEStream(&H3C78E0 + &H14 * ComboBoxLevelTime.SelectedIndex + 9)
        NumericDarkEAMin.Value = Form1.EXEStream(&H3C78E0 + &H14 * ComboBoxLevelTime.SelectedIndex + 10)
        NumericDarkEASec.Value = Form1.EXEStream(&H3C78E0 + &H14 * ComboBoxLevelTime.SelectedIndex + 11)

        NumericRoseEDMin.Value = Form1.EXEStream(&H3C78E0 + &H14 * ComboBoxLevelTime.SelectedIndex + 12)
        NumericRoseEDSec.Value = Form1.EXEStream(&H3C78E0 + &H14 * ComboBoxLevelTime.SelectedIndex + 13)
        NumericRoseECMin.Value = Form1.EXEStream(&H3C78E0 + &H14 * ComboBoxLevelTime.SelectedIndex + 14)
        NumericRoseECSec.Value = Form1.EXEStream(&H3C78E0 + &H14 * ComboBoxLevelTime.SelectedIndex + 15)
        NumericRoseEBMin.Value = Form1.EXEStream(&H3C78E0 + &H14 * ComboBoxLevelTime.SelectedIndex + 16)
        NumericRoseEBSec.Value = Form1.EXEStream(&H3C78E0 + &H14 * ComboBoxLevelTime.SelectedIndex + 17)
        NumericRoseEAMin.Value = Form1.EXEStream(&H3C78E0 + &H14 * ComboBoxLevelTime.SelectedIndex + 18)
        NumericRoseEASec.Value = Form1.EXEStream(&H3C78E0 + &H14 * ComboBoxLevelTime.SelectedIndex + 19)

        ProgramIsChangingStuff = False
    End Sub

    Private Sub NumericDarkEDMin_ValueChanged(sender As Object, e As EventArgs) Handles NumericDarkEDMin.ValueChanged
        If ProgramIsChangingStuff = False Then
            Form1.EXEStream(&H3C78E0 + &H14 * ComboBoxLevelTime.SelectedIndex + 4) = NumericDarkEDMin.Value
        End If
    End Sub

    Private Sub NumericDarkEDSec_ValueChanged(sender As Object, e As EventArgs) Handles NumericDarkEDSec.ValueChanged
        If ProgramIsChangingStuff = False Then
            Form1.EXEStream(&H3C78E0 + &H14 * ComboBoxLevelTime.SelectedIndex + 5) = NumericDarkEDSec.Value
        End If
    End Sub

    Private Sub NumericDarkECMin_ValueChanged(sender As Object, e As EventArgs) Handles NumericDarkECMin.ValueChanged
        If ProgramIsChangingStuff = False Then
            Form1.EXEStream(&H3C78E0 + &H14 * ComboBoxLevelTime.SelectedIndex + 6) = NumericDarkECMin.Value
        End If
    End Sub

    Private Sub NumericDarkECSec_ValueChanged(sender As Object, e As EventArgs) Handles NumericDarkECSec.ValueChanged
        If ProgramIsChangingStuff = False Then
            Form1.EXEStream(&H3C78E0 + &H14 * ComboBoxLevelTime.SelectedIndex + 7) = NumericDarkECSec.Value
        End If
    End Sub

    Private Sub NumericDarkEBMin_ValueChanged(sender As Object, e As EventArgs) Handles NumericDarkEBMin.ValueChanged
        If ProgramIsChangingStuff = False Then
            Form1.EXEStream(&H3C78E0 + &H14 * ComboBoxLevelTime.SelectedIndex + 8) = NumericDarkEBMin.Value
        End If
    End Sub

    Private Sub NumericDarkEBSec_ValueChanged(sender As Object, e As EventArgs) Handles NumericDarkEBSec.ValueChanged
        If ProgramIsChangingStuff = False Then
            Form1.EXEStream(&H3C78E0 + &H14 * ComboBoxLevelTime.SelectedIndex + 9) = NumericDarkEBSec.Value
        End If
    End Sub

    Private Sub NumericDarkEAMin_ValueChanged(sender As Object, e As EventArgs) Handles NumericDarkEAMin.ValueChanged
        If ProgramIsChangingStuff = False Then
            Form1.EXEStream(&H3C78E0 + &H14 * ComboBoxLevelTime.SelectedIndex + 10) = NumericDarkEAMin.Value
        End If
    End Sub

    Private Sub NumericDarkEASec_ValueChanged(sender As Object, e As EventArgs) Handles NumericDarkEASec.ValueChanged
        If ProgramIsChangingStuff = False Then
            Form1.EXEStream(&H3C78E0 + &H14 * ComboBoxLevelTime.SelectedIndex + 11) = NumericDarkEASec.Value
        End If
    End Sub

    Private Sub NumericRoseEDMin_ValueChanged(sender As Object, e As EventArgs) Handles NumericRoseEDMin.ValueChanged
        If ProgramIsChangingStuff = False Then
            Form1.EXEStream(&H3C78E0 + &H14 * ComboBoxLevelTime.SelectedIndex + 12) = NumericRoseEDMin.Value
        End If
    End Sub

    Private Sub NumericRoseEDSec_ValueChanged(sender As Object, e As EventArgs) Handles NumericRoseEDSec.ValueChanged
        If ProgramIsChangingStuff = False Then
            Form1.EXEStream(&H3C78E0 + &H14 * ComboBoxLevelTime.SelectedIndex + 13) = NumericRoseEDSec.Value
        End If
    End Sub

    Private Sub NumericRoseECMin_ValueChanged(sender As Object, e As EventArgs) Handles NumericRoseECMin.ValueChanged
        If ProgramIsChangingStuff = False Then
            Form1.EXEStream(&H3C78E0 + &H14 * ComboBoxLevelTime.SelectedIndex + 14) = NumericRoseECMin.Value
        End If
    End Sub

    Private Sub NumericRoseECSec_ValueChanged(sender As Object, e As EventArgs) Handles NumericRoseECSec.ValueChanged
        If ProgramIsChangingStuff = False Then
            Form1.EXEStream(&H3C78E0 + &H14 * ComboBoxLevelTime.SelectedIndex + 15) = NumericRoseECSec.Value
        End If
    End Sub

    Private Sub NumericRoseEBMin_ValueChanged(sender As Object, e As EventArgs) Handles NumericRoseEBMin.ValueChanged
        If ProgramIsChangingStuff = False Then
            Form1.EXEStream(&H3C78E0 + &H14 * ComboBoxLevelTime.SelectedIndex + 16) = NumericRoseEBMin.Value
        End If
    End Sub

    Private Sub NumericRoseEBSec_ValueChanged(sender As Object, e As EventArgs) Handles NumericRoseEBSec.ValueChanged
        If ProgramIsChangingStuff = False Then
            Form1.EXEStream(&H3C78E0 + &H14 * ComboBoxLevelTime.SelectedIndex + 17) = NumericRoseEBSec.Value
        End If
    End Sub

    Private Sub NumericRoseEAMin_ValueChanged(sender As Object, e As EventArgs) Handles NumericRoseEAMin.ValueChanged
        If ProgramIsChangingStuff = False Then
            Form1.EXEStream(&H3C78E0 + &H14 * ComboBoxLevelTime.SelectedIndex + 18) = NumericRoseEAMin.Value
        End If
    End Sub

    Private Sub NumericRoseEASec_ValueChanged(sender As Object, e As EventArgs) Handles NumericRoseEASec.ValueChanged
        If ProgramIsChangingStuff = False Then
            Form1.EXEStream(&H3C78E0 + &H14 * ComboBoxLevelTime.SelectedIndex + 19) = NumericRoseEASec.Value
        End If
    End Sub

    Private Sub ComboBoxBoss_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBoxBoss.SelectedIndexChanged
        GroupBox9.Enabled = True
        GroupBox10.Enabled = True
        GroupBox11.Enabled = True
        GroupBox12.Enabled = True

        ProgramIsChangingStuff = True

        NumericBossSonic1.Value = Form1.EXEStream(&H3C7798 + &H24 * ComboBoxBoss.SelectedIndex + 10)
        NumericBossSonic2.Value = Form1.EXEStream(&H3C7798 + &H24 * ComboBoxBoss.SelectedIndex + 11)
        NumericBossSonic3.Value = Form1.EXEStream(&H3C7798 + &H24 * ComboBoxBoss.SelectedIndex + 8)
        NumericBossSonic4.Value = Form1.EXEStream(&H3C7798 + &H24 * ComboBoxBoss.SelectedIndex + 9)
        NumericBossSonic5.Value = Form1.EXEStream(&H3C7798 + &H24 * ComboBoxBoss.SelectedIndex + 6)
        NumericBossSonic6.Value = Form1.EXEStream(&H3C7798 + &H24 * ComboBoxBoss.SelectedIndex + 7)
        NumericBossSonic7.Value = Form1.EXEStream(&H3C7798 + &H24 * ComboBoxBoss.SelectedIndex + 4)
        NumericBossSonic8.Value = Form1.EXEStream(&H3C7798 + &H24 * ComboBoxBoss.SelectedIndex + 5)
        NumericBossDark1.Value = Form1.EXEStream(&H3C7798 + &H24 * ComboBoxBoss.SelectedIndex + 18)
        NumericBossDark2.Value = Form1.EXEStream(&H3C7798 + &H24 * ComboBoxBoss.SelectedIndex + 19)
        NumericBossDark3.Value = Form1.EXEStream(&H3C7798 + &H24 * ComboBoxBoss.SelectedIndex + 16)
        NumericBossDark4.Value = Form1.EXEStream(&H3C7798 + &H24 * ComboBoxBoss.SelectedIndex + 17)
        NumericBossDark5.Value = Form1.EXEStream(&H3C7798 + &H24 * ComboBoxBoss.SelectedIndex + 14)
        NumericBossDark6.Value = Form1.EXEStream(&H3C7798 + &H24 * ComboBoxBoss.SelectedIndex + 15)
        NumericBossDark7.Value = Form1.EXEStream(&H3C7798 + &H24 * ComboBoxBoss.SelectedIndex + 12)
        NumericBossDark8.Value = Form1.EXEStream(&H3C7798 + &H24 * ComboBoxBoss.SelectedIndex + 13)
        NumericBossRose1.Value = Form1.EXEStream(&H3C7798 + &H24 * ComboBoxBoss.SelectedIndex + 26)
        NumericBossRose2.Value = Form1.EXEStream(&H3C7798 + &H24 * ComboBoxBoss.SelectedIndex + 27)
        NumericBossRose3.Value = Form1.EXEStream(&H3C7798 + &H24 * ComboBoxBoss.SelectedIndex + 24)
        NumericBossRose4.Value = Form1.EXEStream(&H3C7798 + &H24 * ComboBoxBoss.SelectedIndex + 25)
        NumericBossRose5.Value = Form1.EXEStream(&H3C7798 + &H24 * ComboBoxBoss.SelectedIndex + 22)
        NumericBossRose6.Value = Form1.EXEStream(&H3C7798 + &H24 * ComboBoxBoss.SelectedIndex + 23)
        NumericBossRose7.Value = Form1.EXEStream(&H3C7798 + &H24 * ComboBoxBoss.SelectedIndex + 20)
        NumericBossRose8.Value = Form1.EXEStream(&H3C7798 + &H24 * ComboBoxBoss.SelectedIndex + 21)
        NumericBossChaotix1.Value = Form1.EXEStream(&H3C7798 + &H24 * ComboBoxBoss.SelectedIndex + 34)
        NumericBossChaotix2.Value = Form1.EXEStream(&H3C7798 + &H24 * ComboBoxBoss.SelectedIndex + 35)
        NumericBossChaotix3.Value = Form1.EXEStream(&H3C7798 + &H24 * ComboBoxBoss.SelectedIndex + 32)
        NumericBossChaotix4.Value = Form1.EXEStream(&H3C7798 + &H24 * ComboBoxBoss.SelectedIndex + 33)
        NumericBossChaotix5.Value = Form1.EXEStream(&H3C7798 + &H24 * ComboBoxBoss.SelectedIndex + 30)
        NumericBossChaotix6.Value = Form1.EXEStream(&H3C7798 + &H24 * ComboBoxBoss.SelectedIndex + 31)
        NumericBossChaotix7.Value = Form1.EXEStream(&H3C7798 + &H24 * ComboBoxBoss.SelectedIndex + 28)
        NumericBossChaotix8.Value = Form1.EXEStream(&H3C7798 + &H24 * ComboBoxBoss.SelectedIndex + 29)

        ProgramIsChangingStuff = False
    End Sub

    Private Sub NumericBossSonic1_ValueChanged(sender As Object, e As EventArgs) Handles NumericBossSonic1.ValueChanged
        If ProgramIsChangingStuff = False Then
            Form1.EXEStream(&H3C7798 + &H24 * ComboBoxLevelTime.SelectedIndex + 10) = NumericBossSonic1.Value
        End If
    End Sub

    Private Sub NumericBossSonic2_ValueChanged(sender As Object, e As EventArgs) Handles NumericBossSonic2.ValueChanged
        If ProgramIsChangingStuff = False Then
            Form1.EXEStream(&H3C7798 + &H24 * ComboBoxLevelTime.SelectedIndex + 11) = NumericBossSonic2.Value
        End If
    End Sub

    Private Sub NumericBossSonic3_ValueChanged(sender As Object, e As EventArgs) Handles NumericBossSonic3.ValueChanged
        If ProgramIsChangingStuff = False Then
            Form1.EXEStream(&H3C7798 + &H24 * ComboBoxLevelTime.SelectedIndex + 8) = NumericBossSonic3.Value
        End If
    End Sub

    Private Sub NumericBossSonic4_ValueChanged(sender As Object, e As EventArgs) Handles NumericBossSonic4.ValueChanged
        If ProgramIsChangingStuff = False Then
            Form1.EXEStream(&H3C7798 + &H24 * ComboBoxLevelTime.SelectedIndex + 9) = NumericBossSonic4.Value
        End If
    End Sub

    Private Sub NumericBossSonic5_ValueChanged(sender As Object, e As EventArgs) Handles NumericBossSonic5.ValueChanged
        If ProgramIsChangingStuff = False Then
            Form1.EXEStream(&H3C7798 + &H24 * ComboBoxLevelTime.SelectedIndex + 6) = NumericBossSonic5.Value
        End If
    End Sub

    Private Sub NumericBossSonic6_ValueChanged(sender As Object, e As EventArgs) Handles NumericBossSonic6.ValueChanged
        If ProgramIsChangingStuff = False Then
            Form1.EXEStream(&H3C7798 + &H24 * ComboBoxLevelTime.SelectedIndex + 7) = NumericBossSonic6.Value
        End If
    End Sub

    Private Sub NumericBossSonic7_ValueChanged(sender As Object, e As EventArgs) Handles NumericBossSonic7.ValueChanged
        If ProgramIsChangingStuff = False Then
            Form1.EXEStream(&H3C7798 + &H24 * ComboBoxLevelTime.SelectedIndex + 4) = NumericBossSonic7.Value
        End If
    End Sub

    Private Sub NumericBossSonic8_ValueChanged(sender As Object, e As EventArgs) Handles NumericBossSonic8.ValueChanged
        If ProgramIsChangingStuff = False Then
            Form1.EXEStream(&H3C7798 + &H24 * ComboBoxLevelTime.SelectedIndex + 5) = NumericBossSonic8.Value
        End If
    End Sub

    Private Sub NumericBossDark1_ValueChanged(sender As Object, e As EventArgs) Handles NumericBossDark1.ValueChanged
        If ProgramIsChangingStuff = False Then
            Form1.EXEStream(&H3C7798 + &H24 * ComboBoxLevelTime.SelectedIndex + 18) = NumericBossDark1.Value
        End If
    End Sub

    Private Sub NumericBossDark2_ValueChanged(sender As Object, e As EventArgs) Handles NumericBossDark2.ValueChanged
        If ProgramIsChangingStuff = False Then
            Form1.EXEStream(&H3C7798 + &H24 * ComboBoxLevelTime.SelectedIndex + 19) = NumericBossDark2.Value
        End If
    End Sub

    Private Sub NumericBossDark3_ValueChanged(sender As Object, e As EventArgs) Handles NumericBossDark3.ValueChanged
        If ProgramIsChangingStuff = False Then
            Form1.EXEStream(&H3C7798 + &H24 * ComboBoxLevelTime.SelectedIndex + 16) = NumericBossDark3.Value
        End If
    End Sub

    Private Sub NumericBossDark4_ValueChanged(sender As Object, e As EventArgs) Handles NumericBossDark4.ValueChanged
        If ProgramIsChangingStuff = False Then
            Form1.EXEStream(&H3C7798 + &H24 * ComboBoxLevelTime.SelectedIndex + 17) = NumericBossDark4.Value
        End If
    End Sub

    Private Sub NumericBossDark5_ValueChanged(sender As Object, e As EventArgs) Handles NumericBossDark5.ValueChanged
        If ProgramIsChangingStuff = False Then
            Form1.EXEStream(&H3C7798 + &H24 * ComboBoxLevelTime.SelectedIndex + 14) = NumericBossDark5.Value
        End If
    End Sub

    Private Sub NumericBossDark6_ValueChanged(sender As Object, e As EventArgs) Handles NumericBossDark6.ValueChanged
        If ProgramIsChangingStuff = False Then
            Form1.EXEStream(&H3C7798 + &H24 * ComboBoxLevelTime.SelectedIndex + 15) = NumericBossDark6.Value
        End If
    End Sub

    Private Sub NumericBossDark7_ValueChanged(sender As Object, e As EventArgs) Handles NumericBossDark7.ValueChanged
        If ProgramIsChangingStuff = False Then
            Form1.EXEStream(&H3C7798 + &H24 * ComboBoxLevelTime.SelectedIndex + 12) = NumericBossDark7.Value
        End If
    End Sub

    Private Sub NumericBossDark8_ValueChanged(sender As Object, e As EventArgs) Handles NumericBossDark8.ValueChanged
        If ProgramIsChangingStuff = False Then
            Form1.EXEStream(&H3C7798 + &H24 * ComboBoxLevelTime.SelectedIndex + 13) = NumericBossDark8.Value
        End If
    End Sub

    Private Sub NumericBossRose1_ValueChanged(sender As Object, e As EventArgs) Handles NumericBossRose1.ValueChanged
        If ProgramIsChangingStuff = False Then
            Form1.EXEStream(&H3C7798 + &H24 * ComboBoxLevelTime.SelectedIndex + 26) = NumericBossRose1.Value
        End If
    End Sub

    Private Sub NumericBossRose2_ValueChanged(sender As Object, e As EventArgs) Handles NumericBossRose2.ValueChanged
        If ProgramIsChangingStuff = False Then
            Form1.EXEStream(&H3C7798 + &H24 * ComboBoxLevelTime.SelectedIndex + 27) = NumericBossRose2.Value
        End If
    End Sub

    Private Sub NumericBossRose3_ValueChanged(sender As Object, e As EventArgs) Handles NumericBossRose3.ValueChanged
        If ProgramIsChangingStuff = False Then
            Form1.EXEStream(&H3C7798 + &H24 * ComboBoxLevelTime.SelectedIndex + 24) = NumericBossRose3.Value
        End If
    End Sub

    Private Sub NumericBossRose4_ValueChanged(sender As Object, e As EventArgs) Handles NumericBossRose4.ValueChanged
        If ProgramIsChangingStuff = False Then
            Form1.EXEStream(&H3C7798 + &H24 * ComboBoxLevelTime.SelectedIndex + 25) = NumericBossRose4.Value
        End If
    End Sub

    Private Sub NumericBossRose5_ValueChanged(sender As Object, e As EventArgs) Handles NumericBossRose5.ValueChanged
        If ProgramIsChangingStuff = False Then
            Form1.EXEStream(&H3C7798 + &H24 * ComboBoxLevelTime.SelectedIndex + 22) = NumericBossRose5.Value
        End If
    End Sub

    Private Sub NumericBossRose6_ValueChanged(sender As Object, e As EventArgs) Handles NumericBossRose6.ValueChanged
        If ProgramIsChangingStuff = False Then
            Form1.EXEStream(&H3C7798 + &H24 * ComboBoxLevelTime.SelectedIndex + 23) = NumericBossRose6.Value
        End If
    End Sub

    Private Sub NumericBossRose7_ValueChanged(sender As Object, e As EventArgs) Handles NumericBossRose7.ValueChanged
        If ProgramIsChangingStuff = False Then
            Form1.EXEStream(&H3C7798 + &H24 * ComboBoxLevelTime.SelectedIndex + 20) = NumericBossRose7.Value
        End If
    End Sub

    Private Sub NumericBossRose8_ValueChanged(sender As Object, e As EventArgs) Handles NumericBossRose8.ValueChanged
        If ProgramIsChangingStuff = False Then
            Form1.EXEStream(&H3C7798 + &H24 * ComboBoxLevelTime.SelectedIndex + 21) = NumericBossRose8.Value
        End If
    End Sub

    Private Sub NumericBossChaotix1_ValueChanged(sender As Object, e As EventArgs) Handles NumericBossChaotix1.ValueChanged
        If ProgramIsChangingStuff = False Then
            Form1.EXEStream(&H3C7798 + &H24 * ComboBoxLevelTime.SelectedIndex + 34) = NumericBossChaotix1.Value
        End If
    End Sub

    Private Sub NumericBossChaotix2_ValueChanged(sender As Object, e As EventArgs) Handles NumericBossChaotix2.ValueChanged
        If ProgramIsChangingStuff = False Then
            Form1.EXEStream(&H3C7798 + &H24 * ComboBoxLevelTime.SelectedIndex + 35) = NumericBossChaotix2.Value
        End If
    End Sub

    Private Sub NumericBossChaotix3_ValueChanged(sender As Object, e As EventArgs) Handles NumericBossChaotix3.ValueChanged
        If ProgramIsChangingStuff = False Then
            Form1.EXEStream(&H3C7798 + &H24 * ComboBoxLevelTime.SelectedIndex + 32) = NumericBossChaotix3.Value
        End If
    End Sub

    Private Sub NumericBossChaotix4_ValueChanged(sender As Object, e As EventArgs) Handles NumericBossChaotix4.ValueChanged
        If ProgramIsChangingStuff = False Then
            Form1.EXEStream(&H3C7798 + &H24 * ComboBoxLevelTime.SelectedIndex + 33) = NumericBossChaotix4.Value
        End If
    End Sub

    Private Sub NumericBossChaotix5_ValueChanged(sender As Object, e As EventArgs) Handles NumericBossChaotix5.ValueChanged
        If ProgramIsChangingStuff = False Then
            Form1.EXEStream(&H3C7798 + &H24 * ComboBoxLevelTime.SelectedIndex + 30) = NumericBossChaotix5.Value
        End If
    End Sub

    Private Sub NumericBossChaotix6_ValueChanged(sender As Object, e As EventArgs) Handles NumericBossChaotix6.ValueChanged
        If ProgramIsChangingStuff = False Then
            Form1.EXEStream(&H3C7798 + &H24 * ComboBoxLevelTime.SelectedIndex + 31) = NumericBossChaotix6.Value
        End If
    End Sub

    Private Sub NumericBossChaotix7_ValueChanged(sender As Object, e As EventArgs) Handles NumericBossChaotix7.ValueChanged
        If ProgramIsChangingStuff = False Then
            Form1.EXEStream(&H3C7798 + &H24 * ComboBoxLevelTime.SelectedIndex + 28) = NumericBossChaotix7.Value
        End If
    End Sub

    Private Sub NumericBossChaotix8_ValueChanged(sender As Object, e As EventArgs) Handles NumericBossChaotix8.ValueChanged
        If ProgramIsChangingStuff = False Then
            Form1.EXEStream(&H3C7798 + &H24 * ComboBoxLevelTime.SelectedIndex + 29) = NumericBossChaotix8.Value
        End If
    End Sub
End Class