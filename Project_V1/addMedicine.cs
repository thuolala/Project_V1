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
using System.Text.RegularExpressions;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace GUI
{
    public partial class addMedicine : Form
    {
        public addMedicine()
        {
            InitializeComponent();
        }
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

        private void updateMedicine_Load(object sender, EventArgs e)
        {
            medID.Text = getID().ToString();
            date_nhap.Value = DateTime.Now;
            loadComboBoxType();
            loadComboBoxNCC();
            loadDVNhap_Ban();
        }

        private void btnAddMedicine_Click(object sender, EventArgs e)
        {
            addThuoc();
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

        private void medPic_Click(object sender, EventArgs e)
        {
            OpenImage();
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

        private void addThuoc()
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
            Thuoc th = new Thuoc(name, nsx, hsd, id_ncc, id_nt, nha_sx, chung_nhan, hamluong, tphan, chidinh, chongcd, medImg);

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
                if (thBLL.addThuoc(th) && thkhoBLL.addThuocKho(thkho) && thhopBLL.addThuocHop(thhop))
                {
                    MessageBox.Show("Thêm thành công");
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

                if (thBLL.addThuoc(th) && thkhoBLL.addThuocKho(thkho) && thloBLL.addThuocLo(thlo))
                {
                    MessageBox.Show("Thêm thành công");
                    this.Close();
                }
            }
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

        private void dv_nhap_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (dv_nhap.SelectedIndex == 0)
            {
                vien_lo.Enabled = false;
                vi_hop.Enabled = true;
                vien_vi.Enabled = true;

                dv_ban.SelectedIndex = 0;
            }
            else if (dv_nhap.SelectedIndex == 1)
            {
                vien_lo.Enabled = true;
                vi_hop.Enabled = false;
                vien_vi.Enabled = false;

                dv_ban.SelectedIndex = 1;
            }
        }

        private void vi_hop_TextChanged(object sender, EventArgs e)
        {
            int total = 0;
            if (vi_hop.Text == "" || sl_nhap.Text == "")
            {
                total = 0;
            }
            if (vi_hop.Text == "" && sl_nhap.Text == "")
            {
                total = 0;
            }
            else
            {
                total = Int32.Parse(sl_nhap.Text.ToString()) * Int32.Parse(vi_hop.Text.ToString());
            }

            totalVi.Text = total.ToString();
        }

        private void vien_vi_TextChanged(object sender, EventArgs e)
        {
            int total = 0;
            if (vien_vi.Text == "" || sl_nhap.Text == "")
            {
                total = 0;
            }
            if (vien_vi.Text == "" && sl_nhap.Text == "")
            {
                total = 0;
            }
            else
            {
                total = Int32.Parse(totalVi.Text.ToString()) * Int32.Parse(vien_vi.Text.ToString());
            }

            totalVien_Hop.Text = total.ToString();
        }

        private void vien_lo_TextChanged(object sender, EventArgs e)
        {
            int total = 0;
            if (vien_lo.Text == "" || sl_nhap.Text == "")
            {
                total = 0;
            }
            if (vien_lo.Text == "" && sl_nhap.Text == "")
            {
                total = 0;
            }
            else
            {
                total = Int32.Parse(sl_nhap.Text.ToString()) * Int32.Parse(vien_lo.Text.ToString());
            }
            totalVien_Lo.Text = total.ToString();
        }

        private void dv_ban_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (dv_ban.SelectedIndex == 0)
            {
                gia_vienlo_ban.Enabled = false;
                gia_vienhop_ban.Enabled = true;
                gia_vihop_ban.Enabled = true;
            }
            else if (dv_nhap.SelectedIndex == 1)
            {
                gia_vienlo_ban.Enabled = true;
                gia_vienhop_ban.Enabled = false;
                gia_vihop_ban.Enabled = false;
            }
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
            totalMoneyNhap.Text = total.ToString();

            // 
        }


    }
}
