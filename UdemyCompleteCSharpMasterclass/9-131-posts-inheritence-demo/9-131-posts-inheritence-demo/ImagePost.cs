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

        public string? ImageURL
        {
            get => _imageURL;
            set => _imageURL = value;
        }
        public override void Display()
        {
            Console.WriteLine("\nIMAGE POST");
            Console.WriteLine("ID: {0}", this.Id);
            Console.WriteLine("Title: {0}", this.Title);
            Console.WriteLine("Text: {0}", this.Text);
            Console.WriteLine("Image URL: {0}", this.ImageURL);
            Console.WriteLine("Posted by: {0}", this.Author);
            Console.WriteLine("Date created: {0}", this.Date);
        }

    }
}
