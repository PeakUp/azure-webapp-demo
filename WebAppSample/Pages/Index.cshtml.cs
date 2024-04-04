using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Options;
using WebAppSample.Settings;

namespace WebAppSample.Pages
{
    public class IndexModel : PageModel
    {
        private readonly ILogger<IndexModel> _logger;
        private readonly WebSettings _options;

        public IndexModel(ILogger<IndexModel> logger, IOptionsSnapshot<WebSettings> options)
        {
            _logger = logger;
            _options = options.Value;
        }

        public WebSettings Options => _options;

        public void OnGet()
        {

        }
    }
}
