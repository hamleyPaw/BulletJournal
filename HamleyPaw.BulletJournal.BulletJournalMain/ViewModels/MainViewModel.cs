using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HamleyPaw.BulletJournal.Services;

namespace HamleyPaw.BulletJournal.BulletJournalMain.ViewModels
{
    public class MainViewModel
    {
        private IModelService _ModelService;

        public MainViewModel(IModelService modelService)
        {
            _ModelService = modelService;
        }
    }
}
