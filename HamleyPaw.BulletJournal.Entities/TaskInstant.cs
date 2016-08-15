using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HamleyPaw.BulletJournal.Common;

namespace HamleyPaw.BulletJournal.Entities
{
    public class TaskInstant
    {
        public int TaskInstantId { get; set; }
        public int TopicTaskId { get; set; }
        public long InstantTicks { get; set; }
        public TaskInstantType Type { get; set; }
        public TopicTask ParentTask { get; set; }

        [StringLength(150)]
        public string Text { get; set; }
    }
}
