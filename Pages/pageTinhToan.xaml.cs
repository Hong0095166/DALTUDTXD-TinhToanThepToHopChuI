﻿using DALTUDTXDHONG.Class;
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
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Xml.Linq;

namespace DALTUDTXDHONG.Pages
{
    /// <summary>
    /// Interaction logic for pageTinhToan.xaml
    /// </summary>
    public partial class pageTinhToan : Page
    {

        public pageTinhToan()
        {
           InitializeComponent();
           LoadDL();
        }

        private void sl(object sender, SelectionChangedEventArgs e)
        {
            string selectedColumnName = cbbCotCanTinh.SelectedItem as string;

            foreach (clsColumn column in clsBienToanCuc.clsColumn)
            {
                if (column.Name == selectedColumnName)
                {
                    txtDaiCot.Text = column.ChieuCao.ToString();
                    txtTaiTrong.Text = column.LucDoc.ToString();
                    cbbTietDien.Text = column.TietDien.Name;
                    cbbVatLieu.Text = column.VatLieu.TenVatLieu;
                    break;
                }
            }
        }
        public void LoadDL()
        {
            List<string> listcl = new List<string>();
            foreach (clsColumn column in clsBienToanCuc.clsColumn)
            {
                listcl.Add(column.Name);
            }
            cbbCotCanTinh.ItemsSource = listcl;

            List<clsVatLieuThep> listvl = new List<clsVatLieuThep>();
            HashSet<string> tenVatLieuDaCo = new HashSet<string>();

            foreach (clsVatLieuThep vatLieuThep in clsBienToanCuc.clsVatLieu)
            {
                if (!tenVatLieuDaCo.Contains(vatLieuThep.TenVatLieu))
                {
                    tenVatLieuDaCo.Add(vatLieuThep.TenVatLieu);
                    listvl.Add(vatLieuThep);
                }
            }
            cbbVatLieu.ItemsSource = tenVatLieuDaCo;

            List<clsTietDien> listtd = new List<clsTietDien>();
            HashSet<string> tenTDDaCo = new HashSet<string>();

            foreach (clsTietDien clstietdien in clsBienToanCuc.clsTietDien)
            {
                if (!tenVatLieuDaCo.Contains(clstietdien.Name))
                {
                    tenTDDaCo.Add(clstietdien.Name);
                    listtd.Add(clstietdien);
                }
            }
            cbbTietDien.ItemsSource = tenTDDaCo;
        }
    }
}
