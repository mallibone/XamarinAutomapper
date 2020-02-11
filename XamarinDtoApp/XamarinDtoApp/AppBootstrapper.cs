using AutoMapper;
using XamarinDtoApp.Models;
using XamarinDtoApp.ViewModels;

namespace XamarinDtoApp
{
    public static class AppBootstrapper
    {
        public static IMapper CreateMapper()
        {
            var mapperConfiguration = new MapperConfiguration(cfg =>
            {
                cfg.CreateMap<Note, NoteViewModel>()
                    .ForMember(n => n.ExecuteReset, opt => opt.Ignore())
                    .ForMember(n => n.ExecuteStore, opt => opt.Ignore())
                    .ReverseMap();
            });

            return mapperConfiguration.CreateMapper();
        }
    }
}
