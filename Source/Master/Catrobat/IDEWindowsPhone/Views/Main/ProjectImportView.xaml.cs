﻿using System.Windows.Navigation;
using Catrobat.IDEWindowsPhone.ViewModel.Main;
using Microsoft.Phone.Controls;
using Microsoft.Practices.ServiceLocation;

namespace Catrobat.IDEWindowsPhone.Views.Main
{
    public partial class ProjectImportView : PhoneApplicationPage
    {
        private readonly ProjectImportViewModel _viewModel = ServiceLocator.Current.GetInstance<ProjectImportViewModel>();

        public ProjectImportView()
        {
            InitializeComponent();
        }

        protected override void OnNavigatedFrom(NavigationEventArgs e)
        {
            _viewModel.ResetViewModelCommand.Execute(null);
            base.OnNavigatedFrom(e);
        }

        protected override void OnNavigatedTo(NavigationEventArgs e)
        {
            _viewModel.OnLoadCommand.Execute(NavigationContext);
        }
    }
}