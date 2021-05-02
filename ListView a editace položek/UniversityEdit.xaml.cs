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

namespace ListView_a_editace_položek
{
    /// <summary>
    /// Interaction logic for UniversityEdit.xaml
    /// </summary>
    public partial class UniversityEdit : Window
    {
        bool IsUpdating { get; set; }

        public UniversityEdit()
        {
            InitializeComponent();
            DataContext = new University();
            IsUpdating = false;
        }

        public UniversityEdit(University u)
        {
            InitializeComponent();
            DataContext = u;
            IsUpdating = true;
        }

        private void AddButton_Click(object sender, RoutedEventArgs e)
        {
            if (IsUpdating == false)
            {
                University.AllUniversities.Add((University)DataContext);
            }
            this.Close();
        }
    }
}
