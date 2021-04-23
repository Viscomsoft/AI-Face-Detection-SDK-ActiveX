namespace WindowsFormsApplication1
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.OpenFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.btnblacklist = new System.Windows.Forms.Button();
            this.RadioButton1 = new System.Windows.Forms.RadioButton();
            this.GroupBox1 = new System.Windows.Forms.GroupBox();
            this.RadioButton3 = new System.Windows.Forms.RadioButton();
            this.RadioButton2 = new System.Windows.Forms.RadioButton();
            this.ListBox1 = new System.Windows.Forms.ListBox();
            this.SaveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.Label13 = new System.Windows.Forms.Label();
            this.chkoutputdetectedimage = new System.Windows.Forms.CheckBox();
            this.BtnOutputImage = new System.Windows.Forms.Button();
            this.txtoutputimage = new System.Windows.Forms.TextBox();
            this.PictureBox1 = new System.Windows.Forms.PictureBox();
            this.Button2 = new System.Windows.Forms.Button();
            this.Label10 = new System.Windows.Forms.Label();
            this.txtmaxsizeheight = new System.Windows.Forms.TextBox();
            this.Label11 = new System.Windows.Forms.Label();
            this.txtmaxsizewidth = new System.Windows.Forms.TextBox();
            this.Label12 = new System.Windows.Forms.Label();
            this.Label9 = new System.Windows.Forms.Label();
            this.txtminsizeheight = new System.Windows.Forms.TextBox();
            this.Label8 = new System.Windows.Forms.Label();
            this.txtminsizewidth = new System.Windows.Forms.TextBox();
            this.Label7 = new System.Windows.Forms.Label();
            this.cbomingeighors = new System.Windows.Forms.ComboBox();
            this.Label6 = new System.Windows.Forms.Label();
            this.txtscalefactor = new System.Windows.Forms.TextBox();
            this.Label5 = new System.Windows.Forms.Label();
            this.txtprofilecascade = new System.Windows.Forms.TextBox();
            this.Label4 = new System.Windows.Forms.Label();
            this.chkequalize = new System.Windows.Forms.CheckBox();
            this.txtfrontalcascade = new System.Windows.Forms.TextBox();
            this.Label3 = new System.Windows.Forms.Label();
            this.lbltotalface = new System.Windows.Forms.Label();
            this.Label2 = new System.Windows.Forms.Label();
            this.BtnSourceImage = new System.Windows.Forms.Button();
            this.txtsourceimage = new System.Windows.Forms.TextBox();
            this.Label1 = new System.Windows.Forms.Label();
            this.axFaceDetectionControl1 = new AxFaceDetectionControlLib.AxFaceDetectionControl();
            this.label14 = new System.Windows.Forms.Label();
            this.chkfrontalface = new System.Windows.Forms.CheckBox();
            this.chkprofileface = new System.Windows.Forms.CheckBox();
            this.chktiltedfrontalface = new System.Windows.Forms.CheckBox();
            this.chktiltedprofileface = new System.Windows.Forms.CheckBox();
            this.GroupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.axFaceDetectionControl1)).BeginInit();
            this.SuspendLayout();
            // 
            // OpenFileDialog1
            // 
            this.OpenFileDialog1.FileName = "OpenFileDialog1";
            // 
            // btnblacklist
            // 
            this.btnblacklist.Enabled = false;
            this.btnblacklist.Location = new System.Drawing.Point(1312, 747);
            this.btnblacklist.Margin = new System.Windows.Forms.Padding(4);
            this.btnblacklist.Name = "btnblacklist";
            this.btnblacklist.Size = new System.Drawing.Size(484, 62);
            this.btnblacklist.TabIndex = 69;
            this.btnblacklist.Text = "Black List 1st and 2nd detected object and Detect Face again";
            this.btnblacklist.UseVisualStyleBackColor = true;
            this.btnblacklist.Click += new System.EventHandler(this.btnblacklist_Click);
            // 
            // RadioButton1
            // 
            this.RadioButton1.AutoSize = true;
            this.RadioButton1.Checked = true;
            this.RadioButton1.Location = new System.Drawing.Point(34, 27);
            this.RadioButton1.Margin = new System.Windows.Forms.Padding(4);
            this.RadioButton1.Name = "RadioButton1";
            this.RadioButton1.Size = new System.Drawing.Size(141, 22);
            this.RadioButton1.TabIndex = 0;
            this.RadioButton1.TabStop = true;
            this.RadioButton1.Text = "Demo Image 1";
            this.RadioButton1.UseVisualStyleBackColor = true;
            this.RadioButton1.Click += new System.EventHandler(this.RadioButton1_Click);
            // 
            // GroupBox1
            // 
            this.GroupBox1.Controls.Add(this.RadioButton3);
            this.GroupBox1.Controls.Add(this.RadioButton2);
            this.GroupBox1.Controls.Add(this.RadioButton1);
            this.GroupBox1.Location = new System.Drawing.Point(18, 24);
            this.GroupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.GroupBox1.Name = "GroupBox1";
            this.GroupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.GroupBox1.Size = new System.Drawing.Size(874, 81);
            this.GroupBox1.TabIndex = 68;
            this.GroupBox1.TabStop = false;
            // 
            // RadioButton3
            // 
            this.RadioButton3.AutoSize = true;
            this.RadioButton3.Location = new System.Drawing.Point(627, 27);
            this.RadioButton3.Margin = new System.Windows.Forms.Padding(4);
            this.RadioButton3.Name = "RadioButton3";
            this.RadioButton3.Size = new System.Drawing.Size(141, 22);
            this.RadioButton3.TabIndex = 2;
            this.RadioButton3.Text = "Custom Image";
            this.RadioButton3.UseVisualStyleBackColor = true;
            this.RadioButton3.Click += new System.EventHandler(this.RadioButton3_Click);
            // 
            // RadioButton2
            // 
            this.RadioButton2.AutoSize = true;
            this.RadioButton2.Location = new System.Drawing.Point(334, 27);
            this.RadioButton2.Margin = new System.Windows.Forms.Padding(4);
            this.RadioButton2.Name = "RadioButton2";
            this.RadioButton2.Size = new System.Drawing.Size(141, 22);
            this.RadioButton2.TabIndex = 1;
            this.RadioButton2.Text = "Demo Image 2";
            this.RadioButton2.UseVisualStyleBackColor = true;
            this.RadioButton2.Click += new System.EventHandler(this.RadioButton2_Click);
            // 
            // ListBox1
            // 
            this.ListBox1.FormattingEnabled = true;
            this.ListBox1.ItemHeight = 18;
            this.ListBox1.Location = new System.Drawing.Point(939, 712);
            this.ListBox1.Margin = new System.Windows.Forms.Padding(4);
            this.ListBox1.Name = "ListBox1";
            this.ListBox1.Size = new System.Drawing.Size(362, 112);
            this.ListBox1.TabIndex = 67;
            // 
            // Label13
            // 
            this.Label13.AutoSize = true;
            this.Label13.Location = new System.Drawing.Point(938, 680);
            this.Label13.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Label13.Name = "Label13";
            this.Label13.Size = new System.Drawing.Size(233, 18);
            this.Label13.TabIndex = 66;
            this.Label13.Text = "Detected Object Rectangle";
            // 
            // chkoutputdetectedimage
            // 
            this.chkoutputdetectedimage.AutoSize = true;
            this.chkoutputdetectedimage.Checked = true;
            this.chkoutputdetectedimage.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkoutputdetectedimage.Location = new System.Drawing.Point(934, 114);
            this.chkoutputdetectedimage.Margin = new System.Windows.Forms.Padding(4);
            this.chkoutputdetectedimage.Name = "chkoutputdetectedimage";
            this.chkoutputdetectedimage.Size = new System.Drawing.Size(223, 22);
            this.chkoutputdetectedimage.TabIndex = 65;
            this.chkoutputdetectedimage.Text = "Output Detected Image";
            this.chkoutputdetectedimage.UseVisualStyleBackColor = true;
            this.chkoutputdetectedimage.Click += new System.EventHandler(this.chkoutputdetectedimage_Click);
            // 
            // BtnOutputImage
            // 
            this.BtnOutputImage.Location = new System.Drawing.Point(1488, 153);
            this.BtnOutputImage.Margin = new System.Windows.Forms.Padding(4);
            this.BtnOutputImage.Name = "BtnOutputImage";
            this.BtnOutputImage.Size = new System.Drawing.Size(153, 28);
            this.BtnOutputImage.TabIndex = 64;
            this.BtnOutputImage.Text = "Select";
            this.BtnOutputImage.UseVisualStyleBackColor = true;
            this.BtnOutputImage.Click += new System.EventHandler(this.BtnOutputImage_Click);
            // 
            // txtoutputimage
            // 
            this.txtoutputimage.Location = new System.Drawing.Point(936, 153);
            this.txtoutputimage.Margin = new System.Windows.Forms.Padding(4);
            this.txtoutputimage.Name = "txtoutputimage";
            this.txtoutputimage.Size = new System.Drawing.Size(517, 28);
            this.txtoutputimage.TabIndex = 63;
            // 
            // PictureBox1
            // 
            this.PictureBox1.Location = new System.Drawing.Point(936, 207);
            this.PictureBox1.Margin = new System.Windows.Forms.Padding(4);
            this.PictureBox1.Name = "PictureBox1";
            this.PictureBox1.Size = new System.Drawing.Size(705, 458);
            this.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PictureBox1.TabIndex = 62;
            this.PictureBox1.TabStop = false;
            // 
            // Button2
            // 
            this.Button2.Location = new System.Drawing.Point(930, 4);
            this.Button2.Margin = new System.Windows.Forms.Padding(4);
            this.Button2.Name = "Button2";
            this.Button2.Size = new System.Drawing.Size(230, 56);
            this.Button2.TabIndex = 61;
            this.Button2.Text = "Detect Face";
            this.Button2.UseVisualStyleBackColor = true;
            this.Button2.Click += new System.EventHandler(this.Button2_Click);
            // 
            // Label10
            // 
            this.Label10.AutoSize = true;
            this.Label10.Location = new System.Drawing.Point(30, 831);
            this.Label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Label10.Name = "Label10";
            this.Label10.Size = new System.Drawing.Size(62, 18);
            this.Label10.TabIndex = 60;
            this.Label10.Text = "Height";
            // 
            // txtmaxsizeheight
            // 
            this.txtmaxsizeheight.Location = new System.Drawing.Point(118, 826);
            this.txtmaxsizeheight.Margin = new System.Windows.Forms.Padding(4);
            this.txtmaxsizeheight.Name = "txtmaxsizeheight";
            this.txtmaxsizeheight.Size = new System.Drawing.Size(62, 28);
            this.txtmaxsizeheight.TabIndex = 59;
            this.txtmaxsizeheight.Text = "0";
            // 
            // Label11
            // 
            this.Label11.AutoSize = true;
            this.Label11.Location = new System.Drawing.Point(30, 790);
            this.Label11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Label11.Name = "Label11";
            this.Label11.Size = new System.Drawing.Size(53, 18);
            this.Label11.TabIndex = 58;
            this.Label11.Text = "Width";
            // 
            // txtmaxsizewidth
            // 
            this.txtmaxsizewidth.Location = new System.Drawing.Point(118, 786);
            this.txtmaxsizewidth.Margin = new System.Windows.Forms.Padding(4);
            this.txtmaxsizewidth.Name = "txtmaxsizewidth";
            this.txtmaxsizewidth.Size = new System.Drawing.Size(62, 28);
            this.txtmaxsizewidth.TabIndex = 57;
            this.txtmaxsizewidth.Text = "0";
            // 
            // Label12
            // 
            this.Label12.AutoSize = true;
            this.Label12.Location = new System.Drawing.Point(20, 747);
            this.Label12.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Label12.Name = "Label12";
            this.Label12.Size = new System.Drawing.Size(521, 18);
            this.Label12.TabIndex = 56;
            this.Label12.Text = "Maximum Object Size, Objects larger than that are ignored";
            // 
            // Label9
            // 
            this.Label9.AutoSize = true;
            this.Label9.Location = new System.Drawing.Point(30, 687);
            this.Label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Label9.Name = "Label9";
            this.Label9.Size = new System.Drawing.Size(62, 18);
            this.Label9.TabIndex = 55;
            this.Label9.Text = "Height";
            // 
            // txtminsizeheight
            // 
            this.txtminsizeheight.Location = new System.Drawing.Point(118, 682);
            this.txtminsizeheight.Margin = new System.Windows.Forms.Padding(4);
            this.txtminsizeheight.Name = "txtminsizeheight";
            this.txtminsizeheight.Size = new System.Drawing.Size(62, 28);
            this.txtminsizeheight.TabIndex = 54;
            this.txtminsizeheight.Text = "0";
            // 
            // Label8
            // 
            this.Label8.AutoSize = true;
            this.Label8.Location = new System.Drawing.Point(30, 646);
            this.Label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Label8.Name = "Label8";
            this.Label8.Size = new System.Drawing.Size(53, 18);
            this.Label8.TabIndex = 53;
            this.Label8.Text = "Width";
            // 
            // txtminsizewidth
            // 
            this.txtminsizewidth.Location = new System.Drawing.Point(118, 642);
            this.txtminsizewidth.Margin = new System.Windows.Forms.Padding(4);
            this.txtminsizewidth.Name = "txtminsizewidth";
            this.txtminsizewidth.Size = new System.Drawing.Size(62, 28);
            this.txtminsizewidth.TabIndex = 52;
            this.txtminsizewidth.Text = "0";
            // 
            // Label7
            // 
            this.Label7.AutoSize = true;
            this.Label7.Location = new System.Drawing.Point(15, 621);
            this.Label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Label7.Name = "Label7";
            this.Label7.Size = new System.Drawing.Size(530, 18);
            this.Label7.TabIndex = 51;
            this.Label7.Text = "Minimum Object Size, Objects smaller than that are ignored";
            // 
            // cbomingeighors
            // 
            this.cbomingeighors.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbomingeighors.FormattingEnabled = true;
            this.cbomingeighors.Location = new System.Drawing.Point(195, 561);
            this.cbomingeighors.Margin = new System.Windows.Forms.Padding(4);
            this.cbomingeighors.Name = "cbomingeighors";
            this.cbomingeighors.Size = new System.Drawing.Size(126, 26);
            this.cbomingeighors.TabIndex = 50;
            // 
            // Label6
            // 
            this.Label6.AutoSize = true;
            this.Label6.Location = new System.Drawing.Point(14, 561);
            this.Label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Label6.Name = "Label6";
            this.Label6.Size = new System.Drawing.Size(161, 18);
            this.Label6.TabIndex = 49;
            this.Label6.Text = "Minimum Neighbors";
            // 
            // txtscalefactor
            // 
            this.txtscalefactor.Location = new System.Drawing.Point(195, 506);
            this.txtscalefactor.Margin = new System.Windows.Forms.Padding(4);
            this.txtscalefactor.Name = "txtscalefactor";
            this.txtscalefactor.Size = new System.Drawing.Size(126, 28);
            this.txtscalefactor.TabIndex = 48;
            this.txtscalefactor.Text = "1.06";
            // 
            // Label5
            // 
            this.Label5.AutoSize = true;
            this.Label5.Location = new System.Drawing.Point(9, 506);
            this.Label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Label5.Name = "Label5";
            this.Label5.Size = new System.Drawing.Size(188, 18);
            this.Label5.TabIndex = 47;
            this.Label5.Text = "Scale Factor (> 1.0)";
            // 
            // txtprofilecascade
            // 
            this.txtprofilecascade.Location = new System.Drawing.Point(195, 465);
            this.txtprofilecascade.Margin = new System.Windows.Forms.Padding(4);
            this.txtprofilecascade.Name = "txtprofilecascade";
            this.txtprofilecascade.Size = new System.Drawing.Size(460, 28);
            this.txtprofilecascade.TabIndex = 46;
            this.txtprofilecascade.Text = "haarcascade_profileface.xml";
            // 
            // Label4
            // 
            this.Label4.AutoSize = true;
            this.Label4.Location = new System.Drawing.Point(9, 465);
            this.Label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Label4.Name = "Label4";
            this.Label4.Size = new System.Drawing.Size(188, 18);
            this.Label4.TabIndex = 45;
            this.Label4.Text = "Profile Cascade File";
            // 
            // chkequalize
            // 
            this.chkequalize.AutoSize = true;
            this.chkequalize.Checked = true;
            this.chkequalize.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkequalize.Location = new System.Drawing.Point(12, 424);
            this.chkequalize.Margin = new System.Windows.Forms.Padding(4);
            this.chkequalize.Name = "chkequalize";
            this.chkequalize.Size = new System.Drawing.Size(376, 22);
            this.chkequalize.TabIndex = 44;
            this.chkequalize.Text = "Equalize Histogram to enhance contrast";
            this.chkequalize.UseVisualStyleBackColor = true;
            // 
            // txtfrontalcascade
            // 
            this.txtfrontalcascade.Location = new System.Drawing.Point(195, 248);
            this.txtfrontalcascade.Margin = new System.Windows.Forms.Padding(4);
            this.txtfrontalcascade.Name = "txtfrontalcascade";
            this.txtfrontalcascade.Size = new System.Drawing.Size(460, 28);
            this.txtfrontalcascade.TabIndex = 42;
            this.txtfrontalcascade.Text = "haarcascade_frontalface_alt.xml";
            // 
            // Label3
            // 
            this.Label3.AutoSize = true;
            this.Label3.Location = new System.Drawing.Point(9, 248);
            this.Label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Label3.Name = "Label3";
            this.Label3.Size = new System.Drawing.Size(188, 18);
            this.Label3.TabIndex = 41;
            this.Label3.Text = "Frontal Cascade File";
            // 
            // lbltotalface
            // 
            this.lbltotalface.AutoSize = true;
            this.lbltotalface.Location = new System.Drawing.Point(129, 198);
            this.lbltotalface.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbltotalface.Name = "lbltotalface";
            this.lbltotalface.Size = new System.Drawing.Size(17, 18);
            this.lbltotalface.TabIndex = 40;
            this.lbltotalface.Text = "0";
            // 
            // Label2
            // 
            this.Label2.AutoSize = true;
            this.Label2.Location = new System.Drawing.Point(9, 198);
            this.Label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Label2.Name = "Label2";
            this.Label2.Size = new System.Drawing.Size(107, 18);
            this.Label2.TabIndex = 39;
            this.Label2.Text = "Total Face:";
            // 
            // BtnSourceImage
            // 
            this.BtnSourceImage.Enabled = false;
            this.BtnSourceImage.Location = new System.Drawing.Point(687, 126);
            this.BtnSourceImage.Margin = new System.Windows.Forms.Padding(4);
            this.BtnSourceImage.Name = "BtnSourceImage";
            this.BtnSourceImage.Size = new System.Drawing.Size(153, 28);
            this.BtnSourceImage.TabIndex = 38;
            this.BtnSourceImage.Text = "Select";
            this.BtnSourceImage.UseVisualStyleBackColor = true;
            this.BtnSourceImage.Click += new System.EventHandler(this.BtnSourceImage_Click);
            // 
            // txtsourceimage
            // 
            this.txtsourceimage.Location = new System.Drawing.Point(118, 126);
            this.txtsourceimage.Margin = new System.Windows.Forms.Padding(4);
            this.txtsourceimage.Name = "txtsourceimage";
            this.txtsourceimage.Size = new System.Drawing.Size(536, 28);
            this.txtsourceimage.TabIndex = 37;
            // 
            // Label1
            // 
            this.Label1.AutoSize = true;
            this.Label1.Location = new System.Drawing.Point(9, 126);
            this.Label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Label1.Name = "Label1";
            this.Label1.Size = new System.Drawing.Size(53, 18);
            this.Label1.TabIndex = 36;
            this.Label1.Text = "Image";
            // 
            // axFaceDetectionControl1
            // 
            this.axFaceDetectionControl1.Enabled = true;
            this.axFaceDetectionControl1.Location = new System.Drawing.Point(430, 565);
            this.axFaceDetectionControl1.Margin = new System.Windows.Forms.Padding(4);
            this.axFaceDetectionControl1.Name = "axFaceDetectionControl1";
            this.axFaceDetectionControl1.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("axFaceDetectionControl1.OcxState")));
            this.axFaceDetectionControl1.Size = new System.Drawing.Size(104, 46);
            this.axFaceDetectionControl1.TabIndex = 70;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(902, 84);
            this.label14.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(904, 19);
            this.label14.TabIndex = 71;
            this.label14.Text = "If you want to detect the faces more Accuracy, you may increase Scale Factor and " +
    "set the Minimum/Maximum Object Size ";
            // 
            // chkfrontalface
            // 
            this.chkfrontalface.AutoSize = true;
            this.chkfrontalface.Checked = true;
            this.chkfrontalface.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkfrontalface.Location = new System.Drawing.Point(11, 303);
            this.chkfrontalface.Name = "chkfrontalface";
            this.chkfrontalface.Size = new System.Drawing.Size(205, 22);
            this.chkfrontalface.TabIndex = 72;
            this.chkfrontalface.Text = "Detect frontal face";
            this.chkfrontalface.UseVisualStyleBackColor = true;
            // 
            // chkprofileface
            // 
            this.chkprofileface.AutoSize = true;
            this.chkprofileface.Checked = true;
            this.chkprofileface.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkprofileface.Location = new System.Drawing.Point(232, 303);
            this.chkprofileface.Name = "chkprofileface";
            this.chkprofileface.Size = new System.Drawing.Size(205, 22);
            this.chkprofileface.TabIndex = 73;
            this.chkprofileface.Text = "Detect Profile Face";
            this.chkprofileface.UseVisualStyleBackColor = true;
            // 
            // chktiltedfrontalface
            // 
            this.chktiltedfrontalface.AutoSize = true;
            this.chktiltedfrontalface.Checked = true;
            this.chktiltedfrontalface.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chktiltedfrontalface.Location = new System.Drawing.Point(12, 344);
            this.chktiltedfrontalface.Name = "chktiltedfrontalface";
            this.chktiltedfrontalface.Size = new System.Drawing.Size(538, 22);
            this.chktiltedfrontalface.TabIndex = 74;
            this.chktiltedfrontalface.Text = "Detect frontal face tilted clock-wise,counter-clock-wise";
            this.chktiltedfrontalface.UseVisualStyleBackColor = true;
            // 
            // chktiltedprofileface
            // 
            this.chktiltedprofileface.AutoSize = true;
            this.chktiltedprofileface.Checked = true;
            this.chktiltedprofileface.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chktiltedprofileface.Location = new System.Drawing.Point(11, 385);
            this.chktiltedprofileface.Name = "chktiltedprofileface";
            this.chktiltedprofileface.Size = new System.Drawing.Size(439, 22);
            this.chktiltedprofileface.TabIndex = 75;
            this.chktiltedprofileface.Text = "Detect left side  and right side profile face";
            this.chktiltedprofileface.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1796, 862);
            this.Controls.Add(this.chktiltedprofileface);
            this.Controls.Add(this.chktiltedfrontalface);
            this.Controls.Add(this.chkprofileface);
            this.Controls.Add(this.chkfrontalface);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.axFaceDetectionControl1);
            this.Controls.Add(this.btnblacklist);
            this.Controls.Add(this.GroupBox1);
            this.Controls.Add(this.ListBox1);
            this.Controls.Add(this.Label13);
            this.Controls.Add(this.chkoutputdetectedimage);
            this.Controls.Add(this.BtnOutputImage);
            this.Controls.Add(this.txtoutputimage);
            this.Controls.Add(this.PictureBox1);
            this.Controls.Add(this.Button2);
            this.Controls.Add(this.Label10);
            this.Controls.Add(this.txtmaxsizeheight);
            this.Controls.Add(this.Label11);
            this.Controls.Add(this.txtmaxsizewidth);
            this.Controls.Add(this.Label12);
            this.Controls.Add(this.Label9);
            this.Controls.Add(this.txtminsizeheight);
            this.Controls.Add(this.Label8);
            this.Controls.Add(this.txtminsizewidth);
            this.Controls.Add(this.Label7);
            this.Controls.Add(this.cbomingeighors);
            this.Controls.Add(this.Label6);
            this.Controls.Add(this.txtscalefactor);
            this.Controls.Add(this.Label5);
            this.Controls.Add(this.txtprofilecascade);
            this.Controls.Add(this.Label4);
            this.Controls.Add(this.chkequalize);
            this.Controls.Add(this.txtfrontalcascade);
            this.Controls.Add(this.Label3);
            this.Controls.Add(this.lbltotalface);
            this.Controls.Add(this.Label2);
            this.Controls.Add(this.BtnSourceImage);
            this.Controls.Add(this.txtsourceimage);
            this.Controls.Add(this.Label1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.GroupBox1.ResumeLayout(false);
            this.GroupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.axFaceDetectionControl1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        internal System.Windows.Forms.OpenFileDialog OpenFileDialog1;
        internal System.Windows.Forms.Button btnblacklist;
        internal System.Windows.Forms.RadioButton RadioButton1;
        internal System.Windows.Forms.GroupBox GroupBox1;
        internal System.Windows.Forms.RadioButton RadioButton3;
        internal System.Windows.Forms.RadioButton RadioButton2;
        internal System.Windows.Forms.ListBox ListBox1;
        internal System.Windows.Forms.SaveFileDialog SaveFileDialog1;
        internal System.Windows.Forms.Label Label13;
        internal System.Windows.Forms.CheckBox chkoutputdetectedimage;
        internal System.Windows.Forms.Button BtnOutputImage;
        internal System.Windows.Forms.TextBox txtoutputimage;
        internal System.Windows.Forms.PictureBox PictureBox1;
        internal System.Windows.Forms.Button Button2;
        internal System.Windows.Forms.Label Label10;
        internal System.Windows.Forms.TextBox txtmaxsizeheight;
        internal System.Windows.Forms.Label Label11;
        internal System.Windows.Forms.TextBox txtmaxsizewidth;
        internal System.Windows.Forms.Label Label12;
        internal System.Windows.Forms.Label Label9;
        internal System.Windows.Forms.TextBox txtminsizeheight;
        internal System.Windows.Forms.Label Label8;
        internal System.Windows.Forms.TextBox txtminsizewidth;
        internal System.Windows.Forms.Label Label7;
        internal System.Windows.Forms.ComboBox cbomingeighors;
        internal System.Windows.Forms.Label Label6;
        internal System.Windows.Forms.TextBox txtscalefactor;
        internal System.Windows.Forms.Label Label5;
        internal System.Windows.Forms.TextBox txtprofilecascade;
        internal System.Windows.Forms.Label Label4;
        internal System.Windows.Forms.CheckBox chkequalize;
        internal System.Windows.Forms.TextBox txtfrontalcascade;
        internal System.Windows.Forms.Label Label3;
        internal System.Windows.Forms.Label lbltotalface;
        internal System.Windows.Forms.Label Label2;
        internal System.Windows.Forms.Button BtnSourceImage;
        internal System.Windows.Forms.TextBox txtsourceimage;
        internal System.Windows.Forms.Label Label1;
        private AxFaceDetectionControlLib.AxFaceDetectionControl axFaceDetectionControl1;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.CheckBox chkfrontalface;
        private System.Windows.Forms.CheckBox chkprofileface;
        private System.Windows.Forms.CheckBox chktiltedfrontalface;
        private System.Windows.Forms.CheckBox chktiltedprofileface;
    }
}

