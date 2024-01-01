using System.Reflection;
using System.Security.Cryptography.X509Certificates;

namespace BlogKjellCoppin
{
    public class Post
    {
        public string Title { get; set; }
        public DateTime PublishDate { get; set; }
        public string Content { get; set; }

        public Post(string title, DateTime publishDate, string content)
        {
            Title = title;
            PublishDate = publishDate;
            Content = content;
        }
    }
}
