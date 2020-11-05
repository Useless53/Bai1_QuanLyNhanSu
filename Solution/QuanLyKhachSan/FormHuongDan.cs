using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyKhachSan
{
    public partial class FormHuongDan : Form
    {
        public FormHuongDan()
        {
            InitializeComponent();
        }

        private void treeView1_AfterSelect(object sender, TreeViewEventArgs e)
        {
            string str;
            if (treeView1.SelectedNode.Name == "GT_NTH")
            {
                str = Application.StartupPath + "\\Huong Dan\\Nhom thuc hien.mht";
                webBrowser1.Navigate(str);
            }
            if (treeView1.SelectedNode.Name == "GT_SP")
            {
                str = Application.StartupPath + "\\Huong Dan\\GioiThieuChung.html";
                webBrowser1.Navigate(str);
            }
            if (treeView1.SelectedNode.Name == "HD_QLC")
            {
                str = Application.StartupPath + "\\Huong Dan\\GDchung.html";
                webBrowser1.Navigate(str);
            }
            if (treeView1.SelectedNode.Name == "HD_KH")
            {
                str = Application.StartupPath + "\\Huong Dan\\KhachHang.html";
                webBrowser1.Navigate(str);
            }
            if (treeView1.SelectedNode.Name == "HD_Phong")
            {
                str = Application.StartupPath + "\\HuongDan\\Phong.html";
                webBrowser1.Navigate(str);
            }
            if (treeView1.SelectedNode.Name == "HD_DV")
            {
                str = Application.StartupPath + "\\Huong Dan\\DichVu.html";
                webBrowser1.Navigate(str);
            }
            if (treeView1.SelectedNode.Name == "HD_TTB")
            {
                str = Application.StartupPath + "\\Huong Dan\\TTB.html";
                webBrowser1.Navigate(str);
            }
            if (treeView1.SelectedNode.Name == "HD_QLDV")
            {
                str = Application.StartupPath + "\\Huong Dan\\QLDV.html";
                webBrowser1.Navigate(str);
            }
            if (treeView1.SelectedNode.Name == "HD_QLP")
            {
                str = Application.StartupPath + "\\Huong Dan\\QLPhong.html";
                webBrowser1.Navigate(str);
            }
            if (treeView1.SelectedNode.Name == "HD_QLTTB")
            {
                str = Application.StartupPath + "\\Huong Dan\\QLTTB.html";
                webBrowser1.Navigate(str);
            }
        }
    }
}