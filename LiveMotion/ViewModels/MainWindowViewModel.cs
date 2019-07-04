
using LiveMotion.Models;
using System.Collections.ObjectModel;

namespace LiveMotion.ViewModels
{
    public class MainWindowViewModel : BaseViewModel
    {
        public MainWindowViewModel()
        {
            Presentations = new ObservableCollection<Presentations>()
            {
                new Presentations { id = "1", Title = "Test 1"},
                new Presentations { id = "2", Title = "Test 2"},
                new Presentations { id = "3", Title = "Test 3"},
                new Presentations { id = "4", Title = "Test 4"},
            };

        }

        private ObservableCollection<Presentations> _presentations;
        public ObservableCollection<Presentations> Presentations
        {
            get
            {
                return _presentations;
            }
            set
            {
                _presentations = value;
                OnPropertyChanged();
            }
        }
    }
}
