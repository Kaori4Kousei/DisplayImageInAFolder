using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace WpfApp1
{
    class ViewModel
    {
        private readonly ObservableCollection<ImagesPath> _imagePath;

        public ObservableCollection<ImagesPath> ImagePath
        {
            get { return _imagePath; }
        }

        public ViewModel()
        {
            _imagePath = new ObservableCollection<ImagesPath>();
            LoadingPath();
        }

        private void LoadingPath()
        {
            string[] fileEntries = Directory.GetFiles(@"E:\Cars\");
            foreach (string fileName in fileEntries)
                ImagePath.Add(new ImagesPath() { ImagePathString = fileName });
        }
    }
}
