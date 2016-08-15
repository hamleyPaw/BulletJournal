using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using HamleyPaw.BulletJournal.Common;

namespace HamleyPaw.BulletJournal.Models
{
    public interface ITaskInstant
    {
        //int TaskInstantId { get; set; }

        //int TopicTaskId { get; set; }

        long InstantTicks { get; set; }

        TaskInstantType Type { get; set; }

        ITopicTask ParentTask { get; set; }

        string Text { get; set; }
    }
}
