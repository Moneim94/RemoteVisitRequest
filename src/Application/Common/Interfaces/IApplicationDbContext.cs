using Order.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace Order.Application.Common.Interfaces;

public interface IApplicationDbContext
{
    DbSet<TodoList> TodoLists { get; }

    DbSet<TodoItem> TodoItems { get; }
    DbSet<VisitOrder> VisitOrders { get; }
    DbSet<UserInfo> UserInfo { get; }

    Task<int> SaveChangesAsync(CancellationToken cancellationToken);
}
