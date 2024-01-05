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
    }
}