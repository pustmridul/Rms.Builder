using Microsoft.EntityFrameworkCore;
using Rms.Builder.Entity;

namespace Rms.Builder
{
    public interface IAppDbContext
    {
        DbSet<Item> Items { get; }
    }
}
