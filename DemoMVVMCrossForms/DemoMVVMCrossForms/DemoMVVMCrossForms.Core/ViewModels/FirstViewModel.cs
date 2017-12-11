using DemoMVVMCrossForms.CoreS.Services;
using MvvmCross.Core.ViewModels;
using PropertyChanged;

namespace DemoMVVMCrossForms.CoreS.ViewModels
{
    [AddINotifyPropertyChangedInterface]
    public class FirstViewModel : MvxViewModel
    {

        public FirstViewModel(ITestService testService)
        {
            TestService = testService;

            Hello = TestService.HalloWelt;
        }

        public ITestService TestService { get; set; }
        public string Hello { get; set; }
    }
}
