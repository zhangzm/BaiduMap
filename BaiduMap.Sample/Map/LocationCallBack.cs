﻿using Com.Baidu.Location;
using System;
using System.Collections.Generic;
using System.Text;

namespace BaiduMap.Sample.Map
{
    public class LocationCallBack : Java.Lang.Object, IBDLocationListener
    {
        public Action<BDLocation> ReceiveLocation { get; set; }
        public Action<BDLocation> ReceivePoi { get; set; }


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
