using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class Product
    {
        private byte[] _image;

        public byte[] Image
        {
            get { return _image; }
            set
            {
                _image = value;
            }
        }

        public Product()
        {

        }

        public Product(byte[] pImage)
        {
            this._image = pImage;
        }
    }

    
}
