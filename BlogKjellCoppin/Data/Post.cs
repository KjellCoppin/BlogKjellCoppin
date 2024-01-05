using System.Drawing;
using System.Reflection;
using System.Security.Cryptography.X509Certificates;
using System;

namespace BlogKjellCoppin.Data
{
    public class Post
    {
        public int Id { get; }
        public string Title { get; set; }
        public DateTime PublishDate { get; set; }
        public string Content { get; set; }
        public List<Bitmap> Images { get; set; }
        public bool FullText { get; set; } = false;

        public Post(int id, string title, DateTime publishDate, string content, List<Bitmap> images)
        {
            Id = id;
            Title = title;
            PublishDate = publishDate;
            Content = content;
            Images = images;
        }

        public string ShortContent()
        {
            int len = Content.IndexOf("<br>");
            return string.Concat(Content.AsSpan(0, len), "...");
        }
    }
}
