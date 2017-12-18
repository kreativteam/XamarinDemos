using MvvmCross.Core.ViewModels;
using MvvmCross.Platform.Logging;
using MvvmCross.Platform.Platform;
using MvvmCross.Uwp.Platform;
using Windows.UI.Xaml.Controls;

namespace DemoMVVMCrossForms.UWP
{
    public class Setup : MvxWindowsSetup
    {
        public Setup(Frame rootFrame) : base(rootFrame)
        {
        }

        protected override MvxLogProviderType GetDefaultLogProviderType()
            => MvxLogProviderType.None;

        protected override IMvxApplication CreateApp()
        {
            return new Core.App();
        }

        protected override IMvxTrace CreateDebugTrace()
        {
            return new DebugTrace();
        }
    }
}
