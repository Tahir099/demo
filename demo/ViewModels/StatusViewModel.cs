using demo.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Reflection;
using System.Text;

namespace demo.ViewModels
{
    public class StatusViewModel  :BaseViewModel
    {
     
        
        public StatusViewModel()
        {
            Title = "Status";
            Me = Services.StatusService.GetMyInfo();

            RecentUpdates = new ObservableCollection<Status>
               (Services.StatusService.GetUpdates());
        }

        private Me _me;
        public Me Me
        {
            get { return _me; }
            set { SetProperty(ref _me, value); }
        }

        private ObservableCollection<Status> _recentUpdates;
        public ObservableCollection<Status> RecentUpdates
        {
            get { return _recentUpdates; }
            set { SetProperty(ref _recentUpdates, value); }
        }

    }


}
