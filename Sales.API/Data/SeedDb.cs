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
        }

        private async Task CheckCategoriesAsync()
        {
            if (!_context.Categories.Any())
            {
                _context.Categories.Add(new Category { Name = "Abarrotes" });
                _context.Categories.Add(new Category { Name = "Alimentos Preparados" });
                _context.Categories.Add(new Category { Name = "Automedicación" });
                _context.Categories.Add(new Category { Name = "Bebidas" });
                _context.Categories.Add(new Category { Name = "Bebidas Alcohólicas" });
                _context.Categories.Add(new Category { Name = "Botanas" });
                _context.Categories.Add(new Category { Name = "Dulcería" });
                _context.Categories.Add(new Category { Name = "Frutas y Verduras" });
                _context.Categories.Add(new Category { Name = "Harinas y Pan" });
                _context.Categories.Add(new Category { Name = "Helados" });
                _context.Categories.Add(new Category { Name = "Higiene Personal" });
                _context.Categories.Add(new Category { Name = "Lácteos" });
                _context.Categories.Add(new Category { Name = "Otros Productos" });
                _context.Categories.Add(new Category { Name = "Productos de Limpieza" });
                _context.Categories.Add(new Category { Name = "Productos Enlatados" });
                _context.Categories.Add(new Category { Name = "Uso Doméstico" });

                await _context.SaveChangesAsync();
            }
        }
    }
}
