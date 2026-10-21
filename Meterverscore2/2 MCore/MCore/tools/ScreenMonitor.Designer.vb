<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class ScreenMonitor
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ScreenMonitor))
        Me.viewimage = New System.Windows.Forms.PictureBox()
        Me.confpanel = New System.Windows.Forms.Panel()
        Me.Panel15 = New System.Windows.Forms.Panel()
        Me.Panel5 = New System.Windows.Forms.Panel()
        Me.recscr = New DrakeUI.Framework.DrakeUIButtonIcon()
        Me.smallviewimage = New System.Windows.Forms.PictureBox()
        Me.Panel11 = New System.Windows.Forms.Panel()
        Me.scrshot = New DrakeUI.Framework.DrakeUIButtonIcon()
        Me.mscrtshots = New DrakeUI.Framework.DrakeUIButtonIcon()
        Me.Panel14 = New System.Windows.Forms.Panel()
        Me.Panel10 = New System.Windows.Forms.Panel()
        Me.sondup = New DrakeUI.Framework.DrakeUIButtonIcon()
        Me.soundown = New DrakeUI.Framework.DrakeUIButtonIcon()
        Me.Panel13 = New System.Windows.Forms.Panel()
        Me.Panel8 = New System.Windows.Forms.Panel()
        Me.keybordon = New DrakeUI.Framework.DrakeUIButtonIcon()
        Me.keybordoff = New DrakeUI.Framework.DrakeUIButtonIcon()
        Me.Panel12 = New System.Windows.Forms.Panel()
        Me.Panel7 = New System.Windows.Forms.Panel()
        Me.lokbtn = New DrakeUI.Framework.DrakeUIButtonIcon()
        Me.unlockbtn = New DrakeUI.Framework.DrakeUIButtonIcon()
        Me.coloskeletonpick = New DrakeUI.Framework.DrakeUIColorPicker()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.skltonbtn = New DrakeUI.Framework.DrakeUIButtonIcon()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.blockbtn = New DrakeUI.Framework.DrakeUIButtonIcon()
        Me.Panel44 = New System.Windows.Forms.Panel()
        Me.ctrlbtn = New DrakeUI.Framework.DrakeUIButtonIcon()
        Me.DrakeWidth_W2 = New DrakeUI.Framework.DrakeWidth_W()
        Me.Panel32 = New System.Windows.Forms.Panel()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.qualitybar = New DrakeUI.Framework.DrakeUITrackBar()
        Me.comboTargts = New DrakeUI.Framework.DrakeUIComboBox()
        Me.startbtn = New DrakeUI.Framework.DrakeUIButtonIcon()
        Me.stopbtn = New DrakeUI.Framework.DrakeUIButtonIcon()
        Me.confbtn = New DrakeUI.Framework.DrakeUIButtonIcon()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.DrakeWidth_W3 = New DrakeUI.Framework.DrakeWidth_W()
        Me.DrakeWidth_W11 = New DrakeUI.Framework.DrakeWidth_W()
        Me.Panel26 = New System.Windows.Forms.Panel()
        Me.mainstatelabel = New System.Windows.Forms.Label()
        Me.statetimer = New System.Windows.Forms.Timer(Me.components)
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.DrakeUIButtonIcon11 = New DrakeUI.Framework.DrakeUIButtonIcon()
        Me.DrakeUIButtonIcon10 = New DrakeUI.Framework.DrakeUIButtonIcon()
        Me.DrakeUIButtonIcon9 = New DrakeUI.Framework.DrakeUIButtonIcon()
        Me.inputtext = New DrakeUI.Framework.DrakeUITextBox()
        Me.BTtiptool = New DrakeUI.Framework.DrakeUIToolTip(Me.components)
        Me.savertimer = New System.Windows.Forms.Timer(Me.components)
        CType(Me.myscr, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.myico, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.viewimage, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.confpanel.SuspendLayout()
        Me.Panel15.SuspendLayout()
        Me.Panel5.SuspendLayout()
        CType(Me.smallviewimage, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel11.SuspendLayout()
        Me.Panel10.SuspendLayout()
        Me.Panel8.SuspendLayout()
        Me.Panel7.SuspendLayout()
        Me.Panel4.SuspendLayout()
        Me.Panel3.SuspendLayout()
        Me.Panel44.SuspendLayout()
        Me.Panel32.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.Panel26.SuspendLayout()
        Me.TableLayoutPanel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'myscr
        '
        Me.myscr.Image = Global.BTMOB.My.Resources.Resources.btloader
        Me.myscr.Size = New System.Drawing.Size(47, 30)
        Me.myscr.Visible = False
        '
        'pinbtn
        '
        Me.pinbtn.Location = New System.Drawing.Point(397, 5)
        '
        'minibtn
        '
        Me.minibtn.Location = New System.Drawing.Point(444, 5)
        '
        'closbtn
        '
        Me.closbtn.Location = New System.Drawing.Point(491, 5)
        '
        'mytitle
        '
        Me.mytitle.Size = New System.Drawing.Size(523, 18)
        '
        'viewimage
        '
        Me.viewimage.Dock = System.Windows.Forms.DockStyle.Fill
        Me.viewimage.Location = New System.Drawing.Point(108, 167)
        Me.viewimage.Name = "viewimage"
        Me.viewimage.Size = New System.Drawing.Size(427, 858)
        Me.viewimage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.viewimage.TabIndex = 40
        Me.viewimage.TabStop = False
        '
        'confpanel
        '
        Me.confpanel.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.confpanel.Controls.Add(Me.Panel15)
        Me.confpanel.Controls.Add(Me.Panel11)
        Me.confpanel.Controls.Add(Me.Panel14)
        Me.confpanel.Controls.Add(Me.Panel10)
        Me.confpanel.Controls.Add(Me.Panel13)
        Me.confpanel.Controls.Add(Me.Panel8)
        Me.confpanel.Controls.Add(Me.Panel12)
        Me.confpanel.Controls.Add(Me.Panel7)
        Me.confpanel.Controls.Add(Me.coloskeletonpick)
        Me.confpanel.Controls.Add(Me.Panel4)
        Me.confpanel.Controls.Add(Me.Panel3)
        Me.confpanel.Controls.Add(Me.Panel44)
        Me.confpanel.Controls.Add(Me.DrakeWidth_W2)
        Me.confpanel.Dock = System.Windows.Forms.DockStyle.Left
        Me.confpanel.Location = New System.Drawing.Point(2, 167)
        Me.confpanel.Name = "confpanel"
        Me.confpanel.Size = New System.Drawing.Size(106, 858)
        Me.confpanel.TabIndex = 41
        '
        'Panel15
        '
        Me.Panel15.Controls.Add(Me.Panel5)
        Me.Panel15.Controls.Add(Me.smallviewimage)
        Me.Panel15.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel15.Location = New System.Drawing.Point(0, 397)
        Me.Panel15.Name = "Panel15"
        Me.Panel15.Size = New System.Drawing.Size(104, 461)
        Me.Panel15.TabIndex = 65
        '
        'Panel5
        '
        Me.Panel5.Controls.Add(Me.recscr)
        Me.Panel5.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel5.Location = New System.Drawing.Point(0, 0)
        Me.Panel5.Name = "Panel5"
        Me.Panel5.Padding = New System.Windows.Forms.Padding(8)
        Me.Panel5.Size = New System.Drawing.Size(104, 65)
        Me.Panel5.TabIndex = 50
        '
        'recscr
        '
        Me.recscr.BackColor = System.Drawing.Color.FromArgb(CType(CType(35, Byte), Integer), CType(CType(35, Byte), Integer), CType(CType(35, Byte), Integer))
        Me.recscr.Cursor = System.Windows.Forms.Cursors.Hand
        Me.recscr.Dock = System.Windows.Forms.DockStyle.Fill
        Me.recscr.FillColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.recscr.FillHoverColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.recscr.FillPressColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.recscr.FillSelectedColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.recscr.Font = New System.Drawing.Font("Cascadia Code", 9.0!)
        Me.recscr.ForeHoverColor = System.Drawing.Color.Gray
        Me.recscr.Location = New System.Drawing.Point(8, 8)
        Me.recscr.Name = "recscr"
        Me.recscr.RadiusSides = DrakeUI.Framework.UICornerRadiusSides.None
        Me.recscr.RectColor = System.Drawing.Color.Gray
        Me.recscr.RectDisableColor = System.Drawing.Color.FromArgb(CType(CType(227, Byte), Integer), CType(CType(242, Byte), Integer), CType(CType(253, Byte), Integer))
        Me.recscr.RectHoverColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.recscr.RectPressColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(45, Byte), Integer))
        Me.recscr.RectSelectedColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(45, Byte), Integer))
        Me.recscr.RectSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.Bottom
        Me.recscr.Size = New System.Drawing.Size(88, 49)
        Me.recscr.Style = DrakeUI.Framework.UIStyle.Custom
        Me.recscr.Symbol = 57572
        Me.recscr.SymbolSize = 30
        Me.recscr.TabIndex = 36
        Me.recscr.Tag = "0"
        Me.BTtiptool.SetToolTip(Me.recscr, "Skeleton View")
        '
        'smallviewimage
        '
        Me.smallviewimage.Cursor = System.Windows.Forms.Cursors.Hand
        Me.smallviewimage.Dock = System.Windows.Forms.DockStyle.Fill
        Me.smallviewimage.Location = New System.Drawing.Point(0, 0)
        Me.smallviewimage.Name = "smallviewimage"
        Me.smallviewimage.Size = New System.Drawing.Size(104, 461)
        Me.smallviewimage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.smallviewimage.TabIndex = 41
        Me.smallviewimage.TabStop = False
        '
        'Panel11
        '
        Me.Panel11.Controls.Add(Me.scrshot)
        Me.Panel11.Controls.Add(Me.mscrtshots)
        Me.Panel11.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel11.Location = New System.Drawing.Point(0, 358)
        Me.Panel11.Name = "Panel11"
        Me.Panel11.Size = New System.Drawing.Size(104, 39)
        Me.Panel11.TabIndex = 61
        '
        'scrshot
        '
        Me.scrshot.Cursor = System.Windows.Forms.Cursors.Hand
        Me.scrshot.Dock = System.Windows.Forms.DockStyle.Right
        Me.scrshot.FillColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.scrshot.FillDisableColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.scrshot.FillHoverColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.scrshot.FillPressColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.scrshot.FillSelectedColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.scrshot.Font = New System.Drawing.Font("Cascadia Code", 9.0!)
        Me.scrshot.ForeHoverColor = System.Drawing.Color.Gray
        Me.scrshot.Location = New System.Drawing.Point(-6, 0)
        Me.scrshot.Name = "scrshot"
        Me.scrshot.RadiusSides = DrakeUI.Framework.UICornerRadiusSides.None
        Me.scrshot.RectColor = System.Drawing.Color.Gray
        Me.scrshot.RectDisableColor = System.Drawing.Color.FromArgb(CType(CType(227, Byte), Integer), CType(CType(242, Byte), Integer), CType(CType(253, Byte), Integer))
        Me.scrshot.RectHoverColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.scrshot.RectPressColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(45, Byte), Integer))
        Me.scrshot.RectSelectedColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(45, Byte), Integer))
        Me.scrshot.RectSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.Bottom
        Me.scrshot.Size = New System.Drawing.Size(55, 39)
        Me.scrshot.Style = DrakeUI.Framework.UIStyle.Custom
        Me.scrshot.Symbol = 61502
        Me.scrshot.TabIndex = 7
        '
        'mscrtshots
        '
        Me.mscrtshots.Cursor = System.Windows.Forms.Cursors.Hand
        Me.mscrtshots.Dock = System.Windows.Forms.DockStyle.Right
        Me.mscrtshots.FillColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.mscrtshots.FillDisableColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.mscrtshots.FillHoverColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.mscrtshots.FillPressColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.mscrtshots.FillSelectedColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.mscrtshots.Font = New System.Drawing.Font("Cascadia Code", 9.0!)
        Me.mscrtshots.ForeHoverColor = System.Drawing.Color.Gray
        Me.mscrtshots.Location = New System.Drawing.Point(49, 0)
        Me.mscrtshots.Name = "mscrtshots"
        Me.mscrtshots.RadiusSides = DrakeUI.Framework.UICornerRadiusSides.None
        Me.mscrtshots.RectColor = System.Drawing.Color.Gray
        Me.mscrtshots.RectDisableColor = System.Drawing.Color.FromArgb(CType(CType(227, Byte), Integer), CType(CType(242, Byte), Integer), CType(CType(253, Byte), Integer))
        Me.mscrtshots.RectHoverColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.mscrtshots.RectPressColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(45, Byte), Integer))
        Me.mscrtshots.RectSelectedColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(45, Byte), Integer))
        Me.mscrtshots.RectSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.Bottom
        Me.mscrtshots.Size = New System.Drawing.Size(55, 39)
        Me.mscrtshots.Style = DrakeUI.Framework.UIStyle.Custom
        Me.mscrtshots.Symbol = 57350
        Me.mscrtshots.TabIndex = 20
        '
        'Panel14
        '
        Me.Panel14.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel14.Location = New System.Drawing.Point(0, 353)
        Me.Panel14.Name = "Panel14"
        Me.Panel14.Size = New System.Drawing.Size(104, 5)
        Me.Panel14.TabIndex = 64
        '
        'Panel10
        '
        Me.Panel10.Controls.Add(Me.sondup)
        Me.Panel10.Controls.Add(Me.soundown)
        Me.Panel10.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel10.Location = New System.Drawing.Point(0, 314)
        Me.Panel10.Name = "Panel10"
        Me.Panel10.Size = New System.Drawing.Size(104, 39)
        Me.Panel10.TabIndex = 60
        '
        'sondup
        '
        Me.sondup.Cursor = System.Windows.Forms.Cursors.Hand
        Me.sondup.Dock = System.Windows.Forms.DockStyle.Right
        Me.sondup.FillColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.sondup.FillDisableColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.sondup.FillHoverColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.sondup.FillPressColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.sondup.FillSelectedColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.sondup.Font = New System.Drawing.Font("Cascadia Code", 9.0!)
        Me.sondup.ForeHoverColor = System.Drawing.Color.Gray
        Me.sondup.Location = New System.Drawing.Point(-6, 0)
        Me.sondup.Name = "sondup"
        Me.sondup.RadiusSides = DrakeUI.Framework.UICornerRadiusSides.None
        Me.sondup.RectColor = System.Drawing.Color.Gray
        Me.sondup.RectDisableColor = System.Drawing.Color.FromArgb(CType(CType(227, Byte), Integer), CType(CType(242, Byte), Integer), CType(CType(253, Byte), Integer))
        Me.sondup.RectHoverColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.sondup.RectPressColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(45, Byte), Integer))
        Me.sondup.RectSelectedColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(45, Byte), Integer))
        Me.sondup.RectSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.Bottom
        Me.sondup.Size = New System.Drawing.Size(55, 39)
        Me.sondup.Style = DrakeUI.Framework.UIStyle.Custom
        Me.sondup.Symbol = 57448
        Me.sondup.TabIndex = 20
        '
        'soundown
        '
        Me.soundown.Cursor = System.Windows.Forms.Cursors.Hand
        Me.soundown.Dock = System.Windows.Forms.DockStyle.Right
        Me.soundown.FillColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.soundown.FillDisableColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.soundown.FillHoverColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.soundown.FillPressColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.soundown.FillSelectedColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.soundown.Font = New System.Drawing.Font("Cascadia Code", 9.0!)
        Me.soundown.ForeHoverColor = System.Drawing.Color.Gray
        Me.soundown.Location = New System.Drawing.Point(49, 0)
        Me.soundown.Name = "soundown"
        Me.soundown.RadiusSides = DrakeUI.Framework.UICornerRadiusSides.None
        Me.soundown.RectColor = System.Drawing.Color.Gray
        Me.soundown.RectDisableColor = System.Drawing.Color.FromArgb(CType(CType(227, Byte), Integer), CType(CType(242, Byte), Integer), CType(CType(253, Byte), Integer))
        Me.soundown.RectHoverColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.soundown.RectPressColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(45, Byte), Integer))
        Me.soundown.RectSelectedColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(45, Byte), Integer))
        Me.soundown.RectSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.Bottom
        Me.soundown.Size = New System.Drawing.Size(55, 39)
        Me.soundown.Style = DrakeUI.Framework.UIStyle.Custom
        Me.soundown.Symbol = 57449
        Me.soundown.TabIndex = 7
        '
        'Panel13
        '
        Me.Panel13.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel13.Location = New System.Drawing.Point(0, 309)
        Me.Panel13.Name = "Panel13"
        Me.Panel13.Size = New System.Drawing.Size(104, 5)
        Me.Panel13.TabIndex = 63
        '
        'Panel8
        '
        Me.Panel8.Controls.Add(Me.keybordon)
        Me.Panel8.Controls.Add(Me.keybordoff)
        Me.Panel8.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel8.Location = New System.Drawing.Point(0, 270)
        Me.Panel8.Name = "Panel8"
        Me.Panel8.Size = New System.Drawing.Size(104, 39)
        Me.Panel8.TabIndex = 59
        '
        'keybordon
        '
        Me.keybordon.Cursor = System.Windows.Forms.Cursors.Hand
        Me.keybordon.Dock = System.Windows.Forms.DockStyle.Right
        Me.keybordon.FillColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.keybordon.FillDisableColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.keybordon.FillHoverColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.keybordon.FillPressColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.keybordon.FillSelectedColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.keybordon.Font = New System.Drawing.Font("Cascadia Code", 9.0!)
        Me.keybordon.ForeHoverColor = System.Drawing.Color.Gray
        Me.keybordon.Location = New System.Drawing.Point(-6, 0)
        Me.keybordon.Name = "keybordon"
        Me.keybordon.RadiusSides = DrakeUI.Framework.UICornerRadiusSides.None
        Me.keybordon.RectColor = System.Drawing.Color.Gray
        Me.keybordon.RectDisableColor = System.Drawing.Color.FromArgb(CType(CType(227, Byte), Integer), CType(CType(242, Byte), Integer), CType(CType(253, Byte), Integer))
        Me.keybordon.RectHoverColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.keybordon.RectPressColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(45, Byte), Integer))
        Me.keybordon.RectSelectedColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(45, Byte), Integer))
        Me.keybordon.RectSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.Bottom
        Me.keybordon.Size = New System.Drawing.Size(55, 39)
        Me.keybordon.Style = DrakeUI.Framework.UIStyle.Custom
        Me.keybordon.Symbol = 61753
        Me.keybordon.TabIndex = 20
        '
        'keybordoff
        '
        Me.keybordoff.Cursor = System.Windows.Forms.Cursors.Hand
        Me.keybordoff.Dock = System.Windows.Forms.DockStyle.Right
        Me.keybordoff.FillColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.keybordoff.FillDisableColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.keybordoff.FillHoverColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.keybordoff.FillPressColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.keybordoff.FillSelectedColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.keybordoff.Font = New System.Drawing.Font("Cascadia Code", 9.0!)
        Me.keybordoff.ForeHoverColor = System.Drawing.Color.Gray
        Me.keybordoff.Location = New System.Drawing.Point(49, 0)
        Me.keybordoff.Name = "keybordoff"
        Me.keybordoff.RadiusSides = DrakeUI.Framework.UICornerRadiusSides.None
        Me.keybordoff.RectColor = System.Drawing.Color.Gray
        Me.keybordoff.RectDisableColor = System.Drawing.Color.FromArgb(CType(CType(227, Byte), Integer), CType(CType(242, Byte), Integer), CType(CType(253, Byte), Integer))
        Me.keybordoff.RectHoverColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.keybordoff.RectPressColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(45, Byte), Integer))
        Me.keybordoff.RectSelectedColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(45, Byte), Integer))
        Me.keybordoff.RectSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.Bottom
        Me.keybordoff.Size = New System.Drawing.Size(55, 39)
        Me.keybordoff.Style = DrakeUI.Framework.UIStyle.Custom
        Me.keybordoff.Symbol = 61754
        Me.keybordoff.TabIndex = 7
        '
        'Panel12
        '
        Me.Panel12.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel12.Location = New System.Drawing.Point(0, 265)
        Me.Panel12.Name = "Panel12"
        Me.Panel12.Size = New System.Drawing.Size(104, 5)
        Me.Panel12.TabIndex = 62
        '
        'Panel7
        '
        Me.Panel7.Controls.Add(Me.lokbtn)
        Me.Panel7.Controls.Add(Me.unlockbtn)
        Me.Panel7.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel7.Location = New System.Drawing.Point(0, 226)
        Me.Panel7.Name = "Panel7"
        Me.Panel7.Size = New System.Drawing.Size(104, 39)
        Me.Panel7.TabIndex = 56
        '
        'lokbtn
        '
        Me.lokbtn.Cursor = System.Windows.Forms.Cursors.Hand
        Me.lokbtn.Dock = System.Windows.Forms.DockStyle.Right
        Me.lokbtn.FillColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.lokbtn.FillDisableColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.lokbtn.FillHoverColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.lokbtn.FillPressColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.lokbtn.FillSelectedColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.lokbtn.Font = New System.Drawing.Font("Cascadia Code", 9.0!)
        Me.lokbtn.ForeHoverColor = System.Drawing.Color.Gray
        Me.lokbtn.Location = New System.Drawing.Point(-6, 0)
        Me.lokbtn.Name = "lokbtn"
        Me.lokbtn.RadiusSides = DrakeUI.Framework.UICornerRadiusSides.None
        Me.lokbtn.RectColor = System.Drawing.Color.Gray
        Me.lokbtn.RectDisableColor = System.Drawing.Color.FromArgb(CType(CType(227, Byte), Integer), CType(CType(242, Byte), Integer), CType(CType(253, Byte), Integer))
        Me.lokbtn.RectHoverColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.lokbtn.RectPressColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(45, Byte), Integer))
        Me.lokbtn.RectSelectedColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(45, Byte), Integer))
        Me.lokbtn.RectSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.Bottom
        Me.lokbtn.Size = New System.Drawing.Size(55, 39)
        Me.lokbtn.Style = DrakeUI.Framework.UIStyle.Custom
        Me.lokbtn.Symbol = 57452
        Me.lokbtn.TabIndex = 20
        '
        'unlockbtn
        '
        Me.unlockbtn.Cursor = System.Windows.Forms.Cursors.Hand
        Me.unlockbtn.Dock = System.Windows.Forms.DockStyle.Right
        Me.unlockbtn.FillColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.unlockbtn.FillDisableColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.unlockbtn.FillHoverColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.unlockbtn.FillPressColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.unlockbtn.FillSelectedColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.unlockbtn.Font = New System.Drawing.Font("Cascadia Code", 9.0!)
        Me.unlockbtn.ForeHoverColor = System.Drawing.Color.Gray
        Me.unlockbtn.Location = New System.Drawing.Point(49, 0)
        Me.unlockbtn.Name = "unlockbtn"
        Me.unlockbtn.RadiusSides = DrakeUI.Framework.UICornerRadiusSides.None
        Me.unlockbtn.RectColor = System.Drawing.Color.Gray
        Me.unlockbtn.RectDisableColor = System.Drawing.Color.FromArgb(CType(CType(227, Byte), Integer), CType(CType(242, Byte), Integer), CType(CType(253, Byte), Integer))
        Me.unlockbtn.RectHoverColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.unlockbtn.RectPressColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(45, Byte), Integer))
        Me.unlockbtn.RectSelectedColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(45, Byte), Integer))
        Me.unlockbtn.RectSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.Bottom
        Me.unlockbtn.Size = New System.Drawing.Size(55, 39)
        Me.unlockbtn.Style = DrakeUI.Framework.UIStyle.Custom
        Me.unlockbtn.Symbol = 57453
        Me.unlockbtn.TabIndex = 7
        '
        'coloskeletonpick
        '
        Me.coloskeletonpick.Dock = System.Windows.Forms.DockStyle.Top
        Me.coloskeletonpick.DropDownStyle = DrakeUI.Framework.UIDropDownStyle.DropDownList
        Me.coloskeletonpick.FillColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(45, Byte), Integer))
        Me.coloskeletonpick.Font = New System.Drawing.Font("Cascadia Code", 12.0!)
        Me.coloskeletonpick.Location = New System.Drawing.Point(0, 195)
        Me.coloskeletonpick.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.coloskeletonpick.MinimumSize = New System.Drawing.Size(63, 0)
        Me.coloskeletonpick.Name = "coloskeletonpick"
        Me.coloskeletonpick.Padding = New System.Windows.Forms.Padding(0, 0, 30, 0)
        Me.coloskeletonpick.Radius = 10
        Me.coloskeletonpick.RadiusSides = DrakeUI.Framework.UICornerRadiusSides.None
        Me.coloskeletonpick.RectColor = System.Drawing.Color.Gray
        Me.coloskeletonpick.RectDisableColor = System.Drawing.Color.FromArgb(CType(CType(227, Byte), Integer), CType(CType(242, Byte), Integer), CType(CType(253, Byte), Integer))
        Me.coloskeletonpick.RectSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.Bottom
        Me.coloskeletonpick.Size = New System.Drawing.Size(104, 31)
        Me.coloskeletonpick.Style = DrakeUI.Framework.UIStyle.Custom
        Me.coloskeletonpick.TabIndex = 51
        Me.coloskeletonpick.Text = "ColorPickers"
        Me.coloskeletonpick.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft
        Me.coloskeletonpick.Value = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(136, Byte), Integer), CType(CType(229, Byte), Integer))
        Me.coloskeletonpick.Watermark = ""
        '
        'Panel4
        '
        Me.Panel4.Controls.Add(Me.skltonbtn)
        Me.Panel4.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel4.Location = New System.Drawing.Point(0, 130)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Padding = New System.Windows.Forms.Padding(8)
        Me.Panel4.Size = New System.Drawing.Size(104, 65)
        Me.Panel4.TabIndex = 49
        '
        'skltonbtn
        '
        Me.skltonbtn.BackColor = System.Drawing.Color.FromArgb(CType(CType(35, Byte), Integer), CType(CType(35, Byte), Integer), CType(CType(35, Byte), Integer))
        Me.skltonbtn.Cursor = System.Windows.Forms.Cursors.Hand
        Me.skltonbtn.Dock = System.Windows.Forms.DockStyle.Fill
        Me.skltonbtn.FillColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.skltonbtn.FillHoverColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.skltonbtn.FillPressColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.skltonbtn.FillSelectedColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.skltonbtn.Font = New System.Drawing.Font("Cascadia Code", 9.0!)
        Me.skltonbtn.ForeHoverColor = System.Drawing.Color.Gray
        Me.skltonbtn.Location = New System.Drawing.Point(8, 8)
        Me.skltonbtn.Name = "skltonbtn"
        Me.skltonbtn.RadiusSides = DrakeUI.Framework.UICornerRadiusSides.None
        Me.skltonbtn.RectColor = System.Drawing.Color.Gray
        Me.skltonbtn.RectDisableColor = System.Drawing.Color.FromArgb(CType(CType(227, Byte), Integer), CType(CType(242, Byte), Integer), CType(CType(253, Byte), Integer))
        Me.skltonbtn.RectHoverColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.skltonbtn.RectPressColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(45, Byte), Integer))
        Me.skltonbtn.RectSelectedColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(45, Byte), Integer))
        Me.skltonbtn.RectSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.Bottom
        Me.skltonbtn.Size = New System.Drawing.Size(88, 49)
        Me.skltonbtn.Style = DrakeUI.Framework.UIStyle.Custom
        Me.skltonbtn.Symbol = 57485
        Me.skltonbtn.SymbolSize = 30
        Me.skltonbtn.TabIndex = 36
        Me.skltonbtn.Tag = "0"
        Me.BTtiptool.SetToolTip(Me.skltonbtn, "Skeleton View")
        '
        'Panel3
        '
        Me.Panel3.Controls.Add(Me.blockbtn)
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel3.Location = New System.Drawing.Point(0, 65)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Padding = New System.Windows.Forms.Padding(8)
        Me.Panel3.Size = New System.Drawing.Size(104, 65)
        Me.Panel3.TabIndex = 48
        '
        'blockbtn
        '
        Me.blockbtn.BackColor = System.Drawing.Color.FromArgb(CType(CType(35, Byte), Integer), CType(CType(35, Byte), Integer), CType(CType(35, Byte), Integer))
        Me.blockbtn.Cursor = System.Windows.Forms.Cursors.Hand
        Me.blockbtn.Dock = System.Windows.Forms.DockStyle.Fill
        Me.blockbtn.FillColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.blockbtn.FillHoverColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.blockbtn.FillPressColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.blockbtn.FillSelectedColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.blockbtn.Font = New System.Drawing.Font("Cascadia Code", 9.0!)
        Me.blockbtn.ForeHoverColor = System.Drawing.Color.Gray
        Me.blockbtn.Location = New System.Drawing.Point(8, 8)
        Me.blockbtn.Name = "blockbtn"
        Me.blockbtn.RadiusSides = DrakeUI.Framework.UICornerRadiusSides.None
        Me.blockbtn.RectColor = System.Drawing.Color.Gray
        Me.blockbtn.RectDisableColor = System.Drawing.Color.FromArgb(CType(CType(227, Byte), Integer), CType(CType(242, Byte), Integer), CType(CType(253, Byte), Integer))
        Me.blockbtn.RectHoverColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.blockbtn.RectPressColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(45, Byte), Integer))
        Me.blockbtn.RectSelectedColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(45, Byte), Integer))
        Me.blockbtn.RectSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.Bottom
        Me.blockbtn.Size = New System.Drawing.Size(88, 49)
        Me.blockbtn.Style = DrakeUI.Framework.UIStyle.Custom
        Me.blockbtn.Symbol = 61552
        Me.blockbtn.SymbolSize = 30
        Me.blockbtn.TabIndex = 35
        Me.blockbtn.Tag = "0"
        Me.BTtiptool.SetToolTip(Me.blockbtn, "Black Screen")
        '
        'Panel44
        '
        Me.Panel44.Controls.Add(Me.ctrlbtn)
        Me.Panel44.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel44.Location = New System.Drawing.Point(0, 0)
        Me.Panel44.Name = "Panel44"
        Me.Panel44.Padding = New System.Windows.Forms.Padding(8)
        Me.Panel44.Size = New System.Drawing.Size(104, 65)
        Me.Panel44.TabIndex = 47
        '
        'ctrlbtn
        '
        Me.ctrlbtn.BackColor = System.Drawing.Color.FromArgb(CType(CType(35, Byte), Integer), CType(CType(35, Byte), Integer), CType(CType(35, Byte), Integer))
        Me.ctrlbtn.Cursor = System.Windows.Forms.Cursors.Hand
        Me.ctrlbtn.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ctrlbtn.FillColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.ctrlbtn.FillHoverColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.ctrlbtn.FillPressColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.ctrlbtn.FillSelectedColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.ctrlbtn.Font = New System.Drawing.Font("Cascadia Code", 9.0!)
        Me.ctrlbtn.ForeHoverColor = System.Drawing.Color.Gray
        Me.ctrlbtn.Location = New System.Drawing.Point(8, 8)
        Me.ctrlbtn.Name = "ctrlbtn"
        Me.ctrlbtn.RadiusSides = DrakeUI.Framework.UICornerRadiusSides.None
        Me.ctrlbtn.RectColor = System.Drawing.Color.Gray
        Me.ctrlbtn.RectDisableColor = System.Drawing.Color.FromArgb(CType(CType(227, Byte), Integer), CType(CType(242, Byte), Integer), CType(CType(253, Byte), Integer))
        Me.ctrlbtn.RectHoverColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.ctrlbtn.RectPressColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(45, Byte), Integer))
        Me.ctrlbtn.RectSelectedColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(45, Byte), Integer))
        Me.ctrlbtn.RectSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.Bottom
        Me.ctrlbtn.Size = New System.Drawing.Size(88, 49)
        Me.ctrlbtn.Style = DrakeUI.Framework.UIStyle.Custom
        Me.ctrlbtn.Symbol = 62042
        Me.ctrlbtn.SymbolSize = 30
        Me.ctrlbtn.TabIndex = 34
        Me.ctrlbtn.Tag = "0"
        Me.BTtiptool.SetToolTip(Me.ctrlbtn, "Control Screen")
        '
        'DrakeWidth_W2
        '
        Me.DrakeWidth_W2.BackColor = System.Drawing.Color.Gray
        Me.DrakeWidth_W2.Cursor = System.Windows.Forms.Cursors.SizeWE
        Me.DrakeWidth_W2.Dock = System.Windows.Forms.DockStyle.Right
        Me.DrakeWidth_W2.Location = New System.Drawing.Point(104, 0)
        Me.DrakeWidth_W2.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.DrakeWidth_W2.Name = "DrakeWidth_W2"
        Me.DrakeWidth_W2.Size = New System.Drawing.Size(2, 858)
        Me.DrakeWidth_W2.TabIndex = 42
        '
        'Panel32
        '
        Me.Panel32.Controls.Add(Me.Label5)
        Me.Panel32.Controls.Add(Me.qualitybar)
        Me.Panel32.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel32.Location = New System.Drawing.Point(2, 116)
        Me.Panel32.Name = "Panel32"
        Me.Panel32.Size = New System.Drawing.Size(533, 51)
        Me.Panel32.TabIndex = 55
        '
        'Label5
        '
        Me.Label5.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Label5.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label5.Font = New System.Drawing.Font("Cascadia Code", 9.0!)
        Me.Label5.ForeColor = System.Drawing.Color.White
        Me.Label5.Location = New System.Drawing.Point(0, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(201, 51)
        Me.Label5.TabIndex = 18
        Me.Label5.Text = "Image quality"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'qualitybar
        '
        Me.qualitybar.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.qualitybar.DisableColor = System.Drawing.Color.FromArgb(CType(CType(227, Byte), Integer), CType(CType(242, Byte), Integer), CType(CType(253, Byte), Integer))
        Me.qualitybar.Dock = System.Windows.Forms.DockStyle.Right
        Me.qualitybar.FillColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.qualitybar.Font = New System.Drawing.Font("Cascadia Code", 12.0!)
        Me.qualitybar.ForeColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(136, Byte), Integer), CType(CType(229, Byte), Integer))
        Me.qualitybar.Location = New System.Drawing.Point(201, 0)
        Me.qualitybar.Minimum = 10
        Me.qualitybar.Name = "qualitybar"
        Me.qualitybar.RectColor = System.Drawing.Color.White
        Me.qualitybar.Size = New System.Drawing.Size(332, 51)
        Me.qualitybar.Style = DrakeUI.Framework.UIStyle.Custom
        Me.qualitybar.TabIndex = 5
        Me.qualitybar.Text = "DrakeUITrackBar4"
        Me.qualitybar.Value = 10
        '
        'comboTargts
        '
        Me.comboTargts.Dock = System.Windows.Forms.DockStyle.Left
        Me.comboTargts.DropDownStyle = DrakeUI.Framework.UIDropDownStyle.DropDownList
        Me.comboTargts.FillColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.comboTargts.Font = New System.Drawing.Font("Cascadia Code", 9.0!)
        Me.comboTargts.ForeColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.comboTargts.Items.AddRange(New Object() {"Live screen", "Silent mode", "Skeleton view", "In App"})
        Me.comboTargts.Location = New System.Drawing.Point(65, 10)
        Me.comboTargts.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.comboTargts.MinimumSize = New System.Drawing.Size(63, 0)
        Me.comboTargts.Name = "comboTargts"
        Me.comboTargts.Padding = New System.Windows.Forms.Padding(0, 0, 30, 0)
        Me.comboTargts.RadiusSides = DrakeUI.Framework.UICornerRadiusSides.None
        Me.comboTargts.RectColor = System.Drawing.Color.Gray
        Me.comboTargts.RectDisableColor = System.Drawing.Color.FromArgb(CType(CType(227, Byte), Integer), CType(CType(242, Byte), Integer), CType(CType(253, Byte), Integer))
        Me.comboTargts.RectSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.Bottom
        Me.comboTargts.Size = New System.Drawing.Size(175, 25)
        Me.comboTargts.Style = DrakeUI.Framework.UIStyle.Custom
        Me.comboTargts.TabIndex = 1
        Me.comboTargts.Text = "Live screen"
        Me.comboTargts.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft
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
        Me.startbtn.Location = New System.Drawing.Point(468, 10)
        Me.startbtn.Name = "startbtn"
        Me.startbtn.RadiusSides = DrakeUI.Framework.UICornerRadiusSides.None
        Me.startbtn.RectColor = System.Drawing.Color.Gray
        Me.startbtn.RectDisableColor = System.Drawing.Color.FromArgb(CType(CType(227, Byte), Integer), CType(CType(242, Byte), Integer), CType(CType(253, Byte), Integer))
        Me.startbtn.RectHoverColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.startbtn.RectPressColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(45, Byte), Integer))
        Me.startbtn.RectSelectedColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(45, Byte), Integer))
        Me.startbtn.RectSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.Bottom
        Me.startbtn.Size = New System.Drawing.Size(55, 25)
        Me.startbtn.Style = DrakeUI.Framework.UIStyle.Custom
        Me.startbtn.Symbol = 61515
        Me.startbtn.TabIndex = 5
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
        Me.stopbtn.Location = New System.Drawing.Point(403, 10)
        Me.stopbtn.Name = "stopbtn"
        Me.stopbtn.RadiusSides = DrakeUI.Framework.UICornerRadiusSides.None
        Me.stopbtn.RectColor = System.Drawing.Color.Gray
        Me.stopbtn.RectDisableColor = System.Drawing.Color.FromArgb(CType(CType(227, Byte), Integer), CType(CType(242, Byte), Integer), CType(CType(253, Byte), Integer))
        Me.stopbtn.RectHoverColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.stopbtn.RectPressColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(45, Byte), Integer))
        Me.stopbtn.RectSelectedColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(45, Byte), Integer))
        Me.stopbtn.RectSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.Bottom
        Me.stopbtn.Size = New System.Drawing.Size(55, 25)
        Me.stopbtn.Style = DrakeUI.Framework.UIStyle.Custom
        Me.stopbtn.Symbol = 61516
        Me.stopbtn.TabIndex = 6
        '
        'confbtn
        '
        Me.confbtn.Cursor = System.Windows.Forms.Cursors.Hand
        Me.confbtn.Dock = System.Windows.Forms.DockStyle.Left
        Me.confbtn.FillColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.confbtn.FillHoverColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.confbtn.FillPressColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.confbtn.FillSelectedColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.confbtn.Font = New System.Drawing.Font("Cascadia Code", 9.0!)
        Me.confbtn.ForeHoverColor = System.Drawing.Color.Gray
        Me.confbtn.Location = New System.Drawing.Point(10, 10)
        Me.confbtn.Name = "confbtn"
        Me.confbtn.RadiusSides = DrakeUI.Framework.UICornerRadiusSides.None
        Me.confbtn.RectColor = System.Drawing.Color.Gray
        Me.confbtn.RectDisableColor = System.Drawing.Color.FromArgb(CType(CType(227, Byte), Integer), CType(CType(242, Byte), Integer), CType(CType(253, Byte), Integer))
        Me.confbtn.RectHoverColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.confbtn.RectPressColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(45, Byte), Integer))
        Me.confbtn.RectSelectedColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(45, Byte), Integer))
        Me.confbtn.RectSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.Bottom
        Me.confbtn.Size = New System.Drawing.Size(45, 25)
        Me.confbtn.Style = DrakeUI.Framework.UIStyle.Custom
        Me.confbtn.Symbol = 61573
        Me.confbtn.TabIndex = 34
        Me.confbtn.Tag = "0"
        Me.BTtiptool.SetToolTip(Me.confbtn, "Config")
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Panel2.Controls.Add(Me.stopbtn)
        Me.Panel2.Controls.Add(Me.DrakeWidth_W3)
        Me.Panel2.Controls.Add(Me.startbtn)
        Me.Panel2.Controls.Add(Me.comboTargts)
        Me.Panel2.Controls.Add(Me.DrakeWidth_W11)
        Me.Panel2.Controls.Add(Me.confbtn)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel2.Location = New System.Drawing.Point(2, 71)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Padding = New System.Windows.Forms.Padding(10)
        Me.Panel2.Size = New System.Drawing.Size(533, 45)
        Me.Panel2.TabIndex = 39
        '
        'DrakeWidth_W3
        '
        Me.DrakeWidth_W3.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.DrakeWidth_W3.Dock = System.Windows.Forms.DockStyle.Right
        Me.DrakeWidth_W3.Location = New System.Drawing.Point(458, 10)
        Me.DrakeWidth_W3.Name = "DrakeWidth_W3"
        Me.DrakeWidth_W3.Size = New System.Drawing.Size(10, 25)
        Me.DrakeWidth_W3.TabIndex = 36
        '
        'DrakeWidth_W11
        '
        Me.DrakeWidth_W11.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.DrakeWidth_W11.Dock = System.Windows.Forms.DockStyle.Left
        Me.DrakeWidth_W11.Location = New System.Drawing.Point(55, 10)
        Me.DrakeWidth_W11.Name = "DrakeWidth_W11"
        Me.DrakeWidth_W11.Size = New System.Drawing.Size(10, 25)
        Me.DrakeWidth_W11.TabIndex = 35
        '
        'Panel26
        '
        Me.Panel26.Controls.Add(Me.mainstatelabel)
        Me.Panel26.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel26.Location = New System.Drawing.Point(2, 1080)
        Me.Panel26.Name = "Panel26"
        Me.Panel26.Size = New System.Drawing.Size(533, 20)
        Me.Panel26.TabIndex = 43
        '
        'mainstatelabel
        '
        Me.mainstatelabel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.mainstatelabel.Font = New System.Drawing.Font("Cascadia Code", 8.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.mainstatelabel.ForeColor = System.Drawing.Color.White
        Me.mainstatelabel.Location = New System.Drawing.Point(0, 0)
        Me.mainstatelabel.Name = "mainstatelabel"
        Me.mainstatelabel.Size = New System.Drawing.Size(533, 20)
        Me.mainstatelabel.TabIndex = 1
        Me.mainstatelabel.Text = "..."
        Me.mainstatelabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'statetimer
        '
        Me.statetimer.Interval = 1000
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.ColumnCount = 3
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333!))
        Me.TableLayoutPanel1.Controls.Add(Me.DrakeUIButtonIcon11, 0, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.DrakeUIButtonIcon10, 0, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.DrakeUIButtonIcon9, 0, 0)
        Me.TableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(2, 1025)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 1
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(533, 30)
        Me.TableLayoutPanel1.TabIndex = 48
        '
        'DrakeUIButtonIcon11
        '
        Me.DrakeUIButtonIcon11.Cursor = System.Windows.Forms.Cursors.Hand
        Me.DrakeUIButtonIcon11.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DrakeUIButtonIcon11.FillColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.DrakeUIButtonIcon11.FillDisableColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.DrakeUIButtonIcon11.FillHoverColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.DrakeUIButtonIcon11.FillPressColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.DrakeUIButtonIcon11.FillSelectedColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.DrakeUIButtonIcon11.Font = New System.Drawing.Font("Cascadia Code", 9.0!)
        Me.DrakeUIButtonIcon11.ForeHoverColor = System.Drawing.Color.Gray
        Me.DrakeUIButtonIcon11.Location = New System.Drawing.Point(357, 3)
        Me.DrakeUIButtonIcon11.Name = "DrakeUIButtonIcon11"
        Me.DrakeUIButtonIcon11.RadiusSides = DrakeUI.Framework.UICornerRadiusSides.None
        Me.DrakeUIButtonIcon11.RectColor = System.Drawing.Color.Gray
        Me.DrakeUIButtonIcon11.RectDisableColor = System.Drawing.Color.FromArgb(CType(CType(227, Byte), Integer), CType(CType(242, Byte), Integer), CType(CType(253, Byte), Integer))
        Me.DrakeUIButtonIcon11.RectHoverColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.DrakeUIButtonIcon11.RectPressColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(45, Byte), Integer))
        Me.DrakeUIButtonIcon11.RectSelectedColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(45, Byte), Integer))
        Me.DrakeUIButtonIcon11.RectSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.Bottom
        Me.DrakeUIButtonIcon11.Size = New System.Drawing.Size(173, 24)
        Me.DrakeUIButtonIcon11.Style = DrakeUI.Framework.UIStyle.Custom
        Me.DrakeUIButtonIcon11.Symbol = 61540
        Me.DrakeUIButtonIcon11.TabIndex = 23
        '
        'DrakeUIButtonIcon10
        '
        Me.DrakeUIButtonIcon10.Cursor = System.Windows.Forms.Cursors.Hand
        Me.DrakeUIButtonIcon10.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DrakeUIButtonIcon10.FillColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.DrakeUIButtonIcon10.FillDisableColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.DrakeUIButtonIcon10.FillHoverColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.DrakeUIButtonIcon10.FillPressColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.DrakeUIButtonIcon10.FillSelectedColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.DrakeUIButtonIcon10.Font = New System.Drawing.Font("Cascadia Code", 9.0!)
        Me.DrakeUIButtonIcon10.ForeHoverColor = System.Drawing.Color.Gray
        Me.DrakeUIButtonIcon10.Location = New System.Drawing.Point(180, 3)
        Me.DrakeUIButtonIcon10.Name = "DrakeUIButtonIcon10"
        Me.DrakeUIButtonIcon10.RadiusSides = DrakeUI.Framework.UICornerRadiusSides.None
        Me.DrakeUIButtonIcon10.RectColor = System.Drawing.Color.Gray
        Me.DrakeUIButtonIcon10.RectDisableColor = System.Drawing.Color.FromArgb(CType(CType(227, Byte), Integer), CType(CType(242, Byte), Integer), CType(CType(253, Byte), Integer))
        Me.DrakeUIButtonIcon10.RectHoverColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.DrakeUIButtonIcon10.RectPressColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(45, Byte), Integer))
        Me.DrakeUIButtonIcon10.RectSelectedColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(45, Byte), Integer))
        Me.DrakeUIButtonIcon10.RectSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.Bottom
        Me.DrakeUIButtonIcon10.Size = New System.Drawing.Size(171, 24)
        Me.DrakeUIButtonIcon10.Style = DrakeUI.Framework.UIStyle.Custom
        Me.DrakeUIButtonIcon10.Symbol = 57460
        Me.DrakeUIButtonIcon10.TabIndex = 22
        '
        'DrakeUIButtonIcon9
        '
        Me.DrakeUIButtonIcon9.Cursor = System.Windows.Forms.Cursors.Hand
        Me.DrakeUIButtonIcon9.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DrakeUIButtonIcon9.FillColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.DrakeUIButtonIcon9.FillDisableColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.DrakeUIButtonIcon9.FillHoverColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.DrakeUIButtonIcon9.FillPressColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.DrakeUIButtonIcon9.FillSelectedColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.DrakeUIButtonIcon9.Font = New System.Drawing.Font("Cascadia Code", 9.0!)
        Me.DrakeUIButtonIcon9.ForeHoverColor = System.Drawing.Color.Gray
        Me.DrakeUIButtonIcon9.Location = New System.Drawing.Point(3, 3)
        Me.DrakeUIButtonIcon9.Name = "DrakeUIButtonIcon9"
        Me.DrakeUIButtonIcon9.RadiusSides = DrakeUI.Framework.UICornerRadiusSides.None
        Me.DrakeUIButtonIcon9.RectColor = System.Drawing.Color.Gray
        Me.DrakeUIButtonIcon9.RectDisableColor = System.Drawing.Color.FromArgb(CType(CType(227, Byte), Integer), CType(CType(242, Byte), Integer), CType(CType(253, Byte), Integer))
        Me.DrakeUIButtonIcon9.RectHoverColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.DrakeUIButtonIcon9.RectPressColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(45, Byte), Integer))
        Me.DrakeUIButtonIcon9.RectSelectedColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(45, Byte), Integer))
        Me.DrakeUIButtonIcon9.RectSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.Bottom
        Me.DrakeUIButtonIcon9.Size = New System.Drawing.Size(171, 24)
        Me.DrakeUIButtonIcon9.Style = DrakeUI.Framework.UIStyle.Custom
        Me.DrakeUIButtonIcon9.Symbol = 61641
        Me.DrakeUIButtonIcon9.TabIndex = 21
        '
        'inputtext
        '
        Me.inputtext.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.inputtext.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.inputtext.FillColor = System.Drawing.Color.FromArgb(CType(CType(35, Byte), Integer), CType(CType(35, Byte), Integer), CType(CType(35, Byte), Integer))
        Me.inputtext.FillDisableColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(45, Byte), Integer))
        Me.inputtext.Font = New System.Drawing.Font("Cascadia Code", 9.0!)
        Me.inputtext.ForeColor = System.Drawing.Color.White
        Me.inputtext.Location = New System.Drawing.Point(2, 1055)
        Me.inputtext.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.inputtext.Maximum = 2147483647.0R
        Me.inputtext.Minimum = -2147483648.0R
        Me.inputtext.Name = "inputtext"
        Me.inputtext.Padding = New System.Windows.Forms.Padding(5)
        Me.inputtext.RadiusSides = DrakeUI.Framework.UICornerRadiusSides.None
        Me.inputtext.RectColor = System.Drawing.Color.Gray
        Me.inputtext.RectDisableColor = System.Drawing.Color.FromArgb(CType(CType(227, Byte), Integer), CType(CType(242, Byte), Integer), CType(CType(253, Byte), Integer))
        Me.inputtext.RectSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.Bottom
        Me.inputtext.Size = New System.Drawing.Size(533, 25)
        Me.inputtext.Style = DrakeUI.Framework.UIStyle.Custom
        Me.inputtext.TabIndex = 66
        Me.inputtext.TextAlignment = System.Drawing.ContentAlignment.TopCenter
        Me.inputtext.Watermark = "Send text"
        '
        'BTtiptool
        '
        Me.BTtiptool.BackColor = System.Drawing.Color.FromArgb(CType(CType(54, Byte), Integer), CType(CType(54, Byte), Integer), CType(CType(54, Byte), Integer))
        Me.BTtiptool.Font = New System.Drawing.Font("Cascadia Code", 9.0!)
        Me.BTtiptool.ForeColor = System.Drawing.Color.FromArgb(CType(CType(239, Byte), Integer), CType(CType(239, Byte), Integer), CType(CType(239, Byte), Integer))
        Me.BTtiptool.OwnerDraw = True
        Me.BTtiptool.RectColor = System.Drawing.Color.Gray
        Me.BTtiptool.ShowAlways = True
        Me.BTtiptool.TitleFont = New System.Drawing.Font("Cascadia Code", 9.0!)
        Me.BTtiptool.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info
        Me.BTtiptool.ToolTipTitle = "BT-Tip"
        '
        'savertimer
        '
        Me.savertimer.Interval = 1000
        '
        'ScreenMonitor
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(537, 1102)
        Me.Controls.Add(Me.viewimage)
        Me.Controls.Add(Me.confpanel)
        Me.Controls.Add(Me.TableLayoutPanel1)
        Me.Controls.Add(Me.inputtext)
        Me.Controls.Add(Me.Panel32)
        Me.Controls.Add(Me.Panel26)
        Me.Controls.Add(Me.Panel2)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MinimumSize = New System.Drawing.Size(494, 1028)
        Me.Name = "ScreenMonitor"
        Me.ShowIcon = True
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "MCore | Live Screen"
        Me.Controls.SetChildIndex(Me.Panel2, 0)
        Me.Controls.SetChildIndex(Me.Panel26, 0)
        Me.Controls.SetChildIndex(Me.Panel32, 0)
        Me.Controls.SetChildIndex(Me.inputtext, 0)
        Me.Controls.SetChildIndex(Me.TableLayoutPanel1, 0)
        Me.Controls.SetChildIndex(Me.confpanel, 0)
        Me.Controls.SetChildIndex(Me.viewimage, 0)
        CType(Me.myscr, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.myico, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.viewimage, System.ComponentModel.ISupportInitialize).EndInit()
        Me.confpanel.ResumeLayout(False)
        Me.Panel15.ResumeLayout(False)
        Me.Panel5.ResumeLayout(False)
        CType(Me.smallviewimage, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel11.ResumeLayout(False)
        Me.Panel10.ResumeLayout(False)
        Me.Panel8.ResumeLayout(False)
        Me.Panel7.ResumeLayout(False)
        Me.Panel4.ResumeLayout(False)
        Me.Panel3.ResumeLayout(False)
        Me.Panel44.ResumeLayout(False)
        Me.Panel32.ResumeLayout(False)
        Me.Panel2.ResumeLayout(False)
        Me.Panel26.ResumeLayout(False)
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents viewimage As PictureBox
    Friend WithEvents confpanel As Panel
    Friend WithEvents DrakeWidth_W2 As DrakeUI.Framework.DrakeWidth_W
    Friend WithEvents comboTargts As DrakeUI.Framework.DrakeUIComboBox
    Friend WithEvents startbtn As DrakeUI.Framework.DrakeUIButtonIcon
    Friend WithEvents stopbtn As DrakeUI.Framework.DrakeUIButtonIcon
    Friend WithEvents confbtn As DrakeUI.Framework.DrakeUIButtonIcon
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Panel26 As Panel
    Friend WithEvents mainstatelabel As Label
    Friend WithEvents Panel44 As Panel
    Friend WithEvents Panel4 As Panel
    Friend WithEvents Panel3 As Panel
    Friend WithEvents coloskeletonpick As DrakeUI.Framework.DrakeUIColorPicker
    Friend WithEvents Panel7 As Panel
    Friend WithEvents Panel32 As Panel
    Friend WithEvents unlockbtn As DrakeUI.Framework.DrakeUIButtonIcon
    Friend WithEvents Panel11 As Panel
    Friend WithEvents mscrtshots As DrakeUI.Framework.DrakeUIButtonIcon
    Friend WithEvents scrshot As DrakeUI.Framework.DrakeUIButtonIcon
    Friend WithEvents Panel14 As Panel
    Friend WithEvents Panel10 As Panel
    Friend WithEvents sondup As DrakeUI.Framework.DrakeUIButtonIcon
    Friend WithEvents soundown As DrakeUI.Framework.DrakeUIButtonIcon
    Friend WithEvents Panel13 As Panel
    Friend WithEvents Panel8 As Panel
    Friend WithEvents keybordon As DrakeUI.Framework.DrakeUIButtonIcon
    Friend WithEvents keybordoff As DrakeUI.Framework.DrakeUIButtonIcon
    Friend WithEvents Panel12 As Panel
    Friend WithEvents lokbtn As DrakeUI.Framework.DrakeUIButtonIcon
    Friend WithEvents statetimer As Timer
    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
    Friend WithEvents DrakeUIButtonIcon11 As DrakeUI.Framework.DrakeUIButtonIcon
    Friend WithEvents DrakeUIButtonIcon10 As DrakeUI.Framework.DrakeUIButtonIcon
    Friend WithEvents DrakeUIButtonIcon9 As DrakeUI.Framework.DrakeUIButtonIcon
    Friend WithEvents DrakeWidth_W3 As DrakeUI.Framework.DrakeWidth_W
    Friend WithEvents DrakeWidth_W11 As DrakeUI.Framework.DrakeWidth_W
    Friend WithEvents inputtext As DrakeUI.Framework.DrakeUITextBox
    Friend WithEvents Panel15 As Panel
    Friend WithEvents smallviewimage As PictureBox
    Friend WithEvents BTtiptool As DrakeUI.Framework.DrakeUIToolTip
    Friend WithEvents ctrlbtn As DrakeUI.Framework.DrakeUIButtonIcon
    Friend WithEvents blockbtn As DrakeUI.Framework.DrakeUIButtonIcon
    Friend WithEvents skltonbtn As DrakeUI.Framework.DrakeUIButtonIcon
    Friend WithEvents Label5 As Label
    Friend WithEvents qualitybar As DrakeUI.Framework.DrakeUITrackBar
    Friend WithEvents Panel5 As Panel
    Friend WithEvents recscr As DrakeUI.Framework.DrakeUIButtonIcon
    Friend WithEvents savertimer As Timer
End Class
