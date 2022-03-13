using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace CVTest8.View
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class GroupedListView : ContentPage
       
    {
        public GroupedListView()
        {
            InitializeComponent();

            storePage.RefreshCommand = new Command(() =>
            {

            })
        }
    }
}