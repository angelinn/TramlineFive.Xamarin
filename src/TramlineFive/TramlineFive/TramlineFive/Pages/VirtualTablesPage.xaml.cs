﻿using Rg.Plugins.Popup.Services;
using SkgtService.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TramlineFive.Pages.Popup;
using TramlineFive.Services;
using TramlineFive.ViewModels;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace TramlineFive.Pages
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class VirtualTablesPage : ContentPage
	{
        public MainViewModel MainViewModel { get; private set; } = new MainViewModel();

        public VirtualTablesPage ()
		{
			InitializeComponent ();
            BindingContext = MainViewModel;
		}

        protected override async void OnAppearing()
        {
            base.OnAppearing();
            // await VersionService.CheckForUpdates();
        }

        private async void OnCheckClicked(object sender, EventArgs e)
        {
            try
            {
                IEnumerable<Line> lines = await MainViewModel.LoadLinesAsync();

                ChooseLinePopup linesPickPopup = new ChooseLinePopup(lines);
                await PopupNavigation.PushAsync(linesPickPopup);
            }
            catch (Exception ex)
            {
                await DisplayAlert("Exception", ex.Message, "OK");
            }
        }
    }
}