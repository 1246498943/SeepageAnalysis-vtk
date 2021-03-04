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

namespace SeepageAnalysis.Views
{
    /// <summary>
    /// ImageCheckBox.xaml 的交互逻辑
    /// </summary>
    public partial class ImageCheckBox : CheckBox
    {
        public ImageCheckBox()
        {
            InitializeComponent();
        }

        public string textStr
        {
            get => TxtName.Text;
            set => TxtName.Text = value;
        }

        public ImageSource imageSource
        {
            get => ImageName.Source;
            set => ImageName.Source = value;

        }

        public Brush setTxtBrush
        {
            get => TxtName.Foreground;
            set => TxtName.Foreground = value;
        }


    }
}
