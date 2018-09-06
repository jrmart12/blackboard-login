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
                var resulttoken = await client.Get<resultToken>("http://learn/api/public/v1/oauth2/authorizationcode");
                if (resulttoken != null)
                {
                    LabelChange.Text = resulttoken.result.client_id;
                }
            });
        }
    }
}
