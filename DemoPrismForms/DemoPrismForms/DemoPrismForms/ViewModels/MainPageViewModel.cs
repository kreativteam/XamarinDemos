using Prism.Navigation;
using PropertyChanged;

namespace DemoPrismForms.ViewModels
{
    [AddINotifyPropertyChangedInterface]
    public class MainPageViewModel : ViewModelBase
    {
        public MainPageViewModel(INavigationService navigationService)
            : base(navigationService)
        {
            Title = "Main Page";
        }

        public string Text { get; set; } = "Ich bin Prism";
    }
}
