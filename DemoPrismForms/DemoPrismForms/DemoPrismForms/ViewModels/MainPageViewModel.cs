using Prism.Navigation;

namespace DemoPrismForms.ViewModels
{
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
