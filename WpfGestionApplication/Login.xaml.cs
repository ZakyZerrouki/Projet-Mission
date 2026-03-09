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

namespace WpfGestionApplication
{
    /// <summary>
    /// Interaction logic for Login.xaml
    /// </summary>
    public partial class Login : Window
    {
        public Login()
        {
            InitializeComponent();
        }

        private void TextBox_TextChanged_Password(object sender, TextChangedEventArgs e)
        {

        }

        private void TextBox_TextChanged_Username(object sender, TextChangedEventArgs e)
        {

        }

        private void ButtonLogin_Click(object sender, RoutedEventArgs e)
        {

        }

        private void ButtonAnnuler_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erreur lors de la fermeture de la fenêtre : " + ex.Message,
                    "Erreur", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }
    }
}
