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

namespace Decorator
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        Component sub;
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Tb1.Text = Convert.ToString(sub.Operation());
        }

        private void CheckBox_Checked(object sender, RoutedEventArgs e)
        {
            sub = new ConcreteDecoratorCheese(sub);
        }

        private void CheckBox_Checked_1(object sender, RoutedEventArgs e)
        {
            sub = new ConcreteDecoratorMushrooms(sub);
        }

        private void CheckBox_Checked_2(object sender, RoutedEventArgs e)
        {
            sub = new ConcreteDecoratorVegetables(sub);
        }

        private void CheckBox_Checked_3(object sender, RoutedEventArgs e)
        {
            sub = new ConcreteDecoratorSauce(sub);
        }

        private void RadioButton_Checked(object sender, RoutedEventArgs e)
        {
            sub = new ConcreteComponentWBread();
        }

        private void RadioButton_Checked_1(object sender, RoutedEventArgs e)
        {
            sub = new ConcreteComponentBBread();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            Tb1.Text = "";
            Chb1.IsChecked = false;
            Chb2.IsChecked = false;
            Chb3.IsChecked = false;
            Chb4.IsChecked = false;
            WBread.IsChecked = true;
        }
    }
}
