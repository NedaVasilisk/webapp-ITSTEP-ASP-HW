using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Task1.Pages
{
    public class RandomModel : PageModel
    {
        public char RandomLetter { get; set; }

        public void OnGet()
        {
            Random random = new Random();
            int randomIndex = random.Next(0, 26);

            string alphabet = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";

            RandomLetter = alphabet[randomIndex];
        }
    }
}
