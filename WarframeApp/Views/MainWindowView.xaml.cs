using System.ComponentModel;
using System.Windows;
using WarframeApp.ViewModel;

namespace WarframeApp.Views
{
    public partial class MainWindowView : Window
    {
        public MainWindowView()
        {
            InitializeComponent();
        }

        void MainWindow_Closing(object sender, CancelEventArgs e)
        {
            ((InventoryViewModel)(InventoryViewControl.DataContext)).SaveItems();
        }
    }
}
