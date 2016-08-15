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
    public class Topic
    {
        public int TopicId { get; set; }

        [StringLength(50)]
        public string Title { get; set; }

        [StringLength(150)]
        public string Description { get; set; }

        public string Notes { get; set; }

        public DateTime StartDate { get; set; }

        public TopicStatus Status { get; set; }

        public Collection<TopicTask> Tasks { get; set; }
    }
}
