using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using HamleyPaw.BulletJournal.Services;

namespace HamleyPaw.BulletJournal.BulletJournalMain.ViewModels
{
    public class MainViewModel : ViewModelBase
    {
        // Repsonsibility:
        // Main app control, start/stop.
        // Container for sub VM's

        // At present, this is restricted to a single sub-VM
        // the Day Planner

        private readonly DayPlannerViewModel _DayPlanner = new DayPlannerViewModel();

        public MainViewModel()
        {
            
        }

        public DayPlannerViewModel DayPlanner
        {
            get { return _DayPlanner; }
        }
    }
}
