using System.Collections.ObjectModel;
using System.Linq;
using System.Windows;
using SimpleTodoList.Domain.Models;
using SimpleTodoList.Logic;

namespace SimpleTodoList
{
    /// <summary>
    ///     Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private readonly ITodoItemsService _todoItemsService;

        public MainWindow(ITodoItemsService todoItemsService)
        {
            InitializeComponent();
            _todoItemsService = todoItemsService;
            FillTodoItemsList();
        }

        private ObservableCollection<TodoItem> TodoItems { get; set; }

        private void FillTodoItemsList()
        {
            var items = _todoItemsService.GetTodoItems();
            if (items.Success)
            {
                TodoItems = new ObservableCollection<TodoItem>(items.Value.ToList());
                itemsLv.ItemsSource = TodoItems;
            }
            else
            {
                errorLb.Content = items.Error;
                errorLb.Visibility = Visibility.Visible;
            }
        }
    }
}