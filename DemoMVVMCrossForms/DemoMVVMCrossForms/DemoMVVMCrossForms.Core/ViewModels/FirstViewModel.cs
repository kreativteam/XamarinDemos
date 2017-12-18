using DemoMVVMCrossForms.Core.Services;
using MvvmCross.Core.ViewModels;
using PropertyChanged;
using RestSharp;
using System;
using System.Diagnostics;

namespace DemoMVVMCrossForms.Core.ViewModels
{
    [AddINotifyPropertyChangedInterface]
    public class FirstViewModel : MvxViewModel
    {

        public FirstViewModel(ITestService testService)
        {
            TestService = testService;

            Hello = TestService.HalloWelt;

            Debug.WriteLine("Test");
            var client = new RestClient
            {
                BaseUrl = new Uri("http://127.0.0.1:53225")
            };

            var request = new RestRequest { Resource = "api/values" };

            IRestResponse response = client.Execute(request);

            Debug.WriteLine(response.Content);
        }

        public ITestService TestService { get; set; }
        public string Hello { get; set; }
    }
}
