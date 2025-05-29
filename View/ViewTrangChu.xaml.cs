﻿using DALTUDTXDHONG.Pages;
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

namespace DALTUDTXDHONG.View
{
    /// <summary>
    /// Interaction logic for ViewTrangChu.xaml
    /// </summary>
    public partial class ViewTrangChu : Window
    {
        public ViewTrangChu()
        {
            InitializeComponent();
        }

        private void btnVatLieu_Click(object sender, RoutedEventArgs e)
        {
            frame_Body.Content = new pageVatLieu();
        }

        private void btnTietDien_Click(object sender, RoutedEventArgs e)
        {
            frame_Body.Content = new pageTietDien();
        }

        private void btnTinhToanKNCNLechTam_Click(object sender, RoutedEventArgs e)
        {
            frame_Body.Content = new pageTinhToan();
        }

        private void btnThongSoCot_Click(object sender, RoutedEventArgs e)
        {
            frame_Body.Content = new pageColumnParameters();

        }
    }
}
