using Sales.Shared.Entities;

namespace Sales.API.Data
{
    public class SeedDb
    {
        private readonly DataContext _context;

        public SeedDb(DataContext context)
        {
            _context = context;
        }

        public async Task SeedAsync()
        {
            await _context.Database.EnsureCreatedAsync();
            await CheckCategoriesAsync();
            await CheckCountriesAsync();
        }

        private async Task CheckCountriesAsync()
        {
            if (!_context.Countries.Any())
            {
                _context.Countries.Add(new Country
                {
                    Name = "Colombia",
                    States = new List<State>()
                    {
                      new State()
                      {
                          Name = "Antioquia",
                          Cities = new List<City>()
                          {
                             new City() { Name = "Medellín" },
                             new City() { Name = "Itagüí" },
                             new City() { Name = "Envigado" },
                             new City() { Name = "Bello" },
                             new City() { Name = "Rionegro" },
                          }
                      },
                       new State()
                       {
                          Name = "Bogotá",
                          Cities = new List<City>() 
                          {
                            new City() { Name = "Usaquen" },
                            new City() { Name = "Champinero" },
                            new City() { Name = "Santa fe" },
                            new City() { Name = "Useme" },
                            new City() { Name = "Bosa" },
                          }
                       },
                    }
                });

                _context.Countries.Add(new Country
                {
                    Name = "Estados Unidos",
                    States = new List<State>()
                    {
                       new State()
                       {
                          Name = "Florida",
                          Cities = new List<City>()
                          {
                            new City() { Name = "Orlando" },
                            new City() { Name = "Miami" },
                            new City() { Name = "Tampa" },
                            new City() { Name = "Fort Lauderdale" },
                            new City() { Name = "Key West" },
                          }
                       },
                       new State()
                       {
                          Name = "Texas",
                          Cities = new List<City>()
                          {
                             new City() { Name = "Houston" },
                             new City() { Name = "San Antonio" },
                             new City() { Name = "Dallas" },
                             new City() { Name = "Austin" },
                             new City() { Name = "El Paso" },
                          }
                       },
                    }
                });
            }

            await _context.SaveChangesAsync();


        }

        private async Task CheckCategoriesAsync()
        {
            if (!_context.Categories.Any())
            {
                _context.Categories.Add(new Category { Name = "Hogar" });
                _context.Categories.Add(new Category { Name = "Electroméstico" });
                _context.Categories.Add(new Category { Name = "Tecnología" });
                _context.Categories.Add(new Category { Name = "Botanas" });
                _context.Categories.Add(new Category { Name = "Juguetes" });
                _context.Categories.Add(new Category { Name = "Cosméticos" });
                _context.Categories.Add(new Category { Name = "Cuidado personal" });
                _context.Categories.Add(new Category { Name = "Deporte" });
                _context.Categories.Add(new Category { Name = "Despensa" });
                _context.Categories.Add(new Category { Name = "Dulcería" });
                _context.Categories.Add(new Category { Name = "Herramientas Y Ferretería" });
                _context.Categories.Add(new Category { Name = "Instrumentos Musicales" });
                _context.Categories.Add(new Category { Name = "Libros y Papeleria" });
                _context.Categories.Add(new Category { Name = "Limpieza" });
                _context.Categories.Add(new Category { Name = "Mascotas" });
                _context.Categories.Add(new Category { Name = "Moda y Accesorios" });
                _context.Categories.Add(new Category { Name = "Arte y Artesanías" });
                _context.Categories.Add(new Category { Name = "Carnes" });
                _context.Categories.Add(new Category { Name = "Mundo Bebes" });
                _context.Categories.Add(new Category { Name = "Panadería y Rpostería" });
                _context.Categories.Add(new Category { Name = "Ropa" });
                _context.Categories.Add(new Category { Name = "Salud y Bienestar" });
                _context.Categories.Add(new Category { Name = "Útiles Escolares" });
                _context.Categories.Add(new Category { Name = "Vehículos" });
                _context.Categories.Add(new Category { Name = "Verduras" });
                _context.Categories.Add(new Category { Name = "Vinos y Licores" });
                await _context.SaveChangesAsync();
            }
        }
    }
}
