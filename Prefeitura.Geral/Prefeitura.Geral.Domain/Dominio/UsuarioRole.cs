using Microsoft.AspNetCore.Identity;

namespace Prefeitura.Geral.Negocio.Dominio
{
    public class UsuarioRole : IdentityUserRole<int>
    {

        public virtual Usuario Usuario { get; set; }
        public virtual Role Role { get; set; }
    }
}
