using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.VisualBasic;

namespace EjerciciosRazorPages.Pages.Programa3
{
    public class expresionModel : PageModel
    {
        public string valorA { get; set; } = "";
        public string valorB { get; set; } = "";
        public string valorX { get; set; } = "";
        public string valorY { get; set; } = "";
        public string valorN { get; set; } = "";
        public double[] valoresNK { get; set; } = [];
        public double[] resultados { get; set; } = [];

        public double total { get; set; } = 0;
        public void OnGet()
        {
        }
        public void OnPost() {
            double a = Convert.ToDouble(valorA);
            double b = Convert.ToDouble(valorB);
            double x = Convert.ToDouble(valorX);
            double y = Convert.ToDouble(valorY);
            double n = Convert.ToDouble(valorN);

            evaluacion(n,a,b,x,y);

        }

        public void evaluacion(double n, double a, double b, double x, double y)
        {
            calcularNK(n);

            for (int k = 0; k < valoresNK.Length; k++)
            {
                total += valoresNK[k] * Math.Pow((a * x), (n - k)) * Math.Pow((b * y), (k));
                resultados[k]= total;
            }

        }

        public void calcularNK(double n)
        {
            double valor = 0;

            for (int k = 0; k < n; k++)
            {
                valor = (factorial(n) / (factorial(k) * factorial(n - k)));
                valoresNK[k] = valor;
            }
        }

        public double factorial(double valor)
        {
            if (valor <= 1) return 1;
            return valor * factorial(valor - 1);
        }
    }
}
