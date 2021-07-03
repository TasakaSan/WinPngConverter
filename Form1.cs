using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinPngConverter
{
    public partial class Form1 : Form
    {
        public bool selectFolder;
        public Form1()
        {
            this.StartPosition = FormStartPosition.Manual;
            this.Location = new Point(((Screen.PrimaryScreen.Bounds.Width / 2) - this.Width) - 150, (((Screen.PrimaryScreen.Bounds.Height / 2) - this.Height) + 550));

            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            for (int i = 10; i < 100; i = i + 10)
            {
                cBox_Compress.Items.Add(i);
            }

            List<string> format = new List<string> { ".png", ".jpg", ".bmp", ".gif" };
            foreach (string _item in format)
            {
                cBox_Format.Items.Add(_item);
                cBox_Format.Sorted = true;
            }
        }

        private void toggleBtn_CheckedChanged(object sender, EventArgs e)
        {
            if (toggleBtn.Checked)
            {
                selectFolder = true;
            }
            else selectFolder = false;
        }

        private void SelectFile(TextBox tb_SearchFile)
        {
            if (selectFolder)
            {
                FolderBrowserDialog _folder = new FolderBrowserDialog();
                _folder.ShowNewFolderButton = true;
                DialogResult result = _folder.ShowDialog();
                if (result == DialogResult.OK)
                {
                    tb_SearchFile.Text = _folder.SelectedPath;
                    Environment.SpecialFolder root = _folder.RootFolder;
                }
            }
            else
            {
                OpenFileDialog _file = new OpenFileDialog();
                DialogResult result = _file.ShowDialog();
                if (result == DialogResult.OK)
                {
                    tb_SearchFile.Text = _file.FileName;
                    _file.InitialDirectory = "c:\\";
                }
            }
        }

        private void DestFile(TextBox tb_DestinationFile)
        {
            FolderBrowserDialog _folder = new FolderBrowserDialog();
            _folder.ShowNewFolderButton = true;
            DialogResult result = _folder.ShowDialog();
            if (result == DialogResult.OK)
            {
                tb_DestinationFile.Text = _folder.SelectedPath;
                Environment.SpecialFolder root = _folder.RootFolder;
            }
        }

        private void btn_SearchFile_Click(object sender, EventArgs e)
        {
            SelectFile(tb_SearchFile);
        }

        private void btn_DestinationFile_Click(object sender, EventArgs e)
        {
            DestFile(tb_DestinationFile);
        }

        public static void CompressImage(string SourcePath, string DestPath, int quality, int format)
        {
            using (Bitmap bmp1 = new Bitmap(SourcePath))
            {
                switch (format)
                {
                    case 0:
                        ImageCodecInfo bmpEncoder = GetEncoder(ImageFormat.Bmp);

                        var fileNameBMP = Path.GetFileNameWithoutExtension(SourcePath);
                        DestPath = DestPath + "\\" + fileNameBMP + ".bmp";

                        System.Drawing.Imaging.Encoder bmpQualityEncoder = System.Drawing.Imaging.Encoder.Quality;
                        EncoderParameters myBmpEncoderParameters = new EncoderParameters(1);
                        EncoderParameter myBMPEncoderParameter = new EncoderParameter(bmpQualityEncoder, quality);

                        myBmpEncoderParameters.Param[0] = myBMPEncoderParameter;
                        bmp1.Save(DestPath, bmpEncoder, myBmpEncoderParameters);
                        break;
                    case 1:
                        ImageCodecInfo gifEncoder = GetEncoder(ImageFormat.Gif);

                        var fileNameGIF = Path.GetFileNameWithoutExtension(SourcePath);
                        DestPath = DestPath + "\\" + fileNameGIF + ".gif";

                        System.Drawing.Imaging.Encoder gifQualityEncoder = System.Drawing.Imaging.Encoder.Quality;
                        EncoderParameters myGifEncoderParameters = new EncoderParameters(1);
                        EncoderParameter myGifEncoderParameter = new EncoderParameter(gifQualityEncoder, quality);

                        myGifEncoderParameters.Param[0] = myGifEncoderParameter;
                        bmp1.Save(DestPath, gifEncoder, myGifEncoderParameters);
                        break;
                    case 2:
                        ImageCodecInfo jpgEncoder = GetEncoder(ImageFormat.Jpeg);

                        var fileNameJPG = Path.GetFileNameWithoutExtension(SourcePath);
                        DestPath = DestPath + "\\" + fileNameJPG + ".jpg";

                        System.Drawing.Imaging.Encoder jpgQualityEncoder = System.Drawing.Imaging.Encoder.Quality;
                        EncoderParameters myJpgEncoderParameters = new EncoderParameters(1);
                        EncoderParameter myJpgEncoderParameter = new EncoderParameter(jpgQualityEncoder, quality);

                        myJpgEncoderParameters.Param[0] = myJpgEncoderParameter;
                        bmp1.Save(DestPath, jpgEncoder, myJpgEncoderParameters);
                        break;
                    case 3:
                        ImageCodecInfo pngEncoder = GetEncoder(ImageFormat.Png);

                        var fileNamePNG = Path.GetFileNameWithoutExtension(SourcePath);
                        DestPath = DestPath + "\\" + fileNamePNG + ".png";

                        System.Drawing.Imaging.Encoder pngQualityEncoder = System.Drawing.Imaging.Encoder.Quality;
                        EncoderParameters myPngEncoderParameters = new EncoderParameters(1);
                        EncoderParameter myPngEncoderParameter = new EncoderParameter(pngQualityEncoder, quality);

                        myPngEncoderParameters.Param[0] = myPngEncoderParameter;
                        bmp1.Save(DestPath, pngEncoder, myPngEncoderParameters);
                        break;
                }
            }
        }

        private static ImageCodecInfo GetEncoder(ImageFormat format)
        {
            ImageCodecInfo[] codecs = ImageCodecInfo.GetImageDecoders();
            foreach (ImageCodecInfo codec in codecs)
            {
                if(codec.FormatID == format.Guid)
                {
                    return codec;
                }
            }return null;
        }

        private void btn_ActionCompress_Click(object sender, EventArgs e)
        {
            //Add check if format is select ?

            if (selectFolder)
            {
                string[] files = Directory.GetFiles(tb_SearchFile.Text);
                foreach (var file in files)
                {
                    string ext = Path.GetExtension(file).ToUpper();
                    CompressImage(file, tb_DestinationFile.Text, (int)cBox_Compress.SelectedIndex, (int)cBox_Format.SelectedIndex);
                }

                MessageBox.Show("Compressed Images has been stored to \n" + tb_DestinationFile.Text, "Do you want to open the folder ", MessageBoxButtons.YesNo); 
                if(DialogResult == DialogResult.OK)
                {
                    System.Diagnostics.Process.Start(@"\" + tb_DestinationFile.ToString());
                };

                tb_DestinationFile.Text = "";
                tb_SearchFile.Text = "";
            }
            else
            {
                string filePath = tb_SearchFile.Text;
                string ext = Path.GetExtension(filePath).ToUpper();
                CompressImage(filePath, tb_DestinationFile.Text, (int)cBox_Compress.SelectedIndex, (int)cBox_Format.SelectedIndex);

                MessageBox.Show("Compressed Images has been stored to \n" + tb_DestinationFile.Text, "Do you want to open the folder ", MessageBoxButtons.YesNo);
                if (DialogResult == DialogResult.OK)
                {
                    System.Diagnostics.Process.Start(@"\" + tb_DestinationFile.ToString());
                };

                tb_DestinationFile.Text = "";
                tb_SearchFile.Text = "";
            }
        }
    }
}
