using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HamleyPaw.BulletJournal.Entities
{
    public class BulletJournalEntitiesContext : DbContext
    {
        public DbSet<Topic> Topics { get; set; }
        public DbSet<TopicTask> TopicTasks { get; set; }
        public DbSet<TaskInstant> TaskInstants { get; set; }
    }
}
