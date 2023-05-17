using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Runtime.Remoting.Channels;
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

namespace WpfApp1
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        int player = 0;
        int nothing;
        int bott;
        public MainWindow()
        {
            InitializeComponent();
            _1.IsEnabled = false;
            _2.IsEnabled = false;
            _3.IsEnabled = false;
            _4.IsEnabled = false;
            _5.IsEnabled = false;
            _6.IsEnabled = false;
            _7.IsEnabled = false;
            _8.IsEnabled = false;
            _9.IsEnabled = false;
        }
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            bott = 2;
            if (player % 2 == 0)
            {
                Button senderb = (Button)sender;
                senderb.Content = "X";
                senderb.IsEnabled = false;
                checkWin();
            }
            else
            {
                Button senderbb = (Button)sender;
                senderbb.Content = "O";
                senderbb.IsEnabled = false;
                checkWin();
            }
        }
        private void bot()
        {
            Button[] a = {_1, _2, _3, _4, _5, _6, _7, _8, _9};
            Button g = (a[new Random().Next(0, a.Length)]);
            while (g.Content == "X" || g.Content == "O")
            {
                g = (a[new Random().Next(0, a.Length)]);
            }

            if (player % 2 == 0)
            {
                g.Content = "O";
                g.IsEnabled = false;
                checkWin();
            }
            else
            {
                g.Content = "X";
                g.IsEnabled = false;
                checkWin();
            }
        }
        private void checkWin()
        {
            if (_1.Content == "X" && _1.Content == _2.Content && _2.Content == _3.Content || _1.Content == "O" && _1.Content == _2.Content && _2.Content == _3.Content)
            {
                MessageBox.Show("Победа " + _1.Content);
                _1.IsEnabled = false;
                _2.IsEnabled = false;
                _3.IsEnabled = false;
                _4.IsEnabled = false;
                _5.IsEnabled = false;
                _6.IsEnabled = false;
                _7.IsEnabled = false;
                _8.IsEnabled = false;
                _9.IsEnabled = false;
                start.IsEnabled = true;
                player = player + 1;
                nothing = 3;
            }
            if (_4.Content == "X" && _4.Content == _5.Content && _5.Content == _6.Content || _4.Content == "O" && _4.Content == _5.Content && _5.Content == _6.Content)
            {
                MessageBox.Show("Победа " + _4.Content);
                _1.IsEnabled = false;
                _2.IsEnabled = false;
                _3.IsEnabled = false;
                _4.IsEnabled = false;
                _5.IsEnabled = false;
                _6.IsEnabled = false;
                _7.IsEnabled = false;
                _8.IsEnabled = false;
                _9.IsEnabled = false;
                start.IsEnabled = true;
                player = player + 1;
                nothing = 3;
            }
            if (_7.Content == "X" && _7.Content == _8.Content && _8.Content == _9.Content || _7.Content == "O" && _7.Content == _8.Content && _8.Content == _9.Content)
            {
                MessageBox.Show("Победа " + _7.Content);
                _1.IsEnabled = false;
                _2.IsEnabled = false;
                _3.IsEnabled = false;
                _4.IsEnabled = false;
                _5.IsEnabled = false;
                _6.IsEnabled = false;
                _7.IsEnabled = false;
                _8.IsEnabled = false;
                _9.IsEnabled = false;
                start.IsEnabled = true;
                player = player + 1;
                nothing = 3;
            }
            if (_1.Content == "X" && _1.Content == _4.Content && _4.Content == _7.Content || _1.Content == "O" && _1.Content == _4.Content && _4.Content == _7.Content)
            {
                MessageBox.Show("Победа " + _1.Content);
                _1.IsEnabled = false;
                _2.IsEnabled = false;
                _3.IsEnabled = false;
                _4.IsEnabled = false;
                _5.IsEnabled = false;
                _6.IsEnabled = false;
                _7.IsEnabled = false;
                _8.IsEnabled = false;
                _9.IsEnabled = false;
                start.IsEnabled = true;
                player = player + 1;
                nothing = 3;
            }
            if (_2.Content == "X" && _2.Content == _5.Content && _5.Content == _8.Content || _2.Content == "O" && _2.Content == _5.Content && _5.Content == _8.Content)
            {
                MessageBox.Show("Победа " + _2.Content);
                _1.IsEnabled = false;
                _2.IsEnabled = false;
                _3.IsEnabled = false;
                _4.IsEnabled = false;
                _5.IsEnabled = false;
                _6.IsEnabled = false;
                _7.IsEnabled = false;
                _8.IsEnabled = false;
                _9.IsEnabled = false;
                start.IsEnabled = true;
                player = player + 1;
                nothing = 3;
            }
            if (_3.Content == "X" && _3.Content == _6.Content && _6.Content == _9.Content || _3.Content == "O" && _3.Content == _6.Content && _6.Content == _9.Content)
            {
                MessageBox.Show("Победа " + _3.Content);
                _1.IsEnabled = false;
                _2.IsEnabled = false;
                _3.IsEnabled = false;
                _4.IsEnabled = false;
                _5.IsEnabled = false;
                _6.IsEnabled = false;
                _7.IsEnabled = false;
                _8.IsEnabled = false;
                _9.IsEnabled = false;
                start.IsEnabled = true;
                player = player + 1;
                nothing = 3;
            }
            if (_1.Content == "X" && _1.Content == _5.Content && _5.Content == _9.Content || _1.Content == "O" && _1.Content == _5.Content && _5.Content == _9.Content)
            {
                MessageBox.Show("Победа " + _1.Content);
                _1.IsEnabled = false;
                _2.IsEnabled = false;
                _3.IsEnabled = false;
                _4.IsEnabled = false;
                _5.IsEnabled = false;
                _6.IsEnabled = false;
                _7.IsEnabled = false;
                _8.IsEnabled = false;
                _9.IsEnabled = false;
                start.IsEnabled = true;
                player = player + 1;
                nothing = 3;
            }
            if (_3.Content == "X" && _3.Content == _5.Content && _5.Content == _7.Content || _3.Content == "O" && _3.Content == _5.Content && _5.Content == _7.Content)
            {
                MessageBox.Show("Победа " + _3.Content);
                _1.IsEnabled = false;
                _2.IsEnabled = false;
                _3.IsEnabled = false;
                _4.IsEnabled = false;
                _5.IsEnabled = false;
                _6.IsEnabled = false;
                _7.IsEnabled = false;
                _8.IsEnabled = false;
                _9.IsEnabled = false;
                start.IsEnabled = true;
                player = player + 1;
                nothing = 3;
            }
            if (nothing != 3 && _1.IsEnabled == false && _2.IsEnabled == false && _3.IsEnabled == false && _4.IsEnabled == false && _5.IsEnabled == false && _6.IsEnabled == false && _7.IsEnabled == false && _8.IsEnabled == false && _9.IsEnabled == false)
            {
                MessageBox.Show("Ничья");
                start.IsEnabled = true;
                player = player + 1;
                nothing = 3;
            }
            if (nothing != 3 && bott == 2)
            {
                bott = 1;
                bot();
            }
        }
        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            start.IsEnabled = true;
            _1.IsEnabled = true;
            _2.IsEnabled = true;
            _3.IsEnabled = true;
            _4.IsEnabled = true;
            _5.IsEnabled = true;
            _6.IsEnabled = true;
            _7.IsEnabled = true;
            _8.IsEnabled = true;
            _9.IsEnabled = true;
            _1.Content = " ";
            _2.Content = " ";
            _3.Content = " ";
            _4.Content = " ";
            _5.Content = " ";
            _6.Content = " ";
            _7.Content = " ";
            _8.Content = " ";
            _9.Content = " ";
            start.IsEnabled = false;
            nothing = 2;
        }
    }
}
