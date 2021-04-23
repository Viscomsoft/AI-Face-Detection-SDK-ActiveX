using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{

 
    public partial class Form1 : Form
    {
        string strApp;
        public Form1()
        {
            InitializeComponent();
        }

        private void BtnSourceImage_Click(object sender, EventArgs e)
        {

            OpenFileDialog1.Filter = "All Files (*.*)|*.*|JPEG (*.jpg)|*.jpg|PNG (*.png)|*.png|Bitmap (*.bmp)|*.bmp|TIF (*.tif)|*.tif";

            if(OpenFileDialog1.ShowDialog() == DialogResult.OK)
            {
                txtsourceimage.Text = OpenFileDialog1.FileName;

            }

        }

        private void RadioButton1_Click(object sender, EventArgs e)
        {
              txtmaxsizewidth.Text = "0";
              txtmaxsizeheight.Text = "0";
              BtnSourceImage.Enabled = true;
        }

        private void RadioButton2_Click(object sender, EventArgs e)
        {
            txtmaxsizewidth.Text = "50";
            txtmaxsizeheight.Text = "50";
            BtnSourceImage.Enabled = false;
        }

        private void RadioButton3_Click(object sender, EventArgs e)
        {
            txtmaxsizewidth.Text = "0";
            txtmaxsizeheight.Text = "0";
            BtnSourceImage.Enabled = true;
        }

        private void BtnOutputImage_Click(object sender, EventArgs e)
        {
             SaveFileDialog1.Filter = "PNG (*.png)|*.png";

            if(SaveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                txtoutputimage.Text = SaveFileDialog1.FileName;
            }
        }

        private void chkoutputdetectedimage_Click(object sender, EventArgs e)
        {
            if(chkoutputdetectedimage.Checked)
            {
                txtoutputimage.Enabled = true;
                BtnOutputImage.Enabled = true;
            }
            else
            {
                txtoutputimage.Enabled = false;
                BtnOutputImage.Enabled = false;
            }
      
        }

        private void Form1_Load(object sender, EventArgs e)
        {
              int iFindIndex;
            strApp = Application.ExecutablePath;

           
            iFindIndex = strApp.IndexOf("Examples");

            if (iFindIndex != -1)
            {

                strApp = strApp.Substring(0, iFindIndex);

                strApp = strApp + "FacePhoto";

             

                cbomingeighors.Items.Add("1");
                cbomingeighors.Items.Add("2");
                cbomingeighors.Items.Add("3");
                cbomingeighors.Items.Add("4");
                cbomingeighors.Items.Add("5");
                cbomingeighors.SelectedIndex = 3;
            }

        }

        private void ControlCountFace()
        {
            if(RadioButton1.Checked)
              lbltotalface.Text = axFaceDetectionControl1.CountFaces(strApp + "\\demo1.png").ToString();

           if(RadioButton2.Checked)
             lbltotalface.Text =axFaceDetectionControl1.CountFaces(strApp + "\\demo2.png").ToString();

           if (RadioButton3.Checked)
               lbltotalface.Text = axFaceDetectionControl1.CountFaces(txtsourceimage.Text).ToString();

        }
        private void BlackList()
        {
          int ix;
          int iy;
          int iwidth;
           int iheight; 

             axFaceDetectionControl1.ClearBlackList();

          
            for (int i = 0; i < axFaceDetectionControl1.DetectedRectGetCount(); i++)
            {
                ix = axFaceDetectionControl1.DetectedRectGetX((short)i);
                iy = axFaceDetectionControl1.DetectedRectGetY((short)i);
                iwidth = axFaceDetectionControl1.DetectedRectGetWidth((short)i);
                iheight = axFaceDetectionControl1.DetectedRectGetHeight((short)i);
               
                if(i==0 || i==1)
                     axFaceDetectionControl1.Add2BlackList((short)ix, (short)iy, (short)iwidth, (short)iheight);
            }
           
          


        }

        private void Button2_Click(object sender, EventArgs e)
        {
            if(RadioButton3.Checked)
            {
                if(txtsourceimage.Text.Length==0)
                {
              
                    MessageBox.Show("Please input source image first");
                    return;

                }
            }

            if(chkoutputdetectedimage.Checked)
            {
                if(txtoutputimage.Text == "")
                {
                    MessageBox.Show("Please select the path of output detected image first");
                    return;
                }
            }


        axFaceDetectionControl1.SetFrontalFaceCascade(txtfrontalcascade.Text);
        axFaceDetectionControl1.SetProfileFaceCascade(txtprofilecascade.Text);


        axFaceDetectionControl1.EnableFrontalFace = chkfrontalface.Checked;
        axFaceDetectionControl1.EnableProfileFace = chkprofileface.Checked;
        axFaceDetectionControl1.EnableTiltedFrontalFace = chktiltedfrontalface.Checked;
        axFaceDetectionControl1.EnableTiltedProfileFace = chktiltedprofileface.Checked;
        axFaceDetectionControl1.EnableEqualizeHistogram = chkequalize.Checked;
     
          
       if( txtoutputimage.Text != "")
            axFaceDetectionControl1.SetSaveResults(txtoutputimage.Text);


        axFaceDetectionControl1.SetMinNeighbors(Int32.Parse(cbomingeighors.Text));
        axFaceDetectionControl1.SetScaleFactor(Double.Parse( txtscalefactor.Text));
        axFaceDetectionControl1.SetMinSize(Int32.Parse(txtminsizewidth.Text), Int32.Parse(txtminsizeheight.Text));

        axFaceDetectionControl1.SetMaxSize(Int32.Parse(txtmaxsizewidth.Text), Int32.Parse(txtmaxsizeheight.Text));


        axFaceDetectionControl1.ClearBlackList();
        ControlCountFace();
       


         System.IO.FileStream fs;
       //Specify a valid picture file path on your computer.

        if(txtoutputimage.Text != "")
        {
            if(System.IO.File.Exists( txtoutputimage.Text))
            {
                fs = new System.IO.FileStream(txtoutputimage.Text,
                System.IO.FileMode.Open, System.IO.FileAccess.Read);
                PictureBox1.Image = System.Drawing.Image.FromStream(fs);
                fs.Close();
            }
        }



        ListBox1.Items.Clear();
            int ix, iy,iwidth,iheight;


         
        for( int i = 0 ; i< axFaceDetectionControl1.DetectedRectGetCount() ; i++)
        {
            ix =axFaceDetectionControl1.DetectedRectGetX((short)i);
            iy = axFaceDetectionControl1.DetectedRectGetY((short)i);
            iwidth =axFaceDetectionControl1.DetectedRectGetWidth((short)i);
            iheight = axFaceDetectionControl1.DetectedRectGetHeight((short)i);

            ListBox1.Items.Add(ix.ToString() + " " + iy.ToString() + " " + iwidth.ToString() + " " + iheight.ToString());
        }

              btnblacklist.Enabled =true;
        }

        private void btnblacklist_Click(object sender, EventArgs e)
        {

            if (RadioButton3.Checked)
            {
                if (txtsourceimage.Text.Length == 0)
                {

                    MessageBox.Show("Please input source image first");
                    return;

                }
            }

            if (chkoutputdetectedimage.Checked)
            {
                if (txtoutputimage.Text == "")
                {
                    MessageBox.Show("Please select the path of output detected image first");
                    return;
                }
            }


            axFaceDetectionControl1.SetFrontalFaceCascade(txtfrontalcascade.Text);
            axFaceDetectionControl1.SetProfileFaceCascade(txtprofilecascade.Text);



            axFaceDetectionControl1.SetFrontalFaceCascade(txtfrontalcascade.Text);
            axFaceDetectionControl1.SetProfileFaceCascade(txtprofilecascade.Text);


            axFaceDetectionControl1.EnableFrontalFace = chkfrontalface.Checked;
            axFaceDetectionControl1.EnableProfileFace = chkprofileface.Checked;
            axFaceDetectionControl1.EnableTiltedFrontalFace = chktiltedfrontalface.Checked;
            axFaceDetectionControl1.EnableTiltedProfileFace = chktiltedprofileface.Checked;
            axFaceDetectionControl1.EnableEqualizeHistogram = chkequalize.Checked;
     
         

           
            if (txtoutputimage.Text != "")
                axFaceDetectionControl1.SetSaveResults(txtoutputimage.Text);


            axFaceDetectionControl1.SetMinNeighbors(Int32.Parse(cbomingeighors.Text));
            axFaceDetectionControl1.SetScaleFactor(Double.Parse(txtscalefactor.Text));
            axFaceDetectionControl1.SetMinSize(Int32.Parse(txtminsizewidth.Text), Int32.Parse(txtminsizeheight.Text));

            axFaceDetectionControl1.SetMaxSize(Int32.Parse(txtmaxsizewidth.Text), Int32.Parse(txtmaxsizeheight.Text));


            BlackList();
            ControlCountFace();



            System.IO.FileStream fs;
            //Specify a valid picture file path on your computer.

            if (txtoutputimage.Text != "")
            {
                if (System.IO.File.Exists(txtoutputimage.Text))
                {
                    fs = new System.IO.FileStream(txtoutputimage.Text,
                    System.IO.FileMode.Open, System.IO.FileAccess.Read);
                    PictureBox1.Image = System.Drawing.Image.FromStream(fs);
                    fs.Close();
                }
            }



            ListBox1.Items.Clear();
            int ix, iy, iwidth, iheight;



            for (int i = 0; i < axFaceDetectionControl1.DetectedRectGetCount(); i++)
            {
                ix = axFaceDetectionControl1.DetectedRectGetX((short)i);
                iy = axFaceDetectionControl1.DetectedRectGetY((short)i);
                iwidth = axFaceDetectionControl1.DetectedRectGetWidth((short)i);
                iheight = axFaceDetectionControl1.DetectedRectGetHeight((short)i);

                ListBox1.Items.Add(ix.ToString() + " " + iy.ToString() + " " + iwidth.ToString() + " " + iheight.ToString());
            }

            btnblacklist.Enabled = false;


        }
    }
}
