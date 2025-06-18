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

namespace alphahotel.Widows
{
    /// <summary>
    /// Логика взаимодействия для Autorizaation.xaml
    /// </summary>
    public partial class Autorizaation : Window
    {
        //alphahotelContext db = new alphahotelContext();
        int attemtionCoun = 0;
        public Autorizaation()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            if (string.IsNullOrEmpty(TbLogin.Text))
            {
                MessageBox.Show("Вы не ааели логин");
                TbLogin.Focus();
            }
            else if (string.IsNullOrEmpty(TbPassword.Text))
            {
                MessageBox.Show("Вы не ввели пароль");
                TbPassword.Focus();
            }

        
        }

        private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void BtnLogin_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
