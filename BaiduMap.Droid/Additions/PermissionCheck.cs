using Android.Runtime;
using System;
using System.Collections.Generic;
using System.Text;

namespace Com.Baidu.Mapapi.Utils
{
    public partial class PermissionCheck
    {
        [Register("com/baidu/mapapi/utils/PermissionCheck$a")]
        public class PermissionCheck_A : Java.Lang.Object
        {
				
        }

        [Register("com/baidu/mapapi/utils/PermissionCheck$b")]
        public interface IPermissionCheck_B
        {
            [Register("onGetPermissionCheckResult", "(Lcom/baidu/mapapi/utils/PermissionCheck$a;)V", "")]
             void OnGetPermissionCheckResult(PermissionCheck_A parama);
        }
    }
}
