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
                    .ForMember(vm => vm.ExecuteReset, opt => opt.Ignore())
                    .ForMember(vm => vm.ExecuteStore, opt => opt.Ignore());
                cfg.CreateMap<NoteViewModel, Note>();
            });

            return mapperConfiguration.CreateMapper();
        }
    }
}
