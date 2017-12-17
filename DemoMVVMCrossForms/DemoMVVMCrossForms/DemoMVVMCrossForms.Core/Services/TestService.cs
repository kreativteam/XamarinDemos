namespace DemoMVVMCrossForms.Core.Services
{
    public class TestService : ITestService
    {
        private string _halloWelt;

        public string HalloWelt
        {
            get { return _halloWelt; }
            set
            {
                //TODO Call RESt
                _halloWelt = value;
            }
        }
    }
}
