using App4.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace App4.View
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class AddOrEditData : ContentPage
	{
		public AddOrEditData ()
		{
			InitializeComponent ();
		}

        private async void OnSaveClicked(object sender, EventArgs e)
        {
            var todoItem = (ItemsAttributes)BindingContext;
            await App.Database.SaveItemAsync(todoItem);
            await Navigation.PopAsync();
        }

        private async void OnDeleteClicked(object sender, EventArgs e)
        {
            var todoItem = (ItemsAttributes)BindingContext;
            await App.Database.DeleteItemAsync(todoItem);
            await Navigation.PopAsync();
        }

        private async void OnCancelClicked(object sender, EventArgs e)
        {
            await Navigation.PopAsync();
        }
    }
}