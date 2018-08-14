Imports System.IO
Imports System.Math

Public Class BobsledEditor
    'Dim ProgramIsChangingStuff As Boolean = False

    Public Structure VertexEntry
        Dim PositionX As Single
        Dim PositionY As Single
        Dim PositionZ As Single
    End Structure

    Public Structure HeaderEntry
        Dim VertexNum As UInt16
        Dim SplineLenght As Single
        Dim PointerToFirst As UInt32
        Dim VertexEntryStream As List(Of VertexEntry)
    End Structure

    Public Structure INISplineHeaderEntry
        Dim LevelName As String
        Dim PointerLocation As UInt32
        Dim HeaderPointer() As UInt32
        Dim HeaderEntry() As HeaderEntry
    End Structure

    Dim INISplineHeaderEntryStream As New List(Of INISplineHeaderEntry)

    Private Sub SplineEditor_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ComboBoxSeasideDenied.SelectedIndex = Form1.EXEStream(&H9E49C)

        Dim StringStream = File.ReadAllLines("BobsledPointers.ini")

        For Each i As String In StringStream
            Dim TempINISplineHeaderEntry As New INISplineHeaderEntry

            TempINISplineHeaderEntry.LevelName = i.Split("=")(0)
            TempINISplineHeaderEntry.PointerLocation = Convert.ToUInt32(i.Split("=")(1), 16)

            ReDim TempINISplineHeaderEntry.HeaderPointer(1)
            ReDim TempINISplineHeaderEntry.HeaderEntry(1)

            TempINISplineHeaderEntry.HeaderPointer(0) = BitConverter.ToUInt32(Form1.EXEStream, TempINISplineHeaderEntry.PointerLocation)
            TempINISplineHeaderEntry.HeaderPointer(1) = BitConverter.ToUInt32(Form1.EXEStream, TempINISplineHeaderEntry.PointerLocation + 4)

            For j = 0 To 1
                TempINISplineHeaderEntry.HeaderEntry(j).VertexNum = BitConverter.ToUInt16(Form1.EXEStream, TempINISplineHeaderEntry.HeaderPointer(j) - &H400000 + 2)
                TempINISplineHeaderEntry.HeaderEntry(j).SplineLenght = BitConverter.ToSingle(Form1.EXEStream, TempINISplineHeaderEntry.HeaderPointer(j) - &H400000 + 4)
                TempINISplineHeaderEntry.HeaderEntry(j).PointerToFirst = BitConverter.ToUInt32(Form1.EXEStream, TempINISplineHeaderEntry.HeaderPointer(j) - &H400000 + 8)

                Dim TempVertexEntryStream As New List(Of VertexEntry)

                For k = 0 To TempINISplineHeaderEntry.HeaderEntry(j).VertexNum - 1
                    Dim TempSplinePoint As New VertexEntry

                    TempSplinePoint.PositionX = BitConverter.ToSingle(Form1.EXEStream, TempINISplineHeaderEntry.HeaderEntry(j).PointerToFirst - &H400000 + k * 12)
                    TempSplinePoint.PositionY = BitConverter.ToSingle(Form1.EXEStream, TempINISplineHeaderEntry.HeaderEntry(j).PointerToFirst - &H400000 + k * 12 + 4)
                    TempSplinePoint.PositionZ = BitConverter.ToSingle(Form1.EXEStream, TempINISplineHeaderEntry.HeaderEntry(j).PointerToFirst - &H400000 + k * 12 + 8)

                    TempVertexEntryStream.Add(TempSplinePoint)
                Next

                TempINISplineHeaderEntry.HeaderEntry(j).VertexEntryStream = TempVertexEntryStream
            Next

            INISplineHeaderEntryStream.Add(TempINISplineHeaderEntry)
        Next

        ComboBoxLevel.Items.Clear()

        For Each i As INISplineHeaderEntry In INISplineHeaderEntryStream
            ComboBoxLevel.Items.Add(i.LevelName)
        Next
    End Sub

    Private Sub ComboBoxLevel_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBoxLevel.SelectedIndexChanged
        ListBoxVertices.Items.Clear()

        ComboBoxPickSpline.SelectedIndex = 0
        ComboBoxPickSpline_SelectedIndexChanged(sender, e)
        ListBoxVertices.SelectedIndex = 0
        ListBoxVertices_SelectedIndexChanged(sender, e)

        LabelAmount.Text = "Amount: " + INISplineHeaderEntryStream(ComboBoxLevel.SelectedIndex).HeaderEntry(ComboBoxPickSpline.SelectedIndex).VertexNum.ToString
        LabelLenght.Text = "Lenght: " + INISplineHeaderEntryStream(ComboBoxLevel.SelectedIndex).HeaderEntry(ComboBoxPickSpline.SelectedIndex).SplineLenght.ToString
    End Sub

    Private Sub ListBoxVertices_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ListBoxVertices.SelectedIndexChanged
        LabelPosX.Text = "X Position: " + INISplineHeaderEntryStream(ComboBoxLevel.SelectedIndex).HeaderEntry(ComboBoxPickSpline.SelectedIndex).VertexEntryStream(ListBoxVertices.SelectedIndex).PositionX.ToString
        LabelPosY.Text = "Y Position: " + INISplineHeaderEntryStream(ComboBoxLevel.SelectedIndex).HeaderEntry(ComboBoxPickSpline.SelectedIndex).VertexEntryStream(ListBoxVertices.SelectedIndex).PositionY.ToString
        LabelPosZ.Text = "Z Position: " + INISplineHeaderEntryStream(ComboBoxLevel.SelectedIndex).HeaderEntry(ComboBoxPickSpline.SelectedIndex).VertexEntryStream(ListBoxVertices.SelectedIndex).PositionZ.ToString
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

            If VertexStream.Count = INISplineHeaderEntryStream(ComboBoxLevel.SelectedIndex).HeaderEntry(ComboBoxPickSpline.SelectedIndex).VertexEntryStream.Count Then
                Dim VertexStream2 As New List(Of VertexEntry)
                Dim TotalLenght As Single = 0

                For k = 0 To VertexStream.Count - 1
                    Dim TempVertex = VertexStream(k)
                    If k <> VertexStream.Count - 1 Then
                        Dim DistanceToNext = Sqrt((VertexStream(k + 1).PositionX - VertexStream(k).PositionX) ^ 2 + (VertexStream(k + 1).PositionY - VertexStream(k).PositionY) ^ 2 + (VertexStream(k + 1).PositionZ - VertexStream(k).PositionZ) ^ 2)
                        TotalLenght += DistanceToNext
                    End If
                    VertexStream2.Add(TempVertex)
                Next

                Dim Temp = INISplineHeaderEntryStream(ComboBoxLevel.SelectedIndex).HeaderEntry(ComboBoxPickSpline.SelectedIndex)
                Temp.VertexEntryStream = VertexStream2
                Temp.SplineLenght = TotalLenght
                INISplineHeaderEntryStream(ComboBoxLevel.SelectedIndex).HeaderEntry(ComboBoxPickSpline.SelectedIndex) = Temp

                Dim i = INISplineHeaderEntryStream(ComboBoxLevel.SelectedIndex)
                For j = 0 To 1
                    Form1.EXEStream(BitConverter.ToUInt32(Form1.EXEStream, i.PointerLocation) - &H400000 + j * 4 + 0) = BitConverter.GetBytes(i.HeaderPointer(j))(0)
                    Form1.EXEStream(BitConverter.ToUInt32(Form1.EXEStream, i.PointerLocation) - &H400000 + j * 4 + 1) = BitConverter.GetBytes(i.HeaderPointer(j))(1)
                    Form1.EXEStream(BitConverter.ToUInt32(Form1.EXEStream, i.PointerLocation) - &H400000 + j * 4 + 2) = BitConverter.GetBytes(i.HeaderPointer(j))(2)
                    Form1.EXEStream(BitConverter.ToUInt32(Form1.EXEStream, i.PointerLocation) - &H400000 + j * 4 + 3) = BitConverter.GetBytes(i.HeaderPointer(j))(3)

                    Form1.EXEStream(i.HeaderPointer(j) - &H400000 + 0) = 0
                    Form1.EXEStream(i.HeaderPointer(j) - &H400000 + 1) = 0
                    Form1.EXEStream(i.HeaderPointer(j) - &H400000 + 2) = BitConverter.GetBytes(i.HeaderEntry(j).VertexNum)(0)
                    Form1.EXEStream(i.HeaderPointer(j) - &H400000 + 3) = BitConverter.GetBytes(i.HeaderEntry(j).VertexNum)(1)
                    Form1.EXEStream(i.HeaderPointer(j) - &H400000 + 4) = BitConverter.GetBytes(i.HeaderEntry(j).SplineLenght)(0)
                    Form1.EXEStream(i.HeaderPointer(j) - &H400000 + 5) = BitConverter.GetBytes(i.HeaderEntry(j).SplineLenght)(1)
                    Form1.EXEStream(i.HeaderPointer(j) - &H400000 + 6) = BitConverter.GetBytes(i.HeaderEntry(j).SplineLenght)(2)
                    Form1.EXEStream(i.HeaderPointer(j) - &H400000 + 7) = BitConverter.GetBytes(i.HeaderEntry(j).SplineLenght)(3)
                    Form1.EXEStream(i.HeaderPointer(j) - &H400000 + 8) = BitConverter.GetBytes(i.HeaderEntry(j).PointerToFirst)(0)
                    Form1.EXEStream(i.HeaderPointer(j) - &H400000 + 9) = BitConverter.GetBytes(i.HeaderEntry(j).PointerToFirst)(1)
                    Form1.EXEStream(i.HeaderPointer(j) - &H400000 + 10) = BitConverter.GetBytes(i.HeaderEntry(j).PointerToFirst)(2)
                    Form1.EXEStream(i.HeaderPointer(j) - &H400000 + 11) = BitConverter.GetBytes(i.HeaderEntry(j).PointerToFirst)(3)
                    Form1.EXEStream(i.HeaderPointer(j) - &H400000 + 12) = 0
                    Form1.EXEStream(i.HeaderPointer(j) - &H400000 + 13) = 0
                    Form1.EXEStream(i.HeaderPointer(j) - &H400000 + 14) = 0
                    Form1.EXEStream(i.HeaderPointer(j) - &H400000 + 15) = 0

                    For k = 0 To i.HeaderEntry(j).VertexEntryStream.Count - 1
                        Form1.EXEStream(i.HeaderEntry(j).PointerToFirst - &H400000 + k * 12 + 0) = BitConverter.GetBytes(i.HeaderEntry(j).VertexEntryStream(k).PositionX)(0)
                        Form1.EXEStream(i.HeaderEntry(j).PointerToFirst - &H400000 + k * 12 + 1) = BitConverter.GetBytes(i.HeaderEntry(j).VertexEntryStream(k).PositionX)(1)
                        Form1.EXEStream(i.HeaderEntry(j).PointerToFirst - &H400000 + k * 12 + 2) = BitConverter.GetBytes(i.HeaderEntry(j).VertexEntryStream(k).PositionX)(2)
                        Form1.EXEStream(i.HeaderEntry(j).PointerToFirst - &H400000 + k * 12 + 3) = BitConverter.GetBytes(i.HeaderEntry(j).VertexEntryStream(k).PositionX)(3)
                        Form1.EXEStream(i.HeaderEntry(j).PointerToFirst - &H400000 + k * 12 + 4) = BitConverter.GetBytes(i.HeaderEntry(j).VertexEntryStream(k).PositionY)(0)
                        Form1.EXEStream(i.HeaderEntry(j).PointerToFirst - &H400000 + k * 12 + 5) = BitConverter.GetBytes(i.HeaderEntry(j).VertexEntryStream(k).PositionY)(1)
                        Form1.EXEStream(i.HeaderEntry(j).PointerToFirst - &H400000 + k * 12 + 6) = BitConverter.GetBytes(i.HeaderEntry(j).VertexEntryStream(k).PositionY)(2)
                        Form1.EXEStream(i.HeaderEntry(j).PointerToFirst - &H400000 + k * 12 + 7) = BitConverter.GetBytes(i.HeaderEntry(j).VertexEntryStream(k).PositionY)(3)
                        Form1.EXEStream(i.HeaderEntry(j).PointerToFirst - &H400000 + k * 12 + 8) = BitConverter.GetBytes(i.HeaderEntry(j).VertexEntryStream(k).PositionZ)(0)
                        Form1.EXEStream(i.HeaderEntry(j).PointerToFirst - &H400000 + k * 12 + 9) = BitConverter.GetBytes(i.HeaderEntry(j).VertexEntryStream(k).PositionZ)(1)
                        Form1.EXEStream(i.HeaderEntry(j).PointerToFirst - &H400000 + k * 12 + 10) = BitConverter.GetBytes(i.HeaderEntry(j).VertexEntryStream(k).PositionZ)(2)
                        Form1.EXEStream(i.HeaderEntry(j).PointerToFirst - &H400000 + k * 12 + 11) = BitConverter.GetBytes(i.HeaderEntry(j).VertexEntryStream(k).PositionZ)(3)
                    Next
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

            For Each i As VertexEntry In INISplineHeaderEntryStream(ComboBoxLevel.SelectedIndex).HeaderEntry(ComboBoxPickSpline.SelectedIndex).VertexEntryStream
                SplineOBJWriter.WriteLine("v " + i.PositionX.ToString + " " + i.PositionY.ToString + " " + i.PositionZ.ToString)
            Next

            SplineOBJWriter.WriteLine()

            Dim Everynumber As String = ""

            For i = 1 To INISplineHeaderEntryStream(ComboBoxLevel.SelectedIndex).HeaderEntry(ComboBoxPickSpline.SelectedIndex).VertexEntryStream.Count
                Everynumber += " " + i.ToString
            Next

            SplineOBJWriter.WriteLine("g " + INISplineHeaderEntryStream(ComboBoxLevel.SelectedIndex).LevelName + ComboBoxPickSpline.SelectedItem.ToString)
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

            For j = 0 To 1
                For Each i As VertexEntry In INISplineHeaderEntryStream(ComboBoxLevel.SelectedIndex).HeaderEntry(j).VertexEntryStream
                    SplineOBJWriter.WriteLine("v " + i.PositionX.ToString + " " + i.PositionY.ToString + " " + i.PositionZ.ToString)
                Next

                SplineOBJWriter.WriteLine()

                Dim Everynumber As String = ""

                For l = 1 To INISplineHeaderEntryStream(ComboBoxLevel.SelectedIndex).HeaderEntry(j).VertexEntryStream.Count
                    Everynumber += " " + k.ToString
                    k += 1
                Next

                SplineOBJWriter.WriteLine("g " + INISplineHeaderEntryStream(ComboBoxLevel.SelectedIndex).LevelName + ComboBoxPickSpline.SelectedItem.ToString)
                SplineOBJWriter.WriteLine("l" + Everynumber.ToArray)
            Next

            SplineOBJWriter.Close()
        End If
    End Sub

    Private Sub ComboBoxPickSpline_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBoxPickSpline.SelectedIndexChanged
        LabelLenght.Text = "Lenght: " + INISplineHeaderEntryStream(ComboBoxLevel.SelectedIndex).HeaderEntry(ComboBoxPickSpline.SelectedIndex).SplineLenght.ToString

        ListBoxVertices.Items.Clear()

        For i = 0 To INISplineHeaderEntryStream(ComboBoxLevel.SelectedIndex).HeaderEntry(ComboBoxPickSpline.SelectedIndex).VertexEntryStream.Count - 1
            ListBoxVertices.Items.Add("Vertex " + i.ToString)
        Next

        ButtonExportObj.Enabled = True
        Button1.Enabled = True
        ButtonImportObj.Enabled = True
    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBoxSeasideDenied.SelectedIndexChanged
        Form1.EXEStream(&H9E49C) = ComboBoxSeasideDenied.SelectedIndex
    End Sub
End Class