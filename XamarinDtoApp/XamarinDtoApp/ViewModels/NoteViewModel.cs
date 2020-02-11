using AutoMapper;
using ReactiveUI;
using ReactiveUI.Fody.Helpers;
using System;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Input;
using XamarinDtoApp.Services;

namespace XamarinDtoApp.ViewModels
{
    public class NoteViewModel : ReactiveObject
    {
        private readonly IMapper _mapper;
        private readonly NoteService _noteService;

        public NoteViewModel() { }

        public NoteViewModel(IMapper mapper, NoteService noteService)
        {
            _mapper = mapper ?? throw new System.ArgumentNullException(nameof(mapper));
            _noteService = noteService;

            ExecuteReset = ReactiveCommand.Create(() => Init());
            // Faking a store here...
            ExecuteStore = ReactiveCommand.CreateFromTask(() => 
                {
                    LastEditDate = DateTimeOffset.Now;
                    return Task.Delay(750);
                });
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
        [Reactive] public ICommand ExecuteReset { get; set; }
        [Reactive] public ICommand ExecuteStore { get; set; }
    }
}
