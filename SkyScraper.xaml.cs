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
using RoomLibrary;

namespace RoomExample
{
    /// <summary>
    /// Логика взаимодействия для SkyScraper.xaml
    /// </summary>
    public partial class SkyScraper : Window
    {
        Room room = new Room();
        Room.LivingRoom livingRoom = new Room.LivingRoom();
        Room.Office office = new Room.Office();
        public SkyScraper()
        {
            InitializeComponent();
        }

        private void Button1_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
