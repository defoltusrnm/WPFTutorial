using System;
using System.Windows.Input;

namespace WPFTutorial.Commands
{
    /// <summary>
    /// Инфраструктурный компонент в мввм-е для обработке пользовательского ввода
    /// почти у каждого контрола есть пропа Command и CommandParameter
    /// которые отвечают за их основной ивент
    /// </summary>
    public abstract class Command : ICommand
    {
        public event EventHandler? CanExecuteChanged
        {
            add => CommandManager.RequerySuggested += value;
            remove => CommandManager.RequerySuggested -= value;
        }

        public abstract bool CanExecute(object? parameter);

        public abstract void Execute(object? parameter);
    }
}
