using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Vtk.Views;

namespace SeepageAnalysis.ViewModels
{
    /// <summary>
    /// 交互中间组件
    /// </summary>
   public class MainWindowModel
   {
        public MainWindowModel()
        {
            InitClickedDictionarySource();
            _seepageAndVtkTreeControl = new SeepageAndvtkTreeControl();
        }

        #region 树状状态管理
        public SeepageAndvtkTreeControl _seepageAndVtkTreeControl { get; set; }
        #endregion

        #region 事件映射.
        public Dictionary<string, Action> _EventDictionaryEvent { get; set; }
        private void InitClickedDictionarySource()
        {
            _EventDictionaryEvent = new Dictionary<string, Action>();
            _EventDictionaryEvent.Add(@"ModelSphereBtn", onLoadedmodelSphere);
            _EventDictionaryEvent.Add(@"ModelCoordinateBtn", onLoadedmodelCoordinate);
            _EventDictionaryEvent.Add(@"ModelRectangleBtn", onLoadedmodelRectangle);
            _EventDictionaryEvent.Add(@"ModelSeepageBtn", onLoadedmodelSeepage);
        } 

        /// <summary>
        /// 添加各种模型.
        /// </summary>
        private void onLoadedmodelSphere()
        {
            _seepageAndVtkTreeControl.AddGrupActor();
        }
        private void onLoadedmodelCoordinate()
        {
            _seepageAndVtkTreeControl.AddGrupActor();
        }
        private void onLoadedmodelRectangle()
        {
            _seepageAndVtkTreeControl.AddGrupActor();
        }
        private void onLoadedmodelSeepage()
        {
            //添加渗流模型.并重新设计模型加载的数据格式.
            _seepageAndVtkTreeControl.AddSeepageModelActor();
        }
        #endregion

    }
}
