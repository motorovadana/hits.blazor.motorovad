using Microsoft.EntityFrameworkCore;
using TodoServerApp.Data.Interfaces;
using TodoServerApp.Data.Service;

namespace TodoServerApp.Data.Migrations
{
    public class MSSQLDataService(ApplicationDbContext context) : IDataService
    {
        public async Task<IEnumerable<TaskItem>> GetTaskItemsAsync()
        {
            return await context.TaskItems.ToArrayAsync();
        }
    }
}
