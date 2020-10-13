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

namespace Warehouse_b
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

       

        private void btnSubmit_Click(object sender, RoutedEventArgs e)
        {

            string username = txtUsername.Text;
            string paswoord = txtPaswoord.Text;
            if (txtUsername.Text == "" || txtPaswoord.Text == "")
            {
                MessageBox.Show("Please fill in User name and Pasword ");
            }

            using (WarehouseEntities cxt = new WarehouseEntities())
            {
                var checkcode = cxt.Paswoords.Where(p => p.UserName == username && p.UserPaswoord == paswoord).Count();
                if (checkcode == 1)
                {
                    
                }
                else
                {
                    MessageBox.Show("User name or Paswoord is not corect");
                }
            }

        }
    }
}
