<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Descartar substituições de formulário para limpar a lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Exigido pelo Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'OBSERVAÇÃO: o procedimento a seguir é exigido pelo Windows Form Designer
    'Pode ser modificado usando o Windows Form Designer.  
    'Não o modifique usando o editor de códigos.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.FileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.OpenToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SaveToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SaveAsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.AboutToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ExitToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.EditorsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MissionEditorToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ChaotixMissionEditorToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator3 = New System.Windows.Forms.ToolStripSeparator()
        Me.StartEndingPositionEditorToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SplineEditorToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.BobsledEditorToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.RankingRequirementsEditorToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.UnlockRequirementsEditorToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FileToolStripMenuItem, Me.EditorsToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(784, 24)
        Me.MenuStrip1.TabIndex = 0
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'FileToolStripMenuItem
        '
        Me.FileToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.OpenToolStripMenuItem, Me.SaveToolStripMenuItem, Me.SaveAsToolStripMenuItem, Me.ToolStripSeparator1, Me.AboutToolStripMenuItem, Me.ExitToolStripMenuItem})
        Me.FileToolStripMenuItem.Name = "FileToolStripMenuItem"
        Me.FileToolStripMenuItem.Size = New System.Drawing.Size(37, 20)
        Me.FileToolStripMenuItem.Text = "File"
        '
        'OpenToolStripMenuItem
        '
        Me.OpenToolStripMenuItem.Name = "OpenToolStripMenuItem"
        Me.OpenToolStripMenuItem.Size = New System.Drawing.Size(123, 22)
        Me.OpenToolStripMenuItem.Text = "Open"
        '
        'SaveToolStripMenuItem
        '
        Me.SaveToolStripMenuItem.Enabled = False
        Me.SaveToolStripMenuItem.Name = "SaveToolStripMenuItem"
        Me.SaveToolStripMenuItem.Size = New System.Drawing.Size(123, 22)
        Me.SaveToolStripMenuItem.Text = "Save"
        '
        'SaveAsToolStripMenuItem
        '
        Me.SaveAsToolStripMenuItem.Enabled = False
        Me.SaveAsToolStripMenuItem.Name = "SaveAsToolStripMenuItem"
        Me.SaveAsToolStripMenuItem.Size = New System.Drawing.Size(123, 22)
        Me.SaveAsToolStripMenuItem.Text = "Save As..."
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(120, 6)
        '
        'AboutToolStripMenuItem
        '
        Me.AboutToolStripMenuItem.Name = "AboutToolStripMenuItem"
        Me.AboutToolStripMenuItem.Size = New System.Drawing.Size(123, 22)
        Me.AboutToolStripMenuItem.Text = "About"
        '
        'ExitToolStripMenuItem
        '
        Me.ExitToolStripMenuItem.Name = "ExitToolStripMenuItem"
        Me.ExitToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.ExitToolStripMenuItem.Text = "Exit"
        '
        'EditorsToolStripMenuItem
        '
        Me.EditorsToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.MissionEditorToolStripMenuItem, Me.ChaotixMissionEditorToolStripMenuItem, Me.UnlockRequirementsEditorToolStripMenuItem, Me.ToolStripSeparator3, Me.StartEndingPositionEditorToolStripMenuItem, Me.SplineEditorToolStripMenuItem, Me.BobsledEditorToolStripMenuItem, Me.RankingRequirementsEditorToolStripMenuItem})
        Me.EditorsToolStripMenuItem.Enabled = False
        Me.EditorsToolStripMenuItem.Name = "EditorsToolStripMenuItem"
        Me.EditorsToolStripMenuItem.Size = New System.Drawing.Size(55, 20)
        Me.EditorsToolStripMenuItem.Text = "Editors"
        '
        'MissionEditorToolStripMenuItem
        '
        Me.MissionEditorToolStripMenuItem.Name = "MissionEditorToolStripMenuItem"
        Me.MissionEditorToolStripMenuItem.Size = New System.Drawing.Size(227, 22)
        Me.MissionEditorToolStripMenuItem.Text = "Extra Mission Editor"
        '
        'ChaotixMissionEditorToolStripMenuItem
        '
        Me.ChaotixMissionEditorToolStripMenuItem.Name = "ChaotixMissionEditorToolStripMenuItem"
        Me.ChaotixMissionEditorToolStripMenuItem.Size = New System.Drawing.Size(227, 22)
        Me.ChaotixMissionEditorToolStripMenuItem.Text = "Chaotix Mission Editor"
        '
        'ToolStripSeparator3
        '
        Me.ToolStripSeparator3.Name = "ToolStripSeparator3"
        Me.ToolStripSeparator3.Size = New System.Drawing.Size(224, 6)
        '
        'StartEndingPositionEditorToolStripMenuItem
        '
        Me.StartEndingPositionEditorToolStripMenuItem.Name = "StartEndingPositionEditorToolStripMenuItem"
        Me.StartEndingPositionEditorToolStripMenuItem.Size = New System.Drawing.Size(227, 22)
        Me.StartEndingPositionEditorToolStripMenuItem.Text = "Start/Ending Position Editor"
        '
        'SplineEditorToolStripMenuItem
        '
        Me.SplineEditorToolStripMenuItem.Name = "SplineEditorToolStripMenuItem"
        Me.SplineEditorToolStripMenuItem.Size = New System.Drawing.Size(227, 22)
        Me.SplineEditorToolStripMenuItem.Text = "Spline Editor"
        '
        'BobsledEditorToolStripMenuItem
        '
        Me.BobsledEditorToolStripMenuItem.Name = "BobsledEditorToolStripMenuItem"
        Me.BobsledEditorToolStripMenuItem.Size = New System.Drawing.Size(227, 22)
        Me.BobsledEditorToolStripMenuItem.Text = "Bobsled Editor"
        '
        'RankingRequirementsEditorToolStripMenuItem
        '
        Me.RankingRequirementsEditorToolStripMenuItem.Name = "RankingRequirementsEditorToolStripMenuItem"
        Me.RankingRequirementsEditorToolStripMenuItem.Size = New System.Drawing.Size(227, 22)
        Me.RankingRequirementsEditorToolStripMenuItem.Text = "Ranking Requirements Editor"
        '
        'UnlockRequirementsEditorToolStripMenuItem
        '
        Me.UnlockRequirementsEditorToolStripMenuItem.Name = "UnlockRequirementsEditorToolStripMenuItem"
        Me.UnlockRequirementsEditorToolStripMenuItem.Size = New System.Drawing.Size(227, 22)
        Me.UnlockRequirementsEditorToolStripMenuItem.Text = "Unlock Requirements Editor"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(784, 561)
        Me.Controls.Add(Me.MenuStrip1)
        Me.IsMdiContainer = True
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "Form1"
        Me.Text = "HeroesTweaker"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents FileToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents OpenToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SaveToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SaveAsToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ToolStripSeparator1 As ToolStripSeparator
    Friend WithEvents AboutToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ExitToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents EditorsToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ChaotixMissionEditorToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents MissionEditorToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SplineEditorToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents StartEndingPositionEditorToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents BobsledEditorToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents RankingRequirementsEditorToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ToolStripSeparator3 As ToolStripSeparator
    Friend WithEvents UnlockRequirementsEditorToolStripMenuItem As ToolStripMenuItem
End Class
