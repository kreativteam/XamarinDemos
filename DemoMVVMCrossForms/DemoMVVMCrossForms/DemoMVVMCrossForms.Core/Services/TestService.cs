namespace DemoMVVMCrossForms.Core.Services
{
    public class TestService : ITestService
    {
        private string _halloWelt;

        public string HalloWelt
        {
            get
            {

                return "asdio";
            }
            set
            {

                _halloWelt = value;
            }
        }
    }
}
