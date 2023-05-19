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
    public partial class employeeItem : UserControl
    {
        public Nhanvien nv;
        public Taikhoan tk;
        TaikhoanBLL tkBLL = new TaikhoanBLL();
        VitriBLL vtBLL = new VitriBLL();

        public employeeItem(Nhanvien nvien, Taikhoan tkhoan)
        {
            this.nv = nvien;
            this.tk = tkhoan;
            InitializeComponent();
        }

        //resize image to 
        public Image ResizeImageByPercentage(Image image)
        {
            int newWidth = 90;
            int newHeight = 100;

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

        private void empItem_Load(object sender, EventArgs e)
        {
            empName.Text = this.nv.Name;
            empID.Text = this.nv.Id;
            empPos.Text = vtBLL.getVTName(this.nv.Idpos);
            try
            {
                using (MemoryStream stream = new MemoryStream(nv.Avatar))
                {
                    Image image = Image.FromStream(stream);
                    image = ResizeImageByPercentage(image);
                    empPic.Image = image;
                }
            }
            catch (ArgumentException ex)
            {
                // Handle the exception here, for example:
                MessageBox.Show("Error loading image: " + ex.Message);
            }
        }

        private void empItem_Paint(object sender, PaintEventArgs e)
        {

        }

        private void empPic_Click(object sender, EventArgs e)
        {

        }

        private void btnDetail_Click(object sender, EventArgs e)
        {
            infoFormNV f = new infoFormNV(this.nv, this.tk);
            f.ShowDialog();
        }
    }
}
