using BLL;
using DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.Intrinsics.X86;
using System.Xml.Linq;
using System.Drawing.Imaging;
using System.Drawing.Drawing2D;

namespace GUI
{
    public partial class addEmpForm : Form
    {
        private string filePath;
        private byte[] img;
        NhanvienBLL nvBLL = new NhanvienBLL();
        Nhanvien nv;
        TaikhoanBLL tkBLL = new TaikhoanBLL();
        Taikhoan tk;
        VitriBLL vtBLL = new VitriBLL();
        Vitri vt;

        public addEmpForm()
        {
            InitializeComponent();
        }

        private void exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        //resize image to 
        public Image ResizeImageByPercentage(Image image, int percentage)
        {
            int newWidth = (int)(image.Width * percentage / 100.0);
            int newHeight = (int)(image.Height * percentage / 100.0);

            var destRect = new Rectangle(0, 0, newWidth, newHeight);
            var destImage = new Bitmap(newWidth, newHeight);

            destImage.SetResolution(image.HorizontalResolution, image.VerticalResolution);

            using (var graphics = Graphics.FromImage(destImage))
            {
                graphics.CompositingMode = CompositingMode.SourceCopy;
                graphics.CompositingQuality = CompositingQuality.HighQuality;
                graphics.InterpolationMode = InterpolationMode.HighQualityBicubic;
                graphics.SmoothingMode = SmoothingMode.HighQuality;
                graphics.PixelOffsetMode = PixelOffsetMode.HighQuality;

                using (var wrapMode = new ImageAttributes())
                {
                    wrapMode.SetWrapMode(WrapMode.TileFlipXY);
                    graphics.DrawImage(image, destRect, 0, 0, image.Width, image.Height, GraphicsUnit.Pixel, wrapMode);
                }
            }

            MessageBox.Show(destImage.Width.ToString());
            return destImage;
        }

        private Image CloneImage(string path)
        {
            Image result;
            using (Bitmap original = new Bitmap(path))
            {
                result = (Bitmap)original.Clone();
            };
            return ResizeImageByPercentage(result, 75);
        }

        private byte[] ImageToByteArray(PictureBox pictureBox)
        {
            MemoryStream memoryStream = new MemoryStream();
            //pictureBox.Image.Save(memoryStream, pictureBox.Image.RawFormat);
            Image img = pictureBox.Image;
            //MessageBox.Show(img.RawFormat.ToString());
            img.Save(memoryStream, ImageFormat.Png);
            return memoryStream.ToArray();
        }

        private void OpenImage()
        {
            OpenFileDialog open = new OpenFileDialog();
            open.Filter = "Image Files (*.jpg, *.jpeg, *.jpe, *.jfif, *.png)|*.jpg; *.jpeg; *.jpe; *.jfif; *.png|All files (*.*)|*.*";
            open.Title = "Chọn ảnh";
            if (open.ShowDialog() == DialogResult.OK)
            {
                filePath = open.FileName;
                avatar.Image = CloneImage(filePath);
                avatar.ImageLocation = filePath;
                img = ImageToByteArray(avatar);
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            string nvName = fullname.Text;
            string nvSex = "";

            if (radbtnFemale.Checked)
            {
                nvSex += "Nữ";
            }
            if (radbtnMale.Checked)
            {
                nvSex += "Nam";
            }

            DateTime nvDob = dob.Value;
            string nvHome = hometown.Text;
            string nvPhone = phone.Text;
            string nvEmail = email.Text;
            string nvPos = comboboxPosition.SelectedValue.ToString();
            byte[] nvAva = ImageToByteArray(avatar);

            //set nhan vien
            nv = new Nhanvien(nvName, nvSex, nvDob, nvHome, nvPhone, nvEmail, nvPos, nvAva);

            string uname = username.Text;
            string pass = password.Text;
            int per = 1;

            //set taikhoan
            tk = new Taikhoan(uname, pass, per);

            if (nvBLL.addNV(nv) && tkBLL.addAccount(tk))
            {
                MessageBox.Show("Thêm thành công");
                this.Close();
            }
        }

        //Get auto id 
        private string getID()
        {
            string idnv = nvBLL.getAutoID();
            return idnv;
        }

        //load combobox pos 
        private void loadComboBox()
        {
            DataTable dt = vtBLL.getAllVitri();
            comboboxPosition.DataSource = dt;
            comboboxPosition.DisplayMember = dt.Columns["TEN"].ToString();
            comboboxPosition.ValueMember = dt.Columns["ID"].ToString();
        }

        private void addEmpForm_Load(object sender, EventArgs e)
        {
            labelID.Text = getID();
            loadComboBox();
        }

        private void avatar_Click(object sender, EventArgs e)
        {
            OpenImage();
        }
    }
}
