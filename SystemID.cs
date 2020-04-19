using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace stationMeteo
{
    public class SystemID
    {
        public Byte ID {get; private set;}
        public String alarmSource { get; private set; }
        public String alarmDetail { get; private set; }
        public String alarmStatus { get; private set; } 


        public SystemID(Byte ID, String alarmSource, String alarmDetail, String alarmStatus)
        {
            this.ID = ID;
            this.alarmSource = alarmSource;
            this.alarmDetail = alarmDetail;
            this.alarmStatus = alarmStatus;
        }
    }
}
