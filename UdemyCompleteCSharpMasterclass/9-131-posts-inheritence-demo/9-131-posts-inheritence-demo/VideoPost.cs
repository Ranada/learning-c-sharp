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
    }
}
