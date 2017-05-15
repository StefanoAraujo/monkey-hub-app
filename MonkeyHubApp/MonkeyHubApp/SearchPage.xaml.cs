using System;
using System.Collections.Generic;

using Xamarin.Forms;
using MonkeyHubApp.ViewModels;

namespace MonkeyHubApp
{
	public partial class SearchPage : ContentPage
	{
		public SearchPage()
		{
			InitializeComponent();
			BindingContext = new SearchViewModel();
		}
	}
}
