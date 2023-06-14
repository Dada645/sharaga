using System;
using System.Collections.Generic;
using System.Windows;
using System.Windows.Controls;
using ClassLibrary1;

namespace WpfApp1
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        Zametka zam;
        List<Zametka> allzam = new List<Zametka>();
        int v;
        int c;

        public MainWindow()
        {
            InitializeComponent();
            data.DisplayDate = DateTime.Now;
            data.Text = DateTime.Now.ToString();
            allzam = ConvertJ.Deserialization<List<Zametka>>("заметки.json");
            foreach (Zametka same in allzam)
            {
                if (same.data == data.Text)
                {
                    box.Items.Add(same.name);
                }
            }
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            zam = new Zametka();
            zam.name = name.Text;
            zam.description = discription.Text;
            zam.data = data.Text;
            zam.position = box.Items.Count;
            allzam.Add(zam);
            box.Items.Add(zam.name);
            name.Text = null;
            discription.Text = null;
            ConvertJ.Serialization(allzam, "заметки.json");
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            foreach (Zametka same in allzam)
            {
                if (same.position == box.SelectedIndex && same.data == data.Text)
                {
                    same.name = name.Text;
                    same.description = discription.Text;
                    box.Items[box.SelectedIndex] = name.Text;
                    name.Text = null;
                    discription.Text = null;
                }
            }
            ConvertJ.Serialization(allzam, "заметки.json");
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            foreach (Zametka same in allzam.ToArray())
            {
                if (same.position == box.SelectedIndex && same.data == data.Text)
                {
                    v = allzam.IndexOf(same);
                    foreach (Zametka check in allzam)
                    {
                        if (check.data == data.Text)
                        {
                            c = allzam.IndexOf(check);
                        }
                    }
                    foreach (Zametka up in allzam)
                    {
                        if (allzam.IndexOf(up) > v && allzam.IndexOf(up) < c + 1)
                        {
                            up.position = up.position - 1;
                        }
                    }
                    allzam.Remove(same);
                    box.Items.RemoveAt(box.SelectedIndex);
                    name.Text = null;
                    discription.Text = null;
                }
            }
            ConvertJ.Serialization(allzam, "заметки.json");
        }

        private void box_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            foreach (Zametka same in allzam)
            {
                if (same.position == box.SelectedIndex && same.data == data.Text)
                {
                    name.Text = same.name;
                    discription.Text = same.description;
                }
            }
        }

        private void data_SelectedDateChanged(object sender, SelectionChangedEventArgs e)
        {
            name.Text = null;
            discription.Text = null;
            box.Items.Clear();
            foreach (Zametka same in allzam.ToArray())
            {
                if (same.data == data.Text)
                {
                    box.Items.Add(same.name);
                }
            }

        }
    }
}