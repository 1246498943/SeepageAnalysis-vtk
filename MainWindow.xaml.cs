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
using HandyControl.Tools.Extension;
using Kitware.VTK;
using SeepageAnalysis.ViewModels;

namespace SeepageAnalysis
{
    /// <summary>
    /// MainWindow.xaml 的交互逻辑
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            InitUiSource();

        }

        /// <summary>
        /// 添加关联画板两个事件.
        /// </summary>
        private void InitUiSource()
        {
            color_picker.SelectedColorChanged += delegate
            {
                this.btn_color.setTxtBrush = color_picker.SelectedBrush;
                btn_color.IsChecked = false;
            };
            color_picker.Canceled += delegate
            {
                btn_color.IsChecked = false;
            };

        }

        private void InitTreeSource()
        {
            _mainWindowModelObj = new MainWindowModel();

           System.Windows.Forms.Panel panel = vtkSceneName.getPanelName;
            //这两个对象必须设置
            _mainWindowModelObj._seepageAndVtkTreeControl.setControlObj(ref vtkSceneName._vtkModelControl,ref seepageTreeName,ref panel);
        }

        private void onMouseLeftDown(object sender, MouseButtonEventArgs e)
        {
            Helpers.DelegateHelpers.GetErrorInfo("onMouseLeftDown",()=> {

                base.OnMouseLeftButtonDown(e);
                if(e.GetPosition(this).Y<50)
                {
                    this.DragMove();
                }
            
            });
        }

        private void onCloseBtn(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void onMaxBtn(object sender, RoutedEventArgs e)
        {
            this.WindowState = this.WindowState == WindowState.Normal? WindowState.Maximized : WindowState.Normal;
        }

        private void onMinBtn(object sender, RoutedEventArgs e)
        {
            this.WindowState = WindowState.Minimized;
        }

        private void wndLoaded(object sender, RoutedEventArgs e)
        {
            InitTreeSource();
        }
        private void wndUnloaded(object sender, RoutedEventArgs e)
        {

        }

        private void MenuToggleButton_OnClick(object sender, RoutedEventArgs e)
        {

        }

        private void MenuDarkModeButton_Click(object sender, RoutedEventArgs e)
        {

        }

        private void UIElement_OnPreviewMouseLeftButtonUp(object sender, MouseButtonEventArgs e)
        {

        }

     
        private void onReadModelClicked(object sender, RoutedEventArgs e)
        {
           
        }

        #region 窗体位置改变的时候.

        private void updatePopPosition()
        {
            this.Dispatcher.BeginInvoke(new Action(()=> {

                double offset = shotCutPopUpName.HorizontalOffset;
                shotCutPopUpName.HorizontalOffset = offset + 1;
                shotCutPopUpName.HorizontalOffset = offset;
                shotCutPopUpName.UpdateLayout();

                double SettingOffset = SettingPopUp.HorizontalOffset;
                SettingPopUp.HorizontalOffset = offset + 1;
                SettingPopUp.HorizontalOffset = offset;
                SettingPopUp.UpdateLayout();

            }));
        }
        private void windLocationChanged(object sender, EventArgs e)
        {
            updatePopPosition();
        }

        private void windSizeChanged(object sender, SizeChangedEventArgs e)
        {
            updatePopPosition();
        }
        #endregion

        public MainWindowModel _mainWindowModelObj { get; set; }
        private void onLoadedModelClicked(object sender, RoutedEventArgs e)
        {
            Button btn = e.OriginalSource as Button;
            if(btn!=null)
            {
                _mainWindowModelObj._EventDictionaryEvent[btn.Name]();
            }
        }
    }
}
