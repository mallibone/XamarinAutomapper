using System.ComponentModel;
using Xamarin.Forms;
using XamarinDtoApp.ViewModels;

namespace XamarinDtoApp
{
    // Learn more about making custom code visible in the Xamarin.Forms previewer
    // by visiting https://aka.ms/xamarinforms-previewer
    [DesignTimeVisible(false)]
    public partial class NotePage : ContentPage
    {
        public NotePage(NoteViewModel noteViewModel)
        {
            InitializeComponent();
            ViewModel = noteViewModel ?? throw new System.ArgumentNullException(nameof(noteViewModel));
            BindingContext = ViewModel;
        }

        public NoteViewModel ViewModel { get; }

        protected override void OnAppearing()
        {
            base.OnAppearing();
            ViewModel.Init();
        }
    }
}
