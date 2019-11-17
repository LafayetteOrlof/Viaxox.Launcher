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
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.IO;
using System.Timers;
using System.Threading;

namespace SmartPax
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : INotifyPropertyChanged
    {
        private double _row1height;
        public double row1height
        {
            get { return _row1height; }
            set { SetValue(ref _row1height, value); }
        }

        private double _row1width;
        public double row1width
        {
            get { return _row1width; }
            set { SetValue(ref _row1width, value); }
        }

        private double _row2width;
        public double row2width
        {
            get { return _row2width; }
            set { SetValue(ref _row2width, value); }
        }

        private double _row2height;
        public double row2height
        {
            get { return _row2height; }
            set { SetValue(ref _row2height, value); }
        }

        private long _totalDownloadSize;
        public long totalDownloadSize
        {
            get { return _totalDownloadSize; }
            set { SetValue(ref _totalDownloadSize, value); }
        }
        private double _totalfiles;
        public double totalfiles
        {
            get { return _totalfiles; }
            set { SetValue(ref _totalfiles, value); }
        }

        private long _totalprogress;
        public long totalprogress
        {
            get { return _totalprogress; }
            set { SetValue(ref _totalprogress, value); }
        }

        System.Timers.Timer timer;
        public MainWindow()
        {
            InitializeComponent();
            row1width = 752;
            row1height = 410;

            row2width = 752;
            row2height = 30;

            Globals.getInstance().registry = AppRegistry.getInstance();
            Globals.getInstance().connection = Globals.getInstance().registry.getDataBaseConnection();
         
           
        }

        protected void SetValue<T>(ref T backingField, T value, [CallerMemberName] string propertyName = null)
        {
            if (EqualityComparer<T>.Default.Equals(backingField, value)) return;

            backingField = value;
            OnPropertyChanged(propertyName);
        }

        public event PropertyChangedEventHandler PropertyChanged;
        protected void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            //EntityManager.connection = connection;
            //FTPConfiglist ftp = EntityManager.getFTPInfo().Where(x => x.IP == connection).FirstOrDefault();
            //List<menu> menu = EntityManager.getFileList();
            //long filesize = 0;
            //FTP ftpmanager = FTP.getInstance(ftp.FTP, ftp.username, ftp.password);
            //List<file> filestodownload = new List<file>();
            //foreach (menu item in menu)
            //{
            //    file file = ftpmanager.GetfileInfo(ftp.Folder, item.ExeFile);
            //    filestodownload.Add(file);
            //    filesize += file.size;
            //}
            //totalDownloadSize = filesize;
            //totalfiles = menu.Count;

            //foreach (file item in filestodownload)
            //{
            //    file file = ftpmanager.GetfileInfo(ftp.Folder, item.name);
            //    Stream downloadStream = await ftpmanager.DownloadFile(ftp.Folder, item.name);
            //    Stream output = File.Create(@"C:\" + item.name);
            //    byte[] buffer = new byte[8 * 1024];
            //    int len;
            //    while ((len = downloadStream.Read(buffer, 0, buffer.Length)) > 0)
            //    {
            //        output.Write(buffer, 0, len);
            //        _totalprogress += len;
            //    }
            //}

        }
    }
}
