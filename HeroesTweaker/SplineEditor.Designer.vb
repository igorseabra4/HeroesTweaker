<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class SplineEditor
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.ComboBoxLevel = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.NumericPickSpline = New System.Windows.Forms.NumericUpDown()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.LabelAmount = New System.Windows.Forms.Label()
        Me.ListBoxVertices = New System.Windows.Forms.ListBox()
        Me.LabelPosX = New System.Windows.Forms.Label()
        Me.LabelPosY = New System.Windows.Forms.Label()
        Me.LabelPosZ = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.ComboBoxSplineType = New System.Windows.Forms.ComboBox()
        Me.ButtonExportObj = New System.Windows.Forms.Button()
        Me.LabelDistance = New System.Windows.Forms.Label()
        Me.LabelLenght = New System.Windows.Forms.Label()
        Me.LabelUnknown = New System.Windows.Forms.Label()
        Me.ButtonImportObj = New System.Windows.Forms.Button()
        Me.SplineExportOBJDialog = New System.Windows.Forms.SaveFileDialog()
        Me.SplineImportOBJDialog = New System.Windows.Forms.OpenFileDialog()
        Me.Button1 = New System.Windows.Forms.Button()
        CType(Me.NumericPickSpline, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ComboBoxLevel
        '
        Me.ComboBoxLevel.FormattingEnabled = True
        Me.ComboBoxLevel.Items.AddRange(New Object() {"Grand Metropolis"})
        Me.ComboBoxLevel.Location = New System.Drawing.Point(57, 12)
        Me.ComboBoxLevel.Name = "ComboBoxLevel"
        Me.ComboBoxLevel.Size = New System.Drawing.Size(215, 21)
        Me.ComboBoxLevel.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 15)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(36, 13)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Level:"
        '
        'NumericPickSpline
        '
        Me.NumericPickSpline.Location = New System.Drawing.Point(57, 39)
        Me.NumericPickSpline.Maximum = New Decimal(New Integer() {0, 0, 0, 0})
        Me.NumericPickSpline.Name = "NumericPickSpline"
        Me.NumericPickSpline.Size = New System.Drawing.Size(121, 20)
        Me.NumericPickSpline.TabIndex = 2
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(12, 41)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(39, 13)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Spline:"
        '
        'LabelAmount
        '
        Me.LabelAmount.AutoSize = True
        Me.LabelAmount.Location = New System.Drawing.Point(278, 15)
        Me.LabelAmount.Name = "LabelAmount"
        Me.LabelAmount.Size = New System.Drawing.Size(46, 13)
        Me.LabelAmount.TabIndex = 4
        Me.LabelAmount.Text = "Amount:"
        '
        'ListBoxVertices
        '
        Me.ListBoxVertices.FormattingEnabled = True
        Me.ListBoxVertices.Location = New System.Drawing.Point(12, 65)
        Me.ListBoxVertices.Name = "ListBoxVertices"
        Me.ListBoxVertices.Size = New System.Drawing.Size(166, 186)
        Me.ListBoxVertices.TabIndex = 5
        '
        'LabelPosX
        '
        Me.LabelPosX.AutoSize = True
        Me.LabelPosX.Location = New System.Drawing.Point(184, 136)
        Me.LabelPosX.Name = "LabelPosX"
        Me.LabelPosX.Size = New System.Drawing.Size(57, 13)
        Me.LabelPosX.TabIndex = 7
        Me.LabelPosX.Text = "X Position:"
        '
        'LabelPosY
        '
        Me.LabelPosY.AutoSize = True
        Me.LabelPosY.Location = New System.Drawing.Point(184, 153)
        Me.LabelPosY.Name = "LabelPosY"
        Me.LabelPosY.Size = New System.Drawing.Size(57, 13)
        Me.LabelPosY.TabIndex = 8
        Me.LabelPosY.Text = "Y Position:"
        '
        'LabelPosZ
        '
        Me.LabelPosZ.AutoSize = True
        Me.LabelPosZ.Location = New System.Drawing.Point(184, 170)
        Me.LabelPosZ.Name = "LabelPosZ"
        Me.LabelPosZ.Size = New System.Drawing.Size(57, 13)
        Me.LabelPosZ.TabIndex = 11
        Me.LabelPosZ.Text = "Z Position:"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(184, 41)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(34, 13)
        Me.Label6.TabIndex = 12
        Me.Label6.Text = "Type:"
        '
        'ComboBoxSplineType
        '
        Me.ComboBoxSplineType.FormattingEnabled = True
        Me.ComboBoxSplineType.Items.AddRange(New Object() {"Autoloop", "Ball Path", "Rail", "Null"})
        Me.ComboBoxSplineType.Location = New System.Drawing.Point(224, 38)
        Me.ComboBoxSplineType.Name = "ComboBoxSplineType"
        Me.ComboBoxSplineType.Size = New System.Drawing.Size(121, 21)
        Me.ComboBoxSplineType.TabIndex = 13
        '
        'ButtonExportObj
        '
        Me.ButtonExportObj.Enabled = False
        Me.ButtonExportObj.Location = New System.Drawing.Point(184, 81)
        Me.ButtonExportObj.Name = "ButtonExportObj"
        Me.ButtonExportObj.Size = New System.Drawing.Size(161, 23)
        Me.ButtonExportObj.TabIndex = 14
        Me.ButtonExportObj.Text = "Export OBJ"
        Me.ButtonExportObj.UseVisualStyleBackColor = True
        '
        'LabelDistance
        '
        Me.LabelDistance.AutoSize = True
        Me.LabelDistance.Location = New System.Drawing.Point(184, 187)
        Me.LabelDistance.Name = "LabelDistance"
        Me.LabelDistance.Size = New System.Drawing.Size(52, 13)
        Me.LabelDistance.TabIndex = 15
        Me.LabelDistance.Text = "Distance:"
        '
        'LabelLenght
        '
        Me.LabelLenght.AutoSize = True
        Me.LabelLenght.Location = New System.Drawing.Point(184, 65)
        Me.LabelLenght.Name = "LabelLenght"
        Me.LabelLenght.Size = New System.Drawing.Size(43, 13)
        Me.LabelLenght.TabIndex = 17
        Me.LabelLenght.Text = "Lenght:"
        '
        'LabelUnknown
        '
        Me.LabelUnknown.AutoSize = True
        Me.LabelUnknown.Location = New System.Drawing.Point(184, 204)
        Me.LabelUnknown.Name = "LabelUnknown"
        Me.LabelUnknown.Size = New System.Drawing.Size(56, 13)
        Me.LabelUnknown.TabIndex = 15
        Me.LabelUnknown.Text = "Unknown:"
        '
        'ButtonImportObj
        '
        Me.ButtonImportObj.Enabled = False
        Me.ButtonImportObj.Location = New System.Drawing.Point(184, 110)
        Me.ButtonImportObj.Name = "ButtonImportObj"
        Me.ButtonImportObj.Size = New System.Drawing.Size(161, 23)
        Me.ButtonImportObj.TabIndex = 18
        Me.ButtonImportObj.Text = "Import OBJ"
        Me.ButtonImportObj.UseVisualStyleBackColor = True
        '
        'SplineExportOBJDialog
        '
        Me.SplineExportOBJDialog.Filter = ".OBJ File|*.obj"
        '
        'SplineImportOBJDialog
        '
        Me.SplineImportOBJDialog.Filter = ".OBJ File|*.obj"
        '
        'Button1
        '
        Me.Button1.Enabled = False
        Me.Button1.Location = New System.Drawing.Point(184, 228)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(161, 23)
        Me.Button1.TabIndex = 20
        Me.Button1.Text = "Export All"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'SplineEditor
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(357, 260)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.ButtonImportObj)
        Me.Controls.Add(Me.LabelLenght)
        Me.Controls.Add(Me.LabelUnknown)
        Me.Controls.Add(Me.LabelDistance)
        Me.Controls.Add(Me.ButtonExportObj)
        Me.Controls.Add(Me.ComboBoxSplineType)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.LabelPosZ)
        Me.Controls.Add(Me.LabelPosY)
        Me.Controls.Add(Me.LabelPosX)
        Me.Controls.Add(Me.ListBoxVertices)
        Me.Controls.Add(Me.LabelAmount)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.NumericPickSpline)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.ComboBoxLevel)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Name = "SplineEditor"
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.Text = "Spline Editor"
        CType(Me.NumericPickSpline, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ComboBoxLevel As ComboBox
    Friend WithEvents Label1 As Label
    Friend WithEvents NumericPickSpline As NumericUpDown
    Friend WithEvents Label2 As Label
    Friend WithEvents LabelAmount As Label
    Friend WithEvents ListBoxVertices As ListBox
    Friend WithEvents LabelPosX As Label
    Friend WithEvents LabelPosY As Label
    Friend WithEvents LabelPosZ As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents ComboBoxSplineType As ComboBox
    Friend WithEvents ButtonExportObj As Button
    Friend WithEvents LabelDistance As Label
    Friend WithEvents LabelLenght As Label
    Friend WithEvents LabelUnknown As Label
    Friend WithEvents ButtonImportObj As Button
    Friend WithEvents SplineExportOBJDialog As SaveFileDialog
    Friend WithEvents SplineImportOBJDialog As OpenFileDialog
    Friend WithEvents Button1 As Button
End Class
