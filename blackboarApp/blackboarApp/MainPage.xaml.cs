using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace blackboarApp
{
	public partial class MainPage : ContentPage
	{
        public MainPage()
        {
            InitializeComponent();
            
		}

        protected async override void OnAppearing()
        {
            base.OnAppearing();

            Device.BeginInvokeOnMainThread(async () =>
            {
                RestUser client = new RestUser();
                var resulttoken = await client.Authorize();
                if (resulttoken != null)
                {
                    LabelChange.Text = resulttoken.access_token;
                }
            });
        }
    }
}
