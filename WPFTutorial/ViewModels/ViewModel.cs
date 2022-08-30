using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace WPFTutorial.ViewModels
{
    /// <summary>
    /// Инфраструктурный компонент в мввм-е для работы с бизнес логикой приложения
    /// (колл в базу, колл на апи, всякие калькуляци)
    /// </summary>
    public abstract class ViewModel : INotifyPropertyChanged
    {
        /// <summary>
        /// Ивент который вызывается в дебрях Wpf-а
        /// нужен для обновления значение на УЮ строне или на строне вью модели
        /// </summary>
        public event PropertyChangedEventHandler? PropertyChanged;

        public void OnPropertyChanged([CallerMemberName] string name = "")
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(name));
        }

        /// <summary>
        /// Просто удобная обёртка для вызова ивента
        /// если значение объекта не меняется, то нет смысла вызывать
        /// например это не нужно при работе с коллекциями и командами (как правило)
        /// если этот метод не вызывать в пропах, то значение подтянится один раз при
        /// сете DataContext-а
        /// </summary>
        protected bool Set<T>(ref T field, T value, [CallerMemberName] string name = "")
        {
            if (EqualityComparer<T>.Default.Equals(field, value))
            {
                return false;
            }

            field = value;
            OnPropertyChanged(name);

            return true;
        }
    }
}
