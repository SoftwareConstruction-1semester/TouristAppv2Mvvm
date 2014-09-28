using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using Windows.UI.Xaml.Controls;
using TuristApp_v2._03.Annotations;
using TuristApp_v2._03.Model;

namespace TuristApp_v2._03.ViewModel
{
    public class MainViewModel:INotifyPropertyChanged
    {
        private Event _event1;
        private Event _event2;
        private Event _event3;
        private Event _event4;

        public static Event ActualEvent { get; set; }

        
        public Event Event1
        {
            get { return _event1; }
            set { _event1 = value; }
        }

        public Event Event2
        {
            get { return _event2; }
            set { _event2 = value; }
        }

        public Event Event3
        {
            get { return _event3; }
            set { _event3 = value; }
        }

        public Event Event4
        {
            get { return _event4; }
            set { _event4 = value; }
        }

        public MainViewModel()
        {
            _event1 = new Event("Roskilde Domkirke", "domkirken er bygget i .....", 
                "åben mellem 10-13 alle dage", "25 Kr", "../assets/billed.jpg");

            _event2 = new Event("Roskilde Kloster", "MunkeKloster .....",
                "åben mellem 10-13 hverdage", "40 Kr", "../assets/billed2.jpg");

            _event3 = new Event("Roskilde Havn", "Havnen er rammen om ....",
                "altid åben", "0 Kr", "../assets/billed3.jpg");

            _event4 = new Event("Vikingeskibs museet", "Vikinge skibsmuseet er et levende museum, der.....",
                "åben mellem 9-15 hverdage", "70 Kr", "../assets/billed4.jpg");
        
            //ActualEvent = _event2;
            
        }

        #region Notify
        public event PropertyChangedEventHandler PropertyChanged;

        [NotifyPropertyChangedInvocator]
        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChangedEventHandler handler = PropertyChanged;
            if (handler != null) handler(this, new PropertyChangedEventArgs(propertyName));
        }

       
        #endregion
    }
}
