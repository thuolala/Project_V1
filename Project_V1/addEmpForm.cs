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

        public addEmpForm()
        {
            InitializeComponent();
        }

        private void exit_Click(object sender, EventArgs e)
        {
            this.Close();
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

        private byte[] ImageToByteArray(PictureBox pictureBox)
        {
            MemoryStream memoryStream = new MemoryStream();
            pictureBox.Image.Save(memoryStream, pictureBox.Image.RawFormat);
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

        private void btnUploadPic_Click(object sender, EventArgs e)
        {
            OpenImage();
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
            string nvPos = "BH";
            byte[] nvAva = ImageToByteArray(avatar);

            //set nhan vien
            nv = new Nhanvien(nvName, nvSex, nvDob, nvHome, nvPhone, nvEmail, nvPos, img);

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
    }
}
