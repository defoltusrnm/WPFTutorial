using System;

namespace WPFTutorial.Commands
{
    public class ActionCommand : Command
    {
        private readonly Action<object?> _execute;
        private readonly Predicate<object?>? _canExecute;

        public ActionCommand(Action<object?> execute, Predicate<object?>? canExecute = null)
        {
            _execute = execute;
            _canExecute = canExecute;
        }

        public override bool CanExecute(object? parameter)
            => _canExecute?.Invoke(parameter) ?? true;

        public override void Execute(object? parameter)
            => _execute(parameter);
    }
}
