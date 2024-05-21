using Lector.model;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.Text.Json;

namespace Lector.Pages
{
    public class ResultModel : PageModel
    {
        public ModeloLector Modelo { get; set; }
        public void OnGet()
        {
            Modelo =  JsonSerializer.Deserialize<ModeloLector>(HttpContext.Session.Get("Data"), new JsonSerializerOptions { PropertyNameCaseInsensitive = true })!;

        }

        public IActionResult OnPost()
        {
            return RedirectToPage("Index");
        }
    }
}
