<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class MicMonitor
    Inherits basestyle

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
        Me.components = New System.ComponentModel.Container()
        Me.stopbtn = New DrakeUI.Framework.DrakeUIButtonIcon()
        Me.startbtn = New DrakeUI.Framework.DrakeUIButtonIcon()
        Me.progressbaradio = New DrakeUI.Framework.DrakeUITrackBar()
        Me.comboqultz = New DrakeUI.Framework.DrakeUIComboBox()
        Me.mictoolbox = New System.Windows.Forms.TableLayoutPanel()
        Me.continuebtn = New DrakeUI.Framework.DrakeUIButtonIcon()
        Me.pausebtn = New DrakeUI.Framework.DrakeUIButtonIcon()
        Me.recordbtn = New DrakeUI.Framework.DrakeUIButtonIcon()
        Me.combosrces = New DrakeUI.Framework.DrakeUIComboBox()
        Me.statetimer = New System.Windows.Forms.Timer(Me.components)
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.DrakeWidth_W3 = New DrakeUI.Framework.DrakeWidth_W()
        Me.DrakeWidth_W2 = New DrakeUI.Framework.DrakeWidth_W()
        CType(Me.myscr, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.myico, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.mictoolbox.SuspendLayout()
        Me.Panel3.SuspendLayout()
        Me.SuspendLayout()
        '
        'pinbtn
        '
        Me.pinbtn.Location = New System.Drawing.Point(460, 5)
        Me.pinbtn.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        '
        'minibtn
        '
        Me.minibtn.Location = New System.Drawing.Point(507, 5)
        Me.minibtn.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        '
        'closbtn
        '
        Me.closbtn.Location = New System.Drawing.Point(554, 5)
        Me.closbtn.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        '
        'mytitle
        '
        Me.mytitle.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.mytitle.Size = New System.Drawing.Size(586, 18)
        '
        'stopbtn
        '
        Me.stopbtn.Cursor = System.Windows.Forms.Cursors.Hand
        Me.stopbtn.Dock = System.Windows.Forms.DockStyle.Right
        Me.stopbtn.Enabled = False
        Me.stopbtn.FillColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.stopbtn.FillDisableColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.stopbtn.FillHoverColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.stopbtn.FillPressColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.stopbtn.FillSelectedColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.stopbtn.Font = New System.Drawing.Font("Cascadia Code", 9.0!)
        Me.stopbtn.ForeHoverColor = System.Drawing.Color.Gray
        Me.stopbtn.Location = New System.Drawing.Point(494, 8)
        Me.stopbtn.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.stopbtn.Name = "stopbtn"
        Me.stopbtn.RadiusSides = DrakeUI.Framework.UICornerRadiusSides.None
        Me.stopbtn.RectColor = System.Drawing.Color.Gray
        Me.stopbtn.RectDisableColor = System.Drawing.Color.FromArgb(CType(CType(227, Byte), Integer), CType(CType(242, Byte), Integer), CType(CType(253, Byte), Integer))
        Me.stopbtn.RectHoverColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.stopbtn.RectPressColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(45, Byte), Integer))
        Me.stopbtn.RectSelectedColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(45, Byte), Integer))
        Me.stopbtn.RectSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.Bottom
        Me.stopbtn.Size = New System.Drawing.Size(43, 36)
        Me.stopbtn.Style = DrakeUI.Framework.UIStyle.Custom
        Me.stopbtn.Symbol = 61516
        Me.stopbtn.TabIndex = 41
        '
        'startbtn
        '
        Me.startbtn.Cursor = System.Windows.Forms.Cursors.Hand
        Me.startbtn.Dock = System.Windows.Forms.DockStyle.Right
        Me.startbtn.FillColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.startbtn.FillDisableColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.startbtn.FillHoverColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.startbtn.FillPressColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.startbtn.FillSelectedColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.startbtn.Font = New System.Drawing.Font("Cascadia Code", 9.0!)
        Me.startbtn.ForeHoverColor = System.Drawing.Color.Gray
        Me.startbtn.Location = New System.Drawing.Point(545, 8)
        Me.startbtn.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.startbtn.Name = "startbtn"
        Me.startbtn.RadiusSides = DrakeUI.Framework.UICornerRadiusSides.None
        Me.startbtn.RectColor = System.Drawing.Color.Gray
        Me.startbtn.RectDisableColor = System.Drawing.Color.FromArgb(CType(CType(227, Byte), Integer), CType(CType(242, Byte), Integer), CType(CType(253, Byte), Integer))
        Me.startbtn.RectHoverColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.startbtn.RectPressColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(45, Byte), Integer))
        Me.startbtn.RectSelectedColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(45, Byte), Integer))
        Me.startbtn.RectSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.Bottom
        Me.startbtn.Size = New System.Drawing.Size(43, 36)
        Me.startbtn.Style = DrakeUI.Framework.UIStyle.Custom
        Me.startbtn.Symbol = 61515
        Me.startbtn.TabIndex = 40
        '
        'progressbaradio
        '
        Me.progressbaradio.BackColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.progressbaradio.DisableColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.progressbaradio.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.progressbaradio.Enabled = False
        Me.progressbaradio.FillColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.progressbaradio.Font = New System.Drawing.Font("Cascadia Code", 12.0!)
        Me.progressbaradio.ForeColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(136, Byte), Integer), CType(CType(229, Byte), Integer))
        Me.progressbaradio.Location = New System.Drawing.Point(2, 148)
        Me.progressbaradio.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.progressbaradio.Name = "progressbaradio"
        Me.progressbaradio.RectColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(45, Byte), Integer))
        Me.progressbaradio.Size = New System.Drawing.Size(596, 2)
        Me.progressbaradio.Style = DrakeUI.Framework.UIStyle.Custom
        Me.progressbaradio.TabIndex = 42
        Me.progressbaradio.Text = "DrakeUITrackBar4"
        '
        'comboqultz
        '
        Me.comboqultz.Dock = System.Windows.Forms.DockStyle.Left
        Me.comboqultz.DropDownStyle = DrakeUI.Framework.UIDropDownStyle.DropDownList
        Me.comboqultz.FillColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.comboqultz.Font = New System.Drawing.Font("Cascadia Code", 9.0!)
        Me.comboqultz.ForeColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.comboqultz.Items.AddRange(New Object() {"8000 (Hz)", "11025 (Hz)", "16000 (Hz)", "22050 (Hz)", "32000 (Hz)", "44100 (Hz)"})
        Me.comboqultz.Location = New System.Drawing.Point(146, 8)
        Me.comboqultz.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.comboqultz.MinimumSize = New System.Drawing.Size(49, 0)
        Me.comboqultz.Name = "comboqultz"
        Me.comboqultz.Padding = New System.Windows.Forms.Padding(0, 0, 30, 0)
        Me.comboqultz.RadiusSides = DrakeUI.Framework.UICornerRadiusSides.None
        Me.comboqultz.RectColor = System.Drawing.Color.Gray
        Me.comboqultz.RectDisableColor = System.Drawing.Color.FromArgb(CType(CType(227, Byte), Integer), CType(CType(242, Byte), Integer), CType(CType(253, Byte), Integer))
        Me.comboqultz.RectSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.Bottom
        Me.comboqultz.Size = New System.Drawing.Size(130, 21)
        Me.comboqultz.Style = DrakeUI.Framework.UIStyle.Custom
        Me.comboqultz.TabIndex = 43
        Me.comboqultz.Text = "Audio Quality"
        Me.comboqultz.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft
        '
        'mictoolbox
        '
        Me.mictoolbox.ColumnCount = 3
        Me.mictoolbox.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333!))
        Me.mictoolbox.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333!))
        Me.mictoolbox.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333!))
        Me.mictoolbox.Controls.Add(Me.continuebtn, 0, 0)
        Me.mictoolbox.Controls.Add(Me.pausebtn, 0, 0)
        Me.mictoolbox.Controls.Add(Me.recordbtn, 0, 0)
        Me.mictoolbox.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.mictoolbox.Enabled = False
        Me.mictoolbox.Location = New System.Drawing.Point(2, 123)
        Me.mictoolbox.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.mictoolbox.Name = "mictoolbox"
        Me.mictoolbox.RowCount = 1
        Me.mictoolbox.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.mictoolbox.Size = New System.Drawing.Size(596, 25)
        Me.mictoolbox.TabIndex = 49
        '
        'continuebtn
        '
        Me.continuebtn.Cursor = System.Windows.Forms.Cursors.Hand
        Me.continuebtn.Dock = System.Windows.Forms.DockStyle.Fill
        Me.continuebtn.Enabled = False
        Me.continuebtn.FillColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.continuebtn.FillDisableColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.continuebtn.FillHoverColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.continuebtn.FillPressColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.continuebtn.FillSelectedColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.continuebtn.Font = New System.Drawing.Font("Cascadia Code", 9.0!)
        Me.continuebtn.ForeHoverColor = System.Drawing.Color.Gray
        Me.continuebtn.Location = New System.Drawing.Point(398, 2)
        Me.continuebtn.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.continuebtn.Name = "continuebtn"
        Me.continuebtn.RadiusSides = DrakeUI.Framework.UICornerRadiusSides.None
        Me.continuebtn.RectColor = System.Drawing.Color.Gray
        Me.continuebtn.RectDisableColor = System.Drawing.Color.FromArgb(CType(CType(227, Byte), Integer), CType(CType(242, Byte), Integer), CType(CType(253, Byte), Integer))
        Me.continuebtn.RectHoverColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.continuebtn.RectPressColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(45, Byte), Integer))
        Me.continuebtn.RectSelectedColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(45, Byte), Integer))
        Me.continuebtn.RectSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.Bottom
        Me.continuebtn.Size = New System.Drawing.Size(196, 21)
        Me.continuebtn.Style = DrakeUI.Framework.UIStyle.Custom
        Me.continuebtn.Symbol = 57422
        Me.continuebtn.TabIndex = 23
        Me.continuebtn.Text = "Continue"
        '
        'pausebtn
        '
        Me.pausebtn.Cursor = System.Windows.Forms.Cursors.Hand
        Me.pausebtn.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pausebtn.FillColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.pausebtn.FillDisableColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.pausebtn.FillHoverColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.pausebtn.FillPressColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.pausebtn.FillSelectedColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.pausebtn.Font = New System.Drawing.Font("Cascadia Code", 9.0!)
        Me.pausebtn.ForeHoverColor = System.Drawing.Color.Gray
        Me.pausebtn.Location = New System.Drawing.Point(200, 2)
        Me.pausebtn.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.pausebtn.Name = "pausebtn"
        Me.pausebtn.RadiusSides = DrakeUI.Framework.UICornerRadiusSides.None
        Me.pausebtn.RectColor = System.Drawing.Color.Gray
        Me.pausebtn.RectDisableColor = System.Drawing.Color.FromArgb(CType(CType(227, Byte), Integer), CType(CType(242, Byte), Integer), CType(CType(253, Byte), Integer))
        Me.pausebtn.RectHoverColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.pausebtn.RectPressColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(45, Byte), Integer))
        Me.pausebtn.RectSelectedColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(45, Byte), Integer))
        Me.pausebtn.RectSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.Bottom
        Me.pausebtn.Size = New System.Drawing.Size(194, 21)
        Me.pausebtn.Style = DrakeUI.Framework.UIStyle.Custom
        Me.pausebtn.Symbol = 62091
        Me.pausebtn.TabIndex = 22
        Me.pausebtn.Text = "Pause"
        '
        'recordbtn
        '
        Me.recordbtn.Cursor = System.Windows.Forms.Cursors.Hand
        Me.recordbtn.Dock = System.Windows.Forms.DockStyle.Fill
        Me.recordbtn.FillColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.recordbtn.FillDisableColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.recordbtn.FillHoverColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.recordbtn.FillPressColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.recordbtn.FillSelectedColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.recordbtn.Font = New System.Drawing.Font("Cascadia Code", 9.0!)
        Me.recordbtn.ForeHoverColor = System.Drawing.Color.Gray
        Me.recordbtn.Location = New System.Drawing.Point(2, 2)
        Me.recordbtn.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.recordbtn.Name = "recordbtn"
        Me.recordbtn.RadiusSides = DrakeUI.Framework.UICornerRadiusSides.None
        Me.recordbtn.RectColor = System.Drawing.Color.Gray
        Me.recordbtn.RectDisableColor = System.Drawing.Color.FromArgb(CType(CType(227, Byte), Integer), CType(CType(242, Byte), Integer), CType(CType(253, Byte), Integer))
        Me.recordbtn.RectHoverColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.recordbtn.RectPressColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(45, Byte), Integer))
        Me.recordbtn.RectSelectedColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(45, Byte), Integer))
        Me.recordbtn.RectSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.Bottom
        Me.recordbtn.Size = New System.Drawing.Size(194, 21)
        Me.recordbtn.Style = DrakeUI.Framework.UIStyle.Custom
        Me.recordbtn.Symbol = 61744
        Me.recordbtn.TabIndex = 21
        Me.recordbtn.TagString = "0"
        Me.recordbtn.Text = "Record"
        '
        'combosrces
        '
        Me.combosrces.Dock = System.Windows.Forms.DockStyle.Left
        Me.combosrces.DropDownStyle = DrakeUI.Framework.UIDropDownStyle.DropDownList
        Me.combosrces.FillColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.combosrces.Font = New System.Drawing.Font("Cascadia Code", 9.0!)
        Me.combosrces.ForeColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.combosrces.Items.AddRange(New Object() {"DEFAULT", "MIC", "RECOGNITION", "COMMUNICATION", "CAMCORDER"})
        Me.combosrces.Location = New System.Drawing.Point(8, 8)
        Me.combosrces.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.combosrces.MinimumSize = New System.Drawing.Size(49, 0)
        Me.combosrces.Name = "combosrces"
        Me.combosrces.Padding = New System.Windows.Forms.Padding(0, 0, 30, 0)
        Me.combosrces.RadiusSides = DrakeUI.Framework.UICornerRadiusSides.None
        Me.combosrces.RectColor = System.Drawing.Color.Gray
        Me.combosrces.RectDisableColor = System.Drawing.Color.FromArgb(CType(CType(227, Byte), Integer), CType(CType(242, Byte), Integer), CType(CType(253, Byte), Integer))
        Me.combosrces.RectSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.Bottom
        Me.combosrces.Size = New System.Drawing.Size(130, 21)
        Me.combosrces.Style = DrakeUI.Framework.UIStyle.Custom
        Me.combosrces.TabIndex = 50
        Me.combosrces.Text = "DEFAULT"
        Me.combosrces.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft
        '
        'statetimer
        '
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Panel3.Controls.Add(Me.stopbtn)
        Me.Panel3.Controls.Add(Me.DrakeWidth_W3)
        Me.Panel3.Controls.Add(Me.startbtn)
        Me.Panel3.Controls.Add(Me.comboqultz)
        Me.Panel3.Controls.Add(Me.DrakeWidth_W2)
        Me.Panel3.Controls.Add(Me.combosrces)
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel3.Location = New System.Drawing.Point(2, 71)
        Me.Panel3.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Padding = New System.Windows.Forms.Padding(8, 8, 8, 8)
        Me.Panel3.Size = New System.Drawing.Size(596, 52)
        Me.Panel3.TabIndex = 51
        '
        'DrakeWidth_W3
        '
        Me.DrakeWidth_W3.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.DrakeWidth_W3.Dock = System.Windows.Forms.DockStyle.Right
        Me.DrakeWidth_W3.Location = New System.Drawing.Point(537, 8)
        Me.DrakeWidth_W3.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.DrakeWidth_W3.Name = "DrakeWidth_W3"
        Me.DrakeWidth_W3.Size = New System.Drawing.Size(8, 36)
        Me.DrakeWidth_W3.TabIndex = 52
        '
        'DrakeWidth_W2
        '
        Me.DrakeWidth_W2.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.DrakeWidth_W2.Dock = System.Windows.Forms.DockStyle.Left
        Me.DrakeWidth_W2.Location = New System.Drawing.Point(138, 8)
        Me.DrakeWidth_W2.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.DrakeWidth_W2.Name = "DrakeWidth_W2"
        Me.DrakeWidth_W2.Size = New System.Drawing.Size(8, 36)
        Me.DrakeWidth_W2.TabIndex = 51
        '
        'MicMonitor
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(600, 152)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.mictoolbox)
        Me.Controls.Add(Me.progressbaradio)
        Me.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.MaximumSize = New System.Drawing.Size(600, 152)
        Me.MinimumSize = New System.Drawing.Size(600, 152)
        Me.Name = "MicMonitor"
        Me.Text = "MCore | Microphone"
        Me.Controls.SetChildIndex(Me.progressbaradio, 0)
        Me.Controls.SetChildIndex(Me.mictoolbox, 0)
        Me.Controls.SetChildIndex(Me.Panel3, 0)
        CType(Me.myscr, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.myico, System.ComponentModel.ISupportInitialize).EndInit()
        Me.mictoolbox.ResumeLayout(False)
        Me.Panel3.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents stopbtn As DrakeUI.Framework.DrakeUIButtonIcon
    Friend WithEvents startbtn As DrakeUI.Framework.DrakeUIButtonIcon
    Friend WithEvents progressbaradio As DrakeUI.Framework.DrakeUITrackBar
    Friend WithEvents comboqultz As DrakeUI.Framework.DrakeUIComboBox
    Friend WithEvents mictoolbox As TableLayoutPanel
    Friend WithEvents continuebtn As DrakeUI.Framework.DrakeUIButtonIcon
    Friend WithEvents pausebtn As DrakeUI.Framework.DrakeUIButtonIcon
    Friend WithEvents recordbtn As DrakeUI.Framework.DrakeUIButtonIcon
    Friend WithEvents combosrces As DrakeUI.Framework.DrakeUIComboBox
    Friend WithEvents statetimer As Timer
    Friend WithEvents Panel3 As Panel
    Friend WithEvents DrakeWidth_W3 As DrakeUI.Framework.DrakeWidth_W
    Friend WithEvents DrakeWidth_W2 As DrakeUI.Framework.DrakeWidth_W
End Class
