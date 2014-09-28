using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TuristApp_v2._03.Model
{
    public class Event
    {
        private String _headLine;
        private String _description;
        private String _openingHour;
        private String _price;
        private String _imagePath;

        public Event()
        {
            _headLine = "";
            _description = "";
            _openingHour = "";
            _price = "";
            _imagePath = "";
        }

        public Event(string headLine, string description, string openingHour, string price, string imagePath)
        {
            _headLine = headLine;
            _description = description;
            _openingHour = openingHour;
            _price = price;
            _imagePath = imagePath;
        }

        public string HeadLine
        {
            get { return _headLine; }
            set { _headLine = value; }
        }

        public string Description
        {
            get { return _description; }
            set { _description = value; }
        }

        public string OpeningHour
        {
            get { return _openingHour; }
            set { _openingHour = value; }
        }

        public string Price
        {
            get { return _price; }
            set { _price = value; }
        }

        public string ImagePath
        {
            get { return _imagePath; }
            set { _imagePath = value; }
        }

        public override string ToString()
        {
            return string.Format("HeadLine: {0}, Description: {1}, OpeningHour: {2}, Price: {3}, ImagePath: {4}",
                _headLine, _description, _openingHour, _price, _imagePath);
        }
    }
}
