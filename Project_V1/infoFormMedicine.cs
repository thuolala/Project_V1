using BLL;
using DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI
{
    public partial class infoFormMedicine : Form
    {
        NhomthuocBLL ntBLL = new NhomthuocBLL();
        Nhomthuoc nt = new Nhomthuoc();
        ThuocKhoBLL thkhoBLL = new ThuocKhoBLL();
        Thuoc_Kho thkho = new Thuoc_Kho();
        ThuocHopBLL thhopBLL = new ThuocHopBLL();
        Thuoc_Hop thhop = new Thuoc_Hop();
        ThuocBLL thBLL = new ThuocBLL();
        Thuoc th = new Thuoc();
        ThuocLoBLL thloBLL = new ThuocLoBLL();
        Thuoc_Lo thlo = new Thuoc_Lo();
        NhacungcapBLL nccBLL = new NhacungcapBLL();
        Nhacungcap ncc = new Nhacungcap();
        byte[] img;

        public infoFormMedicine(Thuoc thuoc)
        {
            this.th = thuoc;
            InitializeComponent();
        }

        private Thuoc getThuoc(string id)
        {
            return thBLL.getThuocById(id);
        }

        private Thuoc_Kho getThuocKho(string id)
        {
            return thkhoBLL.getThuocKhoById(id);
        }

        //load combo box dv 
        private void loadDVNhap_Ban()
        {
            string sitem = "Hộp";
            string titem = "Lọ";

            dv_nhap.Items.Insert(0, sitem);
            dv_nhap.Items.Insert(1, titem);

            dv_ban.Items.Insert(0, sitem);
            dv_ban.Items.Insert(1, titem);
        }


        //get id thuoc 
        private string getID()
        {
            return thBLL.getAutoID();
        }

        //RESIZE///
        //resize image to 
        public Image ResizeImageByPercentage(Image image)
        {
            int newWidth = 250;
            int newHeight = 260;

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
                string filePath = open.FileName;
                Image imgR = CloneImage(filePath);
                imgR = ResizeImageByPercentage(imgR);
                medPic.Image = imgR;
                //avatar.ImageLocation = filePath;
                img = ImageToByteArray(imgR);
            }
        }

        //load combo box 
        private void loadComboBoxType()
        {
            string fitem = "Tất cả";
            string fvalue = "ALL";

            DataTable dt = ntBLL.getAllNhomthuoc();
            Dictionary<string, string> listType = new Dictionary<string, string>();
            listType.Add(fitem, fvalue);

            foreach (DataRow row in dt.Rows)
            {
                listType.Add(row["TEN"].ToString(), row["ID"].ToString());
            }

            List<KeyValuePair<string, string>> list = listType.ToList();

            medType.DataSource = list;
            medType.DisplayMember = "Key";
            medType.ValueMember = "Value";

            medType.SelectedIndex = 0;
        }

        private void loadComboBoxNCC()
        {
            string fitem = "Tất cả";
            string fvalue = "ALL";

            DataTable dt = nccBLL.getAllNCC();
            Dictionary<string, string> listType = new Dictionary<string, string>();
            listType.Add(fitem, fvalue);

            foreach (DataRow row in dt.Rows)
            {
                listType.Add(row["TEN"].ToString(), row["ID"].ToString());
            }

            List<KeyValuePair<string, string>> list = listType.ToList();

            medNCC.DataSource = list;
            medNCC.DisplayMember = "Key";
            medNCC.ValueMember = "Value";

            medNCC.SelectedIndex = 0;
        }

        private void loadData()
        {
            dv_nhap.Enabled = false;
            dv_ban.Enabled = false;

            thkho = thkhoBLL.getThuocKhoById(this.th.Id);
            thhop = thhopBLL.getThuocHopById(this.th.Id);
            thlo = thloBLL.getThuocLoById(this.th.Id);

            medID.Text = this.th.Id;
            date_nhap.Value = DateTime.Now;
            med_name.Text = this.th.Name;
            using (MemoryStream stream = new MemoryStream(this.th.Img))
            {
                Image image = Image.FromStream(stream);
                medPic.Image = image;
            }
            medType.SelectedValue = this.th.Id_nt;
            date_nsx.Value = this.th.Nsx;
            date_hsd.Value = this.th.Hsd;
            medNCC.SelectedValue = this.th.Id_ncc;
            nhasx.Text = this.th.Nhasx;
            chungnhan.Text = this.th.Chungnhan;
            if (thhop != null)
            {
                dv_nhap.SelectedIndex = 0;
                dv_ban.SelectedIndex = 0;

                gia_vienlo_ban.Enabled = false;

                vi_hop.Text = (thhop.Sl_vi / thhop.Sl_hop).ToString();
                vien_vi.Text = (thhop.Sl_vien / thhop.Sl_vi).ToString();

                totalVi.Text = thhop.Sl_vi.ToString();
                totalVien_Hop.Text = thhop.Sl_vien.ToString();

                gia_vihop_ban.Text = thhop.Dongia_vi.ToString();
                gia_vienhop_ban.Text = thhop.Dongia_vien.ToString();
            }
            else if (thhop == null)
            {
                dv_nhap.SelectedIndex = 1;
                dv_ban.SelectedIndex = 1;

                gia_vihop_ban.Enabled = false;
                gia_vienhop_ban.Enabled = false;

                vien_lo.Text = (thlo.Sl_vien / thlo.Sl_lo).ToString();
                totalVien_Lo.Text = thlo.Sl_vien.ToString();

                gia_vienlo_ban.Text = thlo.Dongia_vien.ToString();
            }

            sl_nhap.Text = thkho.Sl_donggoi.ToString();
            moneyNhap.Text = thkho.Dongia_donggoi.ToString();
            totalMoneyNhap.Text = thkho.Total_nhap.ToString();

            gia_ban.Text = thkho.Dongia_dvban.ToString();
            thanh_phan.Text = this.th.Thanhphan;
            chi_dinh.Text = this.th.Chidinh;
            chong_cd.Text = this.th.Chongcd;
            date_nhap.Value = thkho.Ngaynhap;
            ham_luong.Text = this.th.Hamluong.ToString();
        }

        private void infoFormMedicine_Load(object sender, EventArgs e)
        {
            loadDVNhap_Ban();
            loadComboBoxType();
            loadComboBoxNCC();

            loadData();
        }

        private void updateThuoc()
        {
            string id = medID.Text;
            string name = med_name.Text;
            string id_nt = medType.SelectedValue.ToString();

            DateTime nsx = date_nsx.Value;
            DateTime hsd = date_hsd.Value;
            string id_ncc = medNCC.SelectedValue.ToString();
            string nha_sx = nhasx.Text;
            string chung_nhan = chungnhan.Text;

            string dvnhap = dv_nhap.SelectedItem.ToString();
            int slnhap = Int32.Parse(sl_nhap.Text);
            int gianhap = Int32.Parse(moneyNhap.Text);
            int tongtienhap = Int32.Parse(totalMoneyNhap.Text);

            // 
            DateTime ngaynhap = date_nhap.Value;
            string dvban = dv_ban.SelectedItem.ToString();
            int giaban = Int32.Parse(gia_ban.Text);

            byte[] medImg = img;

            int hamluong = Int32.Parse(ham_luong.Text);
            string tphan = thanh_phan.Text;
            string chidinh = chi_dinh.Text;
            string chongcd = chong_cd.Text;

            //set thuoc
            Thuoc th = new Thuoc(id, name, nsx, hsd, id_ncc, id_nt, nha_sx, chung_nhan, hamluong, tphan, chidinh, chongcd, medImg);

            string quycach = "";
            //set thuoc kho 
            if (dv_nhap.SelectedIndex == 0)
            {
                quycach = vi_hop.Text + " vỉ/hộp " + vien_vi.Text + " viên/vỉ";
                //hop 
                int vihop = Int32.Parse(vi_hop.Text);
                int vienvi = Int32.Parse(vien_vi.Text);
                int tongvi = Int32.Parse(totalVi.Text);
                int tongvien_hop = Int32.Parse(totalVien_Hop.Text);

                //hop 
                int unit_vihop = Int32.Parse(gia_vihop_ban.Text);
                int unit_vienhop = Int32.Parse(gia_vienhop_ban.Text);

                //thuoc hop 
                Thuoc_Hop thhop = new Thuoc_Hop(id, slnhap, giaban, tongvi, unit_vihop, tongvien_hop, unit_vienhop);
                //kho 
                Thuoc_Kho thkho = new Thuoc_Kho(id, ngaynhap, quycach, slnhap, dvnhap, gianhap, tongtienhap, dvban, giaban);
                if (thBLL.updateThuoc(th) && thkhoBLL.updateThuocKho(thkho) && thhopBLL.updateThuocHop(thhop))
                {
                    MessageBox.Show("Cập nhật thành công");
                    this.Close();
                }
            }
            else if (dv_nhap.SelectedIndex == 1)
            {
                quycach = vien_lo.Text + " viên/lọ";

                //lo 
                int vienlo = Int32.Parse(vien_lo.Text);
                int tongvien_lo = Int32.Parse(totalVien_Lo.Text);

                //lo 
                int unit_vienlo = Int32.Parse(gia_vienlo_ban.Text);

                //thuoc lo 
                Thuoc_Lo thlo = new Thuoc_Lo(id, slnhap, giaban, tongvien_lo, unit_vienlo);
                //kho 
                Thuoc_Kho thkho = new Thuoc_Kho(id, ngaynhap, quycach, slnhap, dvnhap, gianhap, tongtienhap, dvban, giaban);

                if (thBLL.updateThuoc(th) && thkhoBLL.updateThuocKho(thkho) && thloBLL.updateThuocLo(thlo))
                {
                    MessageBox.Show("Cập nhật thành công");
                    this.Close();
                }
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            updateThuoc();
        }

        private void medPic_Click(object sender, EventArgs e)
        {
            OpenImage();
        }

        private void sl_nhap_TextChanged(object sender, EventArgs e)
        {
            int total = 0;
            if (moneyNhap.Text == "" || sl_nhap.Text == "")
            {
                total = 0;
            }
            else
            {
                total = Int32.Parse(sl_nhap.Text) * Int32.Parse(moneyNhap.Text);
            }

            if (dv_nhap.SelectedIndex == 0)
            {
                totalVi.Text = (Int32.Parse(sl_nhap.Text) * Int32.Parse(vi_hop.Text)).ToString();
                totalVien_Hop.Text = (Int32.Parse(sl_nhap.Text) * Int32.Parse(vien_vi.Text)).ToString();
            }
            else if (dv_nhap.SelectedIndex == 1)
            {
                totalVien_Lo.Text = (Int32.Parse(sl_nhap.Text) * Int32.Parse(vien_lo.Text)).ToString();
            }

            totalMoneyNhap.Text = total.ToString();
        }

        private void moneyNhap_TextChanged(object sender, EventArgs e)
        {
            int total = 0;
            if (moneyNhap.Text == "" || sl_nhap.Text == "")
            {
                total = 0;
            }
            else
            {
                total = Int32.Parse(sl_nhap.Text) * Int32.Parse(moneyNhap.Text);
            }
            totalMoneyNhap.Text = total.ToString();
        }

        private void vi_hop_TextChanged(object sender, EventArgs e)
        {
        }

        private void vien_vi_TextChanged(object sender, EventArgs e)
        {
        }

        private void vien_lo_TextChanged(object sender, EventArgs e)
        {
        }

        private void btnDel_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Xác nhận xóa thuốc '" + this.th.Name + "' ?", "Xóa thuốc", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes && thkhoBLL.getThuocKhoById(this.th.Id).Dv_donggoi.Equals("Hộp"))
            {
                if (thBLL.deleteThuoc(this.th.Id) && thkhoBLL.deleteThuocKho(this.th.Id) && thhopBLL.deleteThuocHop(this.th.Id))
                {
                    MessageBox.Show("Xóa thành công");
                    this.Close();
                }
            }
            else if(result == DialogResult.Yes && thkhoBLL.getThuocKhoById(this.th.Id).Dv_donggoi.Equals("Lọ"))
            {
                if (thBLL.deleteThuoc(this.th.Id) && thkhoBLL.deleteThuocKho(this.th.Id) && thloBLL.deleteThuocLo(this.th.Id))
                {
                    MessageBox.Show("Xóa thành công");
                    this.Close();
                }
            }
        }
    }
}
