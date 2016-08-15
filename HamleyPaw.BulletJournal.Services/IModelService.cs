using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HamleyPaw.BulletJournal.Models;

namespace HamleyPaw.BulletJournal.Services
{
    public interface IModelService
    {
        void CommitNewTopic(ITopic topic);
        IEnumerable<ITopic> GetTopicsForDay(DateTime day);
    }
}
