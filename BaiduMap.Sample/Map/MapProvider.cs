using Android.Content;
using Android.Content.PM;
using Android.Widget;
using Com.Baidu.Location;
using Com.Baidu.Mapapi;
using System;
using System.Collections.Generic;
using System.Text;

namespace BaiduMap.Sample.Map
{
    public class MapProvider
    {
        private const String API_KEY_METADATA_KEY = "com.baidu.lbsapi.API_KEY";

        public MapProvider(Context context)
        {
             Init(context);
        }


        private void Init(Context context)
        {
            Location = new LocationClient(context);
            Listener = new LocationListerner();
            CallBack = new LocationCallBack();
            Location.RegisterLocationListener(Listener);
            Location.RegisterLocationListener(CallBack);

            LocationClientOption option = new LocationClientOption();
            option.AddrType = "all";
            option.CoorType = "bd09ll";
            option.DisableCache(true);
            option.Priority = LocationClientOption.NetWorkFirst;
            Location.LocOption = option;

            MapManager = new BMapManager(context);

            ApplicationInfo info = context.PackageManager.GetApplicationInfo(context.PackageName, PackageInfoFlags.MetaData);
            Api_Key = info.MetaData.GetString(API_KEY_METADATA_KEY);
        }

        public LocationClient Location { get; private set; }

        public LocationListerner Listener { get; private set; }

        public LocationCallBack CallBack { get; private set; }

        public BMapManager MapManager { get; private set; }

        public String Api_Key { get; private set; }
    }
}