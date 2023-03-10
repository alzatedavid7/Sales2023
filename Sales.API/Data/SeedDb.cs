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
                _context.Categories.Add(new Category { Name = "aceites" });
                _context.Categories.Add(new Category { Name = "dulces" });
                _context.Categories.Add(new Category { Name = "gaseosas" });
                _context.Categories.Add(new Category { Name = "jabones" });
                _context.Categories.Add(new Category { Name = "salsas" });
                await _context.SaveChangesAsync();
            }
        }
    }
}
