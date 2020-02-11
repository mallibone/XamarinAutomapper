using AutoMapper;
using System;
using Xamarin.Forms;
using XamarinDtoApp.Services;
using XamarinDtoApp.ViewModels;

namespace XamarinDtoApp
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();
            IMapper mapper = AppBootstrapper.CreateMapper();

            var mainPage = new NotePage(new NoteViewModel(mapper, new NoteService()));
            MainPage = mainPage;
        }

        protected override void OnStart()
        {
        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }
    }
}
