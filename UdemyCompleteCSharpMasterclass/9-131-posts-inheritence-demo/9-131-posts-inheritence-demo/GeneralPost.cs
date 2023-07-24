using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _9_131_posts_inheritence_demo
{
    internal class GeneralPost
    {
        private int _id = 0;
        private string? _title = "";
        private string? _text = "";
        private string? _author = "";
        private string _date = "";

        public GeneralPost(string author) {
            _id += 1;
            _author = author;
        }

        public int Id
        {
            get => _id;
            set => _id = value;
        }
        public string? Title
        {
            get => _title;
            set => _title = value;
        }
        public string? Text
        {
            get => _text;
            set => _text = value;
        }
        public string? Author
        {
            get => _author;
            set => _author = value;
        }
        public string? Date
        {
            get => _date;
            set => _date = value;
        }
    }
}
