﻿using BLL;
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
using System.Text.RegularExpressions;

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

        //get per
        private int getPer()
        {
            if (comboboxPosition.SelectedValue.Equals("AD"))
            {
                return 2;
            }
            else
            {
                return 1;
            }
        }

        private bool checkConfirmPass()
        {
            if (password.Text.Equals(confirmPass.Text))
            {
                return true;
            }
            else
            {
                errorInput.Text = "Mật khẩu không trùng khớp!";
                return false;
            }
        }

        private bool ContainsNonAlphabeticChars(string input)
        {
            Regex regex = new Regex("[^a-zA-Z]");
            return regex.IsMatch(input);
        }
        private bool ContainsNonNumber(string input)
        {
            Regex regex = new Regex("[^0-9]");
            return regex.IsMatch(input);
        }

        private bool checkFullname()
        {
            if (fullname.Text == "")
            {
                errorInput.Text = "Họ tên không được trống!";
                return false;
            }
            else if (ContainsNonAlphabeticChars(fullname.Text))
            {
                errorInput.Text = "Họ tên không được chứa ký tự đặc biệt!";
                return false;
            }
            else
            {
                return true;
            }
        }

        private bool checkGender()
        {
            if (radbtnMale.Checked == false && radbtnFemale.Checked == false)
            {
                errorInput.Text = "Vui lòng chọn giới tính!";
                return false;
            }
            else
            {
                return true;
            }
        }

        private bool checkTown()
        {
            if (hometown.Text == "")
            {
                errorInput.Text = "Quê quán không được trống!";
                return false;
            }
            else
            {
                return true;
            }
        }

        private bool checkPhone()
        {
            if (phone.Text == "")
            {
                errorInput.Text = "SĐT không được trống!";
                return false;
            }
            else if (ContainsNonNumber(phone.Text))
            {
                errorInput.Text = "SĐT sai định dạng!";
                return false;
            }
            else
            {
                return true;
            }
        }
        private bool checkEmail()
        {
            if (email.Text == "")
            {
                errorInput.Text = "Email không được trống!";
                return false;
            }
            else if (email.Text.StartsWith("@") || email.Text.EndsWith("@"))
            {
                errorInput.Text = "Email sai định dạng!";
                return false;
            }
            else
            {
                return true;
            }
        }

        private bool checkInput()
        {
            bool f = checkFullname();
            bool t = checkTown();
            bool p = checkPhone();
            bool e = checkEmail();

            bool res = false;
            if (f && t && p && p && e)
            {
                res = true;
            }
            else
            {
                if(f == false || t == false || p == false || e == false)
                {
                    res = false;
                }
            }

            return res;
        }

        private void addNV()
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
            DateTime created = date_created.Value;
            string nvPos = comboboxPosition.SelectedValue.ToString();
            byte[] nvAva = img;

            //set nhan vien
            nv = new Nhanvien(nvName, nvSex, nvDob, nvHome, nvPhone, nvEmail, nvPos, created, nvAva);

            string uname = username.Text;
            string pass = password.Text;
            int per = getPer();

            //set taikhoan
            tk = new Taikhoan(uname, pass, per);

            //them ql 
            if (nvPos.Equals("AD"))
            {
                if (nvBLL.addQL(nv) && tkBLL.addAccountQL(tk))
                {
                    MessageBox.Show("Thêm thành công");
                    this.Close();
                }
            }
            //them nv 
            else if (nvPos.Equals("BH") || nvPos.Equals("KHO") || nvPos.Equals("TN"))
            {
                if (nvBLL.addNV(nv) && tkBLL.addAccountNV(tk))
                {
                    MessageBox.Show("Thêm thành công");
                    this.Close();
                }
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (checkInput())
            {
                addNV();
            }
        }

        //Get auto id 
        private string getID()
        {
            if (comboboxPosition.SelectedValue.ToString().Equals("AD"))
            {
                return nvBLL.getAutoIDQL();
            }
            else
            {
                return nvBLL.getAutoIDNV();
            }
        }

        private void setID()
        {
            labelID.Text = getID();
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
            loadComboBox();
            setID();
        }

        private void avatar_Click(object sender, EventArgs e)
        {
            OpenImage();
        }

        private void comboboxPosition_SelectedIndexChanged(object sender, EventArgs e)
        {
            setID();
        }
    }
}
