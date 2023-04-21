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
using DAL;
using DTO;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;


namespace GUI
{
    public partial class test : Form
    {
        private string filePath;
        private byte[] img;
        ProductBLL pBLL = new ProductBLL();
        Product product;

        public test()
        {
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

        private void LoadGridView()
        {
            gdV.Columns[0].HeaderText = "Avatar";


            DataGridViewImageColumn imgCol = new DataGridViewImageColumn();
            imgCol = (DataGridViewImageColumn)gdV.Columns[0];
            imgCol.ImageLayout = DataGridViewImageCellLayout.Zoom;
        }


        private void test_Load(object sender, EventArgs e)
        {
            gdV.DataSource = pBLL.getAllProduct();
            LoadGridView();
        }

        private void OpenImage()
        {
            OpenFileDialog open = new OpenFileDialog();
            open.Filter = "Image Files (*.jpg, *.jpeg, *.jpe, *.jfif, *.png)|*.jpg; *.jpeg; *.jpe; *.jfif; *.png|All files (*.*)|*.*";
            open.Title = "Chọn ảnh";
            if (open.ShowDialog() == DialogResult.OK)
            {
                filePath = open.FileName;
                pic.Image = CloneImage(filePath);
                pic.ImageLocation = filePath;
                img = ImageToByteArray(pic);
            }
        }

        private void btnPic_Click(object sender, EventArgs e)
        {
            OpenImage();

            product = new Product(ImageToByteArray(pic));

            if (pBLL.addProduct(product))
            {
                gdV.DataSource = pBLL.getAllProduct();
                LoadGridView();
            }
        }
    }
}
