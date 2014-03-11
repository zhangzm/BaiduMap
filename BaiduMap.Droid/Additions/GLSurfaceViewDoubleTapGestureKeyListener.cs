using Android.Content;
using Android.Runtime;
using Android.Util;
using System;
using System.Collections.Generic;
using System.Text;

namespace Com.Baidu.Mapapi.Panoramas
{
    public abstract class GLSurfaceViewDoubleTapGestureKeyListener : Android.Opengl.GLSurfaceView, Android.Views.GestureDetector.IOnDoubleTapListener, Android.Views.GestureDetector.IOnGestureListener, Android.Views.View.IOnKeyListener
    {
        public GLSurfaceViewDoubleTapGestureKeyListener(Context context) : base(context) { }
        public GLSurfaceViewDoubleTapGestureKeyListener(Context context, IAttributeSet attrs) : base(context, attrs) { }
        protected GLSurfaceViewDoubleTapGestureKeyListener(IntPtr javaReference, JniHandleOwnership transfer) : base(javaReference, transfer) { }


        public virtual bool OnDoubleTap(Android.Views.MotionEvent e)
        {
            throw new NotImplementedException();
        }

        public virtual bool OnDoubleTapEvent(Android.Views.MotionEvent e)
        {
            throw new NotImplementedException();
        }

        public virtual bool OnSingleTapConfirmed(Android.Views.MotionEvent e)
        {
            throw new NotImplementedException();
        }

        public virtual bool OnDown(Android.Views.MotionEvent e)
        {
            throw new NotImplementedException();
        }

        public virtual bool OnFling(Android.Views.MotionEvent e1, Android.Views.MotionEvent e2, float velocityX, float velocityY)
        {
            throw new NotImplementedException();
        }

        public virtual void OnLongPress(Android.Views.MotionEvent e)
        {
            throw new NotImplementedException();
        }

        public virtual bool OnScroll(Android.Views.MotionEvent e1, Android.Views.MotionEvent e2, float distanceX, float distanceY)
        {
            throw new NotImplementedException();
        }

        public virtual void OnShowPress(Android.Views.MotionEvent e)
        {
            throw new NotImplementedException();
        }

        public virtual bool OnSingleTapUp(Android.Views.MotionEvent e)
        {
            throw new NotImplementedException();
        }

        public virtual bool OnKey(Android.Views.View v, Android.Views.Keycode keyCode, Android.Views.KeyEvent e)
        {
            throw new NotImplementedException();
        }
    }
}