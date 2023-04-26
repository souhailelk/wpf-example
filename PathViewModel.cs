using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using System;
using System.ComponentModel;
using System.Threading.Tasks;

namespace wpfApp
{

    internal class PathViewModel : ObservableObject
    {
        public PathViewModel()
        {
            ChangePathCommand = new RelayCommand(ChangePathContent);
            path = "noting";
        }
        private string path;
        public string Path
        {
            get { return path; }
            set
            {
                if (path != value)
                {
                    path = value;
                    OnPropertyChanged(nameof(Path));
                }
            }
        }

        public RelayCommand ChangePathCommand { get; }

        private void ChangePathContent() => Path = $"{Guid.NewGuid()}";

    }
}
