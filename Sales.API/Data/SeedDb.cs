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
            await CheckCountriesAsync();
            await CheckCategoriesAsync();
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
                    Cities = new List<City>() {
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
                    Cities = new List<City>() {
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
                    Cities = new List<City>() {
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
                    Cities = new List<City>() {
                        new City() { Name = "Houston" },
                        new City() { Name = "San Antonio" },
                        new City() { Name = "Dallas" },
                        new City() { Name = "Austin" },
                        new City() { Name = "El Paso" },
                    }
                },
            }
                });
                await _context.SaveChangesAsync();
            }
        }

        private async Task CheckCategoriesAsync()
        {
            if (!_context.Categories.Any())
            {
                _context.Categories.Add(new Category
                {
                    Name = "Calzado",
                    ProdCategories = new List<ProdCategory>()
            {
                new ProdCategory()
                {
                    Name = "Calzado Deportivo",
                    Products = new List<Product>() {
                        new Product() { Name = "Chandál" },
                        new Product() { Name = "Gucci" },
                        new Product() { Name = "Prada" },
                        new Product() { Name = "Chevinong" },
                    }
                },                new ProdCategory()
                {
                    Name = "Calzado 1",
                    Products = new List<Product>() {
                        new Product() { Name = "Calzado 1" },
                        new Product() { Name = "Calzado 2" },
                        new Product() { Name = "Calzado 3" },
                        new Product() { Name = "Calzado 4" },
                    }
                },                new ProdCategory()
                {
                    Name = "Calzado 2",
                    Products = new List<Product>() {
                        new Product() { Name = "Calzado 1" },
                        new Product() { Name = "Calzado 2" },
                        new Product() { Name = "Calzado 3" },
                        new Product() { Name = "Calzado 4" },
                    }
                },                new ProdCategory()
                {
                    Name = "Calzado 3",
                    Products = new List<Product>() {
                        new Product() { Name = "Calzado 1" },
                        new Product() { Name = "Calzado 2" },
                        new Product() { Name = "Calzado 3" },
                        new Product() { Name = "Calzado 4" },
                    }
                },                new ProdCategory()
                {
                    Name = "Calzado 4",
                    Products = new List<Product>() {
                        new Product() { Name = "Calzado 1" },
                        new Product() { Name = "Calzado 2" },
                        new Product() { Name = "Calzado 3" },
                        new Product() { Name = "Calzado 4" },
                        new Product() { Name = "Calzado 5" },
                        new Product() { Name = "Calzado 26" },
                        new Product() { Name = "Calzado 37" },
                        new Product() { Name = "Calzado 48" },
                        new Product() { Name = "Calzado 19" },
                        new Product() { Name = "Calzado 22" },
                        new Product() { Name = "Calzado 31" },
                        new Product() { Name = "Calzado 41" },
                    }
                },                new ProdCategory()
                {
                    Name = "Calzado 5",
                    Products = new List<Product>() {
                        new Product() { Name = "Calzado 1" },
                        new Product() { Name = "Calzado 2" },
                        new Product() { Name = "Calzado 3" },
                        new Product() { Name = "Calzado 4" },
                        new Product() { Name = "Calzado 5" },
                        new Product() { Name = "Calzado 26" },
                        new Product() { Name = "Calzado 37" },
                        new Product() { Name = "Calzado 48" },
                        new Product() { Name = "Calzado 19" },
                        new Product() { Name = "Calzado 22" },
                        new Product() { Name = "Calzado 31" },
                        new Product() { Name = "Calzado 41" },
                    }
                },                new ProdCategory()
                {
                    Name = "Calzado 6",
                    Products = new List<Product>() {
                        new Product() { Name = "Calzado 1" },
                        new Product() { Name = "Calzado 2" },
                        new Product() { Name = "Calzado 3" },
                        new Product() { Name = "Calzado 4" },
                        new Product() { Name = "Calzado 5" },
                        new Product() { Name = "Calzado 26" },
                        new Product() { Name = "Calzado 37" },
                        new Product() { Name = "Calzado 48" },
                        new Product() { Name = "Calzado 19" },
                        new Product() { Name = "Calzado 22" },
                        new Product() { Name = "Calzado 31" },
                        new Product() { Name = "Calzado 41" },
                        new Product() { Name = "Calzado 1223" },
                        new Product() { Name = "Calzado 2444" },
                        new Product() { Name = "Calzado 3555" },
                        new Product() { Name = "Calzado 4666" },
                        new Product() { Name = "Calzado 7775" },
                        new Product() { Name = "Calzado 55726" },
                        new Product() { Name = "Calzado 757537" },
                        new Product() { Name = "Calzado 757548" },
                        new Product() { Name = "Calzado 757519" },
                        new Product() { Name = "Calzado 757522" },
                        new Product() { Name = "Calzado 757531" },
                        new Product() { Name = "Calzado 47571" },
                        new Product() { Name = "Calzado 1111" },
                        new Product() { Name = "Calzado 2222" },
                        new Product() { Name = "Calzado 3333" },
                        new Product() { Name = "Calzado 4444" },
                        new Product() { Name = "Calzado 5555" },
                        new Product() { Name = "Calzado 26666" },
                        new Product() { Name = "Calzado 37888" },
                        new Product() { Name = "Calzado 48222" },
                        new Product() { Name = "Calzado 19333" },
                        new Product() { Name = "Calzado 22444" },
                        new Product() { Name = "Calzado 31555" },
                        new Product() { Name = "Calzado 4166" },
                        new Product() { Name = "Calzado 177" },
                        new Product() { Name = "Calzado 2888" },
                        new Product() { Name = "Calzado 3999" },
                        new Product() { Name = "Calzado 4000" },
                        new Product() { Name = "Calzado 52111" },
                        new Product() { Name = "Calzado 265454" },
                        new Product() { Name = "Calzado 37655" },
                        new Product() { Name = "Calzado 48456" },
                        new Product() { Name = "Calzado 19554" },
                        new Product() { Name = "Calzado 225544" },
                        new Product() { Name = "Calzado 316565" },
                        new Product() { Name = "Calzado 41775" },
                    }
                },                new ProdCategory()
                {
                    Name = "Calzado 7",
                    Products = new List<Product>() {
                        new Product() { Name = "Calzado 1" },
                        new Product() { Name = "Calzado 2" },
                        new Product() { Name = "Calzado 3" },
                        new Product() { Name = "Calzado 4" },
                        new Product() { Name = "Calzado 5" },
                        new Product() { Name = "Calzado 26" },
                        new Product() { Name = "Calzado 37" },
                        new Product() { Name = "Calzado 48" },
                        new Product() { Name = "Calzado 19" },
                        new Product() { Name = "Calzado 22" },
                        new Product() { Name = "Calzado 31" },
                        new Product() { Name = "Calzado 41" },
                    }
                },                new ProdCategory()
                {
                    Name = "Calzado 8",
                    Products = new List<Product>() {
                        new Product() { Name = "Calzado 1" },
                        new Product() { Name = "Calzado 2" },
                        new Product() { Name = "Calzado 3" },
                        new Product() { Name = "Calzado 4" },
                        new Product() { Name = "Calzado 5" },
                        new Product() { Name = "Calzado 26" },
                        new Product() { Name = "Calzado 37" },
                        new Product() { Name = "Calzado 48" },
                        new Product() { Name = "Calzado 19" },
                        new Product() { Name = "Calzado 22" },
                        new Product() { Name = "Calzado 31" },
                        new Product() { Name = "Calzado 41" },
                    }
                },
                new ProdCategory()
                {
                    Name = "Ropa 1",
                    Products = new List<Product>() {
                        new Product() { Name = "Ropa 1" },
                        new Product() { Name = "Ropa 2" },
                        new Product() { Name = "Ropa 3" },
                        new Product() { Name = "Ropa 4" },
                        new Product() { Name = "Ropa 5" },
                        new Product() { Name = "Ropa 6" },
                        new Product() { Name = "Ropa 7" },
                        new Product() { Name = "Ropa 8" },
                        new Product() { Name = "Ropa 9" },
                        new Product() { Name = "Ropa 61" },
                        new Product() { Name = "Ropa 72" },
                        new Product() { Name = "Ropa 88" },
                    }
                },
            }
                });
                _context.Categories.Add(new Category
                {
                    Name = "Perfumería",
                    ProdCategories = new List<ProdCategory>()
            {
                new ProdCategory()
                {
                    Name = "Dulce",
                    Products = new List<Product>() {
                        new Product() { Name = "Dulce 1" },
                        new Product() { Name = "Dulce 2" },
                        new Product() { Name = "Dulce 3" },
                        new Product() { Name = "Dulce 4" },
                        new Product() { Name = "Dulce 5" },
                        new Product() { Name = "Dulce 6" },
                        new Product() { Name = "Dulce 7" },
                        new Product() { Name = "Dulce 8" },
                        new Product() { Name = "Dulce 9" },
                        new Product() { Name = "Dulce 61" },
                        new Product() { Name = "Dulce 72" },
                        new Product() { Name = "Dulce 88" },
                    }
                },
                new ProdCategory()
                {
                    Name = "Cítrico",
                    Products = new List<Product>() {
                        new Product() { Name = "Citrico 1" },
                        new Product() { Name = "Citrico 2" },
                        new Product() { Name = "Citrico 3" },
                        new Product() { Name = "Citrico 4" },
                        new Product() { Name = "Citrico 5" },
                        new Product() { Name = "Citrico 6" },
                        new Product() { Name = "Citrico 7" },
                        new Product() { Name = "Citrico 8" },
                        new Product() { Name = "Citrico 9" },
                        new Product() { Name = "Citrico 61" },
                        new Product() { Name = "Citrico 72" },
                        new Product() { Name = "Citrico 88" },
                    }
                },
            }
                });
                _context.Categories.Add(new Category
                {
                    Name = "Tecnología",
                    ProdCategories = new List<ProdCategory>()
            {
                new ProdCategory()
                {
                    Name = "Computadores",
                    Products = new List<Product>() {
                        new Product() { Name = "HP 1" },
                        new Product() { Name = "Lenovo1" },
                        new Product() { Name = "HP12" },
                        new Product() { Name = "Lenovo12" },
                        new Product() { Name = "HP14" },
                        new Product() { Name = "Lenovo13" },
                        new Product() { Name = "HP15" },
                        new Product() { Name = "Lenovo168" },
                        new Product() { Name = "HP17" },
                        new Product() { Name = "Lenovo14" },
                        new Product() { Name = "HP18" },
                        new Product() { Name = "Lenovo15" },
                        new Product() { Name = "HP19" },
                        new Product() { Name = "Lenovo16" },
                        new Product() { Name = "HP1244" },
                        new Product() { Name = "Lenovo17" },
                        new Product() { Name = "HP121" },
                        new Product() { Name = "Lenovo18" },
                        new Product() { Name = "HP111" },
                        new Product() { Name = "Lenovo19" },
                        new Product() { Name = "HP155" },
                        new Product() { Name = "Lenovo120" },
                        new Product() { Name = "HP1789" },
                        new Product() { Name = "Lenovo121" },

                    }
                },
                new ProdCategory()
                {
                    Name = "Celulares",
                    Products = new List<Product>() {
                        new Product() { Name = "Iphone1" },
                        new Product() { Name = "Iphone2" },
                        new Product() { Name = "Iphone3" },
                        new Product() { Name = "Iphone14" },
                        new Product() { Name = "Iphone15" },
                        new Product() { Name = "Iphone16" },
                        new Product() { Name = "Iphone71" },
                        new Product() { Name = "Iphone18" },
                        new Product() { Name = "Iphone19" },
                        new Product() { Name = "Iphone10" },
                        new Product() { Name = "Iphone11" },
                        new Product() { Name = "Iphone12" },
                        new Product() { Name = "Iphone13" },
                        new Product() { Name = "Iphone144" },
                        new Product() { Name = "Iphone155" },
                        new Product() { Name = "Iphone166" },
                        new Product() { Name = "Iphone177" },
                        new Product() { Name = "Iphone188" },
                        new Product() { Name = "Iphone199" },
                        new Product() { Name = "Iphone122" },
                        new Product() { Name = "Iphone1212" },
                        new Product() { Name = "Iphone1222" },
                        new Product() { Name = "Iphone1233" },
                        new Product() { Name = "Iphone1225" },
                    }
                },
            }
                });
                await _context.SaveChangesAsync();
            }
        }

    }
}