using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace Prefeitura.Persistencia
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
