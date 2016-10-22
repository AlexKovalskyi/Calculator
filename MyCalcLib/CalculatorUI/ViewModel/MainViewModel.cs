using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using CalculatorLib.Core;
using CalculatorLib.Interfaces;
using System.Windows.Media.Animation;
using System.Windows;
using System.Windows.Input;
using System.Text.RegularExpressions;

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
			if (parameter.ToString() == "C")
			{
				Expression = string.Empty;
			}
			else if (parameter != null)
			{
				Expression += parameter;
			}
			else
			{
				throw new ArgumentException();
			}
		}

		public void GetResult(object parameter)
		{



		}

	}
}
