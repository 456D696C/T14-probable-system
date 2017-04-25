﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


using Microsoft.Practices.Unity;

using Simple.TaskManagement.ViewModels;



namespace Simple.TaskManagement
{
    public class Locator
    {
        public AboutThisViewModel AboutThis { get; }
        public TaskListViewModel TaskList { get; }
        public TextSearchViewModel TextSearch { get; }
        public SearchResultViewModel SearchResult { get; }
        public NextTaskFactoryViewModel Factory { get; }
        public VisualNotificationSystemViewModel VisualNotifications { get; }

        public Locator()
        {
            var container = Bootstrapper.RegisterTypes(new UnityContainer());

            AboutThis = container.Resolve<AboutThisViewModel>();
            TaskList = container.Resolve<TaskListViewModel>();
            TextSearch = container.Resolve<TextSearchViewModel>();
            SearchResult = container.Resolve<SearchResultViewModel>();
            Factory = container.Resolve<NextTaskFactoryViewModel>();
            VisualNotifications = container.Resolve<VisualNotificationSystemViewModel>();


            container.Resolve<IClientService>().StartAsync().Wait();
  
        }
    }
}
