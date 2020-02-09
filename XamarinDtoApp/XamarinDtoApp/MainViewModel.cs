using AutoMapper;
using ReactiveUI;
using ReactiveUI.Fody.Helpers;
using System;
using System.Linq;
using System.Reactive.Threading.Tasks;
using XamarinDtoApp.Services;

namespace XamarinDtoApp
{
    internal class MainViewModel : ReactiveObject
    {
        private readonly IMapper _mapper;
        private readonly NoteService _noteService;

        public MainViewModel(IMapper mapper, NoteService noteService)
        {
            _mapper = mapper ?? throw new System.ArgumentNullException(nameof(mapper));
            _noteService = noteService;
        }

		public async void Init()
		{
			var note = (await _noteService.GetNotes()).First();
			_mapper.Map(note, this);
		}

        [Reactive] public string Title { get; set; }
        [Reactive] public string Content { get; set; }
        [Reactive] public DateTimeOffset CreationDate { get; set; }
        [Reactive] public DateTimeOffset LastEditDate { get; set; }
    }
}