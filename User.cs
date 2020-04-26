using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace stationMeteo
{
    public class User
    {
        public int ID {get; set;}
        public String username { get; set; }
        public String password { get; set; }
        public Permission permission { get; set; }

        public User(Dictionary<String, Object> json)
        {
            this.ID = int.Parse(json["ID"].ToString());
            this.username = json["username"].ToString();
            this.password = json["password"].ToString();
            this.permission = new Permission((Dictionary<String, Object>)json["permission"]);
        }



        public override String ToString()
        {
            return "[" + 
                this.ID + "-" + 
                this.username + "-" + 
                this.password + "-" + 
                this.permission + "]";



        }






    }



}
