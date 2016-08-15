using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HamleyPaw.BulletJournal.Entities;
using HamleyPaw.BulletJournal.Services;

namespace HamleyPaw.BulletJournal.Services
{
    public class EntityService : IEntityService
    {
        private IConnectionProvider _ConnectionProvider;

        public EntityService(IConnectionProvider connectionProvider)
        {
            if (connectionProvider == null)
            {
                throw new ArgumentNullException("connectionProvider");
            }

            _ConnectionProvider = connectionProvider;
        }

        public IEntitySet<Topic> Topics { get; set; }
        public IEntitySet<TopicTask> TopicTasks { get; set; }
        public IEntitySet<TaskInstant> TaskInstants { get; set; }


        // =====


        //    public EntityWrapper(Server.Entities entities)
        //    {
        //        _Entities = entities;
        //    }

        //    public int SaveChanges()
        //    {
        //        return _Entities.SaveChanges();
        //    }

        //    public void Dispose()
        //    {
        //        _Entities.Dispose();
        //    }
        //}

        //private IEntitySet<WorkflowTemplate> _WorkflowTemplates;
        //public IEntitySet<WorkflowTemplate> WorkflowTemplates
        //{
        //    get
        //    {
        //        if (_WorkflowTemplates == null)
        //        {
        //            _WorkflowTemplates = new EntitySet<WorkflowTemplate>(_Entities.WorkflowTemplates);
        //        }

        //        return _WorkflowTemplates;
        //    }
        //}
    }
}
