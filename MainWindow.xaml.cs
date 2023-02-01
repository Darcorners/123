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
using System.Windows.Navigation;
using System.Windows.Shapes;
using RoomLibrary;

namespace RoomExample
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        Room room1 = new Room();
        Room room2 = new Room();
        Random rnd = new Random();
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Button2.IsEnabled = true;
            room1.RoomLenght = rnd.Next(2, 11);
            room1.RoomWidth = rnd.Next(2, 11);
            int numP = rnd.Next(1, 9);

            Label1.Content = room1.RoomLenght;
            Label2.Content = room1.RoomWidth;
            Label3.Content = numP;

            Label4.Content = room1.RoomPerimeter();
            Label5.Content = room1.RoomArea();
            Label6.Content = Math.Round(room1.PersonArea(numP),3);
        }

        private void Button2_Click(object sender, RoutedEventArgs e)
        {
            Button3.IsEnabled = true;
            room2.RoomLenght = Convert.ToDouble(TB1.Text);
            room2.RoomWidth = Convert.ToDouble(TB2.Text);
            int numP = Convert.ToInt32(TB3.Text);

            Label10.Content = room2.RoomPerimeter();
            Label11.Content = room2.RoomArea();
            Label12.Content = Math.Round(room2.PersonArea(numP), 3);
        }

        private void Button3_Click(object sender, RoutedEventArgs e)
        {
            Label21.Content = room1.RoomArea() + room2.RoomArea();
        }

        private void exit_Click(object sender, RoutedEventArgs e)
        {
            Application.Current.Shutdown();
        }
    }
}
