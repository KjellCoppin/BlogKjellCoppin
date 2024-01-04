using System.Drawing;
using System.Reflection;
using System.Security.Cryptography.X509Certificates;

namespace BlogKjellCoppin.Data
{
    public class Post
    {
        public string Title { get; set; }
        public DateTime PublishDate { get; set; }
        public string Content { get; set; }
        public List<Bitmap> Images { get; set; }

        public Post(string title, DateTime publishDate, string content, List<Bitmap> images)
        {
            Title = title;
            PublishDate = publishDate;
            Content = content;
            Images = images;
        }
    }
}
