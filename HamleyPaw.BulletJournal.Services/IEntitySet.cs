using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace HamleyPaw.BulletJournal.Services
{
    public interface IEntitySet<TEntity>
        where TEntity : class
    {
        TEntity ApplyCurrentValues(TEntity currentEntity);
        TEntity ApplyOriginalValues(TEntity originalEntity);
        T CreateObject<T>() where T : class, TEntity;
        TEntity CreateObject();
    }

    //public interface IEntitySet<TEntity> : IObjectSet<TEntity>
    //where TEntity : class
    //{
    //    TEntity ApplyCurrentValues(TEntity currentEntity);
    //    TEntity ApplyOriginalValues(TEntity originalEntity);
    //    T CreateObject<T>() where T : class, TEntity;
    //    TEntity CreateObject();
    //}
}
