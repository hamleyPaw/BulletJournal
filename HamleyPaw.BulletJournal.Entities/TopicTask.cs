using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HamleyPaw.BulletJournal.Common;

namespace HamleyPaw.BulletJournal.Entities
{
    public class TopicTask
    {
        public int TopicTaskId { get; set; }

        public int TopicId { get; set; }

        [StringLength(50)]
        public string Title { get; set; }

        public TopicTaskStatus TaskStatus { get; set; }

        public Topic ParentTopic { get; set; }

        public Collection<TaskInstant> TaskInstants { get; set; }
    }
}
