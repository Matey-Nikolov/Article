using System;
using System.Collections.Generic;
using System.Text;

namespace Articles
{
    class Article
    {
        public Article(string title, string content, string author)
        {
            Title = title;
            Content = content;
            Author = author;
        }

        public string Title { get; set; }

        public string Content { get; set; }

        public string Author { get; set; }

        public void Rename(string rename)
        {
            Title = rename;
        }

        public void Edit(string edit)
        {
            Content = edit;
        }

        public void ChangeAuthor(string changeAuthor)
        {
            Author = changeAuthor;
        }

        public override string ToString()
        {
            return $"{this.Title} - {this.Content}: {this.Author}";
        }
    }
}
