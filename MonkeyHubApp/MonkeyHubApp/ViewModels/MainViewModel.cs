using System.Threading.Tasks;
using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace MonkeyHubApp.ViewModels
{
    public class MainViewModel : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(propertyName)));
        }

        protected bool SetProperty([CallerMemberName] string propertyName = null)
        {
            OnPropertyChanged(propertyName);

            return true;
        }

        private string _descricao;

        public string Descricao
        {
            get { return _descricao; }
            set
            {
                _descricao = value;
                OnPropertyChanged();
            }
        }


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
