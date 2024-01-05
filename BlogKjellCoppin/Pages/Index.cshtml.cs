using BlogKjellCoppin.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Hosting;
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

        internal string ConvertBitmapToBase64(System.Drawing.Bitmap bitmap)
        {
            using (MemoryStream ms = new MemoryStream())
            {
                bitmap.Save(ms, System.Drawing.Imaging.ImageFormat.Png);
                byte[] imageBytes = ms.ToArray();
                return Convert.ToBase64String(imageBytes);
            }
        }
    }
}