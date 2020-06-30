using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Text;
using SimpleTodoList.Domain.Annotations;
using SimpleTodoList.Domain.Models;

namespace SimpleTodoList.Domain.ViewModels
{
    public class TodoVm :  INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;
        
        [NotifyPropertyChangedInvocator]
        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
        public ObservableCollection<TodoItem> Todoitems {get;set;}
    }
}
