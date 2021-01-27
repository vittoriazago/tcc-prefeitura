using Microsoft.EntityFrameworkCore;
using System.Linq;
using System.Threading.Tasks;

namespace Prefeitura.Negocio
{
    public static class Extensoes
    {

        public static async Task<(int, IQueryable<T>)> Paginacao<T>(this IQueryable<T> lista,
            int numeroPagina = 1,
            int? tamanhoPagina = null)
        {
            var quantidadeTotal = await lista.CountAsync();
            if (tamanhoPagina.HasValue)
            {
                if (numeroPagina > 1)
                    lista = lista.Skip((numeroPagina - 1) * tamanhoPagina.Value);

                lista = lista.Take(tamanhoPagina.Value);
            }
            return (quantidadeTotal, lista);
        }

    }
}
