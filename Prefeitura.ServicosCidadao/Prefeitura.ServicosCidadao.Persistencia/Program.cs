using Microsoft.EntityFrameworkCore;
using System;

namespace Prefeitura.ServicosCidadao.Persistencia
{
    class Program
    {
        static void Main()
        {
            var contexto = new ContextoPrefeituraMigrations();

            try
            {
                contexto.Database.Migrate();
            }
            catch (Exception ex)
            {
                //todo: log
                throw ex;
            }
        }
    }
}
