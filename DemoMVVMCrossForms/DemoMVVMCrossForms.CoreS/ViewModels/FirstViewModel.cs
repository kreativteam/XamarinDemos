using MvvmCross.Core.ViewModels;
using PropertyChanged;

namespace DemoMVVMCrossForms.CoreS.ViewModels
{
    [AddINotifyPropertyChangedInterface]
    public class FirstViewModel : MvxViewModel
    {
        public string Hello { get; set; } = "Hallo Fabian";
    }
}
