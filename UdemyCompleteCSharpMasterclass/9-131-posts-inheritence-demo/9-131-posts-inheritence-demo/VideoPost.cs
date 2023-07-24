using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _9_131_posts_inheritence_demo
{
    internal class VideoPost : GeneralPost
    {
        private string? _videoURL = "";
        private int _length { get; set; }
        public VideoPost() { }

        public string? VideoURL
        {
            get => _videoURL;
            set => _videoURL = value;
        }
        public override void Display()
        {
            Console.WriteLine("\nVIDEO POST");
            Console.WriteLine("ID: {0}", this.Id);
            Console.WriteLine("Title: {0}", this.Title);
            Console.WriteLine("Text: {0}", this.Text);
            Console.WriteLine("Video URL: {0}", this.VideoURL);
            Console.WriteLine("Posted by: {0}", this.Author);
            Console.WriteLine("Date created: {0}", this.Date);
        }
    }
}
