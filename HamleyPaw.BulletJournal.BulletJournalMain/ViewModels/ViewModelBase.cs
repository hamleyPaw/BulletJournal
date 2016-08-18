using System;
using System.ComponentModel;
using System.Linq.Expressions;

namespace HamleyPaw.BulletJournal.BulletJournalMain.ViewModels
{
    public abstract class ViewModelBase : INotifyPropertyChanged
    {
        public ViewModelBase()
        {

        }

        #region INotifyPropertyChanged Members

        public event PropertyChangedEventHandler PropertyChanged;

        protected virtual void OnPropertyChanged(string propertyName)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
            }
        }

        protected void OnPropertyChanged(Expression<Func<object>> expression)
        {
            if (PropertyChanged != null)
            {
                OnPropertyChanged(PropertyNameHelper.GetPropertyName(expression));
            }
        }

        #endregion INotifyPropertyChanged Members
    }
}
