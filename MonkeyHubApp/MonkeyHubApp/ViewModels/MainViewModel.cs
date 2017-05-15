using System.Threading.Tasks;

namespace MonkeyHubApp.ViewModels
{
    public class MainViewModel : BaseViewModel
    {
        private string _descricao;

        public string Descricao
        {
            get { return _descricao; }
            set
            {
                SetProperty(ref _descricao, value);				
            }
        }

		//private string _titulo;

		//public string Titulo
		//{
		//	get { return _titulo; }
		//	set
		//	{
		//		SetProperty(ref _titulo, value);
		//	}
		//}


		public MainViewModel()
        {
            Descricao = "Olá mundo! Eu estou aqui!";

            Task.Delay(3000).ContinueWith(t => 
            {
                Descricao = "Meu texto mudou";              
            });
        }
    }
}
