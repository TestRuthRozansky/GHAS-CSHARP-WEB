using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.Text.RegularExpressions;

namespace GHAS_CSHARP_WEB.Pages
{
    public class IndexModel : PageModel
    {
        private readonly ILogger<IndexModel> _logger;

        public IndexModel(ILogger<IndexModel> logger)
        {
            _logger = logger;
        }

        public void OnGet()
        {

        }

        public void OnPost()
        {
            var pwd = Request.Form["password"];
            Regex testPassword = new Regex(pwd);
            var b = Int16.Parse(pwd);
            ViewData["TestDiv"] =  testdiv(1, b);
        }

        int testdiv(int a, int b)
        {
            return a / b;
        }
    }
}