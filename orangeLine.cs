using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GuiAplication.bl
{
    public class orangeLine
    {
        private string cityName;
        private int fare;
        protected int Tseat;
        protected int seat;
        protected int discount;
        protected string day;

        public string CityName { get => cityName; set => cityName = value; }
        public int Fare { get => fare; set => fare = value; }

        public orangeLine(string city, int fare)
        {
            this.CityName = city;
            this.Fare = fare;
        }
        public orangeLine()
        {
            CityName = string.Empty;
            Fare = 0;
            Tseat = 300;
            discount = 20;
        }
        public orangeLine(string city)
        {
            CityName = city;
        }
        public orangeLine(string sday, int seatNO, string city)
        {
            CityName = city;
            day = sday;
            seat = seatNO;
            discount = 30;
        }
        public int getRemSeat()
        {
            return Tseat;
        }
        public void setRemSeat(int seat)
        {
            this.Tseat = seat;
        }
        public string getCity()
        {
            return CityName;
        }
        public void setSeat(int seat)
        {
            this.seat = seat;
        }
        public int GetSeat()
        {
            return seat;
        }
        public string getDay()
        {
            return day;
        }
        public int getDiscount()
        {
            return discount;
        }
        public int getFare()
        {
            return Fare;
        }
        public virtual string GetFeedBacker()
        {
            return "";
        }
        public virtual string GetComment()
        {
            return "";
        }
        public virtual int GetFareAmount()
        {
            return 0;
        }
        public virtual void SetFareAmount(int money)
        {

        }
    }
}
