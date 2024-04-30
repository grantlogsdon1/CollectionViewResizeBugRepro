using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;

namespace CollectionViewResizeBugRepro
{
    public partial class MainPageViewModel : ObservableObject
    {
        double defaultHeight = 100;
        double newHeight = 150;
        public List<int> TestCollection { get; set; } = [1, 1, 1];

        [ObservableProperty]
        double btnHeight;

        public MainPageViewModel()
        {
            BtnHeight = defaultHeight;
        }

        [RelayCommand]
        private void ChangeHeight()
        {
            if (BtnHeight == defaultHeight)
            {
                BtnHeight = newHeight;
            }
            else
            {
                BtnHeight = defaultHeight;
            }
        }
    }
}
