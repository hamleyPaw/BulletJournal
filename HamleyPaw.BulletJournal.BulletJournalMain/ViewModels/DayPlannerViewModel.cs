using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HamleyPaw.BulletJournal.BulletJournalMain.ViewModels
{
    public class DayPlannerViewModel : ViewModelBase
    {
        // Resonsibility:
        // Control which list of topics is shown on the basis of selected day
        // Allow the user to change the selected day on the following basis
            // Forward one day
            // Back one day
            // Goto selected date

        // Pass the selected date to the Topic List VM (which will deal with getting the actual topics)

        private DateTime _CurrentDate;

        public DayPlannerViewModel()
        {
            
        }

        // Commands
        // NextDayCommand
        // PreviousDayCommand
        // SelectDayCommand

        // TopicListViewModel
    }
}
