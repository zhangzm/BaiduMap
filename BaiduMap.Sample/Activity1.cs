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
        GeoPoint tianan = new GeoPoint(39914195, 116403928);

        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);

            SetContentView(Resource.Layout.Main);

            MapView mMapView = FindViewById<MapView>(Resource.Id.bmapsView);

            App.Current.Map.CallBack.ReceiveLocation = (location) =>
            {
                MapController mMapController = mMapView.Controller;
                // 得到mMapView的控制权,可以用它控制和驱动平移和缩放  
                GeoPoint point = new GeoPoint((int)(location.Latitude * 1E6), (int)(location.Longitude * 1E6));
                //用给定的经纬度构造一个GeoPoint，单位是微度 (度 * 1E6)  
                mMapController.SetCenter(point);//设置地图中心点  
                mMapController.SetZoom(18);//设置地图zoom级别 
                MyLocationOverlay overlay = new MyLocationOverlay(mMapView);
                overlay.SetData(new LocationData() { Latitude = location.Latitude, Longitude = location.Longitude, Direction = 2.0f });
                mMapView.Overlays.Add(overlay);
                mMapView.Refresh();
                mMapView.Controller.AnimateTo(point);
                //PanoramaView
            };

        }

        public override void OnBackPressed()
        {
            App.Current.Map.Location.RequestLocation();
            Toast.MakeText(this, App.Current.Map.Location.IsStarted.ToString(), ToastLength.Short).Show();
            //base.OnBackPressed();
        }
    }
}