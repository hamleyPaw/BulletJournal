using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HamleyPaw.BulletJournal.Common;

namespace HamleyPaw.BulletJournal.Models
{
    public interface ITopic
    {
        int? TopicId { get; set; }

        string Title { get; set; }

        string Description { get; set; }

        string Notes { get; set; }

        TopicStatus Status { get; set; }

        DateTime StartDate { get; set; }

        IEnumerable<ITopicTask> Tasks { get; set; }
    }
}
