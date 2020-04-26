using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace stationMeteo
{
    public class Measure 
    {
        public Byte ID { get; private set; }
        public String measurementType { get; private set; }
        public String units { get; private set; }
        public String format { get; private set; }

        public Byte? minValue { get; private set; }
        public Byte? maxValue { get; private set; }
        public Dictionary<int, Byte> tenLastMeasures { get; set; }
        public Byte? time { get; private set; }

        public Byte? alarmLow { get; set; }
        public Byte? alarmHigh { get; set; }

        public String alarmLowText { get; set; }
        public String alarmHighText { get; set; }


        public Measure(Byte ID, String measurementType, String units, String format ,Byte? minValue, Byte? maxValue, Dictionary<int, Byte> tenLastMeasures, Byte? time, Byte? alarmLow, Byte? alarmHigh )
        {
            this.ID = ID;
            this.measurementType = measurementType;
            this.units = units;
            this.format = format;
            this.minValue = minValue;
            this.maxValue = maxValue;
            this.tenLastMeasures = tenLastMeasures;
            this.time = time;
            this.alarmLow = alarmLow;
            this.alarmHigh = alarmHigh;
        }


        public override String ToString()
        {
            return this.ID + "-"
                + this.measurementType + "-"
                + this.units + "-"
                + this.format + "-"
                + this.minValue + "-"
                + this.maxValue + "]"
                + this.tenLastMeasures + "]"
                + this.time + "]"
                + this.alarmLow + "]"
                + this.alarmHigh + "]";
        }

    }
}
