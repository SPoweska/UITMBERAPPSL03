﻿using System;
using System.Threading.Tasks;
using System.Windows.Input;
using UITMBER.Services;
using UITMBER.Services.Authentication;
using Xamarin.Essentials;
using Xamarin.Forms;
using UITMBER.Models.Car;
using UITMBER.Services.Car;
using UITMBER.Services.Register;
using UITMBER.Services.Location;


namespace UITMBER.ViewModels
{
    public class AboutViewModel : BaseViewModel
    {

        public IAuthenticationService AuthService => DependencyService.Get<IAuthenticationService>();
        public ICarService CarService => DependencyService.Get<ICarService>();
        public IRegisterService _regService => DependencyService.Get<IRegisterService>();
        public ILocationService _locatService => DependencyService.Get<ILocationService>();

        public AboutViewModel()
        {
            Title = "About";
            OpenWebCommand = new Command(async () => await TestAsync());
        }

        public ICommand OpenWebCommand { get; }

        private async Task TestAsync()
        {
            try
            {
                var result = await AuthService.AuthenticateAsync(new Models.Authentication.AuthenticationRequest()
                {
                    Login = "test2@test.pl",
                    Password = "Sm1shn3"
                });
            }
            catch (Exception ex)
            {

               
            }
         
        }
    }
}