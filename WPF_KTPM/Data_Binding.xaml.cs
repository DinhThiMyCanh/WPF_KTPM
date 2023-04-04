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
    /// Interaction logic for Data_Binding.xaml
    /// </summary>
    public partial class Data_Binding : Window
    {
        public Data_Binding()
        {
            InitializeComponent();
            Product A = new Product(){
                Id = 1,
                Name = "Quyển Sách"
            };
            this.DataContext = A;
        }
    }
}
