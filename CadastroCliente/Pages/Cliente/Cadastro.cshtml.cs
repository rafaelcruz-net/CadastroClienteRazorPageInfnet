using CadastroCliente.Model;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace CadastroCliente.Pages.Cliente
{
    public class CadastroModel : PageModel
    {
        [BindProperty]
        public Model.Cliente Cliente { get; set; }

        private ClienteDbContext _context;

        public CadastroModel(ClienteDbContext context)
        {
            _context = context;
        }

        public void OnGet()
        {
        }

        public void OnPost() 
        { 
            if (Cliente != null)
            {
                this._context.Clientes.Add(Cliente);
                this._context.SaveChanges();
            }
        
        }
    }
}
