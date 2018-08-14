Imports System.IO
Imports System.Math

Public Class SplineEditor
    Dim ProgramIsChangingStuff As Boolean = False

    Public Structure VertexEntry
        Dim UnknownFlags As UInt32
        Dim Float1 As Single
        Dim Float2 As Single
        Dim DistanceToNext As Single
        Dim PositionX As Single
        Dim PositionY As Single
        Dim PositionZ As Single
    End Structure

    Public Structure HeaderEntry
        Dim SplineType As UInt16
        Dim VertexNum As UInt16
        Dim SplineLenght As Single
        Dim PointerToFirst As UInt32
        Dim PointerToType As UInt32
        Dim VertexEntryStream As List(Of VertexEntry)
    End Structure

    Public Structure INISplineHeaderEntry
        Dim LevelName As String
        Dim PointerLocation As UInt32
        Dim AmountOfSplines As UInt32
        Dim SplineHeaderPointerStream As List(Of UInt32)
        Dim HeaderEntryStream As List(Of HeaderEntry)
    End Structure

    Dim INISplineHeaderEntryStream As New List(Of INISplineHeaderEntry)

    Private Sub SplineEditor_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim StringStream = File.ReadAllLines("SplinePointers.ini")

        For Each i As String In StringStream
            Dim TempINISplineHeaderEntry As New INISplineHeaderEntry

            TempINISplineHeaderEntry.LevelName = i.Split("=")(0)
            TempINISplineHeaderEntry.PointerLocation = Convert.ToUInt32(i.Split("=")(1), 16)

            Dim TempSplineHeaderPointerStream As New List(Of UInt32)

            Dim j = 0

                While True
                    Dim TempPointer = BitConverter.ToUInt32(Form1.EXEStream, BitConverter.ToUInt32(Form1.EXEStream, TempINISplineHeaderEntry.PointerLocation) - &H400000 + j)
                    If TempPointer <> 0 Then
                        TempSplineHeaderPointerStream.Add(TempPointer)
                    Else
                        Exit While
                    End If

                    j += 4
                End While

                TempINISplineHeaderEntry.AmountOfSplines = TempSplineHeaderPointerStream.Count
                TempINISplineHeaderEntry.SplineHeaderPointerStream = TempSplineHeaderPointerStream

            If TempINISplineHeaderEntry.PointerLocation = &HCDE98 Then 'Platform with 3 rails
               TempSplineHeaderPointerStream.Clear
                For j = 0 To 2
                    TempSplineHeaderPointerStream.Add(BitConverter.ToUInt32(Form1.EXEStream, BitConverter.ToUInt32(Form1.EXEStream, TempINISplineHeaderEntry.PointerLocation) - &H400000 + j * 4))
                Next
				TempINISplineHeaderEntry.AmountOfSplines = 3
                TempINISplineHeaderEntry.SplineHeaderPointerStream = TempSplineHeaderPointerStream
            End If

            Dim TempHeaderEntryStream As New List(Of HeaderEntry)

            For j = 0 To TempINISplineHeaderEntry.SplineHeaderPointerStream.Count - 1
                Dim TempSplineHeader As New HeaderEntry

                TempSplineHeader.SplineType = BitConverter.ToUInt16(Form1.EXEStream, TempINISplineHeaderEntry.SplineHeaderPointerStream(j) - &H400000)
                TempSplineHeader.VertexNum = BitConverter.ToUInt16(Form1.EXEStream, TempINISplineHeaderEntry.SplineHeaderPointerStream(j) - &H400000 + 2)
                TempSplineHeader.SplineLenght = BitConverter.ToSingle(Form1.EXEStream, TempINISplineHeaderEntry.SplineHeaderPointerStream(j) - &H400000 + 4)
                TempSplineHeader.PointerToFirst = BitConverter.ToUInt32(Form1.EXEStream, TempINISplineHeaderEntry.SplineHeaderPointerStream(j) - &H400000 + 8)
                TempSplineHeader.PointerToType = BitConverter.ToUInt32(Form1.EXEStream, TempINISplineHeaderEntry.SplineHeaderPointerStream(j) - &H400000 + 12)

                TempHeaderEntryStream.Add(TempSplineHeader)
            Next

            TempINISplineHeaderEntry.HeaderEntryStream = TempHeaderEntryStream

            For j = 0 To TempINISplineHeaderEntry.HeaderEntryStream.Count - 1
                Dim TempVertexEntryStream As New List(Of VertexEntry)

                For k = 0 To TempINISplineHeaderEntry.HeaderEntryStream(j).VertexNum - 1
                    Dim TempSplinePoint As New VertexEntry

                    If (TempINISplineHeaderEntry.HeaderEntryStream(j).SplineType = 1) Then

                        TempSplinePoint.UnknownFlags = BitConverter.ToUInt32(Form1.EXEStream, TempINISplineHeaderEntry.HeaderEntryStream(j).PointerToFirst - &H400000 + k * 20)
                        TempSplinePoint.DistanceToNext = BitConverter.ToSingle(Form1.EXEStream, TempINISplineHeaderEntry.HeaderEntryStream(j).PointerToFirst - &H400000 + k * 20 + 4)
                        TempSplinePoint.PositionX = BitConverter.ToSingle(Form1.EXEStream, TempINISplineHeaderEntry.HeaderEntryStream(j).PointerToFirst - &H400000 + k * 20 + 8)
                        TempSplinePoint.PositionY = BitConverter.ToSingle(Form1.EXEStream, TempINISplineHeaderEntry.HeaderEntryStream(j).PointerToFirst - &H400000 + k * 20 + 12)
                        TempSplinePoint.PositionZ = BitConverter.ToSingle(Form1.EXEStream, TempINISplineHeaderEntry.HeaderEntryStream(j).PointerToFirst - &H400000 + k * 20 + 16)

                        TempVertexEntryStream.Add(TempSplinePoint)

                    ElseIf (TempINISplineHeaderEntry.HeaderEntryStream(j).SplineType = 2) Then

                        TempSplinePoint.UnknownFlags = BitConverter.ToUInt32(Form1.EXEStream, TempINISplineHeaderEntry.HeaderEntryStream(j).PointerToFirst - &H400000 + k * &H1C)
                        TempSplinePoint.Float1 = BitConverter.ToUInt32(Form1.EXEStream, TempINISplineHeaderEntry.HeaderEntryStream(j).PointerToFirst - &H400000 + k * &H1C + 4)
                        TempSplinePoint.Float2 = BitConverter.ToUInt32(Form1.EXEStream, TempINISplineHeaderEntry.HeaderEntryStream(j).PointerToFirst - &H400000 + k * &H1C + 8)
                        TempSplinePoint.DistanceToNext = BitConverter.ToSingle(Form1.EXEStream, TempINISplineHeaderEntry.HeaderEntryStream(j).PointerToFirst - &H400000 + k * &H1C + 12)
                        TempSplinePoint.PositionX = BitConverter.ToSingle(Form1.EXEStream, TempINISplineHeaderEntry.HeaderEntryStream(j).PointerToFirst - &H400000 + k * &H1C + 16)
                        TempSplinePoint.PositionY = BitConverter.ToSingle(Form1.EXEStream, TempINISplineHeaderEntry.HeaderEntryStream(j).PointerToFirst - &H400000 + k * &H1C + 20)
                        TempSplinePoint.PositionZ = BitConverter.ToSingle(Form1.EXEStream, TempINISplineHeaderEntry.HeaderEntryStream(j).PointerToFirst - &H400000 + k * &H1C + 24)

                        TempVertexEntryStream.Add(TempSplinePoint)

                    End If
                Next

                Dim TempHeaderEntryStream2 = TempINISplineHeaderEntry.HeaderEntryStream(j)

                TempHeaderEntryStream2.VertexEntryStream = TempVertexEntryStream

                TempINISplineHeaderEntry.HeaderEntryStream(j) = TempHeaderEntryStream2
            Next

            INISplineHeaderEntryStream.Add(TempINISplineHeaderEntry)
        Next


        ComboBoxLevel.Items.Clear()

        For Each i As INISplineHeaderEntry In INISplineHeaderEntryStream
            ComboBoxLevel.Items.Add(i.LevelName)
        Next

    End Sub

    Private Sub ComboBoxLevel_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBoxLevel.SelectedIndexChanged
        ProgramIsChangingStuff = True

        ListBoxVertices.Items.Clear()

        LabelAmount.Text = "Amount: " + INISplineHeaderEntryStream(ComboBoxLevel.SelectedIndex).AmountOfSplines.ToString
        NumericPickSpline.Value = 0
        NumericPickSpline.Maximum = INISplineHeaderEntryStream(ComboBoxLevel.SelectedIndex).AmountOfSplines - 1
        NumericPickSpline_ValueChanged(sender, e)
        ListBoxVertices.SelectedIndex = 0
        ListBoxVertices_SelectedIndexChanged(sender, e)

        ProgramIsChangingStuff = False
    End Sub

    Private Sub NumericPickSpline_ValueChanged(sender As Object, e As EventArgs) Handles NumericPickSpline.ValueChanged
        ProgramIsChangingStuff = True
        LabelLenght.Text = "Lenght: " + INISplineHeaderEntryStream(ComboBoxLevel.SelectedIndex).HeaderEntryStream(NumericPickSpline.Value).SplineLenght.ToString

        If INISplineHeaderEntryStream(ComboBoxLevel.SelectedIndex).HeaderEntryStream(NumericPickSpline.Value).PointerToType = &H433970 Then
            ComboBoxSplineType.SelectedIndex = 0
        ElseIf INISplineHeaderEntryStream(ComboBoxLevel.SelectedIndex).HeaderEntryStream(NumericPickSpline.Value).PointerToType = &H434480 Then
            ComboBoxSplineType.SelectedIndex = 1
        ElseIf iNISplineHeaderEntryStream(ComboBoxLevel.SelectedIndex).HeaderEntryStream(NumericPickSpline.Value).PointerToType = &H4343F0 Then
            ComboBoxSplineType.SelectedIndex = 2
        ElseIf INISplineHeaderEntryStream(ComboBoxLevel.SelectedIndex).HeaderEntryStream(NumericPickSpline.Value).PointerToType = 0 Then
            ComboBoxSplineType.SelectedIndex = 3
        Else
            MessageBox.Show("Apparently you have run into a spline of unknown type " + INISplineHeaderEntryStream(ComboBoxLevel.SelectedIndex).HeaderEntryStream(NumericPickSpline.Value).PointerToType.ToString + ". Please tell igorseabra4 about this :D")
        End If

        ListBoxVertices.Items.Clear()

        For i = 0 To INISplineHeaderEntryStream(ComboBoxLevel.SelectedIndex).HeaderEntryStream(NumericPickSpline.Value).VertexEntryStream.Count - 1
            ListBoxVertices.Items.Add("Vertex " + i.ToString)
        Next

        ButtonExportObj.Enabled = True
        Button1.Enabled = True
        ButtonImportObj.Enabled = True

        ProgramIsChangingStuff = False
    End Sub

    Private Sub ListBoxVertices_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ListBoxVertices.SelectedIndexChanged
        ProgramIsChangingStuff = True

        LabelPosX.Text = "X Position: " + INISplineHeaderEntryStream(ComboBoxLevel.SelectedIndex).HeaderEntryStream(NumericPickSpline.Value).VertexEntryStream(ListBoxVertices.SelectedIndex).PositionX.ToString
        LabelPosY.Text = "Y Position: " + INISplineHeaderEntryStream(ComboBoxLevel.SelectedIndex).HeaderEntryStream(NumericPickSpline.Value).VertexEntryStream(ListBoxVertices.SelectedIndex).PositionY.ToString
        LabelPosZ.Text = "Z Position: " + INISplineHeaderEntryStream(ComboBoxLevel.SelectedIndex).HeaderEntryStream(NumericPickSpline.Value).VertexEntryStream(ListBoxVertices.SelectedIndex).PositionZ.ToString
        LabelDistance.Text = "Distance: " + INISplineHeaderEntryStream(ComboBoxLevel.SelectedIndex).HeaderEntryStream(NumericPickSpline.Value).VertexEntryStream(ListBoxVertices.SelectedIndex).DistanceToNext.ToString
        LabelUnknown.Text = "Unknown: " + INISplineHeaderEntryStream(ComboBoxLevel.SelectedIndex).HeaderEntryStream(NumericPickSpline.Value).VertexEntryStream(ListBoxVertices.SelectedIndex).UnknownFlags.ToString

        ProgramIsChangingStuff = False
    End Sub

    Private Sub ComboBoxSplineType_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBoxSplineType.SelectedIndexChanged
        If ProgramIsChangingStuff = False Then
            If ComboBoxSplineType.SelectedIndex = 0 Then
                Dim Temp = INISplineHeaderEntryStream(ComboBoxLevel.SelectedIndex).HeaderEntryStream(NumericPickSpline.Value)
                Temp.PointerToType = &H433970
                INISplineHeaderEntryStream(ComboBoxLevel.SelectedIndex).HeaderEntryStream(NumericPickSpline.Value) = Temp
            ElseIf ComboBoxSplineType.SelectedIndex = 1 Then
                Dim Temp = INISplineHeaderEntryStream(ComboBoxLevel.SelectedIndex).HeaderEntryStream(NumericPickSpline.Value)
                Temp.PointerToType = &H434480
                INISplineHeaderEntryStream(ComboBoxLevel.SelectedIndex).HeaderEntryStream(NumericPickSpline.Value) = Temp
            ElseIf ComboBoxSplineType.SelectedIndex = 2 Then
                Dim Temp = INISplineHeaderEntryStream(ComboBoxLevel.SelectedIndex).HeaderEntryStream(NumericPickSpline.Value)
                Temp.PointerToType = &H4343F0
                INISplineHeaderEntryStream(ComboBoxLevel.SelectedIndex).HeaderEntryStream(NumericPickSpline.Value) = Temp
            ElseIf ComboBoxSplineType.SelectedIndex = 3 Then
                Dim Temp = INISplineHeaderEntryStream(ComboBoxLevel.SelectedIndex).HeaderEntryStream(NumericPickSpline.Value)
                Temp.PointerToType = 0
                INISplineHeaderEntryStream(ComboBoxLevel.SelectedIndex).HeaderEntryStream(NumericPickSpline.Value) = Temp
            End If
        End If
    End Sub

    Private Sub ButtonImportObj_Click(sender As Object, e As EventArgs) Handles ButtonImportObj.Click
        If SplineImportOBJDialog.ShowDialog() = System.Windows.Forms.DialogResult.OK Then

            Dim StringStream As String() = File.ReadAllLines(SplineImportOBJDialog.FileName)

            Dim VertexStream As New List(Of VertexEntry)

            For Each k As String In StringStream
                If k.Length > 2 Then
                    If k.Substring(0, 2) = "v " Then
                        Dim TempVertex As New VertexEntry
                        TempVertex.PositionX = Convert.ToSingle(k.Split(" ")(k.Split.Count - 3))
                        TempVertex.PositionY = Convert.ToSingle(k.Split(" ")(k.Split.Count - 2))
                        TempVertex.PositionZ = Convert.ToSingle(k.Split(" ")(k.Split.Count - 1))
                        VertexStream.Add(TempVertex)
                    End If
                End If
            Next

            If VertexStream.Count = INISplineHeaderEntryStream(ComboBoxLevel.SelectedIndex).HeaderEntryStream(NumericPickSpline.Value).VertexEntryStream.Count Then
                Dim VertexStream2 As New List(Of VertexEntry)
                Dim TotalLenght As Single = 0

                For k = 0 To VertexStream.Count - 1
                    Dim TempVertex = VertexStream(k)
                    If k <> VertexStream.Count - 1 Then
                        TempVertex.DistanceToNext = Sqrt((VertexStream(k + 1).PositionX - VertexStream(k).PositionX) ^ 2 + (VertexStream(k + 1).PositionY - VertexStream(k).PositionY) ^ 2 + (VertexStream(k + 1).PositionZ - VertexStream(k).PositionZ) ^ 2)
                        TotalLenght += TempVertex.DistanceToNext
                    Else
                        TempVertex.DistanceToNext = 0
                    End If
                    VertexStream2.Add(TempVertex)
                Next

                Dim Temp = INISplineHeaderEntryStream(ComboBoxLevel.SelectedIndex).HeaderEntryStream(NumericPickSpline.Value)
                Temp.VertexEntryStream = VertexStream2
                Temp.SplineLenght = TotalLenght
                INISplineHeaderEntryStream(ComboBoxLevel.SelectedIndex).HeaderEntryStream(NumericPickSpline.Value) = Temp

                Dim i = INISplineHeaderEntryStream(ComboBoxLevel.SelectedIndex)
                Dim j = NumericPickSpline.Value

                Form1.EXEStream(BitConverter.ToUInt32(Form1.EXEStream, i.PointerLocation) - &H400000 + j * 4 + 0) = BitConverter.GetBytes(i.SplineHeaderPointerStream(j))(0)
                Form1.EXEStream(BitConverter.ToUInt32(Form1.EXEStream, i.PointerLocation) - &H400000 + j * 4 + 1) = BitConverter.GetBytes(i.SplineHeaderPointerStream(j))(1)
                Form1.EXEStream(BitConverter.ToUInt32(Form1.EXEStream, i.PointerLocation) - &H400000 + j * 4 + 2) = BitConverter.GetBytes(i.SplineHeaderPointerStream(j))(2)
                Form1.EXEStream(BitConverter.ToUInt32(Form1.EXEStream, i.PointerLocation) - &H400000 + j * 4 + 3) = BitConverter.GetBytes(i.SplineHeaderPointerStream(j))(3)

                Form1.EXEStream(i.SplineHeaderPointerStream(j) - &H400000 + 0) = 1
                Form1.EXEStream(i.SplineHeaderPointerStream(j) - &H400000 + 1) = 0
                Form1.EXEStream(i.SplineHeaderPointerStream(j) - &H400000 + 2) = BitConverter.GetBytes(i.HeaderEntryStream(j).VertexNum)(0)
                Form1.EXEStream(i.SplineHeaderPointerStream(j) - &H400000 + 3) = BitConverter.GetBytes(i.HeaderEntryStream(j).VertexNum)(1)
                Form1.EXEStream(i.SplineHeaderPointerStream(j) - &H400000 + 4) = BitConverter.GetBytes(i.HeaderEntryStream(j).SplineLenght)(0)
                Form1.EXEStream(i.SplineHeaderPointerStream(j) - &H400000 + 5) = BitConverter.GetBytes(i.HeaderEntryStream(j).SplineLenght)(1)
                Form1.EXEStream(i.SplineHeaderPointerStream(j) - &H400000 + 6) = BitConverter.GetBytes(i.HeaderEntryStream(j).SplineLenght)(2)
                Form1.EXEStream(i.SplineHeaderPointerStream(j) - &H400000 + 7) = BitConverter.GetBytes(i.HeaderEntryStream(j).SplineLenght)(3)
                Form1.EXEStream(i.SplineHeaderPointerStream(j) - &H400000 + 8) = BitConverter.GetBytes(i.HeaderEntryStream(j).PointerToFirst)(0)
                Form1.EXEStream(i.SplineHeaderPointerStream(j) - &H400000 + 9) = BitConverter.GetBytes(i.HeaderEntryStream(j).PointerToFirst)(1)
                Form1.EXEStream(i.SplineHeaderPointerStream(j) - &H400000 + 10) = BitConverter.GetBytes(i.HeaderEntryStream(j).PointerToFirst)(2)
                Form1.EXEStream(i.SplineHeaderPointerStream(j) - &H400000 + 11) = BitConverter.GetBytes(i.HeaderEntryStream(j).PointerToFirst)(3)
                Form1.EXEStream(i.SplineHeaderPointerStream(j) - &H400000 + 12) = BitConverter.GetBytes(i.HeaderEntryStream(j).PointerToType)(0)
                Form1.EXEStream(i.SplineHeaderPointerStream(j) - &H400000 + 13) = BitConverter.GetBytes(i.HeaderEntryStream(j).PointerToType)(1)
                Form1.EXEStream(i.SplineHeaderPointerStream(j) - &H400000 + 14) = BitConverter.GetBytes(i.HeaderEntryStream(j).PointerToType)(2)
                Form1.EXEStream(i.SplineHeaderPointerStream(j) - &H400000 + 15) = BitConverter.GetBytes(i.HeaderEntryStream(j).PointerToType)(3)

                For k = 0 To i.HeaderEntryStream(j).VertexEntryStream.Count - 1
                    Form1.EXEStream(i.HeaderEntryStream(j).PointerToFirst - &H400000 + k * 20 + 0) = BitConverter.GetBytes(i.HeaderEntryStream(j).VertexEntryStream(k).UnknownFlags)(0)
                    Form1.EXEStream(i.HeaderEntryStream(j).PointerToFirst - &H400000 + k * 20 + 1) = BitConverter.GetBytes(i.HeaderEntryStream(j).VertexEntryStream(k).UnknownFlags)(1)
                    Form1.EXEStream(i.HeaderEntryStream(j).PointerToFirst - &H400000 + k * 20 + 2) = BitConverter.GetBytes(i.HeaderEntryStream(j).VertexEntryStream(k).UnknownFlags)(2)
                    Form1.EXEStream(i.HeaderEntryStream(j).PointerToFirst - &H400000 + k * 20 + 3) = BitConverter.GetBytes(i.HeaderEntryStream(j).VertexEntryStream(k).UnknownFlags)(3)
                    Form1.EXEStream(i.HeaderEntryStream(j).PointerToFirst - &H400000 + k * 20 + 4) = BitConverter.GetBytes(i.HeaderEntryStream(j).VertexEntryStream(k).DistanceToNext)(0)
                    Form1.EXEStream(i.HeaderEntryStream(j).PointerToFirst - &H400000 + k * 20 + 5) = BitConverter.GetBytes(i.HeaderEntryStream(j).VertexEntryStream(k).DistanceToNext)(1)
                    Form1.EXEStream(i.HeaderEntryStream(j).PointerToFirst - &H400000 + k * 20 + 6) = BitConverter.GetBytes(i.HeaderEntryStream(j).VertexEntryStream(k).DistanceToNext)(2)
                    Form1.EXEStream(i.HeaderEntryStream(j).PointerToFirst - &H400000 + k * 20 + 7) = BitConverter.GetBytes(i.HeaderEntryStream(j).VertexEntryStream(k).DistanceToNext)(3)
                    Form1.EXEStream(i.HeaderEntryStream(j).PointerToFirst - &H400000 + k * 20 + 8) = BitConverter.GetBytes(i.HeaderEntryStream(j).VertexEntryStream(k).PositionX)(0)
                    Form1.EXEStream(i.HeaderEntryStream(j).PointerToFirst - &H400000 + k * 20 + 9) = BitConverter.GetBytes(i.HeaderEntryStream(j).VertexEntryStream(k).PositionX)(1)
                    Form1.EXEStream(i.HeaderEntryStream(j).PointerToFirst - &H400000 + k * 20 + 10) = BitConverter.GetBytes(i.HeaderEntryStream(j).VertexEntryStream(k).PositionX)(2)
                    Form1.EXEStream(i.HeaderEntryStream(j).PointerToFirst - &H400000 + k * 20 + 11) = BitConverter.GetBytes(i.HeaderEntryStream(j).VertexEntryStream(k).PositionX)(3)
                    Form1.EXEStream(i.HeaderEntryStream(j).PointerToFirst - &H400000 + k * 20 + 12) = BitConverter.GetBytes(i.HeaderEntryStream(j).VertexEntryStream(k).PositionY)(0)
                    Form1.EXEStream(i.HeaderEntryStream(j).PointerToFirst - &H400000 + k * 20 + 13) = BitConverter.GetBytes(i.HeaderEntryStream(j).VertexEntryStream(k).PositionY)(1)
                    Form1.EXEStream(i.HeaderEntryStream(j).PointerToFirst - &H400000 + k * 20 + 14) = BitConverter.GetBytes(i.HeaderEntryStream(j).VertexEntryStream(k).PositionY)(2)
                    Form1.EXEStream(i.HeaderEntryStream(j).PointerToFirst - &H400000 + k * 20 + 15) = BitConverter.GetBytes(i.HeaderEntryStream(j).VertexEntryStream(k).PositionY)(3)
                    Form1.EXEStream(i.HeaderEntryStream(j).PointerToFirst - &H400000 + k * 20 + 16) = BitConverter.GetBytes(i.HeaderEntryStream(j).VertexEntryStream(k).PositionZ)(0)
                    Form1.EXEStream(i.HeaderEntryStream(j).PointerToFirst - &H400000 + k * 20 + 17) = BitConverter.GetBytes(i.HeaderEntryStream(j).VertexEntryStream(k).PositionZ)(1)
                    Form1.EXEStream(i.HeaderEntryStream(j).PointerToFirst - &H400000 + k * 20 + 18) = BitConverter.GetBytes(i.HeaderEntryStream(j).VertexEntryStream(k).PositionZ)(2)
                    Form1.EXEStream(i.HeaderEntryStream(j).PointerToFirst - &H400000 + k * 20 + 19) = BitConverter.GetBytes(i.HeaderEntryStream(j).VertexEntryStream(k).PositionZ)(3)
                Next
            Else
                MessageBox.Show("Imported OBJ must have the same amount of vertices as the spline.")
            End If
        End If
    End Sub

    Private Sub ButtonExportObj_Click(sender As Object, e As EventArgs) Handles ButtonExportObj.Click
        If SplineExportOBJDialog.ShowDialog() = System.Windows.Forms.DialogResult.OK Then

            Dim SplineOBJWriter As New StreamWriter(New FileStream(SplineExportOBJDialog.FileName, FileMode.Create))

            SplineOBJWriter.WriteLine("#Spline exported from HeroesTweaker")
            SplineOBJWriter.WriteLine()

            For Each i As VertexEntry In INISplineHeaderEntryStream(ComboBoxLevel.SelectedIndex).HeaderEntryStream(NumericPickSpline.Value).VertexEntryStream
                SplineOBJWriter.WriteLine("v " + i.PositionX.ToString + " " + i.PositionY.ToString + " " + i.PositionZ.ToString)
            Next

            SplineOBJWriter.WriteLine()

            Dim Everynumber As String = ""

            For i = 1 To INISplineHeaderEntryStream(ComboBoxLevel.SelectedIndex).HeaderEntryStream(NumericPickSpline.Value).VertexEntryStream.Count
                Everynumber += " " + i.ToString
            Next

            SplineOBJWriter.WriteLine("g " + INISplineHeaderEntryStream(ComboBoxLevel.SelectedIndex).LevelName + NumericPickSpline.Value.ToString)
            SplineOBJWriter.WriteLine("l" + Everynumber.ToArray)

            SplineOBJWriter.Close()
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If SplineExportOBJDialog.ShowDialog() = System.Windows.Forms.DialogResult.OK Then

            Dim SplineOBJWriter As New StreamWriter(New FileStream(SplineExportOBJDialog.FileName, FileMode.Create))

            SplineOBJWriter.WriteLine("#Splines exported from HeroesTweaker")
            SplineOBJWriter.WriteLine()

            Dim k = 1

            For j = 0 To INISplineHeaderEntryStream(ComboBoxLevel.SelectedIndex).HeaderEntryStream.Count - 1
                For Each i As VertexEntry In INISplineHeaderEntryStream(ComboBoxLevel.SelectedIndex).HeaderEntryStream(j).VertexEntryStream
                    SplineOBJWriter.WriteLine("v " + i.PositionX.ToString + " " + i.PositionY.ToString + " " + i.PositionZ.ToString)
                Next

                SplineOBJWriter.WriteLine()

                Dim Everynumber As String = ""

                For l = 1 To INISplineHeaderEntryStream(ComboBoxLevel.SelectedIndex).HeaderEntryStream(j).VertexEntryStream.Count
                    Everynumber += " " + k.ToString
                    k += 1
                Next

                SplineOBJWriter.WriteLine("g " + INISplineHeaderEntryStream(ComboBoxLevel.SelectedIndex).LevelName + j.ToString)
                SplineOBJWriter.WriteLine("l" + Everynumber.ToArray)
            Next

            SplineOBJWriter.Close()
        End If
    End Sub
End Class