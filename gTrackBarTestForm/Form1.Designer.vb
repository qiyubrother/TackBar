<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.pRed = New System.Windows.Forms.Panel()
        Me.pGreen = New System.Windows.Forms.Panel()
        Me.pBlue = New System.Windows.Forms.Panel()
        Me.pRGB = New System.Windows.Forms.Panel()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.GTBarRed = New gTrackBar.gTrackBar()
        Me.GTBarGreen = New gTrackBar.gTrackBar()
        Me.GTBarBlue = New gTrackBar.gTrackBar()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.GTrackBar1 = New gTrackBar.gTrackBar()
        Me.GTrackBar13 = New gTrackBar.gTrackBar()
        Me.GTrackBar4 = New gTrackBar.gTrackBar()
        Me.GTrackBar12 = New gTrackBar.gTrackBar()
        Me.GTrackBar11 = New gTrackBar.gTrackBar()
        Me.GTrackBar10 = New gTrackBar.gTrackBar()
        Me.GTrackBar5 = New gTrackBar.gTrackBar()
        Me.GTrackBar3 = New gTrackBar.gTrackBar()
        Me.GTrackBar8 = New gTrackBar.gTrackBar()
        Me.GTrackBar9 = New gTrackBar.gTrackBar()
        Me.GTrackBar7 = New gTrackBar.gTrackBar()
        Me.GTrackBar2 = New gTrackBar.gTrackBar()
        Me.GTrackBar6 = New gTrackBar.gTrackBar()
        Me.GTrackBar14 = New gTrackBar.gTrackBar()
        Me.Panel1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'pRed
        '
        Me.pRed.BackColor = System.Drawing.Color.White
        Me.pRed.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.pRed.Location = New System.Drawing.Point(12, 32)
        Me.pRed.Name = "pRed"
        Me.pRed.Size = New System.Drawing.Size(20, 19)
        Me.pRed.TabIndex = 5
        '
        'pGreen
        '
        Me.pGreen.BackColor = System.Drawing.Color.White
        Me.pGreen.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.pGreen.Location = New System.Drawing.Point(39, 32)
        Me.pGreen.Name = "pGreen"
        Me.pGreen.Size = New System.Drawing.Size(20, 19)
        Me.pGreen.TabIndex = 5
        '
        'pBlue
        '
        Me.pBlue.BackColor = System.Drawing.Color.White
        Me.pBlue.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.pBlue.Location = New System.Drawing.Point(66, 32)
        Me.pBlue.Name = "pBlue"
        Me.pBlue.Size = New System.Drawing.Size(20, 19)
        Me.pBlue.TabIndex = 5
        '
        'pRGB
        '
        Me.pRGB.BackColor = System.Drawing.Color.Black
        Me.pRGB.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.pRGB.Location = New System.Drawing.Point(12, 10)
        Me.pRGB.Name = "pRGB"
        Me.pRGB.Size = New System.Drawing.Size(75, 19)
        Me.pRGB.TabIndex = 5
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.White
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel1.Controls.Add(Me.pRGB)
        Me.Panel1.Controls.Add(Me.pRed)
        Me.Panel1.Controls.Add(Me.GTBarRed)
        Me.Panel1.Controls.Add(Me.pBlue)
        Me.Panel1.Controls.Add(Me.GTBarGreen)
        Me.Panel1.Controls.Add(Me.pGreen)
        Me.Panel1.Controls.Add(Me.GTBarBlue)
        Me.Panel1.Location = New System.Drawing.Point(479, 188)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(98, 298)
        Me.Panel1.TabIndex = 16
        '
        'GTBarRed
        '
        Me.GTBarRed.AButColorA = System.Drawing.Color.LightCoral
        Me.GTBarRed.AButColorB = System.Drawing.Color.MistyRose
        Me.GTBarRed.AButColorBorder = System.Drawing.Color.IndianRed
        Me.GTBarRed.ArrowColorDown = System.Drawing.Color.White
        Me.GTBarRed.ArrowColorHover = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.GTBarRed.ArrowColorUp = System.Drawing.Color.LightCoral
        Me.GTBarRed.BackColor = System.Drawing.Color.White
        Me.GTBarRed.BorderColor = System.Drawing.Color.Black
        Me.GTBarRed.BorderShow = False
        Me.GTBarRed.BrushDirection = System.Drawing.Drawing2D.LinearGradientMode.Horizontal
        Me.GTBarRed.BrushStyle = gTrackBar.gTrackBar.eBrushStyle.Path
        Me.GTBarRed.ChangeLarge = 10
        Me.GTBarRed.ChangeSmall = 1
        Me.GTBarRed.ColorDown = System.Drawing.Color.LightCoral
        Me.GTBarRed.ColorDownBorder = System.Drawing.Color.Black
        Me.GTBarRed.ColorDownHiLt = System.Drawing.Color.White
        Me.GTBarRed.ColorHover = System.Drawing.Color.LightCoral
        Me.GTBarRed.ColorHoverBorder = System.Drawing.Color.Black
        Me.GTBarRed.ColorHoverHiLt = System.Drawing.Color.White
        Me.GTBarRed.ColorUp = System.Drawing.Color.Red
        Me.GTBarRed.ColorUpBorder = System.Drawing.Color.Black
        Me.GTBarRed.ColorUpHiLt = System.Drawing.Color.White
        Me.GTBarRed.FloatValue = True
        Me.GTBarRed.FloatValueFont = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Bold)
        Me.GTBarRed.FloatValueFontColor = System.Drawing.Color.Red
        Me.GTBarRed.Label = Nothing
        Me.GTBarRed.LabelAlighnment = System.Drawing.StringAlignment.Center
        Me.GTBarRed.LabelColor = System.Drawing.Color.MediumBlue
        Me.GTBarRed.LabelFont = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold)
        Me.GTBarRed.LabelPadding = New System.Windows.Forms.Padding(0)
        Me.GTBarRed.LabelShow = False
        Me.GTBarRed.Location = New System.Drawing.Point(10, 57)
        Me.GTBarRed.Margin = New System.Windows.Forms.Padding(2)
        Me.GTBarRed.MaxValue = 255
        Me.GTBarRed.MinValue = 0
        Me.GTBarRed.Name = "GTBarRed"
        Me.GTBarRed.Orientation = System.Windows.Forms.Orientation.Vertical
        Me.GTBarRed.ShowFocus = False
        Me.GTBarRed.Size = New System.Drawing.Size(24, 231)
        Me.GTBarRed.SliderCapEnd = System.Drawing.Drawing2D.LineCap.DiamondAnchor
        Me.GTBarRed.SliderCapStart = System.Drawing.Drawing2D.LineCap.Round
        Me.GTBarRed.SliderColorHigh = System.Drawing.Color.DarkGray
        Me.GTBarRed.SliderColorLow = System.Drawing.Color.Red
        Me.GTBarRed.SliderFocalPt = CType(resources.GetObject("GTBarRed.SliderFocalPt"), System.Drawing.PointF)
        Me.GTBarRed.SliderHighlightPt = CType(resources.GetObject("GTBarRed.SliderHighlightPt"), System.Drawing.PointF)
        Me.GTBarRed.SliderShape = gTrackBar.gTrackBar.eShape.Ellipse
        Me.GTBarRed.SliderSize = New System.Drawing.Size(12, 8)
        Me.GTBarRed.SliderWidth = 3
        Me.GTBarRed.TabIndex = 2
        Me.GTBarRed.TickColor = System.Drawing.Color.DarkGray
        Me.GTBarRed.TickInterval = 10
        Me.GTBarRed.TickType = gTrackBar.gTrackBar.eTickType.None
        Me.GTBarRed.TickWidth = 5
        Me.GTBarRed.UpDownAutoWidth = True
        Me.GTBarRed.UpDownWidth = 30
        Me.GTBarRed.Value = 77
        Me.GTBarRed.ValueBox = gTrackBar.gTrackBar.eValueBox.Left
        Me.GTBarRed.ValueBoxBackColor = System.Drawing.Color.White
        Me.GTBarRed.ValueBoxBorder = System.Drawing.Color.Red
        Me.GTBarRed.ValueBoxFont = New System.Drawing.Font("Arial", 6.0!)
        Me.GTBarRed.ValueBoxFontColor = System.Drawing.Color.Red
        Me.GTBarRed.ValueBoxShape = gTrackBar.gTrackBar.eShape.Rectangle
        Me.GTBarRed.ValueBoxSize = New System.Drawing.Size(21, 18)
        '
        'GTBarGreen
        '
        Me.GTBarGreen.AButColorA = System.Drawing.Color.LimeGreen
        Me.GTBarGreen.AButColorB = System.Drawing.Color.Honeydew
        Me.GTBarGreen.AButColorBorder = System.Drawing.Color.LimeGreen
        Me.GTBarGreen.ArrowColorDown = System.Drawing.Color.White
        Me.GTBarGreen.ArrowColorHover = System.Drawing.Color.Green
        Me.GTBarGreen.ArrowColorUp = System.Drawing.Color.LimeGreen
        Me.GTBarGreen.BackColor = System.Drawing.Color.White
        Me.GTBarGreen.BorderColor = System.Drawing.Color.Black
        Me.GTBarGreen.BorderShow = False
        Me.GTBarGreen.BrushDirection = System.Drawing.Drawing2D.LinearGradientMode.Horizontal
        Me.GTBarGreen.BrushStyle = gTrackBar.gTrackBar.eBrushStyle.Path
        Me.GTBarGreen.ChangeLarge = 10
        Me.GTBarGreen.ChangeSmall = 1
        Me.GTBarGreen.ColorDown = System.Drawing.Color.PaleGreen
        Me.GTBarGreen.ColorDownBorder = System.Drawing.Color.Black
        Me.GTBarGreen.ColorDownHiLt = System.Drawing.Color.White
        Me.GTBarGreen.ColorHover = System.Drawing.Color.PaleGreen
        Me.GTBarGreen.ColorHoverBorder = System.Drawing.Color.Black
        Me.GTBarGreen.ColorHoverHiLt = System.Drawing.Color.White
        Me.GTBarGreen.ColorUp = System.Drawing.Color.LimeGreen
        Me.GTBarGreen.ColorUpBorder = System.Drawing.Color.Black
        Me.GTBarGreen.ColorUpHiLt = System.Drawing.Color.White
        Me.GTBarGreen.FloatValue = True
        Me.GTBarGreen.FloatValueFont = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Bold)
        Me.GTBarGreen.FloatValueFontColor = System.Drawing.Color.LimeGreen
        Me.GTBarGreen.Label = Nothing
        Me.GTBarGreen.LabelAlighnment = System.Drawing.StringAlignment.Center
        Me.GTBarGreen.LabelColor = System.Drawing.Color.MediumBlue
        Me.GTBarGreen.LabelFont = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold)
        Me.GTBarGreen.LabelPadding = New System.Windows.Forms.Padding(0)
        Me.GTBarGreen.LabelShow = False
        Me.GTBarGreen.Location = New System.Drawing.Point(37, 57)
        Me.GTBarGreen.Margin = New System.Windows.Forms.Padding(2)
        Me.GTBarGreen.MaxValue = 255
        Me.GTBarGreen.MinValue = 0
        Me.GTBarGreen.Name = "GTBarGreen"
        Me.GTBarGreen.Orientation = System.Windows.Forms.Orientation.Vertical
        Me.GTBarGreen.ShowFocus = False
        Me.GTBarGreen.Size = New System.Drawing.Size(24, 231)
        Me.GTBarGreen.SliderCapEnd = System.Drawing.Drawing2D.LineCap.DiamondAnchor
        Me.GTBarGreen.SliderCapStart = System.Drawing.Drawing2D.LineCap.Round
        Me.GTBarGreen.SliderColorHigh = System.Drawing.Color.DarkGray
        Me.GTBarGreen.SliderColorLow = System.Drawing.Color.Lime
        Me.GTBarGreen.SliderFocalPt = CType(resources.GetObject("GTBarGreen.SliderFocalPt"), System.Drawing.PointF)
        Me.GTBarGreen.SliderHighlightPt = CType(resources.GetObject("GTBarGreen.SliderHighlightPt"), System.Drawing.PointF)
        Me.GTBarGreen.SliderShape = gTrackBar.gTrackBar.eShape.Ellipse
        Me.GTBarGreen.SliderSize = New System.Drawing.Size(12, 8)
        Me.GTBarGreen.SliderWidth = 3
        Me.GTBarGreen.TabIndex = 3
        Me.GTBarGreen.TickColor = System.Drawing.Color.DarkGray
        Me.GTBarGreen.TickInterval = 10
        Me.GTBarGreen.TickType = gTrackBar.gTrackBar.eTickType.None
        Me.GTBarGreen.TickWidth = 5
        Me.GTBarGreen.UpDownAutoWidth = True
        Me.GTBarGreen.UpDownWidth = 30
        Me.GTBarGreen.Value = 210
        Me.GTBarGreen.ValueBox = gTrackBar.gTrackBar.eValueBox.Left
        Me.GTBarGreen.ValueBoxBackColor = System.Drawing.Color.White
        Me.GTBarGreen.ValueBoxBorder = System.Drawing.Color.LimeGreen
        Me.GTBarGreen.ValueBoxFont = New System.Drawing.Font("Arial", 6.0!)
        Me.GTBarGreen.ValueBoxFontColor = System.Drawing.Color.LimeGreen
        Me.GTBarGreen.ValueBoxShape = gTrackBar.gTrackBar.eShape.Rectangle
        Me.GTBarGreen.ValueBoxSize = New System.Drawing.Size(21, 18)
        '
        'GTBarBlue
        '
        Me.GTBarBlue.AButColorA = System.Drawing.Color.CornflowerBlue
        Me.GTBarBlue.AButColorB = System.Drawing.Color.AliceBlue
        Me.GTBarBlue.AButColorBorder = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.GTBarBlue.ArrowColorDown = System.Drawing.Color.White
        Me.GTBarBlue.ArrowColorHover = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.GTBarBlue.ArrowColorUp = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.GTBarBlue.BackColor = System.Drawing.Color.White
        Me.GTBarBlue.BorderColor = System.Drawing.Color.Black
        Me.GTBarBlue.BorderShow = False
        Me.GTBarBlue.BrushDirection = System.Drawing.Drawing2D.LinearGradientMode.Horizontal
        Me.GTBarBlue.BrushStyle = gTrackBar.gTrackBar.eBrushStyle.Path
        Me.GTBarBlue.ChangeLarge = 10
        Me.GTBarBlue.ChangeSmall = 1
        Me.GTBarBlue.ColorDown = System.Drawing.Color.LightSteelBlue
        Me.GTBarBlue.ColorDownBorder = System.Drawing.Color.Black
        Me.GTBarBlue.ColorDownHiLt = System.Drawing.Color.White
        Me.GTBarBlue.ColorHover = System.Drawing.Color.LightSteelBlue
        Me.GTBarBlue.ColorHoverBorder = System.Drawing.Color.Black
        Me.GTBarBlue.ColorHoverHiLt = System.Drawing.Color.White
        Me.GTBarBlue.ColorUp = System.Drawing.Color.Blue
        Me.GTBarBlue.ColorUpBorder = System.Drawing.Color.Black
        Me.GTBarBlue.ColorUpHiLt = System.Drawing.Color.White
        Me.GTBarBlue.FloatValue = True
        Me.GTBarBlue.FloatValueFont = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Bold)
        Me.GTBarBlue.FloatValueFontColor = System.Drawing.Color.Blue
        Me.GTBarBlue.Label = ""
        Me.GTBarBlue.LabelAlighnment = System.Drawing.StringAlignment.Center
        Me.GTBarBlue.LabelColor = System.Drawing.Color.MediumBlue
        Me.GTBarBlue.LabelFont = New System.Drawing.Font("Arial", 7.0!)
        Me.GTBarBlue.LabelPadding = New System.Windows.Forms.Padding(0)
        Me.GTBarBlue.LabelShow = False
        Me.GTBarBlue.Location = New System.Drawing.Point(64, 57)
        Me.GTBarBlue.Margin = New System.Windows.Forms.Padding(2)
        Me.GTBarBlue.MaxValue = 255
        Me.GTBarBlue.MinValue = 0
        Me.GTBarBlue.Name = "GTBarBlue"
        Me.GTBarBlue.Orientation = System.Windows.Forms.Orientation.Vertical
        Me.GTBarBlue.ShowFocus = False
        Me.GTBarBlue.Size = New System.Drawing.Size(24, 231)
        Me.GTBarBlue.SliderCapEnd = System.Drawing.Drawing2D.LineCap.DiamondAnchor
        Me.GTBarBlue.SliderCapStart = System.Drawing.Drawing2D.LineCap.Round
        Me.GTBarBlue.SliderColorHigh = System.Drawing.Color.DarkGray
        Me.GTBarBlue.SliderColorLow = System.Drawing.Color.Blue
        Me.GTBarBlue.SliderFocalPt = CType(resources.GetObject("GTBarBlue.SliderFocalPt"), System.Drawing.PointF)
        Me.GTBarBlue.SliderHighlightPt = CType(resources.GetObject("GTBarBlue.SliderHighlightPt"), System.Drawing.PointF)
        Me.GTBarBlue.SliderShape = gTrackBar.gTrackBar.eShape.Ellipse
        Me.GTBarBlue.SliderSize = New System.Drawing.Size(12, 8)
        Me.GTBarBlue.SliderWidth = 3
        Me.GTBarBlue.TabIndex = 4
        Me.GTBarBlue.TickColor = System.Drawing.Color.DarkGray
        Me.GTBarBlue.TickInterval = 10
        Me.GTBarBlue.TickType = gTrackBar.gTrackBar.eTickType.None
        Me.GTBarBlue.TickWidth = 5
        Me.GTBarBlue.UpDownAutoWidth = True
        Me.GTBarBlue.UpDownWidth = 30
        Me.GTBarBlue.Value = 134
        Me.GTBarBlue.ValueBox = gTrackBar.gTrackBar.eValueBox.Left
        Me.GTBarBlue.ValueBoxBackColor = System.Drawing.Color.White
        Me.GTBarBlue.ValueBoxBorder = System.Drawing.Color.Blue
        Me.GTBarBlue.ValueBoxFont = New System.Drawing.Font("Arial", 6.0!)
        Me.GTBarBlue.ValueBoxFontColor = System.Drawing.Color.MediumBlue
        Me.GTBarBlue.ValueBoxShape = gTrackBar.gTrackBar.eShape.Rectangle
        Me.GTBarBlue.ValueBoxSize = New System.Drawing.Size(21, 18)
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(124, 16)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(157, 80)
        Me.PictureBox1.TabIndex = 18
        Me.PictureBox1.TabStop = False
        Me.PictureBox1.Visible = False
        '
        'GTrackBar1
        '
        Me.GTrackBar1.AButColorA = System.Drawing.Color.CornflowerBlue
        Me.GTrackBar1.AButColorB = System.Drawing.Color.Lavender
        Me.GTrackBar1.AButColorBorder = System.Drawing.Color.SteelBlue
        Me.GTrackBar1.ArrowColorDown = System.Drawing.Color.GhostWhite
        Me.GTrackBar1.ArrowColorHover = System.Drawing.Color.DarkBlue
        Me.GTrackBar1.ArrowColorUp = System.Drawing.Color.LightSteelBlue
        Me.GTrackBar1.BackColor = System.Drawing.Color.Transparent
        Me.GTrackBar1.BorderColor = System.Drawing.Color.Black
        Me.GTrackBar1.BorderShow = False
        Me.GTrackBar1.BrushDirection = System.Drawing.Drawing2D.LinearGradientMode.BackwardDiagonal
        Me.GTrackBar1.BrushStyle = gTrackBar.gTrackBar.eBrushStyle.Linear2
        Me.GTrackBar1.ChangeLarge = 10
        Me.GTrackBar1.ChangeSmall = 1
        Me.GTrackBar1.ColorDown = System.Drawing.Color.Red
        Me.GTrackBar1.ColorDownBorder = System.Drawing.Color.Red
        Me.GTrackBar1.ColorDownHiLt = System.Drawing.Color.White
        Me.GTrackBar1.ColorHover = System.Drawing.Color.Firebrick
        Me.GTrackBar1.ColorHoverBorder = System.Drawing.Color.Firebrick
        Me.GTrackBar1.ColorHoverHiLt = System.Drawing.Color.MistyRose
        Me.GTrackBar1.ColorUp = System.Drawing.Color.Red
        Me.GTrackBar1.ColorUpBorder = System.Drawing.Color.Red
        Me.GTrackBar1.ColorUpHiLt = System.Drawing.Color.White
        Me.GTrackBar1.FloatValue = True
        Me.GTrackBar1.FloatValueFont = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Bold)
        Me.GTrackBar1.FloatValueFontColor = System.Drawing.Color.MediumBlue
        Me.GTrackBar1.Label = "Diver Dude"
        Me.GTrackBar1.LabelAlighnment = System.Drawing.StringAlignment.Near
        Me.GTrackBar1.LabelColor = System.Drawing.Color.Red
        Me.GTrackBar1.LabelFont = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold)
        Me.GTrackBar1.LabelPadding = New System.Windows.Forms.Padding(28, 0, 0, 0)
        Me.GTrackBar1.LabelShow = True
        Me.GTrackBar1.Location = New System.Drawing.Point(23, 34)
        Me.GTrackBar1.Margin = New System.Windows.Forms.Padding(2)
        Me.GTrackBar1.MaxValue = 100
        Me.GTrackBar1.MinValue = 0
        Me.GTrackBar1.Name = "GTrackBar1"
        Me.GTrackBar1.Orientation = System.Windows.Forms.Orientation.Horizontal
        Me.GTrackBar1.ShowFocus = False
        Me.GTrackBar1.Size = New System.Drawing.Size(266, 36)
        Me.GTrackBar1.SliderCapEnd = System.Drawing.Drawing2D.LineCap.Flat
        Me.GTrackBar1.SliderCapStart = System.Drawing.Drawing2D.LineCap.Round
        Me.GTrackBar1.SliderColorHigh = System.Drawing.Color.Transparent
        Me.GTrackBar1.SliderColorLow = System.Drawing.Color.FromArgb(CType(CType(150, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.GTrackBar1.SliderFocalPt = CType(resources.GetObject("GTrackBar1.SliderFocalPt"), System.Drawing.PointF)
        Me.GTrackBar1.SliderHighlightPt = CType(resources.GetObject("GTrackBar1.SliderHighlightPt"), System.Drawing.PointF)
        Me.GTrackBar1.SliderShape = gTrackBar.gTrackBar.eShape.Rectangle
        Me.GTrackBar1.SliderSize = New System.Drawing.Size(18, 12)
        Me.GTrackBar1.SliderWidth = 10
        Me.GTrackBar1.TabIndex = 9
        Me.GTrackBar1.TickColor = System.Drawing.Color.FromArgb(CType(CType(150, Byte), Integer), CType(CType(100, Byte), Integer), CType(CType(100, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.GTrackBar1.TickInterval = 20
        Me.GTrackBar1.TickType = gTrackBar.gTrackBar.eTickType.Middle
        Me.GTrackBar1.TickWidth = 5
        Me.GTrackBar1.UpDownAutoWidth = True
        Me.GTrackBar1.UpDownWidth = 30
        Me.GTrackBar1.Value = 100
        Me.GTrackBar1.ValueBox = gTrackBar.gTrackBar.eValueBox.None
        Me.GTrackBar1.ValueBoxBackColor = System.Drawing.Color.White
        Me.GTrackBar1.ValueBoxBorder = System.Drawing.Color.MediumBlue
        Me.GTrackBar1.ValueBoxFont = New System.Drawing.Font("Arial", 8.25!)
        Me.GTrackBar1.ValueBoxFontColor = System.Drawing.Color.MediumBlue
        Me.GTrackBar1.ValueBoxShape = gTrackBar.gTrackBar.eShape.Rectangle
        Me.GTrackBar1.ValueBoxSize = New System.Drawing.Size(30, 20)
        '
        'GTrackBar13
        '
        Me.GTrackBar13.AButColorA = System.Drawing.Color.CornflowerBlue
        Me.GTrackBar13.AButColorB = System.Drawing.Color.Lavender
        Me.GTrackBar13.AButColorBorder = System.Drawing.Color.SteelBlue
        Me.GTrackBar13.ArrowColorDown = System.Drawing.Color.GhostWhite
        Me.GTrackBar13.ArrowColorHover = System.Drawing.Color.DarkBlue
        Me.GTrackBar13.ArrowColorUp = System.Drawing.Color.Transparent
        Me.GTrackBar13.BackColor = System.Drawing.Color.FromArgb(CType(CType(10, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.GTrackBar13.BackgroundImage = CType(resources.GetObject("GTrackBar13.BackgroundImage"), System.Drawing.Image)
        Me.GTrackBar13.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.GTrackBar13.BorderColor = System.Drawing.Color.Black
        Me.GTrackBar13.BorderShow = False
        Me.GTrackBar13.BrushDirection = System.Drawing.Drawing2D.LinearGradientMode.Horizontal
        Me.GTrackBar13.BrushStyle = gTrackBar.gTrackBar.eBrushStyle.Path
        Me.GTrackBar13.ChangeLarge = 10
        Me.GTrackBar13.ChangeSmall = 1
        Me.GTrackBar13.ColorDown = System.Drawing.Color.CornflowerBlue
        Me.GTrackBar13.ColorDownBorder = System.Drawing.Color.DarkSlateBlue
        Me.GTrackBar13.ColorDownHiLt = System.Drawing.Color.AliceBlue
        Me.GTrackBar13.ColorHover = System.Drawing.Color.RoyalBlue
        Me.GTrackBar13.ColorHoverBorder = System.Drawing.Color.Blue
        Me.GTrackBar13.ColorHoverHiLt = System.Drawing.Color.White
        Me.GTrackBar13.ColorUp = System.Drawing.Color.FromArgb(CType(CType(120, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.GTrackBar13.ColorUpBorder = System.Drawing.Color.White
        Me.GTrackBar13.ColorUpHiLt = System.Drawing.Color.SlateBlue
        Me.GTrackBar13.FloatValue = True
        Me.GTrackBar13.FloatValueFont = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold)
        Me.GTrackBar13.FloatValueFontColor = System.Drawing.Color.SaddleBrown
        Me.GTrackBar13.Label = Nothing
        Me.GTrackBar13.LabelAlighnment = System.Drawing.StringAlignment.Near
        Me.GTrackBar13.LabelColor = System.Drawing.Color.MediumBlue
        Me.GTrackBar13.LabelFont = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold)
        Me.GTrackBar13.LabelPadding = New System.Windows.Forms.Padding(0)
        Me.GTrackBar13.LabelShow = False
        Me.GTrackBar13.Location = New System.Drawing.Point(320, 8)
        Me.GTrackBar13.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.GTrackBar13.MaxValue = 50
        Me.GTrackBar13.MinValue = 0
        Me.GTrackBar13.Name = "GTrackBar13"
        Me.GTrackBar13.Orientation = System.Windows.Forms.Orientation.Horizontal
        Me.GTrackBar13.ShowFocus = False
        Me.GTrackBar13.Size = New System.Drawing.Size(261, 96)
        Me.GTrackBar13.SliderCapEnd = System.Drawing.Drawing2D.LineCap.Round
        Me.GTrackBar13.SliderCapStart = System.Drawing.Drawing2D.LineCap.Round
        Me.GTrackBar13.SliderColorHigh = System.Drawing.Color.FromArgb(CType(CType(120, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.GTrackBar13.SliderColorLow = System.Drawing.Color.FromArgb(CType(CType(120, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.GTrackBar13.SliderFocalPt = CType(resources.GetObject("GTrackBar13.SliderFocalPt"), System.Drawing.PointF)
        Me.GTrackBar13.SliderHighlightPt = CType(resources.GetObject("GTrackBar13.SliderHighlightPt"), System.Drawing.PointF)
        Me.GTrackBar13.SliderShape = gTrackBar.gTrackBar.eShape.Ellipse
        Me.GTrackBar13.SliderSize = New System.Drawing.Size(25, 35)
        Me.GTrackBar13.SliderWidth = 10
        Me.GTrackBar13.TabIndex = 20
        Me.GTrackBar13.TickColor = System.Drawing.Color.DarkGray
        Me.GTrackBar13.TickInterval = 10
        Me.GTrackBar13.TickType = gTrackBar.gTrackBar.eTickType.None
        Me.GTrackBar13.TickWidth = 5
        Me.GTrackBar13.UpDownAutoWidth = True
        Me.GTrackBar13.UpDownWidth = 30
        Me.GTrackBar13.Value = 18
        Me.GTrackBar13.ValueBox = gTrackBar.gTrackBar.eValueBox.None
        Me.GTrackBar13.ValueBoxBackColor = System.Drawing.Color.White
        Me.GTrackBar13.ValueBoxBorder = System.Drawing.Color.MediumBlue
        Me.GTrackBar13.ValueBoxFont = New System.Drawing.Font("Arial", 8.25!)
        Me.GTrackBar13.ValueBoxFontColor = System.Drawing.Color.MediumBlue
        Me.GTrackBar13.ValueBoxShape = gTrackBar.gTrackBar.eShape.Rectangle
        Me.GTrackBar13.ValueBoxSize = New System.Drawing.Size(30, 20)
        '
        'GTrackBar4
        '
        Me.GTrackBar4.AButColorA = System.Drawing.Color.Gray
        Me.GTrackBar4.AButColorB = System.Drawing.Color.LightGray
        Me.GTrackBar4.AButColorBorder = System.Drawing.Color.Gray
        Me.GTrackBar4.ArrowColorDown = System.Drawing.Color.White
        Me.GTrackBar4.ArrowColorHover = System.Drawing.Color.Black
        Me.GTrackBar4.ArrowColorUp = System.Drawing.Color.Gray
        Me.GTrackBar4.BackColor = System.Drawing.Color.DarkGray
        Me.GTrackBar4.BorderColor = System.Drawing.Color.DarkBlue
        Me.GTrackBar4.BorderShow = True
        Me.GTrackBar4.BrushDirection = System.Drawing.Drawing2D.LinearGradientMode.Horizontal
        Me.GTrackBar4.BrushStyle = gTrackBar.gTrackBar.eBrushStyle.Path
        Me.GTrackBar4.ChangeLarge = 20
        Me.GTrackBar4.ChangeSmall = 1
        Me.GTrackBar4.ColorDown = System.Drawing.Color.Orange
        Me.GTrackBar4.ColorDownBorder = System.Drawing.Color.SaddleBrown
        Me.GTrackBar4.ColorDownHiLt = System.Drawing.Color.White
        Me.GTrackBar4.ColorHover = System.Drawing.Color.RoyalBlue
        Me.GTrackBar4.ColorHoverBorder = System.Drawing.Color.Black
        Me.GTrackBar4.ColorHoverHiLt = System.Drawing.Color.White
        Me.GTrackBar4.ColorUp = System.Drawing.Color.DarkBlue
        Me.GTrackBar4.ColorUpBorder = System.Drawing.Color.Black
        Me.GTrackBar4.ColorUpHiLt = System.Drawing.Color.White
        Me.GTrackBar4.FloatValue = False
        Me.GTrackBar4.FloatValueFont = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Bold)
        Me.GTrackBar4.FloatValueFontColor = System.Drawing.Color.MediumBlue
        Me.GTrackBar4.Label = "gTrackBar"
        Me.GTrackBar4.LabelAlighnment = System.Drawing.StringAlignment.Near
        Me.GTrackBar4.LabelColor = System.Drawing.Color.MediumBlue
        Me.GTrackBar4.LabelFont = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold)
        Me.GTrackBar4.LabelPadding = New System.Windows.Forms.Padding(40, 8, 0, 0)
        Me.GTrackBar4.LabelShow = True
        Me.GTrackBar4.Location = New System.Drawing.Point(11, 114)
        Me.GTrackBar4.Margin = New System.Windows.Forms.Padding(2)
        Me.GTrackBar4.MaxValue = 1000
        Me.GTrackBar4.MinValue = 0
        Me.GTrackBar4.Name = "GTrackBar4"
        Me.GTrackBar4.Orientation = System.Windows.Forms.Orientation.Horizontal
        Me.GTrackBar4.ShowFocus = False
        Me.GTrackBar4.Size = New System.Drawing.Size(570, 69)
        Me.GTrackBar4.SliderCapEnd = System.Drawing.Drawing2D.LineCap.RoundAnchor
        Me.GTrackBar4.SliderCapStart = System.Drawing.Drawing2D.LineCap.RoundAnchor
        Me.GTrackBar4.SliderColorHigh = System.Drawing.Color.AliceBlue
        Me.GTrackBar4.SliderColorLow = System.Drawing.Color.Orange
        Me.GTrackBar4.SliderFocalPt = CType(resources.GetObject("GTrackBar4.SliderFocalPt"), System.Drawing.PointF)
        Me.GTrackBar4.SliderHighlightPt = CType(resources.GetObject("GTrackBar4.SliderHighlightPt"), System.Drawing.PointF)
        Me.GTrackBar4.SliderShape = gTrackBar.gTrackBar.eShape.Ellipse
        Me.GTrackBar4.SliderSize = New System.Drawing.Size(20, 20)
        Me.GTrackBar4.SliderWidth = 13
        Me.GTrackBar4.TabIndex = 7
        Me.GTrackBar4.TickColor = System.Drawing.Color.MediumBlue
        Me.GTrackBar4.TickInterval = 20
        Me.GTrackBar4.TickType = gTrackBar.gTrackBar.eTickType.None
        Me.GTrackBar4.TickWidth = 5
        Me.GTrackBar4.UpDownAutoWidth = True
        Me.GTrackBar4.UpDownWidth = 60
        Me.GTrackBar4.Value = 0
        Me.GTrackBar4.ValueBox = gTrackBar.gTrackBar.eValueBox.Right
        Me.GTrackBar4.ValueBoxBackColor = System.Drawing.Color.White
        Me.GTrackBar4.ValueBoxBorder = System.Drawing.Color.MediumBlue
        Me.GTrackBar4.ValueBoxFont = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GTrackBar4.ValueBoxFontColor = System.Drawing.Color.MediumBlue
        Me.GTrackBar4.ValueBoxShape = gTrackBar.gTrackBar.eShape.Ellipse
        Me.GTrackBar4.ValueBoxSize = New System.Drawing.Size(50, 30)
        '
        'GTrackBar12
        '
        Me.GTrackBar12.AButColorA = System.Drawing.Color.Gray
        Me.GTrackBar12.AButColorB = System.Drawing.Color.WhiteSmoke
        Me.GTrackBar12.AButColorBorder = System.Drawing.Color.DimGray
        Me.GTrackBar12.ArrowColorDown = System.Drawing.Color.White
        Me.GTrackBar12.ArrowColorHover = System.Drawing.Color.Black
        Me.GTrackBar12.ArrowColorUp = System.Drawing.Color.DarkGray
        Me.GTrackBar12.BackColor = System.Drawing.Color.White
        Me.GTrackBar12.BorderColor = System.Drawing.Color.Black
        Me.GTrackBar12.BorderShow = True
        Me.GTrackBar12.BrushDirection = System.Drawing.Drawing2D.LinearGradientMode.ForwardDiagonal
        Me.GTrackBar12.BrushStyle = gTrackBar.gTrackBar.eBrushStyle.Path
        Me.GTrackBar12.ChangeLarge = 10
        Me.GTrackBar12.ChangeSmall = 1
        Me.GTrackBar12.ColorDown = System.Drawing.Color.WhiteSmoke
        Me.GTrackBar12.ColorDownBorder = System.Drawing.Color.DimGray
        Me.GTrackBar12.ColorDownHiLt = System.Drawing.Color.Gainsboro
        Me.GTrackBar12.ColorHover = System.Drawing.Color.Gray
        Me.GTrackBar12.ColorHoverBorder = System.Drawing.Color.Silver
        Me.GTrackBar12.ColorHoverHiLt = System.Drawing.Color.WhiteSmoke
        Me.GTrackBar12.ColorUp = System.Drawing.Color.Black
        Me.GTrackBar12.ColorUpBorder = System.Drawing.Color.Silver
        Me.GTrackBar12.ColorUpHiLt = System.Drawing.Color.Gainsboro
        Me.GTrackBar12.FloatValue = True
        Me.GTrackBar12.FloatValueFont = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Bold)
        Me.GTrackBar12.FloatValueFontColor = System.Drawing.Color.Black
        Me.GTrackBar12.Label = ""
        Me.GTrackBar12.LabelAlighnment = System.Drawing.StringAlignment.Center
        Me.GTrackBar12.LabelColor = System.Drawing.Color.MediumBlue
        Me.GTrackBar12.LabelFont = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold)
        Me.GTrackBar12.LabelPadding = New System.Windows.Forms.Padding(0)
        Me.GTrackBar12.LabelShow = False
        Me.GTrackBar12.Location = New System.Drawing.Point(42, 537)
        Me.GTrackBar12.Margin = New System.Windows.Forms.Padding(2)
        Me.GTrackBar12.MaxValue = 50
        Me.GTrackBar12.MinValue = 0
        Me.GTrackBar12.Name = "GTrackBar12"
        Me.GTrackBar12.Orientation = System.Windows.Forms.Orientation.Horizontal
        Me.GTrackBar12.ShowFocus = False
        Me.GTrackBar12.Size = New System.Drawing.Size(283, 50)
        Me.GTrackBar12.SliderCapEnd = System.Drawing.Drawing2D.LineCap.Round
        Me.GTrackBar12.SliderCapStart = System.Drawing.Drawing2D.LineCap.Round
        Me.GTrackBar12.SliderColorHigh = System.Drawing.Color.Black
        Me.GTrackBar12.SliderColorLow = System.Drawing.Color.Black
        Me.GTrackBar12.SliderFocalPt = CType(resources.GetObject("GTrackBar12.SliderFocalPt"), System.Drawing.PointF)
        Me.GTrackBar12.SliderHighlightPt = CType(resources.GetObject("GTrackBar12.SliderHighlightPt"), System.Drawing.PointF)
        Me.GTrackBar12.SliderShape = gTrackBar.gTrackBar.eShape.Ellipse
        Me.GTrackBar12.SliderSize = New System.Drawing.Size(25, 25)
        Me.GTrackBar12.SliderWidth = 1
        Me.GTrackBar12.TabIndex = 19
        Me.GTrackBar12.TickColor = System.Drawing.Color.DarkGray
        Me.GTrackBar12.TickInterval = 10
        Me.GTrackBar12.TickType = gTrackBar.gTrackBar.eTickType.None
        Me.GTrackBar12.TickWidth = 5
        Me.GTrackBar12.UpDownAutoWidth = True
        Me.GTrackBar12.UpDownWidth = 30
        Me.GTrackBar12.Value = 40
        Me.GTrackBar12.ValueBox = gTrackBar.gTrackBar.eValueBox.None
        Me.GTrackBar12.ValueBoxBackColor = System.Drawing.Color.White
        Me.GTrackBar12.ValueBoxBorder = System.Drawing.Color.Black
        Me.GTrackBar12.ValueBoxFont = New System.Drawing.Font("Arial", 8.25!)
        Me.GTrackBar12.ValueBoxFontColor = System.Drawing.Color.Black
        Me.GTrackBar12.ValueBoxShape = gTrackBar.gTrackBar.eShape.Rectangle
        Me.GTrackBar12.ValueBoxSize = New System.Drawing.Size(30, 20)
        '
        'GTrackBar11
        '
        Me.GTrackBar11.AButColorA = System.Drawing.Color.Goldenrod
        Me.GTrackBar11.AButColorB = System.Drawing.Color.LightGoldenrodYellow
        Me.GTrackBar11.AButColorBorder = System.Drawing.Color.Goldenrod
        Me.GTrackBar11.ArrowColorDown = System.Drawing.Color.White
        Me.GTrackBar11.ArrowColorHover = System.Drawing.Color.SaddleBrown
        Me.GTrackBar11.ArrowColorUp = System.Drawing.Color.MediumSeaGreen
        Me.GTrackBar11.BackColor = System.Drawing.SystemColors.Control
        Me.GTrackBar11.BorderColor = System.Drawing.Color.Black
        Me.GTrackBar11.BorderShow = False
        Me.GTrackBar11.BrushDirection = System.Drawing.Drawing2D.LinearGradientMode.Horizontal
        Me.GTrackBar11.BrushStyle = gTrackBar.gTrackBar.eBrushStyle.Path
        Me.GTrackBar11.ChangeLarge = 10
        Me.GTrackBar11.ChangeSmall = 1
        Me.GTrackBar11.ColorDown = System.Drawing.Color.Goldenrod
        Me.GTrackBar11.ColorDownBorder = System.Drawing.Color.DarkOrange
        Me.GTrackBar11.ColorDownHiLt = System.Drawing.Color.Yellow
        Me.GTrackBar11.ColorHover = System.Drawing.Color.SpringGreen
        Me.GTrackBar11.ColorHoverBorder = System.Drawing.Color.Teal
        Me.GTrackBar11.ColorHoverHiLt = System.Drawing.Color.Yellow
        Me.GTrackBar11.ColorUp = System.Drawing.Color.SpringGreen
        Me.GTrackBar11.ColorUpBorder = System.Drawing.Color.Teal
        Me.GTrackBar11.ColorUpHiLt = System.Drawing.Color.LightCyan
        Me.GTrackBar11.FloatValue = True
        Me.GTrackBar11.FloatValueFont = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold)
        Me.GTrackBar11.FloatValueFontColor = System.Drawing.Color.SaddleBrown
        Me.GTrackBar11.Label = Nothing
        Me.GTrackBar11.LabelAlighnment = System.Drawing.StringAlignment.Center
        Me.GTrackBar11.LabelColor = System.Drawing.Color.MediumBlue
        Me.GTrackBar11.LabelFont = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold)
        Me.GTrackBar11.LabelPadding = New System.Windows.Forms.Padding(0)
        Me.GTrackBar11.LabelShow = False
        Me.GTrackBar11.Location = New System.Drawing.Point(406, 338)
        Me.GTrackBar11.Margin = New System.Windows.Forms.Padding(2)
        Me.GTrackBar11.MaxValue = 100
        Me.GTrackBar11.MinValue = 0
        Me.GTrackBar11.Name = "GTrackBar11"
        Me.GTrackBar11.Orientation = System.Windows.Forms.Orientation.Vertical
        Me.GTrackBar11.ShowFocus = True
        Me.GTrackBar11.Size = New System.Drawing.Size(54, 158)
        Me.GTrackBar11.SliderCapEnd = System.Drawing.Drawing2D.LineCap.Round
        Me.GTrackBar11.SliderCapStart = System.Drawing.Drawing2D.LineCap.Round
        Me.GTrackBar11.SliderColorHigh = System.Drawing.Color.MediumSeaGreen
        Me.GTrackBar11.SliderColorLow = System.Drawing.Color.MediumSpringGreen
        Me.GTrackBar11.SliderFocalPt = CType(resources.GetObject("GTrackBar11.SliderFocalPt"), System.Drawing.PointF)
        Me.GTrackBar11.SliderHighlightPt = CType(resources.GetObject("GTrackBar11.SliderHighlightPt"), System.Drawing.PointF)
        Me.GTrackBar11.SliderShape = gTrackBar.gTrackBar.eShape.Rectangle
        Me.GTrackBar11.SliderSize = New System.Drawing.Size(40, 20)
        Me.GTrackBar11.SliderWidth = 5
        Me.GTrackBar11.TabIndex = 17
        Me.GTrackBar11.TickColor = System.Drawing.Color.DarkGray
        Me.GTrackBar11.TickInterval = 10
        Me.GTrackBar11.TickType = gTrackBar.gTrackBar.eTickType.None
        Me.GTrackBar11.TickWidth = 5
        Me.GTrackBar11.UpDownAutoWidth = True
        Me.GTrackBar11.UpDownWidth = 30
        Me.GTrackBar11.Value = 25
        Me.GTrackBar11.ValueBox = gTrackBar.gTrackBar.eValueBox.None
        Me.GTrackBar11.ValueBoxBackColor = System.Drawing.Color.White
        Me.GTrackBar11.ValueBoxBorder = System.Drawing.Color.MediumBlue
        Me.GTrackBar11.ValueBoxFont = New System.Drawing.Font("Arial", 8.25!)
        Me.GTrackBar11.ValueBoxFontColor = System.Drawing.Color.MediumBlue
        Me.GTrackBar11.ValueBoxShape = gTrackBar.gTrackBar.eShape.Rectangle
        Me.GTrackBar11.ValueBoxSize = New System.Drawing.Size(30, 20)
        '
        'GTrackBar10
        '
        Me.GTrackBar10.AButColorA = System.Drawing.Color.DarkViolet
        Me.GTrackBar10.AButColorB = System.Drawing.Color.Thistle
        Me.GTrackBar10.AButColorBorder = System.Drawing.Color.Indigo
        Me.GTrackBar10.ArrowColorDown = System.Drawing.Color.LavenderBlush
        Me.GTrackBar10.ArrowColorHover = System.Drawing.Color.Purple
        Me.GTrackBar10.ArrowColorUp = System.Drawing.Color.MediumOrchid
        Me.GTrackBar10.BackColor = System.Drawing.SystemColors.Control
        Me.GTrackBar10.BorderColor = System.Drawing.Color.Black
        Me.GTrackBar10.BorderShow = False
        Me.GTrackBar10.BrushDirection = System.Drawing.Drawing2D.LinearGradientMode.Horizontal
        Me.GTrackBar10.BrushStyle = gTrackBar.gTrackBar.eBrushStyle.Path
        Me.GTrackBar10.ChangeLarge = 10
        Me.GTrackBar10.ChangeSmall = 1
        Me.GTrackBar10.ColorDown = System.Drawing.Color.DarkViolet
        Me.GTrackBar10.ColorDownBorder = System.Drawing.Color.Indigo
        Me.GTrackBar10.ColorDownHiLt = System.Drawing.Color.LavenderBlush
        Me.GTrackBar10.ColorHover = System.Drawing.Color.Purple
        Me.GTrackBar10.ColorHoverBorder = System.Drawing.Color.Fuchsia
        Me.GTrackBar10.ColorHoverHiLt = System.Drawing.Color.LavenderBlush
        Me.GTrackBar10.ColorUp = System.Drawing.Color.Purple
        Me.GTrackBar10.ColorUpBorder = System.Drawing.Color.Purple
        Me.GTrackBar10.ColorUpHiLt = System.Drawing.Color.AliceBlue
        Me.GTrackBar10.FloatValue = False
        Me.GTrackBar10.FloatValueFont = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Bold)
        Me.GTrackBar10.FloatValueFontColor = System.Drawing.Color.MediumBlue
        Me.GTrackBar10.Label = Nothing
        Me.GTrackBar10.LabelAlighnment = System.Drawing.StringAlignment.Center
        Me.GTrackBar10.LabelColor = System.Drawing.Color.MediumBlue
        Me.GTrackBar10.LabelFont = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold)
        Me.GTrackBar10.LabelPadding = New System.Windows.Forms.Padding(0)
        Me.GTrackBar10.LabelShow = False
        Me.GTrackBar10.Location = New System.Drawing.Point(429, 201)
        Me.GTrackBar10.Margin = New System.Windows.Forms.Padding(2)
        Me.GTrackBar10.MaxValue = 50
        Me.GTrackBar10.MinValue = 0
        Me.GTrackBar10.Name = "GTrackBar10"
        Me.GTrackBar10.Orientation = System.Windows.Forms.Orientation.Vertical
        Me.GTrackBar10.ShowFocus = True
        Me.GTrackBar10.Size = New System.Drawing.Size(31, 122)
        Me.GTrackBar10.SliderCapEnd = System.Drawing.Drawing2D.LineCap.Round
        Me.GTrackBar10.SliderCapStart = System.Drawing.Drawing2D.LineCap.Round
        Me.GTrackBar10.SliderColorHigh = System.Drawing.Color.DarkViolet
        Me.GTrackBar10.SliderColorLow = System.Drawing.Color.DarkViolet
        Me.GTrackBar10.SliderFocalPt = CType(resources.GetObject("GTrackBar10.SliderFocalPt"), System.Drawing.PointF)
        Me.GTrackBar10.SliderHighlightPt = CType(resources.GetObject("GTrackBar10.SliderHighlightPt"), System.Drawing.PointF)
        Me.GTrackBar10.SliderShape = gTrackBar.gTrackBar.eShape.Rectangle
        Me.GTrackBar10.SliderSize = New System.Drawing.Size(20, 20)
        Me.GTrackBar10.SliderWidth = 5
        Me.GTrackBar10.TabIndex = 17
        Me.GTrackBar10.TickColor = System.Drawing.Color.DarkGray
        Me.GTrackBar10.TickInterval = 10
        Me.GTrackBar10.TickType = gTrackBar.gTrackBar.eTickType.None
        Me.GTrackBar10.TickWidth = 5
        Me.GTrackBar10.UpDownAutoWidth = False
        Me.GTrackBar10.UpDownWidth = 20
        Me.GTrackBar10.Value = 35
        Me.GTrackBar10.ValueBox = gTrackBar.gTrackBar.eValueBox.None
        Me.GTrackBar10.ValueBoxBackColor = System.Drawing.Color.White
        Me.GTrackBar10.ValueBoxBorder = System.Drawing.Color.MediumBlue
        Me.GTrackBar10.ValueBoxFont = New System.Drawing.Font("Arial", 8.25!)
        Me.GTrackBar10.ValueBoxFontColor = System.Drawing.Color.MediumBlue
        Me.GTrackBar10.ValueBoxShape = gTrackBar.gTrackBar.eShape.Rectangle
        Me.GTrackBar10.ValueBoxSize = New System.Drawing.Size(30, 20)
        '
        'GTrackBar5
        '
        Me.GTrackBar5.AButColorA = System.Drawing.Color.Transparent
        Me.GTrackBar5.AButColorB = System.Drawing.Color.Transparent
        Me.GTrackBar5.AButColorBorder = System.Drawing.Color.Transparent
        Me.GTrackBar5.ArrowColorDown = System.Drawing.Color.LightSteelBlue
        Me.GTrackBar5.ArrowColorHover = System.Drawing.Color.DarkBlue
        Me.GTrackBar5.ArrowColorUp = System.Drawing.Color.Transparent
        Me.GTrackBar5.BackColor = System.Drawing.SystemColors.Control
        Me.GTrackBar5.BorderColor = System.Drawing.Color.Black
        Me.GTrackBar5.BorderShow = True
        Me.GTrackBar5.BrushDirection = System.Drawing.Drawing2D.LinearGradientMode.ForwardDiagonal
        Me.GTrackBar5.BrushStyle = gTrackBar.gTrackBar.eBrushStyle.Linear
        Me.GTrackBar5.ChangeLarge = 10
        Me.GTrackBar5.ChangeSmall = 1
        Me.GTrackBar5.ColorDown = System.Drawing.Color.CornflowerBlue
        Me.GTrackBar5.ColorDownBorder = System.Drawing.Color.DarkSlateBlue
        Me.GTrackBar5.ColorDownHiLt = System.Drawing.Color.AliceBlue
        Me.GTrackBar5.ColorHover = System.Drawing.Color.RoyalBlue
        Me.GTrackBar5.ColorHoverBorder = System.Drawing.Color.Blue
        Me.GTrackBar5.ColorHoverHiLt = System.Drawing.Color.White
        Me.GTrackBar5.ColorUp = System.Drawing.Color.MediumBlue
        Me.GTrackBar5.ColorUpBorder = System.Drawing.Color.DarkBlue
        Me.GTrackBar5.ColorUpHiLt = System.Drawing.Color.AliceBlue
        Me.GTrackBar5.FloatValue = True
        Me.GTrackBar5.FloatValueFont = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Bold)
        Me.GTrackBar5.FloatValueFontColor = System.Drawing.Color.MediumBlue
        Me.GTrackBar5.Label = Nothing
        Me.GTrackBar5.LabelAlighnment = System.Drawing.StringAlignment.Center
        Me.GTrackBar5.LabelColor = System.Drawing.Color.MediumBlue
        Me.GTrackBar5.LabelFont = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold)
        Me.GTrackBar5.LabelPadding = New System.Windows.Forms.Padding(0)
        Me.GTrackBar5.LabelShow = False
        Me.GTrackBar5.Location = New System.Drawing.Point(146, 349)
        Me.GTrackBar5.Margin = New System.Windows.Forms.Padding(2)
        Me.GTrackBar5.MaxValue = 50
        Me.GTrackBar5.MinValue = 0
        Me.GTrackBar5.Name = "GTrackBar5"
        Me.GTrackBar5.Orientation = System.Windows.Forms.Orientation.Horizontal
        Me.GTrackBar5.ShowFocus = False
        Me.GTrackBar5.Size = New System.Drawing.Size(179, 40)
        Me.GTrackBar5.SliderCapEnd = System.Drawing.Drawing2D.LineCap.Round
        Me.GTrackBar5.SliderCapStart = System.Drawing.Drawing2D.LineCap.Round
        Me.GTrackBar5.SliderColorHigh = System.Drawing.Color.DarkGray
        Me.GTrackBar5.SliderColorLow = System.Drawing.Color.DodgerBlue
        Me.GTrackBar5.SliderFocalPt = CType(resources.GetObject("GTrackBar5.SliderFocalPt"), System.Drawing.PointF)
        Me.GTrackBar5.SliderHighlightPt = CType(resources.GetObject("GTrackBar5.SliderHighlightPt"), System.Drawing.PointF)
        Me.GTrackBar5.SliderShape = gTrackBar.gTrackBar.eShape.Ellipse
        Me.GTrackBar5.SliderSize = New System.Drawing.Size(15, 15)
        Me.GTrackBar5.SliderWidth = 1
        Me.GTrackBar5.TabIndex = 14
        Me.GTrackBar5.TickColor = System.Drawing.Color.DarkGray
        Me.GTrackBar5.TickInterval = 10
        Me.GTrackBar5.TickType = gTrackBar.gTrackBar.eTickType.None
        Me.GTrackBar5.TickWidth = 5
        Me.GTrackBar5.UpDownAutoWidth = True
        Me.GTrackBar5.UpDownWidth = 30
        Me.GTrackBar5.Value = 20
        Me.GTrackBar5.ValueBox = gTrackBar.gTrackBar.eValueBox.None
        Me.GTrackBar5.ValueBoxBackColor = System.Drawing.Color.White
        Me.GTrackBar5.ValueBoxBorder = System.Drawing.Color.MediumBlue
        Me.GTrackBar5.ValueBoxFont = New System.Drawing.Font("Arial", 8.25!)
        Me.GTrackBar5.ValueBoxFontColor = System.Drawing.Color.MediumBlue
        Me.GTrackBar5.ValueBoxShape = gTrackBar.gTrackBar.eShape.Rectangle
        Me.GTrackBar5.ValueBoxSize = New System.Drawing.Size(30, 20)
        '
        'GTrackBar3
        '
        Me.GTrackBar3.AButColorA = System.Drawing.Color.CornflowerBlue
        Me.GTrackBar3.AButColorB = System.Drawing.Color.Lavender
        Me.GTrackBar3.AButColorBorder = System.Drawing.Color.SteelBlue
        Me.GTrackBar3.ArrowColorDown = System.Drawing.Color.GhostWhite
        Me.GTrackBar3.ArrowColorHover = System.Drawing.Color.DarkBlue
        Me.GTrackBar3.ArrowColorUp = System.Drawing.Color.LightSteelBlue
        Me.GTrackBar3.BackColor = System.Drawing.SystemColors.Control
        Me.GTrackBar3.BorderColor = System.Drawing.Color.Black
        Me.GTrackBar3.BorderShow = False
        Me.GTrackBar3.BrushDirection = System.Drawing.Drawing2D.LinearGradientMode.ForwardDiagonal
        Me.GTrackBar3.BrushStyle = gTrackBar.gTrackBar.eBrushStyle.Linear
        Me.GTrackBar3.ChangeLarge = 5
        Me.GTrackBar3.ChangeSmall = 1
        Me.GTrackBar3.ColorDown = System.Drawing.Color.CornflowerBlue
        Me.GTrackBar3.ColorDownBorder = System.Drawing.Color.DarkSlateBlue
        Me.GTrackBar3.ColorDownHiLt = System.Drawing.Color.AliceBlue
        Me.GTrackBar3.ColorHover = System.Drawing.Color.RoyalBlue
        Me.GTrackBar3.ColorHoverBorder = System.Drawing.Color.Blue
        Me.GTrackBar3.ColorHoverHiLt = System.Drawing.Color.White
        Me.GTrackBar3.ColorUp = System.Drawing.Color.MediumBlue
        Me.GTrackBar3.ColorUpBorder = System.Drawing.Color.DarkBlue
        Me.GTrackBar3.ColorUpHiLt = System.Drawing.Color.AliceBlue
        Me.GTrackBar3.FloatValue = True
        Me.GTrackBar3.FloatValueFont = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Bold)
        Me.GTrackBar3.FloatValueFontColor = System.Drawing.Color.MediumBlue
        Me.GTrackBar3.Label = "No Auto Button Size"
        Me.GTrackBar3.LabelAlighnment = System.Drawing.StringAlignment.Center
        Me.GTrackBar3.LabelColor = System.Drawing.Color.MediumBlue
        Me.GTrackBar3.LabelFont = New System.Drawing.Font("Arial", 10.0!, System.Drawing.FontStyle.Bold)
        Me.GTrackBar3.LabelPadding = New System.Windows.Forms.Padding(0)
        Me.GTrackBar3.LabelShow = True
        Me.GTrackBar3.Location = New System.Drawing.Point(180, 205)
        Me.GTrackBar3.Margin = New System.Windows.Forms.Padding(2)
        Me.GTrackBar3.MaxValue = 20
        Me.GTrackBar3.MinValue = 0
        Me.GTrackBar3.Name = "GTrackBar3"
        Me.GTrackBar3.Orientation = System.Windows.Forms.Orientation.Horizontal
        Me.GTrackBar3.ShowFocus = True
        Me.GTrackBar3.Size = New System.Drawing.Size(179, 39)
        Me.GTrackBar3.SliderCapEnd = System.Drawing.Drawing2D.LineCap.Round
        Me.GTrackBar3.SliderCapStart = System.Drawing.Drawing2D.LineCap.Round
        Me.GTrackBar3.SliderColorHigh = System.Drawing.Color.Transparent
        Me.GTrackBar3.SliderColorLow = System.Drawing.Color.LimeGreen
        Me.GTrackBar3.SliderFocalPt = CType(resources.GetObject("GTrackBar3.SliderFocalPt"), System.Drawing.PointF)
        Me.GTrackBar3.SliderHighlightPt = CType(resources.GetObject("GTrackBar3.SliderHighlightPt"), System.Drawing.PointF)
        Me.GTrackBar3.SliderShape = gTrackBar.gTrackBar.eShape.Rectangle
        Me.GTrackBar3.SliderSize = New System.Drawing.Size(20, 10)
        Me.GTrackBar3.SliderWidth = 5
        Me.GTrackBar3.TabIndex = 13
        Me.GTrackBar3.TickColor = System.Drawing.Color.DarkGray
        Me.GTrackBar3.TickInterval = 1
        Me.GTrackBar3.TickType = gTrackBar.gTrackBar.eTickType.Middle
        Me.GTrackBar3.TickWidth = 10
        Me.GTrackBar3.UpDownAutoWidth = False
        Me.GTrackBar3.UpDownWidth = 18
        Me.GTrackBar3.Value = 12
        Me.GTrackBar3.ValueBox = gTrackBar.gTrackBar.eValueBox.None
        Me.GTrackBar3.ValueBoxBackColor = System.Drawing.Color.White
        Me.GTrackBar3.ValueBoxBorder = System.Drawing.Color.MediumBlue
        Me.GTrackBar3.ValueBoxFont = New System.Drawing.Font("Arial", 8.25!)
        Me.GTrackBar3.ValueBoxFontColor = System.Drawing.Color.MediumBlue
        Me.GTrackBar3.ValueBoxShape = gTrackBar.gTrackBar.eShape.Rectangle
        Me.GTrackBar3.ValueBoxSize = New System.Drawing.Size(30, 20)
        '
        'GTrackBar8
        '
        Me.GTrackBar8.AButColorA = System.Drawing.Color.CornflowerBlue
        Me.GTrackBar8.AButColorB = System.Drawing.Color.AliceBlue
        Me.GTrackBar8.AButColorBorder = System.Drawing.Color.RoyalBlue
        Me.GTrackBar8.ArrowColorDown = System.Drawing.Color.White
        Me.GTrackBar8.ArrowColorHover = System.Drawing.Color.Black
        Me.GTrackBar8.ArrowColorUp = System.Drawing.Color.Gray
        Me.GTrackBar8.BackColor = System.Drawing.SystemColors.Control
        Me.GTrackBar8.BorderColor = System.Drawing.Color.LightSteelBlue
        Me.GTrackBar8.BorderShow = True
        Me.GTrackBar8.BrushDirection = System.Drawing.Drawing2D.LinearGradientMode.Horizontal
        Me.GTrackBar8.BrushStyle = gTrackBar.gTrackBar.eBrushStyle.Path
        Me.GTrackBar8.ChangeLarge = 10
        Me.GTrackBar8.ChangeSmall = 1
        Me.GTrackBar8.ColorDown = System.Drawing.Color.MistyRose
        Me.GTrackBar8.ColorDownBorder = System.Drawing.Color.Black
        Me.GTrackBar8.ColorDownHiLt = System.Drawing.Color.LightCoral
        Me.GTrackBar8.ColorHover = System.Drawing.Color.IndianRed
        Me.GTrackBar8.ColorHoverBorder = System.Drawing.Color.Black
        Me.GTrackBar8.ColorHoverHiLt = System.Drawing.Color.MistyRose
        Me.GTrackBar8.ColorUp = System.Drawing.Color.Red
        Me.GTrackBar8.ColorUpBorder = System.Drawing.Color.Black
        Me.GTrackBar8.ColorUpHiLt = System.Drawing.Color.White
        Me.GTrackBar8.FloatValue = True
        Me.GTrackBar8.FloatValueFont = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Bold)
        Me.GTrackBar8.FloatValueFontColor = System.Drawing.Color.Red
        Me.GTrackBar8.Label = Nothing
        Me.GTrackBar8.LabelAlighnment = System.Drawing.StringAlignment.Center
        Me.GTrackBar8.LabelColor = System.Drawing.Color.MediumBlue
        Me.GTrackBar8.LabelFont = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold)
        Me.GTrackBar8.LabelPadding = New System.Windows.Forms.Padding(0)
        Me.GTrackBar8.LabelShow = False
        Me.GTrackBar8.Location = New System.Drawing.Point(149, 271)
        Me.GTrackBar8.Margin = New System.Windows.Forms.Padding(2)
        Me.GTrackBar8.MaxValue = 255
        Me.GTrackBar8.MinValue = 0
        Me.GTrackBar8.Name = "GTrackBar8"
        Me.GTrackBar8.Orientation = System.Windows.Forms.Orientation.Horizontal
        Me.GTrackBar8.ShowFocus = False
        Me.GTrackBar8.Size = New System.Drawing.Size(233, 74)
        Me.GTrackBar8.SliderCapEnd = System.Drawing.Drawing2D.LineCap.Round
        Me.GTrackBar8.SliderCapStart = System.Drawing.Drawing2D.LineCap.Round
        Me.GTrackBar8.SliderColorHigh = System.Drawing.Color.DarkGray
        Me.GTrackBar8.SliderColorLow = System.Drawing.Color.Red
        Me.GTrackBar8.SliderFocalPt = CType(resources.GetObject("GTrackBar8.SliderFocalPt"), System.Drawing.PointF)
        Me.GTrackBar8.SliderHighlightPt = CType(resources.GetObject("GTrackBar8.SliderHighlightPt"), System.Drawing.PointF)
        Me.GTrackBar8.SliderShape = gTrackBar.gTrackBar.eShape.Ellipse
        Me.GTrackBar8.SliderSize = New System.Drawing.Size(15, 55)
        Me.GTrackBar8.SliderWidth = 3
        Me.GTrackBar8.TabIndex = 12
        Me.GTrackBar8.TickColor = System.Drawing.Color.Firebrick
        Me.GTrackBar8.TickInterval = 10
        Me.GTrackBar8.TickType = gTrackBar.gTrackBar.eTickType.Both
        Me.GTrackBar8.TickWidth = 5
        Me.GTrackBar8.UpDownAutoWidth = True
        Me.GTrackBar8.UpDownWidth = 30
        Me.GTrackBar8.Value = 135
        Me.GTrackBar8.ValueBox = gTrackBar.gTrackBar.eValueBox.Left
        Me.GTrackBar8.ValueBoxBackColor = System.Drawing.Color.MistyRose
        Me.GTrackBar8.ValueBoxBorder = System.Drawing.Color.Red
        Me.GTrackBar8.ValueBoxFont = New System.Drawing.Font("Arial", 6.0!)
        Me.GTrackBar8.ValueBoxFontColor = System.Drawing.Color.DarkRed
        Me.GTrackBar8.ValueBoxShape = gTrackBar.gTrackBar.eShape.Ellipse
        Me.GTrackBar8.ValueBoxSize = New System.Drawing.Size(20, 40)
        '
        'GTrackBar9
        '
        Me.GTrackBar9.AButColorA = System.Drawing.Color.IndianRed
        Me.GTrackBar9.AButColorB = System.Drawing.Color.MistyRose
        Me.GTrackBar9.AButColorBorder = System.Drawing.Color.DarkRed
        Me.GTrackBar9.ArrowColorDown = System.Drawing.Color.MistyRose
        Me.GTrackBar9.ArrowColorHover = System.Drawing.Color.DarkRed
        Me.GTrackBar9.ArrowColorUp = System.Drawing.Color.Red
        Me.GTrackBar9.BackColor = System.Drawing.Color.MistyRose
        Me.GTrackBar9.BorderColor = System.Drawing.Color.DarkRed
        Me.GTrackBar9.BorderShow = True
        Me.GTrackBar9.BrushDirection = System.Drawing.Drawing2D.LinearGradientMode.Horizontal
        Me.GTrackBar9.BrushStyle = gTrackBar.gTrackBar.eBrushStyle.Path
        Me.GTrackBar9.ChangeLarge = 10
        Me.GTrackBar9.ChangeSmall = 1
        Me.GTrackBar9.ColorDown = System.Drawing.Color.LightSlateGray
        Me.GTrackBar9.ColorDownBorder = System.Drawing.Color.Black
        Me.GTrackBar9.ColorDownHiLt = System.Drawing.Color.White
        Me.GTrackBar9.ColorHover = System.Drawing.Color.RoyalBlue
        Me.GTrackBar9.ColorHoverBorder = System.Drawing.Color.Black
        Me.GTrackBar9.ColorHoverHiLt = System.Drawing.Color.White
        Me.GTrackBar9.ColorUp = System.Drawing.Color.Firebrick
        Me.GTrackBar9.ColorUpBorder = System.Drawing.Color.Firebrick
        Me.GTrackBar9.ColorUpHiLt = System.Drawing.Color.White
        Me.GTrackBar9.FloatValue = True
        Me.GTrackBar9.FloatValueFont = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Bold)
        Me.GTrackBar9.FloatValueFontColor = System.Drawing.Color.Red
        Me.GTrackBar9.Label = Nothing
        Me.GTrackBar9.LabelAlighnment = System.Drawing.StringAlignment.Center
        Me.GTrackBar9.LabelColor = System.Drawing.Color.MediumBlue
        Me.GTrackBar9.LabelFont = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold)
        Me.GTrackBar9.LabelPadding = New System.Windows.Forms.Padding(0)
        Me.GTrackBar9.LabelShow = False
        Me.GTrackBar9.Location = New System.Drawing.Point(64, 465)
        Me.GTrackBar9.Margin = New System.Windows.Forms.Padding(2)
        Me.GTrackBar9.MaxValue = 255
        Me.GTrackBar9.MinValue = 0
        Me.GTrackBar9.Name = "GTrackBar9"
        Me.GTrackBar9.Orientation = System.Windows.Forms.Orientation.Horizontal
        Me.GTrackBar9.ShowFocus = False
        Me.GTrackBar9.Size = New System.Drawing.Size(318, 30)
        Me.GTrackBar9.SliderCapEnd = System.Drawing.Drawing2D.LineCap.Triangle
        Me.GTrackBar9.SliderCapStart = System.Drawing.Drawing2D.LineCap.Triangle
        Me.GTrackBar9.SliderColorHigh = System.Drawing.Color.Silver
        Me.GTrackBar9.SliderColorLow = System.Drawing.Color.Red
        Me.GTrackBar9.SliderFocalPt = CType(resources.GetObject("GTrackBar9.SliderFocalPt"), System.Drawing.PointF)
        Me.GTrackBar9.SliderHighlightPt = CType(resources.GetObject("GTrackBar9.SliderHighlightPt"), System.Drawing.PointF)
        Me.GTrackBar9.SliderShape = gTrackBar.gTrackBar.eShape.Ellipse
        Me.GTrackBar9.SliderSize = New System.Drawing.Size(20, 6)
        Me.GTrackBar9.SliderWidth = 2
        Me.GTrackBar9.TabIndex = 11
        Me.GTrackBar9.TickColor = System.Drawing.Color.Red
        Me.GTrackBar9.TickInterval = 10
        Me.GTrackBar9.TickType = gTrackBar.gTrackBar.eTickType.Both
        Me.GTrackBar9.TickWidth = 1
        Me.GTrackBar9.UpDownAutoWidth = True
        Me.GTrackBar9.UpDownWidth = 30
        Me.GTrackBar9.Value = 0
        Me.GTrackBar9.ValueBox = gTrackBar.gTrackBar.eValueBox.Right
        Me.GTrackBar9.ValueBoxBackColor = System.Drawing.Color.IndianRed
        Me.GTrackBar9.ValueBoxBorder = System.Drawing.Color.Red
        Me.GTrackBar9.ValueBoxFont = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GTrackBar9.ValueBoxFontColor = System.Drawing.Color.White
        Me.GTrackBar9.ValueBoxShape = gTrackBar.gTrackBar.eShape.Rectangle
        Me.GTrackBar9.ValueBoxSize = New System.Drawing.Size(25, 20)
        '
        'GTrackBar7
        '
        Me.GTrackBar7.AButColorA = System.Drawing.Color.CornflowerBlue
        Me.GTrackBar7.AButColorB = System.Drawing.Color.Lavender
        Me.GTrackBar7.AButColorBorder = System.Drawing.Color.SteelBlue
        Me.GTrackBar7.ArrowColorDown = System.Drawing.Color.GhostWhite
        Me.GTrackBar7.ArrowColorHover = System.Drawing.Color.DarkBlue
        Me.GTrackBar7.ArrowColorUp = System.Drawing.Color.LightSteelBlue
        Me.GTrackBar7.BackColor = System.Drawing.SystemColors.Control
        Me.GTrackBar7.BorderColor = System.Drawing.Color.Black
        Me.GTrackBar7.BorderShow = False
        Me.GTrackBar7.BrushDirection = System.Drawing.Drawing2D.LinearGradientMode.Horizontal
        Me.GTrackBar7.BrushStyle = gTrackBar.gTrackBar.eBrushStyle.Path
        Me.GTrackBar7.ChangeLarge = 10
        Me.GTrackBar7.ChangeSmall = 1
        Me.GTrackBar7.ColorDown = System.Drawing.Color.CornflowerBlue
        Me.GTrackBar7.ColorDownBorder = System.Drawing.Color.DarkSlateBlue
        Me.GTrackBar7.ColorDownHiLt = System.Drawing.Color.AliceBlue
        Me.GTrackBar7.ColorHover = System.Drawing.Color.RoyalBlue
        Me.GTrackBar7.ColorHoverBorder = System.Drawing.Color.Blue
        Me.GTrackBar7.ColorHoverHiLt = System.Drawing.Color.White
        Me.GTrackBar7.ColorUp = System.Drawing.Color.MediumBlue
        Me.GTrackBar7.ColorUpBorder = System.Drawing.Color.DarkBlue
        Me.GTrackBar7.ColorUpHiLt = System.Drawing.Color.AliceBlue
        Me.GTrackBar7.FloatValue = True
        Me.GTrackBar7.FloatValueFont = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Bold)
        Me.GTrackBar7.FloatValueFontColor = System.Drawing.Color.MediumBlue
        Me.GTrackBar7.Label = Nothing
        Me.GTrackBar7.LabelAlighnment = System.Drawing.StringAlignment.Center
        Me.GTrackBar7.LabelColor = System.Drawing.Color.MediumBlue
        Me.GTrackBar7.LabelFont = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold)
        Me.GTrackBar7.LabelPadding = New System.Windows.Forms.Padding(0)
        Me.GTrackBar7.LabelShow = False
        Me.GTrackBar7.Location = New System.Drawing.Point(8, 188)
        Me.GTrackBar7.Margin = New System.Windows.Forms.Padding(2)
        Me.GTrackBar7.MaxValue = 5000
        Me.GTrackBar7.MinValue = 0
        Me.GTrackBar7.Name = "GTrackBar7"
        Me.GTrackBar7.Orientation = System.Windows.Forms.Orientation.Vertical
        Me.GTrackBar7.ShowFocus = True
        Me.GTrackBar7.Size = New System.Drawing.Size(30, 401)
        Me.GTrackBar7.SliderCapEnd = System.Drawing.Drawing2D.LineCap.Round
        Me.GTrackBar7.SliderCapStart = System.Drawing.Drawing2D.LineCap.Round
        Me.GTrackBar7.SliderColorHigh = System.Drawing.Color.DarkGray
        Me.GTrackBar7.SliderColorLow = System.Drawing.Color.Red
        Me.GTrackBar7.SliderFocalPt = CType(resources.GetObject("GTrackBar7.SliderFocalPt"), System.Drawing.PointF)
        Me.GTrackBar7.SliderHighlightPt = CType(resources.GetObject("GTrackBar7.SliderHighlightPt"), System.Drawing.PointF)
        Me.GTrackBar7.SliderShape = gTrackBar.gTrackBar.eShape.Ellipse
        Me.GTrackBar7.SliderSize = New System.Drawing.Size(10, 20)
        Me.GTrackBar7.SliderWidth = 2
        Me.GTrackBar7.TabIndex = 10
        Me.GTrackBar7.TickColor = System.Drawing.Color.DarkGray
        Me.GTrackBar7.TickInterval = 10
        Me.GTrackBar7.TickType = gTrackBar.gTrackBar.eTickType.None
        Me.GTrackBar7.TickWidth = 5
        Me.GTrackBar7.UpDownAutoWidth = True
        Me.GTrackBar7.UpDownWidth = 30
        Me.GTrackBar7.Value = 3000
        Me.GTrackBar7.ValueBox = gTrackBar.gTrackBar.eValueBox.None
        Me.GTrackBar7.ValueBoxBackColor = System.Drawing.Color.White
        Me.GTrackBar7.ValueBoxBorder = System.Drawing.Color.MediumBlue
        Me.GTrackBar7.ValueBoxFont = New System.Drawing.Font("Arial", 8.25!)
        Me.GTrackBar7.ValueBoxFontColor = System.Drawing.Color.MediumBlue
        Me.GTrackBar7.ValueBoxShape = gTrackBar.gTrackBar.eShape.Rectangle
        Me.GTrackBar7.ValueBoxSize = New System.Drawing.Size(30, 20)
        '
        'GTrackBar2
        '
        Me.GTrackBar2.AButColorA = System.Drawing.Color.Goldenrod
        Me.GTrackBar2.AButColorB = System.Drawing.Color.LemonChiffon
        Me.GTrackBar2.AButColorBorder = System.Drawing.Color.SandyBrown
        Me.GTrackBar2.ArrowColorDown = System.Drawing.Color.White
        Me.GTrackBar2.ArrowColorHover = System.Drawing.Color.SaddleBrown
        Me.GTrackBar2.ArrowColorUp = System.Drawing.Color.Gray
        Me.GTrackBar2.BackColor = System.Drawing.Color.Tan
        Me.GTrackBar2.BorderColor = System.Drawing.Color.SaddleBrown
        Me.GTrackBar2.BorderShow = True
        Me.GTrackBar2.BrushDirection = System.Drawing.Drawing2D.LinearGradientMode.Horizontal
        Me.GTrackBar2.BrushStyle = gTrackBar.gTrackBar.eBrushStyle.Path
        Me.GTrackBar2.ChangeLarge = 10
        Me.GTrackBar2.ChangeSmall = 1
        Me.GTrackBar2.ColorDown = System.Drawing.Color.LightSlateGray
        Me.GTrackBar2.ColorDownBorder = System.Drawing.Color.Black
        Me.GTrackBar2.ColorDownHiLt = System.Drawing.Color.White
        Me.GTrackBar2.ColorHover = System.Drawing.Color.RoyalBlue
        Me.GTrackBar2.ColorHoverBorder = System.Drawing.Color.Black
        Me.GTrackBar2.ColorHoverHiLt = System.Drawing.Color.White
        Me.GTrackBar2.ColorUp = System.Drawing.Color.DarkBlue
        Me.GTrackBar2.ColorUpBorder = System.Drawing.Color.Black
        Me.GTrackBar2.ColorUpHiLt = System.Drawing.Color.White
        Me.GTrackBar2.FloatValue = True
        Me.GTrackBar2.FloatValueFont = New System.Drawing.Font("Arial", 10.0!, System.Drawing.FontStyle.Bold)
        Me.GTrackBar2.FloatValueFontColor = System.Drawing.Color.MediumBlue
        Me.GTrackBar2.Label = "-                    +"
        Me.GTrackBar2.LabelAlighnment = System.Drawing.StringAlignment.Near
        Me.GTrackBar2.LabelColor = System.Drawing.Color.LemonChiffon
        Me.GTrackBar2.LabelFont = New System.Drawing.Font("Arial", 18.0!)
        Me.GTrackBar2.LabelPadding = New System.Windows.Forms.Padding(59, 0, 0, -10)
        Me.GTrackBar2.LabelShow = True
        Me.GTrackBar2.Location = New System.Drawing.Point(340, 534)
        Me.GTrackBar2.Margin = New System.Windows.Forms.Padding(2)
        Me.GTrackBar2.MaxValue = 50
        Me.GTrackBar2.MinValue = -50
        Me.GTrackBar2.Name = "GTrackBar2"
        Me.GTrackBar2.Orientation = System.Windows.Forms.Orientation.Horizontal
        Me.GTrackBar2.ShowFocus = False
        Me.GTrackBar2.Size = New System.Drawing.Size(237, 55)
        Me.GTrackBar2.SliderCapEnd = System.Drawing.Drawing2D.LineCap.DiamondAnchor
        Me.GTrackBar2.SliderCapStart = System.Drawing.Drawing2D.LineCap.DiamondAnchor
        Me.GTrackBar2.SliderColorHigh = System.Drawing.Color.LightGoldenrodYellow
        Me.GTrackBar2.SliderColorLow = System.Drawing.Color.Gold
        Me.GTrackBar2.SliderFocalPt = CType(resources.GetObject("GTrackBar2.SliderFocalPt"), System.Drawing.PointF)
        Me.GTrackBar2.SliderHighlightPt = CType(resources.GetObject("GTrackBar2.SliderHighlightPt"), System.Drawing.PointF)
        Me.GTrackBar2.SliderShape = gTrackBar.gTrackBar.eShape.Ellipse
        Me.GTrackBar2.SliderSize = New System.Drawing.Size(15, 20)
        Me.GTrackBar2.SliderWidth = 8
        Me.GTrackBar2.TabIndex = 8
        Me.GTrackBar2.TickColor = System.Drawing.Color.DarkGray
        Me.GTrackBar2.TickInterval = 10
        Me.GTrackBar2.TickType = gTrackBar.gTrackBar.eTickType.None
        Me.GTrackBar2.TickWidth = 5
        Me.GTrackBar2.UpDownAutoWidth = True
        Me.GTrackBar2.UpDownWidth = 30
        Me.GTrackBar2.Value = -20
        Me.GTrackBar2.ValueBox = gTrackBar.gTrackBar.eValueBox.Left
        Me.GTrackBar2.ValueBoxBackColor = System.Drawing.Color.White
        Me.GTrackBar2.ValueBoxBorder = System.Drawing.Color.Sienna
        Me.GTrackBar2.ValueBoxFont = New System.Drawing.Font("Arial", 10.0!, System.Drawing.FontStyle.Bold)
        Me.GTrackBar2.ValueBoxFontColor = System.Drawing.Color.SaddleBrown
        Me.GTrackBar2.ValueBoxShape = gTrackBar.gTrackBar.eShape.Rectangle
        Me.GTrackBar2.ValueBoxSize = New System.Drawing.Size(40, 30)
        '
        'GTrackBar6
        '
        Me.GTrackBar6.AButColorA = System.Drawing.Color.Gray
        Me.GTrackBar6.AButColorB = System.Drawing.Color.LightGray
        Me.GTrackBar6.AButColorBorder = System.Drawing.Color.Gray
        Me.GTrackBar6.ArrowColorDown = System.Drawing.Color.White
        Me.GTrackBar6.ArrowColorHover = System.Drawing.Color.Black
        Me.GTrackBar6.ArrowColorUp = System.Drawing.Color.Gray
        Me.GTrackBar6.BackColor = System.Drawing.SystemColors.Control
        Me.GTrackBar6.BorderColor = System.Drawing.Color.Black
        Me.GTrackBar6.BorderShow = False
        Me.GTrackBar6.BrushDirection = System.Drawing.Drawing2D.LinearGradientMode.Vertical
        Me.GTrackBar6.BrushStyle = gTrackBar.gTrackBar.eBrushStyle.Linear
        Me.GTrackBar6.ChangeLarge = 10
        Me.GTrackBar6.ChangeSmall = 1
        Me.GTrackBar6.ColorDown = System.Drawing.Color.DarkBlue
        Me.GTrackBar6.ColorDownBorder = System.Drawing.Color.Transparent
        Me.GTrackBar6.ColorDownHiLt = System.Drawing.Color.IndianRed
        Me.GTrackBar6.ColorHover = System.Drawing.Color.MediumBlue
        Me.GTrackBar6.ColorHoverBorder = System.Drawing.Color.White
        Me.GTrackBar6.ColorHoverHiLt = System.Drawing.Color.LightCoral
        Me.GTrackBar6.ColorUp = System.Drawing.Color.DarkBlue
        Me.GTrackBar6.ColorUpBorder = System.Drawing.Color.Transparent
        Me.GTrackBar6.ColorUpHiLt = System.Drawing.Color.IndianRed
        Me.GTrackBar6.FloatValue = True
        Me.GTrackBar6.FloatValueFont = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Bold)
        Me.GTrackBar6.FloatValueFontColor = System.Drawing.Color.MediumBlue
        Me.GTrackBar6.Label = Nothing
        Me.GTrackBar6.LabelAlighnment = System.Drawing.StringAlignment.Center
        Me.GTrackBar6.LabelColor = System.Drawing.Color.MediumBlue
        Me.GTrackBar6.LabelFont = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold)
        Me.GTrackBar6.LabelPadding = New System.Windows.Forms.Padding(0)
        Me.GTrackBar6.LabelShow = False
        Me.GTrackBar6.Location = New System.Drawing.Point(42, 188)
        Me.GTrackBar6.Margin = New System.Windows.Forms.Padding(2)
        Me.GTrackBar6.MaxValue = 50
        Me.GTrackBar6.MinValue = 0
        Me.GTrackBar6.Name = "GTrackBar6"
        Me.GTrackBar6.Orientation = System.Windows.Forms.Orientation.Vertical
        Me.GTrackBar6.ShowFocus = True
        Me.GTrackBar6.Size = New System.Drawing.Size(75, 249)
        Me.GTrackBar6.SliderCapEnd = System.Drawing.Drawing2D.LineCap.ArrowAnchor
        Me.GTrackBar6.SliderCapStart = System.Drawing.Drawing2D.LineCap.SquareAnchor
        Me.GTrackBar6.SliderColorHigh = System.Drawing.Color.IndianRed
        Me.GTrackBar6.SliderColorLow = System.Drawing.Color.DarkBlue
        Me.GTrackBar6.SliderFocalPt = CType(resources.GetObject("GTrackBar6.SliderFocalPt"), System.Drawing.PointF)
        Me.GTrackBar6.SliderHighlightPt = CType(resources.GetObject("GTrackBar6.SliderHighlightPt"), System.Drawing.PointF)
        Me.GTrackBar6.SliderShape = gTrackBar.gTrackBar.eShape.Ellipse
        Me.GTrackBar6.SliderSize = New System.Drawing.Size(20, 29)
        Me.GTrackBar6.SliderWidth = 8
        Me.GTrackBar6.TabIndex = 8
        Me.GTrackBar6.TickColor = System.Drawing.Color.DarkGray
        Me.GTrackBar6.TickInterval = 10
        Me.GTrackBar6.TickType = gTrackBar.gTrackBar.eTickType.None
        Me.GTrackBar6.TickWidth = 5
        Me.GTrackBar6.UpDownAutoWidth = True
        Me.GTrackBar6.UpDownWidth = 30
        Me.GTrackBar6.Value = 25
        Me.GTrackBar6.ValueBox = gTrackBar.gTrackBar.eValueBox.Right
        Me.GTrackBar6.ValueBoxBackColor = System.Drawing.Color.White
        Me.GTrackBar6.ValueBoxBorder = System.Drawing.Color.MediumBlue
        Me.GTrackBar6.ValueBoxFont = New System.Drawing.Font("Arial", 8.25!)
        Me.GTrackBar6.ValueBoxFontColor = System.Drawing.Color.MediumBlue
        Me.GTrackBar6.ValueBoxShape = gTrackBar.gTrackBar.eShape.Rectangle
        Me.GTrackBar6.ValueBoxSize = New System.Drawing.Size(40, 30)
        '
        'GTrackBar14
        '
        Me.GTrackBar14.AButColorA = System.Drawing.Color.Transparent
        Me.GTrackBar14.AButColorB = System.Drawing.Color.Transparent
        Me.GTrackBar14.AButColorBorder = System.Drawing.Color.Transparent
        Me.GTrackBar14.ArrowColorDown = System.Drawing.Color.LightSteelBlue
        Me.GTrackBar14.ArrowColorHover = System.Drawing.Color.DarkBlue
        Me.GTrackBar14.ArrowColorUp = System.Drawing.Color.Transparent
        Me.GTrackBar14.BackColor = System.Drawing.SystemColors.Control
        Me.GTrackBar14.BorderColor = System.Drawing.Color.Black
        Me.GTrackBar14.BorderShow = True
        Me.GTrackBar14.BrushDirection = System.Drawing.Drawing2D.LinearGradientMode.ForwardDiagonal
        Me.GTrackBar14.BrushStyle = gTrackBar.gTrackBar.eBrushStyle.Linear
        Me.GTrackBar14.ChangeLarge = 10
        Me.GTrackBar14.ChangeSmall = 1
        Me.GTrackBar14.ColorDown = System.Drawing.Color.CornflowerBlue
        Me.GTrackBar14.ColorDownBorder = System.Drawing.Color.DarkSlateBlue
        Me.GTrackBar14.ColorDownHiLt = System.Drawing.Color.AliceBlue
        Me.GTrackBar14.ColorHover = System.Drawing.Color.RoyalBlue
        Me.GTrackBar14.ColorHoverBorder = System.Drawing.Color.Blue
        Me.GTrackBar14.ColorHoverHiLt = System.Drawing.Color.White
        Me.GTrackBar14.ColorUp = System.Drawing.Color.MediumBlue
        Me.GTrackBar14.ColorUpBorder = System.Drawing.Color.DarkBlue
        Me.GTrackBar14.ColorUpHiLt = System.Drawing.Color.AliceBlue
        Me.GTrackBar14.FloatValue = True
        Me.GTrackBar14.FloatValueFont = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Bold)
        Me.GTrackBar14.FloatValueFontColor = System.Drawing.Color.MediumBlue
        Me.GTrackBar14.Label = Nothing
        Me.GTrackBar14.LabelAlighnment = System.Drawing.StringAlignment.Center
        Me.GTrackBar14.LabelColor = System.Drawing.Color.MediumBlue
        Me.GTrackBar14.LabelFont = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold)
        Me.GTrackBar14.LabelPadding = New System.Windows.Forms.Padding(0)
        Me.GTrackBar14.LabelShow = False
        Me.GTrackBar14.Location = New System.Drawing.Point(146, 397)
        Me.GTrackBar14.Margin = New System.Windows.Forms.Padding(2)
        Me.GTrackBar14.MaxValue = 5
        Me.GTrackBar14.MinValue = 0
        Me.GTrackBar14.Name = "GTrackBar14"
        Me.GTrackBar14.Orientation = System.Windows.Forms.Orientation.Horizontal
        Me.GTrackBar14.ShowFocus = False
        Me.GTrackBar14.Size = New System.Drawing.Size(179, 40)
        Me.GTrackBar14.SliderCapEnd = System.Drawing.Drawing2D.LineCap.Round
        Me.GTrackBar14.SliderCapStart = System.Drawing.Drawing2D.LineCap.Round
        Me.GTrackBar14.SliderColorHigh = System.Drawing.Color.DarkGray
        Me.GTrackBar14.SliderColorLow = System.Drawing.Color.DodgerBlue
        Me.GTrackBar14.SliderFocalPt = CType(resources.GetObject("GTrackBar14.SliderFocalPt"), System.Drawing.PointF)
        Me.GTrackBar14.SliderHighlightPt = CType(resources.GetObject("GTrackBar14.SliderHighlightPt"), System.Drawing.PointF)
        Me.GTrackBar14.SliderShape = gTrackBar.gTrackBar.eShape.Ellipse
        Me.GTrackBar14.SliderSize = New System.Drawing.Size(15, 15)
        Me.GTrackBar14.SliderWidth = 1
        Me.GTrackBar14.TabIndex = 21
        Me.GTrackBar14.TickColor = System.Drawing.Color.DarkGray
        Me.GTrackBar14.TickInterval = 10
        Me.GTrackBar14.TickType = gTrackBar.gTrackBar.eTickType.None
        Me.GTrackBar14.TickWidth = 5
        Me.GTrackBar14.UpDownAutoWidth = True
        Me.GTrackBar14.UpDownWidth = 30
        Me.GTrackBar14.Value = 5
        Me.GTrackBar14.ValueBox = gTrackBar.gTrackBar.eValueBox.None
        Me.GTrackBar14.ValueBoxBackColor = System.Drawing.Color.White
        Me.GTrackBar14.ValueBoxBorder = System.Drawing.Color.MediumBlue
        Me.GTrackBar14.ValueBoxFont = New System.Drawing.Font("Arial", 8.25!)
        Me.GTrackBar14.ValueBoxFontColor = System.Drawing.Color.MediumBlue
        Me.GTrackBar14.ValueBoxShape = gTrackBar.gTrackBar.eShape.Rectangle
        Me.GTrackBar14.ValueBoxSize = New System.Drawing.Size(30, 20)
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(592, 599)
        Me.Controls.Add(Me.GTrackBar14)
        Me.Controls.Add(Me.GTrackBar1)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.GTrackBar13)
        Me.Controls.Add(Me.GTrackBar4)
        Me.Controls.Add(Me.GTrackBar12)
        Me.Controls.Add(Me.GTrackBar11)
        Me.Controls.Add(Me.GTrackBar10)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.GTrackBar5)
        Me.Controls.Add(Me.GTrackBar3)
        Me.Controls.Add(Me.GTrackBar8)
        Me.Controls.Add(Me.GTrackBar9)
        Me.Controls.Add(Me.GTrackBar7)
        Me.Controls.Add(Me.GTrackBar2)
        Me.Controls.Add(Me.GTrackBar6)
        Me.DoubleBuffered = True
        Me.Name = "Form1"
        Me.Text = "gTrackBar - Examples"
        Me.Panel1.ResumeLayout(False)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GTBarRed As gTrackBar.gTrackBar
    Friend WithEvents GTBarGreen As gTrackBar.gTrackBar
    Friend WithEvents GTBarBlue As gTrackBar.gTrackBar
    Friend WithEvents pRed As System.Windows.Forms.Panel
    Friend WithEvents pGreen As System.Windows.Forms.Panel
    Friend WithEvents pBlue As System.Windows.Forms.Panel
    Friend WithEvents pRGB As System.Windows.Forms.Panel
    Friend WithEvents GTrackBar4 As gTrackBar.gTrackBar
    Friend WithEvents GTrackBar6 As gTrackBar.gTrackBar
    Friend WithEvents GTrackBar1 As gTrackBar.gTrackBar
    Friend WithEvents GTrackBar7 As gTrackBar.gTrackBar
    Friend WithEvents GTrackBar8 As gTrackBar.gTrackBar
    Friend WithEvents GTrackBar9 As gTrackBar.gTrackBar
    Friend WithEvents GTrackBar3 As gTrackBar.gTrackBar
    Friend WithEvents GTrackBar5 As gTrackBar.gTrackBar
    Friend WithEvents GTrackBar2 As gTrackBar.gTrackBar
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents GTrackBar10 As gTrackBar.gTrackBar
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents GTrackBar11 As gTrackBar.gTrackBar
    Friend WithEvents GTrackBar12 As gTrackBar.gTrackBar
    Friend WithEvents GTrackBar13 As gTrackBar.gTrackBar
    Friend WithEvents GTrackBar14 As gTrackBar.gTrackBar
End Class
