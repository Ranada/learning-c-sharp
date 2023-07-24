using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _9_131_posts_inheritence_demo
{
    internal class ImagePost : GeneralPost
    {
        private string _imageURL = "";

        public ImagePost() : base() { 
        }

        public string ImageURL
        {
            get => _imageURL;
            set => _imageURL = value;
        }

    }
}
