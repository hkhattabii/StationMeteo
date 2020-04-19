using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace stationMeteo
{
    class Tram
    {
        public static readonly Random random = new Random();
        public  Byte firstByte { get; private set; }
        public  Byte secondByte { get; private set; }
        public  Byte thirdByte { get; private set; }
        public  Byte ID { get; private set; }
        public int value { get; private set; }



        public Tram(Byte ID, int value)
        {
            this.firstByte = 0xaa;
            this.secondByte = 0x55;
            this.thirdByte = 0xaa;
            this.ID = ID;
            this.value = value;
        }




        public override String ToString()
        {
            return "[0xaa-0x55-0xaa-"
                + this.ID + "-"
                + this.value + "-";
        }
    }
}
