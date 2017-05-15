using System;
using Xamarin.Forms;
using System.Threading.Tasks;

namespace MonkeyHubApp.ViewModels
{
	public class SearchViewModel : BaseViewModel
	{
		private string _searchTerm;

		public string SearchTerm
		{
			get { return _searchTerm; }
			set
			{
				if (SetProperty(ref _searchTerm, value)) SearchCommand.ChangeCanExecute();
			}
		}

		public Command SearchCommand { get; }

		public SearchViewModel()
		{
			SearchCommand = new Command(ExecuteSearchCommand, CanExecuteSearchCommand);
		}

		async void ExecuteSearchCommand()
		{
			await Task.Delay(1000);
			var resposta = await Application.Current.MainPage.DisplayAlert("MonkeyHubApp", 
                    		$"Você pesquisou por {SearchTerm}?", "Sim", "Não");

			if(resposta)
			{
				await Application.Current.MainPage.DisplayAlert("MonkeyHubApp", "Obrigado!", "OK");				
			}else{
				await Application.Current.MainPage.DisplayAlert("MonkeyHubApp", "De nada!", "OK");
			}

		}

		bool CanExecuteSearchCommand()
		{
			return !string.IsNullOrEmpty(SearchTerm);
		}
	}
}
