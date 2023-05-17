using Microsoft.WindowsAPICodePack.Dialogs;
using MS.WindowsAPICodePack.Internal;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading;
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
using static System.Net.Mime.MediaTypeNames;

namespace WpfApp1
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        CommonOpenFileDialog dialog;
        Random rnd = new Random();
        TimeSpan position;
        TimeSpan totalDuration;
        TimeSpan currentPosition;
        string[] files;
        string c = null;
        int s;
        int f;
        int a = 1;
        int b = 0;
        int d = 0;
        int result;

        public MainWindow()
        {
            InitializeComponent();
        }
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            dialog = new CommonOpenFileDialog { IsFolderPicker = true };
            var result = dialog.ShowDialog();
            if (result == CommonFileDialogResult.Ok)
            {
                files = Directory.GetFiles(dialog.FileName, "*.mp3");
                foreach (string file in files)
                {
                    box.Items.Add(file);
                    if (c == null)
                    {
                        c = file;
                    }
                }
            }
            s = box.Items.Count - 1;
            media.Source = new Uri(c);
            media.Play();
            box.SelectedIndex = 0;
            thread.Start();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            files = Directory.GetFiles(dialog.FileName, "*.mp3");
            foreach (string file in files)
            {
                if (file == c)
                {
                    f = Array.IndexOf(files, file);
                    if (f > 0)
                    {
                        foreach (string fufel in files)
                        {
                            if (Array.IndexOf(files, fufel) == f - 1)
                            {
                                c = fufel;
                                media.Source = new Uri(c);
                                media.Play();
                                box.SelectedIndex = box.SelectedIndex - 1;
                                return;
                            }
                        }
                    }
                    if (f == 0)
                    {
                        foreach (string fus in files)
                        {
                            f = box.Items.Count - 1;
                            if (Array.IndexOf(files, fus) == f)
                            {
                                c = fus;
                                media.Source = new Uri(c);
                                media.Play();
                                fu.Value = 0;
                                box.SelectedIndex = box.Items.Count - 1;
                                return;
                            }
                        }
                    }
                }
            }
        }
        private void play_Click(object sender, RoutedEventArgs e)
        {
            if (a == 1)
            {
                media.Pause();
                a = 0;
            }
            else if (a == 0)
            {
                media.Play();
                a = 1;
            }
        }

        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
            files = Directory.GetFiles(dialog.FileName, "*.mp3");
            foreach (string file in files)
            {
                if (file == c)
                {
                    f = Array.IndexOf(files, file);
                    if (f < s)
                    {
                        foreach (string fufel in files)
                        {
                            if (Array.IndexOf(files, fufel) == f + 1)
                            {
                                c = fufel;
                                media.Source = new Uri(c);
                                media.Play();
                                box.SelectedIndex = box.SelectedIndex + 1;
                                return;
                            }
                        }
                    }
                    if (f == s)
                    {
                        foreach (string fus in files)
                        {
                            f = 0;
                            if (Array.IndexOf(files, fus) == f)
                            {
                                c = fus;
                                media.Source = new Uri(c);
                                media.Play();
                                fu.Value = 0;
                                box.SelectedIndex = 0;
                                return;
                            }
                        }
                    }
                }
            }
        }

        private void Button_Click_4(object sender, RoutedEventArgs e)
        {
            if (b == 0)
            {
                b = 1;
                repeat.Background.Opacity = 1;
            }
            else if (b == 1)
            {
                b = 0;
                repeat.Background.Opacity = 0.5;
            }
        }

        private void Button_Click_5(object sender, RoutedEventArgs e)
        {
            if (d == 0)
            {
                d = 1;
                random.Background.Opacity = 1;
            }
            else if (d == 1)
            {
                d = 0;
                random.Background.Opacity = 0.5;
            }
        }

        private void box_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            try
            {
                media.Source = new Uri(Convert.ToString(box.Items[box.SelectedIndex]));
                media.Play();
                c = Convert.ToString(box.Items[box.SelectedIndex]);
            }
            catch { }
        }

        private void fu_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            media.Position = TimeSpan.FromSeconds(fu.Value);
        }

        private void media_MediaOpened(object sender, RoutedEventArgs e)
        {
            fu.Minimum = 0;
            fu.Maximum = media.NaturalDuration.TimeSpan.TotalSeconds;
            fu.ValueChanged += fu_ValueChanged;
            Dispatcher.Invoke(() => end.Text = media.NaturalDuration.TimeSpan.ToString(@"mm\:ss"));
        }

        Thread thread => new Thread(new ThreadStart(Check));
        private async void Check()
        {
            while (true)
            {
                Dispatcher.Invoke(() => now.Text = media.Position.ToString(@"mm\:ss"));
                if (Dispatcher.Invoke(() => fu.Value != fu.Maximum))
                {
                    Dispatcher.Invoke(() => fu.Value = media.Position.TotalSeconds);
                }
                else
                {

                }
                Dispatcher.Invoke(() => position = media.Position);
                Dispatcher.Invoke(() => totalDuration = TimeSpan.Zero);
                if (Dispatcher.Invoke(() => !media.NaturalDuration.HasTimeSpan) || Dispatcher.Invoke(() => media.NaturalDuration.TimeSpan == TimeSpan.Zero))
                {

                }
                else
                {
                    Dispatcher.Invoke(() => totalDuration = media.NaturalDuration.TimeSpan);
                    Dispatcher.Invoke(() => currentPosition = media.Position);
                }
                await Task.Delay(1000);
            }
        }

        private void media_MediaEnded(object sender, RoutedEventArgs e)
        {
            files = Directory.GetFiles(dialog.FileName, "*.mp3");
            foreach (string file in files)
            {
                if (file == c)
                {
                    f = Array.IndexOf(files, file);
                    if (f < s)
                    {
                        foreach (string fufel in files)
                        {
                            if (Array.IndexOf(files, fufel) == f + 1 && b == 0 && d == 0)
                            {
                                c = fufel;
                                media.Source = new Uri(c);
                                media.Play();
                                fu.Value = 0;
                                box.SelectedIndex = box.SelectedIndex + 1;
                                return;
                            }
                            if (Array.IndexOf(files, fufel) == f && b == 1)
                            {
                                c = fufel;
                                media.Source = new Uri(c);
                                media.Play();
                                fu.Value = 0;
                                box.SelectedIndex = box.SelectedIndex;
                                return;
                            }
                            if (Array.IndexOf(files, fufel) == f && d == 1 && b == 0)
                            {
                                do
                                {
                                    result = rnd.Next(0, s + 1);
                                } while (result == f);
                                foreach (string fa in files)
                                {
                                    if (Array.IndexOf(files, fa) == result)
                                    {
                                        c = fa;
                                        media.Source = new Uri(c);
                                        media.Play();
                                        fu.Value = 0;
                                        box.SelectedIndex = result;
                                        return;
                                    }
                                }
                            }
                        }
                    }
                    if (f == s)
                    {
                        foreach (string fus in files)
                        {
                            f = 0;
                            if (Array.IndexOf(files, fus) == f)
                            {
                                c = fus;
                                media.Source = new Uri(c);
                                media.Play();
                                fu.Value = 0;
                                box.SelectedIndex = 0;
                                return;
                            }
                        }
                    }
                }
            }
        }
    }
}
