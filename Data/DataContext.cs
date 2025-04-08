using Microsoft.EntityFrameworkCore;

namespace Loja.Data
{
    public class DataContext(DbContextOptions<DataContext> options) : DbContext(options)
    {
    }
}
