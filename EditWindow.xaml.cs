﻿using System;
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

namespace Poisk
{
    /// <summary>
    /// Логика взаимодействия для EditWindow.xaml
    /// </summary>
    public partial class EditWindow : Window
    {
        public EditWindow()
        {
            InitializeComponent();

        }
        private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void comboBox1_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        private void add_task_button_Click(object sender, RoutedEventArgs e)
        {
            
        }

        private void back_button_Click(object sender, RoutedEventArgs e)
        {
            TaskWindow windowTask = new TaskWindow();
            windowTask.Show();
            this.Close();
        }

        private void add_task_button_Click_1(object sender, RoutedEventArgs e)
        {
            TaskWindow windowTask = new TaskWindow();
            windowTask.Show();
            this.Close();
        }
    }
}
