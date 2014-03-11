using System;

using Android.App;
using Android.Content;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Android.OS;
using Com.Baidu.Mapapi.Map;
using Com.Baidu.Platform.Comapi.Basestruct;
using BaiduMap.Sample.Map;

namespace BaiduMap.Sample
{
    [Activity(Label = "BaiduMap.Sample", MainLauncher = true, Icon = "@drawable/icon")]
    public class Activity1 : Activity
    {
        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);

            SetContentView(Resource.Layout.Main);

            MapView mMapView = FindViewById<MapView>(Resource.Id.bmapsView);

            App.Current.Map.CallBack.ReceiveLocation = (location) =>
            {
                mMapView.SetBuiltInZoomControls(true);
                //设置启用内置的缩放控件  
                MapController mMapController = mMapView.Controller;
                // 得到mMapView的控制权,可以用它控制和驱动平移和缩放  
                GeoPoint point = new GeoPoint((int)(location.Latitude * 1E6), (int)(location.Longitude * 1E6));
                //用给定的经纬度构造一个GeoPoint，单位是微度 (度 * 1E6)  
                mMapController.SetCenter(point);//设置地图中心点  
                mMapController.SetZoom(12);//设置地图zoom级别  
            };

        }
    }
}