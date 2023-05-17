using Newtonsoft.Json;
using System;
using System.Collections;
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

namespace WpfApp1
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private List<Zametka> allzam = new List<Zametka>();
        private List<string> tipList = new List<string>(); // Список для ComboBox "spisoc"
        private string currentDate;

        public MainWindow()
        {
            InitializeComponent();
            currentDate = data.Text;
            data.SelectedDate = DateTime.Now.Date;
            LoadData();
            UpdateDataGrid();
            LoadTipList(); // Загрузка списка типов
        }

        private void LoadData()
        {
            allzam = ConvertJ.Deserialization<List<Zametka>>("учет.json");
        }

        private void UpdateDataGrid()
        {
            var filteredZametki = allzam.Where(z => z.Date == currentDate).ToList();
            box.ItemsSource = filteredZametki;
            CalculateTotal();
        }

        private void SaveData()
        {
            ConvertJ.Serialization(allzam, "учет.json");
        }

        private void CalculateTotal()
        {
            int total = 0;
            foreach (Zametka zametka in allzam)
            {
                if (zametka.Action == false)
                {
                    total += zametka.Money;
                }
                if (zametka.Action == true)
                {
                    total -= zametka.Money;
                }
            }
            textBlockTotal.Text = "Итог: " + total.ToString();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            string nameValue = name.Text;
            string tipValue = spisoc.Text;
            int moneyValue = int.Parse(discription.Text);
            bool actionValue = moneyValue < 0;
            moneyValue = Math.Abs(moneyValue);

            var zam = new Zametka(nameValue, tipValue, currentDate, moneyValue, actionValue);
            allzam.Add(zam);
            SaveData();
            UpdateDataGrid();

            name.Text = "";
            discription.Text = "";
            spisoc.Text = "";
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            if (box.SelectedItem is Zametka selectedZametka)
            {
                string nameValue = name.Text;
                int moneyValue = Convert.ToInt32(discription.Text);
                string type = spisoc.Text;

                // Поиск индекса выбранной заметки в списке
                int selectedIndex = allzam.FindIndex(z => z == selectedZametka);

                selectedZametka.Name = nameValue;
                selectedZametka.Money = moneyValue;
                selectedZametka.Tip = type;

                // Изменение значения Action в зависимости от moneyValue
                if (moneyValue < 0)
                {
                    selectedZametka.Action = true; // Если moneyValue отрицательное, Action = true
                    selectedZametka.Money = Math.Abs(moneyValue);
                }
                else
                {
                    selectedZametka.Action = false; // Если moneyValue положительное или равно нулю, Action = false
                }

                allzam[selectedIndex] = selectedZametka;
                SaveData();
                UpdateDataGrid();

                name.Text = "";
                discription.Text = "";
                spisoc.Text = "";
                box.SelectedIndex = -1;
            }
        }


        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            if (box.SelectedItem is Zametka selectedZametka)
            {
                allzam.Remove(selectedZametka); // Удаление выбранной заметки из списка
                SaveData();
                UpdateDataGrid();

                name.Text = "";
                discription.Text = "";
            }
        }


        private void box_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (box.SelectedItem is Zametka selectedZametka)
            {
                name.Text = selectedZametka.Name;
                if (selectedZametka.Action)
                {
                    discription.Text = "-" + selectedZametka.Money.ToString();
                }
                else
                {
                    discription.Text = selectedZametka.Money.ToString();
                }
                spisoc.Text = selectedZametka.Tip;
            }
            else
            {
                name.Text = "";
                discription.Text = "";
            }
        }

        private void data_SelectedDateChanged(object sender, SelectionChangedEventArgs e)
        {
            currentDate = data.Text; // Преобразовываем выбранную дату в строку
            UpdateDataGrid();
        }

        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
            Window1 mainForm = new Window1();
            mainForm.Closed += MainForm_Closed; // Привязываем обработчик события Closed
            mainForm.Show();
        }

        private void MainForm_Closed(object sender, EventArgs e)
        {
            LoadTipList();
        }

        private void LoadTipList()
        {
            tipList = ConvertJ.Deserialization<List<string>>("типзаписи.json");
            spisoc.ItemsSource = tipList;
        }
    }
}