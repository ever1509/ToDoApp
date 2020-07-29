using System.Threading;
using System.Threading.Tasks;
using Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace Application.Common.Interfaces
{
    public interface IDbContext
    {
        DbSet<ToDoItem> ToDoItems { get;}

        Task<int> SaveChangesAsync(CancellationToken cancellationToken);
    }
}