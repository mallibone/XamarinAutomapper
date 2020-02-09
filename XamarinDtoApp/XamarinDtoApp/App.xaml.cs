using AutoMapper;
using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using XamarinDtoApp.Models;
using XamarinDtoApp.Services;
using XamarinDtoApp.ViewModels;

namespace XamarinDtoApp
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            var mapperConfiguration = new MapperConfiguration(cfg =>
            {
                cfg.CreateMap<Note, NoteViewModel>()
                    .ReverseMap();
            });

            IMapper mapper = mapperConfiguration.CreateMapper();

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

    public class AppBootstrapper
    {
        public AppBootstrapper()
        {
            var mapperConfiguration = new MapperConfiguration(cfg =>
            {
                cfg.CreateMap<Models.Note, ViewModels.NoteViewModel>()
                    .ReverseMap();
            });
        }
    }
}
