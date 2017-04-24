using System;
using System.Collections;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Runtime.Serialization.Json;
using System.Text;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Storage;
using Windows.UI;
using Windows.UI.Popups;
using Windows.UI.Text;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Media.Animation;
using Windows.UI.Xaml.Navigation;

// The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=234238

namespace Assignment_AWSAD1Calendar
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {

        private List<Event> Events;
        public MainPage()
        {
            this.InitializeComponent();
            addBeforeDay();
            addDayinMonth();
            addAfterDay();
            monthyearsnow();
            CalMain();



        }

        //convert rbg to arbg
        public static Brush ConvertColor(int r, int g, int b)
        {
            return new SolidColorBrush(Windows.UI.Color.FromArgb(Convert.ToByte(255), Convert.ToByte(r), Convert.ToByte(g), Convert.ToByte(b)));
        }
        private void addBeforeDay()
        {
            DayinMonth daybefore = CalendarCus.DayBefore();
            DateTime now = DateTime.Now;
            DateTime day1inmonth = new DateTime(now.Year, now.Month, 1);
            string nameday = day1inmonth.DayOfWeek.ToString();


            Brush color = ConvertColor(129, 152, 177);

            //get int day before day now
            switch (nameday)
            {
                case "Sunday":


                    break;
                case "Monday":
                    tbdSun1.DataContext = daybefore;

                    tbdSun1.Foreground = color;

                    break;
                case "Tuesday":
                    tbdSun1.DataContext = daybefore;
                    tbdMon1.DataContext = daybefore;

                    tbdSun1.Foreground = color;
                    tbdMon1.Foreground = color;
                    break;
                case "Wednesday":
                    tbdSun1.DataContext = daybefore;
                    tbdMon1.DataContext = daybefore;
                    tbdTue1.DataContext = daybefore;

                    tbdSun1.Foreground = color;
                    tbdMon1.Foreground = color;
                    tbdTue1.Foreground = color;
                    break;
                case "Thursday":
                    tbdSun1.DataContext = daybefore;
                    tbdMon1.DataContext = daybefore;
                    tbdTue1.DataContext = daybefore;
                    tbdWed1.DataContext = daybefore;

                    tbdSun1.Foreground = color;
                    tbdMon1.Foreground = color;
                    tbdTue1.Foreground = color;
                    tbdWed1.Foreground = color;


                    break;
                case "Friday":
                    tbdSun1.DataContext = daybefore;
                    tbdMon1.DataContext = daybefore;
                    tbdTue1.DataContext = daybefore;
                    tbdWed1.DataContext = daybefore;
                    tbdThu1.DataContext = daybefore;

                    tbdSun1.Foreground = color;
                    tbdMon1.Foreground = color;
                    tbdTue1.Foreground = color;
                    tbdWed1.Foreground = color;
                    tbdThu1.Foreground = color;


                    break;
                case "Saturday":
                    tbdSun1.DataContext = daybefore;
                    tbdMon1.DataContext = daybefore;
                    tbdTue1.DataContext = daybefore;
                    tbdWed1.DataContext = daybefore;
                    tbdThu1.DataContext = daybefore;
                    tbdFri1.DataContext = daybefore;

                    tbdSun1.Foreground = color;
                    tbdMon1.Foreground = color;
                    tbdTue1.Foreground = color;
                    tbdWed1.Foreground = color;
                    tbdThu1.Foreground = color;
                    tbdFri1.Foreground = color;


                    break;
            }
        }
        private void addAfterDay()
        {
            DayinMonth finishdayofmonth = CalendarCus.DayAfter();
            DateTime now = DateTime.Now;
            int totaldaymonth = DateTime.DaysInMonth(now.Year, now.Month);
            //Date 1/month/year
            DateTime firstdmonth = new DateTime(now.Year, now.Month, 1);
            string firstd = firstdmonth.DayOfWeek.ToString();
            //color
            Brush color = ConvertColor(129, 152, 177);
            switch (firstd)
            {
                case "Sunday":
                    if (totaldaymonth == 31)
                    {
                        tbdWed5.DataContext = finishdayofmonth;
                        tbdThu5.DataContext = finishdayofmonth;
                        tbdFri5.DataContext = finishdayofmonth;
                        tbdSat5.DataContext = finishdayofmonth;
                        tbdSun6.DataContext = finishdayofmonth;
                        tbdMon6.DataContext = finishdayofmonth;
                        tbdTue6.DataContext = finishdayofmonth;
                        tbdWed6.DataContext = finishdayofmonth;
                        tbdThu6.DataContext = finishdayofmonth;
                        tbdFri6.DataContext = finishdayofmonth;
                        tbdSat6.DataContext = finishdayofmonth;
                        //color
                        tbdWed5.Foreground = color;
                        tbdThu5.Foreground = color;
                        tbdFri5.Foreground = color;
                        tbdSat5.Foreground = color;
                        tbdSun6.Foreground = color;
                        tbdMon6.Foreground = color;
                        tbdTue6.Foreground = color;
                        tbdWed6.Foreground = color;
                        tbdThu6.Foreground = color;
                        tbdFri6.Foreground = color;
                        tbdSat6.Foreground = color;


                    }
                    else if (totaldaymonth == 30)
                    {
                        tbdTue5.DataContext = finishdayofmonth;
                        tbdWed5.DataContext = finishdayofmonth;
                        tbdThu5.DataContext = finishdayofmonth;
                        tbdFri5.DataContext = finishdayofmonth;
                        tbdSat5.DataContext = finishdayofmonth;
                        tbdSun6.DataContext = finishdayofmonth;
                        tbdMon6.DataContext = finishdayofmonth;
                        tbdTue6.DataContext = finishdayofmonth;
                        tbdWed6.DataContext = finishdayofmonth;
                        tbdThu6.DataContext = finishdayofmonth;
                        tbdFri6.DataContext = finishdayofmonth;
                        tbdSat6.DataContext = finishdayofmonth;
                        //color
                        tbdTue5.Foreground = color;
                        tbdWed5.Foreground = color;
                        tbdThu5.Foreground = color;
                        tbdFri5.Foreground = color;
                        tbdSat5.Foreground = color;
                        tbdSun6.Foreground = color;
                        tbdMon6.Foreground = color;
                        tbdTue6.Foreground = color;
                        tbdWed6.Foreground = color;
                        tbdThu6.Foreground = color;
                        tbdFri6.Foreground = color;
                        tbdSat6.Foreground = color;

                    }
                    else if (totaldaymonth == 29)
                    {
                        tbdMon5.DataContext = finishdayofmonth;
                        tbdTue5.DataContext = finishdayofmonth;
                        tbdWed5.DataContext = finishdayofmonth;
                        tbdThu5.DataContext = finishdayofmonth;
                        tbdFri5.DataContext = finishdayofmonth;
                        tbdSat5.DataContext = finishdayofmonth;
                        tbdSun6.DataContext = finishdayofmonth;
                        tbdMon6.DataContext = finishdayofmonth;
                        tbdTue6.DataContext = finishdayofmonth;
                        tbdWed6.DataContext = finishdayofmonth;
                        tbdThu6.DataContext = finishdayofmonth;
                        tbdFri6.DataContext = finishdayofmonth;
                        tbdSat6.DataContext = finishdayofmonth;
                        //color
                        tbdMon5.Foreground = color;
                        tbdTue5.Foreground = color;
                        tbdWed5.Foreground = color;
                        tbdThu5.Foreground = color;
                        tbdFri5.Foreground = color;
                        tbdSat5.Foreground = color;
                        tbdSun6.Foreground = color;
                        tbdMon6.Foreground = color;
                        tbdTue6.Foreground = color;
                        tbdWed6.Foreground = color;
                        tbdThu6.Foreground = color;
                        tbdFri6.Foreground = color;
                        tbdSat6.Foreground = color;

                    }
                    else if (totaldaymonth == 28)
                    {
                        tbdSun5.DataContext = finishdayofmonth;
                        tbdMon5.DataContext = finishdayofmonth;
                        tbdTue5.DataContext = finishdayofmonth;
                        tbdWed5.DataContext = finishdayofmonth;
                        tbdThu5.DataContext = finishdayofmonth;
                        tbdFri5.DataContext = finishdayofmonth;
                        tbdSat5.DataContext = finishdayofmonth;
                        tbdSun6.DataContext = finishdayofmonth;
                        tbdMon6.DataContext = finishdayofmonth;
                        tbdTue6.DataContext = finishdayofmonth;
                        tbdWed6.DataContext = finishdayofmonth;
                        tbdThu6.DataContext = finishdayofmonth;
                        tbdFri6.DataContext = finishdayofmonth;
                        tbdSat6.DataContext = finishdayofmonth;
                        //color
                        tbdSun5.Foreground = color;
                        tbdMon5.Foreground = color;
                        tbdTue5.Foreground = color;
                        tbdWed5.Foreground = color;
                        tbdThu5.Foreground = color;
                        tbdFri5.Foreground = color;
                        tbdSat5.Foreground = color;
                        tbdSun6.Foreground = color;
                        tbdMon6.Foreground = color;
                        tbdTue6.Foreground = color;
                        tbdWed6.Foreground = color;
                        tbdThu6.Foreground = color;
                        tbdFri6.Foreground = color;
                        tbdSat6.Foreground = color;

                    }
                    break;
                case "Monday":
                    if (totaldaymonth == 31)
                    {
                        tbdThu5.DataContext = finishdayofmonth;
                        tbdFri5.DataContext = finishdayofmonth;
                        tbdSat5.DataContext = finishdayofmonth;
                        tbdSun6.DataContext = finishdayofmonth;
                        tbdMon6.DataContext = finishdayofmonth;
                        tbdTue6.DataContext = finishdayofmonth;
                        tbdWed6.DataContext = finishdayofmonth;
                        tbdThu6.DataContext = finishdayofmonth;
                        tbdFri6.DataContext = finishdayofmonth;
                        tbdSat6.DataContext = finishdayofmonth;
                        //color
                        tbdThu5.Foreground = color;
                        tbdFri5.Foreground = color;
                        tbdSat5.Foreground = color;
                        tbdSun6.Foreground = color;
                        tbdMon6.Foreground = color;
                        tbdTue6.Foreground = color;
                        tbdWed6.Foreground = color;
                        tbdThu6.Foreground = color;
                        tbdFri6.Foreground = color;
                        tbdSat6.Foreground = color;

                    }
                    else if (totaldaymonth == 30)
                    {
                        tbdWed5.DataContext = finishdayofmonth;
                        tbdThu5.DataContext = finishdayofmonth;
                        tbdFri5.DataContext = finishdayofmonth;
                        tbdSat5.DataContext = finishdayofmonth;
                        tbdSun6.DataContext = finishdayofmonth;
                        tbdMon6.DataContext = finishdayofmonth;
                        tbdTue6.DataContext = finishdayofmonth;
                        tbdWed6.DataContext = finishdayofmonth;
                        tbdThu6.DataContext = finishdayofmonth;
                        tbdFri6.DataContext = finishdayofmonth;
                        tbdSat6.DataContext = finishdayofmonth;
                        //color
                        tbdWed5.Foreground = color;
                        tbdThu5.Foreground = color;
                        tbdFri5.Foreground = color;
                        tbdSat5.Foreground = color;
                        tbdSun6.Foreground = color;
                        tbdMon6.Foreground = color;
                        tbdTue6.Foreground = color;
                        tbdWed6.Foreground = color;
                        tbdThu6.Foreground = color;
                        tbdFri6.Foreground = color;
                        tbdSat6.Foreground = color;
                    }
                    else if (totaldaymonth == 29)
                    {
                        tbdTue5.DataContext = finishdayofmonth;
                        tbdWed5.DataContext = finishdayofmonth;
                        tbdThu5.DataContext = finishdayofmonth;
                        tbdFri5.DataContext = finishdayofmonth;
                        tbdSat5.DataContext = finishdayofmonth;
                        tbdSun6.DataContext = finishdayofmonth;
                        tbdMon6.DataContext = finishdayofmonth;
                        tbdTue6.DataContext = finishdayofmonth;
                        tbdWed6.DataContext = finishdayofmonth;
                        tbdThu6.DataContext = finishdayofmonth;
                        tbdFri6.DataContext = finishdayofmonth;
                        tbdSat6.DataContext = finishdayofmonth;
                        //color
                        tbdTue5.Foreground = color;
                        tbdWed5.Foreground = color;
                        tbdThu5.Foreground = color;
                        tbdFri5.Foreground = color;
                        tbdSat5.Foreground = color;
                        tbdSun6.Foreground = color;
                        tbdMon6.Foreground = color;
                        tbdTue6.Foreground = color;
                        tbdWed6.Foreground = color;
                        tbdThu6.Foreground = color;
                        tbdFri6.Foreground = color;
                        tbdSat6.Foreground = color;

                    }
                    else if (totaldaymonth == 28)
                    {
                        tbdMon5.DataContext = finishdayofmonth;
                        tbdTue5.DataContext = finishdayofmonth;
                        tbdWed5.DataContext = finishdayofmonth;
                        tbdThu5.DataContext = finishdayofmonth;
                        tbdFri5.DataContext = finishdayofmonth;
                        tbdSat5.DataContext = finishdayofmonth;
                        tbdSun6.DataContext = finishdayofmonth;
                        tbdMon6.DataContext = finishdayofmonth;
                        tbdTue6.DataContext = finishdayofmonth;
                        tbdWed6.DataContext = finishdayofmonth;
                        tbdThu6.DataContext = finishdayofmonth;
                        tbdFri6.DataContext = finishdayofmonth;
                        tbdSat6.DataContext = finishdayofmonth;
                        //color
                        tbdMon5.Foreground = color;
                        tbdTue5.Foreground = color;
                        tbdWed5.Foreground = color;
                        tbdThu5.Foreground = color;
                        tbdFri5.Foreground = color;
                        tbdSat5.Foreground = color;
                        tbdSun6.Foreground = color;
                        tbdMon6.Foreground = color;
                        tbdTue6.Foreground = color;
                        tbdWed6.Foreground = color;
                        tbdThu6.Foreground = color;
                        tbdFri6.Foreground = color;
                        tbdSat6.Foreground = color;

                    }

                    break;
                case "Tuesday":
                    if (totaldaymonth == 31)
                    {
                        tbdFri5.DataContext = finishdayofmonth;
                        tbdSat5.DataContext = finishdayofmonth;
                        tbdSun6.DataContext = finishdayofmonth;
                        tbdMon6.DataContext = finishdayofmonth;
                        tbdTue6.DataContext = finishdayofmonth;
                        tbdWed6.DataContext = finishdayofmonth;
                        tbdThu6.DataContext = finishdayofmonth;
                        tbdFri6.DataContext = finishdayofmonth;
                        tbdSat6.DataContext = finishdayofmonth;
                        //color
                        tbdFri5.Foreground = color;
                        tbdSat5.Foreground = color;
                        tbdSun6.Foreground = color;
                        tbdMon6.Foreground = color;
                        tbdTue6.Foreground = color;
                        tbdWed6.Foreground = color;
                        tbdThu6.Foreground = color;
                        tbdFri6.Foreground = color;
                        tbdSat6.Foreground = color;
                    }
                    else if (totaldaymonth == 30)
                    {
                        tbdThu5.DataContext = finishdayofmonth;
                        tbdFri5.DataContext = finishdayofmonth;
                        tbdSat5.DataContext = finishdayofmonth;
                        tbdSun6.DataContext = finishdayofmonth;
                        tbdMon6.DataContext = finishdayofmonth;
                        tbdTue6.DataContext = finishdayofmonth;
                        tbdWed6.DataContext = finishdayofmonth;
                        tbdThu6.DataContext = finishdayofmonth;
                        tbdFri6.DataContext = finishdayofmonth;
                        tbdSat6.DataContext = finishdayofmonth;
                        //color
                        tbdThu5.Foreground = color;
                        tbdFri5.Foreground = color;
                        tbdSat5.Foreground = color;
                        tbdSun6.Foreground = color;
                        tbdMon6.Foreground = color;
                        tbdTue6.Foreground = color;
                        tbdWed6.Foreground = color;
                        tbdThu6.Foreground = color;
                        tbdFri6.Foreground = color;
                        tbdSat6.Foreground = color;

                    }
                    else if (totaldaymonth == 29)
                    {
                        tbdWed5.DataContext = finishdayofmonth;
                        tbdThu5.DataContext = finishdayofmonth;
                        tbdFri5.DataContext = finishdayofmonth;
                        tbdSat5.DataContext = finishdayofmonth;
                        tbdSun6.DataContext = finishdayofmonth;
                        tbdMon6.DataContext = finishdayofmonth;
                        tbdTue6.DataContext = finishdayofmonth;
                        tbdWed6.DataContext = finishdayofmonth;
                        tbdThu6.DataContext = finishdayofmonth;
                        tbdFri6.DataContext = finishdayofmonth;
                        tbdSat6.DataContext = finishdayofmonth;
                        //color
                        tbdWed5.Foreground = color;
                        tbdThu5.Foreground = color;
                        tbdFri5.Foreground = color;
                        tbdSat5.Foreground = color;
                        tbdSun6.Foreground = color;
                        tbdMon6.Foreground = color;
                        tbdTue6.Foreground = color;
                        tbdWed6.Foreground = color;
                        tbdThu6.Foreground = color;
                        tbdFri6.Foreground = color;
                        tbdSat6.Foreground = color;

                    }
                    else if (totaldaymonth == 28)
                    {
                        tbdTue5.DataContext = finishdayofmonth;
                        tbdWed5.DataContext = finishdayofmonth;
                        tbdThu5.DataContext = finishdayofmonth;
                        tbdFri5.DataContext = finishdayofmonth;
                        tbdSat5.DataContext = finishdayofmonth;
                        tbdSun6.DataContext = finishdayofmonth;
                        tbdMon6.DataContext = finishdayofmonth;
                        tbdTue6.DataContext = finishdayofmonth;
                        tbdWed6.DataContext = finishdayofmonth;
                        tbdThu6.DataContext = finishdayofmonth;
                        tbdFri6.DataContext = finishdayofmonth;
                        tbdSat6.DataContext = finishdayofmonth;
                        //color
                        tbdTue5.Foreground = color;
                        tbdWed5.Foreground = color;
                        tbdThu5.Foreground = color;
                        tbdFri5.Foreground = color;
                        tbdSat5.Foreground = color;
                        tbdSun6.Foreground = color;
                        tbdMon6.Foreground = color;
                        tbdTue6.Foreground = color;
                        tbdWed6.Foreground = color;
                        tbdThu6.Foreground = color;
                        tbdFri6.Foreground = color;
                        tbdSat6.Foreground = color;

                    }

                    break;
                case "Wednesday":
                    if (totaldaymonth == 31)
                    {
                        tbdSat5.DataContext = finishdayofmonth;
                        tbdSun6.DataContext = finishdayofmonth;
                        tbdMon6.DataContext = finishdayofmonth;
                        tbdTue6.DataContext = finishdayofmonth;
                        tbdWed6.DataContext = finishdayofmonth;
                        tbdThu6.DataContext = finishdayofmonth;
                        tbdFri6.DataContext = finishdayofmonth;
                        tbdSat6.DataContext = finishdayofmonth;
                        //color
                        tbdSat5.Foreground = color;
                        tbdSun6.Foreground = color;
                        tbdMon6.Foreground = color;
                        tbdTue6.Foreground = color;
                        tbdWed6.Foreground = color;
                        tbdThu6.Foreground = color;
                        tbdFri6.Foreground = color;
                        tbdSat6.Foreground = color;

                    }
                    else if (totaldaymonth == 30)
                    {

                        tbdFri5.DataContext = finishdayofmonth;
                        tbdSat5.DataContext = finishdayofmonth;
                        tbdSun6.DataContext = finishdayofmonth;
                        tbdMon6.DataContext = finishdayofmonth;
                        tbdTue6.DataContext = finishdayofmonth;
                        tbdWed6.DataContext = finishdayofmonth;
                        tbdThu6.DataContext = finishdayofmonth;
                        tbdFri6.DataContext = finishdayofmonth;
                        tbdSat6.DataContext = finishdayofmonth;
                        //color
                        tbdFri5.Foreground = color;
                        tbdSat5.Foreground = color;
                        tbdSun6.Foreground = color;
                        tbdMon6.Foreground = color;
                        tbdTue6.Foreground = color;
                        tbdWed6.Foreground = color;
                        tbdThu6.Foreground = color;
                        tbdFri6.Foreground = color;
                        tbdSat6.Foreground = color;
                    }
                    else if (totaldaymonth == 29)
                    {
                        tbdThu5.DataContext = finishdayofmonth;
                        tbdFri5.DataContext = finishdayofmonth;
                        tbdSat5.DataContext = finishdayofmonth;
                        tbdSun6.DataContext = finishdayofmonth;
                        tbdMon6.DataContext = finishdayofmonth;
                        tbdTue6.DataContext = finishdayofmonth;
                        tbdWed6.DataContext = finishdayofmonth;
                        tbdThu6.DataContext = finishdayofmonth;
                        tbdFri6.DataContext = finishdayofmonth;
                        tbdSat6.DataContext = finishdayofmonth;
                        //color
                        tbdThu5.Foreground = color;
                        tbdFri5.Foreground = color;
                        tbdSat5.Foreground = color;
                        tbdSun6.Foreground = color;
                        tbdMon6.Foreground = color;
                        tbdTue6.Foreground = color;
                        tbdWed6.Foreground = color;
                        tbdThu6.Foreground = color;
                        tbdFri6.Foreground = color;
                        tbdSat6.Foreground = color;

                    }
                    else if (totaldaymonth == 28)
                    {
                        tbdWed5.DataContext = finishdayofmonth;
                        tbdThu5.DataContext = finishdayofmonth;
                        tbdFri5.DataContext = finishdayofmonth;
                        tbdSat5.DataContext = finishdayofmonth;
                        tbdSun6.DataContext = finishdayofmonth;
                        tbdMon6.DataContext = finishdayofmonth;
                        tbdTue6.DataContext = finishdayofmonth;
                        tbdWed6.DataContext = finishdayofmonth;
                        tbdThu6.DataContext = finishdayofmonth;
                        tbdFri6.DataContext = finishdayofmonth;
                        tbdSat6.DataContext = finishdayofmonth;
                        //color
                        tbdWed5.Foreground = color;
                        tbdThu5.Foreground = color;
                        tbdFri5.Foreground = color;
                        tbdSat5.Foreground = color;
                        tbdSun6.Foreground = color;
                        tbdMon6.Foreground = color;
                        tbdTue6.Foreground = color;
                        tbdWed6.Foreground = color;
                        tbdThu6.Foreground = color;
                        tbdFri6.Foreground = color;
                        tbdSat6.Foreground = color;

                    }

                    break;
                case "Thursday":
                    if (totaldaymonth == 31)
                    {
                        tbdSun6.DataContext = finishdayofmonth;
                        tbdMon6.DataContext = finishdayofmonth;
                        tbdTue6.DataContext = finishdayofmonth;
                        tbdWed6.DataContext = finishdayofmonth;
                        tbdThu6.DataContext = finishdayofmonth;
                        tbdFri6.DataContext = finishdayofmonth;
                        tbdSat6.DataContext = finishdayofmonth;
                        //color
                        tbdSun6.Foreground = color;
                        tbdMon6.Foreground = color;
                        tbdTue6.Foreground = color;
                        tbdWed6.Foreground = color;
                        tbdThu6.Foreground = color;
                        tbdFri6.Foreground = color;
                        tbdSat6.Foreground = color;

                    }
                    else if (totaldaymonth == 30)
                    {
                        tbdSat5.DataContext = finishdayofmonth;
                        tbdSun6.DataContext = finishdayofmonth;
                        tbdMon6.DataContext = finishdayofmonth;
                        tbdTue6.DataContext = finishdayofmonth;
                        tbdWed6.DataContext = finishdayofmonth;
                        tbdThu6.DataContext = finishdayofmonth;
                        tbdFri6.DataContext = finishdayofmonth;
                        tbdSat6.DataContext = finishdayofmonth;
                        //color
                        tbdSat5.Foreground = color;
                        tbdSun6.Foreground = color;
                        tbdMon6.Foreground = color;
                        tbdTue6.Foreground = color;
                        tbdWed6.Foreground = color;
                        tbdThu6.Foreground = color;
                        tbdFri6.Foreground = color;
                        tbdSat6.Foreground = color;

                    }
                    else if (totaldaymonth == 29)
                    {
                        tbdFri5.DataContext = finishdayofmonth;
                        tbdSat5.DataContext = finishdayofmonth;
                        tbdSun6.DataContext = finishdayofmonth;
                        tbdMon6.DataContext = finishdayofmonth;
                        tbdTue6.DataContext = finishdayofmonth;
                        tbdWed6.DataContext = finishdayofmonth;
                        tbdThu6.DataContext = finishdayofmonth;
                        tbdFri6.DataContext = finishdayofmonth;
                        tbdSat6.DataContext = finishdayofmonth;
                        //color
                        tbdFri5.Foreground = color;
                        tbdSat5.Foreground = color;
                        tbdSun6.Foreground = color;
                        tbdMon6.Foreground = color;
                        tbdTue6.Foreground = color;
                        tbdWed6.Foreground = color;
                        tbdThu6.Foreground = color;
                        tbdFri6.Foreground = color;
                        tbdSat6.Foreground = color;
                    }
                    else if (totaldaymonth == 28)
                    {
                        tbdThu5.DataContext = finishdayofmonth;
                        tbdFri5.DataContext = finishdayofmonth;
                        tbdSat5.DataContext = finishdayofmonth;
                        tbdSun6.DataContext = finishdayofmonth;
                        tbdMon6.DataContext = finishdayofmonth;
                        tbdTue6.DataContext = finishdayofmonth;
                        tbdWed6.DataContext = finishdayofmonth;
                        tbdThu6.DataContext = finishdayofmonth;
                        tbdFri6.DataContext = finishdayofmonth;
                        tbdSat6.DataContext = finishdayofmonth;
                        //color
                        tbdThu5.Foreground = color;
                        tbdFri5.Foreground = color;
                        tbdSat5.Foreground = color;
                        tbdSun6.Foreground = color;
                        tbdMon6.Foreground = color;
                        tbdTue6.Foreground = color;
                        tbdWed6.Foreground = color;
                        tbdThu6.Foreground = color;
                        tbdFri6.Foreground = color;
                        tbdSat6.Foreground = color;

                    }

                    break;
                case "Friday":
                    if (totaldaymonth == 31)
                    {
                        tbdMon6.DataContext = finishdayofmonth;
                        tbdTue6.DataContext = finishdayofmonth;
                        tbdWed6.DataContext = finishdayofmonth;
                        tbdThu6.DataContext = finishdayofmonth;
                        tbdFri6.DataContext = finishdayofmonth;
                        tbdSat6.DataContext = finishdayofmonth;
                        //color
                        tbdMon6.Foreground = color;
                        tbdTue6.Foreground = color;
                        tbdWed6.Foreground = color;
                        tbdThu6.Foreground = color;
                        tbdFri6.Foreground = color;
                        tbdSat6.Foreground = color;

                    }
                    else if (totaldaymonth == 30)
                    {
                        tbdSun6.DataContext = finishdayofmonth;
                        tbdMon6.DataContext = finishdayofmonth;
                        tbdTue6.DataContext = finishdayofmonth;
                        tbdWed6.DataContext = finishdayofmonth;
                        tbdThu6.DataContext = finishdayofmonth;
                        tbdFri6.DataContext = finishdayofmonth;
                        tbdSat6.DataContext = finishdayofmonth;
                        //color
                        tbdSun6.Foreground = color;
                        tbdMon6.Foreground = color;
                        tbdTue6.Foreground = color;
                        tbdWed6.Foreground = color;
                        tbdThu6.Foreground = color;
                        tbdFri6.Foreground = color;
                        tbdSat6.Foreground = color;

                    }
                    else if (totaldaymonth == 29)
                    {
                        tbdSat5.DataContext = finishdayofmonth;
                        tbdSun6.DataContext = finishdayofmonth;
                        tbdMon6.DataContext = finishdayofmonth;
                        tbdTue6.DataContext = finishdayofmonth;
                        tbdWed6.DataContext = finishdayofmonth;
                        tbdThu6.DataContext = finishdayofmonth;
                        tbdFri6.DataContext = finishdayofmonth;
                        tbdSat6.DataContext = finishdayofmonth;
                        //color
                        tbdSat5.Foreground = color;
                        tbdSun6.Foreground = color;
                        tbdMon6.Foreground = color;
                        tbdTue6.Foreground = color;
                        tbdWed6.Foreground = color;
                        tbdThu6.Foreground = color;
                        tbdFri6.Foreground = color;
                        tbdSat6.Foreground = color;


                    }
                    else if (totaldaymonth == 28)
                    {

                        tbdFri5.DataContext = finishdayofmonth;
                        tbdSat5.DataContext = finishdayofmonth;
                        tbdSun6.DataContext = finishdayofmonth;
                        tbdMon6.DataContext = finishdayofmonth;
                        tbdTue6.DataContext = finishdayofmonth;
                        tbdWed6.DataContext = finishdayofmonth;
                        tbdThu6.DataContext = finishdayofmonth;
                        tbdFri6.DataContext = finishdayofmonth;
                        tbdSat6.DataContext = finishdayofmonth;
                        //color
                        tbdFri5.Foreground = color;
                        tbdSat5.Foreground = color;
                        tbdSun6.Foreground = color;
                        tbdMon6.Foreground = color;
                        tbdTue6.Foreground = color;
                        tbdWed6.Foreground = color;
                        tbdThu6.Foreground = color;
                        tbdFri6.Foreground = color;
                        tbdSat6.Foreground = color;
                    }

                    break;
                case "Saturday":
                    if (totaldaymonth == 31)
                    {
                        tbdTue6.DataContext = finishdayofmonth;
                        tbdWed6.DataContext = finishdayofmonth;
                        tbdThu6.DataContext = finishdayofmonth;
                        tbdFri6.DataContext = finishdayofmonth;
                        tbdSat6.DataContext = finishdayofmonth;
                        //color
                        tbdTue6.Foreground = color;
                        tbdWed6.Foreground = color;
                        tbdThu6.Foreground = color;
                        tbdFri6.Foreground = color;
                        tbdSat6.Foreground = color;

                    }
                    else if (totaldaymonth == 30)
                    {
                        tbdMon6.DataContext = finishdayofmonth;
                        tbdTue6.DataContext = finishdayofmonth;
                        tbdWed6.DataContext = finishdayofmonth;
                        tbdThu6.DataContext = finishdayofmonth;
                        tbdFri6.DataContext = finishdayofmonth;
                        tbdSat6.DataContext = finishdayofmonth;
                        //color
                        tbdMon6.Foreground = color;
                        tbdTue6.Foreground = color;
                        tbdWed6.Foreground = color;
                        tbdThu6.Foreground = color;
                        tbdFri6.Foreground = color;
                        tbdSat6.Foreground = color;

                    }
                    else if (totaldaymonth == 29)
                    {

                        tbdSun6.DataContext = finishdayofmonth;
                        tbdMon6.DataContext = finishdayofmonth;
                        tbdTue6.DataContext = finishdayofmonth;
                        tbdWed6.DataContext = finishdayofmonth;
                        tbdThu6.DataContext = finishdayofmonth;
                        tbdFri6.DataContext = finishdayofmonth;
                        tbdSat6.DataContext = finishdayofmonth;
                        //color
                        tbdSun6.Foreground = color;
                        tbdMon6.Foreground = color;
                        tbdTue6.Foreground = color;
                        tbdWed6.Foreground = color;
                        tbdThu6.Foreground = color;
                        tbdFri6.Foreground = color;
                        tbdSat6.Foreground = color;
                    }
                    else if (totaldaymonth == 28)
                    {
                        tbdSat5.DataContext = finishdayofmonth;
                        tbdSun6.DataContext = finishdayofmonth;
                        tbdMon6.DataContext = finishdayofmonth;
                        tbdTue6.DataContext = finishdayofmonth;
                        tbdWed6.DataContext = finishdayofmonth;
                        tbdThu6.DataContext = finishdayofmonth;
                        tbdFri6.DataContext = finishdayofmonth;
                        tbdSat6.DataContext = finishdayofmonth;
                        //color
                        tbdSat5.Foreground = color;
                        tbdSun6.Foreground = color;
                        tbdMon6.Foreground = color;
                        tbdTue6.Foreground = color;
                        tbdWed6.Foreground = color;
                        tbdThu6.Foreground = color;
                        tbdFri6.Foreground = color;
                        tbdSat6.Foreground = color;

                    }
                    break;



            }
        }
        private void addDayinMonth()
        {
            DayinMonth daynow = CalendarCus.DaysMonth();
            DateTime now = DateTime.Now;
            DateTime day1inmonth = new DateTime(now.Year, now.Month, 1);
            string nameday = day1inmonth.DayOfWeek.ToString();

            int totaldaymonth = DateTime.DaysInMonth(now.Year, now.Month);

            //background datenow
            BGDayNow(daynow, now.Month.ToString(), now.Year.ToString());


            Brush color = ConvertColor(253, 253, 253);


            //get day now
            switch (nameday)
            {
                case "Sunday":

                    if (totaldaymonth == 31)
                    {

                        tbdSun1.DataContext = daynow;
                        tbdMon1.DataContext = daynow;
                        tbdTue1.DataContext = daynow;
                        tbdWed1.DataContext = daynow;
                        tbdThu1.DataContext = daynow;
                        tbdFri1.DataContext = daynow;
                        tbdSat1.DataContext = daynow;
                        //2
                        tbdSun2.DataContext = daynow;
                        tbdMon2.DataContext = daynow;
                        tbdTue2.DataContext = daynow;
                        tbdWed2.DataContext = daynow;
                        tbdThu2.DataContext = daynow;
                        tbdFri2.DataContext = daynow;
                        tbdSat2.DataContext = daynow;
                        //3
                        tbdSun3.DataContext = daynow;
                        tbdMon3.DataContext = daynow;
                        tbdTue3.DataContext = daynow;
                        tbdWed3.DataContext = daynow;
                        tbdThu3.DataContext = daynow;
                        tbdFri3.DataContext = daynow;
                        tbdSat3.DataContext = daynow;
                        //4
                        tbdSun4.DataContext = daynow;
                        tbdMon4.DataContext = daynow;
                        tbdTue4.DataContext = daynow;
                        tbdWed4.DataContext = daynow;
                        tbdThu4.DataContext = daynow;
                        tbdFri4.DataContext = daynow;
                        tbdSat4.DataContext = daynow;
                        //5
                        tbdSun5.DataContext = daynow;
                        tbdMon5.DataContext = daynow;
                        tbdTue5.DataContext = daynow;
                        //Color day 
                        tbdSun1.Foreground = color;
                        tbdMon1.Foreground = color;
                        tbdTue1.Foreground = color;
                        tbdWed1.Foreground = color;
                        tbdThu1.Foreground = color;
                        tbdFri1.Foreground = color;
                        tbdSat1.Foreground = color;
                        //2
                        tbdSun2.Foreground = color;
                        tbdMon2.Foreground = color;
                        tbdTue2.Foreground = color;
                        tbdWed2.Foreground = color;
                        tbdThu2.Foreground = color;
                        tbdFri2.Foreground = color;
                        tbdSat2.Foreground = color;
                        //3
                        tbdSun3.Foreground = color;
                        tbdMon3.Foreground = color;
                        tbdTue3.Foreground = color;
                        tbdWed3.Foreground = color;
                        tbdThu3.Foreground = color;
                        tbdFri3.Foreground = color;
                        tbdSat3.Foreground = color;
                        //4
                        tbdSun4.Foreground = color;
                        tbdMon4.Foreground = color;
                        tbdTue4.Foreground = color;
                        tbdWed4.Foreground = color;
                        tbdThu4.Foreground = color;
                        tbdFri4.Foreground = color;
                        tbdSat4.Foreground = color;
                        //5
                        tbdSun5.Foreground = color;
                        tbdMon5.Foreground = color;
                        tbdTue5.Foreground = color;

                    }
                    else if (totaldaymonth == 30)
                    {
                        tbdSun1.DataContext = daynow;
                        tbdMon1.DataContext = daynow;
                        tbdTue1.DataContext = daynow;
                        tbdWed1.DataContext = daynow;
                        tbdThu1.DataContext = daynow;
                        tbdFri1.DataContext = daynow;
                        tbdSat1.DataContext = daynow;
                        //2
                        tbdSun2.DataContext = daynow;
                        tbdMon2.DataContext = daynow;
                        tbdTue2.DataContext = daynow;
                        tbdWed2.DataContext = daynow;
                        tbdThu2.DataContext = daynow;
                        tbdFri2.DataContext = daynow;
                        tbdSat2.DataContext = daynow;
                        //3
                        tbdSun3.DataContext = daynow;
                        tbdMon3.DataContext = daynow;
                        tbdTue3.DataContext = daynow;
                        tbdWed3.DataContext = daynow;
                        tbdThu3.DataContext = daynow;
                        tbdFri3.DataContext = daynow;
                        tbdSat3.DataContext = daynow;
                        //4
                        tbdSun4.DataContext = daynow;
                        tbdMon4.DataContext = daynow;
                        tbdTue4.DataContext = daynow;
                        tbdWed4.DataContext = daynow;
                        tbdThu4.DataContext = daynow;
                        tbdFri4.DataContext = daynow;
                        tbdSat4.DataContext = daynow;
                        //5
                        tbdSun5.DataContext = daynow;
                        tbdMon5.DataContext = daynow;
                        //Color day 
                        tbdSun1.Foreground = color;
                        tbdMon1.Foreground = color;
                        tbdTue1.Foreground = color;
                        tbdWed1.Foreground = color;
                        tbdThu1.Foreground = color;
                        tbdFri1.Foreground = color;
                        tbdSat1.Foreground = color;
                        //2
                        tbdSun2.Foreground = color;
                        tbdMon2.Foreground = color;
                        tbdTue2.Foreground = color;
                        tbdWed2.Foreground = color;
                        tbdThu2.Foreground = color;
                        tbdFri2.Foreground = color;
                        tbdSat2.Foreground = color;
                        //3
                        tbdSun3.Foreground = color;
                        tbdMon3.Foreground = color;
                        tbdTue3.Foreground = color;
                        tbdWed3.Foreground = color;
                        tbdThu3.Foreground = color;
                        tbdFri3.Foreground = color;
                        tbdSat3.Foreground = color;
                        //4
                        tbdSun4.Foreground = color;
                        tbdMon4.Foreground = color;
                        tbdTue4.Foreground = color;
                        tbdWed4.Foreground = color;
                        tbdThu4.Foreground = color;
                        tbdFri4.Foreground = color;
                        tbdSat4.Foreground = color;
                        //5
                        tbdSun5.Foreground = color;
                        tbdMon5.Foreground = color;

                    }
                    else if (totaldaymonth == 29)
                    {
                        tbdSun1.DataContext = daynow;
                        tbdMon1.DataContext = daynow;
                        tbdTue1.DataContext = daynow;
                        tbdWed1.DataContext = daynow;
                        tbdThu1.DataContext = daynow;
                        tbdFri1.DataContext = daynow;
                        tbdSat1.DataContext = daynow;
                        //2
                        tbdSun2.DataContext = daynow;
                        tbdMon2.DataContext = daynow;
                        tbdTue2.DataContext = daynow;
                        tbdWed2.DataContext = daynow;
                        tbdThu2.DataContext = daynow;
                        tbdFri2.DataContext = daynow;
                        tbdSat2.DataContext = daynow;
                        //3
                        tbdSun3.DataContext = daynow;
                        tbdMon3.DataContext = daynow;
                        tbdTue3.DataContext = daynow;
                        tbdWed3.DataContext = daynow;
                        tbdThu3.DataContext = daynow;
                        tbdFri3.DataContext = daynow;
                        tbdSat3.DataContext = daynow;
                        //4
                        tbdSun4.DataContext = daynow;
                        tbdMon4.DataContext = daynow;
                        tbdTue4.DataContext = daynow;
                        tbdWed4.DataContext = daynow;
                        tbdThu4.DataContext = daynow;
                        tbdFri4.DataContext = daynow;
                        tbdSat4.DataContext = daynow;
                        //5
                        tbdSun5.DataContext = daynow;
                        //Color day 
                        tbdSun1.Foreground = color;
                        tbdMon1.Foreground = color;
                        tbdTue1.Foreground = color;
                        tbdWed1.Foreground = color;
                        tbdThu1.Foreground = color;
                        tbdFri1.Foreground = color;
                        tbdSat1.Foreground = color;
                        //2
                        tbdSun2.Foreground = color;
                        tbdMon2.Foreground = color;
                        tbdTue2.Foreground = color;
                        tbdWed2.Foreground = color;
                        tbdThu2.Foreground = color;
                        tbdFri2.Foreground = color;
                        tbdSat2.Foreground = color;
                        //3
                        tbdSun3.Foreground = color;
                        tbdMon3.Foreground = color;
                        tbdTue3.Foreground = color;
                        tbdWed3.Foreground = color;
                        tbdThu3.Foreground = color;
                        tbdFri3.Foreground = color;
                        tbdSat3.Foreground = color;
                        //4
                        tbdSun4.Foreground = color;
                        tbdMon4.Foreground = color;
                        tbdTue4.Foreground = color;
                        tbdWed4.Foreground = color;
                        tbdThu4.Foreground = color;
                        tbdFri4.Foreground = color;
                        tbdSat4.Foreground = color;
                        //5
                        tbdSun5.Foreground = color;
                    }
                    else if (totaldaymonth == 28)
                    {
                        tbdSun1.DataContext = daynow;
                        tbdMon1.DataContext = daynow;
                        tbdTue1.DataContext = daynow;
                        tbdWed1.DataContext = daynow;
                        tbdThu1.DataContext = daynow;
                        tbdFri1.DataContext = daynow;
                        tbdSat1.DataContext = daynow;
                        //2
                        tbdSun2.DataContext = daynow;
                        tbdMon2.DataContext = daynow;
                        tbdTue2.DataContext = daynow;
                        tbdWed2.DataContext = daynow;
                        tbdThu2.DataContext = daynow;
                        tbdFri2.DataContext = daynow;
                        tbdSat2.DataContext = daynow;
                        //3
                        tbdSun3.DataContext = daynow;
                        tbdMon3.DataContext = daynow;
                        tbdTue3.DataContext = daynow;
                        tbdWed3.DataContext = daynow;
                        tbdThu3.DataContext = daynow;
                        tbdFri3.DataContext = daynow;
                        tbdSat3.DataContext = daynow;
                        //4
                        tbdSun4.DataContext = daynow;
                        tbdMon4.DataContext = daynow;
                        tbdTue4.DataContext = daynow;
                        tbdWed4.DataContext = daynow;
                        tbdThu4.DataContext = daynow;
                        tbdFri4.DataContext = daynow;
                        tbdSat4.DataContext = daynow;
                        //Color day 
                        tbdSun1.Foreground = color;
                        tbdMon1.Foreground = color;
                        tbdTue1.Foreground = color;
                        tbdWed1.Foreground = color;
                        tbdThu1.Foreground = color;
                        tbdFri1.Foreground = color;
                        tbdSat1.Foreground = color;
                        //2
                        tbdSun2.Foreground = color;
                        tbdMon2.Foreground = color;
                        tbdTue2.Foreground = color;
                        tbdWed2.Foreground = color;
                        tbdThu2.Foreground = color;
                        tbdFri2.Foreground = color;
                        tbdSat2.Foreground = color;
                        //3
                        tbdSun3.Foreground = color;
                        tbdMon3.Foreground = color;
                        tbdTue3.Foreground = color;
                        tbdWed3.Foreground = color;
                        tbdThu3.Foreground = color;
                        tbdFri3.Foreground = color;
                        tbdSat3.Foreground = color;
                        //4
                        tbdSun4.Foreground = color;
                        tbdMon4.Foreground = color;
                        tbdTue4.Foreground = color;
                        tbdWed4.Foreground = color;
                        tbdThu4.Foreground = color;
                        tbdFri4.Foreground = color;
                        tbdSat4.Foreground = color;
                    }




                    break;
                case "Monday":
                    if (totaldaymonth == 31)
                    {

                        tbdMon1.DataContext = daynow;
                        tbdTue1.DataContext = daynow;
                        tbdWed1.DataContext = daynow;
                        tbdThu1.DataContext = daynow;
                        tbdFri1.DataContext = daynow;
                        tbdSat1.DataContext = daynow;
                        //2
                        tbdSun2.DataContext = daynow;
                        tbdMon2.DataContext = daynow;
                        tbdTue2.DataContext = daynow;
                        tbdWed2.DataContext = daynow;
                        tbdThu2.DataContext = daynow;
                        tbdFri2.DataContext = daynow;
                        tbdSat2.DataContext = daynow;
                        //3
                        tbdSun3.DataContext = daynow;
                        tbdMon3.DataContext = daynow;
                        tbdTue3.DataContext = daynow;
                        tbdWed3.DataContext = daynow;
                        tbdThu3.DataContext = daynow;
                        tbdFri3.DataContext = daynow;
                        tbdSat3.DataContext = daynow;
                        //4
                        tbdSun4.DataContext = daynow;
                        tbdMon4.DataContext = daynow;
                        tbdTue4.DataContext = daynow;
                        tbdWed4.DataContext = daynow;
                        tbdThu4.DataContext = daynow;
                        tbdFri4.DataContext = daynow;
                        tbdSat4.DataContext = daynow;
                        //5
                        tbdSun5.DataContext = daynow;
                        tbdMon5.DataContext = daynow;
                        tbdTue5.DataContext = daynow;
                        tbdWed5.DataContext = daynow;
                        //Color day 

                        tbdMon1.Foreground = color;
                        tbdTue1.Foreground = color;
                        tbdWed1.Foreground = color;
                        tbdThu1.Foreground = color;
                        tbdFri1.Foreground = color;
                        tbdSat1.Foreground = color;
                        //2
                        tbdSun2.Foreground = color;
                        tbdMon2.Foreground = color;
                        tbdTue2.Foreground = color;
                        tbdWed2.Foreground = color;
                        tbdThu2.Foreground = color;
                        tbdFri2.Foreground = color;
                        tbdSat2.Foreground = color;
                        //3
                        tbdSun3.Foreground = color;
                        tbdMon3.Foreground = color;
                        tbdTue3.Foreground = color;
                        tbdWed3.Foreground = color;
                        tbdThu3.Foreground = color;
                        tbdFri3.Foreground = color;
                        tbdSat3.Foreground = color;
                        //4
                        tbdSun4.Foreground = color;
                        tbdMon4.Foreground = color;
                        tbdTue4.Foreground = color;
                        tbdWed4.Foreground = color;
                        tbdThu4.Foreground = color;
                        tbdFri4.Foreground = color;
                        tbdSat4.Foreground = color;
                        //5
                        tbdSun5.Foreground = color;
                        tbdMon5.Foreground = color;
                        tbdTue5.Foreground = color;
                        tbdWed5.Foreground = color;
                    }
                    else if (totaldaymonth == 30)
                    {
                        tbdMon1.DataContext = daynow;
                        tbdTue1.DataContext = daynow;
                        tbdWed1.DataContext = daynow;
                        tbdThu1.DataContext = daynow;
                        tbdFri1.DataContext = daynow;
                        tbdSat1.DataContext = daynow;
                        //2
                        tbdSun2.DataContext = daynow;
                        tbdMon2.DataContext = daynow;
                        tbdTue2.DataContext = daynow;
                        tbdWed2.DataContext = daynow;
                        tbdThu2.DataContext = daynow;
                        tbdFri2.DataContext = daynow;
                        tbdSat2.DataContext = daynow;
                        //3
                        tbdSun3.DataContext = daynow;
                        tbdMon3.DataContext = daynow;
                        tbdTue3.DataContext = daynow;
                        tbdWed3.DataContext = daynow;
                        tbdThu3.DataContext = daynow;
                        tbdFri3.DataContext = daynow;
                        tbdSat3.DataContext = daynow;
                        //4
                        tbdSun4.DataContext = daynow;
                        tbdMon4.DataContext = daynow;
                        tbdTue4.DataContext = daynow;
                        tbdWed4.DataContext = daynow;
                        tbdThu4.DataContext = daynow;
                        tbdFri4.DataContext = daynow;
                        tbdSat4.DataContext = daynow;
                        //5
                        tbdSun5.DataContext = daynow;
                        tbdMon5.DataContext = daynow;
                        tbdTue5.DataContext = daynow;
                        //Color day 

                        tbdMon1.Foreground = color;
                        tbdTue1.Foreground = color;
                        tbdWed1.Foreground = color;
                        tbdThu1.Foreground = color;
                        tbdFri1.Foreground = color;
                        tbdSat1.Foreground = color;
                        //2
                        tbdSun2.Foreground = color;
                        tbdMon2.Foreground = color;
                        tbdTue2.Foreground = color;
                        tbdWed2.Foreground = color;
                        tbdThu2.Foreground = color;
                        tbdFri2.Foreground = color;
                        tbdSat2.Foreground = color;
                        //3
                        tbdSun3.Foreground = color;
                        tbdMon3.Foreground = color;
                        tbdTue3.Foreground = color;
                        tbdWed3.Foreground = color;
                        tbdThu3.Foreground = color;
                        tbdFri3.Foreground = color;
                        tbdSat3.Foreground = color;
                        //4
                        tbdSun4.Foreground = color;
                        tbdMon4.Foreground = color;
                        tbdTue4.Foreground = color;
                        tbdWed4.Foreground = color;
                        tbdThu4.Foreground = color;
                        tbdFri4.Foreground = color;
                        tbdSat4.Foreground = color;
                        //5
                        tbdSun5.Foreground = color;
                        tbdMon5.Foreground = color;
                        tbdTue5.Foreground = color;

                    }
                    else if (totaldaymonth == 29)
                    {
                        tbdMon1.DataContext = daynow;
                        tbdTue1.DataContext = daynow;
                        tbdWed1.DataContext = daynow;
                        tbdThu1.DataContext = daynow;
                        tbdFri1.DataContext = daynow;
                        tbdSat1.DataContext = daynow;
                        //2
                        tbdSun2.DataContext = daynow;
                        tbdMon2.DataContext = daynow;
                        tbdTue2.DataContext = daynow;
                        tbdWed2.DataContext = daynow;
                        tbdThu2.DataContext = daynow;
                        tbdFri2.DataContext = daynow;
                        tbdSat2.DataContext = daynow;
                        //3
                        tbdSun3.DataContext = daynow;
                        tbdMon3.DataContext = daynow;
                        tbdTue3.DataContext = daynow;
                        tbdWed3.DataContext = daynow;
                        tbdThu3.DataContext = daynow;
                        tbdFri3.DataContext = daynow;
                        tbdSat3.DataContext = daynow;
                        //4
                        tbdSun4.DataContext = daynow;
                        tbdMon4.DataContext = daynow;
                        tbdTue4.DataContext = daynow;
                        tbdWed4.DataContext = daynow;
                        tbdThu4.DataContext = daynow;
                        tbdFri4.DataContext = daynow;
                        tbdSat4.DataContext = daynow;
                        //5
                        tbdSun5.DataContext = daynow;
                        tbdMon5.DataContext = daynow;
                        //Color day 

                        tbdMon1.Foreground = color;
                        tbdTue1.Foreground = color;
                        tbdWed1.Foreground = color;
                        tbdThu1.Foreground = color;
                        tbdFri1.Foreground = color;
                        tbdSat1.Foreground = color;
                        //2
                        tbdSun2.Foreground = color;
                        tbdMon2.Foreground = color;
                        tbdTue2.Foreground = color;
                        tbdWed2.Foreground = color;
                        tbdThu2.Foreground = color;
                        tbdFri2.Foreground = color;
                        tbdSat2.Foreground = color;
                        //3
                        tbdSun3.Foreground = color;
                        tbdMon3.Foreground = color;
                        tbdTue3.Foreground = color;
                        tbdWed3.Foreground = color;
                        tbdThu3.Foreground = color;
                        tbdFri3.Foreground = color;
                        tbdSat3.Foreground = color;
                        //4
                        tbdSun4.Foreground = color;
                        tbdMon4.Foreground = color;
                        tbdTue4.Foreground = color;
                        tbdWed4.Foreground = color;
                        tbdThu4.Foreground = color;
                        tbdFri4.Foreground = color;
                        tbdSat4.Foreground = color;
                        //5
                        tbdSun5.Foreground = color;
                        tbdMon5.Foreground = color;
                    }
                    else if (totaldaymonth == 28)
                    {
                        tbdMon1.DataContext = daynow;
                        tbdTue1.DataContext = daynow;
                        tbdWed1.DataContext = daynow;
                        tbdThu1.DataContext = daynow;
                        tbdFri1.DataContext = daynow;
                        tbdSat1.DataContext = daynow;
                        //2
                        tbdSun2.DataContext = daynow;
                        tbdMon2.DataContext = daynow;
                        tbdTue2.DataContext = daynow;
                        tbdWed2.DataContext = daynow;
                        tbdThu2.DataContext = daynow;
                        tbdFri2.DataContext = daynow;
                        tbdSat2.DataContext = daynow;
                        //3
                        tbdSun3.DataContext = daynow;
                        tbdMon3.DataContext = daynow;
                        tbdTue3.DataContext = daynow;
                        tbdWed3.DataContext = daynow;
                        tbdThu3.DataContext = daynow;
                        tbdFri3.DataContext = daynow;
                        tbdSat3.DataContext = daynow;
                        //4
                        tbdSun4.DataContext = daynow;
                        tbdMon4.DataContext = daynow;
                        tbdTue4.DataContext = daynow;
                        tbdWed4.DataContext = daynow;
                        tbdThu4.DataContext = daynow;
                        tbdFri4.DataContext = daynow;
                        tbdSat4.DataContext = daynow;
                        //5
                        tbdSun5.DataContext = daynow;
                        //Color day 

                        tbdMon1.Foreground = color;
                        tbdTue1.Foreground = color;
                        tbdWed1.Foreground = color;
                        tbdThu1.Foreground = color;
                        tbdFri1.Foreground = color;
                        tbdSat1.Foreground = color;
                        //2
                        tbdSun2.Foreground = color;
                        tbdMon2.Foreground = color;
                        tbdTue2.Foreground = color;
                        tbdWed2.Foreground = color;
                        tbdThu2.Foreground = color;
                        tbdFri2.Foreground = color;
                        tbdSat2.Foreground = color;
                        //3
                        tbdSun3.Foreground = color;
                        tbdMon3.Foreground = color;
                        tbdTue3.Foreground = color;
                        tbdWed3.Foreground = color;
                        tbdThu3.Foreground = color;
                        tbdFri3.Foreground = color;
                        tbdSat3.Foreground = color;
                        //4
                        tbdSun4.Foreground = color;
                        tbdMon4.Foreground = color;
                        tbdTue4.Foreground = color;
                        tbdWed4.Foreground = color;
                        tbdThu4.Foreground = color;
                        tbdFri4.Foreground = color;
                        tbdSat4.Foreground = color;
                        //5
                        tbdSun5.Foreground = color;
                    }

                    break;
                case "Tuesday":
                    if (totaldaymonth == 31)
                    {
                        tbdTue1.DataContext = daynow;
                        tbdWed1.DataContext = daynow;
                        tbdThu1.DataContext = daynow;
                        tbdFri1.DataContext = daynow;
                        tbdSat1.DataContext = daynow;
                        //2
                        tbdSun2.DataContext = daynow;
                        tbdMon2.DataContext = daynow;
                        tbdTue2.DataContext = daynow;
                        tbdWed2.DataContext = daynow;
                        tbdThu2.DataContext = daynow;
                        tbdFri2.DataContext = daynow;
                        tbdSat2.DataContext = daynow;
                        //3
                        tbdSun3.DataContext = daynow;
                        tbdMon3.DataContext = daynow;
                        tbdTue3.DataContext = daynow;
                        tbdWed3.DataContext = daynow;
                        tbdThu3.DataContext = daynow;
                        tbdFri3.DataContext = daynow;
                        tbdSat3.DataContext = daynow;
                        //4
                        tbdSun4.DataContext = daynow;
                        tbdMon4.DataContext = daynow;
                        tbdTue4.DataContext = daynow;
                        tbdWed4.DataContext = daynow;
                        tbdThu4.DataContext = daynow;
                        tbdFri4.DataContext = daynow;
                        tbdSat4.DataContext = daynow;
                        //5
                        tbdSun5.DataContext = daynow;
                        tbdMon5.DataContext = daynow;
                        tbdTue5.DataContext = daynow;
                        tbdWed5.DataContext = daynow;
                        tbdThu5.DataContext = daynow;
                        //Color day 

                        tbdTue1.Foreground = color;
                        tbdWed1.Foreground = color;
                        tbdThu1.Foreground = color;
                        tbdFri1.Foreground = color;
                        tbdSat1.Foreground = color;
                        //2
                        tbdSun2.Foreground = color;
                        tbdMon2.Foreground = color;
                        tbdTue2.Foreground = color;
                        tbdWed2.Foreground = color;
                        tbdThu2.Foreground = color;
                        tbdFri2.Foreground = color;
                        tbdSat2.Foreground = color;
                        //3
                        tbdSun3.Foreground = color;
                        tbdMon3.Foreground = color;
                        tbdTue3.Foreground = color;
                        tbdWed3.Foreground = color;
                        tbdThu3.Foreground = color;
                        tbdFri3.Foreground = color;
                        tbdSat3.Foreground = color;
                        //4
                        tbdSun4.Foreground = color;
                        tbdMon4.Foreground = color;
                        tbdTue4.Foreground = color;
                        tbdWed4.Foreground = color;
                        tbdThu4.Foreground = color;
                        tbdFri4.Foreground = color;
                        tbdSat4.Foreground = color;
                        //5
                        tbdSun5.Foreground = color;
                        tbdMon5.Foreground = color;
                        tbdTue5.Foreground = color;
                        tbdWed5.Foreground = color;
                        tbdThu5.Foreground = color;
                    }
                    else if (totaldaymonth == 30)
                    {
                        tbdTue1.DataContext = daynow;
                        tbdWed1.DataContext = daynow;
                        tbdThu1.DataContext = daynow;
                        tbdFri1.DataContext = daynow;
                        tbdSat1.DataContext = daynow;
                        //2
                        tbdSun2.DataContext = daynow;
                        tbdMon2.DataContext = daynow;
                        tbdTue2.DataContext = daynow;
                        tbdWed2.DataContext = daynow;
                        tbdThu2.DataContext = daynow;
                        tbdFri2.DataContext = daynow;
                        tbdSat2.DataContext = daynow;
                        //3
                        tbdSun3.DataContext = daynow;
                        tbdMon3.DataContext = daynow;
                        tbdTue3.DataContext = daynow;
                        tbdWed3.DataContext = daynow;
                        tbdThu3.DataContext = daynow;
                        tbdFri3.DataContext = daynow;
                        tbdSat3.DataContext = daynow;
                        //4
                        tbdSun4.DataContext = daynow;
                        tbdMon4.DataContext = daynow;
                        tbdTue4.DataContext = daynow;
                        tbdWed4.DataContext = daynow;
                        tbdThu4.DataContext = daynow;
                        tbdFri4.DataContext = daynow;
                        tbdSat4.DataContext = daynow;
                        //5
                        tbdSun5.DataContext = daynow;
                        tbdMon5.DataContext = daynow;
                        tbdTue5.DataContext = daynow;
                        tbdWed5.DataContext = daynow;
                        //Color day 

                        tbdTue1.Foreground = color;
                        tbdWed1.Foreground = color;
                        tbdThu1.Foreground = color;
                        tbdFri1.Foreground = color;
                        tbdSat1.Foreground = color;
                        //2
                        tbdSun2.Foreground = color;
                        tbdMon2.Foreground = color;
                        tbdTue2.Foreground = color;
                        tbdWed2.Foreground = color;
                        tbdThu2.Foreground = color;
                        tbdFri2.Foreground = color;
                        tbdSat2.Foreground = color;
                        //3
                        tbdSun3.Foreground = color;
                        tbdMon3.Foreground = color;
                        tbdTue3.Foreground = color;
                        tbdWed3.Foreground = color;
                        tbdThu3.Foreground = color;
                        tbdFri3.Foreground = color;
                        tbdSat3.Foreground = color;
                        //4
                        tbdSun4.Foreground = color;
                        tbdMon4.Foreground = color;
                        tbdTue4.Foreground = color;
                        tbdWed4.Foreground = color;
                        tbdThu4.Foreground = color;
                        tbdFri4.Foreground = color;
                        tbdSat4.Foreground = color;
                        //5
                        tbdSun5.Foreground = color;
                        tbdMon5.Foreground = color;
                        tbdTue5.Foreground = color;
                        tbdWed5.Foreground = color;
                    }
                    else if (totaldaymonth == 29)
                    {
                        tbdTue1.DataContext = daynow;
                        tbdWed1.DataContext = daynow;
                        tbdThu1.DataContext = daynow;
                        tbdFri1.DataContext = daynow;
                        tbdSat1.DataContext = daynow;
                        //2
                        tbdSun2.DataContext = daynow;
                        tbdMon2.DataContext = daynow;
                        tbdTue2.DataContext = daynow;
                        tbdWed2.DataContext = daynow;
                        tbdThu2.DataContext = daynow;
                        tbdFri2.DataContext = daynow;
                        tbdSat2.DataContext = daynow;
                        //3
                        tbdSun3.DataContext = daynow;
                        tbdMon3.DataContext = daynow;
                        tbdTue3.DataContext = daynow;
                        tbdWed3.DataContext = daynow;
                        tbdThu3.DataContext = daynow;
                        tbdFri3.DataContext = daynow;
                        tbdSat3.DataContext = daynow;
                        //4
                        tbdSun4.DataContext = daynow;
                        tbdMon4.DataContext = daynow;
                        tbdTue4.DataContext = daynow;
                        tbdWed4.DataContext = daynow;
                        tbdThu4.DataContext = daynow;
                        tbdFri4.DataContext = daynow;
                        tbdSat4.DataContext = daynow;
                        //5
                        tbdSun5.DataContext = daynow;
                        tbdMon5.DataContext = daynow;
                        tbdTue5.DataContext = daynow;
                        //Color day 

                        tbdTue1.Foreground = color;
                        tbdWed1.Foreground = color;
                        tbdThu1.Foreground = color;
                        tbdFri1.Foreground = color;
                        tbdSat1.Foreground = color;
                        //2
                        tbdSun2.Foreground = color;
                        tbdMon2.Foreground = color;
                        tbdTue2.Foreground = color;
                        tbdWed2.Foreground = color;
                        tbdThu2.Foreground = color;
                        tbdFri2.Foreground = color;
                        tbdSat2.Foreground = color;
                        //3
                        tbdSun3.Foreground = color;
                        tbdMon3.Foreground = color;
                        tbdTue3.Foreground = color;
                        tbdWed3.Foreground = color;
                        tbdThu3.Foreground = color;
                        tbdFri3.Foreground = color;
                        tbdSat3.Foreground = color;
                        //4
                        tbdSun4.Foreground = color;
                        tbdMon4.Foreground = color;
                        tbdTue4.Foreground = color;
                        tbdWed4.Foreground = color;
                        tbdThu4.Foreground = color;
                        tbdFri4.Foreground = color;
                        tbdSat4.Foreground = color;
                        //5
                        tbdSun5.Foreground = color;
                        tbdMon5.Foreground = color;
                        tbdTue5.Foreground = color;
                    }
                    else if (totaldaymonth == 28)
                    {
                        tbdTue1.DataContext = daynow;
                        tbdWed1.DataContext = daynow;
                        tbdThu1.DataContext = daynow;
                        tbdFri1.DataContext = daynow;
                        tbdSat1.DataContext = daynow;
                        //2
                        tbdSun2.DataContext = daynow;
                        tbdMon2.DataContext = daynow;
                        tbdTue2.DataContext = daynow;
                        tbdWed2.DataContext = daynow;
                        tbdThu2.DataContext = daynow;
                        tbdFri2.DataContext = daynow;
                        tbdSat2.DataContext = daynow;
                        //3
                        tbdSun3.DataContext = daynow;
                        tbdMon3.DataContext = daynow;
                        tbdTue3.DataContext = daynow;
                        tbdWed3.DataContext = daynow;
                        tbdThu3.DataContext = daynow;
                        tbdFri3.DataContext = daynow;
                        tbdSat3.DataContext = daynow;
                        //4
                        tbdSun4.DataContext = daynow;
                        tbdMon4.DataContext = daynow;
                        tbdTue4.DataContext = daynow;
                        tbdWed4.DataContext = daynow;
                        tbdThu4.DataContext = daynow;
                        tbdFri4.DataContext = daynow;
                        tbdSat4.DataContext = daynow;
                        //5
                        tbdSun5.DataContext = daynow;
                        tbdMon5.DataContext = daynow;
                        //Color day 

                        tbdTue1.Foreground = color;
                        tbdWed1.Foreground = color;
                        tbdThu1.Foreground = color;
                        tbdFri1.Foreground = color;
                        tbdSat1.Foreground = color;
                        //2
                        tbdSun2.Foreground = color;
                        tbdMon2.Foreground = color;
                        tbdTue2.Foreground = color;
                        tbdWed2.Foreground = color;
                        tbdThu2.Foreground = color;
                        tbdFri2.Foreground = color;
                        tbdSat2.Foreground = color;
                        //3
                        tbdSun3.Foreground = color;
                        tbdMon3.Foreground = color;
                        tbdTue3.Foreground = color;
                        tbdWed3.Foreground = color;
                        tbdThu3.Foreground = color;
                        tbdFri3.Foreground = color;
                        tbdSat3.Foreground = color;
                        //4
                        tbdSun4.Foreground = color;
                        tbdMon4.Foreground = color;
                        tbdTue4.Foreground = color;
                        tbdWed4.Foreground = color;
                        tbdThu4.Foreground = color;
                        tbdFri4.Foreground = color;
                        tbdSat4.Foreground = color;
                        //5
                        tbdSun5.Foreground = color;
                        tbdMon5.Foreground = color;
                    }

                    break;
                case "Wednesday":
                    if (totaldaymonth == 31)
                    {
                        tbdWed1.DataContext = daynow;
                        tbdThu1.DataContext = daynow;
                        tbdFri1.DataContext = daynow;
                        tbdSat1.DataContext = daynow;
                        //2
                        tbdSun2.DataContext = daynow;
                        tbdMon2.DataContext = daynow;
                        tbdTue2.DataContext = daynow;
                        tbdWed2.DataContext = daynow;
                        tbdThu2.DataContext = daynow;
                        tbdFri2.DataContext = daynow;
                        tbdSat2.DataContext = daynow;
                        //3
                        tbdSun3.DataContext = daynow;
                        tbdMon3.DataContext = daynow;
                        tbdTue3.DataContext = daynow;
                        tbdWed3.DataContext = daynow;
                        tbdThu3.DataContext = daynow;
                        tbdFri3.DataContext = daynow;
                        tbdSat3.DataContext = daynow;
                        //4
                        tbdSun4.DataContext = daynow;
                        tbdMon4.DataContext = daynow;
                        tbdTue4.DataContext = daynow;
                        tbdWed4.DataContext = daynow;
                        tbdThu4.DataContext = daynow;
                        tbdFri4.DataContext = daynow;
                        tbdSat4.DataContext = daynow;
                        //5
                        tbdSun5.DataContext = daynow;
                        tbdMon5.DataContext = daynow;
                        tbdTue5.DataContext = daynow;
                        tbdWed5.DataContext = daynow;
                        tbdThu5.DataContext = daynow;
                        tbdFri5.DataContext = daynow;
                        //Color day 

                        tbdWed1.Foreground = color;
                        tbdThu1.Foreground = color;
                        tbdFri1.Foreground = color;
                        tbdSat1.Foreground = color;
                        //2
                        tbdSun2.Foreground = color;
                        tbdMon2.Foreground = color;
                        tbdTue2.Foreground = color;
                        tbdWed2.Foreground = color;
                        tbdThu2.Foreground = color;
                        tbdFri2.Foreground = color;
                        tbdSat2.Foreground = color;
                        //3
                        tbdSun3.Foreground = color;
                        tbdMon3.Foreground = color;
                        tbdTue3.Foreground = color;
                        tbdWed3.Foreground = color;
                        tbdThu3.Foreground = color;
                        tbdFri3.Foreground = color;
                        tbdSat3.Foreground = color;
                        //4
                        tbdSun4.Foreground = color;
                        tbdMon4.Foreground = color;
                        tbdTue4.Foreground = color;
                        tbdWed4.Foreground = color;
                        tbdThu4.Foreground = color;
                        tbdFri4.Foreground = color;
                        tbdSat4.Foreground = color;
                        //5
                        tbdSun5.Foreground = color;
                        tbdMon5.Foreground = color;
                        tbdTue5.Foreground = color;
                        tbdWed5.Foreground = color;
                        tbdThu5.Foreground = color;
                        tbdFri5.Foreground = color;
                    }
                    else if (totaldaymonth == 30)
                    {
                        tbdWed1.DataContext = daynow;
                        tbdThu1.DataContext = daynow;
                        tbdFri1.DataContext = daynow;
                        tbdSat1.DataContext = daynow;
                        //2
                        tbdSun2.DataContext = daynow;
                        tbdMon2.DataContext = daynow;
                        tbdTue2.DataContext = daynow;
                        tbdWed2.DataContext = daynow;
                        tbdThu2.DataContext = daynow;
                        tbdFri2.DataContext = daynow;
                        tbdSat2.DataContext = daynow;
                        //3
                        tbdSun3.DataContext = daynow;
                        tbdMon3.DataContext = daynow;
                        tbdTue3.DataContext = daynow;
                        tbdWed3.DataContext = daynow;
                        tbdThu3.DataContext = daynow;
                        tbdFri3.DataContext = daynow;
                        tbdSat3.DataContext = daynow;
                        //4
                        tbdSun4.DataContext = daynow;
                        tbdMon4.DataContext = daynow;
                        tbdTue4.DataContext = daynow;
                        tbdWed4.DataContext = daynow;
                        tbdThu4.DataContext = daynow;
                        tbdFri4.DataContext = daynow;
                        tbdSat4.DataContext = daynow;
                        //5
                        tbdSun5.DataContext = daynow;
                        tbdMon5.DataContext = daynow;
                        tbdTue5.DataContext = daynow;
                        tbdWed5.DataContext = daynow;
                        tbdThu5.DataContext = daynow;
                        //Color day 

                        tbdWed1.Foreground = color;
                        tbdThu1.Foreground = color;
                        tbdFri1.Foreground = color;
                        tbdSat1.Foreground = color;
                        //2
                        tbdSun2.Foreground = color;
                        tbdMon2.Foreground = color;
                        tbdTue2.Foreground = color;
                        tbdWed2.Foreground = color;
                        tbdThu2.Foreground = color;
                        tbdFri2.Foreground = color;
                        tbdSat2.Foreground = color;
                        //3
                        tbdSun3.Foreground = color;
                        tbdMon3.Foreground = color;
                        tbdTue3.Foreground = color;
                        tbdWed3.Foreground = color;
                        tbdThu3.Foreground = color;
                        tbdFri3.Foreground = color;
                        tbdSat3.Foreground = color;
                        //4
                        tbdSun4.Foreground = color;
                        tbdMon4.Foreground = color;
                        tbdTue4.Foreground = color;
                        tbdWed4.Foreground = color;
                        tbdThu4.Foreground = color;
                        tbdFri4.Foreground = color;
                        tbdSat4.Foreground = color;
                        //5
                        tbdSun5.Foreground = color;
                        tbdMon5.Foreground = color;
                        tbdTue5.Foreground = color;
                        tbdWed5.Foreground = color;
                        tbdThu5.Foreground = color;
                    }
                    else if (totaldaymonth == 29)
                    {
                        tbdWed1.DataContext = daynow;
                        tbdThu1.DataContext = daynow;
                        tbdFri1.DataContext = daynow;
                        tbdSat1.DataContext = daynow;
                        //2
                        tbdSun2.DataContext = daynow;
                        tbdMon2.DataContext = daynow;
                        tbdTue2.DataContext = daynow;
                        tbdWed2.DataContext = daynow;
                        tbdThu2.DataContext = daynow;
                        tbdFri2.DataContext = daynow;
                        tbdSat2.DataContext = daynow;
                        //3
                        tbdSun3.DataContext = daynow;
                        tbdMon3.DataContext = daynow;
                        tbdTue3.DataContext = daynow;
                        tbdWed3.DataContext = daynow;
                        tbdThu3.DataContext = daynow;
                        tbdFri3.DataContext = daynow;
                        tbdSat3.DataContext = daynow;
                        //4
                        tbdSun4.DataContext = daynow;
                        tbdMon4.DataContext = daynow;
                        tbdTue4.DataContext = daynow;
                        tbdWed4.DataContext = daynow;
                        tbdThu4.DataContext = daynow;
                        tbdFri4.DataContext = daynow;
                        tbdSat4.DataContext = daynow;
                        //5
                        tbdSun5.DataContext = daynow;
                        tbdMon5.DataContext = daynow;
                        tbdTue5.DataContext = daynow;
                        tbdWed5.DataContext = daynow;
                        //Color day 

                        tbdWed1.Foreground = color;
                        tbdThu1.Foreground = color;
                        tbdFri1.Foreground = color;
                        tbdSat1.Foreground = color;
                        //2
                        tbdSun2.Foreground = color;
                        tbdMon2.Foreground = color;
                        tbdTue2.Foreground = color;
                        tbdWed2.Foreground = color;
                        tbdThu2.Foreground = color;
                        tbdFri2.Foreground = color;
                        tbdSat2.Foreground = color;
                        //3
                        tbdSun3.Foreground = color;
                        tbdMon3.Foreground = color;
                        tbdTue3.Foreground = color;
                        tbdWed3.Foreground = color;
                        tbdThu3.Foreground = color;
                        tbdFri3.Foreground = color;
                        tbdSat3.Foreground = color;
                        //4
                        tbdSun4.Foreground = color;
                        tbdMon4.Foreground = color;
                        tbdTue4.Foreground = color;
                        tbdWed4.Foreground = color;
                        tbdThu4.Foreground = color;
                        tbdFri4.Foreground = color;
                        tbdSat4.Foreground = color;
                        //5
                        tbdSun5.Foreground = color;
                        tbdMon5.Foreground = color;
                        tbdTue5.Foreground = color;
                        tbdWed5.Foreground = color;
                    }
                    else if (totaldaymonth == 28)
                    {
                        tbdWed1.DataContext = daynow;
                        tbdThu1.DataContext = daynow;
                        tbdFri1.DataContext = daynow;
                        tbdSat1.DataContext = daynow;
                        //2
                        tbdSun2.DataContext = daynow;
                        tbdMon2.DataContext = daynow;
                        tbdTue2.DataContext = daynow;
                        tbdWed2.DataContext = daynow;
                        tbdThu2.DataContext = daynow;
                        tbdFri2.DataContext = daynow;
                        tbdSat2.DataContext = daynow;
                        //3
                        tbdSun3.DataContext = daynow;
                        tbdMon3.DataContext = daynow;
                        tbdTue3.DataContext = daynow;
                        tbdWed3.DataContext = daynow;
                        tbdThu3.DataContext = daynow;
                        tbdFri3.DataContext = daynow;
                        tbdSat3.DataContext = daynow;
                        //4
                        tbdSun4.DataContext = daynow;
                        tbdMon4.DataContext = daynow;
                        tbdTue4.DataContext = daynow;
                        tbdWed4.DataContext = daynow;
                        tbdThu4.DataContext = daynow;
                        tbdFri4.DataContext = daynow;
                        tbdSat4.DataContext = daynow;
                        //5
                        tbdSun5.DataContext = daynow;
                        tbdMon5.DataContext = daynow;
                        tbdTue5.DataContext = daynow;
                        //Color day 

                        tbdWed1.Foreground = color;
                        tbdThu1.Foreground = color;
                        tbdFri1.Foreground = color;
                        tbdSat1.Foreground = color;
                        //2
                        tbdSun2.Foreground = color;
                        tbdMon2.Foreground = color;
                        tbdTue2.Foreground = color;
                        tbdWed2.Foreground = color;
                        tbdThu2.Foreground = color;
                        tbdFri2.Foreground = color;
                        tbdSat2.Foreground = color;
                        //3
                        tbdSun3.Foreground = color;
                        tbdMon3.Foreground = color;
                        tbdTue3.Foreground = color;
                        tbdWed3.Foreground = color;
                        tbdThu3.Foreground = color;
                        tbdFri3.Foreground = color;
                        tbdSat3.Foreground = color;
                        //4
                        tbdSun4.Foreground = color;
                        tbdMon4.Foreground = color;
                        tbdTue4.Foreground = color;
                        tbdWed4.Foreground = color;
                        tbdThu4.Foreground = color;
                        tbdFri4.Foreground = color;
                        tbdSat4.Foreground = color;
                        //5
                        tbdSun5.Foreground = color;
                        tbdMon5.Foreground = color;
                        tbdTue5.Foreground = color;
                    }
                    break;
                case "Thursday":

                    if (totaldaymonth == 31)
                    {
                        tbdThu1.DataContext = daynow;
                        tbdFri1.DataContext = daynow;
                        tbdSat1.DataContext = daynow;
                        //2
                        tbdSun2.DataContext = daynow;
                        tbdMon2.DataContext = daynow;
                        tbdTue2.DataContext = daynow;
                        tbdWed2.DataContext = daynow;
                        tbdThu2.DataContext = daynow;
                        tbdFri2.DataContext = daynow;
                        tbdSat2.DataContext = daynow;
                        //3
                        tbdSun3.DataContext = daynow;
                        tbdMon3.DataContext = daynow;
                        tbdTue3.DataContext = daynow;
                        tbdWed3.DataContext = daynow;
                        tbdThu3.DataContext = daynow;
                        tbdFri3.DataContext = daynow;
                        tbdSat3.DataContext = daynow;
                        //4
                        tbdSun4.DataContext = daynow;
                        tbdMon4.DataContext = daynow;
                        tbdTue4.DataContext = daynow;
                        tbdWed4.DataContext = daynow;
                        tbdThu4.DataContext = daynow;
                        tbdFri4.DataContext = daynow;
                        tbdSat4.DataContext = daynow;
                        //5
                        tbdSun5.DataContext = daynow;
                        tbdMon5.DataContext = daynow;
                        tbdTue5.DataContext = daynow;
                        tbdWed5.DataContext = daynow;
                        tbdThu5.DataContext = daynow;
                        tbdFri5.DataContext = daynow;
                        tbdSat5.DataContext = daynow;
                        //Color day 

                        tbdThu1.Foreground = color;
                        tbdFri1.Foreground = color;
                        tbdSat1.Foreground = color;
                        //2
                        tbdSun2.Foreground = color;
                        tbdMon2.Foreground = color;
                        tbdTue2.Foreground = color;
                        tbdWed2.Foreground = color;
                        tbdThu2.Foreground = color;
                        tbdFri2.Foreground = color;
                        tbdSat2.Foreground = color;
                        //3
                        tbdSun3.Foreground = color;
                        tbdMon3.Foreground = color;
                        tbdTue3.Foreground = color;
                        tbdWed3.Foreground = color;
                        tbdThu3.Foreground = color;
                        tbdFri3.Foreground = color;
                        tbdSat3.Foreground = color;
                        //4
                        tbdSun4.Foreground = color;
                        tbdMon4.Foreground = color;
                        tbdTue4.Foreground = color;
                        tbdWed4.Foreground = color;
                        tbdThu4.Foreground = color;
                        tbdFri4.Foreground = color;
                        tbdSat4.Foreground = color;
                        //5
                        tbdSun5.Foreground = color;
                        tbdMon5.Foreground = color;
                        tbdTue5.Foreground = color;
                        tbdWed5.Foreground = color;
                        tbdThu5.Foreground = color;
                        tbdFri5.Foreground = color;
                        tbdSat5.Foreground = color;


                    }
                    else if (totaldaymonth == 30)
                    {
                        tbdThu1.DataContext = daynow;
                        tbdFri1.DataContext = daynow;
                        tbdSat1.DataContext = daynow;
                        //2
                        tbdSun2.DataContext = daynow;
                        tbdMon2.DataContext = daynow;
                        tbdTue2.DataContext = daynow;
                        tbdWed2.DataContext = daynow;
                        tbdThu2.DataContext = daynow;
                        tbdFri2.DataContext = daynow;
                        tbdSat2.DataContext = daynow;
                        //3
                        tbdSun3.DataContext = daynow;
                        tbdMon3.DataContext = daynow;
                        tbdTue3.DataContext = daynow;
                        tbdWed3.DataContext = daynow;
                        tbdThu3.DataContext = daynow;
                        tbdFri3.DataContext = daynow;
                        tbdSat3.DataContext = daynow;
                        //4
                        tbdSun4.DataContext = daynow;
                        tbdMon4.DataContext = daynow;
                        tbdTue4.DataContext = daynow;
                        tbdWed4.DataContext = daynow;
                        tbdThu4.DataContext = daynow;
                        tbdFri4.DataContext = daynow;
                        tbdSat4.DataContext = daynow;
                        //5
                        tbdSun5.DataContext = daynow;
                        tbdMon5.DataContext = daynow;
                        tbdTue5.DataContext = daynow;
                        tbdWed5.DataContext = daynow;
                        tbdThu5.DataContext = daynow;
                        tbdFri5.DataContext = daynow;
                        //Color day 

                        tbdThu1.Foreground = color;
                        tbdFri1.Foreground = color;
                        tbdSat1.Foreground = color;
                        //2
                        tbdSun2.Foreground = color;
                        tbdMon2.Foreground = color;
                        tbdTue2.Foreground = color;
                        tbdWed2.Foreground = color;
                        tbdThu2.Foreground = color;
                        tbdFri2.Foreground = color;
                        tbdSat2.Foreground = color;
                        //3
                        tbdSun3.Foreground = color;
                        tbdMon3.Foreground = color;
                        tbdTue3.Foreground = color;
                        tbdWed3.Foreground = color;
                        tbdThu3.Foreground = color;
                        tbdFri3.Foreground = color;
                        tbdSat3.Foreground = color;
                        //4
                        tbdSun4.Foreground = color;
                        tbdMon4.Foreground = color;
                        tbdTue4.Foreground = color;
                        tbdWed4.Foreground = color;
                        tbdThu4.Foreground = color;
                        tbdFri4.Foreground = color;
                        tbdSat4.Foreground = color;
                        //5
                        tbdSun5.Foreground = color;
                        tbdMon5.Foreground = color;
                        tbdTue5.Foreground = color;
                        tbdWed5.Foreground = color;
                        tbdThu5.Foreground = color;
                        tbdFri5.Foreground = color;

                    }
                    else if (totaldaymonth == 29)
                    {
                        tbdThu1.DataContext = daynow;
                        tbdFri1.DataContext = daynow;
                        tbdSat1.DataContext = daynow;
                        //2
                        tbdSun2.DataContext = daynow;
                        tbdMon2.DataContext = daynow;
                        tbdTue2.DataContext = daynow;
                        tbdWed2.DataContext = daynow;
                        tbdThu2.DataContext = daynow;
                        tbdFri2.DataContext = daynow;
                        tbdSat2.DataContext = daynow;
                        //3
                        tbdSun3.DataContext = daynow;
                        tbdMon3.DataContext = daynow;
                        tbdTue3.DataContext = daynow;
                        tbdWed3.DataContext = daynow;
                        tbdThu3.DataContext = daynow;
                        tbdFri3.DataContext = daynow;
                        tbdSat3.DataContext = daynow;
                        //4
                        tbdSun4.DataContext = daynow;
                        tbdMon4.DataContext = daynow;
                        tbdTue4.DataContext = daynow;
                        tbdWed4.DataContext = daynow;
                        tbdThu4.DataContext = daynow;
                        tbdFri4.DataContext = daynow;
                        tbdSat4.DataContext = daynow;
                        //5
                        tbdSun5.DataContext = daynow;
                        tbdMon5.DataContext = daynow;
                        tbdTue5.DataContext = daynow;
                        tbdWed5.DataContext = daynow;
                        tbdThu5.DataContext = daynow;
                        //Color day 

                        tbdThu1.Foreground = color;
                        tbdFri1.Foreground = color;
                        tbdSat1.Foreground = color;
                        //2
                        tbdSun2.Foreground = color;
                        tbdMon2.Foreground = color;
                        tbdTue2.Foreground = color;
                        tbdWed2.Foreground = color;
                        tbdThu2.Foreground = color;
                        tbdFri2.Foreground = color;
                        tbdSat2.Foreground = color;
                        //3
                        tbdSun3.Foreground = color;
                        tbdMon3.Foreground = color;
                        tbdTue3.Foreground = color;
                        tbdWed3.Foreground = color;
                        tbdThu3.Foreground = color;
                        tbdFri3.Foreground = color;
                        tbdSat3.Foreground = color;
                        //4
                        tbdSun4.Foreground = color;
                        tbdMon4.Foreground = color;
                        tbdTue4.Foreground = color;
                        tbdWed4.Foreground = color;
                        tbdThu4.Foreground = color;
                        tbdFri4.Foreground = color;
                        tbdSat4.Foreground = color;
                        //5
                        tbdSun5.Foreground = color;
                        tbdMon5.Foreground = color;
                        tbdTue5.Foreground = color;
                        tbdWed5.Foreground = color;
                        tbdThu5.Foreground = color;
                    }
                    else if (totaldaymonth == 28)
                    {
                        tbdThu1.DataContext = daynow;
                        tbdFri1.DataContext = daynow;
                        tbdSat1.DataContext = daynow;
                        //2
                        tbdSun2.DataContext = daynow;
                        tbdMon2.DataContext = daynow;
                        tbdTue2.DataContext = daynow;
                        tbdWed2.DataContext = daynow;
                        tbdThu2.DataContext = daynow;
                        tbdFri2.DataContext = daynow;
                        tbdSat2.DataContext = daynow;
                        //3
                        tbdSun3.DataContext = daynow;
                        tbdMon3.DataContext = daynow;
                        tbdTue3.DataContext = daynow;
                        tbdWed3.DataContext = daynow;
                        tbdThu3.DataContext = daynow;
                        tbdFri3.DataContext = daynow;
                        tbdSat3.DataContext = daynow;
                        //4
                        tbdSun4.DataContext = daynow;
                        tbdMon4.DataContext = daynow;
                        tbdTue4.DataContext = daynow;
                        tbdWed4.DataContext = daynow;
                        tbdThu4.DataContext = daynow;
                        tbdFri4.DataContext = daynow;
                        tbdSat4.DataContext = daynow;
                        //5
                        tbdSun5.DataContext = daynow;
                        tbdMon5.DataContext = daynow;
                        tbdTue5.DataContext = daynow;
                        tbdWed5.DataContext = daynow;
                        //Color day 

                        tbdThu1.Foreground = color;
                        tbdFri1.Foreground = color;
                        tbdSat1.Foreground = color;
                        //2
                        tbdSun2.Foreground = color;
                        tbdMon2.Foreground = color;
                        tbdTue2.Foreground = color;
                        tbdWed2.Foreground = color;
                        tbdThu2.Foreground = color;
                        tbdFri2.Foreground = color;
                        tbdSat2.Foreground = color;
                        //3
                        tbdSun3.Foreground = color;
                        tbdMon3.Foreground = color;
                        tbdTue3.Foreground = color;
                        tbdWed3.Foreground = color;
                        tbdThu3.Foreground = color;
                        tbdFri3.Foreground = color;
                        tbdSat3.Foreground = color;
                        //4
                        tbdSun4.Foreground = color;
                        tbdMon4.Foreground = color;
                        tbdTue4.Foreground = color;
                        tbdWed4.Foreground = color;
                        tbdThu4.Foreground = color;
                        tbdFri4.Foreground = color;
                        tbdSat4.Foreground = color;
                        //5
                        tbdSun5.Foreground = color;
                        tbdMon5.Foreground = color;
                        tbdTue5.Foreground = color;
                        tbdWed5.Foreground = color;
                    }


                    break;
                case "Friday":
                    if (totaldaymonth == 31)
                    {

                        tbdFri1.DataContext = daynow;
                        tbdSat1.DataContext = daynow;
                        //2
                        tbdSun2.DataContext = daynow;
                        tbdMon2.DataContext = daynow;
                        tbdTue2.DataContext = daynow;
                        tbdWed2.DataContext = daynow;
                        tbdThu2.DataContext = daynow;
                        tbdFri2.DataContext = daynow;
                        tbdSat2.DataContext = daynow;
                        //3
                        tbdSun3.DataContext = daynow;
                        tbdMon3.DataContext = daynow;
                        tbdTue3.DataContext = daynow;
                        tbdWed3.DataContext = daynow;
                        tbdThu3.DataContext = daynow;
                        tbdFri3.DataContext = daynow;
                        tbdSat3.DataContext = daynow;
                        //4
                        tbdSun4.DataContext = daynow;
                        tbdMon4.DataContext = daynow;
                        tbdTue4.DataContext = daynow;
                        tbdWed4.DataContext = daynow;
                        tbdThu4.DataContext = daynow;
                        tbdFri4.DataContext = daynow;
                        tbdSat4.DataContext = daynow;
                        //5
                        tbdSun5.DataContext = daynow;
                        tbdMon5.DataContext = daynow;
                        tbdTue5.DataContext = daynow;
                        tbdWed5.DataContext = daynow;
                        tbdThu5.DataContext = daynow;
                        tbdFri5.DataContext = daynow;
                        tbdSat5.DataContext = daynow;
                        //6
                        tbdSun6.DataContext = daynow;
                        //Color day 

                        tbdFri1.Foreground = color;
                        tbdSat1.Foreground = color;
                        //2
                        tbdSun2.Foreground = color;
                        tbdMon2.Foreground = color;
                        tbdTue2.Foreground = color;
                        tbdWed2.Foreground = color;
                        tbdThu2.Foreground = color;
                        tbdFri2.Foreground = color;
                        tbdSat2.Foreground = color;
                        //3
                        tbdSun3.Foreground = color;
                        tbdMon3.Foreground = color;
                        tbdTue3.Foreground = color;
                        tbdWed3.Foreground = color;
                        tbdThu3.Foreground = color;
                        tbdFri3.Foreground = color;
                        tbdSat3.Foreground = color;
                        //4
                        tbdSun4.Foreground = color;
                        tbdMon4.Foreground = color;
                        tbdTue4.Foreground = color;
                        tbdWed4.Foreground = color;
                        tbdThu4.Foreground = color;
                        tbdFri4.Foreground = color;
                        tbdSat4.Foreground = color;
                        //5
                        tbdSun5.Foreground = color;
                        tbdMon5.Foreground = color;
                        tbdTue5.Foreground = color;
                        tbdWed5.Foreground = color;
                        tbdThu5.Foreground = color;
                        tbdFri5.Foreground = color;
                        tbdSat5.Foreground = color;
                        //6
                        tbdSun6.Foreground = color;


                    }
                    else if (totaldaymonth == 30)
                    {
                        tbdFri1.DataContext = daynow;
                        tbdSat1.DataContext = daynow;
                        //2
                        tbdSun2.DataContext = daynow;
                        tbdMon2.DataContext = daynow;
                        tbdTue2.DataContext = daynow;
                        tbdWed2.DataContext = daynow;
                        tbdThu2.DataContext = daynow;
                        tbdFri2.DataContext = daynow;
                        tbdSat2.DataContext = daynow;
                        //3
                        tbdSun3.DataContext = daynow;
                        tbdMon3.DataContext = daynow;
                        tbdTue3.DataContext = daynow;
                        tbdWed3.DataContext = daynow;
                        tbdThu3.DataContext = daynow;
                        tbdFri3.DataContext = daynow;
                        tbdSat3.DataContext = daynow;
                        //4
                        tbdSun4.DataContext = daynow;
                        tbdMon4.DataContext = daynow;
                        tbdTue4.DataContext = daynow;
                        tbdWed4.DataContext = daynow;
                        tbdThu4.DataContext = daynow;
                        tbdFri4.DataContext = daynow;
                        tbdSat4.DataContext = daynow;
                        //5
                        tbdSun5.DataContext = daynow;
                        tbdMon5.DataContext = daynow;
                        tbdTue5.DataContext = daynow;
                        tbdWed5.DataContext = daynow;
                        tbdThu5.DataContext = daynow;
                        tbdFri5.DataContext = daynow;
                        tbdSat5.DataContext = daynow;
                        //Color day 

                        tbdFri1.Foreground = color;
                        tbdSat1.Foreground = color;
                        //2
                        tbdSun2.Foreground = color;
                        tbdMon2.Foreground = color;
                        tbdTue2.Foreground = color;
                        tbdWed2.Foreground = color;
                        tbdThu2.Foreground = color;
                        tbdFri2.Foreground = color;
                        tbdSat2.Foreground = color;
                        //3
                        tbdSun3.Foreground = color;
                        tbdMon3.Foreground = color;
                        tbdTue3.Foreground = color;
                        tbdWed3.Foreground = color;
                        tbdThu3.Foreground = color;
                        tbdFri3.Foreground = color;
                        tbdSat3.Foreground = color;
                        //4
                        tbdSun4.Foreground = color;
                        tbdMon4.Foreground = color;
                        tbdTue4.Foreground = color;
                        tbdWed4.Foreground = color;
                        tbdThu4.Foreground = color;
                        tbdFri4.Foreground = color;
                        tbdSat4.Foreground = color;
                        //5
                        tbdSun5.Foreground = color;
                        tbdMon5.Foreground = color;
                        tbdTue5.Foreground = color;
                        tbdWed5.Foreground = color;
                        tbdThu5.Foreground = color;
                        tbdFri5.Foreground = color;
                        tbdSat5.Foreground = color;

                    }
                    else if (totaldaymonth == 29)
                    {
                        tbdFri1.DataContext = daynow;
                        tbdSat1.DataContext = daynow;
                        //2
                        tbdSun2.DataContext = daynow;
                        tbdMon2.DataContext = daynow;
                        tbdTue2.DataContext = daynow;
                        tbdWed2.DataContext = daynow;
                        tbdThu2.DataContext = daynow;
                        tbdFri2.DataContext = daynow;
                        tbdSat2.DataContext = daynow;
                        //3
                        tbdSun3.DataContext = daynow;
                        tbdMon3.DataContext = daynow;
                        tbdTue3.DataContext = daynow;
                        tbdWed3.DataContext = daynow;
                        tbdThu3.DataContext = daynow;
                        tbdFri3.DataContext = daynow;
                        tbdSat3.DataContext = daynow;
                        //4
                        tbdSun4.DataContext = daynow;
                        tbdMon4.DataContext = daynow;
                        tbdTue4.DataContext = daynow;
                        tbdWed4.DataContext = daynow;
                        tbdThu4.DataContext = daynow;
                        tbdFri4.DataContext = daynow;
                        tbdSat4.DataContext = daynow;
                        //5
                        tbdSun5.DataContext = daynow;
                        tbdMon5.DataContext = daynow;
                        tbdTue5.DataContext = daynow;
                        tbdWed5.DataContext = daynow;
                        tbdThu5.DataContext = daynow;
                        tbdFri5.DataContext = daynow;
                        //Color day 

                        tbdFri1.Foreground = color;
                        tbdSat1.Foreground = color;
                        //2
                        tbdSun2.Foreground = color;
                        tbdMon2.Foreground = color;
                        tbdTue2.Foreground = color;
                        tbdWed2.Foreground = color;
                        tbdThu2.Foreground = color;
                        tbdFri2.Foreground = color;
                        tbdSat2.Foreground = color;
                        //3
                        tbdSun3.Foreground = color;
                        tbdMon3.Foreground = color;
                        tbdTue3.Foreground = color;
                        tbdWed3.Foreground = color;
                        tbdThu3.Foreground = color;
                        tbdFri3.Foreground = color;
                        tbdSat3.Foreground = color;
                        //4
                        tbdSun4.Foreground = color;
                        tbdMon4.Foreground = color;
                        tbdTue4.Foreground = color;
                        tbdWed4.Foreground = color;
                        tbdThu4.Foreground = color;
                        tbdFri4.Foreground = color;
                        tbdSat4.Foreground = color;
                        //5
                        tbdSun5.Foreground = color;
                        tbdMon5.Foreground = color;
                        tbdTue5.Foreground = color;
                        tbdWed5.Foreground = color;
                        tbdThu5.Foreground = color;
                        tbdFri5.Foreground = color;
                    }
                    else if (totaldaymonth == 28)
                    {
                        tbdFri1.DataContext = daynow;
                        tbdSat1.DataContext = daynow;
                        //2
                        tbdSun2.DataContext = daynow;
                        tbdMon2.DataContext = daynow;
                        tbdTue2.DataContext = daynow;
                        tbdWed2.DataContext = daynow;
                        tbdThu2.DataContext = daynow;
                        tbdFri2.DataContext = daynow;
                        tbdSat2.DataContext = daynow;
                        //3
                        tbdSun3.DataContext = daynow;
                        tbdMon3.DataContext = daynow;
                        tbdTue3.DataContext = daynow;
                        tbdWed3.DataContext = daynow;
                        tbdThu3.DataContext = daynow;
                        tbdFri3.DataContext = daynow;
                        tbdSat3.DataContext = daynow;
                        //4
                        tbdSun4.DataContext = daynow;
                        tbdMon4.DataContext = daynow;
                        tbdTue4.DataContext = daynow;
                        tbdWed4.DataContext = daynow;
                        tbdThu4.DataContext = daynow;
                        tbdFri4.DataContext = daynow;
                        tbdSat4.DataContext = daynow;
                        //5
                        tbdSun5.DataContext = daynow;
                        tbdMon5.DataContext = daynow;
                        tbdTue5.DataContext = daynow;
                        tbdWed5.DataContext = daynow;
                        tbdThu5.DataContext = daynow;
                        //Color day 

                        tbdFri1.Foreground = color;
                        tbdSat1.Foreground = color;
                        //2
                        tbdSun2.Foreground = color;
                        tbdMon2.Foreground = color;
                        tbdTue2.Foreground = color;
                        tbdWed2.Foreground = color;
                        tbdThu2.Foreground = color;
                        tbdFri2.Foreground = color;
                        tbdSat2.Foreground = color;
                        //3
                        tbdSun3.Foreground = color;
                        tbdMon3.Foreground = color;
                        tbdTue3.Foreground = color;
                        tbdWed3.Foreground = color;
                        tbdThu3.Foreground = color;
                        tbdFri3.Foreground = color;
                        tbdSat3.Foreground = color;
                        //4
                        tbdSun4.Foreground = color;
                        tbdMon4.Foreground = color;
                        tbdTue4.Foreground = color;
                        tbdWed4.Foreground = color;
                        tbdThu4.Foreground = color;
                        tbdFri4.Foreground = color;
                        tbdSat4.Foreground = color;
                        //5
                        tbdSun5.Foreground = color;
                        tbdMon5.Foreground = color;
                        tbdTue5.Foreground = color;
                        tbdWed5.Foreground = color;
                        tbdThu5.Foreground = color;
                    }


                    break;
                case "Saturday":

                    if (totaldaymonth == 31)
                    {
                        tbdSat1.DataContext = daynow;
                        //2
                        tbdSun2.DataContext = daynow;
                        tbdMon2.DataContext = daynow;
                        tbdTue2.DataContext = daynow;
                        tbdWed2.DataContext = daynow;
                        tbdThu2.DataContext = daynow;
                        tbdFri2.DataContext = daynow;
                        tbdSat2.DataContext = daynow;
                        //3
                        tbdSun3.DataContext = daynow;
                        tbdMon3.DataContext = daynow;
                        tbdTue3.DataContext = daynow;
                        tbdWed3.DataContext = daynow;
                        tbdThu3.DataContext = daynow;
                        tbdFri3.DataContext = daynow;
                        tbdSat3.DataContext = daynow;
                        //4
                        tbdSun4.DataContext = daynow;
                        tbdMon4.DataContext = daynow;
                        tbdTue4.DataContext = daynow;
                        tbdWed4.DataContext = daynow;
                        tbdThu4.DataContext = daynow;
                        tbdFri4.DataContext = daynow;
                        tbdSat4.DataContext = daynow;
                        //5
                        tbdSun5.DataContext = daynow;
                        tbdMon5.DataContext = daynow;
                        tbdTue5.DataContext = daynow;
                        tbdWed5.DataContext = daynow;
                        tbdThu5.DataContext = daynow;
                        tbdFri5.DataContext = daynow;
                        tbdSat5.DataContext = daynow;
                        //6
                        tbdSun6.DataContext = daynow;
                        tbdMon6.DataContext = daynow;
                        //Color day 

                        tbdSat1.Foreground = color;
                        //2
                        tbdSun2.Foreground = color;
                        tbdMon2.Foreground = color;
                        tbdTue2.Foreground = color;
                        tbdWed2.Foreground = color;
                        tbdThu2.Foreground = color;
                        tbdFri2.Foreground = color;
                        tbdSat2.Foreground = color;
                        //3
                        tbdSun3.Foreground = color;
                        tbdMon3.Foreground = color;
                        tbdTue3.Foreground = color;
                        tbdWed3.Foreground = color;
                        tbdThu3.Foreground = color;
                        tbdFri3.Foreground = color;
                        tbdSat3.Foreground = color;
                        //4
                        tbdSun4.Foreground = color;
                        tbdMon4.Foreground = color;
                        tbdTue4.Foreground = color;
                        tbdWed4.Foreground = color;
                        tbdThu4.Foreground = color;
                        tbdFri4.Foreground = color;
                        tbdSat4.Foreground = color;
                        //5
                        tbdSun5.Foreground = color;
                        tbdMon5.Foreground = color;
                        tbdTue5.Foreground = color;
                        tbdWed5.Foreground = color;
                        tbdThu5.Foreground = color;
                        tbdFri5.Foreground = color;
                        tbdSat5.Foreground = color;
                        //6
                        tbdSun6.Foreground = color;
                        tbdMon6.Foreground = color;

                    }
                    else if (totaldaymonth == 30)
                    {
                        tbdSat1.DataContext = daynow;
                        //2
                        tbdSun2.DataContext = daynow;
                        tbdMon2.DataContext = daynow;
                        tbdTue2.DataContext = daynow;
                        tbdWed2.DataContext = daynow;
                        tbdThu2.DataContext = daynow;
                        tbdFri2.DataContext = daynow;
                        tbdSat2.DataContext = daynow;
                        //3
                        tbdSun3.DataContext = daynow;
                        tbdMon3.DataContext = daynow;
                        tbdTue3.DataContext = daynow;
                        tbdWed3.DataContext = daynow;
                        tbdThu3.DataContext = daynow;
                        tbdFri3.DataContext = daynow;
                        tbdSat3.DataContext = daynow;
                        //4
                        tbdSun4.DataContext = daynow;
                        tbdMon4.DataContext = daynow;
                        tbdTue4.DataContext = daynow;
                        tbdWed4.DataContext = daynow;
                        tbdThu4.DataContext = daynow;
                        tbdFri4.DataContext = daynow;
                        tbdSat4.DataContext = daynow;
                        //5
                        tbdSun5.DataContext = daynow;
                        tbdMon5.DataContext = daynow;
                        tbdTue5.DataContext = daynow;
                        tbdWed5.DataContext = daynow;
                        tbdThu5.DataContext = daynow;
                        tbdFri5.DataContext = daynow;
                        tbdSat5.DataContext = daynow;
                        //6
                        tbdSun6.DataContext = daynow;
                        //Color day 

                        tbdSat1.Foreground = color;
                        //2
                        tbdSun2.Foreground = color;
                        tbdMon2.Foreground = color;
                        tbdTue2.Foreground = color;
                        tbdWed2.Foreground = color;
                        tbdThu2.Foreground = color;
                        tbdFri2.Foreground = color;
                        tbdSat2.Foreground = color;
                        //3
                        tbdSun3.Foreground = color;
                        tbdMon3.Foreground = color;
                        tbdTue3.Foreground = color;
                        tbdWed3.Foreground = color;
                        tbdThu3.Foreground = color;
                        tbdFri3.Foreground = color;
                        tbdSat3.Foreground = color;
                        //4
                        tbdSun4.Foreground = color;
                        tbdMon4.Foreground = color;
                        tbdTue4.Foreground = color;
                        tbdWed4.Foreground = color;
                        tbdThu4.Foreground = color;
                        tbdFri4.Foreground = color;
                        tbdSat4.Foreground = color;
                        //5
                        tbdSun5.Foreground = color;
                        tbdMon5.Foreground = color;
                        tbdTue5.Foreground = color;
                        tbdWed5.Foreground = color;
                        tbdThu5.Foreground = color;
                        tbdFri5.Foreground = color;
                        tbdSat5.Foreground = color;
                        //6
                        tbdSun6.Foreground = color;

                    }
                    else if (totaldaymonth == 29)
                    {
                        tbdSat1.DataContext = daynow;
                        //2
                        tbdSun2.DataContext = daynow;
                        tbdMon2.DataContext = daynow;
                        tbdTue2.DataContext = daynow;
                        tbdWed2.DataContext = daynow;
                        tbdThu2.DataContext = daynow;
                        tbdFri2.DataContext = daynow;
                        tbdSat2.DataContext = daynow;
                        //3
                        tbdSun3.DataContext = daynow;
                        tbdMon3.DataContext = daynow;
                        tbdTue3.DataContext = daynow;
                        tbdWed3.DataContext = daynow;
                        tbdThu3.DataContext = daynow;
                        tbdFri3.DataContext = daynow;
                        tbdSat3.DataContext = daynow;
                        //4
                        tbdSun4.DataContext = daynow;
                        tbdMon4.DataContext = daynow;
                        tbdTue4.DataContext = daynow;
                        tbdWed4.DataContext = daynow;
                        tbdThu4.DataContext = daynow;
                        tbdFri4.DataContext = daynow;
                        tbdSat4.DataContext = daynow;
                        //5
                        tbdSun5.DataContext = daynow;
                        tbdMon5.DataContext = daynow;
                        tbdTue5.DataContext = daynow;
                        tbdWed5.DataContext = daynow;
                        tbdThu5.DataContext = daynow;
                        tbdFri5.DataContext = daynow;
                        tbdSat5.DataContext = daynow;
                        //Color day 

                        tbdSat1.Foreground = color;
                        //2
                        tbdSun2.Foreground = color;
                        tbdMon2.Foreground = color;
                        tbdTue2.Foreground = color;
                        tbdWed2.Foreground = color;
                        tbdThu2.Foreground = color;
                        tbdFri2.Foreground = color;
                        tbdSat2.Foreground = color;
                        //3
                        tbdSun3.Foreground = color;
                        tbdMon3.Foreground = color;
                        tbdTue3.Foreground = color;
                        tbdWed3.Foreground = color;
                        tbdThu3.Foreground = color;
                        tbdFri3.Foreground = color;
                        tbdSat3.Foreground = color;
                        //4
                        tbdSun4.Foreground = color;
                        tbdMon4.Foreground = color;
                        tbdTue4.Foreground = color;
                        tbdWed4.Foreground = color;
                        tbdThu4.Foreground = color;
                        tbdFri4.Foreground = color;
                        tbdSat4.Foreground = color;
                        //5
                        tbdSun5.Foreground = color;
                        tbdMon5.Foreground = color;
                        tbdTue5.Foreground = color;
                        tbdWed5.Foreground = color;
                        tbdThu5.Foreground = color;
                        tbdFri5.Foreground = color;
                        tbdSat5.Foreground = color;
                    }
                    else if (totaldaymonth == 28)
                    {
                        tbdSat1.DataContext = daynow;
                        //2
                        tbdSun2.DataContext = daynow;
                        tbdMon2.DataContext = daynow;
                        tbdTue2.DataContext = daynow;
                        tbdWed2.DataContext = daynow;
                        tbdThu2.DataContext = daynow;
                        tbdFri2.DataContext = daynow;
                        tbdSat2.DataContext = daynow;
                        //3
                        tbdSun3.DataContext = daynow;
                        tbdMon3.DataContext = daynow;
                        tbdTue3.DataContext = daynow;
                        tbdWed3.DataContext = daynow;
                        tbdThu3.DataContext = daynow;
                        tbdFri3.DataContext = daynow;
                        tbdSat3.DataContext = daynow;
                        //4
                        tbdSun4.DataContext = daynow;
                        tbdMon4.DataContext = daynow;
                        tbdTue4.DataContext = daynow;
                        tbdWed4.DataContext = daynow;
                        tbdThu4.DataContext = daynow;
                        tbdFri4.DataContext = daynow;
                        tbdSat4.DataContext = daynow;
                        //5
                        tbdSun5.DataContext = daynow;
                        tbdMon5.DataContext = daynow;
                        tbdTue5.DataContext = daynow;
                        tbdWed5.DataContext = daynow;
                        tbdThu5.DataContext = daynow;
                        tbdFri5.DataContext = daynow;
                        //Color day 

                        tbdSat1.Foreground = color;
                        //2
                        tbdSun2.Foreground = color;
                        tbdMon2.Foreground = color;
                        tbdTue2.Foreground = color;
                        tbdWed2.Foreground = color;
                        tbdThu2.Foreground = color;
                        tbdFri2.Foreground = color;
                        tbdSat2.Foreground = color;
                        //3
                        tbdSun3.Foreground = color;
                        tbdMon3.Foreground = color;
                        tbdTue3.Foreground = color;
                        tbdWed3.Foreground = color;
                        tbdThu3.Foreground = color;
                        tbdFri3.Foreground = color;
                        tbdSat3.Foreground = color;
                        //4
                        tbdSun4.Foreground = color;
                        tbdMon4.Foreground = color;
                        tbdTue4.Foreground = color;
                        tbdWed4.Foreground = color;
                        tbdThu4.Foreground = color;
                        tbdFri4.Foreground = color;
                        tbdSat4.Foreground = color;
                        //5
                        tbdSun5.Foreground = color;
                        tbdMon5.Foreground = color;
                        tbdTue5.Foreground = color;
                        tbdWed5.Foreground = color;
                        tbdThu5.Foreground = color;
                        tbdFri5.Foreground = color;
                    }


                    break;
            }


        }
        private void monthyearsnow()
        {
            DateTime nextmonth = nownp.AddMonths(i);
            DateTime nextm = new DateTime(nownp.Year, nextmonth.Month, nownp.Day);
            tbMonthCal.Text = nownp.ToString("MMMM", CultureInfo.CurrentCulture.NumberFormat);
            tbYearCal.Text = nownp.Year.ToString();
        }
        //Background day now
        private void BGDayNow(DayinMonth dayin, string month, string year)
        {
            DateTime now = DateTime.Now;

            Brush colorbg = ConvertColor(72, 110, 147);


            //background datenow
            if (year == now.Year.ToString() && month == now.Month.ToString())
            {

                switch (now.DayOfWeek.ToString())
                {
                    case "Sunday":
                        if (dayin.dSun1 != null && dayin.dSun1.Equals(now.Day.ToString())) { btnSun1.Background = colorbg; }
                        if (dayin.dSun2 != null && dayin.dSun2.Equals(now.Day.ToString())) { btnSun2.Background = colorbg; }
                        if (dayin.dSun3 != null && dayin.dSun3.Equals(now.Day.ToString())) { btnSun3.Background = colorbg; }
                        if (dayin.dSun4 != null && dayin.dSun4.Equals(now.Day.ToString())) { btnSun4.Background = colorbg; }
                        if (dayin.dSun5 != null && dayin.dSun5.Equals(now.Day.ToString())) { btnSun5.Background = colorbg; }
                        if (dayin.dSun6 != null && dayin.dSun6.Equals(now.Day.ToString())) { btnSun6.Background = colorbg; }
                        if (now.Day >= 25 && now.Day <= 30)
                        {
                            btnSun1.Background = null;
                            btnMon1.Background = null;
                            btnTue1.Background = null;
                            btnWed1.Background = null;
                            btnThu1.Background = null;
                            btnFri1.Background = null;
                            btnSat1.Background = null;
                        }
                        break;
                    case "Monday":
                        if (dayin.dMon1 != null && dayin.dMon1.Equals(now.Day.ToString())) { btnMon1.Background = colorbg; }
                        if (dayin.dMon2 != null && dayin.dMon2.Equals(now.Day.ToString())) { btnMon2.Background = colorbg; }
                        if (dayin.dMon3 != null && dayin.dMon3.Equals(now.Day.ToString())) { btnMon3.Background = colorbg; }
                        if (dayin.dMon4 != null && dayin.dMon4.Equals(now.Day.ToString())) { btnMon4.Background = colorbg; }
                        if (dayin.dMon5 != null && dayin.dMon5.Equals(now.Day.ToString())) { btnMon5.Background = colorbg; }
                        if (dayin.dMon6 != null && dayin.dMon6.Equals(now.Day.ToString())) { btnMon6.Background = colorbg; }
                        if (now.Day >= 25 && now.Day <= 30)
                        {
                            btnSun1.Background = null;
                            btnMon1.Background = null;
                            btnTue1.Background = null;
                            btnWed1.Background = null;
                            btnThu1.Background = null;
                            btnFri1.Background = null;
                            btnSat1.Background = null;
                        }
                        break;
                    case "Tuesday":
                        if (dayin.dTue1 != null && dayin.dTue1.Equals(now.Day.ToString())) { btnTue1.Background = colorbg; }
                        if (dayin.dTue2 != null && dayin.dTue2.Equals(now.Day.ToString())) { btnTue2.Background = colorbg; }
                        if (dayin.dTue3 != null && dayin.dTue3.Equals(now.Day.ToString())) { btnTue3.Background = colorbg; }
                        if (dayin.dTue4 != null && dayin.dTue4.Equals(now.Day.ToString())) { btnTue4.Background = colorbg; }
                        if (dayin.dTue5 != null && dayin.dTue5.Equals(now.Day.ToString())) { btnTue5.Background = colorbg; }
                        if (dayin.dTue6 != null && dayin.dTue6.Equals(now.Day.ToString())) { btnTue6.Background = colorbg; }
                        if (now.Day >= 25 && now.Day <= 30)
                        {
                            btnSun1.Background = null;
                            btnMon1.Background = null;
                            btnTue1.Background = null;
                            btnWed1.Background = null;
                            btnThu1.Background = null;
                            btnFri1.Background = null;
                            btnSat1.Background = null;
                        }
                        break;
                    case "Wednesday":
                        if (dayin.dWed1 != null && dayin.dWed1.Equals(now.Day.ToString())) { btnWed1.Background = colorbg; }
                        if (dayin.dWed2 != null && dayin.dWed2.Equals(now.Day.ToString())) { btnWed2.Background = colorbg; }
                        if (dayin.dWed3 != null && dayin.dWed3.Equals(now.Day.ToString())) { btnWed3.Background = colorbg; }
                        if (dayin.dWed4 != null && dayin.dWed4.Equals(now.Day.ToString())) { btnWed4.Background = colorbg; }
                        if (dayin.dWed5 != null && dayin.dWed5.Equals(now.Day.ToString())) { btnWed5.Background = colorbg; }
                        if (dayin.dWed6 != null && dayin.dWed6.Equals(now.Day.ToString())) { btnWed6.Background = colorbg; }
                        if (now.Day >= 25 && now.Day <= 30)
                        {
                            btnSun1.Background = null;
                            btnMon1.Background = null;
                            btnTue1.Background = null;
                            btnWed1.Background = null;
                            btnThu1.Background = null;
                            btnFri1.Background = null;
                            btnSat1.Background = null;
                        }
                        break;
                    case "Thursday":
                        if (dayin.dThu1 != null && dayin.dThu1.Equals(now.Day.ToString())) { btnThu1.Background = colorbg; }
                        if (dayin.dThu2 != null && dayin.dThu2.Equals(now.Day.ToString())) { btnThu2.Background = colorbg; }
                        if (dayin.dThu3 != null && dayin.dThu3.Equals(now.Day.ToString())) { btnThu3.Background = colorbg; }
                        if (dayin.dThu4 != null && dayin.dThu4.Equals(now.Day.ToString())) { btnThu4.Background = colorbg; }
                        if (dayin.dThu5 != null && dayin.dThu5.Equals(now.Day.ToString())) { btnThu5.Background = colorbg; }
                        if (dayin.dThu6 != null && dayin.dThu6.Equals(now.Day.ToString())) { btnThu6.Background = colorbg; }
                        if (now.Day >= 25 && now.Day <= 30)
                        {
                            btnSun1.Background = null;
                            btnMon1.Background = null;
                            btnTue1.Background = null;
                            btnWed1.Background = null;
                            btnThu1.Background = null;
                            btnFri1.Background = null;
                            btnSat1.Background = null;
                        }
                        break;
                    case "Friday":
                        if (dayin.dFri1 != null && dayin.dFri1.Equals(now.Day.ToString())) { btnFri1.Background = colorbg; }
                        if (dayin.dFri2 != null && dayin.dFri2.Equals(now.Day.ToString())) { btnFri2.Background = colorbg; }
                        if (dayin.dFri3 != null && dayin.dFri3.Equals(now.Day.ToString())) { btnFri3.Background = colorbg; }
                        if (dayin.dFri4 != null && dayin.dFri4.Equals(now.Day.ToString())) { btnFri4.Background = colorbg; }
                        if (dayin.dFri5 != null && dayin.dFri5.Equals(now.Day.ToString())) { btnFri5.Background = colorbg; }
                        if (dayin.dFri6 != null && dayin.dFri6.Equals(now.Day.ToString())) { btnFri6.Background = colorbg; }
                        if (now.Day >= 25 && now.Day <= 30)
                        {
                            btnSun1.Background = null;
                            btnMon1.Background = null;
                            btnTue1.Background = null;
                            btnWed1.Background = null;
                            btnThu1.Background = null;
                            btnFri1.Background = null;
                            btnSat1.Background = null;
                        }
                        break;
                    case "Saturday":
                        if (dayin.dSat1 != null && dayin.dSat1.Equals(now.Day.ToString())) { btnSat1.Background = colorbg; }
                        if (dayin.dSat2 != null && dayin.dSat2.Equals(now.Day.ToString())) { btnSat2.Background = colorbg; }
                        if (dayin.dSat3 != null && dayin.dSat3.Equals(now.Day.ToString())) { btnSat3.Background = colorbg; }
                        if (dayin.dSat4 != null && dayin.dSat4.Equals(now.Day.ToString())) { btnSat4.Background = colorbg; }
                        if (dayin.dSat5 != null && dayin.dSat5.Equals(now.Day.ToString())) { btnSat5.Background = colorbg; }
                        if (dayin.dSat6 != null && dayin.dSat6.Equals(now.Day.ToString())) { btnSat6.Background = colorbg; }
                        if (now.Day >= 25 && now.Day <= 30)
                        {
                            btnSun1.Background = null;
                            btnMon1.Background = null;
                            btnTue1.Background = null;
                            btnWed1.Background = null;
                            btnThu1.Background = null;
                            btnFri1.Background = null;
                            btnSat1.Background = null;
                        }
                        break;

                }
            }
            else
            {
                btnSun1.Background = null;
                btnSun2.Background = null;
                btnSun3.Background = null;
                btnSun4.Background = null;
                btnSun5.Background = null;
                btnSun6.Background = null;
                btnMon1.Background = null;
                btnMon2.Background = null;
                btnMon3.Background = null;
                btnMon4.Background = null;
                btnMon5.Background = null;
                btnMon6.Background = null;
                btnTue1.Background = null;
                btnTue2.Background = null;
                btnTue3.Background = null;
                btnTue4.Background = null;
                btnTue5.Background = null;
                btnTue6.Background = null;
                btnWed1.Background = null;
                btnWed2.Background = null;
                btnWed3.Background = null;
                btnWed4.Background = null;
                btnWed5.Background = null;
                btnWed6.Background = null;
                btnThu1.Background = null;
                btnThu2.Background = null;
                btnThu3.Background = null;
                btnThu4.Background = null;
                btnThu5.Background = null;
                btnThu6.Background = null;
                btnFri1.Background = null;
                btnFri2.Background = null;
                btnFri3.Background = null;
                btnFri4.Background = null;
                btnFri5.Background = null;
                btnFri6.Background = null;
                btnSat1.Background = null;
                btnSat2.Background = null;
                btnSat3.Background = null;
                btnSat4.Background = null;
                btnSat5.Background = null;
                btnSat6.Background = null;
            }
        }

        //Next and Previous
        static DateTime nownp = DateTime.Now;

        int i = 0;
        int j = 0;
        int result = 1;
        private void NextMY_Click(object sender, RoutedEventArgs e)
        {
            i++;
            DateTime nextmonth = nownp.AddMonths(i);
            DateTime nextm = new DateTime(nownp.Year, nextmonth.Month, nownp.Day);
            tbMonthCal.Text = nextm.ToString("MMMM", CultureInfo.CurrentCulture.NumberFormat);
            if (result == 1) { tbYearCal.Text = nownp.Year.ToString(); }


            if (tbMonthCal.Text == "January")
            {
                j++;
                DateTime nextYear = nownp.AddYears(j);
                DateTime nextY = new DateTime(nextYear.Year, nextm.Month, nownp.Day);
                tbMonthCal.Text = nextm.ToString("MMMM", CultureInfo.CurrentCulture.NumberFormat);
                tbYearCal.Text = nextY.Year.ToString();
                result = 2;
            }
            nextprem(tbMonthCal.Text, tbYearCal.Text);

        }

        private void PreviousMY_Click(object sender, RoutedEventArgs e)
        {
            i--;
            DateTime nextmonth = nownp.AddMonths(i);
            DateTime nextm = new DateTime(nownp.Year, nextmonth.Month, nownp.Day);
            tbMonthCal.Text = nextm.ToString("MMMM", CultureInfo.CurrentCulture.NumberFormat);

            if (result == 1) { tbYearCal.Text = nownp.Year.ToString(); }

            if (tbMonthCal.Text == "December")
            {
                j--;
                DateTime nextYear = nownp.AddYears(j);
                DateTime nextY = new DateTime(nextYear.Year, nextm.Month, nownp.Day);
                tbMonthCal.Text = nextm.ToString("MMMM", CultureInfo.CurrentCulture.NumberFormat);
                tbYearCal.Text = nextY.Year.ToString();
                result = 2;
            }
            nextprem(tbMonthCal.Text, tbYearCal.Text);
        }

        private void nextprem(string month, string year)
        {
            DayinMonth nm = CalendarCus.NextPreMonth(month, year);


            int months = (month == "January") ? 1 : (month == "February")
               ? 2 : (month == "March") ? 3 : (month == "April") ? 4 : (month == "May") ? 5 : (month == "June")
               ? 6 : (month == "July") ? 7 : (month == "August") ? 8 : (month == "September") ? 9 : (month == "October")
               ? 10 : (month == "November") ? 11 : (month == "December") ? 12 : 0;

            DayinMonth dnextpre = new DayinMonth();
            Brush colorcenter = ConvertColor(253, 253, 253);
            Brush colorba = ConvertColor(129, 152, 177);

            if (months != 0)
            {
                string dateStr = months.ToString() + "/" + 1 + "/" + year;
                DateTime datetime = DateTime.Parse(dateStr);

                BGDayNow(nm, months.ToString(), year);


                int totalday = DateTime.DaysInMonth(datetime.Year, datetime.Month);
                string day = datetime.DayOfWeek.ToString();
                //show day
                tbdSun1.DataContext = nm;
                tbdMon1.DataContext = nm;
                tbdTue1.DataContext = nm;
                tbdWed1.DataContext = nm;
                tbdThu1.DataContext = nm;
                tbdFri1.DataContext = nm;
                tbdSat1.DataContext = nm;
                //2
                tbdSun2.DataContext = nm;
                tbdMon2.DataContext = nm;
                tbdTue2.DataContext = nm;
                tbdWed2.DataContext = nm;
                tbdThu2.DataContext = nm;
                tbdFri2.DataContext = nm;
                tbdSat2.DataContext = nm;
                //3
                tbdSun3.DataContext = nm;
                tbdMon3.DataContext = nm;
                tbdTue3.DataContext = nm;
                tbdWed3.DataContext = nm;
                tbdThu3.DataContext = nm;
                tbdFri3.DataContext = nm;
                tbdSat3.DataContext = nm;
                //4
                tbdSun4.DataContext = nm;
                tbdMon4.DataContext = nm;
                tbdTue4.DataContext = nm;
                tbdWed4.DataContext = nm;
                tbdThu4.DataContext = nm;
                tbdFri4.DataContext = nm;
                tbdSat4.DataContext = nm;
                //5
                tbdSun5.DataContext = nm;
                tbdMon5.DataContext = nm;
                tbdTue5.DataContext = nm;
                tbdWed5.DataContext = nm;
                tbdThu5.DataContext = nm;
                tbdFri5.DataContext = nm;
                tbdSat5.DataContext = nm;
                //6
                tbdSun6.DataContext = nm;
                tbdMon6.DataContext = nm;
                tbdTue6.DataContext = nm;
                tbdWed6.DataContext = nm;
                tbdThu6.DataContext = nm;
                tbdFri6.DataContext = nm;
                tbdSat6.DataContext = nm;



                switch (day)
                {
                    case "Sunday":
                        if (totalday == 31)
                        {
                            tbdSun1.Foreground = colorcenter;
                            tbdMon1.Foreground = colorcenter;
                            tbdTue1.Foreground = colorcenter;
                            tbdWed1.Foreground = colorcenter;
                            tbdThu1.Foreground = colorcenter;
                            tbdFri1.Foreground = colorcenter;
                            tbdSat1.Foreground = colorcenter;
                            //2                  
                            tbdSun2.Foreground = colorcenter;
                            tbdMon2.Foreground = colorcenter;
                            tbdTue2.Foreground = colorcenter;
                            tbdWed2.Foreground = colorcenter;
                            tbdThu2.Foreground = colorcenter;
                            tbdFri2.Foreground = colorcenter;
                            tbdSat2.Foreground = colorcenter;
                            //3                  
                            tbdSun3.Foreground = colorcenter;
                            tbdMon3.Foreground = colorcenter;
                            tbdTue3.Foreground = colorcenter;
                            tbdWed3.Foreground = colorcenter;
                            tbdThu3.Foreground = colorcenter;
                            tbdFri3.Foreground = colorcenter;
                            tbdSat3.Foreground = colorcenter;
                            //4                 
                            tbdSun4.Foreground = colorcenter;
                            tbdMon4.Foreground = colorcenter;
                            tbdTue4.Foreground = colorcenter;
                            tbdWed4.Foreground = colorcenter;
                            tbdThu4.Foreground = colorcenter;
                            tbdFri4.Foreground = colorcenter;
                            tbdSat4.Foreground = colorcenter;
                            //5                 
                            tbdSun5.Foreground = colorcenter;
                            tbdMon5.Foreground = colorcenter;
                            tbdTue5.Foreground = colorcenter;
                            //color ba
                            tbdWed5.Foreground = colorba;
                            tbdThu5.Foreground = colorba;
                            tbdFri5.Foreground = colorba;
                            tbdSat5.Foreground = colorba;
                            //6     
                            tbdSun6.Foreground = colorba;
                            tbdMon6.Foreground = colorba;
                            tbdTue6.Foreground = colorba;
                            tbdWed6.Foreground = colorba;
                            tbdThu6.Foreground = colorba;
                            tbdFri6.Foreground = colorba;
                            tbdSat6.Foreground = colorba;


                        }
                        else if (totalday == 30)
                        {
                            tbdSun1.Foreground = colorcenter;
                            tbdMon1.Foreground = colorcenter;
                            tbdTue1.Foreground = colorcenter;
                            tbdWed1.Foreground = colorcenter;
                            tbdThu1.Foreground = colorcenter;
                            tbdFri1.Foreground = colorcenter;
                            tbdSat1.Foreground = colorcenter;
                            //2     
                            tbdSun2.Foreground = colorcenter;
                            tbdMon2.Foreground = colorcenter;
                            tbdTue2.Foreground = colorcenter;
                            tbdWed2.Foreground = colorcenter;
                            tbdThu2.Foreground = colorcenter;
                            tbdFri2.Foreground = colorcenter;
                            tbdSat2.Foreground = colorcenter;
                            //3     
                            tbdSun3.Foreground = colorcenter;
                            tbdMon3.Foreground = colorcenter;
                            tbdTue3.Foreground = colorcenter;
                            tbdWed3.Foreground = colorcenter;
                            tbdThu3.Foreground = colorcenter;
                            tbdFri3.Foreground = colorcenter;
                            tbdSat3.Foreground = colorcenter;
                            //4     
                            tbdSun4.Foreground = colorcenter;
                            tbdMon4.Foreground = colorcenter;
                            tbdTue4.Foreground = colorcenter;
                            tbdWed4.Foreground = colorcenter;
                            tbdThu4.Foreground = colorcenter;
                            tbdFri4.Foreground = colorcenter;
                            tbdSat4.Foreground = colorcenter;
                            //5     
                            tbdSun5.Foreground = colorcenter;
                            tbdMon5.Foreground = colorcenter;
                            //color ba
                            tbdTue5.Foreground = colorba;
                            tbdWed5.Foreground = colorba;
                            tbdThu5.Foreground = colorba;
                            tbdFri5.Foreground = colorba;
                            tbdSat5.Foreground = colorba;
                            //6     
                            tbdSun6.Foreground = colorba;
                            tbdMon6.Foreground = colorba;
                            tbdTue6.Foreground = colorba;
                            tbdWed6.Foreground = colorba;
                            tbdThu6.Foreground = colorba;
                            tbdFri6.Foreground = colorba;
                            tbdSat6.Foreground = colorba;
                        }
                        else if (totalday == 29)
                        {
                            tbdSun1.Foreground = colorcenter;
                            tbdMon1.Foreground = colorcenter;
                            tbdTue1.Foreground = colorcenter;
                            tbdWed1.Foreground = colorcenter;
                            tbdThu1.Foreground = colorcenter;
                            tbdFri1.Foreground = colorcenter;
                            tbdSat1.Foreground = colorcenter;
                            //2                  
                            tbdSun2.Foreground = colorcenter;
                            tbdMon2.Foreground = colorcenter;
                            tbdTue2.Foreground = colorcenter;
                            tbdWed2.Foreground = colorcenter;
                            tbdThu2.Foreground = colorcenter;
                            tbdFri2.Foreground = colorcenter;
                            tbdSat2.Foreground = colorcenter;
                            //3                  
                            tbdSun3.Foreground = colorcenter;
                            tbdMon3.Foreground = colorcenter;
                            tbdTue3.Foreground = colorcenter;
                            tbdWed3.Foreground = colorcenter;
                            tbdThu3.Foreground = colorcenter;
                            tbdFri3.Foreground = colorcenter;
                            tbdSat3.Foreground = colorcenter;
                            //4                 
                            tbdSun4.Foreground = colorcenter;
                            tbdMon4.Foreground = colorcenter;
                            tbdTue4.Foreground = colorcenter;
                            tbdWed4.Foreground = colorcenter;
                            tbdThu4.Foreground = colorcenter;
                            tbdFri4.Foreground = colorcenter;
                            tbdSat4.Foreground = colorcenter;
                            //5                 
                            tbdSun5.Foreground = colorcenter;
                            //color ba
                            tbdMon5.Foreground = colorba;
                            tbdTue5.Foreground = colorba;
                            tbdWed5.Foreground = colorba;
                            tbdThu5.Foreground = colorba;
                            tbdFri5.Foreground = colorba;
                            tbdSat5.Foreground = colorba;
                            //6     
                            tbdSun6.Foreground = colorba;
                            tbdMon6.Foreground = colorba;
                            tbdTue6.Foreground = colorba;
                            tbdWed6.Foreground = colorba;
                            tbdThu6.Foreground = colorba;
                            tbdFri6.Foreground = colorba;
                            tbdSat6.Foreground = colorba;
                        }
                        else if (totalday == 28)
                        {
                            tbdSun1.Foreground = colorcenter;
                            tbdMon1.Foreground = colorcenter;
                            tbdTue1.Foreground = colorcenter;
                            tbdWed1.Foreground = colorcenter;
                            tbdThu1.Foreground = colorcenter;
                            tbdFri1.Foreground = colorcenter;
                            tbdSat1.Foreground = colorcenter;
                            //2                  
                            tbdSun2.Foreground = colorcenter;
                            tbdMon2.Foreground = colorcenter;
                            tbdTue2.Foreground = colorcenter;
                            tbdWed2.Foreground = colorcenter;
                            tbdThu2.Foreground = colorcenter;
                            tbdFri2.Foreground = colorcenter;
                            tbdSat2.Foreground = colorcenter;
                            //3                  
                            tbdSun3.Foreground = colorcenter;
                            tbdMon3.Foreground = colorcenter;
                            tbdTue3.Foreground = colorcenter;
                            tbdWed3.Foreground = colorcenter;
                            tbdThu3.Foreground = colorcenter;
                            tbdFri3.Foreground = colorcenter;
                            tbdSat3.Foreground = colorcenter;
                            //4                 
                            tbdSun4.Foreground = colorcenter;
                            tbdMon4.Foreground = colorcenter;
                            tbdTue4.Foreground = colorcenter;
                            tbdWed4.Foreground = colorcenter;
                            tbdThu4.Foreground = colorcenter;
                            tbdFri4.Foreground = colorcenter;
                            tbdSat4.Foreground = colorcenter;
                            //color ba
                            tbdSun5.Foreground = colorba;
                            tbdMon5.Foreground = colorba;
                            tbdTue5.Foreground = colorba;
                            tbdWed5.Foreground = colorba;
                            tbdThu5.Foreground = colorba;
                            tbdFri5.Foreground = colorba;
                            tbdSat5.Foreground = colorba;
                            //6     
                            tbdSun6.Foreground = colorba;
                            tbdMon6.Foreground = colorba;
                            tbdTue6.Foreground = colorba;
                            tbdWed6.Foreground = colorba;
                            tbdThu6.Foreground = colorba;
                            tbdFri6.Foreground = colorba;
                            tbdSat6.Foreground = colorba;
                        }

                        break;
                    case "Monday":
                        if (totalday == 31)
                        {
                            tbdSun1.Foreground = colorba;
                            tbdMon1.Foreground = colorcenter;
                            tbdTue1.Foreground = colorcenter;
                            tbdWed1.Foreground = colorcenter;
                            tbdThu1.Foreground = colorcenter;
                            tbdFri1.Foreground = colorcenter;
                            tbdSat1.Foreground = colorcenter;
                            //2                  
                            tbdSun2.Foreground = colorcenter;
                            tbdMon2.Foreground = colorcenter;
                            tbdTue2.Foreground = colorcenter;
                            tbdWed2.Foreground = colorcenter;
                            tbdThu2.Foreground = colorcenter;
                            tbdFri2.Foreground = colorcenter;
                            tbdSat2.Foreground = colorcenter;
                            //3                  
                            tbdSun3.Foreground = colorcenter;
                            tbdMon3.Foreground = colorcenter;
                            tbdTue3.Foreground = colorcenter;
                            tbdWed3.Foreground = colorcenter;
                            tbdThu3.Foreground = colorcenter;
                            tbdFri3.Foreground = colorcenter;
                            tbdSat3.Foreground = colorcenter;
                            //4                 
                            tbdSun4.Foreground = colorcenter;
                            tbdMon4.Foreground = colorcenter;
                            tbdTue4.Foreground = colorcenter;
                            tbdWed4.Foreground = colorcenter;
                            tbdThu4.Foreground = colorcenter;
                            tbdFri4.Foreground = colorcenter;
                            tbdSat4.Foreground = colorcenter;
                            //5                 
                            tbdSun5.Foreground = colorcenter;
                            tbdMon5.Foreground = colorcenter;
                            tbdTue5.Foreground = colorcenter;
                            tbdWed5.Foreground = colorcenter;
                            //color ba
                            tbdThu5.Foreground = colorba;
                            tbdFri5.Foreground = colorba;
                            tbdSat5.Foreground = colorba;
                            //6     
                            tbdSun6.Foreground = colorba;
                            tbdMon6.Foreground = colorba;
                            tbdTue6.Foreground = colorba;
                            tbdWed6.Foreground = colorba;
                            tbdThu6.Foreground = colorba;
                            tbdFri6.Foreground = colorba;
                            tbdSat6.Foreground = colorba;


                        }
                        else if (totalday == 30)
                        {
                            tbdSun1.Foreground = colorba;
                            tbdMon1.Foreground = colorcenter;
                            tbdTue1.Foreground = colorcenter;
                            tbdWed1.Foreground = colorcenter;
                            tbdThu1.Foreground = colorcenter;
                            tbdFri1.Foreground = colorcenter;
                            tbdSat1.Foreground = colorcenter;
                            //2                  
                            tbdSun2.Foreground = colorcenter;
                            tbdMon2.Foreground = colorcenter;
                            tbdTue2.Foreground = colorcenter;
                            tbdWed2.Foreground = colorcenter;
                            tbdThu2.Foreground = colorcenter;
                            tbdFri2.Foreground = colorcenter;
                            tbdSat2.Foreground = colorcenter;
                            //3                  
                            tbdSun3.Foreground = colorcenter;
                            tbdMon3.Foreground = colorcenter;
                            tbdTue3.Foreground = colorcenter;
                            tbdWed3.Foreground = colorcenter;
                            tbdThu3.Foreground = colorcenter;
                            tbdFri3.Foreground = colorcenter;
                            tbdSat3.Foreground = colorcenter;
                            //4                 
                            tbdSun4.Foreground = colorcenter;
                            tbdMon4.Foreground = colorcenter;
                            tbdTue4.Foreground = colorcenter;
                            tbdWed4.Foreground = colorcenter;
                            tbdThu4.Foreground = colorcenter;
                            tbdFri4.Foreground = colorcenter;
                            tbdSat4.Foreground = colorcenter;
                            //5                 
                            tbdSun5.Foreground = colorcenter;
                            tbdMon5.Foreground = colorcenter;
                            tbdTue5.Foreground = colorcenter;
                            //color ba
                            tbdWed5.Foreground = colorba;
                            tbdThu5.Foreground = colorba;
                            tbdFri5.Foreground = colorba;
                            tbdSat5.Foreground = colorba;
                            //6     
                            tbdSun6.Foreground = colorba;
                            tbdMon6.Foreground = colorba;
                            tbdTue6.Foreground = colorba;
                            tbdWed6.Foreground = colorba;
                            tbdThu6.Foreground = colorba;
                            tbdFri6.Foreground = colorba;
                            tbdSat6.Foreground = colorba;
                        }
                        else if (totalday == 29)
                        {
                            tbdSun1.Foreground = colorba;
                            tbdMon1.Foreground = colorcenter;
                            tbdTue1.Foreground = colorcenter;
                            tbdWed1.Foreground = colorcenter;
                            tbdThu1.Foreground = colorcenter;
                            tbdFri1.Foreground = colorcenter;
                            tbdSat1.Foreground = colorcenter;
                            //2                  
                            tbdSun2.Foreground = colorcenter;
                            tbdMon2.Foreground = colorcenter;
                            tbdTue2.Foreground = colorcenter;
                            tbdWed2.Foreground = colorcenter;
                            tbdThu2.Foreground = colorcenter;
                            tbdFri2.Foreground = colorcenter;
                            tbdSat2.Foreground = colorcenter;
                            //3                  
                            tbdSun3.Foreground = colorcenter;
                            tbdMon3.Foreground = colorcenter;
                            tbdTue3.Foreground = colorcenter;
                            tbdWed3.Foreground = colorcenter;
                            tbdThu3.Foreground = colorcenter;
                            tbdFri3.Foreground = colorcenter;
                            tbdSat3.Foreground = colorcenter;
                            //4                 
                            tbdSun4.Foreground = colorcenter;
                            tbdMon4.Foreground = colorcenter;
                            tbdTue4.Foreground = colorcenter;
                            tbdWed4.Foreground = colorcenter;
                            tbdThu4.Foreground = colorcenter;
                            tbdFri4.Foreground = colorcenter;
                            tbdSat4.Foreground = colorcenter;
                            //5                 
                            tbdSun5.Foreground = colorcenter;
                            tbdMon5.Foreground = colorcenter;
                            //color ba
                            tbdTue5.Foreground = colorba;
                            tbdWed5.Foreground = colorba;
                            tbdThu5.Foreground = colorba;
                            tbdFri5.Foreground = colorba;
                            tbdSat5.Foreground = colorba;
                            //6     
                            tbdSun6.Foreground = colorba;
                            tbdMon6.Foreground = colorba;
                            tbdTue6.Foreground = colorba;
                            tbdWed6.Foreground = colorba;
                            tbdThu6.Foreground = colorba;
                            tbdFri6.Foreground = colorba;
                            tbdSat6.Foreground = colorba;
                        }
                        else if (totalday == 28)
                        {
                            tbdSun1.Foreground = colorba;
                            tbdMon1.Foreground = colorcenter;
                            tbdTue1.Foreground = colorcenter;
                            tbdWed1.Foreground = colorcenter;
                            tbdThu1.Foreground = colorcenter;
                            tbdFri1.Foreground = colorcenter;
                            tbdSat1.Foreground = colorcenter;
                            //2                  
                            tbdSun2.Foreground = colorcenter;
                            tbdMon2.Foreground = colorcenter;
                            tbdTue2.Foreground = colorcenter;
                            tbdWed2.Foreground = colorcenter;
                            tbdThu2.Foreground = colorcenter;
                            tbdFri2.Foreground = colorcenter;
                            tbdSat2.Foreground = colorcenter;
                            //3                  
                            tbdSun3.Foreground = colorcenter;
                            tbdMon3.Foreground = colorcenter;
                            tbdTue3.Foreground = colorcenter;
                            tbdWed3.Foreground = colorcenter;
                            tbdThu3.Foreground = colorcenter;
                            tbdFri3.Foreground = colorcenter;
                            tbdSat3.Foreground = colorcenter;
                            //4                 
                            tbdSun4.Foreground = colorcenter;
                            tbdMon4.Foreground = colorcenter;
                            tbdTue4.Foreground = colorcenter;
                            tbdWed4.Foreground = colorcenter;
                            tbdThu4.Foreground = colorcenter;
                            tbdFri4.Foreground = colorcenter;
                            tbdSat4.Foreground = colorcenter;
                            tbdSun5.Foreground = colorcenter;
                            //color ba
                            tbdMon5.Foreground = colorba;
                            tbdTue5.Foreground = colorba;
                            tbdWed5.Foreground = colorba;
                            tbdThu5.Foreground = colorba;
                            tbdFri5.Foreground = colorba;
                            tbdSat5.Foreground = colorba;
                            //6     
                            tbdSun6.Foreground = colorba;
                            tbdMon6.Foreground = colorba;
                            tbdTue6.Foreground = colorba;
                            tbdWed6.Foreground = colorba;
                            tbdThu6.Foreground = colorba;
                            tbdFri6.Foreground = colorba;
                            tbdSat6.Foreground = colorba;
                        }
                        break;
                    case "Tuesday":
                        if (totalday == 31)
                        {
                            tbdSun1.Foreground = colorba;
                            tbdMon1.Foreground = colorba;
                            tbdTue1.Foreground = colorcenter;
                            tbdWed1.Foreground = colorcenter;
                            tbdThu1.Foreground = colorcenter;
                            tbdFri1.Foreground = colorcenter;
                            tbdSat1.Foreground = colorcenter;
                            //2                  
                            tbdSun2.Foreground = colorcenter;
                            tbdMon2.Foreground = colorcenter;
                            tbdTue2.Foreground = colorcenter;
                            tbdWed2.Foreground = colorcenter;
                            tbdThu2.Foreground = colorcenter;
                            tbdFri2.Foreground = colorcenter;
                            tbdSat2.Foreground = colorcenter;
                            //3                  
                            tbdSun3.Foreground = colorcenter;
                            tbdMon3.Foreground = colorcenter;
                            tbdTue3.Foreground = colorcenter;
                            tbdWed3.Foreground = colorcenter;
                            tbdThu3.Foreground = colorcenter;
                            tbdFri3.Foreground = colorcenter;
                            tbdSat3.Foreground = colorcenter;
                            //4                 
                            tbdSun4.Foreground = colorcenter;
                            tbdMon4.Foreground = colorcenter;
                            tbdTue4.Foreground = colorcenter;
                            tbdWed4.Foreground = colorcenter;
                            tbdThu4.Foreground = colorcenter;
                            tbdFri4.Foreground = colorcenter;
                            tbdSat4.Foreground = colorcenter;
                            //5                 
                            tbdSun5.Foreground = colorcenter;
                            tbdMon5.Foreground = colorcenter;
                            tbdTue5.Foreground = colorcenter;
                            tbdWed5.Foreground = colorcenter;
                            tbdThu5.Foreground = colorcenter;
                            //color ba
                            tbdFri5.Foreground = colorba;
                            tbdSat5.Foreground = colorba;
                            //6     
                            tbdSun6.Foreground = colorba;
                            tbdMon6.Foreground = colorba;
                            tbdTue6.Foreground = colorba;
                            tbdWed6.Foreground = colorba;
                            tbdThu6.Foreground = colorba;
                            tbdFri6.Foreground = colorba;
                            tbdSat6.Foreground = colorba;


                        }
                        else if (totalday == 30)
                        {
                            tbdSun1.Foreground = colorba;
                            tbdMon1.Foreground = colorba;
                            tbdTue1.Foreground = colorcenter;
                            tbdWed1.Foreground = colorcenter;
                            tbdThu1.Foreground = colorcenter;
                            tbdFri1.Foreground = colorcenter;
                            tbdSat1.Foreground = colorcenter;
                            //2                  
                            tbdSun2.Foreground = colorcenter;
                            tbdMon2.Foreground = colorcenter;
                            tbdTue2.Foreground = colorcenter;
                            tbdWed2.Foreground = colorcenter;
                            tbdThu2.Foreground = colorcenter;
                            tbdFri2.Foreground = colorcenter;
                            tbdSat2.Foreground = colorcenter;
                            //3                  
                            tbdSun3.Foreground = colorcenter;
                            tbdMon3.Foreground = colorcenter;
                            tbdTue3.Foreground = colorcenter;
                            tbdWed3.Foreground = colorcenter;
                            tbdThu3.Foreground = colorcenter;
                            tbdFri3.Foreground = colorcenter;
                            tbdSat3.Foreground = colorcenter;
                            //4                 
                            tbdSun4.Foreground = colorcenter;
                            tbdMon4.Foreground = colorcenter;
                            tbdTue4.Foreground = colorcenter;
                            tbdWed4.Foreground = colorcenter;
                            tbdThu4.Foreground = colorcenter;
                            tbdFri4.Foreground = colorcenter;
                            tbdSat4.Foreground = colorcenter;
                            //5                 
                            tbdSun5.Foreground = colorcenter;
                            tbdMon5.Foreground = colorcenter;
                            tbdTue5.Foreground = colorcenter;
                            tbdWed5.Foreground = colorcenter;
                            //color ba
                            tbdThu5.Foreground = colorba;
                            tbdFri5.Foreground = colorba;
                            tbdSat5.Foreground = colorba;
                            //6     
                            tbdSun6.Foreground = colorba;
                            tbdMon6.Foreground = colorba;
                            tbdTue6.Foreground = colorba;
                            tbdWed6.Foreground = colorba;
                            tbdThu6.Foreground = colorba;
                            tbdFri6.Foreground = colorba;
                            tbdSat6.Foreground = colorba;
                        }
                        else if (totalday == 29)
                        {
                            tbdSun1.Foreground = colorba;
                            tbdMon1.Foreground = colorba;
                            tbdTue1.Foreground = colorcenter;
                            tbdWed1.Foreground = colorcenter;
                            tbdThu1.Foreground = colorcenter;
                            tbdFri1.Foreground = colorcenter;
                            tbdSat1.Foreground = colorcenter;
                            //2                  
                            tbdSun2.Foreground = colorcenter;
                            tbdMon2.Foreground = colorcenter;
                            tbdTue2.Foreground = colorcenter;
                            tbdWed2.Foreground = colorcenter;
                            tbdThu2.Foreground = colorcenter;
                            tbdFri2.Foreground = colorcenter;
                            tbdSat2.Foreground = colorcenter;
                            //3                  
                            tbdSun3.Foreground = colorcenter;
                            tbdMon3.Foreground = colorcenter;
                            tbdTue3.Foreground = colorcenter;
                            tbdWed3.Foreground = colorcenter;
                            tbdThu3.Foreground = colorcenter;
                            tbdFri3.Foreground = colorcenter;
                            tbdSat3.Foreground = colorcenter;
                            //4                 
                            tbdSun4.Foreground = colorcenter;
                            tbdMon4.Foreground = colorcenter;
                            tbdTue4.Foreground = colorcenter;
                            tbdWed4.Foreground = colorcenter;
                            tbdThu4.Foreground = colorcenter;
                            tbdFri4.Foreground = colorcenter;
                            tbdSat4.Foreground = colorcenter;
                            //5                 
                            tbdSun5.Foreground = colorcenter;
                            tbdMon5.Foreground = colorcenter;
                            tbdTue5.Foreground = colorcenter;
                            //color ba
                            tbdWed5.Foreground = colorba;
                            tbdThu5.Foreground = colorba;
                            tbdFri5.Foreground = colorba;
                            tbdSat5.Foreground = colorba;
                            //6     
                            tbdSun6.Foreground = colorba;
                            tbdMon6.Foreground = colorba;
                            tbdTue6.Foreground = colorba;
                            tbdWed6.Foreground = colorba;
                            tbdThu6.Foreground = colorba;
                            tbdFri6.Foreground = colorba;
                            tbdSat6.Foreground = colorba;
                        }
                        else if (totalday == 28)
                        {
                            tbdSun1.Foreground = colorba;
                            tbdMon1.Foreground = colorba;
                            tbdTue1.Foreground = colorcenter;
                            tbdWed1.Foreground = colorcenter;
                            tbdThu1.Foreground = colorcenter;
                            tbdFri1.Foreground = colorcenter;
                            tbdSat1.Foreground = colorcenter;
                            //2                  
                            tbdSun2.Foreground = colorcenter;
                            tbdMon2.Foreground = colorcenter;
                            tbdTue2.Foreground = colorcenter;
                            tbdWed2.Foreground = colorcenter;
                            tbdThu2.Foreground = colorcenter;
                            tbdFri2.Foreground = colorcenter;
                            tbdSat2.Foreground = colorcenter;
                            //3                  
                            tbdSun3.Foreground = colorcenter;
                            tbdMon3.Foreground = colorcenter;
                            tbdTue3.Foreground = colorcenter;
                            tbdWed3.Foreground = colorcenter;
                            tbdThu3.Foreground = colorcenter;
                            tbdFri3.Foreground = colorcenter;
                            tbdSat3.Foreground = colorcenter;
                            //4                 
                            tbdSun4.Foreground = colorcenter;
                            tbdMon4.Foreground = colorcenter;
                            tbdTue4.Foreground = colorcenter;
                            tbdWed4.Foreground = colorcenter;
                            tbdThu4.Foreground = colorcenter;
                            tbdFri4.Foreground = colorcenter;
                            tbdSat4.Foreground = colorcenter;
                            tbdSun5.Foreground = colorcenter;
                            tbdMon5.Foreground = colorcenter;
                            //color ba
                            tbdTue5.Foreground = colorba;
                            tbdWed5.Foreground = colorba;
                            tbdThu5.Foreground = colorba;
                            tbdFri5.Foreground = colorba;
                            tbdSat5.Foreground = colorba;
                            //6     
                            tbdSun6.Foreground = colorba;
                            tbdMon6.Foreground = colorba;
                            tbdTue6.Foreground = colorba;
                            tbdWed6.Foreground = colorba;
                            tbdThu6.Foreground = colorba;
                            tbdFri6.Foreground = colorba;
                            tbdSat6.Foreground = colorba;
                        }
                        break;
                    case "Wednesday":
                        if (totalday == 31)
                        {
                            tbdSun1.Foreground = colorba;
                            tbdMon1.Foreground = colorba;
                            tbdTue1.Foreground = colorba;
                            tbdWed1.Foreground = colorcenter;
                            tbdThu1.Foreground = colorcenter;
                            tbdFri1.Foreground = colorcenter;
                            tbdSat1.Foreground = colorcenter;
                            //2                  
                            tbdSun2.Foreground = colorcenter;
                            tbdMon2.Foreground = colorcenter;
                            tbdTue2.Foreground = colorcenter;
                            tbdWed2.Foreground = colorcenter;
                            tbdThu2.Foreground = colorcenter;
                            tbdFri2.Foreground = colorcenter;
                            tbdSat2.Foreground = colorcenter;
                            //3                  
                            tbdSun3.Foreground = colorcenter;
                            tbdMon3.Foreground = colorcenter;
                            tbdTue3.Foreground = colorcenter;
                            tbdWed3.Foreground = colorcenter;
                            tbdThu3.Foreground = colorcenter;
                            tbdFri3.Foreground = colorcenter;
                            tbdSat3.Foreground = colorcenter;
                            //4                 
                            tbdSun4.Foreground = colorcenter;
                            tbdMon4.Foreground = colorcenter;
                            tbdTue4.Foreground = colorcenter;
                            tbdWed4.Foreground = colorcenter;
                            tbdThu4.Foreground = colorcenter;
                            tbdFri4.Foreground = colorcenter;
                            tbdSat4.Foreground = colorcenter;
                            //5                 
                            tbdSun5.Foreground = colorcenter;
                            tbdMon5.Foreground = colorcenter;
                            tbdTue5.Foreground = colorcenter;
                            tbdWed5.Foreground = colorcenter;
                            tbdThu5.Foreground = colorcenter;
                            tbdFri5.Foreground = colorcenter;
                            //color ba
                            tbdSat5.Foreground = colorba;
                            //6     
                            tbdSun6.Foreground = colorba;
                            tbdMon6.Foreground = colorba;
                            tbdTue6.Foreground = colorba;
                            tbdWed6.Foreground = colorba;
                            tbdThu6.Foreground = colorba;
                            tbdFri6.Foreground = colorba;
                            tbdSat6.Foreground = colorba;


                        }
                        else if (totalday == 30)
                        {
                            tbdSun1.Foreground = colorba;
                            tbdMon1.Foreground = colorba;
                            tbdTue1.Foreground = colorba;
                            tbdWed1.Foreground = colorcenter;
                            tbdThu1.Foreground = colorcenter;
                            tbdFri1.Foreground = colorcenter;
                            tbdSat1.Foreground = colorcenter;
                            //2                  
                            tbdSun2.Foreground = colorcenter;
                            tbdMon2.Foreground = colorcenter;
                            tbdTue2.Foreground = colorcenter;
                            tbdWed2.Foreground = colorcenter;
                            tbdThu2.Foreground = colorcenter;
                            tbdFri2.Foreground = colorcenter;
                            tbdSat2.Foreground = colorcenter;
                            //3                  
                            tbdSun3.Foreground = colorcenter;
                            tbdMon3.Foreground = colorcenter;
                            tbdTue3.Foreground = colorcenter;
                            tbdWed3.Foreground = colorcenter;
                            tbdThu3.Foreground = colorcenter;
                            tbdFri3.Foreground = colorcenter;
                            tbdSat3.Foreground = colorcenter;
                            //4                 
                            tbdSun4.Foreground = colorcenter;
                            tbdMon4.Foreground = colorcenter;
                            tbdTue4.Foreground = colorcenter;
                            tbdWed4.Foreground = colorcenter;
                            tbdThu4.Foreground = colorcenter;
                            tbdFri4.Foreground = colorcenter;
                            tbdSat4.Foreground = colorcenter;
                            //5                 
                            tbdSun5.Foreground = colorcenter;
                            tbdMon5.Foreground = colorcenter;
                            tbdTue5.Foreground = colorcenter;
                            tbdWed5.Foreground = colorcenter;
                            tbdThu5.Foreground = colorcenter;
                            //color ba
                            tbdFri5.Foreground = colorba;
                            tbdSat5.Foreground = colorba;
                            //6     
                            tbdSun6.Foreground = colorba;
                            tbdMon6.Foreground = colorba;
                            tbdTue6.Foreground = colorba;
                            tbdWed6.Foreground = colorba;
                            tbdThu6.Foreground = colorba;
                            tbdFri6.Foreground = colorba;
                            tbdSat6.Foreground = colorba;
                        }
                        else if (totalday == 29)
                        {
                            tbdSun1.Foreground = colorba;
                            tbdMon1.Foreground = colorba;
                            tbdTue1.Foreground = colorba;
                            tbdWed1.Foreground = colorcenter;
                            tbdThu1.Foreground = colorcenter;
                            tbdFri1.Foreground = colorcenter;
                            tbdSat1.Foreground = colorcenter;
                            //2                  
                            tbdSun2.Foreground = colorcenter;
                            tbdMon2.Foreground = colorcenter;
                            tbdTue2.Foreground = colorcenter;
                            tbdWed2.Foreground = colorcenter;
                            tbdThu2.Foreground = colorcenter;
                            tbdFri2.Foreground = colorcenter;
                            tbdSat2.Foreground = colorcenter;
                            //3                  
                            tbdSun3.Foreground = colorcenter;
                            tbdMon3.Foreground = colorcenter;
                            tbdTue3.Foreground = colorcenter;
                            tbdWed3.Foreground = colorcenter;
                            tbdThu3.Foreground = colorcenter;
                            tbdFri3.Foreground = colorcenter;
                            tbdSat3.Foreground = colorcenter;
                            //4                 
                            tbdSun4.Foreground = colorcenter;
                            tbdMon4.Foreground = colorcenter;
                            tbdTue4.Foreground = colorcenter;
                            tbdWed4.Foreground = colorcenter;
                            tbdThu4.Foreground = colorcenter;
                            tbdFri4.Foreground = colorcenter;
                            tbdSat4.Foreground = colorcenter;
                            //5                 
                            tbdSun5.Foreground = colorcenter;
                            tbdMon5.Foreground = colorcenter;
                            tbdTue5.Foreground = colorcenter;
                            tbdWed5.Foreground = colorcenter;
                            //color ba
                            tbdThu5.Foreground = colorba;
                            tbdFri5.Foreground = colorba;
                            tbdSat5.Foreground = colorba;
                            //6     
                            tbdSun6.Foreground = colorba;
                            tbdMon6.Foreground = colorba;
                            tbdTue6.Foreground = colorba;
                            tbdWed6.Foreground = colorba;
                            tbdThu6.Foreground = colorba;
                            tbdFri6.Foreground = colorba;
                            tbdSat6.Foreground = colorba;
                        }
                        else if (totalday == 28)
                        {
                            tbdSun1.Foreground = colorba;
                            tbdMon1.Foreground = colorba;
                            tbdTue1.Foreground = colorba;
                            tbdWed1.Foreground = colorcenter;
                            tbdThu1.Foreground = colorcenter;
                            tbdFri1.Foreground = colorcenter;
                            tbdSat1.Foreground = colorcenter;
                            //2                  
                            tbdSun2.Foreground = colorcenter;
                            tbdMon2.Foreground = colorcenter;
                            tbdTue2.Foreground = colorcenter;
                            tbdWed2.Foreground = colorcenter;
                            tbdThu2.Foreground = colorcenter;
                            tbdFri2.Foreground = colorcenter;
                            tbdSat2.Foreground = colorcenter;
                            //3                  
                            tbdSun3.Foreground = colorcenter;
                            tbdMon3.Foreground = colorcenter;
                            tbdTue3.Foreground = colorcenter;
                            tbdWed3.Foreground = colorcenter;
                            tbdThu3.Foreground = colorcenter;
                            tbdFri3.Foreground = colorcenter;
                            tbdSat3.Foreground = colorcenter;
                            //4                 
                            tbdSun4.Foreground = colorcenter;
                            tbdMon4.Foreground = colorcenter;
                            tbdTue4.Foreground = colorcenter;
                            tbdWed4.Foreground = colorcenter;
                            tbdThu4.Foreground = colorcenter;
                            tbdFri4.Foreground = colorcenter;
                            tbdSat4.Foreground = colorcenter;
                            tbdSun5.Foreground = colorcenter;
                            tbdMon5.Foreground = colorcenter;
                            tbdTue5.Foreground = colorcenter;
                            //color ba
                            tbdWed5.Foreground = colorba;
                            tbdThu5.Foreground = colorba;
                            tbdFri5.Foreground = colorba;
                            tbdSat5.Foreground = colorba;
                            //6     
                            tbdSun6.Foreground = colorba;
                            tbdMon6.Foreground = colorba;
                            tbdTue6.Foreground = colorba;
                            tbdWed6.Foreground = colorba;
                            tbdThu6.Foreground = colorba;
                            tbdFri6.Foreground = colorba;
                            tbdSat6.Foreground = colorba;
                        }
                        break;
                    case "Thursday":
                        if (totalday == 31)
                        {
                            tbdSun1.Foreground = colorba;
                            tbdMon1.Foreground = colorba;
                            tbdTue1.Foreground = colorba;
                            tbdWed1.Foreground = colorba;
                            tbdThu1.Foreground = colorcenter;
                            tbdFri1.Foreground = colorcenter;
                            tbdSat1.Foreground = colorcenter;
                            //2                  
                            tbdSun2.Foreground = colorcenter;
                            tbdMon2.Foreground = colorcenter;
                            tbdTue2.Foreground = colorcenter;
                            tbdWed2.Foreground = colorcenter;
                            tbdThu2.Foreground = colorcenter;
                            tbdFri2.Foreground = colorcenter;
                            tbdSat2.Foreground = colorcenter;
                            //3                  
                            tbdSun3.Foreground = colorcenter;
                            tbdMon3.Foreground = colorcenter;
                            tbdTue3.Foreground = colorcenter;
                            tbdWed3.Foreground = colorcenter;
                            tbdThu3.Foreground = colorcenter;
                            tbdFri3.Foreground = colorcenter;
                            tbdSat3.Foreground = colorcenter;
                            //4                 
                            tbdSun4.Foreground = colorcenter;
                            tbdMon4.Foreground = colorcenter;
                            tbdTue4.Foreground = colorcenter;
                            tbdWed4.Foreground = colorcenter;
                            tbdThu4.Foreground = colorcenter;
                            tbdFri4.Foreground = colorcenter;
                            tbdSat4.Foreground = colorcenter;
                            //5                 
                            tbdSun5.Foreground = colorcenter;
                            tbdMon5.Foreground = colorcenter;
                            tbdTue5.Foreground = colorcenter;
                            tbdWed5.Foreground = colorcenter;
                            tbdThu5.Foreground = colorcenter;
                            tbdFri5.Foreground = colorcenter;
                            tbdSat5.Foreground = colorcenter;
                            //color ba
                            //6     
                            tbdSun6.Foreground = colorba;
                            tbdMon6.Foreground = colorba;
                            tbdTue6.Foreground = colorba;
                            tbdWed6.Foreground = colorba;
                            tbdThu6.Foreground = colorba;
                            tbdFri6.Foreground = colorba;
                            tbdSat6.Foreground = colorba;


                        }
                        else if (totalday == 30)
                        {
                            tbdSun1.Foreground = colorba;
                            tbdMon1.Foreground = colorba;
                            tbdTue1.Foreground = colorba;
                            tbdWed1.Foreground = colorba;
                            tbdThu1.Foreground = colorcenter;
                            tbdFri1.Foreground = colorcenter;
                            tbdSat1.Foreground = colorcenter;
                            //2                  
                            tbdSun2.Foreground = colorcenter;
                            tbdMon2.Foreground = colorcenter;
                            tbdTue2.Foreground = colorcenter;
                            tbdWed2.Foreground = colorcenter;
                            tbdThu2.Foreground = colorcenter;
                            tbdFri2.Foreground = colorcenter;
                            tbdSat2.Foreground = colorcenter;
                            //3                  
                            tbdSun3.Foreground = colorcenter;
                            tbdMon3.Foreground = colorcenter;
                            tbdTue3.Foreground = colorcenter;
                            tbdWed3.Foreground = colorcenter;
                            tbdThu3.Foreground = colorcenter;
                            tbdFri3.Foreground = colorcenter;
                            tbdSat3.Foreground = colorcenter;
                            //4                 
                            tbdSun4.Foreground = colorcenter;
                            tbdMon4.Foreground = colorcenter;
                            tbdTue4.Foreground = colorcenter;
                            tbdWed4.Foreground = colorcenter;
                            tbdThu4.Foreground = colorcenter;
                            tbdFri4.Foreground = colorcenter;
                            tbdSat4.Foreground = colorcenter;
                            //5                 
                            tbdSun5.Foreground = colorcenter;
                            tbdMon5.Foreground = colorcenter;
                            tbdTue5.Foreground = colorcenter;
                            tbdWed5.Foreground = colorcenter;
                            tbdThu5.Foreground = colorcenter;
                            tbdFri5.Foreground = colorcenter;
                            //color ba
                            tbdSat5.Foreground = colorba;
                            //6     
                            tbdSun6.Foreground = colorba;
                            tbdMon6.Foreground = colorba;
                            tbdTue6.Foreground = colorba;
                            tbdWed6.Foreground = colorba;
                            tbdThu6.Foreground = colorba;
                            tbdFri6.Foreground = colorba;
                            tbdSat6.Foreground = colorba;
                        }
                        else if (totalday == 29)
                        {
                            tbdSun1.Foreground = colorba;
                            tbdMon1.Foreground = colorba;
                            tbdTue1.Foreground = colorba;
                            tbdWed1.Foreground = colorba;
                            tbdThu1.Foreground = colorcenter;
                            tbdFri1.Foreground = colorcenter;
                            tbdSat1.Foreground = colorcenter;
                            //2                  
                            tbdSun2.Foreground = colorcenter;
                            tbdMon2.Foreground = colorcenter;
                            tbdTue2.Foreground = colorcenter;
                            tbdWed2.Foreground = colorcenter;
                            tbdThu2.Foreground = colorcenter;
                            tbdFri2.Foreground = colorcenter;
                            tbdSat2.Foreground = colorcenter;
                            //3                  
                            tbdSun3.Foreground = colorcenter;
                            tbdMon3.Foreground = colorcenter;
                            tbdTue3.Foreground = colorcenter;
                            tbdWed3.Foreground = colorcenter;
                            tbdThu3.Foreground = colorcenter;
                            tbdFri3.Foreground = colorcenter;
                            tbdSat3.Foreground = colorcenter;
                            //4                 
                            tbdSun4.Foreground = colorcenter;
                            tbdMon4.Foreground = colorcenter;
                            tbdTue4.Foreground = colorcenter;
                            tbdWed4.Foreground = colorcenter;
                            tbdThu4.Foreground = colorcenter;
                            tbdFri4.Foreground = colorcenter;
                            tbdSat4.Foreground = colorcenter;
                            //5                 
                            tbdSun5.Foreground = colorcenter;
                            tbdMon5.Foreground = colorcenter;
                            tbdTue5.Foreground = colorcenter;
                            tbdWed5.Foreground = colorcenter;
                            tbdThu5.Foreground = colorcenter;
                            //color ba
                            tbdFri5.Foreground = colorba;
                            tbdSat5.Foreground = colorba;
                            //6     
                            tbdSun6.Foreground = colorba;
                            tbdMon6.Foreground = colorba;
                            tbdTue6.Foreground = colorba;
                            tbdWed6.Foreground = colorba;
                            tbdThu6.Foreground = colorba;
                            tbdFri6.Foreground = colorba;
                            tbdSat6.Foreground = colorba;
                        }
                        else if (totalday == 28)
                        {
                            tbdSun1.Foreground = colorba;
                            tbdMon1.Foreground = colorba;
                            tbdTue1.Foreground = colorba;
                            tbdWed1.Foreground = colorba;
                            tbdThu1.Foreground = colorcenter;
                            tbdFri1.Foreground = colorcenter;
                            tbdSat1.Foreground = colorcenter;
                            //2                  
                            tbdSun2.Foreground = colorcenter;
                            tbdMon2.Foreground = colorcenter;
                            tbdTue2.Foreground = colorcenter;
                            tbdWed2.Foreground = colorcenter;
                            tbdThu2.Foreground = colorcenter;
                            tbdFri2.Foreground = colorcenter;
                            tbdSat2.Foreground = colorcenter;
                            //3                  
                            tbdSun3.Foreground = colorcenter;
                            tbdMon3.Foreground = colorcenter;
                            tbdTue3.Foreground = colorcenter;
                            tbdWed3.Foreground = colorcenter;
                            tbdThu3.Foreground = colorcenter;
                            tbdFri3.Foreground = colorcenter;
                            tbdSat3.Foreground = colorcenter;
                            //4                 
                            tbdSun4.Foreground = colorcenter;
                            tbdMon4.Foreground = colorcenter;
                            tbdTue4.Foreground = colorcenter;
                            tbdWed4.Foreground = colorcenter;
                            tbdThu4.Foreground = colorcenter;
                            tbdFri4.Foreground = colorcenter;
                            tbdSat4.Foreground = colorcenter;
                            tbdSun5.Foreground = colorcenter;
                            tbdMon5.Foreground = colorcenter;
                            tbdTue5.Foreground = colorcenter;
                            tbdWed5.Foreground = colorcenter;
                            //color ba
                            tbdThu5.Foreground = colorba;
                            tbdFri5.Foreground = colorba;
                            tbdSat5.Foreground = colorba;
                            //6     
                            tbdSun6.Foreground = colorba;
                            tbdMon6.Foreground = colorba;
                            tbdTue6.Foreground = colorba;
                            tbdWed6.Foreground = colorba;
                            tbdThu6.Foreground = colorba;
                            tbdFri6.Foreground = colorba;
                            tbdSat6.Foreground = colorba;
                        }
                        break;
                    case "Friday":
                        if (totalday == 31)
                        {
                            tbdSun1.Foreground = colorba;
                            tbdMon1.Foreground = colorba;
                            tbdTue1.Foreground = colorba;
                            tbdWed1.Foreground = colorba;
                            tbdThu1.Foreground = colorba;
                            tbdFri1.Foreground = colorcenter;
                            tbdSat1.Foreground = colorcenter;
                            //2                  
                            tbdSun2.Foreground = colorcenter;
                            tbdMon2.Foreground = colorcenter;
                            tbdTue2.Foreground = colorcenter;
                            tbdWed2.Foreground = colorcenter;
                            tbdThu2.Foreground = colorcenter;
                            tbdFri2.Foreground = colorcenter;
                            tbdSat2.Foreground = colorcenter;
                            //3                  
                            tbdSun3.Foreground = colorcenter;
                            tbdMon3.Foreground = colorcenter;
                            tbdTue3.Foreground = colorcenter;
                            tbdWed3.Foreground = colorcenter;
                            tbdThu3.Foreground = colorcenter;
                            tbdFri3.Foreground = colorcenter;
                            tbdSat3.Foreground = colorcenter;
                            //4                 
                            tbdSun4.Foreground = colorcenter;
                            tbdMon4.Foreground = colorcenter;
                            tbdTue4.Foreground = colorcenter;
                            tbdWed4.Foreground = colorcenter;
                            tbdThu4.Foreground = colorcenter;
                            tbdFri4.Foreground = colorcenter;
                            tbdSat4.Foreground = colorcenter;
                            //5                 
                            tbdSun5.Foreground = colorcenter;
                            tbdMon5.Foreground = colorcenter;
                            tbdTue5.Foreground = colorcenter;
                            tbdWed5.Foreground = colorcenter;
                            tbdThu5.Foreground = colorcenter;
                            tbdFri5.Foreground = colorcenter;
                            tbdSat5.Foreground = colorcenter;
                            tbdSun6.Foreground = colorcenter;
                            //color ba
                            //6     
                            tbdMon6.Foreground = colorba;
                            tbdTue6.Foreground = colorba;
                            tbdWed6.Foreground = colorba;
                            tbdThu6.Foreground = colorba;
                            tbdFri6.Foreground = colorba;
                            tbdSat6.Foreground = colorba;


                        }
                        else if (totalday == 30)
                        {
                            tbdSun1.Foreground = colorba;
                            tbdMon1.Foreground = colorba;
                            tbdTue1.Foreground = colorba;
                            tbdWed1.Foreground = colorba;
                            tbdThu1.Foreground = colorba;
                            tbdFri1.Foreground = colorcenter;
                            tbdSat1.Foreground = colorcenter;
                            //2                  
                            tbdSun2.Foreground = colorcenter;
                            tbdMon2.Foreground = colorcenter;
                            tbdTue2.Foreground = colorcenter;
                            tbdWed2.Foreground = colorcenter;
                            tbdThu2.Foreground = colorcenter;
                            tbdFri2.Foreground = colorcenter;
                            tbdSat2.Foreground = colorcenter;
                            //3                  
                            tbdSun3.Foreground = colorcenter;
                            tbdMon3.Foreground = colorcenter;
                            tbdTue3.Foreground = colorcenter;
                            tbdWed3.Foreground = colorcenter;
                            tbdThu3.Foreground = colorcenter;
                            tbdFri3.Foreground = colorcenter;
                            tbdSat3.Foreground = colorcenter;
                            //4                 
                            tbdSun4.Foreground = colorcenter;
                            tbdMon4.Foreground = colorcenter;
                            tbdTue4.Foreground = colorcenter;
                            tbdWed4.Foreground = colorcenter;
                            tbdThu4.Foreground = colorcenter;
                            tbdFri4.Foreground = colorcenter;
                            tbdSat4.Foreground = colorcenter;
                            //5                 
                            tbdSun5.Foreground = colorcenter;
                            tbdMon5.Foreground = colorcenter;
                            tbdTue5.Foreground = colorcenter;
                            tbdWed5.Foreground = colorcenter;
                            tbdThu5.Foreground = colorcenter;
                            tbdFri5.Foreground = colorcenter;
                            tbdSat5.Foreground = colorcenter;
                            //color ba
                            //6     
                            tbdSun6.Foreground = colorba;
                            tbdMon6.Foreground = colorba;
                            tbdTue6.Foreground = colorba;
                            tbdWed6.Foreground = colorba;
                            tbdThu6.Foreground = colorba;
                            tbdFri6.Foreground = colorba;
                            tbdSat6.Foreground = colorba;
                        }
                        else if (totalday == 29)
                        {
                            tbdSun1.Foreground = colorba;
                            tbdMon1.Foreground = colorba;
                            tbdTue1.Foreground = colorba;
                            tbdWed1.Foreground = colorba;
                            tbdThu1.Foreground = colorba;
                            tbdFri1.Foreground = colorcenter;
                            tbdSat1.Foreground = colorcenter;
                            //2                  
                            tbdSun2.Foreground = colorcenter;
                            tbdMon2.Foreground = colorcenter;
                            tbdTue2.Foreground = colorcenter;
                            tbdWed2.Foreground = colorcenter;
                            tbdThu2.Foreground = colorcenter;
                            tbdFri2.Foreground = colorcenter;
                            tbdSat2.Foreground = colorcenter;
                            //3                  
                            tbdSun3.Foreground = colorcenter;
                            tbdMon3.Foreground = colorcenter;
                            tbdTue3.Foreground = colorcenter;
                            tbdWed3.Foreground = colorcenter;
                            tbdThu3.Foreground = colorcenter;
                            tbdFri3.Foreground = colorcenter;
                            tbdSat3.Foreground = colorcenter;
                            //4                 
                            tbdSun4.Foreground = colorcenter;
                            tbdMon4.Foreground = colorcenter;
                            tbdTue4.Foreground = colorcenter;
                            tbdWed4.Foreground = colorcenter;
                            tbdThu4.Foreground = colorcenter;
                            tbdFri4.Foreground = colorcenter;
                            tbdSat4.Foreground = colorcenter;
                            //5                 
                            tbdSun5.Foreground = colorcenter;
                            tbdMon5.Foreground = colorcenter;
                            tbdTue5.Foreground = colorcenter;
                            tbdWed5.Foreground = colorcenter;
                            tbdThu5.Foreground = colorcenter;
                            tbdFri5.Foreground = colorcenter;
                            //color ba
                            tbdSat5.Foreground = colorba;
                            //6     
                            tbdSun6.Foreground = colorba;
                            tbdMon6.Foreground = colorba;
                            tbdTue6.Foreground = colorba;
                            tbdWed6.Foreground = colorba;
                            tbdThu6.Foreground = colorba;
                            tbdFri6.Foreground = colorba;
                            tbdSat6.Foreground = colorba;
                        }
                        else if (totalday == 28)
                        {
                            tbdSun1.Foreground = colorba;
                            tbdMon1.Foreground = colorba;
                            tbdTue1.Foreground = colorba;
                            tbdWed1.Foreground = colorba;
                            tbdThu1.Foreground = colorba;
                            tbdFri1.Foreground = colorcenter;
                            tbdSat1.Foreground = colorcenter;
                            //2                  
                            tbdSun2.Foreground = colorcenter;
                            tbdMon2.Foreground = colorcenter;
                            tbdTue2.Foreground = colorcenter;
                            tbdWed2.Foreground = colorcenter;
                            tbdThu2.Foreground = colorcenter;
                            tbdFri2.Foreground = colorcenter;
                            tbdSat2.Foreground = colorcenter;
                            //3                  
                            tbdSun3.Foreground = colorcenter;
                            tbdMon3.Foreground = colorcenter;
                            tbdTue3.Foreground = colorcenter;
                            tbdWed3.Foreground = colorcenter;
                            tbdThu3.Foreground = colorcenter;
                            tbdFri3.Foreground = colorcenter;
                            tbdSat3.Foreground = colorcenter;
                            //4                 
                            tbdSun4.Foreground = colorcenter;
                            tbdMon4.Foreground = colorcenter;
                            tbdTue4.Foreground = colorcenter;
                            tbdWed4.Foreground = colorcenter;
                            tbdThu4.Foreground = colorcenter;
                            tbdFri4.Foreground = colorcenter;
                            tbdSat4.Foreground = colorcenter;
                            tbdSun5.Foreground = colorcenter;
                            tbdMon5.Foreground = colorcenter;
                            tbdTue5.Foreground = colorcenter;
                            tbdWed5.Foreground = colorcenter;
                            tbdThu5.Foreground = colorcenter;
                            //color ba
                            tbdFri5.Foreground = colorba;
                            tbdSat5.Foreground = colorba;
                            //6     
                            tbdSun6.Foreground = colorba;
                            tbdMon6.Foreground = colorba;
                            tbdTue6.Foreground = colorba;
                            tbdWed6.Foreground = colorba;
                            tbdThu6.Foreground = colorba;
                            tbdFri6.Foreground = colorba;
                            tbdSat6.Foreground = colorba;
                        }
                        break;
                    case "Saturday":
                        if (totalday == 31)
                        {
                            tbdSun1.Foreground = colorba;
                            tbdMon1.Foreground = colorba;
                            tbdTue1.Foreground = colorba;
                            tbdWed1.Foreground = colorba;
                            tbdThu1.Foreground = colorba;
                            tbdFri1.Foreground = colorba;
                            tbdSat1.Foreground = colorcenter;
                            //2                  
                            tbdSun2.Foreground = colorcenter;
                            tbdMon2.Foreground = colorcenter;
                            tbdTue2.Foreground = colorcenter;
                            tbdWed2.Foreground = colorcenter;
                            tbdThu2.Foreground = colorcenter;
                            tbdFri2.Foreground = colorcenter;
                            tbdSat2.Foreground = colorcenter;
                            //3                  
                            tbdSun3.Foreground = colorcenter;
                            tbdMon3.Foreground = colorcenter;
                            tbdTue3.Foreground = colorcenter;
                            tbdWed3.Foreground = colorcenter;
                            tbdThu3.Foreground = colorcenter;
                            tbdFri3.Foreground = colorcenter;
                            tbdSat3.Foreground = colorcenter;
                            //4                 
                            tbdSun4.Foreground = colorcenter;
                            tbdMon4.Foreground = colorcenter;
                            tbdTue4.Foreground = colorcenter;
                            tbdWed4.Foreground = colorcenter;
                            tbdThu4.Foreground = colorcenter;
                            tbdFri4.Foreground = colorcenter;
                            tbdSat4.Foreground = colorcenter;
                            //5                 
                            tbdSun5.Foreground = colorcenter;
                            tbdMon5.Foreground = colorcenter;
                            tbdTue5.Foreground = colorcenter;
                            tbdWed5.Foreground = colorcenter;
                            tbdThu5.Foreground = colorcenter;
                            tbdFri5.Foreground = colorcenter;
                            tbdSat5.Foreground = colorcenter;
                            tbdSun6.Foreground = colorcenter;
                            tbdMon6.Foreground = colorcenter;
                            //color ba
                            //6     
                            tbdTue6.Foreground = colorba;
                            tbdWed6.Foreground = colorba;
                            tbdThu6.Foreground = colorba;
                            tbdFri6.Foreground = colorba;
                            tbdSat6.Foreground = colorba;


                        }
                        else if (totalday == 30)
                        {
                            tbdSun1.Foreground = colorba;
                            tbdMon1.Foreground = colorba;
                            tbdTue1.Foreground = colorba;
                            tbdWed1.Foreground = colorba;
                            tbdThu1.Foreground = colorba;
                            tbdFri1.Foreground = colorba;
                            tbdSat1.Foreground = colorcenter;
                            //2                  
                            tbdSun2.Foreground = colorcenter;
                            tbdMon2.Foreground = colorcenter;
                            tbdTue2.Foreground = colorcenter;
                            tbdWed2.Foreground = colorcenter;
                            tbdThu2.Foreground = colorcenter;
                            tbdFri2.Foreground = colorcenter;
                            tbdSat2.Foreground = colorcenter;
                            //3                  
                            tbdSun3.Foreground = colorcenter;
                            tbdMon3.Foreground = colorcenter;
                            tbdTue3.Foreground = colorcenter;
                            tbdWed3.Foreground = colorcenter;
                            tbdThu3.Foreground = colorcenter;
                            tbdFri3.Foreground = colorcenter;
                            tbdSat3.Foreground = colorcenter;
                            //4                 
                            tbdSun4.Foreground = colorcenter;
                            tbdMon4.Foreground = colorcenter;
                            tbdTue4.Foreground = colorcenter;
                            tbdWed4.Foreground = colorcenter;
                            tbdThu4.Foreground = colorcenter;
                            tbdFri4.Foreground = colorcenter;
                            tbdSat4.Foreground = colorcenter;
                            //5                 
                            tbdSun5.Foreground = colorcenter;
                            tbdMon5.Foreground = colorcenter;
                            tbdTue5.Foreground = colorcenter;
                            tbdWed5.Foreground = colorcenter;
                            tbdThu5.Foreground = colorcenter;
                            tbdFri5.Foreground = colorcenter;
                            tbdSat5.Foreground = colorcenter;
                            tbdSun6.Foreground = colorcenter;
                            //color ba
                            //6     
                            tbdMon6.Foreground = colorba;
                            tbdTue6.Foreground = colorba;
                            tbdWed6.Foreground = colorba;
                            tbdThu6.Foreground = colorba;
                            tbdFri6.Foreground = colorba;
                            tbdSat6.Foreground = colorba;
                        }
                        else if (totalday == 29)
                        {
                            tbdSun1.Foreground = colorba;
                            tbdMon1.Foreground = colorba;
                            tbdTue1.Foreground = colorba;
                            tbdWed1.Foreground = colorba;
                            tbdThu1.Foreground = colorba;
                            tbdFri1.Foreground = colorba;
                            tbdSat1.Foreground = colorcenter;
                            //2                  
                            tbdSun2.Foreground = colorcenter;
                            tbdMon2.Foreground = colorcenter;
                            tbdTue2.Foreground = colorcenter;
                            tbdWed2.Foreground = colorcenter;
                            tbdThu2.Foreground = colorcenter;
                            tbdFri2.Foreground = colorcenter;
                            tbdSat2.Foreground = colorcenter;
                            //3                  
                            tbdSun3.Foreground = colorcenter;
                            tbdMon3.Foreground = colorcenter;
                            tbdTue3.Foreground = colorcenter;
                            tbdWed3.Foreground = colorcenter;
                            tbdThu3.Foreground = colorcenter;
                            tbdFri3.Foreground = colorcenter;
                            tbdSat3.Foreground = colorcenter;
                            //4                 
                            tbdSun4.Foreground = colorcenter;
                            tbdMon4.Foreground = colorcenter;
                            tbdTue4.Foreground = colorcenter;
                            tbdWed4.Foreground = colorcenter;
                            tbdThu4.Foreground = colorcenter;
                            tbdFri4.Foreground = colorcenter;
                            tbdSat4.Foreground = colorcenter;
                            //5                 
                            tbdSun5.Foreground = colorcenter;
                            tbdMon5.Foreground = colorcenter;
                            tbdTue5.Foreground = colorcenter;
                            tbdWed5.Foreground = colorcenter;
                            tbdThu5.Foreground = colorcenter;
                            tbdFri5.Foreground = colorcenter;
                            tbdSat5.Foreground = colorcenter;
                            //color ba
                            //6     
                            tbdMon6.Foreground = colorba;
                            tbdTue6.Foreground = colorba;
                            tbdWed6.Foreground = colorba;
                            tbdThu6.Foreground = colorba;
                            tbdFri6.Foreground = colorba;
                            tbdSat6.Foreground = colorba;
                        }
                        else if (totalday == 28)
                        {
                            tbdSun1.Foreground = colorba;
                            tbdMon1.Foreground = colorba;
                            tbdTue1.Foreground = colorba;
                            tbdWed1.Foreground = colorba;
                            tbdThu1.Foreground = colorba;
                            tbdFri1.Foreground = colorba;
                            tbdSat1.Foreground = colorcenter;
                            //2                  
                            tbdSun2.Foreground = colorcenter;
                            tbdMon2.Foreground = colorcenter;
                            tbdTue2.Foreground = colorcenter;
                            tbdWed2.Foreground = colorcenter;
                            tbdThu2.Foreground = colorcenter;
                            tbdFri2.Foreground = colorcenter;
                            tbdSat2.Foreground = colorcenter;
                            //3                  
                            tbdSun3.Foreground = colorcenter;
                            tbdMon3.Foreground = colorcenter;
                            tbdTue3.Foreground = colorcenter;
                            tbdWed3.Foreground = colorcenter;
                            tbdThu3.Foreground = colorcenter;
                            tbdFri3.Foreground = colorcenter;
                            tbdSat3.Foreground = colorcenter;
                            //4                 
                            tbdSun4.Foreground = colorcenter;
                            tbdMon4.Foreground = colorcenter;
                            tbdTue4.Foreground = colorcenter;
                            tbdWed4.Foreground = colorcenter;
                            tbdThu4.Foreground = colorcenter;
                            tbdFri4.Foreground = colorcenter;
                            tbdSat4.Foreground = colorcenter;
                            tbdSun5.Foreground = colorcenter;
                            tbdMon5.Foreground = colorcenter;
                            tbdTue5.Foreground = colorcenter;
                            tbdWed5.Foreground = colorcenter;
                            tbdThu5.Foreground = colorcenter;
                            tbdFri5.Foreground = colorcenter;
                            //color ba
                            tbdSat5.Foreground = colorba;
                            //6     
                            tbdSun6.Foreground = colorba;
                            tbdMon6.Foreground = colorba;
                            tbdTue6.Foreground = colorba;
                            tbdWed6.Foreground = colorba;
                            tbdThu6.Foreground = colorba;
                            tbdFri6.Foreground = colorba;
                            tbdSat6.Foreground = colorba;
                        }
                        break;
                }
            }
        }

        private void btnToday_Click(object sender, RoutedEventArgs e)
        {
            DateTime nextm = new DateTime(nownp.Year, nownp.Month, nownp.Day);
            tbMonthCal.Text = nextm.ToString("MMMM", CultureInfo.CurrentCulture.NumberFormat);
            tbYearCal.Text = nownp.Year.ToString();
            nextprem(tbMonthCal.Text, tbYearCal.Text);
            i = 0;
            j = 0;
            CalMain();
            showEvent.Visibility = Visibility.Collapsed;
        }


        private void btnEvent_Click(object sender, RoutedEventArgs e)
        {
            NavEvent.Visibility = Visibility.Visible;
            cbbMonthDay();
            Hour();
            cbbMonthDay1();
            Hour1();
            tbNameEvent.Text = "";
            txtDes.Text = "";
        }

        private void btnBackEvent_Click(object sender, RoutedEventArgs e)
        {
            NavEvent.Visibility = Visibility.Collapsed;
        }
        //Start
        private void cbbMonthDay()
        {
            List<MonthDay> listMonthD = new List<MonthDay>() {
                new MonthDay() { Month="January" },
                new MonthDay() { Month="February" },
                new MonthDay() { Month="March" },
                new MonthDay() { Month="April" },
                new MonthDay() { Month="May" },
                new MonthDay() { Month="June" },
                new MonthDay() { Month="July" },
                new MonthDay() { Month="August" },
                new MonthDay() { Month="September" },
                new MonthDay() { Month="October" },
                new MonthDay() { Month="November" },
                new MonthDay() { Month="December" }
            };
            cbbmonthStart.ItemsSource = listMonthD;
            DateTime nextm = new DateTime(nownp.Year, nownp.Month, nownp.Day);
            string month = nextm.ToString("MMMM", CultureInfo.CurrentCulture.NumberFormat);
            MonthDay md = listMonthD.Find(x => x.Month.Equals(month));
            cbbmonthStart.SelectedIndex = (md.Month == "January") ? 0 : (md.Month == "February")
                                        ? 1 : (md.Month == "March") ? 2 : (md.Month == "April") ? 3 : (md.Month == "May") ? 4 :
                                        (md.Month == "June") ? 5 : (md.Month == "July") ? 6 : (md.Month == "August") ? 7 :
                                        (md.Month == "September") ? 8 : (md.Month == "October") ? 9 : (md.Month == "November") ? 10 :
                                        (md.Month == "December") ? 11 : -1;
            int daytotal = DateTime.DaysInMonth(nownp.Year, nownp.Month);
            List<MonthDay> listD = new List<MonthDay>();
            MonthDay mdd = new MonthDay();
            for (int i = 1; i <= daytotal; i++)
            {
                listD.Add(new MonthDay() { Day = i.ToString() });

            }
            cbbdayStart.ItemsSource = listD;
            foreach (MonthDay item in listD)
            {
                if (item.Day == nownp.Day.ToString()) { cbbdayStart.SelectedIndex = nownp.Day - 1; }
            }
            tbStart.Text = nownp.Day.ToString() + " " + month + " " + nownp.Year;
            cbbmonthStart.DropDownClosed += CbbmonthStart_DropDownClosed;
            cbbdayStart.DropDownClosed += CbbdayStart_DropDownClosed;
            cbbHour.DropDownClosed += CbbHour_DropDownClosed;
            cbbAMPM.DropDownClosed += CbbAMPM_DropDownClosed;
        }

        private void CbbAMPM_DropDownClosed(object sender, object e)
        {
            tbTimeStart.Text = cbbHour.SelectedValue.ToString() + " " + cbbAMPM.SelectedValue.ToString();
        }

        private void CbbHour_DropDownClosed(object sender, object e)
        {
            tbTimeStart.Text = cbbHour.SelectedValue.ToString() + " " + cbbAMPM.SelectedValue.ToString();
        }

        private void CbbmonthStart_DropDownClosed(object sender, object e)
        {
            string ddd = (cbbmonthStart.SelectedItem as MonthDay).Month;
            int month = (ddd == "January") ? 1 : (ddd == "February") ? 2 : (ddd == "March") ? 3 :
            (ddd == "April") ? 4 : (ddd == "May") ? 5 : (ddd == "June") ? 6 :
            (ddd == "July") ? 7 : (ddd == "August") ? 8 : (ddd == "September") ? 9 :
            (ddd == "October") ? 10 : (ddd == "November") ? 11 : (ddd == "December") ? 12 : -1;
            if (month != -1)
            {

                int daytotal = DateTime.DaysInMonth(nownp.Year, month);
                List<MonthDay> listD = new List<MonthDay>();
                MonthDay mdd = new MonthDay();
                for (int i = 1; i <= daytotal; i++)
                {
                    listD.Add(new MonthDay() { Day = i.ToString() });

                }
                cbbdayStart.ItemsSource = listD;

            }

        }

        private void CbbdayStart_DropDownClosed(object sender, object e)
        {
            tbStart.Text = (cbbdayStart.SelectedItem as MonthDay).Day + " " +
               (cbbmonthStart.SelectedItem as MonthDay).Month + " " + nownp.Year;
        }

        private void Hour()
        {
            DateTime time = DateTime.Now;
            int a = time.Hour;
            cbbHour.SelectedIndex = (a == 0 || a == 12) ? 11 : (a == 1 || a == 13) ? 0 : (a == 2 || a == 14) ? 1 :
                                    (a == 3 || a == 15) ? 2 : (a == 4 || a == 16) ? 3 : (a == 5 || a == 17) ? 4 : (a == 6 || a == 18) ? 5 :
                                     (a == 7 || a == 19) ? 6 : (a == 8 || a == 20) ? 7 : (a == 9 || a == 21) ? 8 : (a == 10 || a == 22) ? 9 :
                                     (a == 11 || a == 23) ? 10 : (a == 12 || a == 24) ? 11 : -1;

            string ampm = time.ToString("tt", CultureInfo.CurrentCulture.NumberFormat);
            cbbAMPM.SelectedIndex = (ampm == "AM") ? 0 : (ampm == "PM") ? 1 : -1;

            tbTimeStart.Text = cbbHour.SelectedValue.ToString() + " " + cbbAMPM.SelectedValue.ToString();
        }

        //End 
        private void cbbMonthDay1()
        {
            List<MonthDay> listMonthD = new List<MonthDay>() {
                new MonthDay() { Month="January" },
                new MonthDay() { Month="February" },
                new MonthDay() { Month="March" },
                new MonthDay() { Month="April" },
                new MonthDay() { Month="May" },
                new MonthDay() { Month="June" },
                new MonthDay() { Month="July" },
                new MonthDay() { Month="August" },
                new MonthDay() { Month="September" },
                new MonthDay() { Month="October" },
                new MonthDay() { Month="November" },
                new MonthDay() { Month="December" }
            };
            cbbmonthStart1.ItemsSource = listMonthD;
            DateTime nextm = new DateTime(nownp.Year, nownp.Month, nownp.Day);
            string month = nextm.ToString("MMMM", CultureInfo.CurrentCulture.NumberFormat);
            MonthDay md = listMonthD.Find(x => x.Month.Equals(month));
            cbbmonthStart1.SelectedIndex = (md.Month == "January") ? 0 : (md.Month == "February")
                                        ? 1 : (md.Month == "March") ? 2 : (md.Month == "April") ? 3 : (md.Month == "May") ? 4 :
                                        (md.Month == "June") ? 5 : (md.Month == "July") ? 6 : (md.Month == "August") ? 7 :
                                        (md.Month == "September") ? 8 : (md.Month == "October") ? 9 : (md.Month == "November") ? 10 :
                                        (md.Month == "December") ? 11 : -1;
            int daytotal = DateTime.DaysInMonth(nownp.Year, nownp.Month);
            List<MonthDay> listD = new List<MonthDay>();
            MonthDay mdd = new MonthDay();
            for (int i = 1; i <= daytotal; i++)
            {
                listD.Add(new MonthDay() { Day = i.ToString() });

            }
            cbbdayStart1.ItemsSource = listD;
            foreach (MonthDay item in listD)
            {
                if (item.Day == nownp.Day.ToString()) { cbbdayStart1.SelectedIndex = nownp.Day - 1; }
            }
            tbEnd.Text = nownp.Day.ToString() + " " + month + " " + nownp.Year;
            cbbmonthStart1.DropDownClosed += CbbmonthStart1_DropDownClosed;
            cbbdayStart1.DropDownClosed += CbbdayStart1_DropDownClosed;
            cbbHour1.DropDownClosed += CbbHour1_DropDownClosed;
            cbbAMPM1.DropDownClosed += CbbAMPM1_DropDownClosed;
        }

        private void CbbAMPM1_DropDownClosed(object sender, object e)
        {
            tbTimeEnd.Text = cbbHour1.SelectedValue.ToString() + " " + cbbAMPM1.SelectedValue.ToString();
        }

        private void CbbHour1_DropDownClosed(object sender, object e)
        {
            tbTimeEnd.Text = cbbHour1.SelectedValue.ToString() + " " + cbbAMPM1.SelectedValue.ToString();
        }

        private void CbbdayStart1_DropDownClosed(object sender, object e)
        {
            tbEnd.Text = (cbbdayStart1.SelectedItem as MonthDay).Day + " " +
              (cbbmonthStart1.SelectedItem as MonthDay).Month + " " + nownp.Year;
        }

        private void CbbmonthStart1_DropDownClosed(object sender, object e)
        {
            string ddd = (cbbmonthStart1.SelectedItem as MonthDay).Month;
            int month = (ddd == "January") ? 1 : (ddd == "February") ? 2 : (ddd == "March") ? 3 :
            (ddd == "April") ? 4 : (ddd == "May") ? 5 : (ddd == "June") ? 6 :
            (ddd == "July") ? 7 : (ddd == "August") ? 8 : (ddd == "September") ? 9 :
            (ddd == "October") ? 10 : (ddd == "November") ? 11 : (ddd == "December") ? 12 : -1;
            if (month != -1)
            {

                int daytotal = DateTime.DaysInMonth(nownp.Year, month);
                List<MonthDay> listD = new List<MonthDay>();
                MonthDay mdd = new MonthDay();
                for (int i = 1; i <= daytotal; i++)
                {
                    listD.Add(new MonthDay() { Day = i.ToString() });

                }
                cbbdayStart1.ItemsSource = listD;

            }
        }

        private void Hour1()
        {
            DateTime time = DateTime.Now;
            int a = time.Hour;
            cbbHour1.SelectedIndex = (a == 0 || a == 12) ? 11 : (a == 1 || a == 13) ? 0 : (a == 2 || a == 14) ? 1 :
                                    (a == 3 || a == 15) ? 2 : (a == 4 || a == 16) ? 3 : (a == 5 || a == 17) ? 4 : (a == 6 || a == 18) ? 5 :
                                     (a == 7 || a == 19) ? 6 : (a == 8 || a == 20) ? 7 : (a == 9 || a == 21) ? 8 : (a == 10 || a == 22) ? 9 :
                                     (a == 11 || a == 23) ? 10 : (a == 12 || a == 24) ? 11 : -1;

            string ampm = time.ToString("tt", CultureInfo.CurrentCulture.NumberFormat);
            cbbAMPM1.SelectedIndex = (ampm == "AM") ? 0 : (ampm == "PM") ? 1 : -1;

            tbTimeEnd.Text = cbbHour1.SelectedValue.ToString() + " " + cbbAMPM1.SelectedValue.ToString();
        }


        public class MonthDay
        {
            public string Month { get; set; }
            public string Day { get; set; }
        }

        //Write Event output file json
        private const string JSONFILENAME = "event.json";

        private async void btnSaveClose_Click(object sender, RoutedEventArgs e)
        {

            string des = txtDes.Text;
            if (des.Length != 0 && tbNameEvent.Text.Length != 0)
            {
                string str = tbStart.Text + " " + tbTimeStart.Text + " " + tbEnd.Text + " " + tbTimeEnd.Text;

                List<string> lstStr = SplitSpace(str);


                //Write event to json

                List<Event> myEvent = new List<Event>();

                myEvent.Add(new Event()
                {
                    NameEvent = tbNameEvent.Text,
                    DayS = lstStr[0],
                    MonthS = lstStr[1],
                    YearS = lstStr[2],
                    HourS = lstStr[3],
                    AMPMS = lstStr[4],
                    DayE = lstStr[5],
                    MonthE = lstStr[6],
                    YearE = lstStr[7],
                    HourE = lstStr[8],
                    AMPME = lstStr[9],
                    Description = des
                });

                string content = String.Empty;
                await ApplicationData.Current.LocalFolder.CreateFileAsync(JSONFILENAME, CreationCollisionOption.OpenIfExists);
                var myStream = await ApplicationData.Current.LocalFolder.OpenStreamForReadAsync(JSONFILENAME);
                using (StreamReader reader = new StreamReader(myStream))
                {
                    content = await reader.ReadToEndAsync();
                    if (content.Length != 0)
                    {
                        DataContractJsonSerializer seri = new DataContractJsonSerializer(typeof(List<Event>));
                        MemoryStream ms = new MemoryStream(Encoding.UTF8.GetBytes(content));

                        List<Event> evet = (List<Event>)seri.ReadObject(ms);
                        myEvent.AddRange(evet);
                        await ms.FlushAsync();
                    }

                }
                //write
                var serializer = new DataContractJsonSerializer(typeof(List<Event>));
                using (var stream = await ApplicationData.Current.LocalFolder.OpenStreamForWriteAsync(
                    JSONFILENAME,
                    CreationCollisionOption.ReplaceExisting))
                {
                    serializer.WriteObject(stream, myEvent);
                }
                //
                NavEvent.Visibility = Visibility.Collapsed;
                //Animation Success
                gStatus.Visibility = Visibility.Visible;
                myStatus.Begin();
                //load grid view
                Events = await EventManager.GetEvent();
                gridvEvents.ItemsSource = Events;
            }
            else
            {
                await new MessageDialog("Not Empty").ShowAsync();
            }

           
        }

        //Slipt " "
        private List<string> SplitSpace(string str)
        {
            List<string> list = new List<string>(); ;
            var array = str.Split(new[] { " " }, StringSplitOptions.RemoveEmptyEntries);
            foreach (var item in array)
            {
                list.Add(item);
            }
            return list;
        }

        //Show Main Day
        private void CalMain()
        {
            DateTime datenow = DateTime.Now;
            int mday = datenow.Day;
            string mdayofw = datenow.DayOfWeek.ToString();
            //
            CalendarMain cMain = new CalendarMain();

            //
            switch (mdayofw)
            {
                case "Sunday":
                    cMain.Day1 = mday.ToString();
                    cMain.Day2 = mdayofweek(1);
                    cMain.Day3 = mdayofweek(2);
                    cMain.Day4 = mdayofweek(3);
                    cMain.Day5 = mdayofweek(4);
                    cMain.Day6 = mdayofweek(5);
                    cMain.Day7 = mdayofweek(6);
                    borDay1.BorderThickness = new Thickness(0, 3, 0, 0);
                    break;
                case "Monday":
                    cMain.Day2 = mday.ToString();
                    cMain.Day1 = mdayofweek(-1);
                    cMain.Day3 = mdayofweek(1);
                    cMain.Day4 = mdayofweek(2);
                    cMain.Day5 = mdayofweek(3);
                    cMain.Day6 = mdayofweek(4);
                    cMain.Day7 = mdayofweek(5);
                    borDay2.BorderThickness = new Thickness(0, 3, 0, 0);
                    break;
                case "Tuesday":
                    cMain.Day3 = mday.ToString();
                    cMain.Day1 = mdayofweek(-2);
                    cMain.Day2 = mdayofweek(-1);
                    cMain.Day4 = mdayofweek(1);
                    cMain.Day5 = mdayofweek(2);
                    cMain.Day6 = mdayofweek(3);
                    cMain.Day7 = mdayofweek(4);
                    borDay3.BorderThickness = new Thickness(0, 3, 0, 0);
                    break;
                case "Wednesday":
                    cMain.Day4 = mday.ToString();
                    cMain.Day1 = mdayofweek(-3);
                    cMain.Day2 = mdayofweek(-2);
                    cMain.Day3 = mdayofweek(-1);
                    cMain.Day5 = mdayofweek(1);
                    cMain.Day6 = mdayofweek(2);
                    cMain.Day7 = mdayofweek(3);
                    borDay4.BorderThickness = new Thickness(0, 3, 0, 0);
                    break;
                case "Thursday":
                    cMain.Day5 = mday.ToString();
                    cMain.Day1 = mdayofweek(-4);
                    cMain.Day2 = mdayofweek(-3);
                    cMain.Day3 = mdayofweek(-2);
                    cMain.Day4 = mdayofweek(-1);
                    cMain.Day6 = mdayofweek(1);
                    cMain.Day7 = mdayofweek(2);
                    borDay5.BorderThickness = new Thickness(0, 3, 0, 0);
                    break;
                case "Friday":
                    cMain.Day6 = mday.ToString();
                    cMain.Day1 = mdayofweek(-5);
                    cMain.Day2 = mdayofweek(-4);
                    cMain.Day3 = mdayofweek(-3);
                    cMain.Day4 = mdayofweek(-2);
                    cMain.Day5 = mdayofweek(-1);
                    cMain.Day7 = mdayofweek(1);
                    borDay6.BorderThickness = new Thickness(0, 3, 0, 0);
                    break;
                case "Saturday":
                    cMain.Day7 = mday.ToString();
                    cMain.Day1 = mdayofweek(-6);
                    cMain.Day2 = mdayofweek(-5);
                    cMain.Day3 = mdayofweek(-4);
                    cMain.Day4 = mdayofweek(-3);
                    cMain.Day5 = mdayofweek(-2);
                    cMain.Day6 = mdayofweek(-1);
                    borDay7.BorderThickness = new Thickness(0, 3, 0, 0);
                    break;

            }
            tbcDay1.DataContext = cMain;
            tbcDay2.DataContext = cMain;
            tbcDay3.DataContext = cMain;
            tbcDay4.DataContext = cMain;
            tbcDay5.DataContext = cMain;
            tbcDay6.DataContext = cMain;
            tbcDay7.DataContext = cMain;


        }
        //Return 7 day of week
        private string mdayofweek(int dayn)
        {
            DateTime dn = DateTime.Now;
            DateTime afteraddsub = dn.AddDays(dayn);
            return afteraddsub.Day.ToString();

        }

        private async void btnEventShow_Click(object sender, RoutedEventArgs e)
        {
            Events = await EventManager.GetEvent();
            showEvent.Visibility = Visibility.Visible;
            gridvEvents.ItemsSource = Events;
        }

        private async void GridView_ItemClick(object sender, ItemClickEventArgs e)
        {
            var messageDialog = new MessageDialog("Delete Event");
            messageDialog.Commands.Clear();
            messageDialog.Commands.Add(new UICommand { Label = "Yes", Id = 0 });
            messageDialog.Commands.Add(new UICommand { Label = "No", Id = 1 });
            var res = await messageDialog.ShowAsync();
            if ((int)res.Id == 0)
            {
                var eve = (Event)e.ClickedItem;
                Event evedelete = Events.Find(x => x.NameEvent.Equals(eve.NameEvent) && x.DayS.Equals(eve.DayS) && x.MonthS.Equals(eve.MonthS)
                                     && x.YearS.Equals(eve.YearS) && x.HourS.Equals(eve.HourS) && x.AMPMS.Equals(eve.AMPMS)
                                     && x.DayE.Equals(eve.DayE) && x.MonthE.Equals(eve.MonthE) && x.YearE.Equals(eve.YearE)
                                     && x.HourE.Equals(eve.HourE) && x.AMPME.Equals(eve.AMPME) && x.Description.Equals(eve.Description));
                List<Event> lstEve = new List<Event>();
                Events.Remove(evedelete);
                lstEve.AddRange(Events);
                //Write event to json

                string content = String.Empty;
                await ApplicationData.Current.LocalFolder.CreateFileAsync(JSONFILENAME, CreationCollisionOption.OpenIfExists);
                //var myStream = await ApplicationData.Current.LocalFolder.OpenStreamForReadAsync(JSONFILENAME);
                //using (StreamReader reader = new StreamReader(myStream))
                //{
                //    content = await reader.ReadToEndAsync();
                //    if (content.Length != 0)
                //    {
                //        DataContractJsonSerializer seri = new DataContractJsonSerializer(typeof(List<Event>));
                //        MemoryStream ms = new MemoryStream(Encoding.UTF8.GetBytes(content));

                //        List<Event> evet = (List<Event>)seri.ReadObject(ms);
                //        lstEve.AddRange(evet);
                //        await ms.FlushAsync();
                //    }

                //}
                //write
                var serializer = new DataContractJsonSerializer(typeof(List<Event>));
                using (var stream = await ApplicationData.Current.LocalFolder.OpenStreamForWriteAsync(
                    JSONFILENAME,
                    CreationCollisionOption.ReplaceExisting))
                {
                    serializer.WriteObject(stream, lstEve);
                }
                //

                Events = await EventManager.GetEvent();
                gridvEvents.ItemsSource = Events;

            }
            //if ((int)res.Id == 1)
            //{
             
            //}


          

           
        }


    }
}
