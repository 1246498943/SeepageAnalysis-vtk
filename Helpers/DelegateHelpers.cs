using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Helpers
{
    /// <summary>
    /// 存放辅助设计类.
    /// </summary>
    public partial class DelegateHelpers
    {
        public static void GetErrorInfo(string methodName,Action action)
        {
            try
            {
                action();
            }
            catch(Exception ex)
            {
                Console.WriteLine($"Error: {methodName} -> {ex.Message}");
            }
        }

    }
}
