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


        private void selfEditForm_Load(object sender, EventArgs e)
        {
            fullname.Text = nv.Name;
            displayID.Text = nv.Id;
            if (nv.Gender.Equals("Nam"))
            {
                radioButtonMale.Checked = true;
            }
            else
            {
                radioButtonMale.Checked = true;
            }
            displayPos.Text = vtBLL.getVTById(nv.Idpos).Name;
            displayPhone.Text = nv.Phone;
            displayBirth.Text = nv.Birthday.ToString().Split(" ")[0];
            hometown.Text = nv.Hometown;
            phone.Text = nv.Phone;
            email.Text = nv.Email;
            displayUsername.Text = tk.Userame;
            displayPassword.Text = tk.Password;
        }

        private void avatar_Click(object sender, EventArgs e)
        {
            OpenImage();
        }

        private void panelEdit_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
