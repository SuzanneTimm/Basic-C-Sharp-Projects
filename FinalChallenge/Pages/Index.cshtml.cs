using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FinalChallenge.Pages
{
    public class IndexModel : PageModel
    {
        private readonly ILogger<IndexModel> _logger;

        public string CurrentDisplayDateAndTimeStr
        {
            get;
            set;
        }

        public IndexModel(ILogger<IndexModel> logger)
        {
            _logger = logger;
        }

        public void OnGet()

        {
            CurrentDisplayDateAndTimeStr = DateTime.Now.ToString("D");

        }
        public void OnPost()

        {
            CurrentDisplayDateAndTimeStr = "Posted new time at " + DateTime.Now.ToString("F");
        }
    }
}
