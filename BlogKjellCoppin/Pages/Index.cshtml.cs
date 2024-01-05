using BlogKjellCoppin.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Hosting;
using SkiaSharp;
using System.Security.Cryptography.X509Certificates;

namespace BlogKjellCoppin.Pages
{
    public class IndexModel : PageModel
    {
        private readonly ILogger<IndexModel> _logger;
        internal readonly IRepository _repo;


        public IndexModel(ILogger<IndexModel> logger)
        {
            _logger = logger;
            _repo = new MockRepository();
        }

        public void OnGet()
        {
            
        }

        public string ConvertSKBitmapToBase64(SKBitmap skBitmap)
        {
            using (var image = SKImage.FromBitmap(skBitmap))
            using (var data = image.Encode(SKEncodedImageFormat.Png, 100))
            {
                byte[] byteArray = data.ToArray();
                return Convert.ToBase64String(byteArray);
            }
        }
    }
}