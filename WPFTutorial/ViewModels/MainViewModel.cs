using System.Collections.ObjectModel;
using System.Windows.Input;
using WPFTutorial.Commands;

namespace WPFTutorial.ViewModels
{
    public class MainViewModel : ViewModel
    {
        public MainViewModel()
        {
            Title = "Buttons grid";
        }
        
        private ObservableCollection<string> _text = new ();
        public ObservableCollection<string> Text { get => _text; set => Set(ref _text, value); }

        private string _title = string.Empty;
        public string Title { get => _title; set => Set(ref _title, value); }
        
        public ICommand AddLineCommand => new ActionCommand(_ => OnAddLine());

        private void OnAddLine()
        {
            string newLine = "AddedLine";
            Text.Add($"{newLine}{Text.Count}");
            OnPropertyChanged(nameof(Text));
        }
    }
}
