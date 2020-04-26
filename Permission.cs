using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace stationMeteo
{
    public class Permission
    {
        public int ID { get; set; }
        public String name { get; set; }
        public Boolean allowCreateID { get; set; }
        public Boolean allowDestroyID { get; set; }
        public Boolean allowConfigAlarm { get; set; }
        public Boolean allowUserCreation { get; set; }


        public Permission(Dictionary<String, Object> json)
        {
            this.ID = int.Parse(json["permissionID"].ToString());
            this.name = json["name"].ToString();
            this.allowCreateID = (bool) json["allowCreateID"];
            this.allowDestroyID = (bool) json["allowDestroyID"];
            this.allowConfigAlarm = (bool) json["allowConfigAlarm"];
            this.allowUserCreation = (bool)json["allowUserCreation"];
        }


        public override String ToString()
        {
            return "[" +
                this.ID + "-" +
                this.name + "-" +
                this.allowCreateID + "-" +
                this.allowDestroyID + "-" +
                this.allowConfigAlarm + "-" +
                this.allowUserCreation + "]";
        }
    }
}
