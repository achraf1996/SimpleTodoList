using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using SimpleTodoList.Domain.Models;
using SimpleTodoList.Domain.ViewModels;
using SimpleTodoList.Logic;

namespace SimpleTodoList
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private  readonly ITodoItemsService _todoItemsService;
        private TodoVm todoItemViewModel;

        public MainWindow(ITodoItemsService todoItemsService)
        {
            _todoItemsService = todoItemsService;
            todoItemViewModel = new TodoVm();
            FillTodoItemsList();
            DataContext = todoItemViewModel;
            InitializeComponent();
        }

        private void FillTodoItemsList()
        {
            var items= _todoItemsService.GetTodoItems();
            if(items.Success)
            {
                todoItemViewModel.TodoItems =  new ObservableCollection<TodoItem>(items.Value.ToList());
            }
            else
            {
            }
        }
    }
}
