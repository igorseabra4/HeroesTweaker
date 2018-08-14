Public Class ChaotixEditor
    Dim MissionTypes() As String = {"Item Collection", "Item Collection (No Robot Detection)", "Clear All Enemies (Timer)",
    "Ring Collection", "Regular Mission (Timer)", "No Frog Detection (Timer)", "No Robot Detection (Timer)"}
    Dim GoalTypes() As String = {"Goal Ring", "Back Ring"}

    Dim ProgramIsChangingStuff As Boolean = False

    Private Sub ChaotixEditor_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ProgramIsChangingStuff = True

        For i = 0 To 6
            ComboBox1.Items.Add(MissionTypes(i))
            ComboBox3.Items.Add(MissionTypes(i))
            ComboBox5.Items.Add(MissionTypes(i))
            ComboBox7.Items.Add(MissionTypes(i))
            ComboBox9.Items.Add(MissionTypes(i))
            ComboBox11.Items.Add(MissionTypes(i))
            ComboBox13.Items.Add(MissionTypes(i))
            ComboBox15.Items.Add(MissionTypes(i))
            ComboBox17.Items.Add(MissionTypes(i))
            ComboBox19.Items.Add(MissionTypes(i))
            ComboBox21.Items.Add(MissionTypes(i))
            ComboBox23.Items.Add(MissionTypes(i))
            ComboBox25.Items.Add(MissionTypes(i))
            ComboBox27.Items.Add(MissionTypes(i))
        Next
        For i = 0 To 1
            ComboBox2.Items.Add(GoalTypes(i))
            ComboBox4.Items.Add(GoalTypes(i))
            ComboBox6.Items.Add(GoalTypes(i))
            ComboBox8.Items.Add(GoalTypes(i))
            ComboBox10.Items.Add(GoalTypes(i))
            ComboBox12.Items.Add(GoalTypes(i))
            ComboBox14.Items.Add(GoalTypes(i))
            ComboBox16.Items.Add(GoalTypes(i))
            ComboBox18.Items.Add(GoalTypes(i))
            ComboBox20.Items.Add(GoalTypes(i))
            ComboBox22.Items.Add(GoalTypes(i))
            ComboBox24.Items.Add(GoalTypes(i))
            ComboBox26.Items.Add(GoalTypes(i))
            ComboBox28.Items.Add(GoalTypes(i))
        Next

        ComboBox1.SelectedIndex = Form1.EXEStream(&H20AC)
        ComboBox3.SelectedIndex = Form1.EXEStream(&H20AD)
        ComboBox5.SelectedIndex = Form1.EXEStream(&H20AE)
        ComboBox7.SelectedIndex = Form1.EXEStream(&H20AF)
        ComboBox9.SelectedIndex = Form1.EXEStream(&H20B0)
        ComboBox11.SelectedIndex = Form1.EXEStream(&H20B1)
        ComboBox13.SelectedIndex = Form1.EXEStream(&H20B2)
        ComboBox15.SelectedIndex = Form1.EXEStream(&H20B3)
        ComboBox17.SelectedIndex = Form1.EXEStream(&H20B4)
        ComboBox19.SelectedIndex = Form1.EXEStream(&H20B5)
        ComboBox21.SelectedIndex = Form1.EXEStream(&H20B6)
        ComboBox23.SelectedIndex = Form1.EXEStream(&H20B7)
        ComboBox25.SelectedIndex = Form1.EXEStream(&H20B8)
        ComboBox27.SelectedIndex = Form1.EXEStream(&H20B9)

        ComboBox2.SelectedIndex = Form1.EXEStream(&H3D0C54)
        ComboBox4.SelectedIndex = Form1.EXEStream(&H3D0C54 + 4)
        ComboBox6.SelectedIndex = Form1.EXEStream(&H3D0C54 + 8)
        ComboBox8.SelectedIndex = Form1.EXEStream(&H3D0C54 + 12)
        ComboBox10.SelectedIndex = Form1.EXEStream(&H3D0C54 + 16)
        ComboBox12.SelectedIndex = Form1.EXEStream(&H3D0C54 + 20)
        ComboBox14.SelectedIndex = Form1.EXEStream(&H3D0C54 + 24)
        ComboBox16.SelectedIndex = Form1.EXEStream(&H3D0C54 + 28)
        ComboBox18.SelectedIndex = Form1.EXEStream(&H3D0C54 + 32)
        ComboBox20.SelectedIndex = Form1.EXEStream(&H3D0C54 + 36)
        ComboBox22.SelectedIndex = Form1.EXEStream(&H3D0C54 + 40)
        ComboBox24.SelectedIndex = Form1.EXEStream(&H3D0C54 + 44)
        ComboBox26.SelectedIndex = Form1.EXEStream(&H3D0C54 + 48)
        ComboBox28.SelectedIndex = Form1.EXEStream(&H3D0C54 + 52)

        NumericUpDown1.Maximum = Decimal.MaxValue
        NumericUpDown2.Maximum = Decimal.MaxValue
        NumericUpDown3.Maximum = Decimal.MaxValue
        NumericUpDown4.Maximum = Decimal.MaxValue
        NumericUpDown5.Maximum = Decimal.MaxValue
        NumericUpDown6.Maximum = Decimal.MaxValue
        NumericUpDown7.Maximum = Decimal.MaxValue
        NumericUpDown8.Maximum = Decimal.MaxValue
        NumericUpDown9.Maximum = Decimal.MaxValue
        NumericUpDown10.Maximum = Decimal.MaxValue
        NumericUpDown11.Maximum = Decimal.MaxValue
        NumericUpDown12.Maximum = Decimal.MaxValue
        NumericUpDown13.Maximum = Decimal.MaxValue
        NumericUpDown14.Maximum = Decimal.MaxValue
        NumericUpDown15.Maximum = Decimal.MaxValue
        NumericUpDown16.Maximum = Decimal.MaxValue
        NumericUpDown17.Maximum = Decimal.MaxValue
        NumericUpDown18.Maximum = Decimal.MaxValue
        NumericUpDown19.Maximum = Decimal.MaxValue
        NumericUpDown20.Maximum = Decimal.MaxValue
        NumericUpDown21.Maximum = Decimal.MaxValue
        NumericUpDown22.Maximum = Decimal.MaxValue
        NumericUpDown23.Maximum = Decimal.MaxValue
        NumericUpDown24.Maximum = Decimal.MaxValue
        NumericUpDown25.Maximum = Decimal.MaxValue
        NumericUpDown26.Maximum = Decimal.MaxValue
        NumericUpDown27.Maximum = Decimal.MaxValue
        NumericUpDown28.Maximum = Decimal.MaxValue

        NumericUpDown1.Minimum = Decimal.MinValue
        NumericUpDown2.Minimum = Decimal.MinValue
        NumericUpDown3.Minimum = Decimal.MinValue
        NumericUpDown4.Minimum = Decimal.MinValue
        NumericUpDown5.Minimum = Decimal.MinValue
        NumericUpDown6.Minimum = Decimal.MinValue
        NumericUpDown7.Minimum = Decimal.MinValue
        NumericUpDown8.Minimum = Decimal.MinValue
        NumericUpDown9.Minimum = Decimal.MinValue
        NumericUpDown10.Minimum = Decimal.MinValue
        NumericUpDown11.Minimum = Decimal.MinValue
        NumericUpDown12.Minimum = Decimal.MinValue
        NumericUpDown13.Minimum = Decimal.MinValue
        NumericUpDown14.Minimum = Decimal.MinValue
        NumericUpDown15.Minimum = Decimal.MinValue
        NumericUpDown16.Minimum = Decimal.MinValue
        NumericUpDown17.Minimum = Decimal.MinValue
        NumericUpDown18.Minimum = Decimal.MinValue
        NumericUpDown19.Minimum = Decimal.MinValue
        NumericUpDown20.Minimum = Decimal.MinValue
        NumericUpDown21.Minimum = Decimal.MinValue
        NumericUpDown22.Minimum = Decimal.MinValue
        NumericUpDown23.Minimum = Decimal.MinValue
        NumericUpDown24.Minimum = Decimal.MinValue
        NumericUpDown25.Minimum = Decimal.MinValue
        NumericUpDown26.Minimum = Decimal.MinValue
        NumericUpDown27.Minimum = Decimal.MinValue
        NumericUpDown28.Minimum = Decimal.MinValue

        NumericUpDown1.Value = BitConverter.ToInt32(Form1.EXEStream, &H4BF420)
        NumericUpDown2.Value = BitConverter.ToInt32(Form1.EXEStream, &H4BF420 + 4)
        NumericUpDown3.Value = BitConverter.ToInt32(Form1.EXEStream, &H4BF420 + 8)
        NumericUpDown4.Value = BitConverter.ToInt32(Form1.EXEStream, &H4BF420 + 12)
        NumericUpDown5.Value = BitConverter.ToInt32(Form1.EXEStream, &H4BF420 + 16)
        NumericUpDown6.Value = BitConverter.ToInt32(Form1.EXEStream, &H4BF420 + 20)
        NumericUpDown7.Value = BitConverter.ToInt32(Form1.EXEStream, &H4BF420 + 24)
        NumericUpDown8.Value = BitConverter.ToInt32(Form1.EXEStream, &H4BF420 + 28)
        NumericUpDown9.Value = BitConverter.ToInt32(Form1.EXEStream, &H4BF420 + 32)
        NumericUpDown10.Value = BitConverter.ToInt32(Form1.EXEStream, &H4BF420 + 36)
        NumericUpDown11.Value = BitConverter.ToInt32(Form1.EXEStream, &H4BF420 + 40)
        NumericUpDown12.Value = BitConverter.ToInt32(Form1.EXEStream, &H4BF420 + 44)
        NumericUpDown13.Value = BitConverter.ToInt32(Form1.EXEStream, &H4BF420 + 48)
        NumericUpDown14.Value = BitConverter.ToInt32(Form1.EXEStream, &H4BF420 + 52)
        NumericUpDown15.Value = BitConverter.ToInt32(Form1.EXEStream, &H4BF420 + 56)
        NumericUpDown16.Value = BitConverter.ToInt32(Form1.EXEStream, &H4BF420 + 60)
        NumericUpDown17.Value = BitConverter.ToInt32(Form1.EXEStream, &H4BF420 + 64)
        NumericUpDown18.Value = BitConverter.ToInt32(Form1.EXEStream, &H4BF420 + 68)
        NumericUpDown19.Value = BitConverter.ToInt32(Form1.EXEStream, &H4BF420 + 72)
        NumericUpDown20.Value = BitConverter.ToInt32(Form1.EXEStream, &H4BF420 + 76)
        NumericUpDown21.Value = BitConverter.ToInt32(Form1.EXEStream, &H4BF420 + 80)
        NumericUpDown22.Value = BitConverter.ToInt32(Form1.EXEStream, &H4BF420 + 84)
        NumericUpDown23.Value = BitConverter.ToInt32(Form1.EXEStream, &H4BF420 + 88)
        NumericUpDown24.Value = BitConverter.ToInt32(Form1.EXEStream, &H4BF420 + 92)
        NumericUpDown25.Value = BitConverter.ToInt32(Form1.EXEStream, &H4BF420 + 96)
        NumericUpDown26.Value = BitConverter.ToInt32(Form1.EXEStream, &H4BF420 + 100)
        NumericUpDown27.Value = BitConverter.ToInt32(Form1.EXEStream, &H4BF420 + 104)
        NumericUpDown28.Value = BitConverter.ToInt32(Form1.EXEStream, &H4BF420 + 108)

        NumericGrandMin.Value = Form1.EXEStream(&H3C6ADD)
        NumericGrandSec.Value = Form1.EXEStream(&H3C6ADE)
        NumericRailMin.Value = Form1.EXEStream(&H3C6AE5)
        NumericRailSec.Value = Form1.EXEStream(&H3C6AE6)
        NumericRail2Min.Value = Form1.EXEStream(&H3C6AED)
        NumericRail2Sec.Value = Form1.EXEStream(&H3C6AEE)
        NumericFrogMin.Value = Form1.EXEStream(&H3C6AF5)
        NumericFrogSec.Value = Form1.EXEStream(&H3C6AF6)
        NumericEggMin.Value = Form1.EXEStream(&H3C6AFD)
        NumericEggSec.Value = Form1.EXEStream(&H3C6AFE)

        NumericCasinoRingNorm.Minimum = Decimal.MinValue
        NumericCasinoRingNorm.Maximum = Decimal.MaxValue
        NumericCasinoRingEx.Minimum = Decimal.MinValue
        NumericCasinoRingEx.Maximum = Decimal.MaxValue

        NumericCasinoRingNorm.Value = BitConverter.ToInt32(Form1.EXEStream, &H1A9DE5)
        NumericCasinoRingEx.Value = BitConverter.ToInt32(Form1.EXEStream, &H1A9DEC)

        ProgramIsChangingStuff = False
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        MessageBox.Show("If set to -1, the game will try to guess the amount of items automatically from the object layout file.")
    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox1.SelectedIndexChanged
        If ProgramIsChangingStuff = False Then
            Form1.EXEStream(&H20AC) = ComboBox1.SelectedIndex
        End If
    End Sub

    Private Sub ComboBox3_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox3.SelectedIndexChanged
        If ProgramIsChangingStuff = False Then
            Form1.EXEStream(&H20AD) = ComboBox3.SelectedIndex
        End If
    End Sub

    Private Sub ComboBox5_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox5.SelectedIndexChanged
        If ProgramIsChangingStuff = False Then
            Form1.EXEStream(&H20AE) = ComboBox5.SelectedIndex
        End If
    End Sub

    Private Sub ComboBox7_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox7.SelectedIndexChanged
        If ProgramIsChangingStuff = False Then
            Form1.EXEStream(&H20AF) = ComboBox7.SelectedIndex
        End If
    End Sub

    Private Sub ComboBox9_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox9.SelectedIndexChanged
        If ProgramIsChangingStuff = False Then
            Form1.EXEStream(&H20B0) = ComboBox9.SelectedIndex
        End If
    End Sub

    Private Sub ComboBox11_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox11.SelectedIndexChanged
        If ProgramIsChangingStuff = False Then
            Form1.EXEStream(&H20B1) = ComboBox11.SelectedIndex
        End If
    End Sub

    Private Sub ComboBox13_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox13.SelectedIndexChanged
        If ProgramIsChangingStuff = False Then
            Form1.EXEStream(&H20B2) = ComboBox13.SelectedIndex
        End If
    End Sub

    Private Sub ComboBox15_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox15.SelectedIndexChanged
        If ProgramIsChangingStuff = False Then
            Form1.EXEStream(&H20B3) = ComboBox15.SelectedIndex
        End If
    End Sub

    Private Sub ComboBox17_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox17.SelectedIndexChanged
        If ProgramIsChangingStuff = False Then
            Form1.EXEStream(&H20B4) = ComboBox17.SelectedIndex
        End If
    End Sub
    Private Sub ComboBox19_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox19.SelectedIndexChanged
        If ProgramIsChangingStuff = False Then
            Form1.EXEStream(&H20B5) = ComboBox19.SelectedIndex
        End If
    End Sub

    Private Sub ComboBox21_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox21.SelectedIndexChanged
        If ProgramIsChangingStuff = False Then
            Form1.EXEStream(&H20B6) = ComboBox21.SelectedIndex
        End If
    End Sub

    Private Sub ComboBox23_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox23.SelectedIndexChanged
        If ProgramIsChangingStuff = False Then
            Form1.EXEStream(&H20B7) = ComboBox23.SelectedIndex
        End If
    End Sub

    Private Sub ComboBox25_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox25.SelectedIndexChanged
        If ProgramIsChangingStuff = False Then
            Form1.EXEStream(&H20B8) = ComboBox25.SelectedIndex
        End If
    End Sub

    Private Sub ComboBox27_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox27.SelectedIndexChanged
        If ProgramIsChangingStuff = False Then
            Form1.EXEStream(&H20B9) = ComboBox1.SelectedIndex
        End If
    End Sub

    Private Sub ComboBox2_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox2.SelectedIndexChanged
        If ProgramIsChangingStuff = False Then
            Form1.EXEStream(&H3D0C54) = ComboBox2.SelectedIndex
        End If
    End Sub

    Private Sub ComboBox4_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox4.SelectedIndexChanged
        If ProgramIsChangingStuff = False Then
            Form1.EXEStream(&H3D0C54 + 4) = ComboBox4.SelectedIndex
        End If
    End Sub

    Private Sub ComboBox6_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox6.SelectedIndexChanged
        If ProgramIsChangingStuff = False Then
            Form1.EXEStream(&H3D0C54 + 8) = ComboBox6.SelectedIndex
        End If
    End Sub

    Private Sub ComboBox8_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox8.SelectedIndexChanged
        If ProgramIsChangingStuff = False Then
            Form1.EXEStream(&H3D0C54 + 12) = ComboBox8.SelectedIndex
        End If
    End Sub

    Private Sub ComboBox10_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox10.SelectedIndexChanged
        If ProgramIsChangingStuff = False Then
            Form1.EXEStream(&H3D0C54 + 16) = ComboBox10.SelectedIndex
        End If
    End Sub

    Private Sub ComboBox12_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox12.SelectedIndexChanged
        If ProgramIsChangingStuff = False Then
            Form1.EXEStream(&H3D0C54 + 20) = ComboBox12.SelectedIndex
        End If
    End Sub

    Private Sub ComboBox14_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox14.SelectedIndexChanged
        If ProgramIsChangingStuff = False Then
            Form1.EXEStream(&H3D0C54 + 24) = ComboBox14.SelectedIndex
        End If
    End Sub

    Private Sub ComboBox16_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox16.SelectedIndexChanged
        If ProgramIsChangingStuff = False Then
            Form1.EXEStream(&H3D0C54 + 28) = ComboBox16.SelectedIndex
        End If
    End Sub

    Private Sub ComboBox18_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox18.SelectedIndexChanged
        If ProgramIsChangingStuff = False Then
            Form1.EXEStream(&H3D0C54 + 32) = ComboBox18.SelectedIndex
        End If
    End Sub

    Private Sub ComboBox20_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox20.SelectedIndexChanged
        If ProgramIsChangingStuff = False Then
            Form1.EXEStream(&H3D0C54 + 36) = ComboBox20.SelectedIndex
        End If
    End Sub

    Private Sub ComboBox22_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox22.SelectedIndexChanged
        If ProgramIsChangingStuff = False Then
            Form1.EXEStream(&H3D0C54 + 40) = ComboBox22.SelectedIndex
        End If
    End Sub

    Private Sub ComboBox24_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox24.SelectedIndexChanged
        If ProgramIsChangingStuff = False Then
            Form1.EXEStream(&H3D0C54 + 44) = ComboBox24.SelectedIndex
        End If
    End Sub

    Private Sub ComboBox26_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox26.SelectedIndexChanged
        If ProgramIsChangingStuff = False Then
            Form1.EXEStream(&H3D0C54 + 48) = ComboBox26.SelectedIndex
        End If
    End Sub

    Private Sub ComboBox28_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox28.SelectedIndexChanged
        If ProgramIsChangingStuff = False Then
            Form1.EXEStream(&H3D0C54 + 52) = ComboBox28.SelectedIndex
        End If
    End Sub

    Private Sub NumericUpDown1_ValueChanged(sender As Object, e As EventArgs) Handles NumericUpDown1.ValueChanged
        If ProgramIsChangingStuff = False Then
            Form1.EXEStream(&H4BF420) = BitConverter.GetBytes(Convert.ToInt32(NumericUpDown1.Value))(0)
            Form1.EXEStream(&H4BF420 + 1) = BitConverter.GetBytes(Convert.ToInt32(NumericUpDown1.Value))(1)
            Form1.EXEStream(&H4BF420 + 2) = BitConverter.GetBytes(Convert.ToInt32(NumericUpDown1.Value))(2)
            Form1.EXEStream(&H4BF420 + 3) = BitConverter.GetBytes(Convert.ToInt32(NumericUpDown1.Value))(3)
        End If
    End Sub

    Private Sub NumericUpDown2_ValueChanged(sender As Object, e As EventArgs) Handles NumericUpDown2.ValueChanged
        If ProgramIsChangingStuff = False Then
            Form1.EXEStream(&H4BF420 + 4) = BitConverter.GetBytes(Convert.ToInt32(NumericUpDown2.Value))(0)
            Form1.EXEStream(&H4BF420 + 5) = BitConverter.GetBytes(Convert.ToInt32(NumericUpDown2.Value))(1)
            Form1.EXEStream(&H4BF420 + 6) = BitConverter.GetBytes(Convert.ToInt32(NumericUpDown2.Value))(2)
            Form1.EXEStream(&H4BF420 + 7) = BitConverter.GetBytes(Convert.ToInt32(NumericUpDown2.Value))(3)
        End If
    End Sub

    Private Sub NumericUpDown3_ValueChanged(sender As Object, e As EventArgs) Handles NumericUpDown3.ValueChanged
        If ProgramIsChangingStuff = False Then
            Form1.EXEStream(&H4BF420 + 8) = BitConverter.GetBytes(Convert.ToInt32(NumericUpDown3.Value))(0)
            Form1.EXEStream(&H4BF420 + 9) = BitConverter.GetBytes(Convert.ToInt32(NumericUpDown3.Value))(1)
            Form1.EXEStream(&H4BF420 + 10) = BitConverter.GetBytes(Convert.ToInt32(NumericUpDown3.Value))(2)
            Form1.EXEStream(&H4BF420 + 11) = BitConverter.GetBytes(Convert.ToInt32(NumericUpDown3.Value))(3)
        End If
    End Sub

    Private Sub NumericUpDown4_ValueChanged(sender As Object, e As EventArgs) Handles NumericUpDown4.ValueChanged
        If ProgramIsChangingStuff = False Then
            Form1.EXEStream(&H4BF420 + 12) = BitConverter.GetBytes(Convert.ToInt32(NumericUpDown4.Value))(0)
            Form1.EXEStream(&H4BF420 + 13) = BitConverter.GetBytes(Convert.ToInt32(NumericUpDown4.Value))(1)
            Form1.EXEStream(&H4BF420 + 14) = BitConverter.GetBytes(Convert.ToInt32(NumericUpDown4.Value))(2)
            Form1.EXEStream(&H4BF420 + 15) = BitConverter.GetBytes(Convert.ToInt32(NumericUpDown4.Value))(3)
        End If
    End Sub

    Private Sub NumericUpDown5_ValueChanged(sender As Object, e As EventArgs) Handles NumericUpDown5.ValueChanged
        If ProgramIsChangingStuff = False Then
            Form1.EXEStream(&H4BF420 + 16) = BitConverter.GetBytes(Convert.ToInt32(NumericUpDown5.Value))(0)
            Form1.EXEStream(&H4BF420 + 17) = BitConverter.GetBytes(Convert.ToInt32(NumericUpDown5.Value))(1)
            Form1.EXEStream(&H4BF420 + 18) = BitConverter.GetBytes(Convert.ToInt32(NumericUpDown5.Value))(2)
            Form1.EXEStream(&H4BF420 + 19) = BitConverter.GetBytes(Convert.ToInt32(NumericUpDown5.Value))(3)
        End If
    End Sub

    Private Sub NumericUpDown6_ValueChanged(sender As Object, e As EventArgs) Handles NumericUpDown6.ValueChanged
        If ProgramIsChangingStuff = False Then
            Form1.EXEStream(&H4BF420 + 20) = BitConverter.GetBytes(Convert.ToInt32(NumericUpDown6.Value))(0)
            Form1.EXEStream(&H4BF420 + 21) = BitConverter.GetBytes(Convert.ToInt32(NumericUpDown6.Value))(1)
            Form1.EXEStream(&H4BF420 + 22) = BitConverter.GetBytes(Convert.ToInt32(NumericUpDown6.Value))(2)
            Form1.EXEStream(&H4BF420 + 23) = BitConverter.GetBytes(Convert.ToInt32(NumericUpDown6.Value))(3)
        End If
    End Sub

    Private Sub NumericUpDown7_ValueChanged(sender As Object, e As EventArgs) Handles NumericUpDown7.ValueChanged
        If ProgramIsChangingStuff = False Then
            Form1.EXEStream(&H4BF420 + 24) = BitConverter.GetBytes(Convert.ToInt32(NumericUpDown7.Value))(0)
            Form1.EXEStream(&H4BF420 + 25) = BitConverter.GetBytes(Convert.ToInt32(NumericUpDown7.Value))(1)
            Form1.EXEStream(&H4BF420 + 26) = BitConverter.GetBytes(Convert.ToInt32(NumericUpDown7.Value))(2)
            Form1.EXEStream(&H4BF420 + 27) = BitConverter.GetBytes(Convert.ToInt32(NumericUpDown7.Value))(3)
        End If
    End Sub

    Private Sub NumericUpDown8_ValueChanged(sender As Object, e As EventArgs) Handles NumericUpDown8.ValueChanged
        If ProgramIsChangingStuff = False Then
            Form1.EXEStream(&H4BF420 + 28) = BitConverter.GetBytes(Convert.ToInt32(NumericUpDown8.Value))(0)
            Form1.EXEStream(&H4BF420 + 29) = BitConverter.GetBytes(Convert.ToInt32(NumericUpDown8.Value))(1)
            Form1.EXEStream(&H4BF420 + 30) = BitConverter.GetBytes(Convert.ToInt32(NumericUpDown8.Value))(2)
            Form1.EXEStream(&H4BF420 + 31) = BitConverter.GetBytes(Convert.ToInt32(NumericUpDown8.Value))(3)
        End If
    End Sub

    Private Sub NumericUpDown9_ValueChanged(sender As Object, e As EventArgs) Handles NumericUpDown9.ValueChanged
        If ProgramIsChangingStuff = False Then
            Form1.EXEStream(&H4BF420 + 32) = BitConverter.GetBytes(Convert.ToInt32(NumericUpDown9.Value))(0)
            Form1.EXEStream(&H4BF420 + 33) = BitConverter.GetBytes(Convert.ToInt32(NumericUpDown9.Value))(1)
            Form1.EXEStream(&H4BF420 + 34) = BitConverter.GetBytes(Convert.ToInt32(NumericUpDown9.Value))(2)
            Form1.EXEStream(&H4BF420 + 35) = BitConverter.GetBytes(Convert.ToInt32(NumericUpDown9.Value))(3)
        End If
    End Sub

    Private Sub NumericUpDown10_ValueChanged(sender As Object, e As EventArgs) Handles NumericUpDown10.ValueChanged
        If ProgramIsChangingStuff = False Then
            Form1.EXEStream(&H4BF420 + 36) = BitConverter.GetBytes(Convert.ToInt32(NumericUpDown10.Value))(0)
            Form1.EXEStream(&H4BF420 + 37) = BitConverter.GetBytes(Convert.ToInt32(NumericUpDown10.Value))(1)
            Form1.EXEStream(&H4BF420 + 38) = BitConverter.GetBytes(Convert.ToInt32(NumericUpDown10.Value))(2)
            Form1.EXEStream(&H4BF420 + 39) = BitConverter.GetBytes(Convert.ToInt32(NumericUpDown10.Value))(3)
        End If
    End Sub

    Private Sub NumericUpDown11_ValueChanged(sender As Object, e As EventArgs) Handles NumericUpDown11.ValueChanged
        If ProgramIsChangingStuff = False Then
            Form1.EXEStream(&H4BF420 + 40) = BitConverter.GetBytes(Convert.ToInt32(NumericUpDown11.Value))(0)
            Form1.EXEStream(&H4BF420 + 41) = BitConverter.GetBytes(Convert.ToInt32(NumericUpDown11.Value))(1)
            Form1.EXEStream(&H4BF420 + 42) = BitConverter.GetBytes(Convert.ToInt32(NumericUpDown11.Value))(2)
            Form1.EXEStream(&H4BF420 + 43) = BitConverter.GetBytes(Convert.ToInt32(NumericUpDown11.Value))(3)
        End If
    End Sub

    Private Sub NumericUpDown12_ValueChanged(sender As Object, e As EventArgs) Handles NumericUpDown12.ValueChanged
        If ProgramIsChangingStuff = False Then
            Form1.EXEStream(&H4BF420 + 44) = BitConverter.GetBytes(Convert.ToInt32(NumericUpDown12.Value))(0)
            Form1.EXEStream(&H4BF420 + 45) = BitConverter.GetBytes(Convert.ToInt32(NumericUpDown12.Value))(1)
            Form1.EXEStream(&H4BF420 + 46) = BitConverter.GetBytes(Convert.ToInt32(NumericUpDown12.Value))(2)
            Form1.EXEStream(&H4BF420 + 47) = BitConverter.GetBytes(Convert.ToInt32(NumericUpDown12.Value))(3)
        End If
    End Sub

    Private Sub NumericUpDown13_ValueChanged(sender As Object, e As EventArgs) Handles NumericUpDown13.ValueChanged
        If ProgramIsChangingStuff = False Then
            Form1.EXEStream(&H4BF420 + 48) = BitConverter.GetBytes(Convert.ToInt32(NumericUpDown13.Value))(0)
            Form1.EXEStream(&H4BF420 + 49) = BitConverter.GetBytes(Convert.ToInt32(NumericUpDown13.Value))(1)
            Form1.EXEStream(&H4BF420 + 50) = BitConverter.GetBytes(Convert.ToInt32(NumericUpDown13.Value))(2)
            Form1.EXEStream(&H4BF420 + 51) = BitConverter.GetBytes(Convert.ToInt32(NumericUpDown13.Value))(3)
        End If
    End Sub

    Private Sub NumericUpDown14_ValueChanged(sender As Object, e As EventArgs) Handles NumericUpDown14.ValueChanged
        If ProgramIsChangingStuff = False Then
            Form1.EXEStream(&H4BF420 + 52) = BitConverter.GetBytes(Convert.ToInt32(NumericUpDown14.Value))(0)
            Form1.EXEStream(&H4BF420 + 53) = BitConverter.GetBytes(Convert.ToInt32(NumericUpDown14.Value))(1)
            Form1.EXEStream(&H4BF420 + 54) = BitConverter.GetBytes(Convert.ToInt32(NumericUpDown14.Value))(2)
            Form1.EXEStream(&H4BF420 + 55) = BitConverter.GetBytes(Convert.ToInt32(NumericUpDown14.Value))(3)
        End If
    End Sub

    Private Sub NumericUpDown15_ValueChanged(sender As Object, e As EventArgs) Handles NumericUpDown15.ValueChanged
        If ProgramIsChangingStuff = False Then
            Form1.EXEStream(&H4BF420 + 56) = BitConverter.GetBytes(Convert.ToInt32(NumericUpDown15.Value))(0)
            Form1.EXEStream(&H4BF420 + 57) = BitConverter.GetBytes(Convert.ToInt32(NumericUpDown15.Value))(1)
            Form1.EXEStream(&H4BF420 + 58) = BitConverter.GetBytes(Convert.ToInt32(NumericUpDown15.Value))(2)
            Form1.EXEStream(&H4BF420 + 59) = BitConverter.GetBytes(Convert.ToInt32(NumericUpDown15.Value))(3)
        End If
    End Sub

    Private Sub NumericUpDown16_ValueChanged(sender As Object, e As EventArgs) Handles NumericUpDown16.ValueChanged
        If ProgramIsChangingStuff = False Then
            Form1.EXEStream(&H4BF420 + 60) = BitConverter.GetBytes(Convert.ToInt32(NumericUpDown16.Value))(0)
            Form1.EXEStream(&H4BF420 + 61) = BitConverter.GetBytes(Convert.ToInt32(NumericUpDown16.Value))(1)
            Form1.EXEStream(&H4BF420 + 62) = BitConverter.GetBytes(Convert.ToInt32(NumericUpDown16.Value))(2)
            Form1.EXEStream(&H4BF420 + 63) = BitConverter.GetBytes(Convert.ToInt32(NumericUpDown16.Value))(3)
        End If
    End Sub

    Private Sub NumericUpDown17_ValueChanged(sender As Object, e As EventArgs) Handles NumericUpDown17.ValueChanged
        If ProgramIsChangingStuff = False Then
            Form1.EXEStream(&H4BF420 + 64) = BitConverter.GetBytes(Convert.ToInt32(NumericUpDown17.Value))(0)
            Form1.EXEStream(&H4BF420 + 65) = BitConverter.GetBytes(Convert.ToInt32(NumericUpDown17.Value))(1)
            Form1.EXEStream(&H4BF420 + 66) = BitConverter.GetBytes(Convert.ToInt32(NumericUpDown17.Value))(2)
            Form1.EXEStream(&H4BF420 + 67) = BitConverter.GetBytes(Convert.ToInt32(NumericUpDown17.Value))(3)
        End If
    End Sub

    Private Sub NumericUpDown18_ValueChanged(sender As Object, e As EventArgs) Handles NumericUpDown18.ValueChanged
        If ProgramIsChangingStuff = False Then
            Form1.EXEStream(&H4BF420 + 68) = BitConverter.GetBytes(Convert.ToInt32(NumericUpDown18.Value))(0)
            Form1.EXEStream(&H4BF420 + 69) = BitConverter.GetBytes(Convert.ToInt32(NumericUpDown18.Value))(1)
            Form1.EXEStream(&H4BF420 + 70) = BitConverter.GetBytes(Convert.ToInt32(NumericUpDown18.Value))(2)
            Form1.EXEStream(&H4BF420 + 71) = BitConverter.GetBytes(Convert.ToInt32(NumericUpDown18.Value))(3)
        End If
    End Sub

    Private Sub NumericUpDown19_ValueChanged(sender As Object, e As EventArgs) Handles NumericUpDown19.ValueChanged
        If ProgramIsChangingStuff = False Then
            Form1.EXEStream(&H4BF420 + 72) = BitConverter.GetBytes(Convert.ToInt32(NumericUpDown19.Value))(0)
            Form1.EXEStream(&H4BF420 + 73) = BitConverter.GetBytes(Convert.ToInt32(NumericUpDown19.Value))(1)
            Form1.EXEStream(&H4BF420 + 74) = BitConverter.GetBytes(Convert.ToInt32(NumericUpDown19.Value))(2)
            Form1.EXEStream(&H4BF420 + 75) = BitConverter.GetBytes(Convert.ToInt32(NumericUpDown19.Value))(3)
        End If
    End Sub

    Private Sub NumericUpDown20_ValueChanged(sender As Object, e As EventArgs) Handles NumericUpDown20.ValueChanged
        If ProgramIsChangingStuff = False Then
            Form1.EXEStream(&H4BF420 + 76) = BitConverter.GetBytes(Convert.ToInt32(NumericUpDown20.Value))(0)
            Form1.EXEStream(&H4BF420 + 77) = BitConverter.GetBytes(Convert.ToInt32(NumericUpDown20.Value))(1)
            Form1.EXEStream(&H4BF420 + 78) = BitConverter.GetBytes(Convert.ToInt32(NumericUpDown20.Value))(2)
            Form1.EXEStream(&H4BF420 + 79) = BitConverter.GetBytes(Convert.ToInt32(NumericUpDown20.Value))(3)
        End If
    End Sub

    Private Sub NumericUpDown21_ValueChanged(sender As Object, e As EventArgs) Handles NumericUpDown21.ValueChanged
        If ProgramIsChangingStuff = False Then
            Form1.EXEStream(&H4BF420 + 80) = BitConverter.GetBytes(Convert.ToInt32(NumericUpDown21.Value))(0)
            Form1.EXEStream(&H4BF420 + 81) = BitConverter.GetBytes(Convert.ToInt32(NumericUpDown21.Value))(1)
            Form1.EXEStream(&H4BF420 + 82) = BitConverter.GetBytes(Convert.ToInt32(NumericUpDown21.Value))(2)
            Form1.EXEStream(&H4BF420 + 83) = BitConverter.GetBytes(Convert.ToInt32(NumericUpDown21.Value))(3)
        End If
    End Sub

    Private Sub NumericUpDown22_ValueChanged(sender As Object, e As EventArgs) Handles NumericUpDown22.ValueChanged
        If ProgramIsChangingStuff = False Then
            Form1.EXEStream(&H4BF420 + 84) = BitConverter.GetBytes(Convert.ToInt32(NumericUpDown22.Value))(0)
            Form1.EXEStream(&H4BF420 + 85) = BitConverter.GetBytes(Convert.ToInt32(NumericUpDown22.Value))(1)
            Form1.EXEStream(&H4BF420 + 86) = BitConverter.GetBytes(Convert.ToInt32(NumericUpDown22.Value))(2)
            Form1.EXEStream(&H4BF420 + 87) = BitConverter.GetBytes(Convert.ToInt32(NumericUpDown22.Value))(3)
        End If
    End Sub

    Private Sub NumericUpDown23_ValueChanged(sender As Object, e As EventArgs) Handles NumericUpDown23.ValueChanged
        If ProgramIsChangingStuff = False Then
            Form1.EXEStream(&H4BF420 + 88) = BitConverter.GetBytes(Convert.ToInt32(NumericUpDown23.Value))(0)
            Form1.EXEStream(&H4BF420 + 89) = BitConverter.GetBytes(Convert.ToInt32(NumericUpDown23.Value))(1)
            Form1.EXEStream(&H4BF420 + 90) = BitConverter.GetBytes(Convert.ToInt32(NumericUpDown23.Value))(2)
            Form1.EXEStream(&H4BF420 + 91) = BitConverter.GetBytes(Convert.ToInt32(NumericUpDown23.Value))(3)
        End If
    End Sub

    Private Sub NumericUpDown24_ValueChanged(sender As Object, e As EventArgs) Handles NumericUpDown24.ValueChanged
        If ProgramIsChangingStuff = False Then
            Form1.EXEStream(&H4BF420 + 92) = BitConverter.GetBytes(Convert.ToInt32(NumericUpDown24.Value))(0)
            Form1.EXEStream(&H4BF420 + 93) = BitConverter.GetBytes(Convert.ToInt32(NumericUpDown24.Value))(1)
            Form1.EXEStream(&H4BF420 + 94) = BitConverter.GetBytes(Convert.ToInt32(NumericUpDown24.Value))(2)
            Form1.EXEStream(&H4BF420 + 95) = BitConverter.GetBytes(Convert.ToInt32(NumericUpDown24.Value))(3)
        End If
    End Sub

    Private Sub NumericUpDown25_ValueChanged(sender As Object, e As EventArgs) Handles NumericUpDown25.ValueChanged
        If ProgramIsChangingStuff = False Then
            Form1.EXEStream(&H4BF420 + 96) = BitConverter.GetBytes(Convert.ToInt32(NumericUpDown25.Value))(0)
            Form1.EXEStream(&H4BF420 + 97) = BitConverter.GetBytes(Convert.ToInt32(NumericUpDown25.Value))(1)
            Form1.EXEStream(&H4BF420 + 98) = BitConverter.GetBytes(Convert.ToInt32(NumericUpDown25.Value))(2)
            Form1.EXEStream(&H4BF420 + 99) = BitConverter.GetBytes(Convert.ToInt32(NumericUpDown25.Value))(3)
        End If
    End Sub

    Private Sub NumericUpDown26_ValueChanged(sender As Object, e As EventArgs) Handles NumericUpDown26.ValueChanged
        If ProgramIsChangingStuff = False Then
            Form1.EXEStream(&H4BF420 + 100) = BitConverter.GetBytes(Convert.ToInt32(NumericUpDown26.Value))(0)
            Form1.EXEStream(&H4BF420 + 101) = BitConverter.GetBytes(Convert.ToInt32(NumericUpDown26.Value))(1)
            Form1.EXEStream(&H4BF420 + 102) = BitConverter.GetBytes(Convert.ToInt32(NumericUpDown26.Value))(2)
            Form1.EXEStream(&H4BF420 + 103) = BitConverter.GetBytes(Convert.ToInt32(NumericUpDown26.Value))(3)
        End If
    End Sub

    Private Sub NumericUpDown27_ValueChanged(sender As Object, e As EventArgs) Handles NumericUpDown27.ValueChanged
        If ProgramIsChangingStuff = False Then
            Form1.EXEStream(&H4BF420 + 104) = BitConverter.GetBytes(Convert.ToInt32(NumericUpDown27.Value))(0)
            Form1.EXEStream(&H4BF420 + 105) = BitConverter.GetBytes(Convert.ToInt32(NumericUpDown27.Value))(1)
            Form1.EXEStream(&H4BF420 + 106) = BitConverter.GetBytes(Convert.ToInt32(NumericUpDown27.Value))(2)
            Form1.EXEStream(&H4BF420 + 107) = BitConverter.GetBytes(Convert.ToInt32(NumericUpDown27.Value))(3)
        End If
    End Sub

    Private Sub NumericUpDown28_ValueChanged(sender As Object, e As EventArgs) Handles NumericUpDown28.ValueChanged
        If ProgramIsChangingStuff = False Then
            Form1.EXEStream(&H4BF420 + 108) = BitConverter.GetBytes(Convert.ToInt32(NumericUpDown28.Value))(0)
            Form1.EXEStream(&H4BF420 + 109) = BitConverter.GetBytes(Convert.ToInt32(NumericUpDown28.Value))(1)
            Form1.EXEStream(&H4BF420 + 110) = BitConverter.GetBytes(Convert.ToInt32(NumericUpDown28.Value))(2)
            Form1.EXEStream(&H4BF420 + 111) = BitConverter.GetBytes(Convert.ToInt32(NumericUpDown28.Value))(3)
        End If
    End Sub

    Private Sub NumericGrandMin_ValueChanged(sender As Object, e As EventArgs) Handles NumericGrandMin.ValueChanged
        If ProgramIsChangingStuff = False Then
            Form1.EXEStream(&H3C6ADD) = NumericGrandMin.Value
        End If
    End Sub

    Private Sub NumericGrandSec_ValueChanged(sender As Object, e As EventArgs) Handles NumericGrandSec.ValueChanged
        If ProgramIsChangingStuff = False Then
            Form1.EXEStream(&H3C6ADE) = NumericGrandSec.Value
        End If
    End Sub

    Private Sub NumericRailMin_ValueChanged(sender As Object, e As EventArgs) Handles NumericRailMin.ValueChanged
        If ProgramIsChangingStuff = False Then
            Form1.EXEStream(&H3C6AE5) = NumericRailMin.Value
        End If
    End Sub

    Private Sub NumericRailSec_ValueChanged(sender As Object, e As EventArgs) Handles NumericRailSec.ValueChanged
        If ProgramIsChangingStuff = False Then
            Form1.EXEStream(&H3C6AE6) = NumericRailSec.Value
        End If
    End Sub

    Private Sub NumericRail2Min_ValueChanged(sender As Object, e As EventArgs) Handles NumericRail2Min.ValueChanged
        If ProgramIsChangingStuff = False Then
            Form1.EXEStream(&H3C6AED) = NumericRail2Min.Value
        End If
    End Sub

    Private Sub NumericRail2Sec_ValueChanged(sender As Object, e As EventArgs) Handles NumericRail2Sec.ValueChanged
        If ProgramIsChangingStuff = False Then
            Form1.EXEStream(&H3C6AEE) = NumericRail2Sec.Value
        End If
    End Sub

    Private Sub NumericFrogMin_ValueChanged(sender As Object, e As EventArgs) Handles NumericFrogMin.ValueChanged
        If ProgramIsChangingStuff = False Then
            Form1.EXEStream(&H3C6AF5) = NumericFrogMin.Value
        End If
    End Sub

    Private Sub NumericFrogSec_ValueChanged(sender As Object, e As EventArgs) Handles NumericFrogSec.ValueChanged
        If ProgramIsChangingStuff = False Then
            Form1.EXEStream(&H3C6AF6) = NumericFrogSec.Value
        End If
    End Sub

    Private Sub NumericEggMin_ValueChanged(sender As Object, e As EventArgs) Handles NumericEggMin.ValueChanged
        If ProgramIsChangingStuff = False Then
            Form1.EXEStream(&H3C6AFD) = NumericEggMin.Value
        End If
    End Sub

    Private Sub NumericEggSec_ValueChanged(sender As Object, e As EventArgs) Handles NumericEggSec.ValueChanged
        If ProgramIsChangingStuff = False Then
            Form1.EXEStream(&H3C6AFE) = NumericEggSec.Value
        End If
    End Sub

    Private Sub NumericCasinoRingNorm_ValueChanged(sender As Object, e As EventArgs) Handles NumericCasinoRingNorm.ValueChanged
        If ProgramIsChangingStuff = False Then
            Form1.EXEStream(&H1A9DE5) = BitConverter.GetBytes(NumericCasinoRingNorm.Value)(0)
            Form1.EXEStream(&H1A9DE5 + 1) = BitConverter.GetBytes(NumericCasinoRingNorm.Value)(1)
            Form1.EXEStream(&H1A9DE5 + 2) = BitConverter.GetBytes(NumericCasinoRingNorm.Value)(2)
            Form1.EXEStream(&H1A9DE5 + 3) = BitConverter.GetBytes(NumericCasinoRingNorm.Value)(3)
        End If
    End Sub

    Private Sub NumericCasinoRingEx_ValueChanged(sender As Object, e As EventArgs) Handles NumericCasinoRingEx.ValueChanged
        If ProgramIsChangingStuff = False Then
            Form1.EXEStream(&H1A9DEC) = BitConverter.GetBytes(NumericCasinoRingEx.Value)(0)
            Form1.EXEStream(&H1A9DEC + 1) = BitConverter.GetBytes(NumericCasinoRingEx.Value)(1)
            Form1.EXEStream(&H1A9DEC + 2) = BitConverter.GetBytes(NumericCasinoRingEx.Value)(2)
            Form1.EXEStream(&H1A9DEC + 3) = BitConverter.GetBytes(NumericCasinoRingEx.Value)(3)
        End If
    End Sub
End Class