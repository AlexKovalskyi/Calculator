using System;
using System.Windows.Input;

namespace CalculatorUI.ViewModel
{
	internal class Command : ICommand
	{
		private readonly Action<object> _execute;
		private readonly Predicate<object> _canExecute;

		public Command(Action<object> execute)
			: this(execute, null)
		{
		}

		public Command(Action<object> execute, Predicate<object> canExecute)
		{
			if (execute == null)
				throw new ArgumentNullException(nameof(execute), "Argument must not be null.");

			_execute = execute;
			_canExecute = canExecute;
		}

		public event EventHandler CanExecuteChanged
		{
			add { CommandManager.RequerySuggested += value; }
			remove { CommandManager.RequerySuggested -= value; }
		}

		public void Execute(object parameters)
		{
			_execute(parameters);
		}

		public bool CanExecute(object parameter)
		{
			var result = _canExecute == null ? true : _canExecute(parameter);

			return result;
		}
	}
}
