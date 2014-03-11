using Android.App;
using Android.Runtime;
using Android.Widget;
using BaiduMap.Sample.Map;
using System;
using System.Collections.Generic;
using System.Text;

namespace BaiduMap.Sample
{
    [Application]
    public class App : Application
    {
        public App() : base() { }
        protected App(IntPtr javaReference, JniHandleOwnership transfer) : base(javaReference, transfer) { }

        public override void OnCreate()
        {
            base.OnCreate();
            Current = this;
            Map = new MapProvider(this);
            InitMap();
            StartLocation();
        }

        public void InitMap()
        {
            if (Map != null)
            {
                Map.MapManager.Init(Map.Api_Key, null);
            }
        }

        public void StartLocation()
        {
            if (Map != null)
            {
                Map.Location.Start();
            }
        }

        public static App Current { get; set; }

        public MapProvider Map { get; set; }

    }
}