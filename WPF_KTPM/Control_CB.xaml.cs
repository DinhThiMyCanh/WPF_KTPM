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
    /// Interaction logic for Control_CB.xaml
    /// </summary>
    public partial class Control_CB : Window
    {
        public Control_CB()
        {
            InitializeComponent();
        }
        private void btnDangky_Click(object sender, RoutedEventArgs e)
        {
            string gt = "Nam";
            if (rdNu.IsChecked == true)
                gt = "Nữ";
            string sothich = "";
            if (chkThethao.IsChecked == true)
                sothich = sothich + chkThethao.Content;
            if (chkAmnhac.IsChecked == true)
                sothich = sothich + "\n" + chkAmnhac.Content;
            if (chkDoctruyen.IsChecked == true)
                sothich = sothich + "\n" + chkDoctruyen.Content;

            string qq = "";
            qq = cboQuequan.Text;

            string dsmh = "";
            foreach (ListBoxItem item in lstDSMH.SelectedItems)
                dsmh = dsmh + item.Content + "\n";

            MessageBox.Show("Họ và tên:" + txtTen.Text + "\n" + "Tuổi:" + txtTuoi.Text +
                "Giới tính:" + gt + "\n" + "Sở thích:" + sothich +
                "\n" + "Quê quán:" + qq + "\n" + "Danh sách môn học:" + dsmh);
        }
    }
}
