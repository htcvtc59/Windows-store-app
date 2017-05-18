using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Windows.UI.Xaml.Controls;

namespace Assignment_AWSAD1Calendar
{
    class CalendarCus
    {
        private static string afterday(int x)
        {
            DateTime now = DateTime.Now;
            int totaldaymonth = DateTime.DaysInMonth(now.Year, now.Month);
            DateTime daynextmonth = new DateTime(now.Year, now.Month, totaldaymonth);
            DateTime datenext = daynextmonth.AddDays(x);

            return datenext.Day.ToString();

        }

        public static DayinMonth DayBefore()
        {
            DateTime now = DateTime.Now;
            string nameday = now.DayOfWeek.ToString();

            int daynow = now.Day;

            DateTime day1 = now.AddDays(-(now.Day - 1));

            //day in month before add near day 1
            string dsu = "";
            DateTime dsun;
            string dmo = "";
            DateTime dmon;
            string dtu = "";
            DateTime dtue;
            string dwe = "";
            DateTime dwed;
            string dth = "";
            DateTime dthu;
            string dfr = "";
            DateTime dfri;
            string dsa = "";
            DateTime dsat;
            switch (day1.DayOfWeek.ToString())
            {
                case "Sunday":


                    break;
                case "Monday":
                    dsun = day1.AddDays(-1);
                    dsu = dsun.Day.ToString();

                    break;
                case "Tuesday":
                    dsun = day1.AddDays(-2);
                    dsu = dsun.Day.ToString();
                    dmon = day1.AddDays(-1);
                    dmo = dmon.Day.ToString();

                    break;
                case "Wednesday":
                    dsun = day1.AddDays(-3);
                    dsu = dsun.Day.ToString();
                    dmon = day1.AddDays(-2);
                    dmo = dmon.Day.ToString();
                    dtue = day1.AddDays(-1);
                    dtu = dtue.Day.ToString();

                    break;
                case "Thursday":
                    dsun = day1.AddDays(-4);
                    dsu = dsun.Day.ToString();
                    dmon = day1.AddDays(-3);
                    dmo = dmon.Day.ToString();
                    dtue = day1.AddDays(-2);
                    dtu = dtue.Day.ToString();
                    dwed = day1.AddDays(-1);
                    dwe = dwed.Day.ToString();

                    break;
                case "Friday":
                    dsun = day1.AddDays(-5);
                    dsu = dsun.Day.ToString();
                    dmon = day1.AddDays(-4);
                    dmo = dmon.Day.ToString();
                    dtue = day1.AddDays(-3);
                    dtu = dtue.Day.ToString();
                    dwed = day1.AddDays(-2);
                    dwe = dwed.Day.ToString();
                    dthu = day1.AddDays(-1);
                    dth = dthu.Day.ToString();

                    break;
                case "Saturday":
                    dsun = day1.AddDays(-6);
                    dsu = dsun.Day.ToString();
                    dmon = day1.AddDays(-5);
                    dmo = dmon.Day.ToString();
                    dtue = day1.AddDays(-4);
                    dtu = dtue.Day.ToString();
                    dwed = day1.AddDays(-3);
                    dwe = dwed.Day.ToString();
                    dthu = day1.AddDays(-2);
                    dth = dthu.Day.ToString();
                    dfri = day1.AddDays(-1);
                    dfr = dfri.Day.ToString();

                    break;
            }


            DayinMonth daybefore = new DayinMonth();

            switch (day1.DayOfWeek.ToString())
            {
                case "Sunday":


                    break;
                case "Monday":
                    daybefore.dSun1 = dsu;

                    break;
                case "Tuesday":
                    daybefore.dSun1 = dsu;
                    daybefore.dMon1 = dmo;

                    break;
                case "Wednesday":
                    daybefore.dSun1 = dsu;
                    daybefore.dMon1 = dmo;
                    daybefore.dTue1 = dtu;

                    break;
                case "Thursday":
                    daybefore.dSun1 = dsu;
                    daybefore.dMon1 = dmo;
                    daybefore.dTue1 = dtu;
                    daybefore.dWed1 = dwe;


                    break;
                case "Friday":
                    daybefore.dSun1 = dsu;
                    daybefore.dMon1 = dmo;
                    daybefore.dTue1 = dtu;
                    daybefore.dWed1 = dwe;
                    daybefore.dThu1 = dth;


                    break;
                case "Saturday":
                    daybefore.dSun1 = dsu;
                    daybefore.dMon1 = dmo;
                    daybefore.dTue1 = dtu;
                    daybefore.dWed1 = dwe;
                    daybefore.dThu1 = dth;
                    daybefore.dFri1 = dfr;


                    break;
            }

            return daybefore;


        }

        public static DayinMonth DayAfter()
        {
            DayinMonth finishdayofmonth = DaysMonth();
            DateTime now = DateTime.Now;
            int totaldaymonth = DateTime.DaysInMonth(now.Year, now.Month);
            //Date 1/month/year
            DateTime firstdmonth = new DateTime(now.Year, now.Month, 1);
            string firstd = firstdmonth.DayOfWeek.ToString();
            switch (firstd)
            {
                case "Sunday":
                    if (totaldaymonth == 31)
                    {
                        finishdayofmonth.dWed5 = afterday(1);
                        finishdayofmonth.dThu5 = afterday(2);
                        finishdayofmonth.dFri5 = afterday(3);
                        finishdayofmonth.dSat5 = afterday(4);
                        finishdayofmonth.dSun6 = afterday(5);
                        finishdayofmonth.dMon6 = afterday(6);
                        finishdayofmonth.dTue6 = afterday(7);
                        finishdayofmonth.dWed6 = afterday(8);
                        finishdayofmonth.dThu6 = afterday(9);
                        finishdayofmonth.dFri6 = afterday(10);
                        finishdayofmonth.dSat6 = afterday(11);


                    }
                    else if (totaldaymonth == 30)
                    {
                        finishdayofmonth.dTue5 = afterday(1);
                        finishdayofmonth.dWed5 = afterday(2);
                        finishdayofmonth.dThu5 = afterday(3);
                        finishdayofmonth.dFri5 = afterday(4);
                        finishdayofmonth.dSat5 = afterday(5);
                        finishdayofmonth.dSun6 = afterday(6);
                        finishdayofmonth.dMon6 = afterday(7);
                        finishdayofmonth.dTue6 = afterday(8);
                        finishdayofmonth.dWed6 = afterday(9);
                        finishdayofmonth.dThu6 = afterday(10);
                        finishdayofmonth.dFri6 = afterday(11);
                        finishdayofmonth.dSat6 = afterday(12);

                    }
                    else if (totaldaymonth == 29)
                    {
                        finishdayofmonth.dMon5 = afterday(1);
                        finishdayofmonth.dTue5 = afterday(2);
                        finishdayofmonth.dWed5 = afterday(3);
                        finishdayofmonth.dThu5 = afterday(4);
                        finishdayofmonth.dFri5 = afterday(5);
                        finishdayofmonth.dSat5 = afterday(6);
                        finishdayofmonth.dSun6 = afterday(7);
                        finishdayofmonth.dMon6 = afterday(8);
                        finishdayofmonth.dTue6 = afterday(9);
                        finishdayofmonth.dWed6 = afterday(10);
                        finishdayofmonth.dThu6 = afterday(11);
                        finishdayofmonth.dFri6 = afterday(12);
                        finishdayofmonth.dSat6 = afterday(13);

                    }
                    else if (totaldaymonth == 28)
                    {
                        finishdayofmonth.dSun5 = afterday(1);
                        finishdayofmonth.dMon5 = afterday(2);
                        finishdayofmonth.dTue5 = afterday(3);
                        finishdayofmonth.dWed5 = afterday(4);
                        finishdayofmonth.dThu5 = afterday(5);
                        finishdayofmonth.dFri5 = afterday(6);
                        finishdayofmonth.dSat5 = afterday(7);
                        finishdayofmonth.dSun6 = afterday(8);
                        finishdayofmonth.dMon6 = afterday(9);
                        finishdayofmonth.dTue6 = afterday(10);
                        finishdayofmonth.dWed6 = afterday(11);
                        finishdayofmonth.dThu6 = afterday(12);
                        finishdayofmonth.dFri6 = afterday(13);
                        finishdayofmonth.dSat6 = afterday(14);

                    }
                    break;
                case "Monday":
                    if (totaldaymonth == 31)
                    {
                        finishdayofmonth.dThu5 = afterday(1);
                        finishdayofmonth.dFri5 = afterday(2);
                        finishdayofmonth.dSat5 = afterday(3);
                        finishdayofmonth.dSun6 = afterday(4);
                        finishdayofmonth.dMon6 = afterday(5);
                        finishdayofmonth.dTue6 = afterday(6);
                        finishdayofmonth.dWed6 = afterday(7);
                        finishdayofmonth.dThu6 = afterday(8);
                        finishdayofmonth.dFri6 = afterday(9);
                        finishdayofmonth.dSat6 = afterday(10);

                    }
                    else if (totaldaymonth == 30)
                    {
                        finishdayofmonth.dWed5 = afterday(1);
                        finishdayofmonth.dThu5 = afterday(2);
                        finishdayofmonth.dFri5 = afterday(3);
                        finishdayofmonth.dSat5 = afterday(4);
                        finishdayofmonth.dSun6 = afterday(5);
                        finishdayofmonth.dMon6 = afterday(6);
                        finishdayofmonth.dTue6 = afterday(7);
                        finishdayofmonth.dWed6 = afterday(8);
                        finishdayofmonth.dThu6 = afterday(9);
                        finishdayofmonth.dFri6 = afterday(10);
                        finishdayofmonth.dSat6 = afterday(11);

                    }
                    else if (totaldaymonth == 29)
                    {
                        finishdayofmonth.dTue5 = afterday(1);
                        finishdayofmonth.dWed5 = afterday(2);
                        finishdayofmonth.dThu5 = afterday(3);
                        finishdayofmonth.dFri5 = afterday(4);
                        finishdayofmonth.dSat5 = afterday(5);
                        finishdayofmonth.dSun6 = afterday(6);
                        finishdayofmonth.dMon6 = afterday(7);
                        finishdayofmonth.dTue6 = afterday(8);
                        finishdayofmonth.dWed6 = afterday(9);
                        finishdayofmonth.dThu6 = afterday(10);
                        finishdayofmonth.dFri6 = afterday(11);
                        finishdayofmonth.dSat6 = afterday(12);

                    }
                    else if (totaldaymonth == 28)
                    {
                        finishdayofmonth.dMon5 = afterday(1);
                        finishdayofmonth.dTue5 = afterday(2);
                        finishdayofmonth.dWed5 = afterday(3);
                        finishdayofmonth.dThu5 = afterday(4);
                        finishdayofmonth.dFri5 = afterday(5);
                        finishdayofmonth.dSat5 = afterday(6);
                        finishdayofmonth.dSun6 = afterday(7);
                        finishdayofmonth.dMon6 = afterday(8);
                        finishdayofmonth.dTue6 = afterday(9);
                        finishdayofmonth.dWed6 = afterday(10);
                        finishdayofmonth.dThu6 = afterday(11);
                        finishdayofmonth.dFri6 = afterday(12);
                        finishdayofmonth.dSat6 = afterday(13);

                    }

                    break;
                case "Tuesday":
                    if (totaldaymonth == 31)
                    {
                        finishdayofmonth.dFri5 = afterday(1);
                        finishdayofmonth.dSat5 = afterday(2);
                        finishdayofmonth.dSun6 = afterday(3);
                        finishdayofmonth.dMon6 = afterday(4);
                        finishdayofmonth.dTue6 = afterday(5);
                        finishdayofmonth.dWed6 = afterday(6);
                        finishdayofmonth.dThu6 = afterday(7);
                        finishdayofmonth.dFri6 = afterday(8);
                        finishdayofmonth.dSat6 = afterday(9);

                    }
                    else if (totaldaymonth == 30)
                    {
                        finishdayofmonth.dThu5 = afterday(1);
                        finishdayofmonth.dFri5 = afterday(2);
                        finishdayofmonth.dSat5 = afterday(3);
                        finishdayofmonth.dSun6 = afterday(4);
                        finishdayofmonth.dMon6 = afterday(5);
                        finishdayofmonth.dTue6 = afterday(6);
                        finishdayofmonth.dWed6 = afterday(7);
                        finishdayofmonth.dThu6 = afterday(8);
                        finishdayofmonth.dFri6 = afterday(9);
                        finishdayofmonth.dSat6 = afterday(10);

                    }
                    else if (totaldaymonth == 29)
                    {
                        finishdayofmonth.dWed5 = afterday(1);
                        finishdayofmonth.dThu5 = afterday(2);
                        finishdayofmonth.dFri5 = afterday(3);
                        finishdayofmonth.dSat5 = afterday(4);
                        finishdayofmonth.dSun6 = afterday(5);
                        finishdayofmonth.dMon6 = afterday(6);
                        finishdayofmonth.dTue6 = afterday(7);
                        finishdayofmonth.dWed6 = afterday(8);
                        finishdayofmonth.dThu6 = afterday(9);
                        finishdayofmonth.dFri6 = afterday(10);
                        finishdayofmonth.dSat6 = afterday(11);

                    }
                    else if (totaldaymonth == 28)
                    {
                        finishdayofmonth.dTue5 = afterday(1);
                        finishdayofmonth.dWed5 = afterday(2);
                        finishdayofmonth.dThu5 = afterday(3);
                        finishdayofmonth.dFri5 = afterday(4);
                        finishdayofmonth.dSat5 = afterday(5);
                        finishdayofmonth.dSun6 = afterday(6);
                        finishdayofmonth.dMon6 = afterday(7);
                        finishdayofmonth.dTue6 = afterday(8);
                        finishdayofmonth.dWed6 = afterday(9);
                        finishdayofmonth.dThu6 = afterday(10);
                        finishdayofmonth.dFri6 = afterday(11);
                        finishdayofmonth.dSat6 = afterday(12);

                    }

                    break;
                case "Wednesday":
                    if (totaldaymonth == 31)
                    {
                        finishdayofmonth.dSat5 = afterday(1);
                        finishdayofmonth.dSun6 = afterday(2);
                        finishdayofmonth.dMon6 = afterday(3);
                        finishdayofmonth.dTue6 = afterday(4);
                        finishdayofmonth.dWed6 = afterday(5);
                        finishdayofmonth.dThu6 = afterday(6);
                        finishdayofmonth.dFri6 = afterday(7);
                        finishdayofmonth.dSat6 = afterday(8);

                    }
                    else if (totaldaymonth == 30)
                    {

                        finishdayofmonth.dFri5 = afterday(1);
                        finishdayofmonth.dSat5 = afterday(2);
                        finishdayofmonth.dSun6 = afterday(3);
                        finishdayofmonth.dMon6 = afterday(4);
                        finishdayofmonth.dTue6 = afterday(5);
                        finishdayofmonth.dWed6 = afterday(6);
                        finishdayofmonth.dThu6 = afterday(7);
                        finishdayofmonth.dFri6 = afterday(8);
                        finishdayofmonth.dSat6 = afterday(9);
                    }
                    else if (totaldaymonth == 29)
                    {
                        finishdayofmonth.dThu5 = afterday(1);
                        finishdayofmonth.dFri5 = afterday(2);
                        finishdayofmonth.dSat5 = afterday(3);
                        finishdayofmonth.dSun6 = afterday(4);
                        finishdayofmonth.dMon6 = afterday(5);
                        finishdayofmonth.dTue6 = afterday(6);
                        finishdayofmonth.dWed6 = afterday(7);
                        finishdayofmonth.dThu6 = afterday(8);
                        finishdayofmonth.dFri6 = afterday(9);
                        finishdayofmonth.dSat6 = afterday(10);

                    }
                    else if (totaldaymonth == 28)
                    {
                        finishdayofmonth.dWed5 = afterday(1);
                        finishdayofmonth.dThu5 = afterday(2);
                        finishdayofmonth.dFri5 = afterday(3);
                        finishdayofmonth.dSat5 = afterday(4);
                        finishdayofmonth.dSun6 = afterday(5);
                        finishdayofmonth.dMon6 = afterday(6);
                        finishdayofmonth.dTue6 = afterday(7);
                        finishdayofmonth.dWed6 = afterday(8);
                        finishdayofmonth.dThu6 = afterday(9);
                        finishdayofmonth.dFri6 = afterday(10);
                        finishdayofmonth.dSat6 = afterday(11);

                    }

                    break;
                case "Thursday":
                    if (totaldaymonth == 31)
                    {
                        finishdayofmonth.dSun6 = afterday(1);
                        finishdayofmonth.dMon6 = afterday(2);
                        finishdayofmonth.dTue6 = afterday(3);
                        finishdayofmonth.dWed6 = afterday(4);
                        finishdayofmonth.dThu6 = afterday(5);
                        finishdayofmonth.dFri6 = afterday(6);
                        finishdayofmonth.dSat6 = afterday(7);

                    }
                    else if (totaldaymonth == 30)
                    {
                        finishdayofmonth.dSat5 = afterday(1);
                        finishdayofmonth.dSun6 = afterday(2);
                        finishdayofmonth.dMon6 = afterday(3);
                        finishdayofmonth.dTue6 = afterday(4);
                        finishdayofmonth.dWed6 = afterday(5);
                        finishdayofmonth.dThu6 = afterday(6);
                        finishdayofmonth.dFri6 = afterday(7);
                        finishdayofmonth.dSat6 = afterday(8);

                    }
                    else if (totaldaymonth == 29)
                    {

                        finishdayofmonth.dFri5 = afterday(1);
                        finishdayofmonth.dSat5 = afterday(2);
                        finishdayofmonth.dSun6 = afterday(3);
                        finishdayofmonth.dMon6 = afterday(4);
                        finishdayofmonth.dTue6 = afterday(5);
                        finishdayofmonth.dWed6 = afterday(6);
                        finishdayofmonth.dThu6 = afterday(7);
                        finishdayofmonth.dFri6 = afterday(8);
                        finishdayofmonth.dSat6 = afterday(9);
                    }
                    else if (totaldaymonth == 28)
                    {
                        finishdayofmonth.dThu5 = afterday(1);
                        finishdayofmonth.dFri5 = afterday(2);
                        finishdayofmonth.dSat5 = afterday(3);
                        finishdayofmonth.dSun6 = afterday(4);
                        finishdayofmonth.dMon6 = afterday(5);
                        finishdayofmonth.dTue6 = afterday(6);
                        finishdayofmonth.dWed6 = afterday(7);
                        finishdayofmonth.dThu6 = afterday(8);
                        finishdayofmonth.dFri6 = afterday(9);
                        finishdayofmonth.dSat6 = afterday(10);

                    }

                    break;
                case "Friday":
                    if (totaldaymonth == 31)
                    {
                        finishdayofmonth.dMon6 = afterday(1);
                        finishdayofmonth.dTue6 = afterday(2);
                        finishdayofmonth.dWed6 = afterday(3);
                        finishdayofmonth.dThu6 = afterday(4);
                        finishdayofmonth.dFri6 = afterday(5);
                        finishdayofmonth.dSat6 = afterday(6);

                    }
                    else if (totaldaymonth == 30)
                    {
                        finishdayofmonth.dSun6 = afterday(1);
                        finishdayofmonth.dMon6 = afterday(2);
                        finishdayofmonth.dTue6 = afterday(3);
                        finishdayofmonth.dWed6 = afterday(4);
                        finishdayofmonth.dThu6 = afterday(5);
                        finishdayofmonth.dFri6 = afterday(6);
                        finishdayofmonth.dSat6 = afterday(7);

                    }
                    else if (totaldaymonth == 29)
                    {
                        finishdayofmonth.dSat5 = afterday(1);
                        finishdayofmonth.dSun6 = afterday(2);
                        finishdayofmonth.dMon6 = afterday(3);
                        finishdayofmonth.dTue6 = afterday(4);
                        finishdayofmonth.dWed6 = afterday(5);
                        finishdayofmonth.dThu6 = afterday(6);
                        finishdayofmonth.dFri6 = afterday(7);
                        finishdayofmonth.dSat6 = afterday(8);

                    }
                    else if (totaldaymonth == 28)
                    {

                        finishdayofmonth.dFri5 = afterday(1);
                        finishdayofmonth.dSat5 = afterday(2);
                        finishdayofmonth.dSun6 = afterday(4);
                        finishdayofmonth.dMon6 = afterday(5);
                        finishdayofmonth.dTue6 = afterday(6);
                        finishdayofmonth.dWed6 = afterday(7);
                        finishdayofmonth.dThu6 = afterday(8);
                        finishdayofmonth.dFri6 = afterday(9);
                        finishdayofmonth.dSat6 = afterday(10);
                    }

                    break;
                case "Saturday":
                    if (totaldaymonth == 31)
                    {
                        finishdayofmonth.dTue6 = afterday(1);
                        finishdayofmonth.dWed6 = afterday(2);
                        finishdayofmonth.dThu6 = afterday(3);
                        finishdayofmonth.dFri6 = afterday(4);
                        finishdayofmonth.dSat6 = afterday(5);

                    }
                    else if (totaldaymonth == 30)
                    {
                        finishdayofmonth.dMon6 = afterday(1);
                        finishdayofmonth.dTue6 = afterday(2);
                        finishdayofmonth.dWed6 = afterday(3);
                        finishdayofmonth.dThu6 = afterday(4);
                        finishdayofmonth.dFri6 = afterday(5);
                        finishdayofmonth.dSat6 = afterday(6);

                    }
                    else if (totaldaymonth == 29)
                    {

                        finishdayofmonth.dSun6 = afterday(1);
                        finishdayofmonth.dMon6 = afterday(2);
                        finishdayofmonth.dTue6 = afterday(3);
                        finishdayofmonth.dWed6 = afterday(4);
                        finishdayofmonth.dThu6 = afterday(5);
                        finishdayofmonth.dFri6 = afterday(6);
                        finishdayofmonth.dSat6 = afterday(7);
                    }
                    else if (totaldaymonth == 28)
                    {
                        finishdayofmonth.dSat5 = afterday(1);
                        finishdayofmonth.dSun6 = afterday(2);
                        finishdayofmonth.dMon6 = afterday(3);
                        finishdayofmonth.dTue6 = afterday(4);
                        finishdayofmonth.dWed6 = afterday(5);
                        finishdayofmonth.dThu6 = afterday(6);
                        finishdayofmonth.dFri6 = afterday(7);
                        finishdayofmonth.dSat6 = afterday(8);

                    }
                    break;



            }
            return finishdayofmonth;
        }



        public static DayinMonth DaysMonth()
        {
            DateTime now = DateTime.Now;
            int totaldaymonth = DateTime.DaysInMonth(now.Year, now.Month);
            //Date 1/month/year
            DateTime firstdmonth = new DateTime(now.Year, now.Month, 1);
            string firstd = firstdmonth.DayOfWeek.ToString();

            List<string> listDay = new List<string>();

            for (int i = 1; i <= totaldaymonth; i++)
            {
                listDay.Add(i.ToString());
            }


            DayinMonth dayinmonth = new DayinMonth();
            switch (firstd)
            {
                case "Sunday":
                    if (totaldaymonth == 30)
                    {
                        dayinmonth.dSun1 = listDay[0];
                        dayinmonth.dMon1 = listDay[1];
                        dayinmonth.dTue1 = listDay[2];
                        dayinmonth.dWed1 = listDay[3];
                        dayinmonth.dThu1 = listDay[4];
                        dayinmonth.dFri1 = listDay[5];
                        dayinmonth.dSat1 = listDay[6];
                        dayinmonth.dSun2 = listDay[7];
                        dayinmonth.dMon2 = listDay[8];
                        dayinmonth.dTue2 = listDay[9];
                        dayinmonth.dWed2 = listDay[10];
                        dayinmonth.dThu2 = listDay[11];
                        dayinmonth.dFri2 = listDay[12];
                        dayinmonth.dSat2 = listDay[13];
                        dayinmonth.dSun3 = listDay[14];
                        dayinmonth.dMon3 = listDay[15];
                        dayinmonth.dTue3 = listDay[16];
                        dayinmonth.dWed3 = listDay[17];
                        dayinmonth.dThu3 = listDay[18];
                        dayinmonth.dFri3 = listDay[19];
                        dayinmonth.dSat3 = listDay[20];
                        dayinmonth.dSun4 = listDay[21];
                        dayinmonth.dMon4 = listDay[22];
                        dayinmonth.dTue4 = listDay[23];
                        dayinmonth.dWed4 = listDay[24];
                        dayinmonth.dThu4 = listDay[25];
                        dayinmonth.dFri4 = listDay[26];
                        dayinmonth.dSat4 = listDay[27];
                        dayinmonth.dSun5 = listDay[28];
                        dayinmonth.dMon5 = listDay[29];

                    }
                    else if (totaldaymonth == 31)
                    {
                        dayinmonth.dSun1 = listDay[0];
                        dayinmonth.dMon1 = listDay[1];
                        dayinmonth.dTue1 = listDay[2];
                        dayinmonth.dWed1 = listDay[3];
                        dayinmonth.dThu1 = listDay[4];
                        dayinmonth.dFri1 = listDay[5];
                        dayinmonth.dSat1 = listDay[6];
                        dayinmonth.dSun2 = listDay[7];
                        dayinmonth.dMon2 = listDay[8];
                        dayinmonth.dTue2 = listDay[9];
                        dayinmonth.dWed2 = listDay[10];
                        dayinmonth.dThu2 = listDay[11];
                        dayinmonth.dFri2 = listDay[12];
                        dayinmonth.dSat2 = listDay[13];
                        dayinmonth.dSun3 = listDay[14];
                        dayinmonth.dMon3 = listDay[15];
                        dayinmonth.dTue3 = listDay[16];
                        dayinmonth.dWed3 = listDay[17];
                        dayinmonth.dThu3 = listDay[18];
                        dayinmonth.dFri3 = listDay[19];
                        dayinmonth.dSat3 = listDay[20];
                        dayinmonth.dSun4 = listDay[21];
                        dayinmonth.dMon4 = listDay[22];
                        dayinmonth.dTue4 = listDay[23];
                        dayinmonth.dWed4 = listDay[24];
                        dayinmonth.dThu4 = listDay[25];
                        dayinmonth.dFri4 = listDay[26];
                        dayinmonth.dSat4 = listDay[27];
                        dayinmonth.dSun5 = listDay[28];
                        dayinmonth.dMon5 = listDay[29];
                        dayinmonth.dTue5 = listDay[30];

                    }
                    else if (totaldaymonth == 28)
                    {
                        dayinmonth.dSun1 = listDay[0];
                        dayinmonth.dMon1 = listDay[1];
                        dayinmonth.dTue1 = listDay[2];
                        dayinmonth.dWed1 = listDay[3];
                        dayinmonth.dThu1 = listDay[4];
                        dayinmonth.dFri1 = listDay[5];
                        dayinmonth.dSat1 = listDay[6];
                        dayinmonth.dSun2 = listDay[7];
                        dayinmonth.dMon2 = listDay[8];
                        dayinmonth.dTue2 = listDay[9];
                        dayinmonth.dWed2 = listDay[10];
                        dayinmonth.dThu2 = listDay[11];
                        dayinmonth.dFri2 = listDay[12];
                        dayinmonth.dSat2 = listDay[13];
                        dayinmonth.dSun3 = listDay[14];
                        dayinmonth.dMon3 = listDay[15];
                        dayinmonth.dTue3 = listDay[16];
                        dayinmonth.dWed3 = listDay[17];
                        dayinmonth.dThu3 = listDay[18];
                        dayinmonth.dFri3 = listDay[19];
                        dayinmonth.dSat3 = listDay[20];
                        dayinmonth.dSun4 = listDay[21];
                        dayinmonth.dMon4 = listDay[22];
                        dayinmonth.dTue4 = listDay[23];
                        dayinmonth.dWed4 = listDay[24];
                        dayinmonth.dThu4 = listDay[25];
                        dayinmonth.dFri4 = listDay[26];
                        dayinmonth.dSat4 = listDay[27];


                    }
                    else if (totaldaymonth == 29)
                    {
                        dayinmonth.dSun1 = listDay[0];
                        dayinmonth.dMon1 = listDay[1];
                        dayinmonth.dTue1 = listDay[2];
                        dayinmonth.dWed1 = listDay[3];
                        dayinmonth.dThu1 = listDay[4];
                        dayinmonth.dFri1 = listDay[5];
                        dayinmonth.dSat1 = listDay[6];
                        dayinmonth.dSun2 = listDay[7];
                        dayinmonth.dMon2 = listDay[8];
                        dayinmonth.dTue2 = listDay[9];
                        dayinmonth.dWed2 = listDay[10];
                        dayinmonth.dThu2 = listDay[11];
                        dayinmonth.dFri2 = listDay[12];
                        dayinmonth.dSat2 = listDay[13];
                        dayinmonth.dSun3 = listDay[14];
                        dayinmonth.dMon3 = listDay[15];
                        dayinmonth.dTue3 = listDay[16];
                        dayinmonth.dWed3 = listDay[17];
                        dayinmonth.dThu3 = listDay[18];
                        dayinmonth.dFri3 = listDay[19];
                        dayinmonth.dSat3 = listDay[20];
                        dayinmonth.dSun4 = listDay[21];
                        dayinmonth.dMon4 = listDay[22];
                        dayinmonth.dTue4 = listDay[23];
                        dayinmonth.dWed4 = listDay[24];
                        dayinmonth.dThu4 = listDay[25];
                        dayinmonth.dFri4 = listDay[26];
                        dayinmonth.dSat4 = listDay[27];
                        dayinmonth.dSun5 = listDay[28];
                    }



                    break;
                case "Monday":
                    if (totaldaymonth == 30)
                    {

                        dayinmonth.dMon1 = listDay[0];
                        dayinmonth.dTue1 = listDay[1];
                        dayinmonth.dWed1 = listDay[2];
                        dayinmonth.dThu1 = listDay[3];
                        dayinmonth.dFri1 = listDay[4];
                        dayinmonth.dSat1 = listDay[5];
                        dayinmonth.dSun2 = listDay[6];
                        dayinmonth.dMon2 = listDay[7];
                        dayinmonth.dTue2 = listDay[8];
                        dayinmonth.dWed2 = listDay[9];
                        dayinmonth.dThu2 = listDay[10];
                        dayinmonth.dFri2 = listDay[11];
                        dayinmonth.dSat2 = listDay[12];
                        dayinmonth.dSun3 = listDay[13];
                        dayinmonth.dMon3 = listDay[14];
                        dayinmonth.dTue3 = listDay[15];
                        dayinmonth.dWed3 = listDay[16];
                        dayinmonth.dThu3 = listDay[17];
                        dayinmonth.dFri3 = listDay[18];
                        dayinmonth.dSat3 = listDay[19];
                        dayinmonth.dSun4 = listDay[20];
                        dayinmonth.dMon4 = listDay[21];
                        dayinmonth.dTue4 = listDay[22];
                        dayinmonth.dWed4 = listDay[23];
                        dayinmonth.dThu4 = listDay[24];
                        dayinmonth.dFri4 = listDay[25];
                        dayinmonth.dSat4 = listDay[26];
                        dayinmonth.dSun5 = listDay[27];
                        dayinmonth.dMon5 = listDay[28];
                        dayinmonth.dTue5 = listDay[29];

                    }
                    else if (totaldaymonth == 31)
                    {
                        dayinmonth.dMon1 = listDay[0];
                        dayinmonth.dTue1 = listDay[1];
                        dayinmonth.dWed1 = listDay[2];
                        dayinmonth.dThu1 = listDay[3];
                        dayinmonth.dFri1 = listDay[4];
                        dayinmonth.dSat1 = listDay[5];
                        dayinmonth.dSun2 = listDay[6];
                        dayinmonth.dMon2 = listDay[7];
                        dayinmonth.dTue2 = listDay[8];
                        dayinmonth.dWed2 = listDay[9];
                        dayinmonth.dThu2 = listDay[10];
                        dayinmonth.dFri2 = listDay[11];
                        dayinmonth.dSat2 = listDay[12];
                        dayinmonth.dSun3 = listDay[13];
                        dayinmonth.dMon3 = listDay[14];
                        dayinmonth.dTue3 = listDay[15];
                        dayinmonth.dWed3 = listDay[16];
                        dayinmonth.dThu3 = listDay[17];
                        dayinmonth.dFri3 = listDay[18];
                        dayinmonth.dSat3 = listDay[19];
                        dayinmonth.dSun4 = listDay[20];
                        dayinmonth.dMon4 = listDay[21];
                        dayinmonth.dTue4 = listDay[22];
                        dayinmonth.dWed4 = listDay[23];
                        dayinmonth.dThu4 = listDay[24];
                        dayinmonth.dFri4 = listDay[25];
                        dayinmonth.dSat4 = listDay[26];
                        dayinmonth.dSun5 = listDay[27];
                        dayinmonth.dMon5 = listDay[28];
                        dayinmonth.dTue5 = listDay[29];
                        dayinmonth.dWed5 = listDay[30];

                    }
                    else if (totaldaymonth == 28)
                    {
                        dayinmonth.dMon1 = listDay[0];
                        dayinmonth.dTue1 = listDay[1];
                        dayinmonth.dWed1 = listDay[2];
                        dayinmonth.dThu1 = listDay[3];
                        dayinmonth.dFri1 = listDay[4];
                        dayinmonth.dSat1 = listDay[5];
                        dayinmonth.dSun2 = listDay[6];
                        dayinmonth.dMon2 = listDay[7];
                        dayinmonth.dTue2 = listDay[8];
                        dayinmonth.dWed2 = listDay[9];
                        dayinmonth.dThu2 = listDay[10];
                        dayinmonth.dFri2 = listDay[11];
                        dayinmonth.dSat2 = listDay[12];
                        dayinmonth.dSun3 = listDay[13];
                        dayinmonth.dMon3 = listDay[14];
                        dayinmonth.dTue3 = listDay[15];
                        dayinmonth.dWed3 = listDay[16];
                        dayinmonth.dThu3 = listDay[17];
                        dayinmonth.dFri3 = listDay[18];
                        dayinmonth.dSat3 = listDay[19];
                        dayinmonth.dSun4 = listDay[20];
                        dayinmonth.dMon4 = listDay[21];
                        dayinmonth.dTue4 = listDay[22];
                        dayinmonth.dWed4 = listDay[23];
                        dayinmonth.dThu4 = listDay[24];
                        dayinmonth.dFri4 = listDay[25];
                        dayinmonth.dSat4 = listDay[26];
                        dayinmonth.dSun5 = listDay[27];


                    }
                    else if (totaldaymonth == 29)
                    {
                        dayinmonth.dMon1 = listDay[0];
                        dayinmonth.dTue1 = listDay[1];
                        dayinmonth.dWed1 = listDay[2];
                        dayinmonth.dThu1 = listDay[3];
                        dayinmonth.dFri1 = listDay[4];
                        dayinmonth.dSat1 = listDay[5];
                        dayinmonth.dSun2 = listDay[6];
                        dayinmonth.dMon2 = listDay[7];
                        dayinmonth.dTue2 = listDay[8];
                        dayinmonth.dWed2 = listDay[9];
                        dayinmonth.dThu2 = listDay[10];
                        dayinmonth.dFri2 = listDay[11];
                        dayinmonth.dSat2 = listDay[12];
                        dayinmonth.dSun3 = listDay[13];
                        dayinmonth.dMon3 = listDay[14];
                        dayinmonth.dTue3 = listDay[15];
                        dayinmonth.dWed3 = listDay[16];
                        dayinmonth.dThu3 = listDay[17];
                        dayinmonth.dFri3 = listDay[18];
                        dayinmonth.dSat3 = listDay[19];
                        dayinmonth.dSun4 = listDay[20];
                        dayinmonth.dMon4 = listDay[21];
                        dayinmonth.dTue4 = listDay[22];
                        dayinmonth.dWed4 = listDay[23];
                        dayinmonth.dThu4 = listDay[24];
                        dayinmonth.dFri4 = listDay[25];
                        dayinmonth.dSat4 = listDay[26];
                        dayinmonth.dSun5 = listDay[27];
                        dayinmonth.dMon5 = listDay[28];
                    }


                    break;
                case "Tuesday":
                    if (totaldaymonth == 30)
                    {

                        dayinmonth.dTue1 = listDay[0];
                        dayinmonth.dWed1 = listDay[1];
                        dayinmonth.dThu1 = listDay[2];
                        dayinmonth.dFri1 = listDay[3];
                        dayinmonth.dSat1 = listDay[4];
                        dayinmonth.dSun2 = listDay[5];
                        dayinmonth.dMon2 = listDay[6];
                        dayinmonth.dTue2 = listDay[7];
                        dayinmonth.dWed2 = listDay[8];
                        dayinmonth.dThu2 = listDay[9];
                        dayinmonth.dFri2 = listDay[10];
                        dayinmonth.dSat2 = listDay[11];
                        dayinmonth.dSun3 = listDay[12];
                        dayinmonth.dMon3 = listDay[13];
                        dayinmonth.dTue3 = listDay[14];
                        dayinmonth.dWed3 = listDay[15];
                        dayinmonth.dThu3 = listDay[16];
                        dayinmonth.dFri3 = listDay[17];
                        dayinmonth.dSat3 = listDay[18];
                        dayinmonth.dSun4 = listDay[19];
                        dayinmonth.dMon4 = listDay[20];
                        dayinmonth.dTue4 = listDay[21];
                        dayinmonth.dWed4 = listDay[22];
                        dayinmonth.dThu4 = listDay[23];
                        dayinmonth.dFri4 = listDay[24];
                        dayinmonth.dSat4 = listDay[25];
                        dayinmonth.dSun5 = listDay[26];
                        dayinmonth.dMon5 = listDay[27];
                        dayinmonth.dTue5 = listDay[28];
                        dayinmonth.dWed5 = listDay[29];

                    }
                    else if (totaldaymonth == 31)
                    {
                        dayinmonth.dTue1 = listDay[0];
                        dayinmonth.dWed1 = listDay[1];
                        dayinmonth.dThu1 = listDay[2];
                        dayinmonth.dFri1 = listDay[3];
                        dayinmonth.dSat1 = listDay[4];
                        dayinmonth.dSun2 = listDay[5];
                        dayinmonth.dMon2 = listDay[6];
                        dayinmonth.dTue2 = listDay[7];
                        dayinmonth.dWed2 = listDay[8];
                        dayinmonth.dThu2 = listDay[9];
                        dayinmonth.dFri2 = listDay[10];
                        dayinmonth.dSat2 = listDay[11];
                        dayinmonth.dSun3 = listDay[12];
                        dayinmonth.dMon3 = listDay[13];
                        dayinmonth.dTue3 = listDay[14];
                        dayinmonth.dWed3 = listDay[15];
                        dayinmonth.dThu3 = listDay[16];
                        dayinmonth.dFri3 = listDay[17];
                        dayinmonth.dSat3 = listDay[18];
                        dayinmonth.dSun4 = listDay[19];
                        dayinmonth.dMon4 = listDay[20];
                        dayinmonth.dTue4 = listDay[21];
                        dayinmonth.dWed4 = listDay[22];
                        dayinmonth.dThu4 = listDay[23];
                        dayinmonth.dFri4 = listDay[24];
                        dayinmonth.dSat4 = listDay[25];
                        dayinmonth.dSun5 = listDay[26];
                        dayinmonth.dMon5 = listDay[27];
                        dayinmonth.dTue5 = listDay[28];
                        dayinmonth.dWed5 = listDay[29];
                        dayinmonth.dThu5 = listDay[30];

                    }
                    else if (totaldaymonth == 28)
                    {
                        dayinmonth.dTue1 = listDay[0];
                        dayinmonth.dWed1 = listDay[1];
                        dayinmonth.dThu1 = listDay[2];
                        dayinmonth.dFri1 = listDay[3];
                        dayinmonth.dSat1 = listDay[4];
                        dayinmonth.dSun2 = listDay[5];
                        dayinmonth.dMon2 = listDay[6];
                        dayinmonth.dTue2 = listDay[7];
                        dayinmonth.dWed2 = listDay[8];
                        dayinmonth.dThu2 = listDay[9];
                        dayinmonth.dFri2 = listDay[10];
                        dayinmonth.dSat2 = listDay[11];
                        dayinmonth.dSun3 = listDay[12];
                        dayinmonth.dMon3 = listDay[13];
                        dayinmonth.dTue3 = listDay[14];
                        dayinmonth.dWed3 = listDay[15];
                        dayinmonth.dThu3 = listDay[16];
                        dayinmonth.dFri3 = listDay[17];
                        dayinmonth.dSat3 = listDay[18];
                        dayinmonth.dSun4 = listDay[19];
                        dayinmonth.dMon4 = listDay[20];
                        dayinmonth.dTue4 = listDay[21];
                        dayinmonth.dWed4 = listDay[22];
                        dayinmonth.dThu4 = listDay[23];
                        dayinmonth.dFri4 = listDay[24];
                        dayinmonth.dSat4 = listDay[25];
                        dayinmonth.dSun5 = listDay[26];
                        dayinmonth.dMon5 = listDay[27];


                    }
                    else if (totaldaymonth == 29)
                    {
                        dayinmonth.dTue1 = listDay[0];
                        dayinmonth.dWed1 = listDay[1];
                        dayinmonth.dThu1 = listDay[2];
                        dayinmonth.dFri1 = listDay[3];
                        dayinmonth.dSat1 = listDay[4];
                        dayinmonth.dSun2 = listDay[5];
                        dayinmonth.dMon2 = listDay[6];
                        dayinmonth.dTue2 = listDay[7];
                        dayinmonth.dWed2 = listDay[8];
                        dayinmonth.dThu2 = listDay[9];
                        dayinmonth.dFri2 = listDay[10];
                        dayinmonth.dSat2 = listDay[11];
                        dayinmonth.dSun3 = listDay[12];
                        dayinmonth.dMon3 = listDay[13];
                        dayinmonth.dTue3 = listDay[14];
                        dayinmonth.dWed3 = listDay[15];
                        dayinmonth.dThu3 = listDay[16];
                        dayinmonth.dFri3 = listDay[17];
                        dayinmonth.dSat3 = listDay[18];
                        dayinmonth.dSun4 = listDay[19];
                        dayinmonth.dMon4 = listDay[20];
                        dayinmonth.dTue4 = listDay[21];
                        dayinmonth.dWed4 = listDay[22];
                        dayinmonth.dThu4 = listDay[23];
                        dayinmonth.dFri4 = listDay[24];
                        dayinmonth.dSat4 = listDay[25];
                        dayinmonth.dSun5 = listDay[26];
                        dayinmonth.dMon5 = listDay[27];
                        dayinmonth.dTue5 = listDay[28];
                    }

                    break;
                case "Wednesday":
                    if (totaldaymonth == 30)
                    {

                        dayinmonth.dWed1 = listDay[0];
                        dayinmonth.dThu1 = listDay[1];
                        dayinmonth.dFri1 = listDay[2];
                        dayinmonth.dSat1 = listDay[3];
                        dayinmonth.dSun2 = listDay[4];
                        dayinmonth.dMon2 = listDay[5];
                        dayinmonth.dTue2 = listDay[6];
                        dayinmonth.dWed2 = listDay[7];
                        dayinmonth.dThu2 = listDay[8];
                        dayinmonth.dFri2 = listDay[9];
                        dayinmonth.dSat2 = listDay[10];
                        dayinmonth.dSun3 = listDay[11];
                        dayinmonth.dMon3 = listDay[12];
                        dayinmonth.dTue3 = listDay[13];
                        dayinmonth.dWed3 = listDay[14];
                        dayinmonth.dThu3 = listDay[15];
                        dayinmonth.dFri3 = listDay[16];
                        dayinmonth.dSat3 = listDay[17];
                        dayinmonth.dSun4 = listDay[18];
                        dayinmonth.dMon4 = listDay[19];
                        dayinmonth.dTue4 = listDay[20];
                        dayinmonth.dWed4 = listDay[21];
                        dayinmonth.dThu4 = listDay[22];
                        dayinmonth.dFri4 = listDay[23];
                        dayinmonth.dSat4 = listDay[24];
                        dayinmonth.dSun5 = listDay[25];
                        dayinmonth.dMon5 = listDay[26];
                        dayinmonth.dTue5 = listDay[27];
                        dayinmonth.dWed5 = listDay[28];
                        dayinmonth.dThu5 = listDay[29];

                    }
                    else if (totaldaymonth == 31)
                    {
                        dayinmonth.dWed1 = listDay[0];
                        dayinmonth.dThu1 = listDay[1];
                        dayinmonth.dFri1 = listDay[2];
                        dayinmonth.dSat1 = listDay[3];
                        dayinmonth.dSun2 = listDay[4];
                        dayinmonth.dMon2 = listDay[5];
                        dayinmonth.dTue2 = listDay[6];
                        dayinmonth.dWed2 = listDay[7];
                        dayinmonth.dThu2 = listDay[8];
                        dayinmonth.dFri2 = listDay[9];
                        dayinmonth.dSat2 = listDay[10];
                        dayinmonth.dSun3 = listDay[11];
                        dayinmonth.dMon3 = listDay[12];
                        dayinmonth.dTue3 = listDay[13];
                        dayinmonth.dWed3 = listDay[14];
                        dayinmonth.dThu3 = listDay[15];
                        dayinmonth.dFri3 = listDay[16];
                        dayinmonth.dSat3 = listDay[17];
                        dayinmonth.dSun4 = listDay[18];
                        dayinmonth.dMon4 = listDay[19];
                        dayinmonth.dTue4 = listDay[20];
                        dayinmonth.dWed4 = listDay[21];
                        dayinmonth.dThu4 = listDay[22];
                        dayinmonth.dFri4 = listDay[23];
                        dayinmonth.dSat4 = listDay[24];
                        dayinmonth.dSun5 = listDay[25];
                        dayinmonth.dMon5 = listDay[26];
                        dayinmonth.dTue5 = listDay[27];
                        dayinmonth.dWed5 = listDay[28];
                        dayinmonth.dThu5 = listDay[29];
                        dayinmonth.dFri5 = listDay[30];

                    }
                    else if (totaldaymonth == 28)
                    {
                        dayinmonth.dWed1 = listDay[0];
                        dayinmonth.dThu1 = listDay[1];
                        dayinmonth.dFri1 = listDay[2];
                        dayinmonth.dSat1 = listDay[3];
                        dayinmonth.dSun2 = listDay[4];
                        dayinmonth.dMon2 = listDay[5];
                        dayinmonth.dTue2 = listDay[6];
                        dayinmonth.dWed2 = listDay[7];
                        dayinmonth.dThu2 = listDay[8];
                        dayinmonth.dFri2 = listDay[9];
                        dayinmonth.dSat2 = listDay[10];
                        dayinmonth.dSun3 = listDay[11];
                        dayinmonth.dMon3 = listDay[12];
                        dayinmonth.dTue3 = listDay[13];
                        dayinmonth.dWed3 = listDay[14];
                        dayinmonth.dThu3 = listDay[15];
                        dayinmonth.dFri3 = listDay[16];
                        dayinmonth.dSat3 = listDay[17];
                        dayinmonth.dSun4 = listDay[18];
                        dayinmonth.dMon4 = listDay[19];
                        dayinmonth.dTue4 = listDay[20];
                        dayinmonth.dWed4 = listDay[21];
                        dayinmonth.dThu4 = listDay[22];
                        dayinmonth.dFri4 = listDay[23];
                        dayinmonth.dSat4 = listDay[24];
                        dayinmonth.dSun5 = listDay[25];
                        dayinmonth.dMon5 = listDay[26];
                        dayinmonth.dTue5 = listDay[27];


                    }
                    else if (totaldaymonth == 29)
                    {
                        dayinmonth.dWed1 = listDay[0];
                        dayinmonth.dThu1 = listDay[1];
                        dayinmonth.dFri1 = listDay[2];
                        dayinmonth.dSat1 = listDay[3];
                        dayinmonth.dSun2 = listDay[4];
                        dayinmonth.dMon2 = listDay[5];
                        dayinmonth.dTue2 = listDay[6];
                        dayinmonth.dWed2 = listDay[7];
                        dayinmonth.dThu2 = listDay[8];
                        dayinmonth.dFri2 = listDay[9];
                        dayinmonth.dSat2 = listDay[10];
                        dayinmonth.dSun3 = listDay[11];
                        dayinmonth.dMon3 = listDay[12];
                        dayinmonth.dTue3 = listDay[13];
                        dayinmonth.dWed3 = listDay[14];
                        dayinmonth.dThu3 = listDay[15];
                        dayinmonth.dFri3 = listDay[16];
                        dayinmonth.dSat3 = listDay[17];
                        dayinmonth.dSun4 = listDay[18];
                        dayinmonth.dMon4 = listDay[19];
                        dayinmonth.dTue4 = listDay[20];
                        dayinmonth.dWed4 = listDay[21];
                        dayinmonth.dThu4 = listDay[22];
                        dayinmonth.dFri4 = listDay[23];
                        dayinmonth.dSat4 = listDay[24];
                        dayinmonth.dSun5 = listDay[25];
                        dayinmonth.dMon5 = listDay[26];
                        dayinmonth.dTue5 = listDay[27];
                        dayinmonth.dWed5 = listDay[28];
                    }

                    break;
                case "Thursday":
                    if (totaldaymonth == 30)
                    {

                        dayinmonth.dThu1 = listDay[0];
                        dayinmonth.dFri1 = listDay[1];
                        dayinmonth.dSat1 = listDay[2];
                        dayinmonth.dSun2 = listDay[3];
                        dayinmonth.dMon2 = listDay[4];
                        dayinmonth.dTue2 = listDay[5];
                        dayinmonth.dWed2 = listDay[6];
                        dayinmonth.dThu2 = listDay[7];
                        dayinmonth.dFri2 = listDay[8];
                        dayinmonth.dSat2 = listDay[9];
                        dayinmonth.dSun3 = listDay[10];
                        dayinmonth.dMon3 = listDay[11];
                        dayinmonth.dTue3 = listDay[12];
                        dayinmonth.dWed3 = listDay[13];
                        dayinmonth.dThu3 = listDay[14];
                        dayinmonth.dFri3 = listDay[15];
                        dayinmonth.dSat3 = listDay[16];
                        dayinmonth.dSun4 = listDay[17];
                        dayinmonth.dMon4 = listDay[18];
                        dayinmonth.dTue4 = listDay[19];
                        dayinmonth.dWed4 = listDay[20];
                        dayinmonth.dThu4 = listDay[21];
                        dayinmonth.dFri4 = listDay[22];
                        dayinmonth.dSat4 = listDay[23];
                        dayinmonth.dSun5 = listDay[24];
                        dayinmonth.dMon5 = listDay[25];
                        dayinmonth.dTue5 = listDay[26];
                        dayinmonth.dWed5 = listDay[27];
                        dayinmonth.dThu5 = listDay[28];
                        dayinmonth.dFri5 = listDay[29];

                    }
                    else if (totaldaymonth == 31)
                    {
                        dayinmonth.dThu1 = listDay[0];
                        dayinmonth.dFri1 = listDay[1];
                        dayinmonth.dSat1 = listDay[2];
                        dayinmonth.dSun2 = listDay[3];
                        dayinmonth.dMon2 = listDay[4];
                        dayinmonth.dTue2 = listDay[5];
                        dayinmonth.dWed2 = listDay[6];
                        dayinmonth.dThu2 = listDay[7];
                        dayinmonth.dFri2 = listDay[8];
                        dayinmonth.dSat2 = listDay[9];
                        dayinmonth.dSun3 = listDay[10];
                        dayinmonth.dMon3 = listDay[11];
                        dayinmonth.dTue3 = listDay[12];
                        dayinmonth.dWed3 = listDay[13];
                        dayinmonth.dThu3 = listDay[14];
                        dayinmonth.dFri3 = listDay[15];
                        dayinmonth.dSat3 = listDay[16];
                        dayinmonth.dSun4 = listDay[17];
                        dayinmonth.dMon4 = listDay[18];
                        dayinmonth.dTue4 = listDay[19];
                        dayinmonth.dWed4 = listDay[20];
                        dayinmonth.dThu4 = listDay[21];
                        dayinmonth.dFri4 = listDay[22];
                        dayinmonth.dSat4 = listDay[23];
                        dayinmonth.dSun5 = listDay[24];
                        dayinmonth.dMon5 = listDay[25];
                        dayinmonth.dTue5 = listDay[26];
                        dayinmonth.dWed5 = listDay[27];
                        dayinmonth.dThu5 = listDay[28];
                        dayinmonth.dFri5 = listDay[29];
                        dayinmonth.dSat5 = listDay[30];

                    }
                    else if (totaldaymonth == 28)
                    {
                        dayinmonth.dThu1 = listDay[0];
                        dayinmonth.dFri1 = listDay[1];
                        dayinmonth.dSat1 = listDay[2];
                        dayinmonth.dSun2 = listDay[3];
                        dayinmonth.dMon2 = listDay[4];
                        dayinmonth.dTue2 = listDay[5];
                        dayinmonth.dWed2 = listDay[6];
                        dayinmonth.dThu2 = listDay[7];
                        dayinmonth.dFri2 = listDay[8];
                        dayinmonth.dSat2 = listDay[9];
                        dayinmonth.dSun3 = listDay[10];
                        dayinmonth.dMon3 = listDay[11];
                        dayinmonth.dTue3 = listDay[12];
                        dayinmonth.dWed3 = listDay[13];
                        dayinmonth.dThu3 = listDay[14];
                        dayinmonth.dFri3 = listDay[15];
                        dayinmonth.dSat3 = listDay[16];
                        dayinmonth.dSun4 = listDay[17];
                        dayinmonth.dMon4 = listDay[18];
                        dayinmonth.dTue4 = listDay[19];
                        dayinmonth.dWed4 = listDay[20];
                        dayinmonth.dThu4 = listDay[21];
                        dayinmonth.dFri4 = listDay[22];
                        dayinmonth.dSat4 = listDay[23];
                        dayinmonth.dSun5 = listDay[24];
                        dayinmonth.dMon5 = listDay[25];
                        dayinmonth.dTue5 = listDay[26];
                        dayinmonth.dWed5 = listDay[27];


                    }
                    else if (totaldaymonth == 29)
                    {
                        dayinmonth.dThu1 = listDay[0];
                        dayinmonth.dFri1 = listDay[1];
                        dayinmonth.dSat1 = listDay[2];
                        dayinmonth.dSun2 = listDay[3];
                        dayinmonth.dMon2 = listDay[4];
                        dayinmonth.dTue2 = listDay[5];
                        dayinmonth.dWed2 = listDay[6];
                        dayinmonth.dThu2 = listDay[7];
                        dayinmonth.dFri2 = listDay[8];
                        dayinmonth.dSat2 = listDay[9];
                        dayinmonth.dSun3 = listDay[10];
                        dayinmonth.dMon3 = listDay[11];
                        dayinmonth.dTue3 = listDay[12];
                        dayinmonth.dWed3 = listDay[13];
                        dayinmonth.dThu3 = listDay[14];
                        dayinmonth.dFri3 = listDay[15];
                        dayinmonth.dSat3 = listDay[16];
                        dayinmonth.dSun4 = listDay[17];
                        dayinmonth.dMon4 = listDay[18];
                        dayinmonth.dTue4 = listDay[19];
                        dayinmonth.dWed4 = listDay[20];
                        dayinmonth.dThu4 = listDay[21];
                        dayinmonth.dFri4 = listDay[22];
                        dayinmonth.dSat4 = listDay[23];
                        dayinmonth.dSun5 = listDay[24];
                        dayinmonth.dMon5 = listDay[25];
                        dayinmonth.dTue5 = listDay[26];
                        dayinmonth.dWed5 = listDay[27];
                        dayinmonth.dThu5 = listDay[28];
                    }


                    break;
                case "Friday":
                    if (totaldaymonth == 30)
                    {
                        dayinmonth.dFri1 = listDay[0];
                        dayinmonth.dSat1 = listDay[1];
                        dayinmonth.dSun2 = listDay[2];
                        dayinmonth.dMon2 = listDay[3];
                        dayinmonth.dTue2 = listDay[4];
                        dayinmonth.dWed2 = listDay[5];
                        dayinmonth.dThu2 = listDay[6];
                        dayinmonth.dFri2 = listDay[7];
                        dayinmonth.dSat2 = listDay[8];
                        dayinmonth.dSun3 = listDay[9];
                        dayinmonth.dMon3 = listDay[10];
                        dayinmonth.dTue3 = listDay[11];
                        dayinmonth.dWed3 = listDay[12];
                        dayinmonth.dThu3 = listDay[13];
                        dayinmonth.dFri3 = listDay[14];
                        dayinmonth.dSat3 = listDay[15];
                        dayinmonth.dSun4 = listDay[16];
                        dayinmonth.dMon4 = listDay[17];
                        dayinmonth.dTue4 = listDay[18];
                        dayinmonth.dWed4 = listDay[19];
                        dayinmonth.dThu4 = listDay[20];
                        dayinmonth.dFri4 = listDay[21];
                        dayinmonth.dSat4 = listDay[22];
                        dayinmonth.dSun5 = listDay[23];
                        dayinmonth.dMon5 = listDay[24];
                        dayinmonth.dTue5 = listDay[25];
                        dayinmonth.dWed5 = listDay[26];
                        dayinmonth.dThu5 = listDay[27];
                        dayinmonth.dFri5 = listDay[28];
                        dayinmonth.dSat5 = listDay[29];

                    }
                    else if (totaldaymonth == 31)
                    {
                        dayinmonth.dFri1 = listDay[0];
                        dayinmonth.dSat1 = listDay[1];
                        dayinmonth.dSun2 = listDay[2];
                        dayinmonth.dMon2 = listDay[3];
                        dayinmonth.dTue2 = listDay[4];
                        dayinmonth.dWed2 = listDay[5];
                        dayinmonth.dThu2 = listDay[6];
                        dayinmonth.dFri2 = listDay[7];
                        dayinmonth.dSat2 = listDay[8];
                        dayinmonth.dSun3 = listDay[9];
                        dayinmonth.dMon3 = listDay[10];
                        dayinmonth.dTue3 = listDay[11];
                        dayinmonth.dWed3 = listDay[12];
                        dayinmonth.dThu3 = listDay[13];
                        dayinmonth.dFri3 = listDay[14];
                        dayinmonth.dSat3 = listDay[15];
                        dayinmonth.dSun4 = listDay[16];
                        dayinmonth.dMon4 = listDay[17];
                        dayinmonth.dTue4 = listDay[18];
                        dayinmonth.dWed4 = listDay[19];
                        dayinmonth.dThu4 = listDay[20];
                        dayinmonth.dFri4 = listDay[21];
                        dayinmonth.dSat4 = listDay[22];
                        dayinmonth.dSun5 = listDay[23];
                        dayinmonth.dMon5 = listDay[24];
                        dayinmonth.dTue5 = listDay[25];
                        dayinmonth.dWed5 = listDay[26];
                        dayinmonth.dThu5 = listDay[27];
                        dayinmonth.dFri5 = listDay[28];
                        dayinmonth.dSat5 = listDay[29];
                        dayinmonth.dSun6 = listDay[30];

                    }
                    else if (totaldaymonth == 28)
                    {
                        dayinmonth.dFri1 = listDay[0];
                        dayinmonth.dSat1 = listDay[1];
                        dayinmonth.dSun2 = listDay[2];
                        dayinmonth.dMon2 = listDay[3];
                        dayinmonth.dTue2 = listDay[4];
                        dayinmonth.dWed2 = listDay[5];
                        dayinmonth.dThu2 = listDay[6];
                        dayinmonth.dFri2 = listDay[7];
                        dayinmonth.dSat2 = listDay[8];
                        dayinmonth.dSun3 = listDay[9];
                        dayinmonth.dMon3 = listDay[10];
                        dayinmonth.dTue3 = listDay[11];
                        dayinmonth.dWed3 = listDay[12];
                        dayinmonth.dThu3 = listDay[13];
                        dayinmonth.dFri3 = listDay[14];
                        dayinmonth.dSat3 = listDay[15];
                        dayinmonth.dSun4 = listDay[16];
                        dayinmonth.dMon4 = listDay[17];
                        dayinmonth.dTue4 = listDay[18];
                        dayinmonth.dWed4 = listDay[19];
                        dayinmonth.dThu4 = listDay[20];
                        dayinmonth.dFri4 = listDay[21];
                        dayinmonth.dSat4 = listDay[22];
                        dayinmonth.dSun5 = listDay[23];
                        dayinmonth.dMon5 = listDay[24];
                        dayinmonth.dTue5 = listDay[25];
                        dayinmonth.dWed5 = listDay[26];
                        dayinmonth.dThu5 = listDay[27];


                    }
                    else if (totaldaymonth == 29)
                    {
                        dayinmonth.dFri1 = listDay[0];
                        dayinmonth.dSat1 = listDay[1];
                        dayinmonth.dSun2 = listDay[2];
                        dayinmonth.dMon2 = listDay[3];
                        dayinmonth.dTue2 = listDay[4];
                        dayinmonth.dWed2 = listDay[5];
                        dayinmonth.dThu2 = listDay[6];
                        dayinmonth.dFri2 = listDay[7];
                        dayinmonth.dSat2 = listDay[8];
                        dayinmonth.dSun3 = listDay[9];
                        dayinmonth.dMon3 = listDay[10];
                        dayinmonth.dTue3 = listDay[11];
                        dayinmonth.dWed3 = listDay[12];
                        dayinmonth.dThu3 = listDay[13];
                        dayinmonth.dFri3 = listDay[14];
                        dayinmonth.dSat3 = listDay[15];
                        dayinmonth.dSun4 = listDay[16];
                        dayinmonth.dMon4 = listDay[17];
                        dayinmonth.dTue4 = listDay[18];
                        dayinmonth.dWed4 = listDay[19];
                        dayinmonth.dThu4 = listDay[20];
                        dayinmonth.dFri4 = listDay[21];
                        dayinmonth.dSat4 = listDay[22];
                        dayinmonth.dSun5 = listDay[23];
                        dayinmonth.dMon5 = listDay[24];
                        dayinmonth.dTue5 = listDay[25];
                        dayinmonth.dWed5 = listDay[26];
                        dayinmonth.dThu5 = listDay[27];
                        dayinmonth.dFri5 = listDay[28];
                    }


                    break;
                case "Saturday":
                    if (totaldaymonth == 30)
                    {

                        dayinmonth.dSat1 = listDay[0];
                        dayinmonth.dSun2 = listDay[1];
                        dayinmonth.dMon2 = listDay[2];
                        dayinmonth.dTue2 = listDay[3];
                        dayinmonth.dWed2 = listDay[4];
                        dayinmonth.dThu2 = listDay[5];
                        dayinmonth.dFri2 = listDay[6];
                        dayinmonth.dSat2 = listDay[7];
                        dayinmonth.dSun3 = listDay[8];
                        dayinmonth.dMon3 = listDay[9];
                        dayinmonth.dTue3 = listDay[10];
                        dayinmonth.dWed3 = listDay[11];
                        dayinmonth.dThu3 = listDay[12];
                        dayinmonth.dFri3 = listDay[13];
                        dayinmonth.dSat3 = listDay[14];
                        dayinmonth.dSun4 = listDay[15];
                        dayinmonth.dMon4 = listDay[16];
                        dayinmonth.dTue4 = listDay[17];
                        dayinmonth.dWed4 = listDay[18];
                        dayinmonth.dThu4 = listDay[19];
                        dayinmonth.dFri4 = listDay[20];
                        dayinmonth.dSat4 = listDay[21];
                        dayinmonth.dSun5 = listDay[22];
                        dayinmonth.dMon5 = listDay[23];
                        dayinmonth.dTue5 = listDay[24];
                        dayinmonth.dWed5 = listDay[25];
                        dayinmonth.dThu5 = listDay[26];
                        dayinmonth.dFri5 = listDay[27];
                        dayinmonth.dSat5 = listDay[28];
                        dayinmonth.dSun6 = listDay[29];

                    }
                    else if (totaldaymonth == 31)
                    {
                        dayinmonth.dSat1 = listDay[0];
                        dayinmonth.dSun2 = listDay[1];
                        dayinmonth.dMon2 = listDay[2];
                        dayinmonth.dTue2 = listDay[3];
                        dayinmonth.dWed2 = listDay[4];
                        dayinmonth.dThu2 = listDay[5];
                        dayinmonth.dFri2 = listDay[6];
                        dayinmonth.dSat2 = listDay[7];
                        dayinmonth.dSun3 = listDay[8];
                        dayinmonth.dMon3 = listDay[9];
                        dayinmonth.dTue3 = listDay[10];
                        dayinmonth.dWed3 = listDay[11];
                        dayinmonth.dThu3 = listDay[12];
                        dayinmonth.dFri3 = listDay[13];
                        dayinmonth.dSat3 = listDay[14];
                        dayinmonth.dSun4 = listDay[15];
                        dayinmonth.dMon4 = listDay[16];
                        dayinmonth.dTue4 = listDay[17];
                        dayinmonth.dWed4 = listDay[18];
                        dayinmonth.dThu4 = listDay[19];
                        dayinmonth.dFri4 = listDay[20];
                        dayinmonth.dSat4 = listDay[21];
                        dayinmonth.dSun5 = listDay[22];
                        dayinmonth.dMon5 = listDay[23];
                        dayinmonth.dTue5 = listDay[24];
                        dayinmonth.dWed5 = listDay[25];
                        dayinmonth.dThu5 = listDay[26];
                        dayinmonth.dFri5 = listDay[27];
                        dayinmonth.dSat5 = listDay[28];
                        dayinmonth.dSun6 = listDay[29];
                        dayinmonth.dMon6 = listDay[30];

                    }
                    else if (totaldaymonth == 28)
                    {
                        dayinmonth.dSat1 = listDay[0];
                        dayinmonth.dSun2 = listDay[1];
                        dayinmonth.dMon2 = listDay[2];
                        dayinmonth.dTue2 = listDay[3];
                        dayinmonth.dWed2 = listDay[4];
                        dayinmonth.dThu2 = listDay[5];
                        dayinmonth.dFri2 = listDay[6];
                        dayinmonth.dSat2 = listDay[7];
                        dayinmonth.dSun3 = listDay[8];
                        dayinmonth.dMon3 = listDay[9];
                        dayinmonth.dTue3 = listDay[10];
                        dayinmonth.dWed3 = listDay[11];
                        dayinmonth.dThu3 = listDay[12];
                        dayinmonth.dFri3 = listDay[13];
                        dayinmonth.dSat3 = listDay[14];
                        dayinmonth.dSun4 = listDay[15];
                        dayinmonth.dMon4 = listDay[16];
                        dayinmonth.dTue4 = listDay[17];
                        dayinmonth.dWed4 = listDay[18];
                        dayinmonth.dThu4 = listDay[19];
                        dayinmonth.dFri4 = listDay[20];
                        dayinmonth.dSat4 = listDay[21];
                        dayinmonth.dSun5 = listDay[22];
                        dayinmonth.dMon5 = listDay[23];
                        dayinmonth.dTue5 = listDay[24];
                        dayinmonth.dWed5 = listDay[25];
                        dayinmonth.dThu5 = listDay[26];
                        dayinmonth.dFri5 = listDay[27];


                    }
                    else if (totaldaymonth == 29)
                    {
                        dayinmonth.dSat1 = listDay[0];
                        dayinmonth.dSun2 = listDay[1];
                        dayinmonth.dMon2 = listDay[2];
                        dayinmonth.dTue2 = listDay[3];
                        dayinmonth.dWed2 = listDay[4];
                        dayinmonth.dThu2 = listDay[5];
                        dayinmonth.dFri2 = listDay[6];
                        dayinmonth.dSat2 = listDay[7];
                        dayinmonth.dSun3 = listDay[8];
                        dayinmonth.dMon3 = listDay[9];
                        dayinmonth.dTue3 = listDay[10];
                        dayinmonth.dWed3 = listDay[11];
                        dayinmonth.dThu3 = listDay[12];
                        dayinmonth.dFri3 = listDay[13];
                        dayinmonth.dSat3 = listDay[14];
                        dayinmonth.dSun4 = listDay[15];
                        dayinmonth.dMon4 = listDay[16];
                        dayinmonth.dTue4 = listDay[17];
                        dayinmonth.dWed4 = listDay[18];
                        dayinmonth.dThu4 = listDay[19];
                        dayinmonth.dFri4 = listDay[20];
                        dayinmonth.dSat4 = listDay[21];
                        dayinmonth.dSun5 = listDay[22];
                        dayinmonth.dMon5 = listDay[23];
                        dayinmonth.dTue5 = listDay[24];
                        dayinmonth.dWed5 = listDay[25];
                        dayinmonth.dThu5 = listDay[26];
                        dayinmonth.dFri5 = listDay[27];
                        dayinmonth.dSat5 = listDay[28];
                    }


                    break;
            }


            return dayinmonth;

        }


        public static DayinMonth NextPreMonth(string month, string year)
        {


            int months = (month == "January") ? 1 : (month == "February")
                ? 2 : (month == "March") ? 3 : (month == "April") ? 4 : (month == "May") ? 5 : (month == "June")
                ? 6 : (month == "July") ? 7 : (month == "August") ? 8 : (month == "September") ? 9 : (month == "October")
                ? 10 : (month == "November") ? 11 : (month == "December") ? 12 : 0;

            DayinMonth dnextpre = new DayinMonth();

            if (months != 0)
            {
                string dateStr = months.ToString() + "/" + 1 + "/" + year;
                DateTime datetime = DateTime.Parse(dateStr);

                int totalday = DateTime.DaysInMonth(datetime.Year, datetime.Month);
                string daynext = datetime.DayOfWeek.ToString();
                List<string> nd = new List<string>();
                for (int i = 1; i <= totalday; i++)
                {
                    nd.Add(i.ToString());
                }
                //Before
                DayinMonth before = CalendarCus.dbefore(datetime);
                //After
                DayinMonth after = CalendarCus.dafter(datetime);

                switch (daynext)
                {
                    case "Sunday":
                        if (totalday == 31)
                        {
                            //Before

                            //Center
                            dnextpre.dSun1 = nd[0];
                            dnextpre.dMon1 = nd[1];
                            dnextpre.dTue1 = nd[2];
                            dnextpre.dWed1 = nd[3];
                            dnextpre.dThu1 = nd[4];
                            dnextpre.dFri1 = nd[5];
                            dnextpre.dSat1 = nd[6];
                            //2
                            dnextpre.dSun2 = nd[7];
                            dnextpre.dMon2 = nd[8];
                            dnextpre.dTue2 = nd[9];
                            dnextpre.dWed2 = nd[10];
                            dnextpre.dThu2 = nd[11];
                            dnextpre.dFri2 = nd[12];
                            dnextpre.dSat2 = nd[13];
                            //3
                            dnextpre.dSun3 = nd[14];
                            dnextpre.dMon3 = nd[15];
                            dnextpre.dTue3 = nd[16];
                            dnextpre.dWed3 = nd[17];
                            dnextpre.dThu3 = nd[18];
                            dnextpre.dFri3 = nd[19];
                            dnextpre.dSat3 = nd[20];
                            //4
                            dnextpre.dSun4 = nd[21];
                            dnextpre.dMon4 = nd[22];
                            dnextpre.dTue4 = nd[23];
                            dnextpre.dWed4 = nd[24];
                            dnextpre.dThu4 = nd[25];
                            dnextpre.dFri4 = nd[26];
                            dnextpre.dSat4 = nd[27];
                            //5
                            dnextpre.dSun5 = nd[28];
                            dnextpre.dMon5 = nd[29];
                            dnextpre.dTue5 = nd[30];
                            //After
                            dnextpre.dWed5 = after.dWed5;
                            dnextpre.dThu5 = after.dThu5;
                            dnextpre.dFri5 = after.dFri5;
                            dnextpre.dSat5 = after.dSat5;
                            dnextpre.dSun6 = after.dSun6;
                            dnextpre.dMon6 = after.dMon6;
                            dnextpre.dTue6 = after.dTue6;
                            dnextpre.dWed6 = after.dWed6;
                            dnextpre.dThu6 = after.dThu6;
                            dnextpre.dFri6 = after.dFri6;
                            dnextpre.dSat6 = after.dSat6;

                        }
                        else if (totalday == 30)
                        {
                            dnextpre.dSun1 = nd[0];
                            dnextpre.dMon1 = nd[1];
                            dnextpre.dTue1 = nd[2];
                            dnextpre.dWed1 = nd[3];
                            dnextpre.dThu1 = nd[4];
                            dnextpre.dFri1 = nd[5];
                            dnextpre.dSat1 = nd[6];
                            //2
                            dnextpre.dSun2 = nd[7];
                            dnextpre.dMon2 = nd[8];
                            dnextpre.dTue2 = nd[9];
                            dnextpre.dWed2 = nd[10];
                            dnextpre.dThu2 = nd[11];
                            dnextpre.dFri2 = nd[12];
                            dnextpre.dSat2 = nd[13];
                            //3
                            dnextpre.dSun3 = nd[14];
                            dnextpre.dMon3 = nd[15];
                            dnextpre.dTue3 = nd[16];
                            dnextpre.dWed3 = nd[17];
                            dnextpre.dThu3 = nd[18];
                            dnextpre.dFri3 = nd[19];
                            dnextpre.dSat3 = nd[20];
                            //4
                            dnextpre.dSun4 = nd[21];
                            dnextpre.dMon4 = nd[22];
                            dnextpre.dTue4 = nd[23];
                            dnextpre.dWed4 = nd[24];
                            dnextpre.dThu4 = nd[25];
                            dnextpre.dFri4 = nd[26];
                            dnextpre.dSat4 = nd[27];
                            //5
                            dnextpre.dSun5 = nd[28];
                            dnextpre.dMon5 = nd[29];
                            //After
                            dnextpre.dTue5 = after.dTue5;
                            dnextpre.dWed5 = after.dWed5;
                            dnextpre.dThu5 = after.dThu5;
                            dnextpre.dFri5 = after.dFri5;
                            dnextpre.dSat5 = after.dSat5;
                            dnextpre.dSun6 = after.dSun6;
                            dnextpre.dMon6 = after.dMon6;
                            dnextpre.dTue6 = after.dTue6;
                            dnextpre.dWed6 = after.dWed6;
                            dnextpre.dThu6 = after.dThu6;
                            dnextpre.dFri6 = after.dFri6;
                            dnextpre.dSat6 = after.dSat6;
                        }
                        else if (totalday == 29)
                        {
                            dnextpre.dSun1 = nd[0];
                            dnextpre.dMon1 = nd[1];
                            dnextpre.dTue1 = nd[2];
                            dnextpre.dWed1 = nd[3];
                            dnextpre.dThu1 = nd[4];
                            dnextpre.dFri1 = nd[5];
                            dnextpre.dSat1 = nd[6];
                            //2
                            dnextpre.dSun2 = nd[7];
                            dnextpre.dMon2 = nd[8];
                            dnextpre.dTue2 = nd[9];
                            dnextpre.dWed2 = nd[10];
                            dnextpre.dThu2 = nd[11];
                            dnextpre.dFri2 = nd[12];
                            dnextpre.dSat2 = nd[13];
                            //3
                            dnextpre.dSun3 = nd[14];
                            dnextpre.dMon3 = nd[15];
                            dnextpre.dTue3 = nd[16];
                            dnextpre.dWed3 = nd[17];
                            dnextpre.dThu3 = nd[18];
                            dnextpre.dFri3 = nd[19];
                            dnextpre.dSat3 = nd[20];
                            //4
                            dnextpre.dSun4 = nd[21];
                            dnextpre.dMon4 = nd[22];
                            dnextpre.dTue4 = nd[23];
                            dnextpre.dWed4 = nd[24];
                            dnextpre.dThu4 = nd[25];
                            dnextpre.dFri4 = nd[26];
                            dnextpre.dSat4 = nd[27];
                            //5
                            dnextpre.dSun5 = nd[28];
                            //After
                            dnextpre.dMon5 = after.dMon5;
                            dnextpre.dTue5 = after.dTue5;
                            dnextpre.dWed5 = after.dWed5;
                            dnextpre.dThu5 = after.dThu5;
                            dnextpre.dFri5 = after.dFri5;
                            dnextpre.dSat5 = after.dSat5;
                            dnextpre.dSun6 = after.dSun6;
                            dnextpre.dMon6 = after.dMon6;
                            dnextpre.dTue6 = after.dTue6;
                            dnextpre.dWed6 = after.dWed6;
                            dnextpre.dThu6 = after.dThu6;
                            dnextpre.dFri6 = after.dFri6;
                            dnextpre.dSat6 = after.dSat6;
                        }
                        else if (totalday == 28)
                        {
                            dnextpre.dSun1 = nd[0];
                            dnextpre.dMon1 = nd[1];
                            dnextpre.dTue1 = nd[2];
                            dnextpre.dWed1 = nd[3];
                            dnextpre.dThu1 = nd[4];
                            dnextpre.dFri1 = nd[5];
                            dnextpre.dSat1 = nd[6];
                            //2
                            dnextpre.dSun2 = nd[7];
                            dnextpre.dMon2 = nd[8];
                            dnextpre.dTue2 = nd[9];
                            dnextpre.dWed2 = nd[10];
                            dnextpre.dThu2 = nd[11];
                            dnextpre.dFri2 = nd[12];
                            dnextpre.dSat2 = nd[13];
                            //3
                            dnextpre.dSun3 = nd[14];
                            dnextpre.dMon3 = nd[15];
                            dnextpre.dTue3 = nd[16];
                            dnextpre.dWed3 = nd[17];
                            dnextpre.dThu3 = nd[18];
                            dnextpre.dFri3 = nd[19];
                            dnextpre.dSat3 = nd[20];
                            //4
                            dnextpre.dSun4 = nd[21];
                            dnextpre.dMon4 = nd[22];
                            dnextpre.dTue4 = nd[23];
                            dnextpre.dWed4 = nd[24];
                            dnextpre.dThu4 = nd[25];
                            dnextpre.dFri4 = nd[26];
                            dnextpre.dSat4 = nd[27];
                            //After
                            dnextpre.dSun5 = after.dSun5;
                            dnextpre.dMon5 = after.dMon5;
                            dnextpre.dTue5 = after.dTue5;
                            dnextpre.dWed5 = after.dWed5;
                            dnextpre.dThu5 = after.dThu5;
                            dnextpre.dFri5 = after.dFri5;
                            dnextpre.dSat5 = after.dSat5;
                            dnextpre.dSun6 = after.dSun6;
                            dnextpre.dMon6 = after.dMon6;
                            dnextpre.dTue6 = after.dTue6;
                            dnextpre.dWed6 = after.dWed6;
                            dnextpre.dThu6 = after.dThu6;
                            dnextpre.dFri6 = after.dFri6;
                            dnextpre.dSat6 = after.dSat6;
                        }

                        break;
                    case "Monday":
                        if (totalday == 31)
                        {
                            //Before
                            dnextpre.dSun1 = before.dSun1;
                            //Center
                            dnextpre.dMon1 = nd[0];
                            dnextpre.dTue1 = nd[1];
                            dnextpre.dWed1 = nd[2];
                            dnextpre.dThu1 = nd[3];
                            dnextpre.dFri1 = nd[4];
                            dnextpre.dSat1 = nd[5];
                            //2
                            dnextpre.dSun2 = nd[6];
                            dnextpre.dMon2 = nd[7];
                            dnextpre.dTue2 = nd[8];
                            dnextpre.dWed2 = nd[9];
                            dnextpre.dThu2 = nd[10];
                            dnextpre.dFri2 = nd[11];
                            dnextpre.dSat2 = nd[12];
                            //3
                            dnextpre.dSun3 = nd[13];
                            dnextpre.dMon3 = nd[14];
                            dnextpre.dTue3 = nd[15];
                            dnextpre.dWed3 = nd[16];
                            dnextpre.dThu3 = nd[17];
                            dnextpre.dFri3 = nd[18];
                            dnextpre.dSat3 = nd[19];
                            //4
                            dnextpre.dSun4 = nd[20];
                            dnextpre.dMon4 = nd[21];
                            dnextpre.dTue4 = nd[22];
                            dnextpre.dWed4 = nd[23];
                            dnextpre.dThu4 = nd[24];
                            dnextpre.dFri4 = nd[25];
                            dnextpre.dSat4 = nd[26];
                            //5
                            dnextpre.dSun5 = nd[27];
                            dnextpre.dMon5 = nd[28];
                            dnextpre.dTue5 = nd[29];
                            dnextpre.dWed5 = nd[30];
                            //After
                            dnextpre.dThu5 = after.dThu5;
                            dnextpre.dFri5 = after.dFri5;
                            dnextpre.dSat5 = after.dSat5;
                            dnextpre.dSun6 = after.dSun6;
                            dnextpre.dMon6 = after.dMon6;
                            dnextpre.dTue6 = after.dTue6;
                            dnextpre.dWed6 = after.dWed6;
                            dnextpre.dThu6 = after.dThu6;
                            dnextpre.dFri6 = after.dFri6;
                            dnextpre.dSat6 = after.dSat6;

                        }
                        else if (totalday == 30)
                        {
                            //Before
                            dnextpre.dSun1 = before.dSun1;
                            //Center
                            dnextpre.dMon1 = nd[0];
                            dnextpre.dTue1 = nd[1];
                            dnextpre.dWed1 = nd[2];
                            dnextpre.dThu1 = nd[3];
                            dnextpre.dFri1 = nd[4];
                            dnextpre.dSat1 = nd[5];
                            //2
                            dnextpre.dSun2 = nd[6];
                            dnextpre.dMon2 = nd[7];
                            dnextpre.dTue2 = nd[8];
                            dnextpre.dWed2 = nd[9];
                            dnextpre.dThu2 = nd[10];
                            dnextpre.dFri2 = nd[11];
                            dnextpre.dSat2 = nd[12];
                            //3
                            dnextpre.dSun3 = nd[13];
                            dnextpre.dMon3 = nd[14];
                            dnextpre.dTue3 = nd[15];
                            dnextpre.dWed3 = nd[16];
                            dnextpre.dThu3 = nd[17];
                            dnextpre.dFri3 = nd[18];
                            dnextpre.dSat3 = nd[19];
                            //4
                            dnextpre.dSun4 = nd[20];
                            dnextpre.dMon4 = nd[21];
                            dnextpre.dTue4 = nd[22];
                            dnextpre.dWed4 = nd[23];
                            dnextpre.dThu4 = nd[24];
                            dnextpre.dFri4 = nd[25];
                            dnextpre.dSat4 = nd[26];
                            //5
                            dnextpre.dSun5 = nd[27];
                            dnextpre.dMon5 = nd[28];
                            dnextpre.dTue5 = nd[29];
                            //After
                            dnextpre.dWed5 = after.dWed5;
                            dnextpre.dThu5 = after.dThu5;
                            dnextpre.dFri5 = after.dFri5;
                            dnextpre.dSat5 = after.dSat5;
                            dnextpre.dSun6 = after.dSun6;
                            dnextpre.dMon6 = after.dMon6;
                            dnextpre.dTue6 = after.dTue6;
                            dnextpre.dWed6 = after.dWed6;
                            dnextpre.dThu6 = after.dThu6;
                            dnextpre.dFri6 = after.dFri6;
                            dnextpre.dSat6 = after.dSat6;
                        }
                        else if (totalday == 29)
                        {
                            //Before
                            dnextpre.dSun1 = before.dSun1;
                            //Center
                            dnextpre.dMon1 = nd[0];
                            dnextpre.dTue1 = nd[1];
                            dnextpre.dWed1 = nd[2];
                            dnextpre.dThu1 = nd[3];
                            dnextpre.dFri1 = nd[4];
                            dnextpre.dSat1 = nd[5];
                            //2
                            dnextpre.dSun2 = nd[6];
                            dnextpre.dMon2 = nd[7];
                            dnextpre.dTue2 = nd[8];
                            dnextpre.dWed2 = nd[9];
                            dnextpre.dThu2 = nd[10];
                            dnextpre.dFri2 = nd[11];
                            dnextpre.dSat2 = nd[12];
                            //3
                            dnextpre.dSun3 = nd[13];
                            dnextpre.dMon3 = nd[14];
                            dnextpre.dTue3 = nd[15];
                            dnextpre.dWed3 = nd[16];
                            dnextpre.dThu3 = nd[17];
                            dnextpre.dFri3 = nd[18];
                            dnextpre.dSat3 = nd[19];
                            //4
                            dnextpre.dSun4 = nd[20];
                            dnextpre.dMon4 = nd[21];
                            dnextpre.dTue4 = nd[22];
                            dnextpre.dWed4 = nd[23];
                            dnextpre.dThu4 = nd[24];
                            dnextpre.dFri4 = nd[25];
                            dnextpre.dSat4 = nd[26];
                            //5
                            dnextpre.dSun5 = nd[27];
                            dnextpre.dMon5 = nd[28];
                            //After
                            dnextpre.dTue5 = after.dTue5;
                            dnextpre.dWed5 = after.dWed5;
                            dnextpre.dThu5 = after.dThu5;
                            dnextpre.dFri5 = after.dFri5;
                            dnextpre.dSat5 = after.dSat5;
                            dnextpre.dSun6 = after.dSun6;
                            dnextpre.dMon6 = after.dMon6;
                            dnextpre.dTue6 = after.dTue6;
                            dnextpre.dWed6 = after.dWed6;
                            dnextpre.dThu6 = after.dThu6;
                            dnextpre.dFri6 = after.dFri6;
                            dnextpre.dSat6 = after.dSat6;
                        }
                        else if (totalday == 28)
                        {
                            //Before
                            dnextpre.dSun1 = before.dSun1;
                            //Center
                            dnextpre.dMon1 = nd[0];
                            dnextpre.dTue1 = nd[1];
                            dnextpre.dWed1 = nd[2];
                            dnextpre.dThu1 = nd[3];
                            dnextpre.dFri1 = nd[4];
                            dnextpre.dSat1 = nd[5];
                            //2
                            dnextpre.dSun2 = nd[6];
                            dnextpre.dMon2 = nd[7];
                            dnextpre.dTue2 = nd[8];
                            dnextpre.dWed2 = nd[9];
                            dnextpre.dThu2 = nd[10];
                            dnextpre.dFri2 = nd[11];
                            dnextpre.dSat2 = nd[12];
                            //3
                            dnextpre.dSun3 = nd[13];
                            dnextpre.dMon3 = nd[14];
                            dnextpre.dTue3 = nd[15];
                            dnextpre.dWed3 = nd[16];
                            dnextpre.dThu3 = nd[17];
                            dnextpre.dFri3 = nd[18];
                            dnextpre.dSat3 = nd[19];
                            //4
                            dnextpre.dSun4 = nd[20];
                            dnextpre.dMon4 = nd[21];
                            dnextpre.dTue4 = nd[22];
                            dnextpre.dWed4 = nd[23];
                            dnextpre.dThu4 = nd[24];
                            dnextpre.dFri4 = nd[25];
                            dnextpre.dSat4 = nd[26];
                            //5
                            dnextpre.dSun5 = nd[27];
                            //After
                            dnextpre.dMon5 = after.dMon5;
                            dnextpre.dTue5 = after.dTue5;
                            dnextpre.dWed5 = after.dWed5;
                            dnextpre.dThu5 = after.dThu5;
                            dnextpre.dFri5 = after.dFri5;
                            dnextpre.dSat5 = after.dSat5;
                            dnextpre.dSun6 = after.dSun6;
                            dnextpre.dMon6 = after.dMon6;
                            dnextpre.dTue6 = after.dTue6;
                            dnextpre.dWed6 = after.dWed6;
                            dnextpre.dThu6 = after.dThu6;
                            dnextpre.dFri6 = after.dFri6;
                            dnextpre.dSat6 = after.dSat6;


                        }
                        break;
                    case "Tuesday":
                        if (totalday == 31)
                        {
                            //Before
                            dnextpre.dSun1 = before.dSun1;
                            dnextpre.dMon1 = before.dMon1;
                            //Center
                            dnextpre.dTue1 = nd[0];
                            dnextpre.dWed1 = nd[1];
                            dnextpre.dThu1 = nd[2];
                            dnextpre.dFri1 = nd[3];
                            dnextpre.dSat1 = nd[4];
                            //2
                            dnextpre.dSun2 = nd[5];
                            dnextpre.dMon2 = nd[6];
                            dnextpre.dTue2 = nd[7];
                            dnextpre.dWed2 = nd[8];
                            dnextpre.dThu2 = nd[9];
                            dnextpre.dFri2 = nd[10];
                            dnextpre.dSat2 = nd[11];
                            //3
                            dnextpre.dSun3 = nd[12];
                            dnextpre.dMon3 = nd[13];
                            dnextpre.dTue3 = nd[14];
                            dnextpre.dWed3 = nd[15];
                            dnextpre.dThu3 = nd[16];
                            dnextpre.dFri3 = nd[17];
                            dnextpre.dSat3 = nd[18];
                            //4
                            dnextpre.dSun4 = nd[19];
                            dnextpre.dMon4 = nd[20];
                            dnextpre.dTue4 = nd[21];
                            dnextpre.dWed4 = nd[22];
                            dnextpre.dThu4 = nd[23];
                            dnextpre.dFri4 = nd[24];
                            dnextpre.dSat4 = nd[25];
                            //5
                            dnextpre.dSun5 = nd[26];
                            dnextpre.dMon5 = nd[27];
                            dnextpre.dTue5 = nd[28];
                            dnextpre.dWed5 = nd[29];
                            dnextpre.dThu5 = nd[30];
                            //After
                            dnextpre.dFri5 = after.dFri5;
                            dnextpre.dSat5 = after.dSat5;
                            dnextpre.dSun6 = after.dSun6;
                            dnextpre.dMon6 = after.dMon6;
                            dnextpre.dTue6 = after.dTue6;
                            dnextpre.dWed6 = after.dWed6;
                            dnextpre.dThu6 = after.dThu6;
                            dnextpre.dFri6 = after.dFri6;
                            dnextpre.dSat6 = after.dSat6;
                        }
                        else if (totalday == 30)
                        {
                            //Before
                            dnextpre.dSun1 = before.dSun1;
                            dnextpre.dMon1 = before.dMon1;
                            //Center
                            dnextpre.dTue1 = nd[0];
                            dnextpre.dWed1 = nd[1];
                            dnextpre.dThu1 = nd[2];
                            dnextpre.dFri1 = nd[3];
                            dnextpre.dSat1 = nd[4];
                            //2
                            dnextpre.dSun2 = nd[5];
                            dnextpre.dMon2 = nd[6];
                            dnextpre.dTue2 = nd[7];
                            dnextpre.dWed2 = nd[8];
                            dnextpre.dThu2 = nd[9];
                            dnextpre.dFri2 = nd[10];
                            dnextpre.dSat2 = nd[11];
                            //3
                            dnextpre.dSun3 = nd[12];
                            dnextpre.dMon3 = nd[13];
                            dnextpre.dTue3 = nd[14];
                            dnextpre.dWed3 = nd[15];
                            dnextpre.dThu3 = nd[16];
                            dnextpre.dFri3 = nd[17];
                            dnextpre.dSat3 = nd[18];
                            //4
                            dnextpre.dSun4 = nd[19];
                            dnextpre.dMon4 = nd[20];
                            dnextpre.dTue4 = nd[21];
                            dnextpre.dWed4 = nd[22];
                            dnextpre.dThu4 = nd[23];
                            dnextpre.dFri4 = nd[24];
                            dnextpre.dSat4 = nd[25];
                            //5
                            dnextpre.dSun5 = nd[26];
                            dnextpre.dMon5 = nd[27];
                            dnextpre.dTue5 = nd[28];
                            dnextpre.dWed5 = nd[29];
                            //After
                            dnextpre.dThu5 = after.dThu5;
                            dnextpre.dFri5 = after.dFri5;
                            dnextpre.dSat5 = after.dSat5;
                            dnextpre.dSun6 = after.dSun6;
                            dnextpre.dMon6 = after.dMon6;
                            dnextpre.dTue6 = after.dTue6;
                            dnextpre.dWed6 = after.dWed6;
                            dnextpre.dThu6 = after.dThu6;
                            dnextpre.dFri6 = after.dFri6;
                            dnextpre.dSat6 = after.dSat6;
                        }
                        else if (totalday == 29)
                        {
                            //Before
                            dnextpre.dSun1 = before.dSun1;
                            dnextpre.dMon1 = before.dMon1;
                            //Center
                            dnextpre.dTue1 = nd[0];
                            dnextpre.dWed1 = nd[1];
                            dnextpre.dThu1 = nd[2];
                            dnextpre.dFri1 = nd[3];
                            dnextpre.dSat1 = nd[4];
                            //2
                            dnextpre.dSun2 = nd[5];
                            dnextpre.dMon2 = nd[6];
                            dnextpre.dTue2 = nd[7];
                            dnextpre.dWed2 = nd[8];
                            dnextpre.dThu2 = nd[9];
                            dnextpre.dFri2 = nd[10];
                            dnextpre.dSat2 = nd[11];
                            //3
                            dnextpre.dSun3 = nd[12];
                            dnextpre.dMon3 = nd[13];
                            dnextpre.dTue3 = nd[14];
                            dnextpre.dWed3 = nd[15];
                            dnextpre.dThu3 = nd[16];
                            dnextpre.dFri3 = nd[17];
                            dnextpre.dSat3 = nd[18];
                            //4
                            dnextpre.dSun4 = nd[19];
                            dnextpre.dMon4 = nd[20];
                            dnextpre.dTue4 = nd[21];
                            dnextpre.dWed4 = nd[22];
                            dnextpre.dThu4 = nd[23];
                            dnextpre.dFri4 = nd[24];
                            dnextpre.dSat4 = nd[25];
                            //5
                            dnextpre.dSun5 = nd[26];
                            dnextpre.dMon5 = nd[27];
                            dnextpre.dTue5 = nd[28];
                            //After
                            dnextpre.dWed5 = after.dWed5;
                            dnextpre.dThu5 = after.dThu5;
                            dnextpre.dFri5 = after.dFri5;
                            dnextpre.dSat5 = after.dSat5;
                            dnextpre.dSun6 = after.dSun6;
                            dnextpre.dMon6 = after.dMon6;
                            dnextpre.dTue6 = after.dTue6;
                            dnextpre.dWed6 = after.dWed6;
                            dnextpre.dThu6 = after.dThu6;
                            dnextpre.dFri6 = after.dFri6;
                            dnextpre.dSat6 = after.dSat6;
                        }
                        else if (totalday == 28)
                        {
                            //Before
                            dnextpre.dSun1 = before.dSun1;
                            dnextpre.dMon1 = before.dMon1;
                            //Center
                            dnextpre.dTue1 = nd[0];
                            dnextpre.dWed1 = nd[1];
                            dnextpre.dThu1 = nd[2];
                            dnextpre.dFri1 = nd[3];
                            dnextpre.dSat1 = nd[4];
                            //2
                            dnextpre.dSun2 = nd[5];
                            dnextpre.dMon2 = nd[6];
                            dnextpre.dTue2 = nd[7];
                            dnextpre.dWed2 = nd[8];
                            dnextpre.dThu2 = nd[9];
                            dnextpre.dFri2 = nd[10];
                            dnextpre.dSat2 = nd[11];
                            //3
                            dnextpre.dSun3 = nd[12];
                            dnextpre.dMon3 = nd[13];
                            dnextpre.dTue3 = nd[14];
                            dnextpre.dWed3 = nd[15];
                            dnextpre.dThu3 = nd[16];
                            dnextpre.dFri3 = nd[17];
                            dnextpre.dSat3 = nd[18];
                            //4
                            dnextpre.dSun4 = nd[19];
                            dnextpre.dMon4 = nd[20];
                            dnextpre.dTue4 = nd[21];
                            dnextpre.dWed4 = nd[22];
                            dnextpre.dThu4 = nd[23];
                            dnextpre.dFri4 = nd[24];
                            dnextpre.dSat4 = nd[25];
                            //5
                            dnextpre.dSun5 = nd[26];
                            dnextpre.dMon5 = nd[27];
                            //After
                            dnextpre.dTue5 = after.dTue5;
                            dnextpre.dWed5 = after.dWed5;
                            dnextpre.dThu5 = after.dThu5;
                            dnextpre.dFri5 = after.dFri5;
                            dnextpre.dSat5 = after.dSat5;
                            dnextpre.dSun6 = after.dSun6;
                            dnextpre.dMon6 = after.dMon6;
                            dnextpre.dTue6 = after.dTue6;
                            dnextpre.dWed6 = after.dWed6;
                            dnextpre.dThu6 = after.dThu6;
                            dnextpre.dFri6 = after.dFri6;
                            dnextpre.dSat6 = after.dSat6;
                        }
                        break;
                    case "Wednesday":
                        if (totalday == 31)
                        {
                            //Before
                            dnextpre.dSun1 = before.dSun1;
                            dnextpre.dMon1 = before.dMon1;
                            dnextpre.dTue1 = before.dTue1;
                            //Center
                            dnextpre.dWed1 = nd[0];
                            dnextpre.dThu1 = nd[1];
                            dnextpre.dFri1 = nd[2];
                            dnextpre.dSat1 = nd[3];
                            //2
                            dnextpre.dSun2 = nd[4];
                            dnextpre.dMon2 = nd[5];
                            dnextpre.dTue2 = nd[6];
                            dnextpre.dWed2 = nd[7];
                            dnextpre.dThu2 = nd[8];
                            dnextpre.dFri2 = nd[9];
                            dnextpre.dSat2 = nd[10];
                            //3
                            dnextpre.dSun3 = nd[11];
                            dnextpre.dMon3 = nd[12];
                            dnextpre.dTue3 = nd[13];
                            dnextpre.dWed3 = nd[14];
                            dnextpre.dThu3 = nd[15];
                            dnextpre.dFri3 = nd[16];
                            dnextpre.dSat3 = nd[17];
                            //4
                            dnextpre.dSun4 = nd[18];
                            dnextpre.dMon4 = nd[19];
                            dnextpre.dTue4 = nd[20];
                            dnextpre.dWed4 = nd[21];
                            dnextpre.dThu4 = nd[22];
                            dnextpre.dFri4 = nd[23];
                            dnextpre.dSat4 = nd[24];
                            //5
                            dnextpre.dSun5 = nd[25];
                            dnextpre.dMon5 = nd[26];
                            dnextpre.dTue5 = nd[27];
                            dnextpre.dWed5 = nd[28];
                            dnextpre.dThu5 = nd[29];
                            dnextpre.dFri5 = nd[30];
                            //After
                            dnextpre.dSat5 = after.dSat5;
                            dnextpre.dSun6 = after.dSun6;
                            dnextpre.dMon6 = after.dMon6;
                            dnextpre.dTue6 = after.dTue6;
                            dnextpre.dWed6 = after.dWed6;
                            dnextpre.dThu6 = after.dThu6;
                            dnextpre.dFri6 = after.dFri6;
                            dnextpre.dSat6 = after.dSat6;
                        }
                        else if (totalday == 30)
                        {
                            //Before
                            dnextpre.dSun1 = before.dSun1;
                            dnextpre.dMon1 = before.dMon1;
                            dnextpre.dTue1 = before.dTue1;
                            //Center
                            dnextpre.dWed1 = nd[0];
                            dnextpre.dThu1 = nd[1];
                            dnextpre.dFri1 = nd[2];
                            dnextpre.dSat1 = nd[3];
                            //2
                            dnextpre.dSun2 = nd[4];
                            dnextpre.dMon2 = nd[5];
                            dnextpre.dTue2 = nd[6];
                            dnextpre.dWed2 = nd[7];
                            dnextpre.dThu2 = nd[8];
                            dnextpre.dFri2 = nd[9];
                            dnextpre.dSat2 = nd[10];
                            //3
                            dnextpre.dSun3 = nd[11];
                            dnextpre.dMon3 = nd[12];
                            dnextpre.dTue3 = nd[13];
                            dnextpre.dWed3 = nd[14];
                            dnextpre.dThu3 = nd[15];
                            dnextpre.dFri3 = nd[16];
                            dnextpre.dSat3 = nd[17];
                            //4
                            dnextpre.dSun4 = nd[18];
                            dnextpre.dMon4 = nd[19];
                            dnextpre.dTue4 = nd[20];
                            dnextpre.dWed4 = nd[21];
                            dnextpre.dThu4 = nd[22];
                            dnextpre.dFri4 = nd[23];
                            dnextpre.dSat4 = nd[24];
                            //5
                            dnextpre.dSun5 = nd[25];
                            dnextpre.dMon5 = nd[26];
                            dnextpre.dTue5 = nd[27];
                            dnextpre.dWed5 = nd[28];
                            dnextpre.dThu5 = nd[29];
                            //After
                            dnextpre.dFri5 = after.dFri5;
                            dnextpre.dSat5 = after.dSat5;
                            dnextpre.dSun6 = after.dSun6;
                            dnextpre.dMon6 = after.dMon6;
                            dnextpre.dTue6 = after.dTue6;
                            dnextpre.dWed6 = after.dWed6;
                            dnextpre.dThu6 = after.dThu6;
                            dnextpre.dFri6 = after.dFri6;
                            dnextpre.dSat6 = after.dSat6;
                        }
                        else if (totalday == 29)
                        {
                            //Before
                            dnextpre.dSun1 = before.dSun1;
                            dnextpre.dMon1 = before.dMon1;
                            dnextpre.dTue1 = before.dTue1;
                            //Center
                            dnextpre.dWed1 = nd[0];
                            dnextpre.dThu1 = nd[1];
                            dnextpre.dFri1 = nd[2];
                            dnextpre.dSat1 = nd[3];
                            //2
                            dnextpre.dSun2 = nd[4];
                            dnextpre.dMon2 = nd[5];
                            dnextpre.dTue2 = nd[6];
                            dnextpre.dWed2 = nd[7];
                            dnextpre.dThu2 = nd[8];
                            dnextpre.dFri2 = nd[9];
                            dnextpre.dSat2 = nd[10];
                            //3
                            dnextpre.dSun3 = nd[11];
                            dnextpre.dMon3 = nd[12];
                            dnextpre.dTue3 = nd[13];
                            dnextpre.dWed3 = nd[14];
                            dnextpre.dThu3 = nd[15];
                            dnextpre.dFri3 = nd[16];
                            dnextpre.dSat3 = nd[17];
                            //4
                            dnextpre.dSun4 = nd[18];
                            dnextpre.dMon4 = nd[19];
                            dnextpre.dTue4 = nd[20];
                            dnextpre.dWed4 = nd[21];
                            dnextpre.dThu4 = nd[22];
                            dnextpre.dFri4 = nd[23];
                            dnextpre.dSat4 = nd[24];
                            //5
                            dnextpre.dSun5 = nd[25];
                            dnextpre.dMon5 = nd[26];
                            dnextpre.dTue5 = nd[27];
                            dnextpre.dWed5 = nd[28];
                            //After
                            dnextpre.dThu5 = after.dThu5;
                            dnextpre.dFri5 = after.dFri5;
                            dnextpre.dSat5 = after.dSat5;
                            dnextpre.dSun6 = after.dSun6;
                            dnextpre.dMon6 = after.dMon6;
                            dnextpre.dTue6 = after.dTue6;
                            dnextpre.dWed6 = after.dWed6;
                            dnextpre.dThu6 = after.dThu6;
                            dnextpre.dFri6 = after.dFri6;
                            dnextpre.dSat6 = after.dSat6;
                        }
                        else if (totalday == 28)
                        {
                            //Before
                            dnextpre.dSun1 = before.dSun1;
                            dnextpre.dMon1 = before.dMon1;
                            dnextpre.dTue1 = before.dTue1;
                            //Center
                            dnextpre.dWed1 = nd[0];
                            dnextpre.dThu1 = nd[1];
                            dnextpre.dFri1 = nd[2];
                            dnextpre.dSat1 = nd[3];
                            //2
                            dnextpre.dSun2 = nd[4];
                            dnextpre.dMon2 = nd[5];
                            dnextpre.dTue2 = nd[6];
                            dnextpre.dWed2 = nd[7];
                            dnextpre.dThu2 = nd[8];
                            dnextpre.dFri2 = nd[9];
                            dnextpre.dSat2 = nd[10];
                            //3
                            dnextpre.dSun3 = nd[11];
                            dnextpre.dMon3 = nd[12];
                            dnextpre.dTue3 = nd[13];
                            dnextpre.dWed3 = nd[14];
                            dnextpre.dThu3 = nd[15];
                            dnextpre.dFri3 = nd[16];
                            dnextpre.dSat3 = nd[17];
                            //4
                            dnextpre.dSun4 = nd[18];
                            dnextpre.dMon4 = nd[19];
                            dnextpre.dTue4 = nd[20];
                            dnextpre.dWed4 = nd[21];
                            dnextpre.dThu4 = nd[22];
                            dnextpre.dFri4 = nd[23];
                            dnextpre.dSat4 = nd[24];
                            //5
                            dnextpre.dSun5 = nd[25];
                            dnextpre.dMon5 = nd[26];
                            dnextpre.dTue5 = nd[27];
                            //After
                            dnextpre.dWed5 = after.dWed5;
                            dnextpre.dThu5 = after.dThu5;
                            dnextpre.dFri5 = after.dFri5;
                            dnextpre.dSat5 = after.dSat5;
                            dnextpre.dSun6 = after.dSun6;
                            dnextpre.dMon6 = after.dMon6;
                            dnextpre.dTue6 = after.dTue6;
                            dnextpre.dWed6 = after.dWed6;
                            dnextpre.dThu6 = after.dThu6;
                            dnextpre.dFri6 = after.dFri6;
                            dnextpre.dSat6 = after.dSat6;


                        }
                        break;
                    case "Thursday":
                        if (totalday == 31)
                        {
                            //Before
                            dnextpre.dSun1 = before.dSun1;
                            dnextpre.dMon1 = before.dMon1;
                            dnextpre.dTue1 = before.dTue1;
                            dnextpre.dWed1 = before.dWed1;
                            //Center
                            dnextpre.dThu1 = nd[0];
                            dnextpre.dFri1 = nd[1];
                            dnextpre.dSat1 = nd[2];
                            //2
                            dnextpre.dSun2 = nd[3];
                            dnextpre.dMon2 = nd[4];
                            dnextpre.dTue2 = nd[5];
                            dnextpre.dWed2 = nd[6];
                            dnextpre.dThu2 = nd[7];
                            dnextpre.dFri2 = nd[8];
                            dnextpre.dSat2 = nd[9];
                            //3
                            dnextpre.dSun3 = nd[10];
                            dnextpre.dMon3 = nd[11];
                            dnextpre.dTue3 = nd[12];
                            dnextpre.dWed3 = nd[13];
                            dnextpre.dThu3 = nd[14];
                            dnextpre.dFri3 = nd[15];
                            dnextpre.dSat3 = nd[16];
                            //4
                            dnextpre.dSun4 = nd[17];
                            dnextpre.dMon4 = nd[18];
                            dnextpre.dTue4 = nd[19];
                            dnextpre.dWed4 = nd[20];
                            dnextpre.dThu4 = nd[21];
                            dnextpre.dFri4 = nd[22];
                            dnextpre.dSat4 = nd[23];
                            //5
                            dnextpre.dSun5 = nd[24];
                            dnextpre.dMon5 = nd[25];
                            dnextpre.dTue5 = nd[26];
                            dnextpre.dWed5 = nd[27];
                            dnextpre.dThu5 = nd[28];
                            dnextpre.dFri5 = nd[29];
                            dnextpre.dSat5 = nd[30];
                            //After
                            dnextpre.dSun6 = after.dSun6;
                            dnextpre.dMon6 = after.dMon6;
                            dnextpre.dTue6 = after.dTue6;
                            dnextpre.dWed6 = after.dWed6;
                            dnextpre.dThu6 = after.dThu6;
                            dnextpre.dFri6 = after.dFri6;
                            dnextpre.dSat6 = after.dSat6;
                        }
                        else if (totalday == 30)
                        {
                            //Before
                            dnextpre.dSun1 = before.dSun1;
                            dnextpre.dMon1 = before.dMon1;
                            dnextpre.dTue1 = before.dTue1;
                            dnextpre.dWed1 = before.dWed1;
                            //Center
                            dnextpre.dThu1 = nd[0];
                            dnextpre.dFri1 = nd[1];
                            dnextpre.dSat1 = nd[2];
                            //2
                            dnextpre.dSun2 = nd[3];
                            dnextpre.dMon2 = nd[4];
                            dnextpre.dTue2 = nd[5];
                            dnextpre.dWed2 = nd[6];
                            dnextpre.dThu2 = nd[7];
                            dnextpre.dFri2 = nd[8];
                            dnextpre.dSat2 = nd[9];
                            //3
                            dnextpre.dSun3 = nd[10];
                            dnextpre.dMon3 = nd[11];
                            dnextpre.dTue3 = nd[12];
                            dnextpre.dWed3 = nd[13];
                            dnextpre.dThu3 = nd[14];
                            dnextpre.dFri3 = nd[15];
                            dnextpre.dSat3 = nd[16];
                            //4
                            dnextpre.dSun4 = nd[17];
                            dnextpre.dMon4 = nd[18];
                            dnextpre.dTue4 = nd[19];
                            dnextpre.dWed4 = nd[20];
                            dnextpre.dThu4 = nd[21];
                            dnextpre.dFri4 = nd[22];
                            dnextpre.dSat4 = nd[23];
                            //5
                            dnextpre.dSun5 = nd[24];
                            dnextpre.dMon5 = nd[25];
                            dnextpre.dTue5 = nd[26];
                            dnextpre.dWed5 = nd[27];
                            dnextpre.dThu5 = nd[28];
                            dnextpre.dFri5 = nd[29];
                            //After
                            dnextpre.dSat5 = after.dSat5;
                            dnextpre.dSun6 = after.dSun6;
                            dnextpre.dMon6 = after.dMon6;
                            dnextpre.dTue6 = after.dTue6;
                            dnextpre.dWed6 = after.dWed6;
                            dnextpre.dThu6 = after.dThu6;
                            dnextpre.dFri6 = after.dFri6;
                            dnextpre.dSat6 = after.dSat6;
                        }
                        else if (totalday == 29)
                        {
                            //Before
                            dnextpre.dSun1 = before.dSun1;
                            dnextpre.dMon1 = before.dMon1;
                            dnextpre.dTue1 = before.dTue1;
                            dnextpre.dWed1 = before.dWed1;
                            //Center
                            dnextpre.dThu1 = nd[0];
                            dnextpre.dFri1 = nd[1];
                            dnextpre.dSat1 = nd[2];
                            //2
                            dnextpre.dSun2 = nd[3];
                            dnextpre.dMon2 = nd[4];
                            dnextpre.dTue2 = nd[5];
                            dnextpre.dWed2 = nd[6];
                            dnextpre.dThu2 = nd[7];
                            dnextpre.dFri2 = nd[8];
                            dnextpre.dSat2 = nd[9];
                            //3
                            dnextpre.dSun3 = nd[10];
                            dnextpre.dMon3 = nd[11];
                            dnextpre.dTue3 = nd[12];
                            dnextpre.dWed3 = nd[13];
                            dnextpre.dThu3 = nd[14];
                            dnextpre.dFri3 = nd[15];
                            dnextpre.dSat3 = nd[16];
                            //4
                            dnextpre.dSun4 = nd[17];
                            dnextpre.dMon4 = nd[18];
                            dnextpre.dTue4 = nd[19];
                            dnextpre.dWed4 = nd[20];
                            dnextpre.dThu4 = nd[21];
                            dnextpre.dFri4 = nd[22];
                            dnextpre.dSat4 = nd[23];
                            //5
                            dnextpre.dSun5 = nd[24];
                            dnextpre.dMon5 = nd[25];
                            dnextpre.dTue5 = nd[26];
                            dnextpre.dWed5 = nd[27];
                            dnextpre.dThu5 = nd[28];
                            //After
                            dnextpre.dFri5 = after.dFri5;
                            dnextpre.dSat5 = after.dSat5;
                            dnextpre.dSun6 = after.dSun6;
                            dnextpre.dMon6 = after.dMon6;
                            dnextpre.dTue6 = after.dTue6;
                            dnextpre.dWed6 = after.dWed6;
                            dnextpre.dThu6 = after.dThu6;
                            dnextpre.dFri6 = after.dFri6;
                            dnextpre.dSat6 = after.dSat6;
                        }
                        else if (totalday == 28)
                        {
                            //Before
                            dnextpre.dSun1 = before.dSun1;
                            dnextpre.dMon1 = before.dMon1;
                            dnextpre.dTue1 = before.dTue1;
                            dnextpre.dWed1 = before.dWed1;
                            //Center
                            dnextpre.dThu1 = nd[0];
                            dnextpre.dFri1 = nd[1];
                            dnextpre.dSat1 = nd[2];
                            //2
                            dnextpre.dSun2 = nd[3];
                            dnextpre.dMon2 = nd[4];
                            dnextpre.dTue2 = nd[5];
                            dnextpre.dWed2 = nd[6];
                            dnextpre.dThu2 = nd[7];
                            dnextpre.dFri2 = nd[8];
                            dnextpre.dSat2 = nd[9];
                            //3
                            dnextpre.dSun3 = nd[10];
                            dnextpre.dMon3 = nd[11];
                            dnextpre.dTue3 = nd[12];
                            dnextpre.dWed3 = nd[13];
                            dnextpre.dThu3 = nd[14];
                            dnextpre.dFri3 = nd[15];
                            dnextpre.dSat3 = nd[16];
                            //4
                            dnextpre.dSun4 = nd[17];
                            dnextpre.dMon4 = nd[18];
                            dnextpre.dTue4 = nd[19];
                            dnextpre.dWed4 = nd[20];
                            dnextpre.dThu4 = nd[21];
                            dnextpre.dFri4 = nd[22];
                            dnextpre.dSat4 = nd[23];
                            //5
                            dnextpre.dSun5 = nd[24];
                            dnextpre.dMon5 = nd[25];
                            dnextpre.dTue5 = nd[26];
                            dnextpre.dWed5 = nd[27];
                            //After
                            dnextpre.dThu5 = after.dThu5;
                            dnextpre.dFri5 = after.dFri5;
                            dnextpre.dSat5 = after.dSat5;
                            dnextpre.dSun6 = after.dSun6;
                            dnextpre.dMon6 = after.dMon6;
                            dnextpre.dTue6 = after.dTue6;
                            dnextpre.dWed6 = after.dWed6;
                            dnextpre.dThu6 = after.dThu6;
                            dnextpre.dFri6 = after.dFri6;
                            dnextpre.dSat6 = after.dSat6;
                        }
                        break;
                    case "Friday":
                        if (totalday == 31)
                        {
                            //Before
                            dnextpre.dSun1 = before.dSun1;
                            dnextpre.dMon1 = before.dMon1;
                            dnextpre.dTue1 = before.dTue1;
                            dnextpre.dWed1 = before.dWed1;
                            dnextpre.dThu1 = before.dThu1;
                            //Center
                            dnextpre.dFri1 = nd[0];
                            dnextpre.dSat1 = nd[1];
                            //2
                            dnextpre.dSun2 = nd[2];
                            dnextpre.dMon2 = nd[3];
                            dnextpre.dTue2 = nd[4];
                            dnextpre.dWed2 = nd[5];
                            dnextpre.dThu2 = nd[6];
                            dnextpre.dFri2 = nd[7];
                            dnextpre.dSat2 = nd[8];
                            //3
                            dnextpre.dSun3 = nd[9];
                            dnextpre.dMon3 = nd[10];
                            dnextpre.dTue3 = nd[11];
                            dnextpre.dWed3 = nd[12];
                            dnextpre.dThu3 = nd[13];
                            dnextpre.dFri3 = nd[14];
                            dnextpre.dSat3 = nd[15];
                            //4
                            dnextpre.dSun4 = nd[16];
                            dnextpre.dMon4 = nd[17];
                            dnextpre.dTue4 = nd[18];
                            dnextpre.dWed4 = nd[19];
                            dnextpre.dThu4 = nd[20];
                            dnextpre.dFri4 = nd[21];
                            dnextpre.dSat4 = nd[22];
                            //5
                            dnextpre.dSun5 = nd[23];
                            dnextpre.dMon5 = nd[24];
                            dnextpre.dTue5 = nd[25];
                            dnextpre.dWed5 = nd[26];
                            dnextpre.dThu5 = nd[27];
                            dnextpre.dFri5 = nd[28];
                            dnextpre.dSat5 = nd[29];
                            dnextpre.dSun6 = nd[30];
                            //After
                            dnextpre.dMon6 = after.dMon6;
                            dnextpre.dTue6 = after.dTue6;
                            dnextpre.dWed6 = after.dWed6;
                            dnextpre.dThu6 = after.dThu6;
                            dnextpre.dFri6 = after.dFri6;
                            dnextpre.dSat6 = after.dSat6;
                        }
                        else if (totalday == 30)
                        {
                            //Before
                            dnextpre.dSun1 = before.dSun1;
                            dnextpre.dMon1 = before.dMon1;
                            dnextpre.dTue1 = before.dTue1;
                            dnextpre.dWed1 = before.dWed1;
                            dnextpre.dThu1 = before.dThu1;
                            //Center
                            dnextpre.dFri1 = nd[0];
                            dnextpre.dSat1 = nd[1];
                            //2
                            dnextpre.dSun2 = nd[2];
                            dnextpre.dMon2 = nd[3];
                            dnextpre.dTue2 = nd[4];
                            dnextpre.dWed2 = nd[5];
                            dnextpre.dThu2 = nd[6];
                            dnextpre.dFri2 = nd[7];
                            dnextpre.dSat2 = nd[8];
                            //3
                            dnextpre.dSun3 = nd[9];
                            dnextpre.dMon3 = nd[10];
                            dnextpre.dTue3 = nd[11];
                            dnextpre.dWed3 = nd[12];
                            dnextpre.dThu3 = nd[13];
                            dnextpre.dFri3 = nd[14];
                            dnextpre.dSat3 = nd[15];
                            //4
                            dnextpre.dSun4 = nd[16];
                            dnextpre.dMon4 = nd[17];
                            dnextpre.dTue4 = nd[18];
                            dnextpre.dWed4 = nd[19];
                            dnextpre.dThu4 = nd[20];
                            dnextpre.dFri4 = nd[21];
                            dnextpre.dSat4 = nd[22];
                            //5
                            dnextpre.dSun5 = nd[23];
                            dnextpre.dMon5 = nd[24];
                            dnextpre.dTue5 = nd[25];
                            dnextpre.dWed5 = nd[26];
                            dnextpre.dThu5 = nd[27];
                            dnextpre.dFri5 = nd[28];
                            dnextpre.dSat5 = nd[29];
                            //After
                            dnextpre.dSun6 = after.dSun6;
                            dnextpre.dMon6 = after.dMon6;
                            dnextpre.dTue6 = after.dTue6;
                            dnextpre.dWed6 = after.dWed6;
                            dnextpre.dThu6 = after.dThu6;
                            dnextpre.dFri6 = after.dFri6;
                            dnextpre.dSat6 = after.dSat6;
                        }
                        else if (totalday == 29)
                        {
                            //Before
                            dnextpre.dSun1 = before.dSun1;
                            dnextpre.dMon1 = before.dMon1;
                            dnextpre.dTue1 = before.dTue1;
                            dnextpre.dWed1 = before.dWed1;
                            dnextpre.dThu1 = before.dThu1;
                            //Center
                            dnextpre.dFri1 = nd[0];
                            dnextpre.dSat1 = nd[1];
                            //2
                            dnextpre.dSun2 = nd[2];
                            dnextpre.dMon2 = nd[3];
                            dnextpre.dTue2 = nd[4];
                            dnextpre.dWed2 = nd[5];
                            dnextpre.dThu2 = nd[6];
                            dnextpre.dFri2 = nd[7];
                            dnextpre.dSat2 = nd[8];
                            //3
                            dnextpre.dSun3 = nd[9];
                            dnextpre.dMon3 = nd[10];
                            dnextpre.dTue3 = nd[11];
                            dnextpre.dWed3 = nd[12];
                            dnextpre.dThu3 = nd[13];
                            dnextpre.dFri3 = nd[14];
                            dnextpre.dSat3 = nd[15];
                            //4
                            dnextpre.dSun4 = nd[16];
                            dnextpre.dMon4 = nd[17];
                            dnextpre.dTue4 = nd[18];
                            dnextpre.dWed4 = nd[19];
                            dnextpre.dThu4 = nd[20];
                            dnextpre.dFri4 = nd[21];
                            dnextpre.dSat4 = nd[22];
                            //5
                            dnextpre.dSun5 = nd[23];
                            dnextpre.dMon5 = nd[24];
                            dnextpre.dTue5 = nd[25];
                            dnextpre.dWed5 = nd[26];
                            dnextpre.dThu5 = nd[27];
                            dnextpre.dFri5 = nd[28];
                            //After
                            dnextpre.dSat5 = after.dSat4;
                            dnextpre.dSun6 = after.dSun6;
                            dnextpre.dMon6 = after.dMon6;
                            dnextpre.dTue6 = after.dTue6;
                            dnextpre.dWed6 = after.dWed6;
                            dnextpre.dThu6 = after.dThu6;
                            dnextpre.dFri6 = after.dFri6;
                            dnextpre.dSat6 = after.dSat6;
                        }
                        else if (totalday == 28)
                        {
                            //Before
                            dnextpre.dSun1 = before.dSun1;
                            dnextpre.dMon1 = before.dMon1;
                            dnextpre.dTue1 = before.dTue1;
                            dnextpre.dWed1 = before.dWed1;
                            dnextpre.dThu1 = before.dThu1;
                            //Center
                            dnextpre.dFri1 = nd[0];
                            dnextpre.dSat1 = nd[1];
                            //2
                            dnextpre.dSun2 = nd[2];
                            dnextpre.dMon2 = nd[3];
                            dnextpre.dTue2 = nd[4];
                            dnextpre.dWed2 = nd[5];
                            dnextpre.dThu2 = nd[6];
                            dnextpre.dFri2 = nd[7];
                            dnextpre.dSat2 = nd[8];
                            //3
                            dnextpre.dSun3 = nd[9];
                            dnextpre.dMon3 = nd[10];
                            dnextpre.dTue3 = nd[11];
                            dnextpre.dWed3 = nd[12];
                            dnextpre.dThu3 = nd[13];
                            dnextpre.dFri3 = nd[14];
                            dnextpre.dSat3 = nd[15];
                            //4
                            dnextpre.dSun4 = nd[16];
                            dnextpre.dMon4 = nd[17];
                            dnextpre.dTue4 = nd[18];
                            dnextpre.dWed4 = nd[19];
                            dnextpre.dThu4 = nd[20];
                            dnextpre.dFri4 = nd[21];
                            dnextpre.dSat4 = nd[22];
                            //5
                            dnextpre.dSun5 = nd[23];
                            dnextpre.dMon5 = nd[24];
                            dnextpre.dTue5 = nd[25];
                            dnextpre.dWed5 = nd[26];
                            dnextpre.dThu5 = nd[27];
                            //After
                            dnextpre.dFri5 = after.dFri4;
                            dnextpre.dSat5 = after.dSat4;
                            dnextpre.dSun6 = after.dSun6;
                            dnextpre.dMon6 = after.dMon6;
                            dnextpre.dTue6 = after.dTue6;
                            dnextpre.dWed6 = after.dWed6;
                            dnextpre.dThu6 = after.dThu6;
                            dnextpre.dFri6 = after.dFri6;
                            dnextpre.dSat6 = after.dSat6;
                        }
                        break;
                    case "Saturday":
                        if (totalday == 31)
                        {
                            //Before
                            dnextpre.dSun1 = before.dSun1;
                            dnextpre.dMon1 = before.dMon1;
                            dnextpre.dTue1 = before.dTue1;
                            dnextpre.dWed1 = before.dWed1;
                            dnextpre.dThu1 = before.dThu1;
                            dnextpre.dFri1 = before.dFri1;
                            //Center
                            dnextpre.dSat1 = nd[0];
                            //2
                            dnextpre.dSun2 = nd[1];
                            dnextpre.dMon2 = nd[2];
                            dnextpre.dTue2 = nd[3];
                            dnextpre.dWed2 = nd[4];
                            dnextpre.dThu2 = nd[5];
                            dnextpre.dFri2 = nd[6];
                            dnextpre.dSat2 = nd[7];
                            //3
                            dnextpre.dSun3 = nd[8];
                            dnextpre.dMon3 = nd[9];
                            dnextpre.dTue3 = nd[10];
                            dnextpre.dWed3 = nd[11];
                            dnextpre.dThu3 = nd[12];
                            dnextpre.dFri3 = nd[13];
                            dnextpre.dSat3 = nd[14];
                            //4
                            dnextpre.dSun4 = nd[15];
                            dnextpre.dMon4 = nd[16];
                            dnextpre.dTue4 = nd[17];
                            dnextpre.dWed4 = nd[18];
                            dnextpre.dThu4 = nd[19];
                            dnextpre.dFri4 = nd[20];
                            dnextpre.dSat4 = nd[21];
                            //5
                            dnextpre.dSun5 = nd[22];
                            dnextpre.dMon5 = nd[23];
                            dnextpre.dTue5 = nd[24];
                            dnextpre.dWed5 = nd[25];
                            dnextpre.dThu5 = nd[26];
                            dnextpre.dFri5 = nd[27];
                            dnextpre.dSat5 = nd[28];
                            dnextpre.dSun6 = nd[29];
                            dnextpre.dMon6 = nd[30];
                            //After
                            dnextpre.dTue6 = after.dTue6;
                            dnextpre.dWed6 = after.dWed6;
                            dnextpre.dThu6 = after.dThu6;
                            dnextpre.dFri6 = after.dFri6;
                            dnextpre.dSat6 = after.dSat6;
                        }
                        else if (totalday == 30)
                        {
                            //Before
                            dnextpre.dSun1 = before.dSun1;
                            dnextpre.dMon1 = before.dMon1;
                            dnextpre.dTue1 = before.dTue1;
                            dnextpre.dWed1 = before.dWed1;
                            dnextpre.dThu1 = before.dThu1;
                            dnextpre.dFri1 = before.dFri1;
                            //Center
                            dnextpre.dSat1 = nd[0];
                            //2
                            dnextpre.dSun2 = nd[1];
                            dnextpre.dMon2 = nd[2];
                            dnextpre.dTue2 = nd[3];
                            dnextpre.dWed2 = nd[4];
                            dnextpre.dThu2 = nd[5];
                            dnextpre.dFri2 = nd[6];
                            dnextpre.dSat2 = nd[7];
                            //3
                            dnextpre.dSun3 = nd[8];
                            dnextpre.dMon3 = nd[9];
                            dnextpre.dTue3 = nd[10];
                            dnextpre.dWed3 = nd[11];
                            dnextpre.dThu3 = nd[12];
                            dnextpre.dFri3 = nd[13];
                            dnextpre.dSat3 = nd[14];
                            //4
                            dnextpre.dSun4 = nd[15];
                            dnextpre.dMon4 = nd[16];
                            dnextpre.dTue4 = nd[17];
                            dnextpre.dWed4 = nd[18];
                            dnextpre.dThu4 = nd[19];
                            dnextpre.dFri4 = nd[20];
                            dnextpre.dSat4 = nd[21];
                            //5
                            dnextpre.dSun5 = nd[22];
                            dnextpre.dMon5 = nd[23];
                            dnextpre.dTue5 = nd[24];
                            dnextpre.dWed5 = nd[25];
                            dnextpre.dThu5 = nd[26];
                            dnextpre.dFri5 = nd[27];
                            dnextpre.dSat5 = nd[28];
                            dnextpre.dSun6 = nd[29];
                            //After
                            dnextpre.dMon6 = after.dMon6;
                            dnextpre.dTue6 = after.dTue6;
                            dnextpre.dWed6 = after.dWed6;
                            dnextpre.dThu6 = after.dThu6;
                            dnextpre.dFri6 = after.dFri6;
                            dnextpre.dSat6 = after.dSat6;
                        }
                        else if (totalday == 29)
                        {
                            //Before
                            dnextpre.dSun1 = before.dSun1;
                            dnextpre.dMon1 = before.dMon1;
                            dnextpre.dTue1 = before.dTue1;
                            dnextpre.dWed1 = before.dWed1;
                            dnextpre.dThu1 = before.dThu1;
                            dnextpre.dFri1 = before.dFri1;
                            //Center
                            dnextpre.dSat1 = nd[0];
                            //2
                            dnextpre.dSun2 = nd[1];
                            dnextpre.dMon2 = nd[2];
                            dnextpre.dTue2 = nd[3];
                            dnextpre.dWed2 = nd[4];
                            dnextpre.dThu2 = nd[5];
                            dnextpre.dFri2 = nd[6];
                            dnextpre.dSat2 = nd[7];
                            //3
                            dnextpre.dSun3 = nd[8];
                            dnextpre.dMon3 = nd[9];
                            dnextpre.dTue3 = nd[10];
                            dnextpre.dWed3 = nd[11];
                            dnextpre.dThu3 = nd[12];
                            dnextpre.dFri3 = nd[13];
                            dnextpre.dSat3 = nd[14];
                            //4
                            dnextpre.dSun4 = nd[15];
                            dnextpre.dMon4 = nd[16];
                            dnextpre.dTue4 = nd[17];
                            dnextpre.dWed4 = nd[18];
                            dnextpre.dThu4 = nd[19];
                            dnextpre.dFri4 = nd[20];
                            dnextpre.dSat4 = nd[21];
                            //5
                            dnextpre.dSun5 = nd[22];
                            dnextpre.dMon5 = nd[23];
                            dnextpre.dTue5 = nd[24];
                            dnextpre.dWed5 = nd[25];
                            dnextpre.dThu5 = nd[26];
                            dnextpre.dFri5 = nd[27];
                            dnextpre.dSat5 = nd[28];
                            //After
                            dnextpre.dSun6 = after.dSun6;
                            dnextpre.dMon6 = after.dMon6;
                            dnextpre.dTue6 = after.dTue6;
                            dnextpre.dWed6 = after.dWed6;
                            dnextpre.dThu6 = after.dThu6;
                            dnextpre.dFri6 = after.dFri6;
                            dnextpre.dSat6 = after.dSat6;
                        }
                        else if (totalday == 28)
                        {
                            //Before
                            dnextpre.dSun1 = before.dSun1;
                            dnextpre.dMon1 = before.dMon1;
                            dnextpre.dTue1 = before.dTue1;
                            dnextpre.dWed1 = before.dWed1;
                            dnextpre.dThu1 = before.dThu1;
                            dnextpre.dFri1 = before.dFri1;
                            //Center
                            dnextpre.dSat1 = nd[0];
                            //2
                            dnextpre.dSun2 = nd[1];
                            dnextpre.dMon2 = nd[2];
                            dnextpre.dTue2 = nd[3];
                            dnextpre.dWed2 = nd[4];
                            dnextpre.dThu2 = nd[5];
                            dnextpre.dFri2 = nd[6];
                            dnextpre.dSat2 = nd[7];
                            //3
                            dnextpre.dSun3 = nd[8];
                            dnextpre.dMon3 = nd[9];
                            dnextpre.dTue3 = nd[10];
                            dnextpre.dWed3 = nd[11];
                            dnextpre.dThu3 = nd[12];
                            dnextpre.dFri3 = nd[13];
                            dnextpre.dSat3 = nd[14];
                            //4
                            dnextpre.dSun4 = nd[15];
                            dnextpre.dMon4 = nd[16];
                            dnextpre.dTue4 = nd[17];
                            dnextpre.dWed4 = nd[18];
                            dnextpre.dThu4 = nd[19];
                            dnextpre.dFri4 = nd[20];
                            dnextpre.dSat4 = nd[21];
                            //5
                            dnextpre.dSun5 = nd[22];
                            dnextpre.dMon5 = nd[23];
                            dnextpre.dTue5 = nd[24];
                            dnextpre.dWed5 = nd[25];
                            dnextpre.dThu5 = nd[26];
                            dnextpre.dFri5 = nd[27];
                            //After
                            dnextpre.dSat5 = after.dSat5;
                            dnextpre.dSun6 = after.dSun6;
                            dnextpre.dMon6 = after.dMon6;
                            dnextpre.dTue6 = after.dTue6;
                            dnextpre.dWed6 = after.dWed6;
                            dnextpre.dThu6 = after.dThu6;
                            dnextpre.dFri6 = after.dFri6;
                            dnextpre.dSat6 = after.dSat6;
                        }
                        break;
                }
            }


            return dnextpre;
        }


        private static DayinMonth dbefore(DateTime date)
        {
            DayinMonth dim = new DayinMonth();
            string nday = date.DayOfWeek.ToString();


            switch (nday)
            {
                case "Sunday":


                    break;
                case "Monday":
                    DateTime sun1 = date.AddDays(-1);
                    dim.dSun1 = sun1.Day.ToString();

                    break;
                case "Tuesday":
                    DateTime sun2 = date.AddDays(-2);
                    DateTime mon1 = date.AddDays(-1);
                    dim.dSun1 = sun2.Day.ToString();
                    dim.dMon1 = mon1.Day.ToString();


                    break;
                case "Wednesday":
                    DateTime sun3 = date.AddDays(-3);
                    DateTime mon2 = date.AddDays(-2);
                    DateTime tue1 = date.AddDays(-1);
                    dim.dSun1 = sun3.Day.ToString();
                    dim.dMon1 = mon2.Day.ToString();
                    dim.dTue1 = tue1.Day.ToString();

                    break;
                case "Thursday":
                    DateTime sun4 = date.AddDays(-4);
                    DateTime mon3 = date.AddDays(-3);
                    DateTime tue2 = date.AddDays(-2);
                    DateTime wed1 = date.AddDays(-1);
                    dim.dSun1 = sun4.Day.ToString();
                    dim.dMon1 = mon3.Day.ToString();
                    dim.dTue1 = tue2.Day.ToString();
                    dim.dWed1 = wed1.Day.ToString();

                    break;
                case "Friday":
                    DateTime sun5 = date.AddDays(-5);
                    DateTime mon4 = date.AddDays(-4);
                    DateTime tue3 = date.AddDays(-3);
                    DateTime wed2 = date.AddDays(-2);
                    DateTime thu1 = date.AddDays(-1);
                    dim.dSun1 = sun5.Day.ToString();
                    dim.dMon1 = mon4.Day.ToString();
                    dim.dTue1 = tue3.Day.ToString();
                    dim.dWed1 = wed2.Day.ToString();
                    dim.dThu1 = thu1.Day.ToString();

                    break;
                case "Saturday":
                    DateTime sun6 = date.AddDays(-6);
                    DateTime mon5 = date.AddDays(-5);
                    DateTime tue4 = date.AddDays(-4);
                    DateTime wed3 = date.AddDays(-3);
                    DateTime thu2 = date.AddDays(-2);
                    DateTime fri1 = date.AddDays(-1);
                    dim.dSun1 = sun6.Day.ToString();
                    dim.dMon1 = mon5.Day.ToString();
                    dim.dTue1 = tue4.Day.ToString();
                    dim.dWed1 = wed3.Day.ToString();
                    dim.dThu1 = thu2.Day.ToString();
                    dim.dFri1 = fri1.Day.ToString();
                    break;
            }
            return dim;


        }


        private static DayinMonth dafter(DateTime date)
        {
            DayinMonth dam = new DayinMonth();
            string nday = date.DayOfWeek.ToString();
            int totalday = DateTime.DaysInMonth(date.Year, date.Month);

            switch (nday)
            {
                case "Sunday":
                    if (totalday == 31)
                    {
                        dam.dWed5 = afterday(1);
                        dam.dThu5 = afterday(2);
                        dam.dFri5 = afterday(3);
                        dam.dSat5 = afterday(4);
                        dam.dSun6 = afterday(5);
                        dam.dMon6 = afterday(6);
                        dam.dTue6 = afterday(7);
                        dam.dWed6 = afterday(8);
                        dam.dThu6 = afterday(9);
                        dam.dFri6 = afterday(10);
                        dam.dSat6 = afterday(11);


                    }
                    else if (totalday == 30)
                    {
                        dam.dTue5 = afterday(1);
                        dam.dWed5 = afterday(2);
                        dam.dThu5 = afterday(3);
                        dam.dFri5 = afterday(4);
                        dam.dSat5 = afterday(5);
                        dam.dSun6 = afterday(6);
                        dam.dMon6 = afterday(7);
                        dam.dTue6 = afterday(8);
                        dam.dWed6 = afterday(9);
                        dam.dThu6 = afterday(10);
                        dam.dFri6 = afterday(11);
                        dam.dSat6 = afterday(12);

                    }
                    else if (totalday == 29)
                    {
                        dam.dMon5 = afterday(1);
                        dam.dTue5 = afterday(2);
                        dam.dWed5 = afterday(3);
                        dam.dThu5 = afterday(4);
                        dam.dFri5 = afterday(5);
                        dam.dSat5 = afterday(6);
                        dam.dSun6 = afterday(7);
                        dam.dMon6 = afterday(8);
                        dam.dTue6 = afterday(9);
                        dam.dWed6 = afterday(10);
                        dam.dThu6 = afterday(11);
                        dam.dFri6 = afterday(12);
                        dam.dSat6 = afterday(13);

                    }
                    else if (totalday == 28)
                    {
                        dam.dSun5 = afterday(1);
                        dam.dMon5 = afterday(2);
                        dam.dTue5 = afterday(3);
                        dam.dWed5 = afterday(4);
                        dam.dThu5 = afterday(5);
                        dam.dFri5 = afterday(6);
                        dam.dSat5 = afterday(7);
                        dam.dSun6 = afterday(8);
                        dam.dMon6 = afterday(9);
                        dam.dTue6 = afterday(10);
                        dam.dWed6 = afterday(11);
                        dam.dThu6 = afterday(12);
                        dam.dFri6 = afterday(13);
                        dam.dSat6 = afterday(14);

                    }
                    break;
                case "Monday":
                    if (totalday == 31)
                    {
                        dam.dThu5 = afterday(1);
                        dam.dFri5 = afterday(2);
                        dam.dSat5 = afterday(3);
                        dam.dSun6 = afterday(4);
                        dam.dMon6 = afterday(5);
                        dam.dTue6 = afterday(6);
                        dam.dWed6 = afterday(7);
                        dam.dThu6 = afterday(8);
                        dam.dFri6 = afterday(9);
                        dam.dSat6 = afterday(10);

                    }
                    else if (totalday == 30)
                    {
                        dam.dWed5 = afterday(1);
                        dam.dThu5 = afterday(2);
                        dam.dFri5 = afterday(3);
                        dam.dSat5 = afterday(4);
                        dam.dSun6 = afterday(5);
                        dam.dMon6 = afterday(6);
                        dam.dTue6 = afterday(7);
                        dam.dWed6 = afterday(8);
                        dam.dThu6 = afterday(9);
                        dam.dFri6 = afterday(10);
                        dam.dSat6 = afterday(11);

                    }
                    else if (totalday == 29)
                    {
                        dam.dTue5 = afterday(1);
                        dam.dWed5 = afterday(2);
                        dam.dThu5 = afterday(3);
                        dam.dFri5 = afterday(4);
                        dam.dSat5 = afterday(5);
                        dam.dSun6 = afterday(6);
                        dam.dMon6 = afterday(7);
                        dam.dTue6 = afterday(8);
                        dam.dWed6 = afterday(9);
                        dam.dThu6 = afterday(10);
                        dam.dFri6 = afterday(11);
                        dam.dSat6 = afterday(12);

                    }
                    else if (totalday == 28)
                    {
                        dam.dMon5 = afterday(1);
                        dam.dTue5 = afterday(2);
                        dam.dWed5 = afterday(3);
                        dam.dThu5 = afterday(4);
                        dam.dFri5 = afterday(5);
                        dam.dSat5 = afterday(6);
                        dam.dSun6 = afterday(7);
                        dam.dMon6 = afterday(8);
                        dam.dTue6 = afterday(9);
                        dam.dWed6 = afterday(10);
                        dam.dThu6 = afterday(11);
                        dam.dFri6 = afterday(12);
                        dam.dSat6 = afterday(13);

                    }

                    break;
                case "Tuesday":
                    if (totalday == 31)
                    {
                        dam.dFri5 = afterday(1);
                        dam.dSat5 = afterday(2);
                        dam.dSun6 = afterday(3);
                        dam.dMon6 = afterday(4);
                        dam.dTue6 = afterday(5);
                        dam.dWed6 = afterday(6);
                        dam.dThu6 = afterday(7);
                        dam.dFri6 = afterday(8);
                        dam.dSat6 = afterday(9);

                    }
                    else if (totalday == 30)
                    {
                        dam.dThu5 = afterday(1);
                        dam.dFri5 = afterday(2);
                        dam.dSat5 = afterday(3);
                        dam.dSun6 = afterday(4);
                        dam.dMon6 = afterday(5);
                        dam.dTue6 = afterday(6);
                        dam.dWed6 = afterday(7);
                        dam.dThu6 = afterday(8);
                        dam.dFri6 = afterday(9);
                        dam.dSat6 = afterday(10);

                    }
                    else if (totalday == 29)
                    {
                        dam.dWed5 = afterday(1);
                        dam.dThu5 = afterday(2);
                        dam.dFri5 = afterday(3);
                        dam.dSat5 = afterday(4);
                        dam.dSun6 = afterday(5);
                        dam.dMon6 = afterday(6);
                        dam.dTue6 = afterday(7);
                        dam.dWed6 = afterday(8);
                        dam.dThu6 = afterday(9);
                        dam.dFri6 = afterday(10);
                        dam.dSat6 = afterday(11);

                    }
                    else if (totalday == 28)
                    {
                        dam.dTue5 = afterday(1);
                        dam.dWed5 = afterday(2);
                        dam.dThu5 = afterday(3);
                        dam.dFri5 = afterday(4);
                        dam.dSat5 = afterday(5);
                        dam.dSun6 = afterday(6);
                        dam.dMon6 = afterday(7);
                        dam.dTue6 = afterday(8);
                        dam.dWed6 = afterday(9);
                        dam.dThu6 = afterday(10);
                        dam.dFri6 = afterday(11);
                        dam.dSat6 = afterday(12);

                    }

                    break;
                case "Wednesday":
                    if (totalday == 31)
                    {
                        dam.dSat5 = afterday(1);
                        dam.dSun6 = afterday(2);
                        dam.dMon6 = afterday(3);
                        dam.dTue6 = afterday(4);
                        dam.dWed6 = afterday(5);
                        dam.dThu6 = afterday(6);
                        dam.dFri6 = afterday(7);
                        dam.dSat6 = afterday(8);

                    }
                    else if (totalday == 30)
                    {

                        dam.dFri5 = afterday(1);
                        dam.dSat5 = afterday(2);
                        dam.dSun6 = afterday(3);
                        dam.dMon6 = afterday(4);
                        dam.dTue6 = afterday(5);
                        dam.dWed6 = afterday(6);
                        dam.dThu6 = afterday(7);
                        dam.dFri6 = afterday(8);
                        dam.dSat6 = afterday(9);
                    }
                    else if (totalday == 29)
                    {
                        dam.dThu5 = afterday(1);
                        dam.dFri5 = afterday(2);
                        dam.dSat5 = afterday(3);
                        dam.dSun6 = afterday(4);
                        dam.dMon6 = afterday(5);
                        dam.dTue6 = afterday(6);
                        dam.dWed6 = afterday(7);
                        dam.dThu6 = afterday(8);
                        dam.dFri6 = afterday(9);
                        dam.dSat6 = afterday(10);

                    }
                    else if (totalday == 28)
                    {
                        dam.dWed5 = afterday(1);
                        dam.dThu5 = afterday(2);
                        dam.dFri5 = afterday(3);
                        dam.dSat5 = afterday(4);
                        dam.dSun6 = afterday(5);
                        dam.dMon6 = afterday(6);
                        dam.dTue6 = afterday(7);
                        dam.dWed6 = afterday(8);
                        dam.dThu6 = afterday(9);
                        dam.dFri6 = afterday(10);
                        dam.dSat6 = afterday(11);

                    }

                    break;
                case "Thursday":
                    if (totalday == 31)
                    {
                        dam.dSun6 = afterday(1);
                        dam.dMon6 = afterday(2);
                        dam.dTue6 = afterday(3);
                        dam.dWed6 = afterday(4);
                        dam.dThu6 = afterday(5);
                        dam.dFri6 = afterday(6);
                        dam.dSat6 = afterday(7);

                    }
                    else if (totalday == 30)
                    {
                        dam.dSat5 = afterday(1);
                        dam.dSun6 = afterday(2);
                        dam.dMon6 = afterday(3);
                        dam.dTue6 = afterday(4);
                        dam.dWed6 = afterday(5);
                        dam.dThu6 = afterday(6);
                        dam.dFri6 = afterday(7);
                        dam.dSat6 = afterday(8);

                    }
                    else if (totalday == 29)
                    {

                        dam.dFri5 = afterday(1);
                        dam.dSat5 = afterday(2);
                        dam.dSun6 = afterday(3);
                        dam.dMon6 = afterday(4);
                        dam.dTue6 = afterday(5);
                        dam.dWed6 = afterday(6);
                        dam.dThu6 = afterday(7);
                        dam.dFri6 = afterday(8);
                        dam.dSat6 = afterday(9);
                    }
                    else if (totalday == 28)
                    {
                        dam.dThu5 = afterday(1);
                        dam.dFri5 = afterday(2);
                        dam.dSat5 = afterday(3);
                        dam.dSun6 = afterday(4);
                        dam.dMon6 = afterday(5);
                        dam.dTue6 = afterday(6);
                        dam.dWed6 = afterday(7);
                        dam.dThu6 = afterday(8);
                        dam.dFri6 = afterday(9);
                        dam.dSat6 = afterday(10);

                    }

                    break;
                case "Friday":
                    if (totalday == 31)
                    {
                        dam.dMon6 = afterday(1);
                        dam.dTue6 = afterday(2);
                        dam.dWed6 = afterday(3);
                        dam.dThu6 = afterday(4);
                        dam.dFri6 = afterday(5);
                        dam.dSat6 = afterday(6);

                    }
                    else if (totalday == 30)
                    {
                        dam.dSun6 = afterday(1);
                        dam.dMon6 = afterday(2);
                        dam.dTue6 = afterday(3);
                        dam.dWed6 = afterday(4);
                        dam.dThu6 = afterday(5);
                        dam.dFri6 = afterday(6);
                        dam.dSat6 = afterday(7);

                    }
                    else if (totalday == 29)
                    {
                        dam.dSat5 = afterday(1);
                        dam.dSun6 = afterday(2);
                        dam.dMon6 = afterday(3);
                        dam.dTue6 = afterday(4);
                        dam.dWed6 = afterday(5);
                        dam.dThu6 = afterday(6);
                        dam.dFri6 = afterday(7);
                        dam.dSat6 = afterday(8);

                    }
                    else if (totalday == 28)
                    {

                        dam.dFri5 = afterday(1);
                        dam.dSat5 = afterday(2);
                        dam.dSun6 = afterday(4);
                        dam.dMon6 = afterday(5);
                        dam.dTue6 = afterday(6);
                        dam.dWed6 = afterday(7);
                        dam.dThu6 = afterday(8);
                        dam.dFri6 = afterday(9);
                        dam.dSat6 = afterday(10);
                    }

                    break;
                case "Saturday":
                    if (totalday == 31)
                    {
                        dam.dTue6 = afterday(1);
                        dam.dWed6 = afterday(2);
                        dam.dThu6 = afterday(3);
                        dam.dFri6 = afterday(4);
                        dam.dSat6 = afterday(5);

                    }
                    else if (totalday == 30)
                    {
                        dam.dMon6 = afterday(1);
                        dam.dTue6 = afterday(2);
                        dam.dWed6 = afterday(3);
                        dam.dThu6 = afterday(4);
                        dam.dFri6 = afterday(5);
                        dam.dSat6 = afterday(6);

                    }
                    else if (totalday == 29)
                    {

                        dam.dSun6 = afterday(1);
                        dam.dMon6 = afterday(2);
                        dam.dTue6 = afterday(3);
                        dam.dWed6 = afterday(4);
                        dam.dThu6 = afterday(5);
                        dam.dFri6 = afterday(6);
                        dam.dSat6 = afterday(7);
                    }
                    else if (totalday == 28)
                    {
                        dam.dSat5 = afterday(1);
                        dam.dSun6 = afterday(2);
                        dam.dMon6 = afterday(3);
                        dam.dTue6 = afterday(4);
                        dam.dWed6 = afterday(5);
                        dam.dThu6 = afterday(6);
                        dam.dFri6 = afterday(7);
                        dam.dSat6 = afterday(8);

                    }
                    break;
            }


            return dam;
        }


    }
}
