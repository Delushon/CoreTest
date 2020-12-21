using CoreTest.Infrastructure.Commands;
using CoreTest.ViewModels.Base;
using System;
using System.Collections.Generic;
using System.Text;
using System.Windows;
using System.Windows.Input;

namespace CoreTest.ViewModels
{
    internal class MainWindowViewModel : ViewModel
    {
        #region Заголовок окна

        private string _Title = "Пробный Title";

        /// <summary>Заголовок окна</summary>
        public string Title
        {
            get => _Title;
            //set
            //{
            //    if (Equals(_Title, value)) return;
            //    _Title = value;
            //    OnPropertyChanged();
            //}
            set => Set(ref _Title, value);
        }

        #endregion

        #region Статус

        private string _Status = "Complete!";

        /// <summary>Status of window</summary>
        public string Status 
        { 
            get => _Status;
            set => Set(ref _Status, value); 
        }

        #endregion

        #region Commands


        #region CloseApplicationCommand
        public ICommand CloseApplicationCommand { get; }

        private void OnCloseApplicationCommandExecuted(object p)
        {
            Application.Current.Shutdown();
        }

        private bool CanCloseApplicationCommandExecute(object p) => true;

        #endregion

        #endregion

        public MainWindowViewModel()
        {
            #region Commands

            CloseApplicationCommand = new LambdaCommand(OnCloseApplicationCommandExecuted, CanCloseApplicationCommandExecute);

            #endregion

        }
    }
}
