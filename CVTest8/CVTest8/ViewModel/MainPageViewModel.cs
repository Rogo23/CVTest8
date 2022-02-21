using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;
using CVTest8.View;

namespace CVTest8.ViewModel
{
    
    class MainPageViewModel
    {
        public Command GoSimple { get; }
        public Command GoGroup { get; }
        public Command GoList { get; }
        
        public MainPageViewModel()
        {
            GoSimple = new Command(Simple);
            GoGroup = new Command(Group);
            GoList = new Command(List);
            
        }

        private async void Simple()
        {
            var navPage = new NavigationPage(new SimpleCollectionView());

            await Application.Current.MainPage.Navigation.PushAsync(navPage);
        }

        private async void Group()
        {
            var navPage = new NavigationPage(new GroupView());

            await Application.Current.MainPage.Navigation.PushAsync(navPage);
        }

        private async void List()
        {
            var navPage = new NavigationPage(new GroupedListView());

            await Application.Current.MainPage.Navigation.PushAsync(navPage);

        }
    }

}
