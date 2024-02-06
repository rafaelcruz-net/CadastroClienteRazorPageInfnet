using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace CadastroCliente.Pages.Cliente
{
    public class ListaModel : PageModel
    {
        private ClienteDbContext _context;
        public List<Model.Cliente> Clientes { get; set; }

        public ListaModel(ClienteDbContext context)
        {
            _context = context;
        }

        public void OnGet()
        {
            this.Clientes = this._context.Clientes.ToList();
        }
    }
}
