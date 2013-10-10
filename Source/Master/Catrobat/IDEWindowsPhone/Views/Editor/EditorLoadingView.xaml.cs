﻿using System.Windows;
using Catrobat.Core.Services;
using Catrobat.IDEWindowsPhone.Views.Editor.Sprites;
using Microsoft.Phone.Controls;

namespace Catrobat.IDEWindowsPhone.Views.Editor
{
    public partial class EditorLoadingView : PhoneApplicationPage
    {
        public EditorLoadingView()
        {
            InitializeComponent();
            Loaded += OnLoaded;
        }

        private void OnLoaded(object sender, RoutedEventArgs routedEventArgs)
        {
            ServiceLocator.NavigationService.NavigateTo(typeof(SpritesView));
            ServiceLocator.NavigationService.RemoveBackEntry();
        }
    }
}