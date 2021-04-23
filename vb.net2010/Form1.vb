Public Class Form1

    Dim strApp As String
    Private Sub Button1_Click(sender As System.Object, e As System.EventArgs) Handles Button1.Click


        OpenFileDialog1.Filter = "All Files (*.*)|*.*|JPEG (*.jpg)|*.jpg|PNG (*.png)|*.png|Bitmap (*.bmp)|*.bmp|TIF (*.tif)|*.tif"

        If OpenFileDialog1.ShowDialog() = DialogResult.OK Then

            txtsourceimage.Text = OpenFileDialog1.FileName

        End If

    End Sub

    Private Sub ControlCountFace()
        If RadioButton1.Checked Then

            lbltotalface.Text = AxFaceDetectionControl1.CountFaces(strApp + "\demo1.png")

        End If

        If RadioButton2.Checked Then

            lbltotalface.Text = AxFaceDetectionControl1.CountFaces(strApp + "\demo2.png")

        End If

        If RadioButton3.Checked Then

            lbltotalface.Text = AxFaceDetectionControl1.CountFaces(txtsourceimage.Text)

        End If

    End Sub
    Private Sub BlackList()
        Dim ix As Integer
        Dim iy As Integer
        Dim iwidth As Integer
        Dim iheight As Integer

        AxFaceDetectionControl1.ClearBlackList()

        For i = 0 To AxFaceDetectionControl1.DetectedRectGetCount - 1

            ix = AxFaceDetectionControl1.DetectedRectGetX(i)
            iy = AxFaceDetectionControl1.DetectedRectGetY(i)
            iwidth = AxFaceDetectionControl1.DetectedRectGetWidth(i)
            iheight = AxFaceDetectionControl1.DetectedRectGetHeight(i)

            If i = 0 Or i = 1 Then

                AxFaceDetectionControl1.Add2BlackList(ix, iy, iwidth, iheight)

            End If
        Next

    End Sub
    Private Sub Button2_Click(sender As System.Object, e As System.EventArgs) Handles Button2.Click
        If RadioButton3.Checked Then
            If txtsourceimage.Text = "" Then
                MessageBox.Show("Please input source image first")
                Exit Sub

            End If
        End If

        If chkoutputdetectedimage.Checked Then
            If txtoutputimage.Text = "" Then

                MessageBox.Show("Please select the path of output detected image first")
                Exit Sub

            End If
        End If


        AxFaceDetectionControl1.SetFrontalFaceCascade(txtfrontalcascade.Text)
        AxFaceDetectionControl1.SetProfileFaceCascade(txtprofilecascade.Text)

        AxFaceDetectionControl1.EnableEqualizeHistogram = chkequalize.Checked

        AxFaceDetectionControl1.EnableFrontalFace = chkfrontalface.Checked
        AxFaceDetectionControl1.EnableProfileFace = chkprofileface.Checked
        AxFaceDetectionControl1.EnableTiltedFrontalFace = chktiltedfrontalface.Checked
        AxFaceDetectionControl1.EnableTiltedProfileFace = chktiltedprofileface.Checked
       

        If txtoutputimage.Text <> "" Then AxFaceDetectionControl1.SetSaveResults(txtoutputimage.Text)


        AxFaceDetectionControl1.SetMinNeighbors(cbomingeighors.Text)
        AxFaceDetectionControl1.SetScaleFactor(txtscalefactor.Text)
        AxFaceDetectionControl1.SetMinSize(txtminsizewidth.Text, txtminsizeheight.Text)

        AxFaceDetectionControl1.SetMaxSize(txtmaxsizewidth.Text, txtmaxsizeheight.Text)


        AxFaceDetectionControl1.ClearBlackList()
        ControlCountFace()
       


        Dim fs As System.IO.FileStream
        ' Specify a valid picture file path on your computer.

        If txtoutputimage.Text <> "" Then
            If System.IO.File.Exists(txtoutputimage.Text) Then
                fs = New System.IO.FileStream(txtoutputimage.Text,
                IO.FileMode.Open, IO.FileAccess.Read)
                PictureBox1.Image = System.Drawing.Image.FromStream(fs)
                fs.Close()
            End If
        End If



        ListBox1.Items.Clear()
        Dim ix, iy, iwidth, iheight As Integer

        For i = 0 To AxFaceDetectionControl1.DetectedRectGetCount - 1

            ix = AxFaceDetectionControl1.DetectedRectGetX(i)
            iy = AxFaceDetectionControl1.DetectedRectGetY(i)
            iwidth = AxFaceDetectionControl1.DetectedRectGetWidth(i)
            iheight = AxFaceDetectionControl1.DetectedRectGetHeight(i)

            ListBox1.Items.Add(Str(ix) + " " + Str(iy) + " " + Str(iwidth) + " " + Str(iheight))
        Next

        btnblacklist.Enabled = True

    End Sub

    Private Sub Form1_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load

        Dim iFindIndex As Integer
        strApp = Application.ExecutablePath
        iFindIndex = strApp.IndexOf("Examples")

        If iFindIndex <> -1 Then

        strApp = strApp.Substring(0, iFindIndex)

        strApp = strApp + "FacePhoto"


        cbomingeighors.Items.Add("1")
        cbomingeighors.Items.Add("2")
        cbomingeighors.Items.Add("3")
        cbomingeighors.Items.Add("4")
        cbomingeighors.Items.Add("5")
        cbomingeighors.SelectedIndex = 3



        End If




    End Sub

    Private Sub Button3_Click(sender As System.Object, e As System.EventArgs) Handles Button3.Click
        SaveFileDialog1.Filter = "PNG (*.png)|*.png"

        If SaveFileDialog1.ShowDialog() = DialogResult.OK Then

            txtoutputimage.Text = SaveFileDialog1.FileName
        End If
    End Sub

    Private Sub chkoutputdetectedimage_Click(sender As System.Object, e As System.EventArgs) Handles chkoutputdetectedimage.Click
        If chkoutputdetectedimage.Checked Then
            txtoutputimage.Enabled = True
            Button3.Enabled = True
        Else
            txtoutputimage.Enabled = False
            Button3.Enabled = False
        End If
    End Sub

    Private Sub RadioButton3_Click(sender As System.Object, e As System.EventArgs) Handles RadioButton3.Click
        txtmaxsizewidth.Text = 0
        txtmaxsizeheight.Text = 0
        Button1.Enabled = True
    End Sub

    Private Sub RadioButton2_Click(sender As System.Object, e As System.EventArgs) Handles RadioButton2.Click
        txtmaxsizewidth.Text = 50 'Objects larger than 50x50 that are ignored
        txtmaxsizeheight.Text = 50
        Button1.Enabled = False

    End Sub

    Private Sub RadioButton1_Click(sender As System.Object, e As System.EventArgs) Handles RadioButton1.Click
       txtmaxsizewidth.Text = 0
        txtmaxsizeheight.Text = 0
        Button1.Enabled = False

    End Sub

    Private Sub Button4_Click(sender As System.Object, e As System.EventArgs) Handles btnblacklist.Click
        If RadioButton3.Checked Then
            If txtsourceimage.Text = "" Then
                MessageBox.Show("Please input source image first")
                Exit Sub

            End If
        End If

        If chkoutputdetectedimage.Checked Then
            If txtoutputimage.Text = "" Then

                MessageBox.Show("Please select the path of output detected image first")
                Exit Sub

            End If
        End If


        AxFaceDetectionControl1.SetFrontalFaceCascade(txtfrontalcascade.Text)
        AxFaceDetectionControl1.SetProfileFaceCascade(txtprofilecascade.Text)

           AxFaceDetectionControl1.EnableEqualizeHistogram = chkequalize.Checked

        AxFaceDetectionControl1.EnableFrontalFace = chkfrontalface.Checked
        AxFaceDetectionControl1.EnableProfileFace = chkprofileface.Checked
        AxFaceDetectionControl1.EnableTiltedFrontalFace = chktiltedfrontalface.Checked
        AxFaceDetectionControl1.EnableTiltedProfileFace = chktiltedprofileface.Checked

        If txtoutputimage.Text <> "" Then AxFaceDetectionControl1.SetSaveResults(txtoutputimage.Text)


        AxFaceDetectionControl1.SetMinNeighbors(cbomingeighors.Text)
        AxFaceDetectionControl1.SetScaleFactor(txtscalefactor.Text)
        AxFaceDetectionControl1.SetMinSize(txtminsizewidth.Text, txtminsizeheight.Text)

        AxFaceDetectionControl1.SetMaxSize(txtmaxsizewidth.Text, txtmaxsizeheight.Text)


        BlackList()
        ControlCountFace()



        Dim fs As System.IO.FileStream
        ' Specify a valid picture file path on your computer.

        If txtoutputimage.Text <> "" Then
            If System.IO.File.Exists(txtoutputimage.Text) Then
                fs = New System.IO.FileStream(txtoutputimage.Text,
                IO.FileMode.Open, IO.FileAccess.Read)
                PictureBox1.Image = System.Drawing.Image.FromStream(fs)
                fs.Close()
            End If
        End If



        ListBox1.Items.Clear()
        Dim ix, iy, iwidth, iheight As Integer

        For i = 0 To AxFaceDetectionControl1.DetectedRectGetCount - 1

            ix = AxFaceDetectionControl1.DetectedRectGetX(i)
            iy = AxFaceDetectionControl1.DetectedRectGetY(i)
            iwidth = AxFaceDetectionControl1.DetectedRectGetWidth(i)
            iheight = AxFaceDetectionControl1.DetectedRectGetHeight(i)

            ListBox1.Items.Add(Str(ix) + " " + Str(iy) + " " + Str(iwidth) + " " + Str(iheight))
        Next

        btnblacklist.Enabled = False

    End Sub
End Class
