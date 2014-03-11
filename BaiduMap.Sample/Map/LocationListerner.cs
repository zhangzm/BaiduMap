using Com.Baidu.Location;
using System;
using System.Collections.Generic;
using System.Text;

namespace BaiduMap.Sample.Map
{
    public class LocationListerner : Java.Lang.Object, IBDLocationListener
    {

        public event Action<BDLocation> ReceiveLocation;
        public event Action<BDLocation> ReceivePoi;


        public void OnReceiveLocation(BDLocation p0)
        {
            if (ReceiveLocation != null)
            {
                ReceiveLocation(p0);
            }
        }

        public void OnReceivePoi(BDLocation p0)
        {
            if (ReceivePoi != null)
            {
                ReceivePoi(p0);
            }
        }
    }
}