using System.ComponentModel;

namespace CalculatorUI.ViewModel
{
	public abstract class MainViewModelBase : INotifyPropertyChanged
	{
		public event PropertyChangedEventHandler PropertyChanged;

		protected virtual void OnPropertyChanged(string propName)
		{
			PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propName));
		}
	}
}
