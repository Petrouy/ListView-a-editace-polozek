using System;
using System.Collections.Generic;
using System.ComponentModel;
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

namespace ListView_a_editace_položek
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            University.InitUniversities();
            University u = new University();
            DataContext = u;
        }


        private void Universities_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            University ui = (University)((sender as ListView).SelectedItem);
            DataContext = ui;
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            Universities.SelectedIndex = 0;
        }

        private void Universities_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            University ui = (University)((sender as ListView).SelectedItem);
            UniversityEdit ue = new UniversityEdit(ui);
            ue.ShowDialog();
        }

        private void AddButton_Click(object sender, RoutedEventArgs e)
        {
            UniversityEdit ue = new UniversityEdit();
            ue.ShowDialog();
        }
    }

}
