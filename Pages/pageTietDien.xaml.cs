﻿using DALTUDTXDHONG.Class;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Runtime.Remoting.Metadata.W3cXsd2001;
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
using ETABSv1;
using System.Configuration;
using System.Security.Policy;

namespace DALTUDTXDHONG.Pages
{
    /// <summary>
    /// Interaction logic for pageTietDien.xaml
    /// </summary>
    public partial class pageTietDien : Page
    {
        public pageTietDien()
        {
            InitializeComponent();
            loadDaTa();
        }

        private void btnThem_Click(object sender, RoutedEventArgs e)
        {
            clsBienToanCuc.clsTietDien.Add(new clsTietDien(txtName.Text, Convert.ToDouble(txtRongCanh.Text), Convert.ToDouble(txtDayCanh.Text), Convert.ToDouble(txtCaoBung.Text), Convert.ToDouble(txtDayBung.Text)));
            loadDaTa();
        }
        public void loadDaTa()
        {
            List<clsTietDien> list = new List<clsTietDien>();
            HashSet<string> tenTietDienDaCo = new HashSet<string>();

            foreach (clsTietDien TietDienThep in clsBienToanCuc.clsTietDien)
            {
                if (!tenTietDienDaCo.Contains(TietDienThep.Name))
                {
                    tenTietDienDaCo.Add(TietDienThep.Name);
                    list.Add(TietDienThep);
                }
            }

            dtgTietDien.ItemsSource = list;
        }
    }
}
