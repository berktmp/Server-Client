using System;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Configuration;

namespace SocketProgram.Models
{
    public class Brain : INotifyPropertyChanged
    {
        private bool _isLambOn; // to hold Lamb value
        private int _number; // to hold random number value

        //getter and setter for lamb
        public bool IsLambOn
        {
            get => _isLambOn;
            set => SetProperty(ref _isLambOn, value);
        }

        // getter and setter for number
        public int Number
        {
            get => _number;
            set => SetProperty(ref _number, value);
        }

        public event PropertyChangedEventHandler? PropertyChanged;

        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        //Generic function
        protected bool SetProperty<T>(ref T storage, T value, [CallerMemberName] string propertyName = null)
        {
            if (Equals(storage, value))
            {
                return false;
            }

            storage = value;
            OnPropertyChanged(propertyName);

            return true;
        }

    }
}