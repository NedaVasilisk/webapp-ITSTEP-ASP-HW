using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Task1.Pages
{
    public class TimeModel : PageModel
    {
        public string CurrentDate { get; set; }

        public void OnGet()
        {
            CurrentDate = DateTime.Now.ToString("dd.MM.yyyy"); 
        }
    }
}
