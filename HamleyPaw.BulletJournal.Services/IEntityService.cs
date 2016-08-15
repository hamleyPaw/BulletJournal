using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HamleyPaw.BulletJournal.Entities;

namespace HamleyPaw.BulletJournal.Services
{
    public interface IEntityService
    {
        IEntitySet<Topic> Topics { get; set; }
        IEntitySet<TopicTask> TopicTasks { get; set; }
        IEntitySet<TaskInstant> TaskInstants { get; set; }

    }
}
