using BusinessObjects.Models;
using Services.Rooms;
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
using System.Windows.Shapes;

namespace RentAppForm.View
{
    /// <summary>
    /// Interaction logic for RoomView.xaml
    /// </summary>
    public partial class RoomView : Window
    {
        private IRoomService roomService = null;
        public static string SetRoomID = null;
        public RoomView()
        {
            InitializeComponent();
            roomService = new RoomService();

            dtg_roomsDataGrid.ItemsSource = roomService.GetAllRooms();
        }

        private void btnBacktoMenu_Click(object sender, RoutedEventArgs e)
        {
            var adminManagement = new ManagementView();
            adminManagement.Show();
            Close();
        }

        private void RoomForm_Loaded(object sender, RoutedEventArgs e)
        {
        }

        private void btnAdd_Click(object sender, RoutedEventArgs e)
        {

        }

        private void btnEdit_Click(object sender, RoutedEventArgs e)
        {
            
            var RoomDetailView = new RoomDetailView();
            RoomDetailView.Show();

            Close();
        }

        private void btnRemove_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
