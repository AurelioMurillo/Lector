using Lector.model;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.Text.Json;

namespace Lector.Pages
{
    public class IndexModel : PageModel
    {
        private readonly ILogger<IndexModel> _logger;
        public int CamposEvaluar { get; set; }
        public int NumMuestras { get; set; }
        public bool Leucocitos { get; set; }
        public bool Eritrocitos { get; set; }
        public bool Cristales { get; set; }
        public bool Cilindros { get; set; }
        public bool CelTracto { get; set; }

        public IndexModel(ILogger<IndexModel> logger)
        {
            _logger = logger;
        }

        public void OnGet()
        {

        }

        public IActionResult OnPost(int CamposEvaluar,int NumMuestras, bool Leucocitos, bool Eritrocitos, bool Cristales, bool Cilindros, bool CelTracto)
        {
            ModeloLector model = new ModeloLector()
            {
                CamposEvaluar = CamposEvaluar,
                NumMuestras = NumMuestras,
                Leucocitos = Leucocitos,
                Eritrocitos = Eritrocitos,
                Cristales = Cristales,
                Cilindros = Cilindros,
                CelTracto = CelTracto
            };
            HttpContext.Session.SetString("Data", JsonSerializer.Serialize(model));
            return RedirectToPage("Finish");
        }
    }
}
