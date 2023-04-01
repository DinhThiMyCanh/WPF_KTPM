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

namespace WPF_KTPM
{
    /// <summary>
    /// Interaction logic for Rounter_Event.xaml
    /// </summary>
    public partial class Rounter_Event : Window
    {
        public Rounter_Event()
        {
            InitializeComponent();
        }

        private void StackPanel_Click(object sender, RoutedEventArgs e)
        {
            FrameworkElement feSource = e.Source as FrameworkElement;
            switch(feSource.Name)
            {
                case "btnYes":
                    MessageBox.Show("Sự kiện của nút Yes");
                    break;
                case "btnNo":
                    MessageBox.Show("Sự kiện của nút No");
                    break;
                case "btnCancel":
                    MessageBox.Show("Sự kiện của nút Cancel");
                    break;

            }    
        }
    }
}
