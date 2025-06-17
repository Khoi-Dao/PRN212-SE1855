using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace ListWPF
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        List<int>dsDuLieu = new List<int>();
        public MainWindow()
        {
            InitializeComponent();
        }

        private void btnThem_Click(object sender, RoutedEventArgs e)
        {
            int x = int.Parse(txtGiaTri.Text);
            dsDuLieu.Add(x);
            HienThiDanhSach();
            txtGiaTri.Text = "";
        }

        private void btnSapXepTang_Click(object sender, RoutedEventArgs e)
        {
            dsDuLieu.Sort();
            HienThiDanhSach();

        }
        void HienThiDanhSach()
        {
            lstDuLieu.Items.Clear();
            for (int i = 0; i < dsDuLieu.Count; i++) 
            { 
                int x = dsDuLieu[i];
                lstDuLieu.Items.Add(x);
            }

        }
        private void btnSapXepGiam_Click(object sender, RoutedEventArgs e)
        {
            dsDuLieu.Sort();
            dsDuLieu.Reverse();
            HienThiDanhSach();
        }

        private void btnXoa1PhanTu_Click(object sender, RoutedEventArgs e)
        {
            if (lstDuLieu.SelectedIndex == -1) 
            {
                MessageBox.Show("Phải chọn phần tử mới xóa được",
                    "Thông báo lỗi", MessageBoxButton.OK);
                return;
            }
            dsDuLieu.RemoveAt(lstDuLieu.SelectedIndex);
            HienThiDanhSach();
        }

        private void btnXoaNhieuPhanTu_Click(object sender, RoutedEventArgs e)
        {
            if (lstDuLieu.SelectedIndex == -1)
            {
                MessageBox.Show("Phải chọn phần tử mới xóa được",
                    "Thông báo lỗi", MessageBoxButton.OK);
                return;
            }
            while (lstDuLieu.SelectedItems.Count > 0) 
            {
                int data = (int)lstDuLieu.SelectedItems[0];
                    dsDuLieu.Remove(data);
                lstDuLieu.Items.Remove(data);
            }
        }

        private void btnXoaToanBoPhanTu_Click(object sender, RoutedEventArgs e)
        {
            dsDuLieu.Clear();
            HienThiDanhSach();
        }

        private void btnChen_Click(object sender, RoutedEventArgs e)
        {
            int x=int.Parse(txtGiaTriChen.Text);
            int vt = int.Parse(txtViTriChen.Text);
            dsDuLieu.Insert(vt, x);
            HienThiDanhSach();
            txtViTriChen.Text = "";
            txtGiaTriChen.Text= "";
        }
    }
}