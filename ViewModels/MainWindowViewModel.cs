﻿using CoreTest.ViewModels.Base;
using System;
using System.Collections.Generic;
using System.Text;

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
    }
}
