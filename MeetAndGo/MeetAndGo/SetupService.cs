using MeetAndGo.Database;
using Microsoft.EntityFrameworkCore;
using System.IO;

namespace MeetAndGo
{
    public class SetupService
    {
        public void Init(meetGoContext context)
        {
            context.Database.Migrate();
        }

        public void InsertData(meetGoContext context)
        {
            var path = Path.Combine(Directory.GetCurrentDirectory(), "Script", "script.sql");
            var query = File.ReadAllText(path);
            context.Database.ExecuteSqlRaw(query);
        }
    }
}
