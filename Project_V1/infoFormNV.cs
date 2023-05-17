using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BLL;
using DTO;

namespace GUI
{
    public partial class infoFormNV : Form
    {
        private string filePath;
        private byte[] img;
        NhanvienBLL nvBLL = new NhanvienBLL();
        Nhanvien nv;
        TaikhoanBLL tkBLL = new TaikhoanBLL();
        Taikhoan tk;
        VitriBLL vtBLL = new VitriBLL();
        Vitri vt;

        public infoFormNV(Nhanvien nnv, Taikhoan ttk)
        {
            this.nv = nnv;
            this.tk = ttk;
            InitializeComponent();
        }

        private void infoForm_Load(object sender, EventArgs e)
        {
            labelID.Text = nv.Id;
            labelPos.Text = vtBLL.getVTName(nv.Idpos);
            fullname.Text = nv.Name;
            if (nv.Gender.Equals("Nam"))
            {
                radbtnMale.Checked = true;
            }
            if (nv.Gender.Equals("Nữ"))
            {
                radbtnFemale.Checked = true;
            }
            dob.Value = nv.Birthday;
            hometown.Text = nv.Hometown;
            phone.Text = nv.Phone;
            email.Text = nv.Email;
            using (MemoryStream stream = new MemoryStream(nv.Avatar))
            {
                Image image = Image.FromStream(stream);
                avatar.Image = image;
            }

            username.Text = tk.Userame;
            password.Text = tk.Password;
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

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            string id = labelID.Text;
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
            nv = new Nhanvien(id, nvName, nvSex, nvDob, nvHome, nvPhone, nvEmail, nvPos, nvAva);

            string uname = username.Text;
            string pass = password.Text;
            int per = 1;

            //set taikhoan
            tk = new Taikhoan(id, uname, pass, per);

            if (nvBLL.updateNV(nv) && tkBLL.updateAccount(tk))
            {
                MessageBox.Show("Cập nhật thành công");
                this.Close();
            }
        }

        private void avatar_Click(object sender, EventArgs e)
        {
            OpenImage();
        }

        private void btnDel_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Xác nhận xóa nhân viên '" + this.nv.Name + "' ?", "Xóa nhân viên", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                if (nvBLL.deleteNV(this.nv.Id) && tkBLL.deleteAccount(this.nv.Id))
                {
                    MessageBox.Show("Xóa thành công");
                    this.Close();
                }
            }
            else
            {
                // User clicked No or closed the dialog, do something else here
            }
        }
    }
}
