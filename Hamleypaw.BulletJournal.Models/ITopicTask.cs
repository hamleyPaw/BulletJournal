using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HamleyPaw.BulletJournal.Common;

namespace HamleyPaw.BulletJournal.Models
{
    public interface ITopicTask
    {
        string Title { get; set; }

        TopicTaskStatus TaskStatus { get; set; }

        ITopic ParentTopic { get; set; }

        IEnumerable<ITaskInstant> TaskInstants { get; set; }
    }
}
