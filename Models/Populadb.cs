using Microsoft.AspNetCore.Builder;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace mvc.Models
{
    public static class Populadb
    {
        
        public static void IncluiDadosDb(IApplicationBuilder app)
        {
            IncluiDadosDb(app.ApplicationServices.GetRequiredService<AppDbContext>());
        }
        
        public static void IncluiDadosDb(AppDbContext context)
        {
            System.Console.WriteLine("Aplicando migrations...");
            context.Database.Migrate();
            if (!context.Produtos.Any())
            {
                System.Console.WriteLine("Criando dados...");

                context.Produtos.AddRange(
                    new Produto ("Luva Goleiro", "Futebol", 25 ),
                    new Produto ("Bola de Basquete", "Basquete", 15 ),
                    new Produto ("Bola de Futebol", "Futebol", 25.50M ),
                    new Produto ("Meias Grandes", "Futebol", 25 ),
                    new Produto ("Cesta Quadra", "Basquete", 14.69M )
                    );

                context.SaveChanges();
            }
        }
    }
}
