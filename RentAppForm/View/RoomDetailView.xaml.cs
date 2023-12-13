using Services.Rooms;
using System;
using System.Collections.Generic;
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
    /// Interaction logic for RoomDetailView.xaml
    /// </summary>
    public partial class RoomDetailView : Window
    {
        private IRoomService roomService;
        public RoomDetailView()
        {
            InitializeComponent();
            roomService = new RoomService();
        }
    }
}
