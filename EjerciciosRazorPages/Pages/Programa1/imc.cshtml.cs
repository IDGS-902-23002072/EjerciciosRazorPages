using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace EjerciciosRazorPages.Pages.Programa1
{
    public class imcModel : PageModel
    {
        [BindProperty]
        public string peso { get; set; } = "";
        [BindProperty]

        public string altura { get; set; } = "";
        public double imc { get; set; } = 0.0;
        public void OnGet()
        {
        }

        public void OnPost()
        {
            double weight = Convert.ToDouble(peso);
            double height = Convert.ToDouble(altura);

            imc = weight / Math.Pow(height,2);

            ModelState.Clear();
        }
    }
}
