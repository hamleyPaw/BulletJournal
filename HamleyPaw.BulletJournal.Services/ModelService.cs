using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HamleyPaw.BulletJournal.Models;

namespace HamleyPaw.BulletJournal.Services
{
    public class ModelService : IModelService
    {
        //CTOR
        // Dependencies
        // Entity Service
        private IEntityService _EntityService;

        public ModelService(IEntityService entityService)
        {
            if (entityService == null)
            {
                throw new ArgumentNullException("entityService");
            }

            _EntityService = entityService;
        }

        public void CommitNewTopic(ITopic topic)
        {
            if (topic == null)
            {
                throw new ArgumentNullException("topic");
            }

            // Translate the supplied topic to an Entity object
            // Commit to the DB
            // EntityService.Topics

            // Entity Service.SaveChanges();

            // Get ID from Entity


            // Set the ID on the supplied object.
            topic.TopicId = 1;
        }

        public IEnumerable<ITopic> GetTopicsForDay(DateTime day)
        {
            return null;
        }
    }
}
