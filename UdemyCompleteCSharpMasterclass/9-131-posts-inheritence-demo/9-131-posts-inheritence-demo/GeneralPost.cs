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
        private string _text = "";
        private string _author = "";
        private string _date = "";

        public GeneralPost(string title, string text, string author) {
            _id += 1;
            _title = title;
            _text = text;
            _author = author;
            _date = "TODO: Add method to create timestamp";
        }

        public int Id
        {
            get => _id;
            set => _id = value;
        }
        public string Title
        {
            get => _title;
            set => _title = value;
        }
    }
}
