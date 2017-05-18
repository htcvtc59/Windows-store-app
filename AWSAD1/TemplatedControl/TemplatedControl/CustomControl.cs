using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Documents;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;

// The Templated Control item template is documented at http://go.microsoft.com/fwlink/?LinkId=234235

namespace TemplatedControl
{
    public sealed class CustomControl : Control
    {
        public CustomControl()
        {
            this.DefaultStyleKey = typeof(CustomControl);
        }


        public bool Blink
        {
            get { return (bool)GetValue(BlinkProperty); }
            set { SetValue(BlinkProperty, value); }
        }

        // Using a DependencyProperty as the backing store for Blink.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty BlinkProperty =
            DependencyProperty.Register("Blink", typeof(bool), typeof(CustomControl), new PropertyMetadata(false, new PropertyChangedCallback(OnBlinkChanged)));

        private DispatcherTimer __timer = null;
        private DispatcherTimer _timer
        {
            get
            {
                if (__timer == null)
                {
                    __timer = new DispatcherTimer();
                    __timer.Interval = new TimeSpan(0, 0, 0, 0, 500);
                    __timer.Tick += __timer_Tick;

                }
                return __timer;

            }



        }

        private void __timer_Tick(object sender, object e)
        {
            DoBlink();
        }

        private void DoBlink()
        {
            this.Opacity = (this.Opacity + 1) % 2;
        }

        private static void OnBlinkChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            var instance = d as CustomControl;
            if (instance != null)
            {
                if (instance._timer.IsEnabled != instance.Blink)
                {
                    if (instance.Blink)
                    {
                        instance._timer.Start();
                    }
                    else { instance._timer.Stop(); }

                }
            }
        }

        public event EventHandler Blinked;
        private void OnBlinked()
        {
            EventHandler eh = Blinked;
            if (eh != null)
            {
                eh(this,new EventArgs());

            }

        }




    }
}
