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
        Me.AxFaceDetectionControl1 = New AxFaceDetectionControlLib.AxFaceDetectionControl()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtsourceimage = New System.Windows.Forms.TextBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.lbltotalface = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtfrontalcascade = New System.Windows.Forms.TextBox()
        Me.chkequalize = New System.Windows.Forms.CheckBox()
        Me.txtprofilecascade = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtscalefactor = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.cbomingeighors = New System.Windows.Forms.ComboBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txtminsizewidth = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.txtminsizeheight = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.txtmaxsizeheight = New System.Windows.Forms.TextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.txtmaxsizewidth = New System.Windows.Forms.TextBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.txtoutputimage = New System.Windows.Forms.TextBox()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.SaveFileDialog1 = New System.Windows.Forms.SaveFileDialog()
        Me.chkoutputdetectedimage = New System.Windows.Forms.CheckBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.ListBox1 = New System.Windows.Forms.ListBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.RadioButton3 = New System.Windows.Forms.RadioButton()
        Me.RadioButton2 = New System.Windows.Forms.RadioButton()
        Me.RadioButton1 = New System.Windows.Forms.RadioButton()
        Me.btnblacklist = New System.Windows.Forms.Button()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.chktiltedprofileface = New System.Windows.Forms.CheckBox()
        Me.chktiltedfrontalface = New System.Windows.Forms.CheckBox()
        Me.chkprofileface = New System.Windows.Forms.CheckBox()
        Me.chkfrontalface = New System.Windows.Forms.CheckBox()
        CType(Me.AxFaceDetectionControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'AxFaceDetectionControl1
        '
        Me.AxFaceDetectionControl1.Enabled = True
        Me.AxFaceDetectionControl1.Location = New System.Drawing.Point(659, 592)
        Me.AxFaceDetectionControl1.Margin = New System.Windows.Forms.Padding(4)
        Me.AxFaceDetectionControl1.Name = "AxFaceDetectionControl1"
        Me.AxFaceDetectionControl1.OcxState = CType(resources.GetObject("AxFaceDetectionControl1.OcxState"), System.Windows.Forms.AxHost.State)
        Me.AxFaceDetectionControl1.Size = New System.Drawing.Size(328, 107)
        Me.AxFaceDetectionControl1.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(36, 114)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(53, 18)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Image"
        '
        'txtsourceimage
        '
        Me.txtsourceimage.Location = New System.Drawing.Point(146, 114)
        Me.txtsourceimage.Margin = New System.Windows.Forms.Padding(4)
        Me.txtsourceimage.Name = "txtsourceimage"
        Me.txtsourceimage.Size = New System.Drawing.Size(536, 28)
        Me.txtsourceimage.TabIndex = 2
        '
        'Button1
        '
        Me.Button1.Enabled = False
        Me.Button1.Location = New System.Drawing.Point(714, 114)
        Me.Button1.Margin = New System.Windows.Forms.Padding(4)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(153, 28)
        Me.Button1.TabIndex = 3
        Me.Button1.Text = "Select"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(36, 186)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(107, 18)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Total Face:"
        '
        'lbltotalface
        '
        Me.lbltotalface.AutoSize = True
        Me.lbltotalface.Location = New System.Drawing.Point(156, 186)
        Me.lbltotalface.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lbltotalface.Name = "lbltotalface"
        Me.lbltotalface.Size = New System.Drawing.Size(17, 18)
        Me.lbltotalface.TabIndex = 5
        Me.lbltotalface.Text = "0"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(36, 236)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(188, 18)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "Frontal Cascade File"
        '
        'txtfrontalcascade
        '
        Me.txtfrontalcascade.Location = New System.Drawing.Point(222, 236)
        Me.txtfrontalcascade.Margin = New System.Windows.Forms.Padding(4)
        Me.txtfrontalcascade.Name = "txtfrontalcascade"
        Me.txtfrontalcascade.Size = New System.Drawing.Size(460, 28)
        Me.txtfrontalcascade.TabIndex = 7
        Me.txtfrontalcascade.Text = "haarcascade_frontalface_alt.xml"
        '
        'chkequalize
        '
        Me.chkequalize.AutoSize = True
        Me.chkequalize.Checked = True
        Me.chkequalize.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chkequalize.Location = New System.Drawing.Point(39, 441)
        Me.chkequalize.Margin = New System.Windows.Forms.Padding(4)
        Me.chkequalize.Name = "chkequalize"
        Me.chkequalize.Size = New System.Drawing.Size(376, 22)
        Me.chkequalize.TabIndex = 9
        Me.chkequalize.Text = "Equalize Histogram to enhance contrast"
        Me.chkequalize.UseVisualStyleBackColor = True
        '
        'txtprofilecascade
        '
        Me.txtprofilecascade.Location = New System.Drawing.Point(222, 497)
        Me.txtprofilecascade.Margin = New System.Windows.Forms.Padding(4)
        Me.txtprofilecascade.Name = "txtprofilecascade"
        Me.txtprofilecascade.Size = New System.Drawing.Size(460, 28)
        Me.txtprofilecascade.TabIndex = 11
        Me.txtprofilecascade.Text = "haarcascade_profileface.xml"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(36, 497)
        Me.Label4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(188, 18)
        Me.Label4.TabIndex = 10
        Me.Label4.Text = "Profile Cascade File"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(36, 567)
        Me.Label5.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(188, 18)
        Me.Label5.TabIndex = 12
        Me.Label5.Text = "Scale Factor (> 1.0)"
        '
        'txtscalefactor
        '
        Me.txtscalefactor.Location = New System.Drawing.Point(222, 567)
        Me.txtscalefactor.Margin = New System.Windows.Forms.Padding(4)
        Me.txtscalefactor.Name = "txtscalefactor"
        Me.txtscalefactor.Size = New System.Drawing.Size(126, 28)
        Me.txtscalefactor.TabIndex = 13
        Me.txtscalefactor.Text = "1.06"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(40, 622)
        Me.Label6.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(161, 18)
        Me.Label6.TabIndex = 14
        Me.Label6.Text = "Minimum Neighbors"
        '
        'cbomingeighors
        '
        Me.cbomingeighors.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbomingeighors.FormattingEnabled = True
        Me.cbomingeighors.Location = New System.Drawing.Point(222, 622)
        Me.cbomingeighors.Margin = New System.Windows.Forms.Padding(4)
        Me.cbomingeighors.Name = "cbomingeighors"
        Me.cbomingeighors.Size = New System.Drawing.Size(126, 26)
        Me.cbomingeighors.TabIndex = 15
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(42, 681)
        Me.Label7.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(530, 18)
        Me.Label7.TabIndex = 16
        Me.Label7.Text = "Minimum Object Size, Objects smaller than that are ignored"
        '
        'txtminsizewidth
        '
        Me.txtminsizewidth.Location = New System.Drawing.Point(146, 703)
        Me.txtminsizewidth.Margin = New System.Windows.Forms.Padding(4)
        Me.txtminsizewidth.Name = "txtminsizewidth"
        Me.txtminsizewidth.Size = New System.Drawing.Size(62, 28)
        Me.txtminsizewidth.TabIndex = 17
        Me.txtminsizewidth.Text = "0"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(57, 707)
        Me.Label8.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(53, 18)
        Me.Label8.TabIndex = 18
        Me.Label8.Text = "Width"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(57, 748)
        Me.Label9.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(62, 18)
        Me.Label9.TabIndex = 20
        Me.Label9.Text = "Height"
        '
        'txtminsizeheight
        '
        Me.txtminsizeheight.Location = New System.Drawing.Point(146, 743)
        Me.txtminsizeheight.Margin = New System.Windows.Forms.Padding(4)
        Me.txtminsizeheight.Name = "txtminsizeheight"
        Me.txtminsizeheight.Size = New System.Drawing.Size(62, 28)
        Me.txtminsizeheight.TabIndex = 19
        Me.txtminsizeheight.Text = "0"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(42, 891)
        Me.Label10.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(62, 18)
        Me.Label10.TabIndex = 25
        Me.Label10.Text = "Height"
        '
        'txtmaxsizeheight
        '
        Me.txtmaxsizeheight.Location = New System.Drawing.Point(130, 887)
        Me.txtmaxsizeheight.Margin = New System.Windows.Forms.Padding(4)
        Me.txtmaxsizeheight.Name = "txtmaxsizeheight"
        Me.txtmaxsizeheight.Size = New System.Drawing.Size(62, 28)
        Me.txtmaxsizeheight.TabIndex = 24
        Me.txtmaxsizeheight.Text = "0"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(42, 851)
        Me.Label11.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(53, 18)
        Me.Label11.TabIndex = 23
        Me.Label11.Text = "Width"
        '
        'txtmaxsizewidth
        '
        Me.txtmaxsizewidth.Location = New System.Drawing.Point(130, 847)
        Me.txtmaxsizewidth.Margin = New System.Windows.Forms.Padding(4)
        Me.txtmaxsizewidth.Name = "txtmaxsizewidth"
        Me.txtmaxsizewidth.Size = New System.Drawing.Size(62, 28)
        Me.txtmaxsizewidth.TabIndex = 22
        Me.txtmaxsizewidth.Text = "0"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(42, 808)
        Me.Label12.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(521, 18)
        Me.Label12.TabIndex = 21
        Me.Label12.Text = "Maximum Object Size, Objects larger than that are ignored"
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(958, 6)
        Me.Button2.Margin = New System.Windows.Forms.Padding(4)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(230, 56)
        Me.Button2.TabIndex = 26
        Me.Button2.Text = "Detect Face"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        '
        'PictureBox1
        '
        Me.PictureBox1.Location = New System.Drawing.Point(963, 195)
        Me.PictureBox1.Margin = New System.Windows.Forms.Padding(4)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(705, 458)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 27
        Me.PictureBox1.TabStop = False
        '
        'txtoutputimage
        '
        Me.txtoutputimage.Location = New System.Drawing.Point(963, 141)
        Me.txtoutputimage.Margin = New System.Windows.Forms.Padding(4)
        Me.txtoutputimage.Name = "txtoutputimage"
        Me.txtoutputimage.Size = New System.Drawing.Size(517, 28)
        Me.txtoutputimage.TabIndex = 28
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(1515, 140)
        Me.Button3.Margin = New System.Windows.Forms.Padding(4)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(153, 28)
        Me.Button3.TabIndex = 29
        Me.Button3.Text = "Select"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'chkoutputdetectedimage
        '
        Me.chkoutputdetectedimage.AutoSize = True
        Me.chkoutputdetectedimage.Checked = True
        Me.chkoutputdetectedimage.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chkoutputdetectedimage.Location = New System.Drawing.Point(963, 110)
        Me.chkoutputdetectedimage.Margin = New System.Windows.Forms.Padding(4)
        Me.chkoutputdetectedimage.Name = "chkoutputdetectedimage"
        Me.chkoutputdetectedimage.Size = New System.Drawing.Size(223, 22)
        Me.chkoutputdetectedimage.TabIndex = 30
        Me.chkoutputdetectedimage.Text = "Output Detected Image"
        Me.chkoutputdetectedimage.UseVisualStyleBackColor = True
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(964, 668)
        Me.Label13.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(233, 18)
        Me.Label13.TabIndex = 31
        Me.Label13.Text = "Detected Object Rectangle"
        '
        'ListBox1
        '
        Me.ListBox1.FormattingEnabled = True
        Me.ListBox1.ItemHeight = 18
        Me.ListBox1.Location = New System.Drawing.Point(966, 700)
        Me.ListBox1.Margin = New System.Windows.Forms.Padding(4)
        Me.ListBox1.Name = "ListBox1"
        Me.ListBox1.Size = New System.Drawing.Size(362, 112)
        Me.ListBox1.TabIndex = 32
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.RadioButton3)
        Me.GroupBox1.Controls.Add(Me.RadioButton2)
        Me.GroupBox1.Controls.Add(Me.RadioButton1)
        Me.GroupBox1.Location = New System.Drawing.Point(45, 10)
        Me.GroupBox1.Margin = New System.Windows.Forms.Padding(4)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Padding = New System.Windows.Forms.Padding(4)
        Me.GroupBox1.Size = New System.Drawing.Size(874, 63)
        Me.GroupBox1.TabIndex = 33
        Me.GroupBox1.TabStop = False
        '
        'RadioButton3
        '
        Me.RadioButton3.AutoSize = True
        Me.RadioButton3.Location = New System.Drawing.Point(627, 27)
        Me.RadioButton3.Margin = New System.Windows.Forms.Padding(4)
        Me.RadioButton3.Name = "RadioButton3"
        Me.RadioButton3.Size = New System.Drawing.Size(141, 22)
        Me.RadioButton3.TabIndex = 2
        Me.RadioButton3.Text = "Custom Image"
        Me.RadioButton3.UseVisualStyleBackColor = True
        '
        'RadioButton2
        '
        Me.RadioButton2.AutoSize = True
        Me.RadioButton2.Location = New System.Drawing.Point(334, 27)
        Me.RadioButton2.Margin = New System.Windows.Forms.Padding(4)
        Me.RadioButton2.Name = "RadioButton2"
        Me.RadioButton2.Size = New System.Drawing.Size(141, 22)
        Me.RadioButton2.TabIndex = 1
        Me.RadioButton2.Text = "Demo Image 2"
        Me.RadioButton2.UseVisualStyleBackColor = True
        '
        'RadioButton1
        '
        Me.RadioButton1.AutoSize = True
        Me.RadioButton1.Checked = True
        Me.RadioButton1.Location = New System.Drawing.Point(34, 27)
        Me.RadioButton1.Margin = New System.Windows.Forms.Padding(4)
        Me.RadioButton1.Name = "RadioButton1"
        Me.RadioButton1.Size = New System.Drawing.Size(141, 22)
        Me.RadioButton1.TabIndex = 0
        Me.RadioButton1.TabStop = True
        Me.RadioButton1.Text = "Demo Image 1"
        Me.RadioButton1.UseVisualStyleBackColor = True
        '
        'btnblacklist
        '
        Me.btnblacklist.Enabled = False
        Me.btnblacklist.Location = New System.Drawing.Point(1340, 735)
        Me.btnblacklist.Margin = New System.Windows.Forms.Padding(4)
        Me.btnblacklist.Name = "btnblacklist"
        Me.btnblacklist.Size = New System.Drawing.Size(484, 62)
        Me.btnblacklist.TabIndex = 35
        Me.btnblacklist.Text = "Black List 1st and 2nd detected object and Detect Face again"
        Me.btnblacklist.UseVisualStyleBackColor = True
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.Location = New System.Drawing.Point(960, 66)
        Me.Label14.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(904, 19)
        Me.Label14.TabIndex = 36
        Me.Label14.Text = "If you want to detect the faces more Accuracy, you may increase Scale Factor and " & _
    "set the Minimum/Maximum Object Size "
        '
        'chktiltedprofileface
        '
        Me.chktiltedprofileface.AutoSize = True
        Me.chktiltedprofileface.Checked = True
        Me.chktiltedprofileface.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chktiltedprofileface.Location = New System.Drawing.Point(39, 389)
        Me.chktiltedprofileface.Name = "chktiltedprofileface"
        Me.chktiltedprofileface.Size = New System.Drawing.Size(439, 22)
        Me.chktiltedprofileface.TabIndex = 79
        Me.chktiltedprofileface.Text = "Detect left side  and right side profile face"
        Me.chktiltedprofileface.UseVisualStyleBackColor = True
        '
        'chktiltedfrontalface
        '
        Me.chktiltedfrontalface.AutoSize = True
        Me.chktiltedfrontalface.Checked = True
        Me.chktiltedfrontalface.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chktiltedfrontalface.Location = New System.Drawing.Point(40, 348)
        Me.chktiltedfrontalface.Name = "chktiltedfrontalface"
        Me.chktiltedfrontalface.Size = New System.Drawing.Size(538, 22)
        Me.chktiltedfrontalface.TabIndex = 78
        Me.chktiltedfrontalface.Text = "Detect frontal face tilted clock-wise,counter-clock-wise"
        Me.chktiltedfrontalface.UseVisualStyleBackColor = True
        '
        'chkprofileface
        '
        Me.chkprofileface.AutoSize = True
        Me.chkprofileface.Checked = True
        Me.chkprofileface.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chkprofileface.Location = New System.Drawing.Point(260, 307)
        Me.chkprofileface.Name = "chkprofileface"
        Me.chkprofileface.Size = New System.Drawing.Size(205, 22)
        Me.chkprofileface.TabIndex = 77
        Me.chkprofileface.Text = "Detect Profile Face"
        Me.chkprofileface.UseVisualStyleBackColor = True
        '
        'chkfrontalface
        '
        Me.chkfrontalface.AutoSize = True
        Me.chkfrontalface.Checked = True
        Me.chkfrontalface.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chkfrontalface.Location = New System.Drawing.Point(39, 307)
        Me.chkfrontalface.Name = "chkfrontalface"
        Me.chkfrontalface.Size = New System.Drawing.Size(205, 22)
        Me.chkfrontalface.TabIndex = 76
        Me.chkfrontalface.Text = "Detect frontal face"
        Me.chkfrontalface.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 18.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1858, 938)
        Me.Controls.Add(Me.chktiltedprofileface)
        Me.Controls.Add(Me.chktiltedfrontalface)
        Me.Controls.Add(Me.chkprofileface)
        Me.Controls.Add(Me.chkfrontalface)
        Me.Controls.Add(Me.Label14)
        Me.Controls.Add(Me.btnblacklist)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.ListBox1)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.chkoutputdetectedimage)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.txtoutputimage)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.txtmaxsizeheight)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.txtmaxsizewidth)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.txtminsizeheight)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.txtminsizewidth)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.cbomingeighors)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.txtscalefactor)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.txtprofilecascade)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.chkequalize)
        Me.Controls.Add(Me.txtfrontalcascade)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.lbltotalface)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.txtsourceimage)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.AxFaceDetectionControl1)
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "Form1"
        Me.Text = "Face Detection Demo"
        CType(Me.AxFaceDetectionControl1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents AxFaceDetectionControl1 As AxFaceDetectionControlLib.AxFaceDetectionControl
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtsourceimage As System.Windows.Forms.TextBox
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents lbltotalface As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txtfrontalcascade As System.Windows.Forms.TextBox
    Friend WithEvents chkequalize As System.Windows.Forms.CheckBox
    Friend WithEvents txtprofilecascade As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents txtscalefactor As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents cbomingeighors As System.Windows.Forms.ComboBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents txtminsizewidth As System.Windows.Forms.TextBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents txtminsizeheight As System.Windows.Forms.TextBox
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents txtmaxsizeheight As System.Windows.Forms.TextBox
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents txtmaxsizewidth As System.Windows.Forms.TextBox
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents OpenFileDialog1 As System.Windows.Forms.OpenFileDialog
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents txtoutputimage As System.Windows.Forms.TextBox
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents SaveFileDialog1 As System.Windows.Forms.SaveFileDialog
    Friend WithEvents chkoutputdetectedimage As System.Windows.Forms.CheckBox
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents ListBox1 As System.Windows.Forms.ListBox
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents RadioButton3 As System.Windows.Forms.RadioButton
    Friend WithEvents RadioButton2 As System.Windows.Forms.RadioButton
    Friend WithEvents RadioButton1 As System.Windows.Forms.RadioButton
    Friend WithEvents btnblacklist As System.Windows.Forms.Button
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Private WithEvents chktiltedprofileface As System.Windows.Forms.CheckBox
    Private WithEvents chktiltedfrontalface As System.Windows.Forms.CheckBox
    Private WithEvents chkprofileface As System.Windows.Forms.CheckBox
    Private WithEvents chkfrontalface As System.Windows.Forms.CheckBox

End Class
