﻿using System.Windows.Input;
using Cirrious.MvvmCross.ViewModels;

namespace Navigation.Core.ViewModels
{
    public class MainViewModel : MvxViewModel
    {
        private string _parameterKey;

        public ICommand GoSimpleCommand
        {
            get { return new MvxRelayCommand(() => ShowViewModel<SimpleViewModel>()); }
        }

        public string ParameterKey
        {
            get { return _parameterKey; }
            set { _parameterKey = value; RaisePropertyChanged(() => ParameterKey); }
        }

        public ICommand GoParameterizedCommand
        {
            get { return new MvxRelayCommand(() => ShowViewModel<ParameterizedViewModel>(new ParameterizedViewModel.Parameters() { Key = ParameterKey } )); }
        }

        public ICommand GoAnonymousCommand
        {
            get { return new MvxRelayCommand(() => ShowViewModel<AnonymousViewModel>(new { key = ParameterKey })); }
        }

    }
}