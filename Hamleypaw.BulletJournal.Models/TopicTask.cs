using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HamleyPaw.BulletJournal.Common;

namespace HamleyPaw.BulletJournal.Models
{
    public class TopicTask : ITopicTask
    {
        [StringLength(50)]
        public string Title { get; set; }

        public TopicTaskStatus TaskStatus { get; set; }

        public ITopic ParentTopic { get; set; }

        public IEnumerable<ITaskInstant> TaskInstants { get; set; }
    }
}
