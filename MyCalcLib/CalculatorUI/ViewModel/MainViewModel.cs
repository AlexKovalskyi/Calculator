using System;
using CalculatorLib.Core;
using System.Windows.Input;
using CalculatorLib.CommonTypes;
using CalculatorLib.IOServices;
using System.Diagnostics;

namespace CalculatorUI.ViewModel
{
	public class MainViewModel : MainViewModelBase
	{
		private string expression;
		public MainViewModel()
		{
			ClickCommand = new Command(GetBtnValue);
			ResultCommand = new Command(GetResult);
		}
		public string Expression
		{
			get { return expression; }
			set
			{
				expression = value;
				OnPropertyChanged(nameof(Expression));
			}
		}

		public ICommand ClickCommand { get; private set; }
		public ICommand ResultCommand { get; private set; }

		public void GetBtnValue(object parameter)
		{
			if (parameter == null)
			{
				throw new ArgumentException(nameof(GetBtnValue), "Wrong parameter.");
			}
			else if (parameter.ToString() == "C")
			{
				Expression = string.Empty;
			}
			else if (parameter != null)
			{
				Expression += parameter;
			}
		}

		public void GetResult(object parameter)
		{
			Arguments arguments;
			OperationType operation;
			Calculator calc = new Calculator();
			UIInputService inpuService = new UIInputService(expression);
			arguments = inpuService.ReadArgs();

			Debug.WriteLine(arguments);
			operation = inpuService.ReadOperations();

			Debug.WriteLine(operation);
			Expression = calc.GetFunk(operation).Invoke(arguments).ToString();
		}
	}
}
