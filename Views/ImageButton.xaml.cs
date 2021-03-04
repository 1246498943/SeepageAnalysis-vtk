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
    /// ImageButton.xaml 的交互逻辑
    /// </summary>
    public partial class ImageButton : Button
    {
        public ImageButton()
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


        public bool IsChecked
        {
            get { return (bool)GetValue(IsCheckedProperty); }
            set { SetValue(IsCheckedProperty, value); }
        }

        public static readonly DependencyProperty IsCheckedProperty =
            DependencyProperty.Register("IsChecked", typeof(bool), typeof(ImageButton), new PropertyMetadata(false));

        protected override void OnClick()
        {
            base.OnClick();
            IsChecked = !IsChecked;
        }


    }
}
