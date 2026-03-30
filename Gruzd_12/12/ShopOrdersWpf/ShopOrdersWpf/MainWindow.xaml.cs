using System.Collections.ObjectModel;
using System.Linq;
using System.Windows;
using System.Windows.Controls;

namespace ShopOrdersWpf
{
    public partial class MainWindow : Window
    {
        public ObservableCollection<Order> Orders { get; set; }

        public MainWindow()
        {
            InitializeComponent();

            Orders = new ObservableCollection<Order>
            {
                new Order { Id = 1, Client = "Иванов", Status = "Новый", Amount = 120.50m },
                new Order { Id = 2, Client = "Петров", Status = "В обработке", Amount = 300m },
                new Order { Id = 3, Client = "Сидоров", Status = "Выполнен", Amount = 999.99m }
            };

            DataContext = this;
        }

        private void New_Click(object sender, RoutedEventArgs e)
        {
            int newId = Orders.Any() ? Orders.Max(o => o.Id) + 1 : 1;
            Orders.Add(new Order
            {
                Id = newId,
                Client = "Новый клиент",
                Status = "Новый",
                Amount = 0m
            });
        }

        private void Edit_Click(object sender, RoutedEventArgs e)
        {
            if (OrdersGrid.SelectedItem is Order order)
            {
                order.Client += " (ред.)";
                OrdersGrid.Items.Refresh();
            }
            else
            {
                MessageBox.Show("Выберите заказ.");
            }
        }

        private void Delete_Click(object sender, RoutedEventArgs e)
        {
            if (OrdersGrid.SelectedItem is Order order)
            {
                Orders.Remove(order);
            }
            else
            {
                MessageBox.Show("Выберите заказ.");
            }
        }

        private void StatusFilter_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (OrdersGrid == null || StatusFilter == null || Orders == null)
                return; 

            if (StatusFilter.SelectedItem is ComboBoxItem item)
            {
                string status = item.Content.ToString();

                if (status == "Все")
                    OrdersGrid.ItemsSource = Orders;
                else
                    OrdersGrid.ItemsSource = Orders.Where(o => o.Status == status).ToList();
            }
        }


        private void SetStatusNew_Click(object sender, RoutedEventArgs e) => SetStatus("Новый");
        private void SetStatusProcessing_Click(object sender, RoutedEventArgs e) => SetStatus("В обработке");
        private void SetStatusDone_Click(object sender, RoutedEventArgs e) => SetStatus("Выполнен");

        private void SetStatus(string status)
        {
            if (OrdersGrid.SelectedItem is Order order)
            {
                order.Status = status;
                OrdersGrid.Items.Refresh();
            }
        }
    }
}
