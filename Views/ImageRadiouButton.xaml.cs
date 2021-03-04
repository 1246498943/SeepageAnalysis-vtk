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
    /// ImageRadiouButton.xaml 的交互逻辑
    /// </summary>
    public partial class ImageRadiouButton : RadioButton
    {
        public ImageRadiouButton()
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

        private  bool radioStatus = true;
        public bool RadioStatus
        {
            get => radioStatus;
            set => radioStatus = value;
        }

        protected override void OnClick()
        {
            bool? wacChecked = this.IsChecked;
            base.OnClick();
            if (wacChecked == true)
            {
                this.IsChecked = false;
            }
            radioStatus = !radioStatus;
        }
    }
}
