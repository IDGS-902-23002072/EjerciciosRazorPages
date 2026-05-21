using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace EjerciciosRazorPages.Pages.Programa2
{
    public class codificarModel : PageModel
    {
        [BindProperty]
        public string mensaje { get; set; } = "";

        [BindProperty]
        public string factorN { get; set; } = "";

        public string msjCodificado { get; set; } = "";
        public string msjDecodificado { get; set; } = "";

        private string alfabeto = "ABCDEFGHIJKLMNOPQRSTUVXYZ";
        public void OnGet()
        {
        }

        public void OnPost()
        {
            int n = Convert.ToInt32(factorN);

            for (int i = 0; i < mensaje.Length; i++)
            {
                if (mensaje[i] != ' ')
                {
                    int posicion = alfabeto.IndexOf(char.ToUpper(mensaje[i]));

                    if (posicion != -1)
                    {
                        int nuevaPosicion = (posicion + n) % alfabeto.Length;

                        msjCodificado += alfabeto[nuevaPosicion];
                    }
                    else {
                        msjCodificado += mensaje[i];                    
                    }
                }
                else
                {
                    msjCodificado += " ";
                }
            }
        }

        public void decodificar() {
            int n = Convert.ToInt32(factorN);

            for (int i = 0; i < msjCodificado.Length; i++)
            {
                if (msjCodificado[i] != ' ')
                {
                    int posicion = alfabeto.IndexOf(char.ToUpper(msjCodificado[i]));

                    if (posicion != -1)
                    {
                        int nuevaPosicion = (posicion - n) % alfabeto.Length;

                        msjDecodificado += alfabeto[nuevaPosicion];
                    }
                    else
                    {
                        msjDecodificado += msjCodificado[i];
                    }
                }
                else
                {
                    msjDecodificado += " ";
                }
            }
        }
    }
}