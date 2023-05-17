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

namespace WpfApp1
{
    /// <summary>
    /// Логика взаимодействия для Window1.xaml
    /// </summary>
    public partial class Window1 : Window
    {
        private List<string> stringList = new List<string>();

        public Window1()
        {
            InitializeComponent();
            stringList = ConvertJ.Deserialization<List<string>>("типзаписи.json");
        }

        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
            stringList.Add(textBox.Text);
            ConvertJ.Serialization(stringList, "типзаписи.json");
            this.Close();
        }
    }
}
