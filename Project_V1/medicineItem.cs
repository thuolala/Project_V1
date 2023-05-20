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
    public partial class medicineItem : UserControl
    {
        public string name;
        public int price;
        Thuoc th;
        ThuocBLL thBLL = new ThuocBLL();
        ThuocKhoBLL thkhoBLL = new ThuocKhoBLL();
        Thuoc_Kho thkho = new Thuoc_Kho();
        ThuocHopBLL thhopBLL = new ThuocHopBLL();
        Thuoc_Hop thhop = new Thuoc_Hop();
        ThuocLoBLL thloBLL = new ThuocLoBLL();
        Thuoc_Lo thlo = new Thuoc_Lo();

        public medicineItem(Thuoc thuoc)
        {
            InitializeComponent();
            this.th = thuoc;
        }

        private Thuoc getThuoc(string id)
        {
            return thBLL.getThuocById(id);
        }

        private Thuoc_Kho getThuocKho(string id)
        {
            return thkhoBLL.getThuocKhoById(id);
        }

        //resize image to 
        public Image ResizeImageByPercentage(Image image)
        {
            int newWidth = 240;
            int newHeight = 190;

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

        private void medicineItem_Load(object sender, EventArgs e)
        {
            medName.Text = th.Name;
            labelID.Text = this.th.Id;

            thkho = getThuocKho(this.th.Id);
            medPrice.Text = thkho.Dongia_dvban.ToString();
            try
            {
                using (MemoryStream stream = new MemoryStream(this.th.Img))
                {
                    Image image = Image.FromStream(stream);
                    image = ResizeImageByPercentage(image);
                    medPic.Image = image;
                }
            }
            catch (ArgumentException ex)
            {
                MessageBox.Show("Error loading image: " + ex.Message);
            }
            avaiQuan.Text = thkho.Sl_donggoi.ToString();
            labelUnit.Text = thkho.Dv_ban;
        }

        private void btnDetail_Click(object sender, EventArgs e)
        {
            infoFormMedicine f = new infoFormMedicine(this.th);
            f.ShowDialog();
        }
    }
}
