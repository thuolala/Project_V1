using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Drawing.Imaging;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BLL;
using DTO;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace GUI
{
    public partial class selfEditForm : Form
    {
        private string filePath;
        private byte[] img;
        NhanvienBLL nvBLL = new NhanvienBLL();
        Nhanvien nv;
        TaikhoanBLL tkBLL = new TaikhoanBLL();
        Taikhoan tk;
        VitriBLL vtBLL = new VitriBLL();
        Vitri vt;

        public selfEditForm(Nhanvien nnv, Taikhoan ttk)
        {
            this.nv = nnv;
            this.tk = ttk;
            InitializeComponent();
        }

        //resize image to 
        public Image ResizeImageByPercentage(Image image)
        {
            int newWidth = 180;
            int newHeight = 200;

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
            return destImage;
        }

        private Image CloneImage(string path)
        {
            Image result;
            using (Bitmap original = new Bitmap(path))
            {
                result = (Bitmap)original.Clone();
            };
            return result;
        }

        private byte[] ImageToByteArray(Image image)
        {
            MemoryStream memoryStream = new MemoryStream();
            //pictureBox.Image.Save(memoryStream, pictureBox.Image.RawFormat);
            //MessageBox.Show(img.RawFormat.ToString());
            image.Save(memoryStream, ImageFormat.Png);
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
                Image imgR = CloneImage(filePath);
                imgR = ResizeImageByPercentage(imgR);
                avatar.Image = imgR;
                //avatar.ImageLocation = filePath;
                img = ImageToByteArray(imgR);
            }
        }

        private void loadAll()
        {
            displayID.Text = nv.Id;
            displayPos.Text = vtBLL.getVTName(nv.Idpos);
            fullname.Text = nv.Name;
            displayPhone.Text = nv.Phone;
            displayBirth.Text = nv.Birthday.ToString().Split(" ")[0];
            hometown.Text = nv.Hometown;
            phone.Text = nv.Phone;
            email.Text = nv.Email;
            displayUsername.Text = tk.Userame;
            displayPassword.Text = tk.Password;
            password.Text = tk.Password;
            using (MemoryStream stream = new MemoryStream(nv.Avatar))
            {
                Image image = Image.FromStream(stream);
                avatar.Image = image;
            }
            if (nv.Gender.Equals("Nam"))
            {
                radioButtonMale.Checked = true;
            }
            else
            {
                radioButtonFemale.Checked = true;
            }
        }

        private void selfEditForm_Load(object sender, EventArgs e)
        {
            loadAll();
        }

        private void avatar_Click(object sender, EventArgs e)
        {
            OpenImage();
        }

        private void updateNV()
        {
            string id = nv.Id;
            string nvName = nv.Name;
            string nvSex = nv.Gender;
            DateTime nvDob = nv.Birthday;

            string nvHome = hometown.Text;
            string nvPhone = phone.Text;
            string nvEmail = email.Text;
            byte[] nvAva = ImageToByteArray(avatar.Image);

            //set nhan vien
            Nhanvien nvien = new Nhanvien(id, nvName, nvSex, nvDob, nvHome, nvPhone, nvEmail, nv.Idpos, nv.Created, nvAva);

            string uname = tk.Userame;
            string pass = password.Text;
            int per = tk.Permission;

            //set taikhoan
            Taikhoan tkhoan = new Taikhoan(id, uname, pass, per);

            if (nvBLL.updateNV(nvien) && tkBLL.updateAccount(tkhoan))
            {
                MessageBox.Show("Cập nhật thành công");
            }

            nv = new Nhanvien();
            nv = nvien;
            tk = new Taikhoan();
            tk = tkhoan;

            loadAll();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (password.Text == "")
            {
                errorInput.Text = "Mật khẩu không được để trống";
            }
            else
            {
                updateNV();
            }

        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            hometown.Text = "";
            phone.Text = "";
            email.Text = "";
            password.Text = "";
        }
    }
}
