using System;
using Prism.Navigation;
using Prism.Services;
using TestPrism.Models;

namespace TestPrism.ViewModels
{
    public class MainPageViewModel : ViewModelBase
    {
        private NetworkAuthData _networkAuthData;

        public MainPageViewModel(INavigationService navigationService, IPageDialogService pageDialogService,
                                IDeviceService deviceService)
           : base(navigationService, pageDialogService, deviceService)
        {
            Title = "Main Page";
        }

        public NetworkAuthData NetworkAuthData
        {
            get => _networkAuthData;
            set => SetProperty(ref _networkAuthData, value);
        }

        public override void OnNavigatingTo(INavigationParameters parameters)
        {
            // TODO: Implement your initialization logic
        }

        public override void OnNavigatedFrom(INavigationParameters parameters)
        {
            // TODO: Handle any final tasks before you navigate away
        }

        public override void OnNavigatedTo(INavigationParameters parameters)
        {
            switch (parameters.GetNavigationMode())
            {
                case NavigationMode.Back:
                    // TODO: Handle any tasks that should occur only when navigated back to
                    break;
                case NavigationMode.New:
                    // TODO: Handle any tasks that should occur only when navigated to for the first time
                    break;
            }

            // TODO: Handle any tasks that should be done every time OnNavigatedTo is triggered
            if (parameters.ContainsKey("ProfileData"))
            {
                NetworkAuthData = parameters["ProfileData"] as NetworkAuthData;
            }
        }

        public override void Destroy()
        {
            // TODO: Dispose of any objects you need to for memory management
        }
    }
}
