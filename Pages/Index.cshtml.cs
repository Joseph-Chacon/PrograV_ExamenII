using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using MiAppWebBD.Data;
using ExamenFinal.Models;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


namespace ExamenFinal.Pages
{
    public class IndexModel : PageModel
    {
        private readonly ApplicationDbContext _context;

        public IndexModel(ApplicationDbContext context)
        {
            _context = context;
        }

        [BindProperty]
        public List<Estudiante> Estudiantes { get; set; }
        public string ErrorMessage { get; set; }

        public async Task OnGetAsync()
        {
            try
            {
                Estudiantes = await _context.Estudiantes.ToListAsync();
            }catch (Exception ex) {
                ErrorMessage = "No se pudo conectar a la base de datos. Por favor, intente nuevamente más tarde.";
            }
            
        }
    }
}
